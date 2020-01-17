using System;
using System.Linq;

namespace TesteLINQ
{
    class Exercicio_1
    {
        public void Exercicio1()
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            var result1 = numeros.Where(x => x % 2 > 0);
            var result2 = numeros.Where(y => y % 2 == 0);
            Console.WriteLine("Questão número 1");
            Console.WriteLine();
            Console.WriteLine("O array não contém apenas números impares");
            Console.WriteLine("Os números ímpares são:");
            foreach (int x in result1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Os números pares são:");
            foreach (int y in result2)
            {
                Console.WriteLine(y);
            }
        }
    }
}
