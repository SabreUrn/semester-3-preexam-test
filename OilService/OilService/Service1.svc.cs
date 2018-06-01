using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OilService {
	public class Service1 : IService1 {
		CalcOil.CalcOil c = new CalcOil.CalcOil();

		public double LiterToGallons(double antalLiter) {
			return c.LiterToGallons(antalLiter);
		}

		public double LiterToOilBarrels(double antalLiter) {
			return c.LiterToOilBarrels(antalLiter);
		}

		public double GallonsToLiter(double gallons) {
			return gallons * 3.785;
		}

		public double OilBarrelsToLiter(double oilBarrels) {
			return GallonsToLiter(oilBarrels * 42);
		}
	}
}
