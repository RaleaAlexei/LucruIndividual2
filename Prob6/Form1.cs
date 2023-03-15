namespace Prob6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*6. Elaboraţi o aplicație compusă dintr-o fereastră
         * care va conține patru cutii de selecție simplă cu etichetele: 
         * iarna, vara, toamna, primavara. 
         * În rezultatul selectării unei opțiuni culoarea ferestrei să devină culoarea anotimpului 
         * respectiv: alb, verde deschis, verde închis sau galben. 
         */
        private void anotimpuri_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(anotimpuri.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.White;
                    break;
                case 1:
                    this.BackColor = Color.LightGreen;
                    break;
                case 3:
                    this.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    this.BackColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }
    }
}