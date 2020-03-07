using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA8
{
    class WeightLifting : ChinOfResTraining
    {
        public override void Handle()
        {
            if (next != null)
            {
                Console.WriteLine("weight lifting ");
                next.Handle();
            }
        }
    }
}
