namespace Banquito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            var registro = new Registro();
            registro.ShowDialog();
        }
    }
}
