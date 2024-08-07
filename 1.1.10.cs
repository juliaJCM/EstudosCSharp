using System;

class Program
{
    static void Main()
    {
        // Largura e altura dos blocos
        int larguraBloco = 8;
        int alturaBloco = 4;
        
        // Desenho da tela
        // Parte superior do padrão
        for (int i = 0; i < alturaBloco; i++)
        {
            if (i == 0 || i == alturaBloco - 1)
            {
                // Linha completa para os blocos superiores
                Console.WriteLine(new string('*', larguraBloco) + "    " +
                                  new string('*', larguraBloco) + "   " +
                                  "*" + new string(' ', 4) + "*");
            }
            else
            {
                // Linhas intermediárias
                Console.WriteLine("*" + new string(' ', larguraBloco - 2) + "*" +
                                  new string(' ', 4) + "*" +
                                  new string(' ', 4) + "*" +
                                  new string(' ', 4) + "*");
            }
        }

        // Parte intermediária do padrão
        for (int i = 0; i < alturaBloco - 1; i++)
        {
            if (i == alturaBloco - 2)
            {
                // Linha final dos blocos intermediários
                Console.WriteLine(new string(' ', larguraBloco - 1) + "*" +
                                  new string(' ', 4) + "*" +
                                  new string(' ', 4) + "*" +
                                  new string(' ', larguraBloco - 1) + "*");
            }
            else
            {
                // Linhas intermediárias dos blocos intermediários
                Console.WriteLine(new string(' ', larguraBloco - 1) + "*" +
                                  new string(' ', 4) + "*" +
                                  new string(' ', 4) + "*" +
                                  new string(' ', larguraBloco - 1) + "*");
            }
        }

        // Parte inferior do padrão
        Console.WriteLine(new string('*', larguraBloco) + "    " +
                          new string('*', larguraBloco) + "   " +
                          new string('*', larguraBloco));
    }
}
