using System;
using System.Collections.Generic;
using System.Text;

namespace C12_InterFaces_1
{
    interface ITrafficLight
    {
        

        Guid Id { get; set; }

        string Location { get; set; }
        void ChangeLight();
        void WarningLight();
        

    }
}
