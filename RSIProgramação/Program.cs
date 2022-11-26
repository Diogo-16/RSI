using System;
using System.Runtime.Serialization;
using System.Security.Authentication;

public class HelloWorld
{
    static void Solucoes()
    {
        char repetir = 's';
        double ph, alcalinasPer, neutrasPer, acidasPer;
        int quantidade, alcalinas, acidas, neutras;
        alcalinas = 0;
        acidas = 0;
        neutras = 0;

        Console.Write("\nQuantas soluções tem?");
        quantidade = Convert.ToInt32(Console.ReadLine());

        while (quantidade <= 0)
        {
            Console.Write("O valor da quantidade de soluções tem de ser positivo: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i <= quantidade; i++)
        {
            Console.Write("-------------------------------\nIntroduza o seu pH: ");
            ph = Convert.ToDouble(Console.ReadLine());

            while (ph > 14 || ph < 0)
            {
                Console.Write("Introduza um pH entre 0 e 14: ");
                ph = Convert.ToDouble(Console.ReadLine());
            }

            if (ph < 7 && ph >= 0)
            {
                Console.WriteLine("A sua solução é ácida.");
                acidas++;
                Console.WriteLine("Você tem " + acidas + " soluções ácidas.\n-------------------------------");
            }
            else if (ph == 7)
            {
                Console.WriteLine("A sua solução é neutra.");
                neutras++;
                Console.WriteLine("Você tem " + neutras + " soluções neutras.\n-------------------------------");
            }
            else if (ph > 7 && ph <= 14)
            {
                Console.WriteLine("A sua solução é alcalina.");
                alcalinas++;
                Console.WriteLine("Você tem " + alcalinas + " soluções alcalinas.\n-------------------------------");
            }
        }

        alcalinasPer = ((double)alcalinas / (double)quantidade) * 100;
        neutrasPer = ((double)neutras / (double)quantidade) * 100;
        acidasPer = ((double)acidas / (double)quantidade) * 100;

        alcalinasPer = Math.Round(alcalinasPer, 1);
        neutrasPer = Math.Round(neutrasPer, 1);
        acidasPer = Math.Round(acidasPer, 1);

        Console.WriteLine("Você tem " + alcalinasPer + "% de soluções alcalinas.");
        Console.WriteLine("Você tem " + neutrasPer + "% de soluções neutras.");
        Console.WriteLine("Você tem " + acidasPer + "% de soluções acidas.");

        Console.Write("\nQuer fazer outra vez?(S/N)\n");
        repetir = Console.ReadKey().KeyChar;

        switch (repetir)
        {
            case 's':
                Solucoes();
                break;
            case 'S':
                Solucoes();
                break;
            case 'n':
                break;
            case 'N':
                break;
            default:
                break;
        }
    }
    public static void Main(string[] args)
    {
        Solucoes();
    }
}