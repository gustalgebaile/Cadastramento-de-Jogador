using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Jogador
    {
        public DateTime DataDeNasc { get; set; }
        public string Nome { get; set; }
        public string UltSobrenome { get; set; }
        public string Time { get; set; }
        public bool Convacado { get; set; }
        public double Gols { get; set; }
        public ushort NumCamisa { get; set; }
        public Guid Id { get; set; }

        public int CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataDeNasc.Year;

            if (DataDeNasc > dataAtual.AddYears(-idade))
                idade--;

            return idade;
        }
    }
}
