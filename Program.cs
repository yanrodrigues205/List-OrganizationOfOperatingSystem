using Lista_EngenhariaDSoftware;

class Program
{
    static void Main()
    {
        Lista lista_processos = new Lista();
        Lista lista_vazia = new Lista();
        

        Console.WriteLine("Yan Pablo Rodrigues - 1 ANO AMS-ADS\n Partições de Memória");
        Console.WriteLine("\nLista de Processos:");
        lista_processos.Adicionar("[A|5|3]");
        lista_processos.Adicionar("[B|8|6]");
        lista_processos.Adicionar("[C|14|2]");
        lista_processos.Adicionar("[D|16|3]");
        lista_processos.Adicionar("[?|19|1]");
        lista_processos.Adicionar("[E|26|3]");
        lista_processos.Adicionar("[?|29|3]");
        lista_processos.Mostrar();
        Console.WriteLine("\nLista de Espaços Vazios:");
        lista_vazia.Adicionar("[-|0|5]");
        lista_vazia.Adicionar("[-|20|6]");
        lista_vazia.Mostrar();



    }
}