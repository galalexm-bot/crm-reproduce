using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class GenerateMethodCodeResponse
{
	[DataMember]
	public string MethodSourceCode { get; set; }

	[DataMember]
	public int InsertPosition { get; set; }
}
