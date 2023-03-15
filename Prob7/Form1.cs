namespace Prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*7. Elaboraţi o aplicație compusă dintr-o fereastră care va conţine o cutie de editare şi un buton.
         * În cutia de editare se va introduce un cuvânt la acționarea butonului să se afişeze de cîte ori 
         * apare în cuvînt litera a şi poziţiile acesteia în cuvântul dat.
         */
        private void btShow_Click(object sender, EventArgs e)
        {
            string Text = cuvantInput.Text;
            info.Text = "";
            string Ending = "";
            int Occurences = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Char.ToLower(Text[i]) == 'a')
                {
                    Occurences++;
                    Ending += $"{i+1} ";
                }
            }
            info.Text = $"{Occurences} ori; {Ending}";
        }
    }
}