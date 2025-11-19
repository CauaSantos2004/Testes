using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_CacaAoBugMVC.Model;


namespace _02_CacaAoBugMVC.Test
{

    [TestClass]
    public class ValidaServiceTests
    {

        [TestMethod]
        public void ValidaNome_NomeValido_RetornarTrue()
        {
            //Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            //Act
            bool resultado = service.ValidaNome("Lucas", out mensagemErro);

            //Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(mensagemErro, "");
        }

        [TestMethod]
        public void ValidaNome_NomeVazio_RetornarFalse()
        {
            //Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            //Act
            bool resultado = service.ValidaNome("", out mensagemErro);

            //Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(mensagemErro, "");
        }

        [TestMethod]
        public void ValidaNome_NomeComMenos3Caracteres_RetornarFalse()
        {
            //Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            //Act
            bool resultado = service.ValidaNome("Ca", out mensagemErro);

            //Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual(mensagemErro, "");
        }

        [TestMethod]
        public void ValidaNome_NomeCom3LetrasIguaisConsecutivas_RetornarFalse()
        {
            //Arrange
            ValidaService service = new ValidaService();
            string mensagemErro;

            //Act
            bool resultado = service.ValidaNome("Lucaaas", out mensagemErro);

            //Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual(mensagemErro, "");
        }
}   }
