using System;
using System.Collections.Generic;
using System.Text;

namespace Fila_Encadeada
{
     static class Menu
    {
        public static int Selecao { get; set; }
        public static Fila MyFila { get; set; }
        public static int Tam { get; set; }

        
        public static void Inicializar()
        {
            Fila MyFila = new Fila();

            bool validar = false;
            while(validar == false)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t Fila Encadeada\n\n");
                Console.WriteLine("     > 1. Inserir");
                Console.WriteLine("     > 2. Remover");
                Console.WriteLine("     > 3. Imprimir");
                Console.WriteLine("     > 4. Tamanho");
                Console.WriteLine("     > 5. Reinicializar");
                Console.WriteLine("     > 6. Sair\n");
                Selecao = int.Parse(Console.ReadLine());
                switch (Selecao)
                {
                    case 1:
                        Inserir(MyFila);
                        break;
                    case 2:
                        Remover(MyFila);
                        break;
                    case 3:
                        Imprimir(MyFila);
                        break;
                    case 4:
                        Tamanho(MyFila);
                        break;
                    case 5:
                        Reinicializar(MyFila);
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

        private static void Inserir(Fila x)
        {
            bool aux = false;
            while(aux == false)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t Inserir valores à fila\n\n");
                Console.WriteLine("Digite '--' a qualquer momento para encerrar a inserção\n");
                Console.Write("Digite o valor: ");
                try
                {
                    string cont =Console.ReadLine();
                    if(cont != "--")
                    {
                        x.Inserir(Convert.ToInt32(cont));
                    }
                    else
                    {
                        aux = true;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t\t Erro - Caractere inválido\n\n");
                    Console.WriteLine(" > Pressione uma tecla para voltar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            
        }

        private static void Remover(Fila x)
        {
            Console.Clear();
            x.Remover();
            Console.WriteLine("\n\n\t\t\t\t Primeiro valor da fila removido com sucesso. fila\n\n");
            Console.WriteLine(" > Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        private static void Imprimir(Fila x)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t Imprimir Fila\n\n");
            if(x.inicio == null && x.fim == null)
            {
                Console.WriteLine("\t\t\t\t Fila Vazia\n\n");
            }
            else
            {
                x.Imprimir();
                Console.WriteLine(" > Pressione uma tecla para voltar...");
            }
            Console.ReadKey();
        }

        private static void Tamanho(Fila x)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t Tamanho da fila\n\n");
            Tam = x.Tamanho();
            Console.WriteLine($"     > A fila tem {Tam} posições.\n\n");
            Console.WriteLine(" > Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        private static void Reinicializar(Fila x)
        {
            Console.Clear();
            x.Reinicializar();
            Console.WriteLine("\n\n\t\t\t\t Fila Reinicializada com sucesso.\n\n");
            Console.WriteLine(" > Pressione uma tecla para voltar...");
            Console.ReadKey();
        }
    }
}
