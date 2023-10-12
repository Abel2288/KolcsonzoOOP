using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Konyv : IKolcsonzo
	{

		string cim;
		string szerzo;
		string isbn;

		public Konyv(string cim, string szerzo, string isbn)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.isbn = isbn;
		}

		public int MeddigKolcsonozheto()
		{
			return 14; 
		}
		 
		public string MegjelenitendoNev()
		{
			return ($"{this.cim} - {this.szerzo} ");
		}

		
	
		
		
		
	}
}
