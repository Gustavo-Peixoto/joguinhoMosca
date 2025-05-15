namespace joguinhoMosca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar form = new Cadastrar();
            form.Show();
            this.Hide();
        }
    }
}
