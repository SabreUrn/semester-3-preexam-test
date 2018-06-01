using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTGasStationService {
	[ServiceContract]
	public interface IService1 {
		[OperationContract]
		[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "optankning/")]
		IList<Optankning> GetAllOptanknings();

		[OperationContract]
		[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "optankning?id={id}")]
		IList<Optankning> GetKundesOptanknings(int id);

		[OperationContract]
		[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "optankning/")]
		void InsertOptankning(Optankning optankning);
	}


	[DataContract]
	public class CompositeType {
		bool boolValue = true;
		string stringValue = "Hello ";

		[DataMember]
		public bool BoolValue {
			get { return boolValue; }
			set { boolValue = value; }
		}

		[DataMember]
		public string StringValue {
			get { return stringValue; }
			set { stringValue = value; }
		}
	}
}
