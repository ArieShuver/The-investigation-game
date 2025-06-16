using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{



    public class Sensor
    {
        public string Type;

        public Sensor(string type)
        {
            Type = type;
        }




        public static bool Activate(IranianAgent agent, string type)
        {
            if (agent.Sensitive.Contains(type))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
