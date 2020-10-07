using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Exercises
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

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente
        public int[] Exercise1B()
        {
            int[] numbers = new int[10];
            
            for (int counter = 10; counter > 0; counter--)
            {
                numbers[numbers.Length - counter] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
        // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }

            return numbers;
        }

        public int Exercise2()
		{
			int sum = 0;

            for (int counter = 1; counter < 101; counter++)
            {
				sum += counter;
            }

            return sum;
		}

        public double Exercise4(List<int> ages)
		{
            double sum = 0.0;

            var answers = ages.Count;

            foreach (var item in ages)
            {
				sum += item;
            }

            var average = (sum / answers);

            return average;
		}

        public void Exercise6()
		{
            // var winner = candidates[0];
            // var isDraw = false;
            // var drawCandidates = winner.name;

            // for (int i = 1; i < candidates.Length; i++)
            // {
            //     var currentCandidate = candidates[i];

            //     if (currentCandidate.votes > winner.votes)
            //     {
            //         winner = currentCandidate;
            //         drawCandidates = currentCandidate.name;
            //     }
            //     else if (currentCandidate.votes == winner.votes)
            //     {
            //         isDraw = true;
            //         drawCandidates += $", {currentCandidate.name}";
            //     }
            // }

			// if (isDraw)
			// {
			// 	System.Console.WriteLine($"Segundo turno entre: {drawCandidates}!");
			// }
			// else
			// {
			// 	System.Console.WriteLine($"O vencedor é: {winner.name}");
			// 	System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
			// }
		}
    
        public IEnumerable<int> Exercise17(int number)
		{
            // Imprimir a tabuada de qualquer número fornecido pelo usuário.
            // DADO que a aplicação esteja pronta, QUANDO o usuário informar um número
            // DEVE retornar a tabuada de 1 a 10

            var multiplicationTable = new List<int>(){
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            return multiplicationTable.Select(item => item * number);
		}
    }
}