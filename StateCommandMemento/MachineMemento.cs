﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class MachineMemento
    {
        public Machine Machine { get; set; }
        public IMachineState MachineState { get; set; }
        public List<ICommand> Commands { get; set; }

        public MachineMemento(Machine machine, IMachineState machineState, List<ICommand> commands)
        {
            Machine = machine;
            MachineState = machineState;
            Commands = commands;
        }

        public void Reset()
        {
            Machine.MachineState = new MachineOffState();
            Machine.Commands.Clear();
        }
    }
}
