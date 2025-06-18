using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.models;

namespace InvestigationGame
{
    public class SquadLeader : IranianAgent
    {

        public SquadLeader(string name, string rank, List<SensorRegoler> sensor) :base (name,rank,sensor)
        { 

        }


        public override bool Attack(int num)
        {
            Random rand = new Random();
            if (num > 2)
            {
                this.Listindexs.Remove(rand.Next(0, this.Listindexs.Count));
                return true;
            }
        return false;
        }
    }
}
