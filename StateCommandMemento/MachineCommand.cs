using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class MachineCommand : ICommand
    {
        //public Machine Machine { get; set; }
        public string UserInput { get; set; }

        public MachineCommand(string userInput)
        {
            //Machine = machine;
            UserInput = userInput;
        }

        public void Execute()
        {
            Console.WriteLine(UserInput);
        }
    }
}
