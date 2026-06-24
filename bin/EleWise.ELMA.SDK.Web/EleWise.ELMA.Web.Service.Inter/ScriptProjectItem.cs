using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ScriptProjectItem
{
	[DataMember]
	public string ItemType { get; set; }

	[DataMember]
	public string Include { get; set; }

	[DataMember]
	public List<MetadataItem> Metadata { get; set; }

	[DataMember]
	public string FileContent { get; set; }

	public ScriptProjectItem()
	{
		Metadata = new List<MetadataItem>();
	}
}
