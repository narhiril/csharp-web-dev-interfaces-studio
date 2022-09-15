using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public class Floppy : BaseDisc, IStorageDisc
    {
        public Floppy(string name, int capacity) : base(name, capacity)
        {
            MinSpinRate = 1;
            MaxSpinRate = 4;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"{Name} ({this.GetType().Name}) spins at between {MinSpinRate}rpm and {MaxSpinRate}rpm.");
        }
    }
}
