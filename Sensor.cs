using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{



    public class Sensor
    {
        public string Type;

        public Sensor(string type)
        {
            Type = type;
        }




        public static void Activate(IranianAgent agent)
        {
            int counter = 0;
            while (counter != 2)
            {

                Console.WriteLine("Insert sensor type");
                string type = Console.ReadLine();
                if (agent.Sensor.Contains(type))
                {
                    counter++;
                    Console.WriteLine($"You guessed it{counter}/{2}");
                }
                
                
                
            }
        }
    }
}
