using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTGasStationService {
	public class Optankning {
		public int UnikId { get; set; }
		public int KundeNr { get; set; }
		public double AntalLiter { get; set; }

		public Optankning(int unikId, int kundeNr, double antalLiter) {
			UnikId = unikId;
			KundeNr = kundeNr;
			AntalLiter = antalLiter;
		}
		public Optankning() { }
	}
}