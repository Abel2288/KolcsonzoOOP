using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{

         List<IKolcsonzo> Katalogus= new List<IKolcsonzo>();

			

			Konyv k1 = new Konyv("Harry Potter", "J. K. Rowling", "456-12-12");
			Konyv k2 = new Konyv("Harry Potter 2", "J. K. Rowling", "421-64-12");
			Konyv k3 = new Konyv("Jaws", "Peter Benchley", "854-14-13");
			Dvd d1 = new Dvd("Kis vakond",64);
			Dvd d2 = new Dvd("Verdak", 106);
			Dvd d3 = new Dvd("Verdak 2", 94);
			Ujsag u1 = new Ujsag("Pesti Hirlap", 2003, 12);
			Ujsag u2 = new Ujsag("Pesti Hirlap", 2006, 6);
			Ujsag u3 = new Ujsag("Pesti Hirlap", 2000, 5);
			Katalogus.Add(u1);
			Katalogus.Add(u2);
			Katalogus.Add(u3);
			Katalogus.Add(d1);
			Katalogus.Add(d2);
		    Katalogus.Add(d3);
			Katalogus.Add(k1);
			Katalogus.Add(k2);
			Katalogus.Add(k3);
			foreach (var k in Katalogus)
			{
                Console.WriteLine($"{k.MegjelenitendoNev()} - {k.MeddigKolcsonozheto()}");
            }


			List<Dvd> Irottcdtarto = new List<Dvd>();


			Dvd cd1 = new Dvd("Horrora Akdava1", 112);
			Dvd cd2 = new Dvd("Horrora Akdava2", 98);
			Dvd cd3 = new Dvd("Horrora Akdava3", 125);
			Dvd cd4 = new Dvd("Tancolo Talpak", 100);
			Dvd cd5 = new Dvd("We live we Love mano",18);
			Irottcdtarto.Add(cd1);
			Irottcdtarto.Add(cd2);
			Irottcdtarto.Add(cd3);
			Irottcdtarto.Add(cd4);
			Irottcdtarto.Add(cd5);



			Console.ReadLine();




		}
		
	}
}
