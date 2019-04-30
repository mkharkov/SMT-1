using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMT_1
{
    class LoadController
    {
        public static int minLoad = 0;
        public static int maxLoad = 190;

        private int load = minLoad;

        public int Load
        {
            get
            {
                return load;
            }
            set
            {
                if (value >= minLoad && value <= maxLoad)
                    load = value;
            }
        }
    }
}
