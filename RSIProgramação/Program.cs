using System;
using System.Security.Authentication;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double ph;
        int quantidade;

        Console.WriteLine("Quantas soluções tem?");
        quantidade = Convert.ToInt32(Console.ReadLine());
        
        while (quantidade <= 0)
        {
            Console.WriteLine("O valor da quantidade de soluções tem de ser positivo: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine("------------------------\nIntroduza o seu pH: ");
            ph = Convert.ToDouble(Console.ReadLine());

            while (ph > 14 || ph < 0)
            {
                Console.WriteLine("Introduza um pH entre 0 e 14: ");
                ph = Convert.ToDouble(Console.ReadLine());
            }

            if (ph < 7 && ph >= 0)
            {
                Console.WriteLine("A sua solução é ácida.\n------------------------");
            }
            else if (ph == 7)
            {
                Console.WriteLine("A sua solução é neutra.\n------------------------");
            }
            else if (ph > 7 && ph <= 14)
            {
                Console.WriteLine("A sua solução é alcalina.\n------------------------");
            }
        }
        Console.ReadKey();
    }
}