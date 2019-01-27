using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POOI_GRA_AMAR_AMAR
{
    class Program
    {
        #region main
        static void Main(string[] args)
        {

            Administration admin = new Administration();

            admin.peuplement();
            admin.menu();
            Console.ReadKey();
        }
        #endregion
    }


}
