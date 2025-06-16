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
            IranianAgent agent = factory();
            ActivateAll(agent);
        }





        public void ActivateAll(IranianAgent agent)

        {
            List<int> Listindexs = new List<int>();
            int conn = 0;

            while (conn < 2)
            {
                Console.WriteLine("Insert sensor");
                string sensor = Console.ReadLine();

                if (Sensor.Activate(agent, sensor))
                {
                    int index = agent.Sensitive.IndexOf(sensor);
                    if (!Listindexs.Contains(index))
                        conn++;
                    Listindexs.Add(agent.Sensitive.IndexOf(sensor));
                    Console.WriteLine($"You guessed it{conn}/2");
                }
            }
        }








        public IranianAgent factory()
        {
            List<string> sensors = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                sensors.Add(RandomSensor().Type);
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











        public Sensor RandomSensor()
        {
            List<string> type = new List<string>()
{
    "AudioSensor",

"ThermalSensor"
};
            Random rand = new Random();
            string typeSensor = type[rand.Next(type.Count)];
            Sensor sensor = new Sensor(typeSensor);
            Console.WriteLine(sensor.Type);
            return sensor;
        }

    }
}
