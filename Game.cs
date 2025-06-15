using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.models;

namespace InvestigationGame
{
    public class Game
    {



        public Game()
        {

        }





        public void GameStart()
        {

            List<string> sensors = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                sensors.Add(RandomSensor().Type);
            }
            IranianAgent agent = new IranianAgent(RandomName(), "junior", sensors);

            Sensor.Activate(agent);




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
            return sensor;
        }

    }
}
