
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes.Salle;

namespace TEST_GESTION_ET_SUPERVISION_DU_RESTAURANT
{
    [TestClass]
    public class TestPersonnesFrabrique
    {
        private FabriquePersonne _fabrique;

        public TestPersonnesFabrique()
        {
            _fabrique = new FabriquePersonne();
            Assert.IsNotNull(_fabrique);
        }


        [TestMethod]
        public void PersonneFactory()
        {
            //Object[] paramCli = { "Test", Caractere.Lent, Gouts.Salé, true,  };
            //Object[] paramEmp = { "Jacque" };
            var VchefDeCuisine = Roles.ChefDeCuisine;
            var Vclient = Caractere.Lent;

            var newPersonne = _fabrique.CreateClient(Vclient);
            var newEmploye = _fabrique.CreateEmploye(VchefDeCuisine);

            Assert.AreEqual(newEmploye.Role, VchefDeCuisine);
            Assert.AreEqual(newPersonne.Caractere, Vclient);
        }
    }
}
