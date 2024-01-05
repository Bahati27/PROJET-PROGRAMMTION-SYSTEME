using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.BDD;
using System.Collections.Generic;

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
            BDD bdd = BDD.GetInstance();
            List<string> recettes = bdd.getRecette(categorie);

            // Assert
            CollectionAssert.AreEqual(recettesAttendues, recettes);
        }

        [TestMethod]
        public void TestGetPrice()
        {
            string nomRecettte = "Burger Vegan";
            int prixAttendu = 26;

            BDD bdd = BDD.GetInstance();
            int prix = bdd.getPrice(nomRecettte);

            Assert.AreEqual(prixAttendu, prix);
        }

        [TestMethod]
        public void TestGetEtape()
        {
            string nomRecettte = "Burger Vegan";
            List<string> etapesAttendues = new List<string> { "Cuire", "Preparation" };

            BDD bdd = BDD.GetInstance(); 
            List<string> etapes = bdd.getEtape(nomRecettte);

            CollectionAssert.AreEqual(etapesAttendues, etapes);
        }

        [TestMethod]
        public void TestGetRecette_CategorieInexistante()
        {
            string categorie = "Sortie";

            BDD bdd = BDD.GetInstance();
            List<string> recettes = bdd.getRecette(categorie);

            Assert.AreEqual(0, recettes.Count);
        }
    }
}
