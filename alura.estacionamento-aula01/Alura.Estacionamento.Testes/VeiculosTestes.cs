using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculosTestes
    {
        [Fact(DisplayName = "Teste n�1")]
        [Trait("Funcionalidade", "Acelerar")]
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

        [Fact(DisplayName = "Teste n�2")]
        [Trait("Funcionalidade", "Frear")]

        public void TestaVeiculoFrear()
        {

            var veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);

        }


        // O teste a baixo ser� ignorado
        [Fact(DisplayName = "teste n�3", Skip = "Teste ainda n�o implementado")]
        public void ValidaNomeProprietario()
        {
            // Exemplo de utiliza��o do Skip
        }

        [Fact]
        public void AlterarDadosVeiculo()
        {
            //Arrange

            Patio estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = "Jos� Silva";
            veiculo.Placa = "ZXC-8524";
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Opala";
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "Jos� Silva";
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
            veiculo.Proprietario = "Andr� Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Preto";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "ZXC-8888";

            //Act
            string dadosveiculo = veiculo.ToString();

            //Assert
            Assert.Contains("Ficha do Ve�culo", dadosveiculo);
        }
    }
}