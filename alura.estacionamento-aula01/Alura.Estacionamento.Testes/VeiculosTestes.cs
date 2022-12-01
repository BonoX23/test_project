using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculosTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {

            
            // Arrange � a prepara��o do ambiente (inser��o de veriav�is)
            var veiculo = new Veiculo();

            // Act � metodo que queremos testar no caso Acelerar() e Frear()
            veiculo.Acelerar(10);

            // Assert � para verificar o resultado obtido da verifica�ao daquele m�todo
            // Abaixo colocamos no primeiro argumento o resultado que esperamos ou seja 100 e nos iredmos verificar de veiculo.VelocidadeAtual
            Assert.Equal(100, veiculo.VelocidadeAtual);

        }

        [Fact]

        public void TestaVeiculoFrear()
        {

            var veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);

        }
    }
}
