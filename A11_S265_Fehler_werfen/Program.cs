using System;

namespace A11_S265_Fehler_werfen
{
	public class SchroedingerException : Exception
	{

	}
	public class SchroedingerArgumentException : ArgumentException
	{

	}

	class Program
	{
		static void Main(string[] args)
		{
			throw new Exception("Tja, so einfach kannst du einen Fehler auslösen!");

		}
	}
}
