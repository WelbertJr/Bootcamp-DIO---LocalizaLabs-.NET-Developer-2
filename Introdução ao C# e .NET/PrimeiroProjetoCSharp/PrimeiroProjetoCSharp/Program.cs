using System;
using Primeiro;
using PrimeiroProjetoCSharp;
using Interface;
using Enum;

namespace PrimeiroProjetoCSharp
{ 
  
  class Program
    { 
      
        static void Main(string[] args)
        {

           var pessoa1 = (Pessoas)0;
           Pessoas pessoa2 = Pessoas.João;
           Pessoas pessoa3 = (Pessoas)4;

           Pessoa person = new Pessoa();

           person.Nome = "Giovanna";
           person.Idade = 18;
           person.Estado = "SP";

           var person2 = new Pessoa();


           person2.Nome = "Julio";
           person2.Idade = 25;
           person2.Estado = "MG";

           Animal animal = new Animal();

            animal.Nome = "Boris";
            animal.NomeDono = "Andreas";
            animal.Especie = "Cachorro";

           var Classe = new Primeiro.Classe();
           var Claase2 = new Segundo.Classe();

           Console.WriteLine(pessoa3);
        }
    }
}
