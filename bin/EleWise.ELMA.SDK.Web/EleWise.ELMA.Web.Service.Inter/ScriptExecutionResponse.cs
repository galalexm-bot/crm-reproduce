using System.Runtime.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ScriptExecutionResponse
{
	[DataMember]
	public WebData Model { get; set; }

	[DataMember]
	public object Item { get; set; }

	[DataMember]
	public ClientComponentModel[] AdditionalComponentModels { get; set; }

	[DataMember]
	public string ExceptionMessage { get; set; }

	[DataMember]
	public string ExceptionStackTrace { get; set; }

	[DataMember]
	public FormViewBuilderInfo FormViewBuilderInfo { get; set; }

	[DataMember]
	public string RedirectUrl { get; set; }

	[DataMember]
	public object ReturnValue { get; set; }

	public ScriptExecutionResponse()
	{
		AdditionalComponentModels = new ClientComponentModel[0];
	}
}
