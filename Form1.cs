namespace PTSecondLabSecondTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    class Logic
    {
        public static int GetSumOfNumbersInText(string inputText)
        {
            int currentNumber = 0;
            char currentSign = '+';

            int numberMultiplier;
            int textNumbersSum = 0;

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
