namespace Prob8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void btShow_Click(object sender, EventArgs e)
        {
            int.TryParse(numInput.Text, out int Numar);
            if (Numar <= 0) return;
            string Text = "";
            for(int i = 1; i < Numar; i++)
            {
                if (IsPrime(i))
                {
                    Text += $"{i} ";
                }
            }
            numInput.Text = Text;
        }
    }
}