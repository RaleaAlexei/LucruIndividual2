using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Prob1
{
    public partial class Form1 : Form
    {
        /*
1. Elaborați o aplicație compusă dintr-o fereastră în care afișați o matrice cu 10 linii și
10 coloane formată din elemente întregi generate aleatoriu din intervalul [0,100]. 
Folosiți în acest sens fie o etichetă fie un tabel. 
Fereastră să mai conțină un buton și o etichetă. 
La executare click pe buton să se determine suma pe coloane 
a elementelor din tabel și să se afișeze în etichetă. 
*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                string[] Row = new string[10];
                for (int j = 0; j < 10; j++)
                {
                    Row[j] = rand.Next(0, 101).ToString();
                }
                numData.Rows.Add(Row);
            }
        }

        private void calcbt_Click(object sender, EventArgs e)
        {
            string[] Row = new string[10];
            for (int i = 0; i < 10; i++)
            {
                int Sum = 0;
                for (int j = 0; j < 10; j++)
                {
                    Sum += int.Parse(numData.Rows[i].Cells[j].FormattedValue.ToString());
                }
                Row[i] = Sum.ToString();
            }

            numData.Rows.Add(Row);
        }
    }
}