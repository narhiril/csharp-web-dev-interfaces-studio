using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public class VinylLP : BaseDisc, IStorageDisc
    {
        public bool IsRewritable { get; set; } = false;
        public int Capacity { get; set; }
        public VinylLP(string name, int capacity) : base(name)
        {
            Capacity = capacity;
            MinSpinRate = 33;
            MaxSpinRate = 78;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"{Name} ({this.GetType().Name}) spins at between {MinSpinRate}rpm and {MaxSpinRate}rpm.");
        }
    }
}
