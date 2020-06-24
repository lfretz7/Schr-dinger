using System;
using System.Collections.Generic;
using System.Text;

namespace _10_S240_Kaffemaschine_im_Einsatz
{
    class Tea : IHotDrink
    {
        public int Degree { get; set; } 
    }
    class Coffee : IHasCaffeine, IHotDrink
    {
        public int Degree { get; set; }
        public float Caffeine { get; set; }
    }
    class Coke : IHasCaffeine
    {
        public float Caffeine { get; set; }
    }
}
