using CalculatorUI.Exceptions;
using System;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class CalculatorUI : Form
    {
        private int[] _numbers;
        private string _operationKey;
        private bool isNewOperation = true;
        private bool isOperationSelected = false;

        public CalculatorUI()
        {
            _numbers = new int[2];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            _numbers[0] = Convert.ToInt32(textBox.Text);
            var result = _numbers[0] * -1;
            textBox.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberButtonClick("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberButtonClick("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberButtonClick("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberButtonClick("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberButtonClick("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberButtonClick("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberButtonClick("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberButtonClick("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberButtonClick("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (isOperationSelected)
            {
                textBox.Text = "0";
            }

            if(!(textBox.Text == "0"))
            {
                textBox.Text = textBox.Text + "0";
            }
        }

        private void divitionButton_Click(object sender, EventArgs e)
        {
            OperationButtonClick("/");
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            OperationButtonClick("*");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            OperationButtonClick("-");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            OperationButtonClick("+");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            _numbers = new int[2];
            _operationKey = "";
        }

        private void OperationButtonClick(string operationKey)
        {
            _numbers[0] = Convert.ToInt32(textBox.Text);
            _operationKey = operationKey;
            isOperationSelected = true;
        }

        private void NumberButtonClick(string number)
        {
            if (textBox.Text == "0" || isNewOperation || isOperationSelected)
            {
                textBox.Text = number;
                isNewOperation = false;
                isOperationSelected = false;
            }
            else
            {
                textBox.Text = textBox.Text + number;
            }
        }

        private async void equalButton_Click(object sender, EventArgs e)
        {
            if (isNewOperation)
            {
                return;
            }

            try
            {
                _numbers[1] = Convert.ToInt32(textBox.Text);
            }
            catch (Exception)
            {
                return;
            }

            var operation = MathOperationFactory.GetMathOperation(_operationKey);
            decimal result;

            try
            {
                result = await operation.Calculate(_numbers);
            }
            catch(MathOperationException ex)
            {
                textBox.Text = ex.Message;
                _numbers = new int[2];
                return;
            }

            isNewOperation = true;
            textBox.Text = result.ToString();
        }

        private void fibButton_Click(object sender, EventArgs e)
        {
            var operation = MathOperationFactory.GetMathOperation("fib");

            _numbers[0] = Convert.ToInt32(textBox.Text);

            textBox.Text = operation.Calculate(_numbers).Result.ToString();
            isNewOperation = true;
        }
    }
}
