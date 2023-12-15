using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Lieux
{
    public class Cuisine
    {
        private static Cuisine _instance;


        private Cuisine()
        {

        }

        public static Cuisine Instance
        {
            get {
                return _instance;
            }
            
        }
    }
}
