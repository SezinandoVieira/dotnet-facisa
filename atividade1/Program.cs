using System;
using dotnet.models;

namespace dotnet {
    class Program {
        static void Main (string[] args) {
            do {
                ExibeMenu ();

                try {

                    int opcao = int.Parse (Console.ReadLine ());
                    if (opcao == 0) break;

                    ExecutaOpcao (opcao);
                    Console.WriteLine ("Aperte Enter para continuar...");
                    Console.ReadLine ();

                } catch (FormatException) {
                    Console.WriteLine ("**********************************");
                    Console.WriteLine ("Erro, opção invalida. Por favor digite uma opção válida");
                    Console.WriteLine ("Aperte enter para continuar...");
                    Console.ReadLine ();

                }

            } while (true);

        }

        private static void ExecutaOpcao (int opcao) {
            Console.Clear ();

            switch (opcao) {

                case 1:
                    {
                        CadastroDeAcionista ();
                    }
                    break;

                case 2:
                    {
                        CadastroDeAcoes ();
                    }
                    break;

                case 3:
                    {
                       // VisualizarCarteira ();
                    }
                    break;

            }
        }

        private static void CadastroDeAcionista () {
            Console.WriteLine ("Cadastro de acionistas");
            Console.Write ("Digite seu CPF: ");
            string cpf = Console.ReadLine ();

            Console.Write ("Digite o nome do acionista: ");
            string nome = Console.ReadLine ();

            Carteira.acionistas.Add (new Acionistas (cpf, nome));

        }

        private static void CadastroDeAcoes(){
            Console.WriteLine("Cadastro de Ações");
            Console.Write("Digite o nome da empresa: ");

            string nome = Console.ReadLine();
            int id = Carteira.acoes.Count + 1;

            Carteira.acoes.Add (new Acoes(id, nome));
        }


        static void ExibeMenu () {
            Console.Clear ();
            Console.WriteLine ("Welcome to the Easy Exchange");

            Console.Write ("");

            Console.WriteLine ("1 - Cadastro de ação");
            Console.WriteLine ("2 - Pesquisar por ação");
            Console.WriteLine ("3 - Visualizar carteira de ações");
            Console.WriteLine ("0 - Sair");

            Console.Write ("Digite uma opção: ");
        }

    }
}