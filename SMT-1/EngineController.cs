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
        public static int minRPM = 300;
        public static int maxRPM = 1000;

        public bool On { get; set; } = false;

        private int rpm= minRPM;

        public int RPM
        {
            get
            {
                return rpm;
            }
            set
            {
                if (value >= minRPM && value <= maxRPM)
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
            RPM = minRPM;
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
