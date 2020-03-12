using System.Collections.Generic;
using System.Linq;

namespace dotnet.models {
    public class Acionistas {
        public string CPF { get; }
        public string nome { get; }
        private List<int> acoes;

        public Acionistas (string CPF, string nome) {
            this.CPF = CPF;
            this.nome = nome;
            acoes = new List<int> ();
        }

        public void AdicionaAcoes (int acoes) {
            this.acoes.Add (acoes);
        }

        public List<Acoes> AcoesAdicionadas () {
            List<Acoes> acoesAdicionadas = new List<Acoes> ();
            foreach (var id in acoes) {
                Acoes acoes = Carteira.acoes.Where (p => p.id == id).FirstOrDefault ();
                if (acoes != null) acoesAdicionadas.Add (acoes);
            }

            return acoesAdicionadas;
        }

        public override string ToString () {
            return $"Nome: {this.nome} CPF: {this.CPF}";
        }

    }
}