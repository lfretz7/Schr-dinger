using System;

namespace A11_S257_ArgumentNullException
{
    public class Person
    {
        public string Firstname { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Person p = new Person("Schrödinger");
                // p.ThrowException();
            }
            catch (ArgumentNullException ex) when (ex.InnerException != null)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Ups, bin hier!");
            }
        }
    }
}

