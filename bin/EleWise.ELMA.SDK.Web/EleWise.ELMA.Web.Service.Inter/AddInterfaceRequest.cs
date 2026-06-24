using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class AddInterfaceRequest
{
	[DataMember]
	public string SourceCode { get; set; }

	[DataMember]
	public string ClassName { get; set; }

	[DataMember]
	public string InterfaceName { get; set; }
}
