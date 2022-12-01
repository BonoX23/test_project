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
            var veiculo = new Veiculo();
            
            veiculo.Acelerar(10);

            //Verificação é feito com Assert
            // Abaixo nos esperamos que o resultado seja 100 e nos iredmos verificar de veiculo.VelocidadeAtual
            Assert.Equal(100, veiculo.VelocidadeAtual);

        }
    }
}
