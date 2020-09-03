using System;
using System.Collections.Generic;
using System.Text;

namespace C12_InterFaces_1
{
    class BandSaw : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Band saw has started.");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Band saw has stopped.");
            return true;
        }
    }
}
