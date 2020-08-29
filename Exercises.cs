using System;

namespace entra21_tests
{
    class Exercises
    {
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int counter = 1; counter < 11; counter++)
            {
				numbers[counter - 1] = counter;
            }

            return numbers;
        }

        // public double Exercise1B()
        // {
        //     Console.WriteLine("decrescente");

        //     for (int counter = 10; counter > 0; counter--)
        //     {
		// 		Console.WriteLine(counter);   
        //     }
        // }

        // public double Exercise1C()
        // {
        //     System.Console.WriteLine("apenas os pares");

        //     for (int counter = 2; counter < 11; counter += 2)
        //     {
        //         System.Console.WriteLine(counter);
        //     }
        // }
    }
}