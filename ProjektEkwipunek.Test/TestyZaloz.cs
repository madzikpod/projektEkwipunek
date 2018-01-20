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

            Assert.IsNull(postac.NakrycieGlowy);
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

            // Assert
            Assert.IsNull(postac.NakrycieGlowy);
        }
        [TestMethod]
        public void TestZalozPredmiotyZPrzedmiotami()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina", 1);
            var helm = new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "trwala'", 0.5);
            helm.Bonusy.Add(new Bonus() { DoCzego = StatystykiPostaci.Inteligencja, Premia = 3 });
            helm.Bonusy.Add(new Bonus() { DoCzego =StatystykiPostaci.Moc, Premia=5});

            var buty = new Przedmiot(TypPrzedmiotu.Buty, "kozaki'", 0.7);
            buty.Bonusy.Add(new Bonus() { DoCzego = StatystykiPostaci.Inteligencja, Premia = 7 });
            buty.Bonusy.Add(new Bonus() { DoCzego = StatystykiPostaci.Moc, Premia = 2 });


            postac.DodajPrzedmiotDoEkwipunku(helm);
            postac.DodajPrzedmiotDoEkwipunku(buty);
            // Act
            postac.Zaloz(CzescCiala.Glowa, helm);
            postac.Zaloz(CzescCiala.Stopy, buty);

            // Assert
            Assert.AreEqual(7,postac.BonusMoc);
            Assert.AreEqual(10, postac.BonusInteligencja);
            Assert.AreEqual(0, postac.BonusObrona);

        }
    }
}
