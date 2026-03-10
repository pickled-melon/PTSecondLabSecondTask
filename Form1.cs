namespace PTSecondLabSecondTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            inputTextBox.Text = Properties.Settings.Default.inputText;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;

            var result = Logic.GetSumOfNumbersInText(inputText);

            Properties.Settings.Default.inputText = inputText;
            Properties.Settings.Default.Save();

            this.numbersSumLabel.Text = $"Результат арифметического выражения: {result}";
        }
    }

    class Logic
    {
        public static long GetSumOfNumbersInText(string inputText)
        {
            long currentNumber = 0;
            char currentSign = '+';

            long numberMultiplier;
            long textNumbersSum = 0;

            foreach (char c in inputText)
            {
                if (c == '+' || c == '-')
                {
                    numberMultiplier = (currentSign == '-') ? -1 : 1;
                    textNumbersSum += numberMultiplier * currentNumber;
                    currentNumber = 0;
                    currentSign = c;
                }
                else if (c >= '0' && c <= '9')
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }
            }

            numberMultiplier = (currentSign == '-') ? -1 : 1;
            textNumbersSum += numberMultiplier * currentNumber;

            return textNumbersSum;
        }
    }
}
