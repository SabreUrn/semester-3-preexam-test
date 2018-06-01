using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OilService {
	[ServiceContract]
	public interface IService1 {

		[OperationContract]
		double LiterToGallons(double antalLiter);

		[OperationContract]
		double LiterToOilBarrels(double antalLiter);

		[OperationContract]
		double GallonsToLiter(double gallons);

		[OperationContract]
		double OilBarrelsToLiter(double oilBarrels);
	}

	
	[DataContract]
	public class CompositeType {

		//[DataMember]
	}
}
