using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinhoMosca
{
    public partial class Cadastrar : Form
    {
        string caminhoImagem;
        public Cadastrar()
        {
            InitializeComponent();
        }
        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagem (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            openFileDialog.Title = "Abrir Arquivo";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoImagem = openFileDialog.FileName;
                pic.Image = new Bitmap(caminhoImagem);
            }
        }
        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string tipo = txtTipo.Text;
            string raca = txtRaca.Text;
            string nivel = txtNivel.Text;
            if(nome == "" || tipo == "" || raca == "" || nivel == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                try
                {
                    int nivelInt = Convert.ToInt32(nivel);
                    Personagens enviarPersonagem = new Personagens(nome, tipo, raca, nivelInt, caminhoImagem);
                    MessageBox.Show("Personagem cadastrado com sucesso!");
                    txtNome.Text = "";
                    txtTipo.Text = "";
                    txtRaca.Text = "";
                    txtNivel.Text = "";
                    caminhoImagem = "";
                }
                catch (FormatException)
                {
                    MessageBox.Show("O nível deve ser um número inteiro!");
                }
            }
        }
    }
}
