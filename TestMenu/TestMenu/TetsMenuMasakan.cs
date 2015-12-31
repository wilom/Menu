using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MenuProject.App;
using System.Collections.Generic;
using Moq;


namespace TestMenu
{
    [TestClass]
    public class TetsMenuMasakan
    {
        [TestMethod]
        public void testKokiMemasakAyamGoreng()
        {
            Menu menu = new Menu("MAG", "Ayam Goreng", "AG");
            Assert.AreEqual("AG", menu.FinishGoodId);
            Assert.AreEqual("MAG", menu.Id);
            Assert.AreEqual("Ayam Goreng", menu.Name);
        }

        [TestMethod]
        public void TestMenambahResep()
        {
            Menu menu = new Menu("MAG", "Ayam Goreng", "AG");
            menu.MenambahResep("A", 1);
            List<ItemResep> resep = menu._resep;
            Assert.AreEqual(1, resep.Count);
            ItemResep bahan1 = resep[0];
            Assert.AreEqual("A", bahan1.ProductId);
            Assert.AreEqual(1, bahan1.Qty);
        }

       

    }
}
