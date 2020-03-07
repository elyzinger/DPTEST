using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA12
{
    class HouseComputerBuilder : ComputerBuilder
    {
        public override void AddingGraphicCard()
        {
            computer.AddingGraphicCard("strong");
        }

        public override void AddingMemoryCard()
        {
            computer.AddingMemoryCard("normal");
        }

        public override void AddingMotherboard()
        {
            computer.AddingMotherboard("very thin case");
        }

        public override void AddingProcessor()
        {
            computer.AddingProcessor("normal");
        }

        public override void BuildCase()
        {
            computer.BuildCase("thin case");
        }

        public override void RunTest()
        {
            computer.RunTest();
        }
    }
}
