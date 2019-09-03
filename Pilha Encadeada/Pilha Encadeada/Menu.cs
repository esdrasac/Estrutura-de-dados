using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha_Encadeada {
    static class Menu {
        public static int Selecao { get; set; }
        public static Pilha MyPilha { get; set; }
        public static int Tam { get; set; }


        public static void Inicializar() {
            MyPilha = new Pilha();

            bool validar = false;
            while(validar == false) {
                Console.Clear();
                Console.WriteLine("\t\t\t\t Pilha Encadeada\n\n");
                Console.WriteLine("     > 1. Inserir");
                Console.WriteLine("     > 2. Remover");
                Console.WriteLine("     > 3. Imprimir");
                Console.WriteLine("     > 4. Tamanho");
                Console.WriteLine("     > 5. Reinicializar");
                Console.WriteLine("     > 6. Sair\n");
                Selecao = int.Parse(Console.ReadLine());
                switch(Selecao) {
                    case 1:
                        Inserir(MyPilha);
                        break;
                    case 2:
                        Remover(MyPilha);
                        break;
                    case 3:
                        Imprimir(MyPilha);
                        break;
                    case 4:
                        Tamanho(MyPilha);
                        break;
                    case 5:
                        Reinicializar(MyPilha);
                        break;
                    case 6:
                        validar = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t Opção inválida\n\n");
                        Console.WriteLine(" > Pressione uma tecla para voltar...");
                        Console.ReadKey();
                        break;
                }
            }

        }

        private static void Inserir(Pilha x) {
            bool aux = false;
            while(aux == false) {
                Console.Clear();
                Console.WriteLine("\t\t\t\t Inserir valores à pilha\n\n");
                Console.WriteLine("Digite '--' a qualquer momento para encerrar a inserção\n");
                Console.Write("Digite o valor: ");
                try {
                    string cont = Console.ReadLine();
                    if(cont != "--") {
                        x.Inserir(Convert.ToInt32(cont));
                    }
                    else {
                        aux = true;
                    }
                }
                catch(Exception) {
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t\t Erro - Caractere inválido\n\n");
                    Console.WriteLine(" > Pressione uma tecla para voltar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }

        }

        private static void Remover(Pilha x) {
            Console.Clear();
            int removido = x.Remover();
            if(x.Topo != null)
                Console.WriteLine($"\n\n\t\t\t\t Número {removido} removido do topo da pilha.\n\n");
            Console.WriteLine(" > Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        private static void Imprimir(Pilha x) {
            Console.Clear();
            Console.WriteLine("\t\t\t\t Imprimir Pilha\n\n");
            if(x.Topo == null) {
                Console.WriteLine("\t\t\t\t Pilha Vazia\n\n");
            }
            else {
                x.Imprimir();
                Console.WriteLine(" > Pressione uma tecla para voltar...");
            }
            Console.ReadKey();
        }

        private static void Tamanho(Pilha x) {
            Console.Clear();
            Console.WriteLine("\t\t\t\t Tamanho da fila\n\n");
            Tam = x.Tamanho();
            Console.WriteLine($"     > A Pilha tem {Tam} posições.\n\n");
            Console.WriteLine(" > Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        private static void Reinicializar(Pilha x) {
            Console.Clear();
            x.Reinicializar();
            Console.WriteLine("\n\n\t\t\t\t Pilha Reinicializada com sucesso.\n\n");
            Console.WriteLine(" > Pressione uma tecla para voltar...");
            Console.ReadKey();
        }
    }
}
