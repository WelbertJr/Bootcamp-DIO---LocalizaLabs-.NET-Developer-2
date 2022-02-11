using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());


            for (int i = 0; i < numero; i++)
            {

                int maiorEsfera = int.Parse(Console.ReadLine());

                int qtdeNumerosDivisoresPar = 0;

                for (int j = 1; j <= maiorEsfera; j++)
                {
                    int numeroDivisores = 0;

                    for (int k = 1; k < ((int)Math.Floor(Math.Sqrt(j))) + 1; k++)
                    {
                        if (j % k == 0)
                        {
                            numeroDivisores += (j / k == k) ? 1 : 2;
                        }
                    }
                    if (numeroDivisores % 2 == 0) qtdeNumerosDivisoresPar++;
                }
                Console.WriteLine(qtdeNumerosDivisoresPar);


            }
        }
    }
}