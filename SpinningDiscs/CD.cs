using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IStorageDisc
    {
        public bool IsRewritable { get; set; } = false;
        public int Capacity { get; set; }
        public CD (string name, int capacity) : base(name) 
        {
            Capacity = capacity;
            MinSpinRate = 200;
            MaxSpinRate = 500;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"{Name} ({this.GetType().Name}) spins at between {MinSpinRate}rpm and {MaxSpinRate}rpm.");
        }
    }
}
