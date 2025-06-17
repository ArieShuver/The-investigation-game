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

        public int Conn = 0;


        public PulseSensor(string type) : base(type)
        {
            Type = type;
        }




        public override bool Activate(string sensor, IranianAgent agent)
        {
            RaisingCounter();

            if (Type == sensor)
            {
                int index = agent.Sensitive.IndexOf(this);

                if (Conn > 3)
                {
                    agent.Listindexs.Remove(index);
                    Conn = 0;
                    return true;
                }
                else
                {

                    return true;

                }
            }
            return false;
        }




        public void RaisingCounter()
        {
            Conn++;
        }
    }

}