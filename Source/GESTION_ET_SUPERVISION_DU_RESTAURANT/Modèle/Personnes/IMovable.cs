using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes
{
    public interface IMovable
    {
        void avancer();
        void reculer();
        void lateral();
        void noMobile();

    }
}
