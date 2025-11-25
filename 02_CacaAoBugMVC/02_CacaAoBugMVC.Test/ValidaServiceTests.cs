using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_CacaAoBugMVC.Model;

namespace _02_CacaAoBugMVC.Test
{
    [TestClass]
    public class ValidaServiceTests
    {

        // 1º Parte da Tarefa

        [TestMethod]

        // Teste para nome válido
        public void ValidaNome_NomeValido_RetornarTrue()
        {
            // Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            // Act
            bool resultado = service.ValidaNome("Lucas", out mensagemErro);

            // Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual("", mensagemErro);
        }


        // Teste para nome vazio
        [TestMethod]
        public void ValidaNome_NomeVazio_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            // Act
            bool resultado = service.ValidaNome("", out mensagemErro);

            // Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual("", mensagemErro);
        }


        // Teste para nome com menos de 3 caracteres
        [TestMethod]
        public void ValidaNome_NomeComMenos3Caracteres_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            // Act
            bool resultado = service.ValidaNome("Ca", out mensagemErro);

            // Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual("", mensagemErro);
        }


        // Teste para nome com 3 letras iguais consecutivas
        [TestMethod]
        public void ValidaNome_NomeCom3LetrasIguaisConsecutivas_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            // Act
            bool resultado = service.ValidaNome("Lucaaas", out mensagemErro);

            // Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual("", mensagemErro);
        }


        // Teste para nome com espaço duplo
        [TestMethod]
        public void ValidaNome_NomeComEspacoDuplo_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            // Act
            bool resultado = service.ValidaNome("Ana  Maria", out mensagemErro);

            // Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual("", mensagemErro);
        }


        // Teste para nome com caracteres inválidos
        [TestMethod]
        public void ValidaNome_NomeComCaracteresInvalidos_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            // Act
            bool resultado = service.ValidaNome("Lu!cas", out mensagemErro);

            // Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual("", mensagemErro);
        }



        // 2º Parte da Tarefa

        // Teste para nota válida com vírgula
        [TestMethod]
        public void ConverteNota_NotaValidaComVirgula_RetornarTrue()
        {
            // Arrange
            ValidaService service = new ValidaService();
            double nota;

            // Act
            bool resultado = service.ConverteNota("7,5", out nota);

            // Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual(7.5, nota);
        }

        // Teste para nota válida com ponto
        [TestMethod]
        public void ConverteNota_NotaValidaComPonto_RetornarTrue()
        {
            // Arrange
            ValidaService service = new ValidaService();
            double nota;

            // Act
            bool resultado = service.ConverteNota("8.3", out nota);

            // Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual(8.3, nota);
        }

        // Teste para nota fora do intervalo
        [TestMethod]
        public void ConverteNota_NotaForaDoIntervalo_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            double nota;

            // Act
            bool resultado = service.ConverteNota("15", out nota);

            // Assert
            Assert.IsFalse(resultado);
        }

        // Teste para texto inválido
        [TestMethod]
        public void ConverteNota_TextoInvalido_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            double nota;

            // Act
            bool resultado = service.ConverteNota("abc", out nota);

            // Assert
            Assert.IsFalse(resultado);
        }

        // Teste para campo vazio
        [TestMethod]
        public void ConverteNota_CampoVazio_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            double nota;

            // Act
            bool resultado = service.ConverteNota("", out nota);

            // Assert
            Assert.IsFalse(resultado);
        }

        // Teste para formato incorreto
        [TestMethod]
        public void ConverteNota_FormatoIncorreto_RetornarFalse()
        {
            // Arrange
            ValidaService service = new ValidaService();
            double nota;

            // Act
            bool resultado = service.ConverteNota("7,,5", out nota);

            // Assert
            Assert.IsFalse(resultado);
        }
    }
}
