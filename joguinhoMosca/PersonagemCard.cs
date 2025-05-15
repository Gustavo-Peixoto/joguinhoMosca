using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinhoMosca
{
    public partial class PersonagemCard : UserControl
    {
        public PersonagemCard()
        {
            InitializeComponent();
        }

        public void setarPersonagem(Personagens personagem)
        {
            lblName.Text = personagem.getNome();
            lblNivel.Text = personagem.getNivel().ToString();
            lblRaca.Text = personagem.getRaca();
            lblTipo.Text = personagem.getTipo();

            if (File.Exists(personagem.getImagemPath()))
            {
                picPerfil.Image = Image.FromFile(personagem.getImagemPath());
            }
        }
    }
}
