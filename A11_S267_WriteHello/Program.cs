using System;

namespace A11_S267_WriteHello
{

	class Program
	{
		static void WriteHello(string name)
		{
			if (String.IsNullOrEmpty(name))
				throw new ArgumentNullException("name");
			Console.WriteLine("Hello {0}", name);
		}
		static void WriteHello2(string name)
		{
			if (String.IsNullOrEmpty(name))
				throw new ArgumentNullException(nameof(name));
			Console.WriteLine("Hello {0}", name);
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your name");
			string name = Console.ReadLine().Trim();
			if (!String.IsNullOrEmpty(name))
				WriteHello(name);
			else
				Console.WriteLine("Warum machst du nie, was man dir sagt?");
		}
	}
}
