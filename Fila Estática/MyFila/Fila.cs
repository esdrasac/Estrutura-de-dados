using System;
using System.Collections.Generic;
using System.Text;

namespace MyFila
{

    
    class Fila
    {
        public int tamFila { get; set; }
        public int inicio { get; set; }
        public int fim { get; set; }
        private int[] fila { get; set; }
      
        public Fila(int TamFila)
        {
            tamFila = TamFila;
            fila = new int[tamFila];
            for(int i = 0; i < fila.Length; i++)
            {
                inicio = 0;
                fim = -1;
            }
        }

        private bool Fila_Vazia()
        {
            return inicio > fim;
        }

        private bool Fila_Cheia()
        {
            return fim == tamFila - 1;
        }

        public bool Inserir(int valor)
        {
            if (Fila_Cheia())
            {
                return false;
            }
            else
            {
                fim++;
                fila[fim] = valor;
                return true;
            }
        }


        public bool Remover(ref int valor)
        {
            if (Fila_Vazia())
            {
                return false;
            }
            else
            {
                valor = fila[inicio];
                fila[inicio] = 0;
                inicio++;
                return true;
            }
        }

        public bool Get(ref int valor)
        {
            if (Fila_Vazia())
            {
                return false;
            }
            else
            {
                valor = fila[inicio];
                return true;
            }
        }

        public bool Imprimir()
        {
            int j = inicio;
            if (Fila_Vazia())
            {
                return false;
            }
            else
            {
                for(int i = 0; i < tamFila; i++)
                {
                    Console.WriteLine(fila[j]);
                    j = (j + 1) % tamFila;
                }
                return true;

            }
        }

        public int Tamanho()
        {
            return (fim - inicio) + 2;
        }
    }
}
