using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTGasStationService {
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service1 : IService1 {
		private static List<Optankning> optankningList = new List<Optankning>();

		public IList<Optankning> GetAllOptanknings() {
			return optankningList;
		}

		public IList<Optankning> GetKundesOptanknings(int id) {
			List<Optankning> list = new List<Optankning>();
			foreach(Optankning o in optankningList) {
				if (o.KundeNr == id) list.Add(o);
			}
			return list;
		}

		public void InsertOptankning(Optankning optankning) {
			if (optankningList != null) optankningList.Add(optankning);
		}
	}
}
