using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_5
{
    internal class Car: Multipleinterface
    {
        private bool started = false;

        public void Start()
        {
            Console.WriteLine("Car started");
            started = true;
        }
        public void Stop() 
        {
            Console.WriteLine("Car stopped");
        }
        public bool Started
        {
            get{
                return started;
            }
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car turning left ");
        }
        public void TurnRight()
        {
            Console.WriteLine("Car turning right ");
        }
        public void Accelerate()
        {
            Console.WriteLine("Car turning Accelerating ");
        }
        public void brake()
        {
            Console.WriteLine("Car braking ");
        }
    }
}
