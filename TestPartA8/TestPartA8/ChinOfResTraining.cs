using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA8
{
       public abstract class ChinOfResTraining
    {
        protected ChinOfResTraining next;

        public void SetNext(ChinOfResTraining next)
        {
            this.next = next;
        }
        public abstract void Handle();
    }
}
