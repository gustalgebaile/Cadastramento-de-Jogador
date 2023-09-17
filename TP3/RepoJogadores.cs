using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class RepoJogador
    {
        private List<Jogador> listaJogadores = new List<Jogador>();

        public void AdicionarJogador(Jogador jogador)
        {
            jogador.Id = Guid.NewGuid();
            listaJogadores.Add(jogador);
        }

        public List<Jogador> ProcurarJogadorPorNome(string nome)
        {
            return listaJogadores
                .Where(d => d.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
