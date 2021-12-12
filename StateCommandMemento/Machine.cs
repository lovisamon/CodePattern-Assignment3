using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class Machine
    {
        public IMachineState MachineState { get; set; }
        public List<ICommand> Commands { get; set; }

        public Machine()
        {
            MachineState = new MachineOffState();
            Commands = new List<ICommand>();
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if(MachineState is MachineOffState)
            {
                MachineState = new MachineOnState();
                ExecuteCommands();
            }
            else
            {
                MachineState = new MachineOffState();
            }
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, MachineState, Commands);
        }

        public void AddCommand(ICommand command)
        {
            Commands.Add(command);
            Console.WriteLine("Add command.");

            if (MachineState is MachineOnState)
            {
                command.Execute();
                Commands.Remove(command);
            }
        }

        public void ExecuteCommands()
        {
            if(Commands.Count > 0)
            {
                foreach(var command in Commands.ToList())
                {
                    command.Execute();
                    Commands.Remove(command);
                }
            }
            else
            {
                Console.WriteLine("No saved commands were found.");
            }
        }
    }
}
