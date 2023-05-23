using System;
using System.Collections.Generic;
using System.Text;

namespace _230427_NotebookCollection
{
    class Notebook
    {
        // membervars and properties (attributes)
        private string brand; // membervariable
        public string Brand // property for a member variable
        {
            get { return brand; }
        }

        public long RAM { get; set; } // property ONLY

        // ctors
        public Notebook(string brand)
        {
            this.brand = brand; // this.brand uses the brand form the membervariable
        }

        // methods
    }
}
