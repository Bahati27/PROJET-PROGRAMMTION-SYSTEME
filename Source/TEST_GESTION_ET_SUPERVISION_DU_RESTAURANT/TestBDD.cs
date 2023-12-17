using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TEST_GESTION_ET_SUPERVISION_DU_RESTAURANT
{
    [TestClass]
    public class TestBDD
    {
        [TestMethod]
        public void TestGetRecette()
        {
            // Arrange
            string categorie = "Plat";
            List<string> recettesAttendues = new List<string> { "Burger Vegan", "Steak Frites" };

            // Act
            List<string> recettes = getRecette(categorie);

            // Assert
            CollectionAssert.AreEqual(recettesAttendues, recettes);
        }

        [TestMethod]
        public void TestGetPrice()
        {
            string nomRecettte = "Burger Vegan";
            int prixAttendu = 26;

            int prix = getPrice(nomRecettte);

            Assert.AreEqual(prixAttendu, prix);
        }

        [TestMethod]
        public void TestGetEtape()
        {
            string nomRecettte = "Burger Vegan";
            List<string> etapesAttendues = new List<string> { "Cuire", "Preparation" };

            List<string> etapes = getEtape(nomRecettte);

            CollectionAssert.AreEqual(etapesAttendues, etapes);
        }

        [TestMethod]
        public void TestGetRecette_CategorieInexistante()
        {
            string categorie = "Sortie";

            List<string> recettes = getRecette(categorie);

            Assert.AreEqual(0, recettes.Count);
        }
    }
}
