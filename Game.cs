using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.models;

namespace InvestigationGame
{
    public class Game
    {



        //public Game()
        //{

        //}





        public void GameStart()
        {
            //IranianAgent agent = factory();
            ActivateAll();
        }






        public void ActivateAll()
        {
            int conn = 0;
           
            IranianAgent agent = factory();

            while (conn <= 2)
            {
                Console.WriteLine("Insert sensor");
                string sensor = Console.ReadLine();
                foreach (SensorRegoler s in agent.Sensitive)
                {
                    
                    if (s.Activate(s,sensor,agent))
                    {
                        Console.WriteLine(1);
                        int index = agent.Sensitive.IndexOf(s);
                        if (!agent.Listindexs.Contains(index))
                        {
                            agent.Listindexs.Add(index);
                            Console.WriteLine(2);
                            conn++;

                            Console.WriteLine($"You guessed it{agent.Listindexs.Count()}/2");
                            break;
                        }
                    }
                }
            }
        }








        public IranianAgent factory()
        {
            List<SensorRegoler> sensors = new List<SensorRegoler>();
            for (int i = 0; i < 2; i++)
            {
                sensors.Add(RandomSensor());
            }
            IranianAgent agent = new IranianAgent(RandomName(), "junior", sensors);
            return agent;
        }









        public string RandomName()
        {
            List<string> iranianNames = new List<string>()
{
    "Ali",
    "Reza",
    "Hossein",
    "Mohammad",
    "Amir",
    "Mehdi",
    "Saeed",
    "Ehsan",
    "Mostafa",
    "Farhad"
};

            Random rand = new Random();
            string name = iranianNames[rand.Next(iranianNames.Count)];
            return name;
        }











        public SensorRegoler RandomSensor()
        {
            List<SensorRegoler> type = new List<SensorRegoler>()
            {
              new SensorRegoler("SensorRegoler"),
              new PulseSensor("PulseSensor")
            };

            Random rand = new Random();
            SensorRegoler typeSensor = type[rand.Next(type.Count)];
            Console.WriteLine(typeSensor.Type);
            return typeSensor;
        }

    }
}
