using System;

namespace _10_S240_Kaffemaschine_im_Einsatz
{
    class Program
    {
        static void Main(string[] args)
        {
            IHotDrink[] hotDrinks = new IHotDrink[]
            {
                new Coffee() {Caffeine = 100, Degree = 90},
                new Tea {Degree = 95}
            };
            foreach (IHotDrink drink in hotDrinks)
            {
                Console.WriteLine("Temperatur von {0}: {1}",
                drink.GetType().Name,
                drink.Degree);
            }
        }
    }
}
