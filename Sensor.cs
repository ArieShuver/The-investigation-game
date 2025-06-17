using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{



    public class SensorRegoler
    {
        public string Type;

        public SensorRegoler(string type)
        {
            Type = type;
        }
        public virtual bool Activate(string sensor,IranianAgent agent)
        {
            if (Type == sensor)
            {
             
                {
                    return true;
                }
            }           
            return false;

        }
    }
}
