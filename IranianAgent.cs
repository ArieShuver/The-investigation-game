using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    public class IranianAgent
    {
        public string Name;
        public string Rank;
        public List<string> Sensor;

        public IranianAgent(string name, string rank,List<string>sensor)
        {
            Name = name;
            Rank = rank;
            Sensor = sensor;
        }
       
    }
}
