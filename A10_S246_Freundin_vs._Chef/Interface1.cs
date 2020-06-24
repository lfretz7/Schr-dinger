using System;
using System.Collections.Generic;
using System.Text;

namespace A10_S246_Freundin_vs._Chef
{
   interface IEmployee
    {
        string Name { get; set; }
        void GetCalled();
        void GetFired();
    }
   interface IFriend
    {
        string Name { get; set; }
        void GetCalled();
        void BeCool();
    }
}
