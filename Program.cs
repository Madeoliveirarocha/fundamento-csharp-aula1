using System;
using System.Collections.Generic;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Medias:");

            var xNotasZuqui = new List<int> { 7, 6, 5, 3 };
            var xNotasBronza = new List<int> { 8, 9, 10, 8 };

            var xMediazuqi = CalcularMedia(xNotasZuqui);
            Console.WriteLine("Media Zuqui: " + xMediazuqi);
            
            if (xMediazuqi<7) 
            {
                Console.WriteLine("Reprovado");
            } 
            else
            {
                if( xMediazuqi> 7 )
                    Console.WriteLine("Aprovado");
            }
            

            var mediabronza = CalcularMedia(xNotasBronza);
            Console.WriteLine("MediaBronza " + mediabronza );
            if (mediabronza < 7) {
                Console.WriteLine("Reprovado");
            }
            else
            {
                if(( mediabronza > 7 ))
                Console.WriteLine("Aprovado"); 
            }

            
        }

        static float CalcularMedia(List<int> notas)
        {
            var total = 0;

            foreach (var nota in notas)
            {
                total += nota; 
                
            }
            return total / notas.Count;            
        }
    }
}
