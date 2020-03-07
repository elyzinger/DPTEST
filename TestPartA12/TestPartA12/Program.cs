using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ComputerBuilder> comBuilder = new List<ComputerBuilder>();
            comBuilder.Add(new GamingComputerBuilder());
            comBuilder.Add(new HouseComputerBuilder());
            comBuilder.Add(new OfficeComputerBuilder());

            Computer com = CreateCom(comBuilder[0]);
            Console.WriteLine(comBuilder[0]);
            Console.WriteLine(comBuilder[1].ToString());
        }

        static Computer CreateCom(ComputerBuilder builder)
        {
            builder.BuildComputer();
            return builder.GetComputer();

        }

        
    }
}
