using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot("Entity")]
[DataContract]
public class EntityManifest
{
	[XmlElement("Uid")]
	[DataMember]
	public Guid Uid { get; set; }

	[XmlElement("TableName")]
	[DataMember]
	public string TableName { get; set; }

	[XmlElement("Namespace")]
	[DataMember]
	public string Namespace { get; set; }

	[XmlElement("Name")]
	[DataMember]
	public string Name { get; set; }

	[XmlElement("DisplayName")]
	[DataMember]
	public string DisplayName { get; set; }

	[XmlElement("EntityMetadataType")]
	[DataMember]
	public int EntityMetadataType { get; set; }

	public EntityManifest()
	{
		EntityMetadataType = 1;
	}

	public override string ToString()
	{
		return Name;
	}
}
