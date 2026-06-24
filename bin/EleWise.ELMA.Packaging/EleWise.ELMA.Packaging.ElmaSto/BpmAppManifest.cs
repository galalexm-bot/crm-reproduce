using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot("BpmApp")]
[DataContract]
public class BpmAppManifest
{
	[XmlElement("Id")]
	[DataMember]
	public string Id { get; set; }

	[XmlElement("Title")]
	[DataMember]
	public string Title { get; set; }

	[XmlElement("Description")]
	[DataMember]
	public string Description { get; set; }

	[XmlElement("Version")]
	[DataMember]
	public string Version { get; set; }

	[XmlIgnore]
	[DataMember]
	public Guid Uid { get; set; }

	[XmlElement("Author")]
	[DataMember]
	public string Author { get; set; }

	[XmlElement("TagDataBase")]
	[DataMember]
	public string TagDataBase { get; set; }

	[XmlElement("TagEdition")]
	[DataMember]
	public string TagEdition { get; set; }

	[XmlElement("TagLanguage")]
	[DataMember]
	public string TagLanguage { get; set; }

	public BpmAppManifest()
	{
		Uid = Guid.NewGuid();
	}

	public override string ToString()
	{
		if (!string.IsNullOrWhiteSpace(Version))
		{
			return string.Format("{0} (1)", Title, Version);
		}
		return Title;
	}
}
