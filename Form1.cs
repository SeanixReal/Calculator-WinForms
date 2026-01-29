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
                if (CalculatorViewBox.Text.Length > 1)
                {
                    CalculatorViewBox.Text = CalculatorViewBox.Text.Substring(0, CalculatorViewBox.Text.Length - 1);
                }
                else
                {
                    CalculatorViewBox.Text = "0";
                }
                return;
            }

            if (buttonText == "⁺/₋")
            {
                if (CalculatorViewBox.Text == "0" || string.IsNullOrEmpty(CalculatorViewBox.Text))
                {
                    return;
                }

                string expression = CalculatorViewBox.Text;
                string lastNumber = GetLastNumber(expression);
                
                if (!string.IsNullOrEmpty(lastNumber))
                {
                    string newNumber;
                    if (lastNumber.StartsWith("-"))
                    {
                        newNumber = lastNumber.Substring(1);
                    }
                    else
                    {
                        newNumber = "-" + lastNumber;
                    }
                    
                    int lastIndex = expression.LastIndexOf(lastNumber);
                    if (lastIndex >= 0)
                    {
                        CalculatorViewBox.Text = expression.Substring(0, lastIndex) + newNumber;
                    }
                }
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

                if (resultValue % 1 == 0)
                {
                    CalculatorViewBox.Text = resultValue.ToString("0");
                }
                else
                {
                    CalculatorViewBox.Text = resultValue.ToString("G");
                }

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
                return string.Empty;
            }

            int i = expression.Length - 1;
            
            while (i >= 0 && IsOperatorChar(expression[i]))
            {
                i--;
            }

            int endIndex = i;
            
            while (i >= 0 && (char.IsDigit(expression[i]) || expression[i] == '.'))
            {
                i--;
            }

            if (i >= 0 && expression[i] == '-')
            {
                if (i == 0 || IsOperatorChar(expression[i - 1]))
                {
                    i--;
                }
            }

            if (endIndex >= 0 && i < endIndex)
            {
                return expression.Substring(i + 1, endIndex - i);
            }

            return string.Empty;
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

                string resultStr;
                if (result % 1 == 0)
                {
                    resultStr = result.ToString("0");
                }
                else
                {
                    resultStr = result.ToString("G");
                }

                int lastIndex = expression.LastIndexOf(lastNumber);
                if (lastIndex >= 0)
                {
                    CalculatorViewBox.Text = expression.Substring(0, lastIndex) + resultStr;
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

                string resultStr;
                if (result % 1 == 0)
                {
                    resultStr = result.ToString("0");
                }
                else
                {
                    resultStr = result.ToString("G");
                }

                int lastIndex = expression.LastIndexOf(lastNumber);
                if (lastIndex >= 0)
                {
                    CalculatorViewBox.Text = expression.Substring(0, lastIndex) + resultStr;
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

                string resultStr;
                if (result % 1 == 0)
                {
                    resultStr = result.ToString("0");
                }
                else
                {
                    resultStr = result.ToString("G");
                }

                int lastIndex = expression.LastIndexOf(lastNumber);
                if (lastIndex >= 0)
                {
                    CalculatorViewBox.Text = expression.Substring(0, lastIndex) + resultStr;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
