using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMT_1
{
    class LoadController
    {
        private int load = 0;

        public int Load
        {
            get
            {
                return load;
            }
            set
            {
                if (value >= 0 && value <= 190)
                    load = value;
            }
        }
    }
}
