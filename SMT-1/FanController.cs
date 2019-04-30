using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMT_1
{
    public class FanController
    {
        public bool On { get; set; }
        public bool VentOpen { get; set; }

        public FanController()
        {
            On = false;
            VentOpen = false;
        }
    }
}
