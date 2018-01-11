using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjektEkwipunek.Test
{
    [TestClass]
    public class TestyZaloz
    {
        [TestMethod]
        public void TestZaloz()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);
            var helm = new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "trwala'", 0.5);
            postac.DodajPrzedmiotDoEkwipunku(helm);
            // Act
            postac.Zaloz(CzescCiala.Glowa, helm);

            // Assert
            Assert.AreEqual(helm.Id, postac.NakrycieGlowy.Id);
        }
        [TestMethod]
        public void TestZalozPuste()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);

            // Act
            // Assert
            Assert.ThrowsException<Exception>(() => { postac.Zaloz(CzescCiala.Glowa, null); });
        }
        [TestMethod]
        public void TestZalozOgraniczenie()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);
            var helm = new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "trwala'", 0.5);
            helm.OgraniczeniaKlasowe = KtoMozeNosic.Sebix;

            postac.DodajPrzedmiotDoEkwipunku(helm);
            // Act
            Assert.ThrowsException<Exception>(() => { postac.Zaloz(CzescCiala.Glowa, helm); });

            //assert
            Assert.IsNull(postac.NakrycieGlowy);
        }
    }
}
