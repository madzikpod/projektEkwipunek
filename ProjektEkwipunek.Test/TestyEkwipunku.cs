using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjektEkwipunek;

namespace ProjektEkwipunek.Test
{
    [TestClass]
    public class TestyEkwipunku
    {
        [TestMethod]
        public void TestDodawanieDoEkwipunku()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);
            var helm = new Przedmiot(TypPrzedmiotu.NakrycieGlowy,"trwala'",0.5);
            // Act
            var wynik = postac.DodajPrzedmiotDoEkwipunku(helm);
            // Assert
            Assert.AreEqual(true, wynik);
            Assert.AreEqual(1, postac.Ekwipunek.Count);
            Assert.AreEqual(helm.Waga, postac.Obciazenie);
        }
        [TestMethod]
        public void TestDodawanieDoEkwipunkuPonadUdzwig()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);
            var helm = new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "trwala'", postac.Udzwig+1);
            // Act
            var wynik = postac.DodajPrzedmiotDoEkwipunku(helm);
            // Assert
            Assert.AreEqual(false, wynik);
            Assert.AreEqual(0, postac.Ekwipunek.Count);
            Assert.AreEqual(0, postac.Obciazenie);
        }
        [TestMethod]
        public void TestDodawaniePodwojnieDoEkwipunku()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);
            var helm = new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "trwala'", 0.5);
            // Act
            postac.DodajPrzedmiotDoEkwipunku(helm);
            var wynik = postac.DodajPrzedmiotDoEkwipunku(helm);
            // Assert
            Assert.AreEqual(false, wynik);
            Assert.AreEqual(1, postac.Ekwipunek.Count);
            Assert.AreEqual(helm.Waga, postac.Obciazenie);
        }
        [TestMethod]
        public void TestUsuwanieZEkwipunku()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);
            var helm = new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "trwala'", 0.5);
            // Act
            postac.DodajPrzedmiotDoEkwipunku(helm);
             postac.DodajPrzedmiotDoEkwipunku(helm);
            var wynik = postac.UsunPrzedmiotZEkwipunku(helm);
            // Assert
            Assert.AreEqual(true, wynik);
            Assert.AreEqual(0, postac.Ekwipunek.Count);
            Assert.AreEqual(0, postac.Obciazenie);
        }
        [TestMethod]
        public void TestUsuwanieZEkwipunkuNieobecnegoPrzedmiotu()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);
            var helm = new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "trwala'", 0.5);
            var bron = new Przedmiot(TypPrzedmiotu.Bron, "patelnia", 2);
            // Act
            postac.DodajPrzedmiotDoEkwipunku(helm);
           
            var wynik = postac.UsunPrzedmiotZEkwipunku(bron);
            // Assert
            Assert.AreEqual(false, wynik);
            Assert.AreEqual(1, postac.Ekwipunek.Count);
            Assert.AreEqual(helm.Waga, postac.Obciazenie);
        }

    }
}
