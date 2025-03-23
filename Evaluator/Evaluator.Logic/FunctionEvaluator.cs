using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Evaluator.Logic
{
    public class FunctionEvaluator
    {
        public static double Evaluate(string infix)
        {
            var postfix = ToPostfix(infix);
            return Calculate(postfix);
        }

        private static double Calculate(List<string> postfix)
        {
            var stack = new Stack<double>();
            foreach (var item in postfix)
            {
                if (double.TryParse(item, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    stack.Push(number);
                }
                else if (IsOperator(item))
                {
                    var operator2 = stack.Pop();
                    var operator1 = stack.Pop();
                    stack.Push(Result(operator1, item[0], operator2));
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

        private static List<string> ToPostfix(string infix)
        {
            var stack = new Stack<char>();
            var postfix = new List<string>();
            var numberBuffer = new StringBuilder();

            foreach (var item in infix)
            {
                if (char.IsDigit(item) || item == '.')
                {
                    numberBuffer.Append(item);
                }
                else
                {
                    if (numberBuffer.Length > 0)
                    {
                        postfix.Add(numberBuffer.ToString());
                        numberBuffer.Clear();
                    }

                    if (IsOperator(item.ToString()))
                    {
                        if (item == ')')
                        {
                            while (stack.Peek() != '(')
                            {
                                postfix.Add(stack.Pop().ToString());
                            }
                            stack.Pop(); // Eliminar '('
                        }
                        else
                        {
                            while (stack.Count > 0 && PriorityExpression(item) <= PriorityStack(stack.Peek()))
                            {
                                postfix.Add(stack.Pop().ToString());
                            }
                            stack.Push(item);
                        }
                    }
                    else if (item == '(')
                    {
                        stack.Push(item);
                    }
                }
            }

            if (numberBuffer.Length > 0)
            {
                postfix.Add(numberBuffer.ToString());
            }

            while (stack.Count > 0)
            {
                postfix.Add(stack.Pop().ToString());
            }

            return postfix;
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

        private static bool IsOperator(string item) => "()^*/+-".Contains(item);
    }
}
