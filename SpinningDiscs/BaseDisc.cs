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
        public int Capacity { get; set; }

        public bool IsRewritable { get; set; } = false;

        public BaseDisc(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

    }
}
