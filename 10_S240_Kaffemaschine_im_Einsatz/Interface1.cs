using System;
using System.Collections.Generic;
using System.Text;

namespace _10_S240_Kaffemaschine_im_Einsatz
{
    interface IHotDrink
    {
        int Degree { get; set; }
    }
    interface IHasCaffeine
    {
        float Caffeine { get; set; }
    }
}
