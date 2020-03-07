using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA12
{
    class OfficeComputerBuilder : ComputerBuilder
    {
        public override void AddingGraphicCard()
        {
            computer.AddingGraphicCard("normal");
        }

        public override void AddingMemoryCard()
        {
            computer.AddingMemoryCard("normal");
        }

        public override void AddingMotherboard()
        {
            computer.AddingMotherboard("normal");
        }

        public override void AddingProcessor()
        {
            computer.AddingProcessor("normal");
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
