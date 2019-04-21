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
                if (value >= 300 && value <= 1000)
                {
                    this.rpm = value;
                    CalculateVoltage();
                }
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
            Voltage = RpmToVoltage(RPM);
        }

        public static decimal RpmToVoltage(int Rpm)
        {
            return Rpm * 2; // CHANGE WHEN FORMULA WILL BE KNOWN
        }
    }
}
