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

            
            // Arrange é a preparação do ambiente (inserção de veriavéis)
            var veiculo = new Veiculo();

            // Act é metodo que queremos testar no caso Acelerar() e Frear()
            veiculo.Acelerar(10);

            // Assert é para verificar o resultado obtido da verificaçao daquele método
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
