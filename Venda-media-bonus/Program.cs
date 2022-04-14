using System;

namespace Teste_media
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int vendaum;
            int vendadois;
            int vendatres;
            int vendaquatro;
            int media;


            Console.WriteLine("Digite o nome do vendedor");
            nome = (Console.ReadLine());

            Console.WriteLine("Digite a primeira venda");
            vendaum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda venda");
            vendadois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a terceira venda");
            vendatres = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quarta venda");
            vendaquatro = Convert.ToInt32(Console.ReadLine());


            media = ((vendaum + vendadois + vendatres + vendaquatro) / 4);
            Console.WriteLine("Sua media de venda é" + media);

            if (media >= 7)
            {
                Console.WriteLine(nome + "Ganhou o bônus");

            }

            else
            {
                Console.WriteLine(nome + "não ganhou bônus");
            }



        }
    }
}
