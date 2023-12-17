using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Lieux;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes.Salle;
using System.Collections.Generic;

namespace TEST_GESTION_ET_SUPERVISION_DU_RESTAURANT
{
    [TestClass]
    public class TestTable
    {
        [TestMethod]
        public void TestPropertiesTable()
        {
            int posX = 3; 
            int posY = 3;
            int size = 6;

            Table table = new Table(posX, posY, size);

            Assert.AreEqual(posX, table.PosX);
            Assert.AreEqual(posY, table.PosY);
            Assert.AreEqual(size, table.Size);
        }

        [TestMethod]
        public void TestAddClient_SingleClient()
        {
            // Arrange
            Table table = new Table(1, 1, 4);
            Client client = new Client();

            // Act
            table.AddClient(new List<Client> { client });

            // Assert
            Assert.AreEqual(1, table.Clients.Count);
            Assert.AreEqual(1, client.PosX);
            Assert.AreEqual(1, client.PosY);
        }
    }
}
