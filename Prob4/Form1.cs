namespace Prob4
{
    public partial class Form1 : Form
    {
        /*
         * 4. Elaborați o aplicație compusă dintr-o fereastră ce va conține două butoane (Calculează, Șterge), 
         * etichete, două cutii de editare, o suprafață de desenare. 
         * În cutiile de editare se va introduce lungimile laturilor unui dreptunghi. 
         * La acționarea butonului 'Calculează' se va desena dreptunghiul în dependență 
         * de lungimile specificate și se va scrie aria dreptunghiului într-o etichetă. 
         * La acționarea butonului 'Șterge' se va curăța suprafața de desenare. 
         */
        public Form1()
        {
            InitializeComponent();
        }
        private Pen blackPen = new Pen(Color.Black, 3);
        private Graphics graphics;
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = tablou.CreateGraphics();
        }
        private void Calculeaza_Click(object sender, EventArgs e)
        {
            double.TryParse(lungInput.Text, out double lungime);
            double.TryParse(inaltInput.Text, out double inaltime);

            if (lungime < 0 || inaltime < 0) return;
            double Area = lungime * inaltime;
            info.Text = $"Aria: {Area:N2} m^2";
            graphics.Clear(Color.FromKnownColor(KnownColor.Control));
            graphics.DrawRectangle(blackPen, 0, 0, (int)lungime * 10, (int)inaltime * 10);
        }
    }
}