using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA12
{
      public abstract class ComputerBuilder
    {
        protected Computer computer;

        public void BuildComputer()
        {
            
                this.computer = new Computer();
                BuildCase();
                AddingMotherboard();
                AddingProcessor();
                AddingGraphicCard();
                AddingMemoryCard();
                RunTest();
            
        }
        public Computer GetComputer()
        {
            if (computer == null)
            {
                throw new ComputerNotReadyException("build a computer first");
            }
            return computer;
        }

        public abstract void BuildCase();
       
        public abstract void AddingMotherboard();

        public abstract void AddingProcessor();

        public abstract void AddingGraphicCard();

        public abstract void AddingMemoryCard();

        public abstract void RunTest();
      
    }
}
