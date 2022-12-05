using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Testes
{
    public class VeiculosTestes
    {
        public ITestOutputHelper Output { get; }
        private Veiculo veiculo;

        public VeiculosTestes(ITestOutputHelper output)
        {
            Output = output;
            Output.WriteLine("Execu��o do  construtor.");
            veiculo = new Veiculo();
            veiculo.Tipo = TipoVeiculo.Automovel;
        }

        [Fact/*(DisplayName = "Teste n�1")*/]
        //[Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerarComAceleracao10()
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

        public void TestaVeiculoFrearComFreio10()
        {

            var veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);

        }


        //[Fact/*(DisplayName = "Teste n�3",*/( Skip = "Teste ainda n�o implementado")]
        //public void ValidaNomeProprietario()
        //{
        //    // Exemplo de utiliza��o do Skip
        //}

        [Fact]
        public void AlteraDadosVeiculoDeUmDeterminadoVeiculoComBaseNaPlaca()
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
            var alterado = estacionamento.AlteraDadosVeiculo(veiculoAlterado);

            //Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);

        }

        [Fact]
        public void GerarFichadeInforma��odoProprioVeiculo()
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