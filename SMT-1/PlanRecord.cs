using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMT_1
{
    public class PlanRecord
    {
        private TimeSpan time;
        private int speed;
        private int load;
        private int t1;
        private int t2;

        public PlanRecord()
        {
            time = new TimeSpan(0,0,0);
            speed = 300;
            load = 0;
            t1 = 0;
            t2 = 0;
        }

        public TimeSpan GetTime() => time;
        public int GetSpeed() => speed;
        public int GetLoad() => load;
        public int GetT1() => t1;
        public int GetT2() => t2;

        public bool SetTime(TimeSpan t)
        {
            time = t; // Можливо тут потрібна якась умова або обмеження максимуму часу
            return true;
        }

        public bool SetSpeed(int s)
        {
            if (s>=300 || s<=1000)
            {
                speed = s;
                return true;
            }
            return false;
        }

        public bool SetLoad(int l)
        {
            if(l>=0 || l<=50)
            {
                load = l;
                return true; 
            }
            return false;
        }

        public bool SetT1(int t)
        {
            if(t>=0 || t<=125)
            {
                t1 = t;
                return true;
            }
            return false;
        }

        public bool SetT2(int t)
        {
            if(t>=0 || t<=125)
            {
                t2 = t;
                return true;
            }
            return false;
        }
    }
}
