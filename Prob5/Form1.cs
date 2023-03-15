namespace Prob5
{
    public partial class Form1 : Form
    {
        /*5. Elaborați o aplicație compusă dintr-o fereastră
         * ce va conține o cutie de selectare cu valorile cerc și dreptunghi, 
         * trei cutii de editare , un buton și două etichete. 
         * În dependență de valoarea selectată din cutia de selectare 
         * se va calcula fie lungimea și aria cercului, 
         * fie perimetrul și aria dreptunghiului la acționarea butonului.
         */
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int doCircle()
        {
            double.TryParse(razaInput.Text, out double Raza);
            if (Raza < 0) return 0;
            double Area = Math.PI * (Math.Pow(Raza, 2));
            double Lungime = Math.PI * Raza * 2;
            info.Text = $"Aria: {Area:N2} m^2; Lungime: {Lungime:N2} m";
            return 1;
        }
        private int doSquare()
        {
            double.TryParse(lungInput.Text, out double lungime);
            double.TryParse(inaltInput.Text, out double inaltime);

            if (lungime < 0 || inaltime < 0) return 0;
            double Area = lungime * inaltime;
            double Perimetru = (lungime * 2) + (inaltime * 2);
            info.Text = $"Aria: {Area:N2} m^2; Perimetru: {Perimetru:N2} m;";
            return 1;
        }
        private void calculeaza_Click(object sender, EventArgs e)
        {
            switch (figuri.SelectedIndex)
            {
                case 0:
                    {
                        doCircle();
                        break;
                    }
                case 1:
                    {
                        doSquare();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}