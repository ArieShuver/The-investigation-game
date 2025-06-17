using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.models;

namespace InvestigationGame
{
    public class PulseSensor : SensorRegoler
    {




        public PulseSensor(string type) : base(type)
        {
            Type = type;
        }




        public virtual bool Activate(SensorRegoler s, string sensor, IranianAgent agent)
        {
            if (s.Type == sensor)
            {
                int index = agent.Sensitive.IndexOf(s);

                if (agent.Conn > 3)
                {
                    agent.Listindexs.Remove(index);
                }
                else
                {

                    return true;

                }
            }
            agent.RaisingCounter();
            return false;
        }
    }
}