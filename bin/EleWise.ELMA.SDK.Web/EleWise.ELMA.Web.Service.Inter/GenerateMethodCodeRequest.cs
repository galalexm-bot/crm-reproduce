using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class GenerateMethodCodeRequest
{
	[DataMember]
	public string SourceCode { get; set; }

	[DataMember]
	public string ClassName { get; set; }

	[DataMember]
	public string MethodName { get; set; }

	[DataMember]
	public string ReturnType { get; set; }

	[DataMember]
	public string ReturnValue { get; set; }

	[DataMember]
	public List<ScriptMethodParameter> Parameters { get; set; }

	[DataMember]
	public string Description { get; set; }

	public GenerateMethodCodeRequest()
	{
		Parameters = new List<ScriptMethodParameter>();
	}
}
