using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA8
{
    class PreWorkout : ChinOfResTraining
    {
        public override void Handle()
        {
            if (next != null)
            {
                Console.WriteLine("pre workout");
                next.Handle();
            }
        }
    }
}
