using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartA3
{
    interface ICarControl
    {
        void StartDrive();
        void EndDrive();
        void IncreaseSpeed();
        void Slow();
        void TurnLeft();
        void TurnRight();
        void ShowGasState();
        void ShowLocation();
    }
}
