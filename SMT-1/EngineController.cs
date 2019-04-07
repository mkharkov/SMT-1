using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace SMT_1
{
    public class EngineController
    {
        public bool On { get; set; } = false;

        private int rpm=300;

        public int RPM
        {
            get
            {
                return rpm;
            }
            set
            {
                if (value > 1000 || value < 300)
                    return;
                this.rpm = value;
                CalculateVoltage();
            }
        }

        public decimal Voltage
        {
            get;
            private set;
        }

        public EngineController()
        {
            RPM = 300;
        }



        private void CalculateVoltage()
        {
            Voltage = RPM * 2;// CHANGE WHEN FORMULA WILL BE KNOWN
        }
    }
}
