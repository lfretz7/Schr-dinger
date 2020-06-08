using System;

namespace _7_S170_Instanz_Methode
{
    class Program
    {
        class Position
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
        }
        class WoWCharacter
        {
            public int Health { get; private set; }
            public int Level { get; private set; }
            public Position Position { get; private set; }
            public float Strength { get; set; }
            public float Agility { get; set; }
            public float Speed { get; set; }
            public void Attack(WoWCharacter character)
            {
             
            }
            public void Move(Position newposition)
            {

            }
            public void Die()
            {

            }

        }
        static void Main(string[] args)
        {
          
        }
    }
}
