using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA3
{
    class Car : ICarControl, IControlPROXY
    {
        public void EndDrive()
        {
             Console.WriteLine("ending drive");
        }

        public void IncreaseSpeed()
        {
             Console.WriteLine("increasing speed");
        }

        public void ShowGasState()
        {
             Console.WriteLine("gas state");
        }

        public void ShowLocation()
        {
             Console.WriteLine("showing location");
        }

        public void Slow()
        {
             Console.WriteLine("slowing down");
        }

        public void StartDrive()
        {
             Console.WriteLine("starting drive");
        }

        public void TurnLeft()
        {
             Console.WriteLine("turning left");
        }

        public void TurnRight()
        {
             Console.WriteLine("turning right");
        }
    }
}
