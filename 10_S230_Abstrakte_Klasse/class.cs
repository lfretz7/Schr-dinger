using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrakte.KLasse
{
    public abstract class Shape
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public ConsoleColor Color { get; set; }
        public abstract void Draw();
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            //Zeichnen simulieren
            Console.WriteLine("Zeichne Rechteck");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            //Zeichnen simulieren
            Console.WriteLine("Zeichne Kreis");
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            //Zeichnen simulieren
            Console.WriteLine("Zeichne Dreieck");
        }
    }
    class ShapeFactory
    {
        public static Shape GetShape()
        {
            return new Rectangle();
        }
    }

}
