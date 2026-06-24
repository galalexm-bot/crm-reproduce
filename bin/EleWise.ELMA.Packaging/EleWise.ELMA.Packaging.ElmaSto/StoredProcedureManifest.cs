using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot]
public class StoredProcedureManifest
{
	[XmlAttribute("Name")]
	public string Name { get; set; }

	[XmlAttribute("Database")]
	public string Database { get; set; }

	public override string ToString()
	{
		return Name;
	}
}
