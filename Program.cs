﻿using Lista_EngenhariaDSoftware;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();
        

        lista.Adicionar("Valor 1");
        lista.Adicionar("Valor 2");
        lista.Adicionar("Valor 3");
        lista.Adicionar("Valor 4");
        lista.Remover("Valor 3");
        lista.Remover("Valor 2");

        lista.Mostrar();
    }
}