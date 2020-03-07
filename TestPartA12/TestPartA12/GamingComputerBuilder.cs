using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA12
{
    class GamingComputerBuilder : ComputerBuilder
    {
        public override void AddingGraphicCard()
        {
            computer.AddingGraphicCard("strong graphicCard");
        }

        public override void AddingMemoryCard()
        {
            computer.AddingMemoryCard("lots of memory");
        }

        public override void AddingMotherboard()
        {
            computer.AddingMotherboard("normal");
        }

        public override void AddingProcessor()
        {
            computer.AddingProcessor("strong Processor");
        }

        public override void BuildCase()
        {
            computer.BuildCase("normal");
        }

        public override void RunTest()
        {
            computer.RunTest();
        }
    }
}
