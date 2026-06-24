using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace EleWise.ELMA.Web.Service;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[Description("Null service for building service references")]
internal class EmptyPublicService
{
	[OperationContract]
	[Description("Null method for building service reference")]
	[WebGet(UriTemplate = "/NoService/EmptyMethod")]
	public void EmptyMethod()
	{
	}
}
