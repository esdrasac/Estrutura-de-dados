using System;
using System.Collections.Generic;
using System.Text;

namespace Fila_Encadeada
{

    class Elemento
    {
        public int Valor { get; set; }
        public Elemento Proximo { get; set; }
    }
    class Fila
    {
        public Elemento inicio { get; set; }
        public Elemento fim { get; set; }


        public Fila()
        {
            inicio = null;
            fim = null;
        }

        public int Tamanho()
        {
            Elemento end = inicio;
            int tam = 0;
            while (end != null)
            {
                tam++;
                end = end.Proximo;
            }
            return tam;
        }

        public int Imprimir()
        {
            Elemento end = inicio;
            int tam = 0;
            Console.WriteLine("     Fila: ");
            while (end != null)
            {
                Console.WriteLine($"            > {end.Valor}");
                end = end.Proximo;
            }
            Console.WriteLine("\n\n");
            return tam;
        }
        public bool Inserir(int x)
        {
            Elemento prox = new Elemento();
            prox.Valor = x;
            prox.Proximo = null;
            if (inicio == null)
            {
                inicio = prox;
            }
            else
            {
                fim.Proximo = prox;
            }
            fim = prox;
            return true;
        }

        public int Remover()
        {
            int aux = 0;
            if (inicio != null)
            {
                aux = inicio.Valor;
                inicio = inicio.Proximo;
                if (inicio == null)
                {
                    fim = null;
                }
            }
            else
            {
                Console.WriteLine("\n\nFila Vazia\n\n");
            }
            return aux;
        }

        public void Reinicializar()
        {
            inicio = null;
            fim = null;
        }
    }
}
