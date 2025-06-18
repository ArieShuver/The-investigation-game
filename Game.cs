using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame;
using InvestigationGame.models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InvestigationGame
{
    public class Game
    {


        public void GameStart()
        {
            IranianAgent agent = factory(1);

            ActivateAll(agent);

            IranianAgent agent2 = factory(2);

            ActivateAll(agent2);

        }








        public void ActivateAll(IranianAgent agent)
        {
            int CounterErrors = 0;

            while (agent.Sensitive.Count != agent.Listindexs.Count)
            {
                if (agent.Attack(CounterErrors))
                {
                    CounterErrors = 0;

                }
                Console.WriteLine("Insert sensor");
                string sensor = Console.ReadLine();
                for (int i = 0; i < agent.Sensitive.Count; i++)
                {
                    if (agent.Sensitive[i].Activate(sensor, agent))
                    {

                        if (!agent.Listindexs.Contains(i))
                        {
                            agent.Listindexs.Add(i);
                            Console.WriteLine($"You guessed it{agent.Listindexs.Count()}/{agent.Sensitive.Count}");

                            break;
                        }

                    }
                    //else
                    {
                        //CounterErrors++;
                        //Console.WriteLine($"No sensor found.You guessed it {agent.Listindexs.Count()}/{agent.Sensitive.Count}");
                    }

                   
                }
        
               
            }

        }
        







        public IranianAgent factory(int rank)
        {
            IranianAgent agent;
            if (rank == 1)
            {
                List<SensorRegoler> sensors = new List<SensorRegoler>();
                for (int i = 0; i < 2; i++)
                {
                    sensors.Add(HelpFiles.RandomSensor());
                }
                agent = new IranianAgent(HelpFiles.RandomName(), "junior", sensors);
                return agent;
            }
            else if (rank == 2)
            {
                List<SensorRegoler> sensors = new List<SensorRegoler>();
                for (int i = 0; i < 4; i++)
                {
                    sensors.Add(HelpFiles.RandomSensor());
                }
                agent = new SquadLeader(HelpFiles.RandomName(), "junior", sensors);
                return agent;
            }
            else
            {
                List<SensorRegoler> sensors = new List<SensorRegoler>();
                for (int i = 0; i < 2; i++)
                {
                    sensors.Add(HelpFiles.RandomSensor());
                }
                agent = new IranianAgent(HelpFiles.RandomName(), "junior", sensors);
                return agent;
            }
        }
    }
}


















