namespace Prob9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void determinabt_Click(object sender, EventArgs e)
        {
            int.TryParse(varstaInput.Text, out int Varsta);
            int Greutate = 2 * Varsta + 8;
            int Inaltime = 5 * Varsta + 80;
            weightInfo.Text = $"Greutate: {Greutate} kg";
            heightInfo.Text = $"Inaltime: {Inaltime} cm";
        }
    }
}