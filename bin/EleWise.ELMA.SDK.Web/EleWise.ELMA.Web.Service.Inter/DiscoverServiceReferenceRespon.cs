using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class DiscoverServiceReferenceResponse
{
	[DataMember]
	public ScriptWebReference WebReference { get; set; }

	[DataMember]
	public ServiceReferenceInfo ServiceReferenceInfo { get; set; }

	[DataMember]
	public string ServiceString { get; set; }

	[DataMember]
	public string CodeFilePath { get; set; }

	[DataMember]
	public bool NeedAuthenticateUser { get; set; }

	[DataMember]
	public string AuthenticationType { get; set; }

	[DataMember]
	public string ErrorMessage { get; set; }
}
