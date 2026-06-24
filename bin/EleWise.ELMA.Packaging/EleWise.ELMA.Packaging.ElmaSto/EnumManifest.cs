using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot("Enum")]
[DataContract]
public class EnumManifest
{
	[XmlElement("Uid")]
	[DataMember]
	public Guid Uid { get; set; }

	[XmlElement("Namespace")]
	[DataMember]
	public string Namespace { get; set; }

	[XmlElement("Name")]
	[DataMember]
	public string Name { get; set; }

	[XmlElement("DisplayName")]
	[DataMember]
	public string DisplayName { get; set; }

	public override string ToString()
	{
		return Name;
	}
}
