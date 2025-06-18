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

            for (int i = 1; i < 3; i++)
            {
                IranianAgent agent = Fectorys.FactoryAgent(i);
                ActivateAll(agent);

            }
            //IranianAgent agent = Fectorys.FactoryAgent(1);

            //ActivateAll(agent);

            //IranianAgent agent2 = Fectorys.FactoryAgent(2);

            //ActivateAll(agent2);

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

    }
}


















