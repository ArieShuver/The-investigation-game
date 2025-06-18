using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.models;

namespace InvestigationGame
{
    public  class HelpFiles
    {
        public static string RandomName()
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




        public static SensorRegoler RandomSensor()
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
        //public void RandomAgent()
        //{
        //    List<IranianAgent> iranianAgents = new List<IranianAgent>()
        //    {

        //    };

        //}






