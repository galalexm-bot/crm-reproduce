using System.Runtime.Serialization;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ActionExecutionResponse
{
	[DataMember]
	public object Result { get; set; }

	[DataMember]
	public ClientComponentModel[] AdditionalComponentModels { get; set; }

	[DataMember]
	public string ExceptionMessage { get; set; }

	[DataMember]
	public string ExceptionStackTrace { get; set; }

	public ActionExecutionResponse()
	{
		AdditionalComponentModels = new ClientComponentModel[0];
	}
}
