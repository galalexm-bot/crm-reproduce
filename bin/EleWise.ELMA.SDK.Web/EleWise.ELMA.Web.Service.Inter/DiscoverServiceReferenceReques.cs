using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class DiscoverServiceReferenceRequest
{
	[DataMember]
	public string Uri { get; set; }

	[DataMember]
	public string Namespace { get; set; }

	[DataMember]
	public string ProjectName { get; set; }

	[DataMember]
	public string UserName { get; set; }

	[DataMember]
	public string Password { get; set; }

	[DataMember]
	public string Domain { get; set; }

	[DataMember]
	public string AuthenticationType { get; set; }
}
