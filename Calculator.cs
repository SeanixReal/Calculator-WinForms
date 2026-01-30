using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForms
{
    public partial class CalculatorForm : Form
    {
        private bool isNewCalculation = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            CalculatorViewBox.Text = "0";
        }

        private void AppendToTextBox(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (string.IsNullOrEmpty(buttonText))
            {
                return;
            }

            if (buttonText == "AC")
            {
                CalculatorViewBox.Text = "0";
                isNewCalculation = false;
                return;
            }

            if (buttonText == "⌫")
            {
                string text = CalculatorViewBox.Text;
                if (text.Length > 1)
                {
                    CalculatorViewBox.Text = text.Substring(0, text.Length - 1);
                }
                else
                {
                    CalculatorViewBox.Text = "0";
                }
                return;
            }

            if (buttonText == "⁺/₋")
            {
                string text = CalculatorViewBox.Text;
                if (text == "0")
                {
                    return;
                }

                string lastNumber = GetLastNumber(text);
                if (lastNumber == "")
                {
                    return;
                }
                
                string newNumber;
                if (lastNumber.StartsWith("-"))
                {
                    newNumber = lastNumber.Substring(1);
                }
                else
                {
                    newNumber = "-" + lastNumber;
                }
                int lastIndex = text.LastIndexOf(lastNumber);
                CalculatorViewBox.Text = text.Substring(0, lastIndex) + newNumber;
                return;
            }

            if (buttonText == "¹/𝑥")
            {
                ApplyReciprocal();
                return;
            }

            if (buttonText == "𝑥²")
            {
                ApplySquare();
                return;
            }

            if (buttonText == "²√𝑥")
            {
                ApplySquareRoot();
                return;
            }

            if (isNewCalculation)
            {
                if (buttonText.Length == 1 && IsOperatorChar(buttonText[0]))
                {
                    isNewCalculation = false;
                }
                else
                {
                    CalculatorViewBox.Text = "0";
                    isNewCalculation = false;
                }
            }

            if (buttonText == ".")
            {
                string currentNumber = GetLastNumber(CalculatorViewBox.Text);
                
                if (currentNumber.Contains("."))
                {
                    return;
                }

                if (CalculatorViewBox.Text == "0")
                {
                    CalculatorViewBox.Text = "0.";
                    return;
                }

                char lastChar = CalculatorViewBox.Text[CalculatorViewBox.Text.Length - 1];
                if (IsOperatorChar(lastChar))
                {
                    CalculatorViewBox.Text += "0.";
                    return;
                }

                CalculatorViewBox.Text += ".";
                return;
            }

            if (buttonText.Length == 1 && IsOperatorChar(buttonText[0]))
            {
                if (CalculatorViewBox.Text.Length > 0)
                {
                    char lastChar = CalculatorViewBox.Text[CalculatorViewBox.Text.Length - 1];
                    if (IsOperatorChar(lastChar))
                    {
                        CalculatorViewBox.Text = CalculatorViewBox.Text.Substring(0, CalculatorViewBox.Text.Length - 1) + buttonText;
                        return;
                    }
                }
                
                CalculatorViewBox.Text += buttonText;
                return;
            }

            if (char.IsDigit(buttonText[0]))
            {
                if (CalculatorViewBox.Text == "0")
                {
                    CalculatorViewBox.Text = buttonText;
                    return;
                }

                if (CalculatorViewBox.Text.Length >= 1)
                {
                    string lastNumber = GetLastNumber(CalculatorViewBox.Text);

                    if (lastNumber == "0" && buttonText != "0")
                    {
                        int lastIndex = CalculatorViewBox.Text.LastIndexOf("0");
                        CalculatorViewBox.Text = CalculatorViewBox.Text.Substring(0, lastIndex) + buttonText;
                        return;
                    }
                }

                CalculatorViewBox.Text += buttonText;
                return;
            }
        }

        private void CalculateResult(object sender, EventArgs e)
        {
            try
            {
                string expression = CalculatorViewBox.Text;

                if (string.IsNullOrEmpty(expression) || expression == "0")
                {
                    return;
                }

                DataTable dt = new DataTable();
                var result = dt.Compute(expression, string.Empty);

                double resultValue = Convert.ToDouble(result);

                if (double.IsInfinity(resultValue) || double.IsNaN(resultValue))
                {
                    MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CalculatorViewBox.Text = "0";
                    isNewCalculation = false;
                    return;
                }

                CalculatorViewBox.Text = resultValue.ToString();
                isNewCalculation = true;
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid expression format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CalculatorViewBox.Text = "0";
                isNewCalculation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating result: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CalculatorViewBox.Text = "0";
                isNewCalculation = false;
            }
        }

        private string GetLastNumber(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return "";
            }

            int i = expression.Length - 1;

            while (i >= 0 && IsOperatorChar(expression[i]))
            {
                i--;
            }

            if (i < 0)
            {
                return "";
            }

            string lastNumber = "";
            while (i >= 0 && (char.IsDigit(expression[i]) || expression[i] == '.'))
            {
                lastNumber = expression[i] + lastNumber;
                i--;
            }

            if (i >= 0 && expression[i] == '-')
            {
                if (i == 0 || IsOperatorChar(expression[i - 1]))
                {
                    lastNumber = "-" + lastNumber;
                }
            }

            return lastNumber;
        }

        private bool IsOperatorChar(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '%';
        }

        private void ApplyReciprocal()
        {
            try
            {
                string expression = CalculatorViewBox.Text;
                string lastNumber = GetLastNumber(expression);

                if (string.IsNullOrEmpty(lastNumber))
                {
                    return;
                }

                double value = double.Parse(lastNumber);
                double result = 1 / value;

                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int lastIndex = expression.LastIndexOf(lastNumber);
                if (lastIndex >= 0)
                {
                    CalculatorViewBox.Text = expression.Substring(0, lastIndex) + result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySquare()
        {
            try
            {
                string expression = CalculatorViewBox.Text;
                string lastNumber = GetLastNumber(expression);

                if (string.IsNullOrEmpty(lastNumber))
                {
                    return;
                }

                double value = double.Parse(lastNumber);
                double result = value * value;

                int lastIndex = expression.LastIndexOf(lastNumber);
                if (lastIndex >= 0)
                {
                    CalculatorViewBox.Text = expression.Substring(0, lastIndex) + result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySquareRoot()
        {
            try
            {
                string expression = CalculatorViewBox.Text;
                string lastNumber = GetLastNumber(expression);

                if (string.IsNullOrEmpty(lastNumber))
                {
                    return;
                }

                double value = double.Parse(lastNumber);
                double result = Math.Sqrt(value);

                int lastIndex = expression.LastIndexOf(lastNumber);
                if (lastIndex >= 0)
                {
                    CalculatorViewBox.Text = expression.Substring(0, lastIndex) + result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
