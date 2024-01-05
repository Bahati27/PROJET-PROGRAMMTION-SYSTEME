using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes.Salle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle
{
    public class CommandContext
    {
        private string command;
        private bool isServed;
        private IOrderStrategy strategy;

        public void setStrategy(IOrderStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string executeCommand(string command, Client client, Serveur serveur) 
        {
            return strategy.order(command, client, serveur);
        }
    }
}
