using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public interface ICadastrarJogador
    {
        void AdicionarJogador(Jogador jogador);

        IList<Jogador> ListaJogadores();
    }
    public class CadastroJogadorEmMemoria : ICadastrarJogador
    {
        public IList<Jogador> _lstJogador;
        public CadastroJogadorEmMemoria()
        {
            _lstJogador = new List<Jogador>();
        }

        public void AdicionarJogador(Jogador jogador)
        {
            _lstJogador.Add(jogador);
        }

        public IList<Jogador> ListaJogadores()
        {
            return _lstJogador;
        }
    }
}
