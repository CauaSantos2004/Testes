using _02_CacaAoBugMVC.Model; // Namespace do arquivo AlunoService.cs.
                              // É necessário importar porque estou utilizando uma classe localizada em outro projeto.

namespace _02_CacaAoBugMVC.Test
{
        // [TestClass] → diz que a classe contém testes
        // [TestMethod] → diz que o método é um teste
        // [TestInitialize] → roda antes do teste 
        // [TestCleanup] → roda depois do teste


    [TestClass] //essa etiqueta indica que a classe abaixo é uma classe de teste, marca como uma classe de testes
    public class AlunoServiceTests
    {
        [TestMethod] //essa etiqueta indica que o método abaixo é um método de teste
        public void CalcularMedia_DeveRetornarCorreo()
        {
            //Arrnge - (Preparar) Preparação do teste 
            var service = new AlunoService();

            //Act - (Agir, Executar) Ação do teste - execução do método a ser testado
            var resultado = service.CalcularMedia(8.0, 7.5, 6.5);

            //Assert - (Afirmação, Confirmar) Verificação do teste - comparação do resultado obtido com o resultado esperado
            Assert.AreEqual(7.33, Math.Round( resultado,2)); // Compara o valor esperado (7.33) com o resultado arredondado para 2 casas decimais.

        }

        [TestMethod]
        public void CalcularMedia_DeveRetornarErro() //teste que deve retornar erro (deve retornar a media incorreta)
        {
            //Arrnge - (Preparar) Preparação do teste 
            var service = new AlunoService();

            //Act - (Agir, Executar) Ação do teste - execução do método a ser testado
            var resultado = service.CalcularMedia(6.0, 5.5, 3.5);

            //Assert - (Afirmação, Confirmar) Verificação do teste - comparação do resultado obtido com o resultado esperado
            Assert.AreNotEqual(7.33, Math.Round(resultado, 2)); // Compara o valor esperado (7.33) com o resultado arredondado para 2 casas decimais.
                                                                // a media correta é 5.67, portanto esse teste deve passar
        }

        [TestMethod]
        public void ObterSituacao_DeveRetornarAprovado()
        {
            //Arrnge - (Preparar) Preparação do teste 
            var service = new AlunoService();

            //Act - (Agir, Executar) Ação do teste - execução do método a ser testado
            var resultadoAprovado = service.ObterSituacao(7.0);
            var resultadoEmExameFinal = service.ObterSituacao(6.5);
            var resultadoReprovado = service.ObterSituacao(4.9);

            //Assert - (Afirmação, Confirmar) Verificação do teste - comparação do resultado obtido com o resultado esperado            Assert.AreEqual("Aprovado", resultadoAprovado);
            Assert.AreEqual("Em Exame Final", resultadoEmExameFinal);
            Assert.AreEqual("Reprovado", resultadoReprovado);
        }
    }
}
