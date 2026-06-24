using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class MetadataItem
{
	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public string Value { get; set; }
}
