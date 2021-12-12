using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class ReturningStringsAdapter
    {
        public ReturningStrings ReturningStrings { get; set; }

        public ReturningStringsAdapter()
        {
            ReturningStrings = new ReturningStrings();
        }

        public int ReturnString()
        {
            return Int32.Parse(ReturningStrings.ReturnString());
        }
    }
}
