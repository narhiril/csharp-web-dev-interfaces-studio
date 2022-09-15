using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IStorageDisc> AllMyDiscs = new List<IStorageDisc>(){
                new CD("Linkin Park - Meteora", 1024),
                new DVD("The Fellowship of the Ring Extended Edition", 2048),
                new VinylLP("Chillhop Fall Essentials 2021", 128),
                new Floppy("Windows 3.1 Install Disk", 16)
            };

            foreach(IStorageDisc disc in AllMyDiscs)
            {
                disc.SpinDisc();
            }

        }
    }
}
