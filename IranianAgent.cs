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
        public List<string> Sensitive;
        public List<string> Sensors;


        public IranianAgent(string name, string rank,List<string>sensor)
        {
            Name = name;
            Rank = rank;
            Sensitive = sensor;
            Sensors = new List<string>();
        }
       
    }
}
