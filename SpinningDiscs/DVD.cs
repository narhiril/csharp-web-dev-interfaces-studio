using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IStorageDisc
    {
        public DVD (string name, int capacity) : base(name, capacity) 
        {
            MinSpinRate = 560;
            MaxSpinRate = 1600;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"{Name} ({this.GetType().Name}) spins at between {MinSpinRate}rpm and {MaxSpinRate}rpm.");
        }
    }
}
