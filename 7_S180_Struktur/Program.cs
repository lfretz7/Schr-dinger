using System;

namespace _7_S180_Struktur
{
    class Program
    {
        struct eigenerDatentyp
        {
            public int Eigenschaft1 { get; set; }
            public bool Eigenschaft2 { get; set; }
        }
        static void Main(string[] args)
        {
            eigenerDatentyp meineVariable1 = new eigenerDatentyp();
            meineVariable1.Eigenschaft1 = 100;
            meineVariable1.Eigenschaft2 = true;
        }
    }
}
