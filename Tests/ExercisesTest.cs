using System.Collections.Generic;
using System.Linq;
using Domain;
using Xunit;

namespace Tests
{
    public class ExercisesTest
    {
        [Fact]
        public void Should_return_an_array_from_1_to_10()
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
        public void Should_return_an_array_from_10_to_1()
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
        public void Should_return_an_array_from_1_to_10_but_only_even()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            Assert.Collection(
                returnedValues,
                item1 => { Assert.Equal(2, item1); },
                item2 => { Assert.Equal(4, item2); },
                item3 => { Assert.Equal(6, item3); },
                item4 => { Assert.Equal(8, item4); },
                item5 => { Assert.Equal(10, item5); }
            );
        }
  
        [Fact]
        public void Should_return_5050()
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int result = exercises.Exercise2();

            // Deve / Asserções
            Assert.Equal(5050, result);
        }
    
        [Fact]
        public void Should_return_7_when_passed_5_and_9()
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

        [Theory]
        [InlineData(new int[3]{4, 6, 8}, 6)]
        [InlineData(new int[2]{4, 6}, 5)]
        [InlineData(new int[4]{1, 2, 3, 4}, 2.5)]
        public void Should_return_the_average_between_ages(int[] ages, double expected)
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            double result = exercises.Exercise4(ages.ToList());

            // Deve / Asserções
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(6, new int[10]{6, 12, 18, 24, 30, 36, 42, 48, 54, 60})]
        [InlineData(5, new int[10]{5, 10, 15, 20, 25, 30, 35, 40, 45, 50})]
        public void Should_return_the_input_multiplied_by_1_to_10(int number, int[] expectedResult)
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise17(number);

            // Deve / Asserções
            Assert.Equal(result, expectedResult);
        }
    }
}
