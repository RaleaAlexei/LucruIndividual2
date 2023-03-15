namespace Prob3
{
    public partial class Form1 : Form
    {
        /*
* 3. Elaborați o aplicație compusă dintr-o fereastră ce va conține două butoane (Calculează, Șterge), 
* etichete, o cutie de editare, o suprafață de desenare. 
* În cutia de editare va servi pentru întroducerea razei cercului. 
* La acționarea butonului 'Calculează' se va desena cercul în dependență de raza 
* specificată și se va scrie aria cercului într-o etichetă. 
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
            double.TryParse(razaInput.Text, out double Raza);
            if(Raza < 0) return;
            double Area = Math.PI * (Math.Pow(Raza, 2));
            info.Text = $"Aria: {Area:N2} m^2";
            graphics.Clear(Color.FromKnownColor(KnownColor.Control));
            graphics.DrawEllipse(blackPen, 0, 0, (int)Area, (int)Area);
        }
    }
}