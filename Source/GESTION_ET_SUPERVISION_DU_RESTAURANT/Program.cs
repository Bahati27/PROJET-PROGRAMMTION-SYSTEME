using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.BDD;

namespace GESTION_ET_SUPERVISION_DU_RESTAURANT
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //BDD BDD = new BDD();
            //BDD.updateStock("Endive aux Noix");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vue.RestaurantDisplay());

            /*IBDD setReservation = new BDD();
            setReservation.updateStock("Endive aux Noix");*/

        }
    }
}
