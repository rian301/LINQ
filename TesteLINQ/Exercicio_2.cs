using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteLINQ
{
    class Exercicio_2
    {
        //Elabore um método que traga somente os números do primeiro array que não estejam contidos no segundo array e demonstre o resultado no console

        public void exercicio2()
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            IEnumerable<int> diff = primeiroArray.Except(segundoArray);
            Console.WriteLine("Questão número 2");
            Console.WriteLine("Os números do primeiro array que não estão no segundo array:");

            foreach (int res in diff)
            {
                Console.WriteLine(res);
            }
        }

    }
}
