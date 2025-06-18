using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.models;

namespace InvestigationGame
{
    public class Fectorys
    {
        public static IranianAgent FactoryAgent(int rank)
        {
            IranianAgent agent;

            switch (rank)
            {
                case 1:
                    
                    agent = new IranianAgent(HelpFiles.RandomName(), "junior", FactorySensor(2));
                    return agent;

                    break;


                case 2:

                    FactorySensor(4);
                    agent = new SquadLeader(HelpFiles.RandomName(), "junior", FactorySensor(4));
                    return agent;

                    break;


                case 3:

                    FactorySensor(8);
                    agent = new IranianAgent(HelpFiles.RandomName(), "junior", FactorySensor(8));
                    return agent;

                    break;

                default:
                    throw new ArgumentException("Invalid rank: " + rank);

            }





        }
        public static List<SensorRegoler> FactorySensor(int num)
        {
            List<SensorRegoler> ListSensors = new List<SensorRegoler>();
            for (int i = 0; i < num; i++)
            {
                ListSensors.Add(HelpFiles.RandomSensor());
            }
            return ListSensors;
        }
    }
}
