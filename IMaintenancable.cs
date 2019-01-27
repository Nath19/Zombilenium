using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    interface IMaintenancable
    {
        //fonction permettant de mettre en maintenance une attraction
        void MiseEnMaintenance(Attraction a, bool ouvert, string natureMaintenance, TimeSpan dureeMaintenance);
    }
}
