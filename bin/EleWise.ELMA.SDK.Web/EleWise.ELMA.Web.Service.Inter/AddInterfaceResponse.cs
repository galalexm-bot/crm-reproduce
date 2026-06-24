using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
public sealed class AddInterfaceResponse
{
	[DataMember]
	public string SourceCode { get; set; }
}
