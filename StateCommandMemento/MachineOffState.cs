using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class MachineOffState : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning on machine.");
        }
    }
}
