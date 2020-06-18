using Abstrakte.KLasse;
using System;

namespace _10_S230_Abstrakte_Klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle();
            s.Draw();

            Shape myShape = ShapeFactory.GetShape();
            myShape.Draw();
        }
    }
}
