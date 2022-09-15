using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IStorageDisc
    {
        bool IsRewritable { get; set; }
        int Capacity { get; set; }
        int MinSpinRate { get; set; }

        int MaxSpinRate { get; set; }
        void SpinDisc();
    }
}
