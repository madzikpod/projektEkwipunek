using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjektEkwipunek.Test
{
    /// <summary>
    /// Summary description for TestPostaci
    /// </summary>
    [TestClass]
    public class TestPostaci
    {
        [TestMethod]
        public void TestZwiekszaniaStatystykWrazZLevelem()
        {
            // Arrange
            var postac = new TypowaGrazyna("Halina",1);
            var postac2 = new TypowaGrazyna("Grazyna", 10);
            var postac3 = new TypowaGrazyna("Grazyna", 25);
            // Act

            // Assert

            Assert.AreEqual(10, postac.Moc);
            Assert.AreEqual(15, postac2.Moc);
            Assert.AreEqual(22.5, postac3.Moc);

            Assert.AreEqual(10, postac.Obrona);
            Assert.AreEqual(15, postac2.Obrona);
            Assert.AreEqual(22.5, postac3.Obrona);

            Assert.AreEqual(30, postac.Udzwig);
            Assert.AreEqual(45, postac2.Udzwig);
            Assert.AreEqual(67.5, postac3.Udzwig);
        }
    }
}
