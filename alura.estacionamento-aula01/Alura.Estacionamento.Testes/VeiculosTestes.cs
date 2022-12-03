using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculosTestes
    {
        [Fact(DisplayName = "Teste n°1")]
        [Trait("Funcionalidade", "Acelerar")]
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

        [Fact(DisplayName = "Teste n°2")]
        [Trait("Funcionalidade", "Frear")]

        public void TestaVeiculoFrear()
        {

            var veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);

        }


        // O teste a baixo será ignorado
        [Fact(DisplayName = "teste nº3", Skip = "Teste ainda não implementado")]
        public void ValidaNomeProprietario()
        {
            // Exemplo de utilização do Skip
        }

        [Fact]
        public void AlterarDadosVeiculo()
        {
            //Arrange

            Patio estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = "José Silva";
            veiculo.Placa = "ZXC-8524";
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Opala";
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "José Silva";
            veiculoAlterado.Placa = "ZXC-8524";
            veiculoAlterado.Cor = "Preto"; //Alterado
            veiculoAlterado.Modelo = "Opala";

            //Act
            var alterado = estacionamento.AlteraDados(veiculoAlterado);

            //Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);

        }

        [Fact]
        public void DadosVeiculo()
        {
            //Arrange
            var veiculo = new Veiculo();
            veiculo.Proprietario = "André Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Preto";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "ZXC-8888";

            //Act
            string dadosveiculo = veiculo.ToString();

            //Assert
            Assert.Contains("Ficha do Veículo", dadosveiculo);
        }
    }
}