namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void B_Agregar_01_Click(object sender, EventArgs e)
        {
            alta_concurso new_alta = new alta_concurso();
            new_alta.Show();
        }
    }
}
