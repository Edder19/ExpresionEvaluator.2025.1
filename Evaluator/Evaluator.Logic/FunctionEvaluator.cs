using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Evaluator.Logic
{

    public class FunctionEvaluator
    {
        public static double Evalute(string infix)
        {
            var postfix = ToPostfix(infix);
            return Calculate(postfix);
        }

        private static double Calculate(string postfix)
        {
            var stack = new Stack<double>();
            var tokens = postfix.Split(' ');

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else if (IsOperator(token[0]))
                {
                    double operator2 = stack.Pop();
                    double operator1 = stack.Pop();
                    stack.Push(Result(operator1, token[0], operator2));
                }
            }
            return stack.Pop();
        }

        private static double Result(double operator1, char item, double operator2)
        {
            return item switch
            {
                '+' => operator1 + operator2,
                '-' => operator1 - operator2,
                '*' => operator1 * operator2,
                '/' => operator1 / operator2,
                '^' => Math.Pow(operator1, operator2),
                _ => throw new Exception("Invalid expression"),
            };
        }

        private static string ToPostfix(string infix)
        {
            var stack = new Stack<char>();
            var postfix = new List<string>();
            var number = "";

            foreach (var item in infix)
            {
                if (char.IsDigit(item) || item == '.')
                {
                    number += item;
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        postfix.Add(number);
                        number = "";
                    }

                    if (IsOperator(item))
                    {
                        while (stack.Count > 0 && PriorityStack(stack.Peek()) >= PriorityExpression(item))
                        {
                            postfix.Add(stack.Pop().ToString());
                        }
                        stack.Push(item);
                    }
                }
            }

            if (!string.IsNullOrEmpty(number))
            {
                postfix.Add(number);
            }

            while (stack.Count > 0)
            {
                postfix.Add(stack.Pop().ToString());
            }

            return string.Join(" ", postfix);
        }

        private static int PriorityStack(char item)
        {
            return item switch
            {
                '^' => 3,
                '*' => 2,
                '/' => 2,
                '+' => 1,
                '-' => 1,
                '(' => 0,
                _ => throw new Exception("Invalid expression."),
            };
        }

        private static int PriorityExpression(char item)
        {
            return item switch
            {
                '^' => 4,
                '*' => 2,
                '/' => 2,
                '+' => 1,
                '-' => 1,
                '(' => 5,
                _ => throw new Exception("Invalid expression."),
            };
        }

        private static bool IsOperator(char item) => "()^*/+-".IndexOf(item) >= 0;
    }

}
