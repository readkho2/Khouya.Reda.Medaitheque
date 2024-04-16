using Mediatheque.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mediatheque.CoreTests.ModelTests.ObjetDePretTests
{
    [TestClass()]
    public class EmprunteShould
    {
        [TestMethod()]
        public void FillEmprunteur()
        {
            // Arrange
            var objetDePret = new ObjetDePret("Scie sauteuse");

            // Act
            objetDePret.Emprunte("bernard");

            // Assert
            Assert.AreEqual("bernard", objetDePret.Emprunteur);
        }

        [TestMethod()]
        public void ReturnTrue_IfObjetIsAvailable()
        {
            // Arrange
            var objetDePret = new ObjetDePret("chaise");

            // Act
            var actual = objetDePret.Emprunte("albert");

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ReturnFalse_IfObjetIsNotAvailable()
        {
            // Arrange
            var objetDePret = new ObjetDePret("chaise");
            objetDePret.Emprunte("Alain");

            // Act
            var actual = objetDePret.Emprunte("albert");

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
