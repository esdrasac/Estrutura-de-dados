using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha_Encadeada {
    class Pilha {
        public Elemento Topo { get; set; }
        public int Tam { get; set; }

        public Pilha() {
            Topo = new Elemento();
            Topo = null;
        }

        public void Inserir(int x) {
            Elemento novo = new Elemento();
            novo.Valor = x;
            novo.Proximo = null;
            if(Topo == null) {
                Topo = novo;
            }
            else {
                novo.Proximo = Topo;
            }
            Topo = novo;
        }

        public int Remover() {
            int remove = Topo.Valor;
            Topo = Topo.Proximo;
            return remove;
        }

        public int Tamanho() {
            Elemento imprime = new Elemento();
            imprime = Topo;
            while(imprime != null) {
                Tam++;
                imprime = imprime.Proximo;
            }
            return Tam;
        }

        public void Imprimir() {
            Elemento imprime = new Elemento();
            imprime = Topo;
            while(imprime != null) {
                Console.WriteLine(imprime.Valor);
                imprime = imprime.Proximo;
            }
        }

        public void Reinicializar() {
            Topo = null;
        }
    }
}
