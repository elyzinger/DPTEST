using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA12
{
     public class Computer
    {
        private List<string> parts = new List<string>();
        public Computer()
        {

        }
        public void BuildCase(string cumputerCase)
        {
            parts.Add(cumputerCase);
        }
        public void AddingMotherboard(string motherboard)
        {
            parts.Add(motherboard);
        }
        public void AddingProcessor(string processor)
        {
            parts.Add(processor);
        }
        public void AddingGraphicCard(string graphicCard)
        {
            parts.Add(graphicCard);
        }
        public void AddingMemoryCard(string memoryCard)
        {
            parts.Add(memoryCard);
        }
        public void RunTest()
        {
            Console.WriteLine("runing test");
        }
       
    }
}
