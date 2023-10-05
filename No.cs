using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_EngenhariaDSoftware.List
{
    public class No
    {
        public string Valor { get; set; }

        public No Prox { get; set; }

        public No(string valor_atual)
        {
            Valor = valor_atual;
            Prox = null;
        }


    }
}