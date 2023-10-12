using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Ujsag : IKolcsonzo
	{
		private string cim;
		private int KiadasEv;
		private int KiadasHet;

		public Ujsag(string cim, int kiadasEv, int kiadasHet)
		{
			this.cim = cim;
			KiadasEv = kiadasEv;
			KiadasHet = kiadasHet;
		}

		public int MeddigKolcsonozheto()
		{
			return 0;
		}

		public string MegjelenitendoNev()
		{
			return ($"{this.cim} {this.KiadasEv }/{this.KiadasHet}");
		}

	}
}
