namespace WinFormsApp1i_307a
{
    partial class Calculator
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
            zero = new Button();
            comma = new Button();
            plus = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            clear = new Button();
            clear_enter = new Button();
            del = new Button();
            divide = new Button();
            multiply = new Button();
            minus = new Button();
            percent = new Button();
            oneslashx = new Button();
            smooth = new Button();
            plusorminus = new Button();
            root = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // zero
            // 
            zero.Location = new Point(16, 255);
            zero.Name = "zero";
            zero.Size = new Size(98, 44);
            zero.TabIndex = 0;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += btnNumdersAction_Click;
            // 
            // comma
            // 
            comma.Location = new Point(120, 255);
            comma.Name = "comma";
            comma.Size = new Size(46, 44);
            comma.TabIndex = 1;
            comma.Text = ",";
            comma.UseVisualStyleBackColor = true;
            comma.Click += btnNumdersAction_Click;
            // 
            // plus
            // 
            plus.Location = new Point(172, 255);
            plus.Name = "plus";
            plus.Size = new Size(46, 44);
            plus.TabIndex = 2;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            three.Location = new Point(120, 205);
            three.Name = "three";
            three.Size = new Size(46, 44);
            three.TabIndex = 5;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += btnNumdersAction_Click;
            // 
            // two
            // 
            two.Location = new Point(68, 205);
            two.Name = "two";
            two.Size = new Size(46, 44);
            two.TabIndex = 4;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += btnNumdersAction_Click;
            // 
            // one
            // 
            one.Location = new Point(16, 205);
            one.Name = "one";
            one.Size = new Size(46, 44);
            one.TabIndex = 3;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += btnNumdersAction_Click;
            // 
            // six
            // 
            six.Location = new Point(120, 155);
            six.Name = "six";
            six.Size = new Size(46, 44);
            six.TabIndex = 8;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += btnNumdersAction_Click;
            // 
            // five
            // 
            five.Location = new Point(68, 155);
            five.Name = "five";
            five.Size = new Size(46, 44);
            five.TabIndex = 7;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += btnNumdersAction_Click;
            // 
            // four
            // 
            four.Location = new Point(16, 155);
            four.Name = "four";
            four.Size = new Size(46, 44);
            four.TabIndex = 6;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += btnNumdersAction_Click;
            // 
            // nine
            // 
            nine.Location = new Point(120, 105);
            nine.Name = "nine";
            nine.Size = new Size(46, 44);
            nine.TabIndex = 11;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += btnNumdersAction_Click;
            // 
            // eight
            // 
            eight.Location = new Point(68, 105);
            eight.Name = "eight";
            eight.Size = new Size(46, 44);
            eight.TabIndex = 10;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += btnNumdersAction_Click;
            // 
            // seven
            // 
            seven.Location = new Point(16, 105);
            seven.Name = "seven";
            seven.Size = new Size(46, 44);
            seven.TabIndex = 9;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += btnNumdersAction_Click;
            // 
            // clear
            // 
            clear.Location = new Point(120, 55);
            clear.Name = "clear";
            clear.Size = new Size(46, 44);
            clear.TabIndex = 14;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            // 
            // clear_enter
            // 
            clear_enter.Location = new Point(68, 55);
            clear_enter.Name = "clear_enter";
            clear_enter.Size = new Size(46, 44);
            clear_enter.TabIndex = 13;
            clear_enter.Text = "CE";
            clear_enter.UseVisualStyleBackColor = true;
            // 
            // del
            // 
            del.Location = new Point(16, 55);
            del.Name = "del";
            del.Size = new Size(46, 44);
            del.TabIndex = 12;
            del.Text = "← ";
            del.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            divide.Location = new Point(172, 105);
            divide.Name = "divide";
            divide.Size = new Size(46, 44);
            divide.TabIndex = 17;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            multiply.Location = new Point(172, 155);
            multiply.Name = "multiply";
            multiply.Size = new Size(46, 44);
            multiply.TabIndex = 16;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Location = new Point(172, 205);
            minus.Name = "minus";
            minus.Size = new Size(46, 44);
            minus.TabIndex = 15;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            // 
            // percent
            // 
            percent.Location = new Point(224, 105);
            percent.Name = "percent";
            percent.Size = new Size(46, 44);
            percent.TabIndex = 20;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = true;
            // 
            // oneslashx
            // 
            oneslashx.Location = new Point(224, 155);
            oneslashx.Name = "oneslashx";
            oneslashx.Size = new Size(46, 44);
            oneslashx.TabIndex = 19;
            oneslashx.Text = "1/x";
            oneslashx.UseVisualStyleBackColor = true;
            // 
            // smooth
            // 
            smooth.Location = new Point(224, 205);
            smooth.Name = "smooth";
            smooth.Size = new Size(46, 94);
            smooth.TabIndex = 18;
            smooth.Text = "=";
            smooth.UseVisualStyleBackColor = true;
            // 
            // plusorminus
            // 
            plusorminus.Location = new Point(171, 55);
            plusorminus.Name = "plusorminus";
            plusorminus.Size = new Size(46, 44);
            plusorminus.TabIndex = 23;
            plusorminus.Text = "±";
            plusorminus.UseVisualStyleBackColor = true;
            // 
            // root
            // 
            root.Location = new Point(224, 55);
            root.Name = "root";
            root.Size = new Size(46, 44);
            root.TabIndex = 22;
            root.Text = "√";
            root.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(16, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(253, 37);
            txtDisplay.TabIndex = 24;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 318);
            Controls.Add(txtDisplay);
            Controls.Add(plusorminus);
            Controls.Add(root);
            Controls.Add(percent);
            Controls.Add(oneslashx);
            Controls.Add(smooth);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(clear);
            Controls.Add(clear_enter);
            Controls.Add(del);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(plus);
            Controls.Add(comma);
            Controls.Add(zero);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button zero;
        private Button comma;
        private Button plus;
        private Button three;
        private Button two;
        private Button one;
        private Button six;
        private Button five;
        private Button four;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button clear;
        private Button clear_enter;
        private Button del;
        private Button divide;
        private Button multiply;
        private Button minus;
        private Button percent;
        private Button oneslashx;
        private Button smooth;
        private Button plusorminus;
        private Button root;
        private TextBox txtDisplay;
    }
}
