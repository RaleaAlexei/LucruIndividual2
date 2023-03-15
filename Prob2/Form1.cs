namespace Prob2
{
    public partial class Form1 : Form
    {
        /*
         * 2. Elaborați o aplicație compusă dintr-o fereastră ce va conține o cutie de editare
         * în care se vor introduce un șir de cuvinte separate printr-un spațiu și un buton. 
         * La acționarea butonului să se afișeze în altă cutie de editare doar acele cuvinte 
         * ce încep cu o vocală. 
         */
        public Form1()
        {
            InitializeComponent();
        }
        private string Vocale = "aeiou";
        private void btShow_Click(object sender, EventArgs e)
        {
            cutieEditat.Text = "";
            string[] Cuvinte = cutieOriginal.Text.Split(' ');
            for(int i = 0; i < Cuvinte.Length; i++)
            {
                if (Vocale.Contains(Cuvinte[i][0]))
                {
                    cutieEditat.Text += $"{Cuvinte[i]} ";
                }
            }
        }
    }
}