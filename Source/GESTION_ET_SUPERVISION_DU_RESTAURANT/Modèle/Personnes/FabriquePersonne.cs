using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes.Salle;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes.Cuisine;


namespace GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes
{
    public class FabriquePersonne
    {
        public AEmploye CreateEmploye(Roles role)
        {
            AEmploye employe = null;
            switch (role)
            {
                case Roles.ChefDeCuisine:
                    employe = new ChefDeCuisine();
                    employe.Role = role;
                    break;

                case Roles.Cuisinier:
                    employe = new Cuisinier();
                    employe.Role = role;
                    break;

                case Roles.CommisDeCuisine:
                    employe = new CommisDeCuisine();
                    employe.Role = role;
                    break;

                case Roles.Plongeur:
                    employe = new Plongeur();
                    employe.Role = role;
                    break;

                case Roles.MaitreDHotel:
                    employe = new MaitreDHotel();
                    employe.Role = role;
                    break;

                case Roles.ChefDeRang:
                    employe = new ChefDeRang();
                    employe.Role = role;
                    break;

                case Roles.Serveur:
                    employe = new Serveur();
                    employe.Role = role;
                    break;


                case Roles.CommisDeSalle:
                    employe = new CommisDeSalle();
                    employe.Role = role;
                    break;
            }

            return employe;
        }

        public Client CreateClient(Caractere caractere)
        {
            Client client;
            switch (caractere)
            {
                case Caractere.Lent:
                    client = new Client();
                    client.Caractere = caractere;
                    break;
                case Caractere.Presse:
                    client = new Client();
                    client.Caractere = caractere;
                    break;
                default:
                    client = null;
                    break;
            }
            return client;
        }

    }
}
