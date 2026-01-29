namespace Calculator_WinForms
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculatorViewBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculatorViewBox
            // 
            this.CalculatorViewBox.BackColor = System.Drawing.SystemColors.Info;
            this.CalculatorViewBox.Enabled = false;
            this.CalculatorViewBox.Font = new System.Drawing.Font("Aptos Display", 24F);
            this.CalculatorViewBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CalculatorViewBox.Location = new System.Drawing.Point(12, 13);
            this.CalculatorViewBox.Name = "CalculatorViewBox";
            this.CalculatorViewBox.ReadOnly = true;
            this.CalculatorViewBox.Size = new System.Drawing.Size(310, 47);
            this.CalculatorViewBox.TabIndex = 0;
            this.CalculatorViewBox.Text = "HelloWorld";
            this.CalculatorViewBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "©Seanix";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button2.Location = new System.Drawing.Point(249, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "⌫";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Ivory;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button3.Location = new System.Drawing.Point(91, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Ivory;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button4.Location = new System.Drawing.Point(170, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "AC";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Ivory;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button5.Location = new System.Drawing.Point(170, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 51);
            this.button5.TabIndex = 8;
            this.button5.Text = "²√𝑥";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Ivory;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button6.Location = new System.Drawing.Point(91, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 51);
            this.button6.TabIndex = 7;
            this.button6.Text = "𝑥²";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Ivory;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button7.Location = new System.Drawing.Point(249, 127);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 51);
            this.button7.TabIndex = 6;
            this.button7.Text = "/";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Ivory;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button8.Location = new System.Drawing.Point(12, 127);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 51);
            this.button8.TabIndex = 5;
            this.button8.Text = "¹/𝑥";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightYellow;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button9.Location = new System.Drawing.Point(170, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 51);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightYellow;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button10.Location = new System.Drawing.Point(91, 184);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 51);
            this.button10.TabIndex = 11;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Ivory;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button11.Location = new System.Drawing.Point(249, 184);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(73, 51);
            this.button11.TabIndex = 10;
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightYellow;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button12.Location = new System.Drawing.Point(12, 184);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 51);
            this.button12.TabIndex = 9;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightYellow;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button13.Location = new System.Drawing.Point(170, 241);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 51);
            this.button13.TabIndex = 16;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightYellow;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button14.Location = new System.Drawing.Point(91, 241);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 51);
            this.button14.TabIndex = 15;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Ivory;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button15.Location = new System.Drawing.Point(249, 241);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 51);
            this.button15.TabIndex = 14;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightYellow;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button16.Location = new System.Drawing.Point(12, 241);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(73, 51);
            this.button16.TabIndex = 13;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LightYellow;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button17.Location = new System.Drawing.Point(170, 298);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(73, 51);
            this.button17.TabIndex = 20;
            this.button17.Text = "3";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LightYellow;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button18.Location = new System.Drawing.Point(91, 298);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 51);
            this.button18.TabIndex = 19;
            this.button18.Text = "2";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Ivory;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button19.Location = new System.Drawing.Point(249, 298);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(73, 51);
            this.button19.TabIndex = 18;
            this.button19.Text = "+";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LightYellow;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button20.Location = new System.Drawing.Point(12, 298);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(73, 51);
            this.button20.TabIndex = 17;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.LightYellow;
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button21.Location = new System.Drawing.Point(170, 355);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(73, 51);
            this.button21.TabIndex = 24;
            this.button21.Text = ".";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.LightYellow;
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button22.Location = new System.Drawing.Point(91, 355);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(73, 51);
            this.button22.TabIndex = 23;
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Lavender;
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.Font = new System.Drawing.Font("Aptos Display", 12F);
            this.button23.Location = new System.Drawing.Point(249, 355);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(73, 51);
            this.button23.TabIndex = 22;
            this.button23.Text = "=";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.CalculateResult);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.LightYellow;
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.Font = new System.Drawing.Font("Aptos Display", 14F);
            this.button24.Location = new System.Drawing.Point(12, 355);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(73, 51);
            this.button24.TabIndex = 21;
            this.button24.Text = "⁺/₋";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.AppendToTextBox);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(333, 418);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalculatorViewBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Aptos Display", 8.25F);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalculatorViewBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

