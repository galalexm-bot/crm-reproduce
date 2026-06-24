using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot("Process")]
[DataContract]
public class ProcessManifest
{
	[XmlElement("Id")]
	[DataMember]
	public Guid Id { get; set; }

	[XmlElement("Name")]
	[DataMember]
	public string Name { get; set; }

	[XmlElement("Version")]
	[DataMember]
	public long Version { get; set; }

	[XmlArray]
	[XmlArrayItem("Package")]
	[DataMember]
	public List<PackageDependencyManifest> Dependencies { get; set; }

	[XmlElement("Context")]
	[DataMember]
	public EntityManifest Context { get; set; }

	public override string ToString()
	{
		return Name;
	}
}
