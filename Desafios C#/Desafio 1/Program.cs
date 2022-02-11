using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i < N; i++)
            {
                if (i != N - 1)
                {
                    Console.Write("Ho ");                  
                }
                else
                {
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}