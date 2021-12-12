using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            // Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts
            PrintingInts printingInts = new();
            ReturningStringsAdapter returningStringsAdapter = new();
            printingInts.Print(returningStringsAdapter.ReturnString());
        }
    }
}
