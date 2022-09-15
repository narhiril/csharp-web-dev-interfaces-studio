using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public int MinSpinRate { get; set; }
        public int MaxSpinRate { get; set; }

        public string Name { get; set; }

        public BaseDisc(string name)
        {
            Name = name;
        }

    }
}
