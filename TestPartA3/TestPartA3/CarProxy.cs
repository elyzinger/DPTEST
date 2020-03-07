using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA3
{
    class CarProxy : IControlPROXY
    {

        public void ShowGasState()
        {
            IControlPROXY car1 = new Car();
             car1.ShowGasState();
        }

        public void ShowLocation()
        {
            IControlPROXY car1 = new Car();
            car1.ShowLocation();
        }
    }
}
