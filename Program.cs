using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var xPessoas = new List<Pessoas>();

            xPessoas.Add (new Pessoas (12, "Lucas"  ));
            xPessoas.Add (new Pessoas (17, "Matheus" ));
            xPessoas.Add (new Pessoas (20, "Andre" ));
            xPessoas.Add (new Pessoas (70, "Joao"));
            


            var xMediaIdade = xPessoas.Average(p => p.Idade);
            var xMaisVelho = xPessoas.OrderByDescending(p => p.Idade).FirstOrDefault().Nome;
            var xMenorIdade = xPessoas.OrderByDescending(p => p.Idade).LastOrDefault().Idade;
            var xMaisNovo = xPessoas.OrderByDescending(p => p.Idade).LastOrDefault().Nome;
            var xMaiorIdade = xPessoas.OrderByDescending(p => p.Idade).FirstOrDefault().Idade;
            var xAdultos = xPessoas.Where(p => p.Idade >= 18).Count();



            Console.WriteLine($"A média da idade das pessoas é: {xMediaIdade.ToString("F2")}");
            Console.WriteLine($"A Pessoas Mais velha é: {xMaisVelho} e ela tem {xMaiorIdade} anos.");
            Console.WriteLine($"A Pessoa Mais nova é: {xMaisNovo} Ela tem {xMenorIdade} anos.");
            Console.WriteLine($"A quantidade de pessoas com mais de 18 anos é: {xAdultos}");
                                  
      
        }

       


    }
}
