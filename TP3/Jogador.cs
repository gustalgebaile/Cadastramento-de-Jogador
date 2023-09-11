using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Jogador
    {
        public int numId { get; set; }
        public int idade { get; set; }
        public string nome { get; set; }
        public bool convacado { get; set; }
        public double golsPartida { get; set; }
        public short numCamisa { get; set; }
        public string dataEstreia {get; set; }
        public Jogador(int numId, string nome, int idade, bool convacado, double golsPartida, short numCamisa, string dataEstreia)
        {
            this.numId = numId;
            this.nome = nome;
            this.idade = idade;
            this.convacado = convacado;
            this.golsPartida = golsPartida;
            this.numCamisa = numCamisa;
            this.dataEstreia = dataEstreia;

        }
    }
}
