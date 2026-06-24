using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ScriptMethodParameter
{
	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public string Type { get; set; }

	[DataMember]
	public string Description { get; set; }
}
