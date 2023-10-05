using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lista_EngenhariaDSoftware.List;

namespace Lista_EngenhariaDSoftware
{
    public class Lista
    {
        public No Topo {get; set;}
        
        public Lista()
        {
            Topo = null;
        }

        public void Adicionar(string valor)
        {
            No novoNo = new No(valor);

            if(Topo == null)
            {
                Topo = novoNo;
            }
            else
            {
                No noAtual = Topo;
                while(noAtual.Prox != null)
                {
                    noAtual = noAtual.Prox;
                }

                noAtual.Prox = novoNo;
            }
        }

        public void Mostrar()
        {
            No noAtual = Topo;
            while(noAtual != null)
            {
                Console.Write(noAtual.Valor + " -> ");
                noAtual = noAtual.Prox;
            }

            Console.WriteLine("Fim da Lista!");
        }

        public void Remover(string valor)
        {
            if(Topo == null)
            {
                return;
            }


            if(Topo.Valor == valor)
            {
                Topo = Topo.Prox;
                return;
            }

            No noAtual = Topo;

            while(noAtual.Prox != null)
            {
                if(noAtual.Prox.Valor == valor)
                {
                    noAtual.Prox = noAtual.Prox.Prox;
                    return;
                }

                noAtual= noAtual.Prox;
            }
        }
    }
}