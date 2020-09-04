using System.Collections.Generic;
using Xunit;

namespace entra21_tests
{
    public class ExercisesTest
    {
        [Fact]
        public void should_return_an_array_from_1_to_10()
        {
            // BDD - Behavior Driven Design
            // Dado, Quando, Deve

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar todos os número de 1 a 10

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var result = exercises.Exercise1A();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], result[i]);
            }
        }

        [Fact]
        public void should_return_an_array_from_10_to_1()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
            // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                10,9,8,7,6,5,4,3,2,1
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        
        [Fact]
        public void should_return_an_array_from_1_to_10_but_only_even()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            var expectedOutput = new int[5]
            {
                2,4,6,8,10
            };

            Assert.Equal(5, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
  
        [Fact]
        public void should_return_5050()
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int result = exercises.Exercise2();

            // Deve / Asserções
            Assert.Equal(5050, result);
        }
    
        [Fact]
        public void should_return_7_when_passed_5_and_9()
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // criando uma lista com o número 5 na primeira posição e o número 9 na segunda
            var myList = new List<int>(){5, 9};

            // Quando / Ação
            double result = exercises.Exercise4(myList);

            // Deve / Asserções
            Assert.Equal(7, result);
        }

        [Fact]
        public void should_return_8_when_passed_4_and_6_and_8()
        {
            // Dado / Setup
            var exercises = new Exercises();
            var myList = new List<int>(){4, 6, 8};

            // Quando / Ação
            double result = exercises.Exercise4(myList);

            // Deve / Asserções
            Assert.Equal(6, result);
        }
    }
}
