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
        public List<SensorRegoler> Sensitive;
        public List<int> Listindexs = new List<int>();

        public int Conn;



        public IranianAgent(string name, string rank,List<SensorRegoler>sensor)
        {
            Name = name;
            Rank = rank;
            Sensitive = sensor;
            Conn = 0;

        }

        public void RaisingCounter()
        {
            Conn++;
        }
    }
}
