using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			static void PrintPersonInfo(Person p)
			{
				if (p == null)
					throw new ArgumentNullException("p");
				if (p.Name == null)
					throw new ArgumentException("The Name property is null.", nameof(p));
				if (p.Name.Contains("Schrödinger"))
					Console.WriteLine("Unser Held: {0}", p.Name);
				else
					Console.WriteLine(p.Name);
			}
		}
	}
}
