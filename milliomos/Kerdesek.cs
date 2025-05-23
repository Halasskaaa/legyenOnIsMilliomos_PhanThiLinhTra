using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milliomos
{
	internal class Kerdesek
	{
		internal string Szoveg { get; }
		internal string[] Valaszok { get; }
		internal char HelyesValasz { get; }
		internal Kerdesek(string szoveg, string[] valaszok, char helyesValasz)
		
		{
			Szoveg = szoveg;

			Valaszok = valaszok;

			HelyesValasz = helyesValasz;
		}

		internal void Kiir()

		{

			Console.WriteLine(Szoveg);

			Console.WriteLine($"A: {Valaszok[0]}\tB: {Valaszok[1]}");

			Console.WriteLine($"C: {Valaszok[2]}\tD: {Valaszok[3]}");

		}

	}

}

 

	