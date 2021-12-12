using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            // *** Machine Commands ***
            Console.WriteLine("*** Machine Commands ***");
            Machine machine1 = new();

            // Turn on machine, commands get executed immediately
            machine1.PowerSwitch();
            Console.WriteLine();
            machine1.AddCommand(new MachineCommand("Executing 1st command."));
            Console.WriteLine();
            machine1.AddCommand(new MachineCommand("Executing 2nd command."));

            // Turn off machine, commands do not execute
            Console.WriteLine();
            machine1.PowerSwitch();
            Console.WriteLine();
            machine1.AddCommand(new MachineCommand("Executing 3rd command."));
            machine1.AddCommand(new MachineCommand("Executing 4th command."));

            // Turn on machine, added commands during off state get executed
            Console.WriteLine();
            machine1.PowerSwitch();

            // *** Machine Reset ***
            Console.WriteLine();
            Console.WriteLine("*** Machine Reset ***");
            Machine machine2 = new();
            machine2.AddCommand(new MachineCommand("Executing 1st command."));
            machine2.AddCommand(new MachineCommand("Executing 2nd command."));
            machine2.AddCommand(new MachineCommand("Executing 3rd command."));
            MachineMemento machineMemento = machine2.CreateMemento();
            machine2.AddCommand(new MachineCommand("Executing 4th command."));
            machineMemento.Reset(); // Reset machine
            machine2.PowerSwitch(); // Turn on machine, commands are wiped
        }
    }
}