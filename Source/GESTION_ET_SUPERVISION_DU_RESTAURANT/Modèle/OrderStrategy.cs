using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes.Salle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle
{
    public interface IOrderStrategy
    {
        string order(string command, Client client, Serveur serveur);
    }
}
