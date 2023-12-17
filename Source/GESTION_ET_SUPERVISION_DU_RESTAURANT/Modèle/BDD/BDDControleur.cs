using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.BDD
{
    class BDDControleur
    {
        IBDD Bdd = new BDD();

        public void getReservation()
        {
            Bdd.getReservation();
        }

        public void setReservation(string Nom, int nbPersonne, int Heure)
        {
            Bdd.setReservation(Nom, nbPersonne, Heure);
        }

        public void updateStock(string recette, int quantite = 1)
        {
            Bdd.updateStock(recette, quantite);
        }

        public List<string> getRecette(string categorie)
        {
            return Bdd.getRecette(categorie);
        }

        public void reStock()
        {
            Bdd.reStock();
        }

        public List<string> getEtape(string recette)
        {
            return Bdd.getEtape(recette);
        }

        public int getPrix(string recette)
        {
            return Bdd.getPrice(recette);
        }
    }
}
