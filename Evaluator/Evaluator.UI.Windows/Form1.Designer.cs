namespace Evaluator.UI.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn9 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDot = new Button();
            btnPlus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParentesis = new Button();
            btnPow = new Button();
            btnResultado = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnMenus = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 18F);
            txtDisplay.ForeColor = SystemColors.Info;
            txtDisplay.Location = new Point(37, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(376, 39);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(37, 55);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 73);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(143, 55);
            btn9.Name = "btn9";
            btn9.Size = new Size(44, 73);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(93, 134);
            btn5.Name = "btn5";
            btn5.Size = new Size(45, 73);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(93, 55);
            btn8.Name = "btn8";
            btn8.Size = new Size(44, 73);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(144, 134);
            btn6.Name = "btn6";
            btn6.Size = new Size(43, 73);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(37, 134);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 73);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn0
            // 
            btn0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn0.Font = new Font("Segoe UI", 18F);
            btn0.Location = new Point(37, 292);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 42);
            btn0.TabIndex = 7;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn1.Font = new Font("Segoe UI", 18F);
            btn1.Location = new Point(37, 213);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 73);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn2.Font = new Font("Segoe UI", 18F);
            btn2.Location = new Point(95, 213);
            btn2.Name = "btn2";
            btn2.Size = new Size(43, 73);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn3.Font = new Font("Segoe UI", 18F);
            btn3.Location = new Point(144, 213);
            btn3.Name = "btn3";
            btn3.Size = new Size(43, 73);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnDot
            // 
            btnDot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDot.Font = new Font("Segoe UI", 18F);
            btnDot.Location = new Point(144, 292);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(43, 42);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnPlus
            // 
            btnPlus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F);
            btnPlus.Location = new Point(246, 134);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(47, 73);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click_1;
            // 
            // btnMultiply
            // 
            btnMultiply.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 18F);
            btnMultiply.Location = new Point(193, 134);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(47, 73);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F);
            btnDivide.Location = new Point(193, 55);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(47, 73);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F);
            btnOpenParenthesis.Location = new Point(193, 213);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(47, 73);
            btnOpenParenthesis.TabIndex = 17;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParentesis
            // 
            btnCloseParentesis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCloseParentesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParentesis.Font = new Font("Segoe UI", 18F);
            btnCloseParentesis.Location = new Point(246, 213);
            btnCloseParentesis.Name = "btnCloseParentesis";
            btnCloseParentesis.Size = new Size(47, 73);
            btnCloseParentesis.TabIndex = 16;
            btnCloseParentesis.Text = ")";
            btnCloseParentesis.UseVisualStyleBackColor = false;
            btnCloseParentesis.Click += btnCloseParentesis_Click;
            // 
            // btnPow
            // 
            btnPow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F);
            btnPow.Location = new Point(246, 55);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(47, 73);
            btnPow.TabIndex = 15;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnResultado
            // 
            btnResultado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnResultado.BackColor = Color.FromArgb(255, 128, 0);
            btnResultado.Font = new Font("Segoe UI", 18F);
            btnResultado.Location = new Point(193, 292);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(220, 42);
            btnResultado.TabIndex = 18;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F);
            btnDelete.Location = new Point(299, 55);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 73);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(299, 134);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 73);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnMenus
            // 
            btnMenus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMenus.BackColor = Color.FromArgb(255, 128, 0);
            btnMenus.Font = new Font("Segoe UI", 18F);
            btnMenus.Location = new Point(299, 213);
            btnMenus.Name = "btnMenus";
            btnMenus.Size = new Size(114, 73);
            btnMenus.TabIndex = 21;
            btnMenus.Text = "-";
            btnMenus.UseVisualStyleBackColor = false;
            btnMenus.Click += btnMenus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(437, 351);
            Controls.Add(btnMenus);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnResultado);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnCloseParentesis);
            Controls.Add(btnPow);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btn4);
            Controls.Add(btn6);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Fuction Evaluator ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn9;
        private Button btn5;
        private Button btn8;
        private Button btn6;
        private Button btn4;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDot;
        private Button btnPlus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnOpenParenthesis;
        private Button btnCloseParentesis;
        private Button btnPow;
        private Button btnResultado;
        private Button btnDelete;
        private Button btnClear;
        private Button btnMenus;
    }
}
