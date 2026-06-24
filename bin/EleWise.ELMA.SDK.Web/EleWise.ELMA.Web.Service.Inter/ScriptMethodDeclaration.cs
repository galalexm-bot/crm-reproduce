using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ScriptMethodDeclaration
{
	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public string ReturnType { get; set; }

	[DataMember]
	public List<ScriptMethodParameter> Parameters { get; set; }

	[DataMember]
	public string Signature { get; set; }

	[DataMember]
	public string Description { get; set; }

	[DataMember]
	public string DisplayInfo { get; set; }

	public ScriptMethodDeclaration()
	{
		Parameters = new List<ScriptMethodParameter>();
	}
}
