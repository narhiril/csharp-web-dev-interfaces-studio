﻿using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IStorageDisc
    {
        public CD (string name, int capacity) : base(name, capacity) 
        {
            MinSpinRate = 200;
            MaxSpinRate = 500;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"{Name} ({this.GetType().Name}) spins at between {MinSpinRate}rpm and {MaxSpinRate}rpm.");
        }
    }
}
