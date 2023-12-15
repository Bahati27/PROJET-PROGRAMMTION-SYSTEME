using Microsoft.VisualStudio.TestTools.UnitTesting;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Lieux;
using System;

namespace TEST_GESTION_ET_SUPERVISION_DU_RESTAURANT
{
    [TestClass]
    public class TestLieux
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        [TestMethod]

        public void CuisineSingleton()
        {
            Cuisine cuisine1 = Cuisine.Instance;
            Cuisine cuisine2 = Cuisine.Instance;
            Assert.IsNotNull(cuisine1);
            Assert.AreEqual(cuisine1, cuisine2);
        }
    }
}
