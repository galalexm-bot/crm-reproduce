using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ParseMethodsRequest
{
	[DataMember]
	public string SourceCode { get; set; }
}
