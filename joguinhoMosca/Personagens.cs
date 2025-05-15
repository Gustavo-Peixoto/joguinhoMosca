using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinhoMosca
{
    public class Personagens
    {
        private string nome;
        private string tipo;
        private string raca;
        private int nivel;
        private string imagemPath;

        public Personagens(string nome, string tipo, string raca, int nivel, string imagemPath)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.raca = raca;
            this.nivel = nivel;
            this.imagemPath = imagemPath;
        }
        
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getTipo()
        {
            return tipo;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string getRaca()
        {
            return raca;
        }
        public void setRaca(string raca)
        {
            this.raca = raca;
        }

        public int getNivel()
        {
            return nivel;
        }
        public void setTipo(int nivel)
        {
            this.nivel = nivel;
        }

        public string getImagemPath()
        {
            return imagemPath;
        }
        public void setImagemPath(string imagemPath)
        {
            this.imagemPath = imagemPath;
        }
    }
}
