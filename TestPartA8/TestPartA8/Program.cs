using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA8
{
    class Program
    {
        static void Main(string[] args)
        {
            ChinOfResTraining root = new PreWorkout();
            ChinOfResTraining aerobic = new Aerobic();
            ChinOfResTraining weightLifting = new WeightLifting();
            ChinOfResTraining tension = new Tension();

            root.SetNext(aerobic);
            aerobic.SetNext(weightLifting);
            weightLifting.SetNext(tension);
            tension.SetNext(null);
            Console.WriteLine("heyy!!");
            root.Handle();
            Console.WriteLine("hello!!!!!!!!!!!!!!!!!");
        }
    }
}
