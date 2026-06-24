using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot]
[DataContract]
public class ExtensionPointManifest
{
	[XmlAttribute("Name")]
	[DataMember]
	public string Name { get; set; }

	[XmlArray]
	[XmlArrayItem("Property")]
	[DataMember]
	public List<PropertyCodeManifest> Properties { get; set; }

	[XmlArray]
	[XmlArrayItem("Method")]
	[DataMember]
	public List<MethodCodeManifest> Methods { get; set; }

	public ExtensionPointManifest()
	{
		Properties = new List<PropertyCodeManifest>();
		Methods = new List<MethodCodeManifest>();
	}

	public override string ToString()
	{
		return Name;
	}
}
