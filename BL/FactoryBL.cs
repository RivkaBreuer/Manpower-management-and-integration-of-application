using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FactoryBL
    {
        static IBL bl = null;
        public static IBL GetBL()
        {
            if (bl == null)
            bl = new Bl_list();
            return bl;
        }
    }
}
