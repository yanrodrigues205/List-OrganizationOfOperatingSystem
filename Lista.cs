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


        public void Pesquisar(string valor)
        {
            No noAtual = Topo;

            while(noAtual != null)
            {
                if(noAtual.Valor == valor)
                {
                    Console.WriteLine("Valor encontrado com sucesso!");
                    return;
                }
                noAtual = noAtual.Prox;
            }

            Console.WriteLine("Valor não foi encontrado!");
            return;

        }

        public void Editar(string valor_anterior, string valor_atual) 
        {
            No noAtual = Topo;
            while(noAtual != null)
            {
                if(noAtual.Valor == valor_anterior)
                {
                    noAtual.Valor = valor_atual; //ATT valor do nó
                    Console.WriteLine(valor_anterior + " foi editado com sucesso, seu valor atual é: " + valor_atual);
                    return; 
                }
                noAtual = noAtual.Prox;
            }
        }


    }
}