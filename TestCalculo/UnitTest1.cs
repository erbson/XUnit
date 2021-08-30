using CalculadoraTests.br;
using System;
using Xunit;

namespace TestCalculo
{
    public class UnitTest1
    {
        [Fact]
       public void RetornaValor()
        {
            // Arrange
            var valor1 = 10;
            var valor2 = 10;
            var varlorEsperado = 20;

            // Act

            var soma = Calculo.Somar(valor1,valor2);
            // assert 

            Assert.Equal(varlorEsperado, soma);

        }
        [Fact]
        public void SubtrairValores()
        {

            // Arrange
            var valor1 = 10;
            var valor2 = 5;
            var varlorEsperado = 15;

            // Act

            var subtrair = Calculo.Subtrair(valor1, valor2);
            // assert 

            Assert.Equal(varlorEsperado, subtrair);




        }


    }
}
