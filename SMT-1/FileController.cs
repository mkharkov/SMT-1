using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace SMT_1
{
    public class FileController
    {
        public static string FileFormatString = "time=100; speed=600; load=30; t1=20; t2=25";
        public static string ApplyTemplate(string time, string speed, string load, string t1, string t2)
        {
            return String.Format("time={0}; speed={1}; load={2}; t1={3}; t2={4}", time, speed, load, t1, t2);
        }

        private List<PlanRecord> buffer = new List<PlanRecord>();
        public List<PlanRecord> GetRecords() => buffer;

        string filePath = "";
        public string GetFilePath() => filePath;
        public bool LoadFromFile(string fileName)
        {
            if (ParseAndValidate(fileName))
            {
                filePath = fileName;
                return true;
            }

            return false;
        }

        public bool SaveToFile(string fileName, List<string> data)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(fileName))
                {
                    foreach (string s in data)
                        tw.WriteLine(s);
                }
            } catch {
                return false;
            }
            return true;
        }

        private bool ParseAndValidate(string fileName)
        {
            foreach (string line in File.ReadAllLines(fileName))
            {
                //string[] kv = record.Split(';');
                string record = line.Replace(" ", "");
                PlanRecord pr = new PlanRecord();
                foreach (string kvs in record.Split(';'))
                {
                    string[] kv = kvs.Split('=');
                    bool isParsed = false;
                    switch(kv[0].ToLower())
                    {
                        case "time":
                            TimeSpan time = new TimeSpan();
                            isParsed = TimeSpan.TryParse(kv[1], out time);
                            if(!isParsed || !pr.SetTime(time))
                                return false;
                            break;
                        case "speed":
                            int speed = -1;
                            isParsed = int.TryParse(kv[1], out speed);
                            if (!isParsed || !pr.SetSpeed(speed))
                                return false;
                            break;
                        case "load":
                            int load = -1;
                            isParsed = int.TryParse(kv[1], out load);
                            if (!isParsed || !pr.SetLoad(load))
                                return false;
                            break;
                        case "t1":
                            int t1 = -1;
                            isParsed = int.TryParse(kv[1], out t1);
                            if (!isParsed || !pr.SetT1(t1))
                                return false;
                            break;
                        case "t2":
                            int t2 = -1;
                            isParsed = int.TryParse(kv[1], out t2);
                            if (!isParsed || !pr.SetT2(t2))
                                return false;
                            break;
                        default:
                            return false;
                    }
                }
                buffer.Add(pr);
            }
            return true;
        }
    }
}
