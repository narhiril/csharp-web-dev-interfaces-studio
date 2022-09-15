using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IStorageDisc
    {
        int MinSpinRate { get; set; }

        int MaxSpinRate { get; set; }
        void SpinDisc();
    }
}
