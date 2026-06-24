using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
public sealed class ServerVersionInfo
{
	[DataMember]
	public string UIVersion { get; set; }

	[DataMember]
	public string Version { get; set; }

	[DataMember]
	public int Type { get; set; }

	[DataMember]
	public int Mode { get; set; }

	[DataMember]
	public string RuntimeModelHash { get; set; }
}
