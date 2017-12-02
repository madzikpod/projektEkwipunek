using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjektEkwipunek.Test
{
    /// <summary>
    /// Summary description for TestPrzedmiotu
    /// </summary>
    [TestClass]
    public class TestPrzedmiotu
    {
        [TestMethod]
        public void TestTworzeniePrzedmiotuZeZlaWaga()
        {
            Assert.ThrowsException<ArgumentException>(() => { var t = new Przedmiot(TypPrzedmiotu.Bron, "Patelnia", 0); });
            Assert.ThrowsException<ArgumentException>(() => { var t = new Przedmiot(TypPrzedmiotu.Bron, "Patelnia", -2); });
        }
        [TestMethod]
        public void TestTworzeniePrzedmiotuZeZlaNazwa()
        {
            Assert.ThrowsException<ArgumentException>(() => { var t = new Przedmiot(TypPrzedmiotu.Bron, "", 5); });
            Assert.ThrowsException<ArgumentException>(() => { var t = new Przedmiot(TypPrzedmiotu.Bron, null, 2); });
        }

    }
}
