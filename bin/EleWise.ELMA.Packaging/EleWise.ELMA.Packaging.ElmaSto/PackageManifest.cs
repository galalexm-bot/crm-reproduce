using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using NuGet;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot("Package")]
[DataContract]
public class PackageManifest
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
	[IgnoreDataMember]
	public SemanticVersion SemanticVersion
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			try
			{
				return new SemanticVersion(Version);
			}
			catch (Exception)
			{
				return null;
			}
		}
		set
		{
			Version = ((object)value).ToString();
		}
	}

	[XmlElement("Author")]
	[DataMember]
	public string Author { get; set; }

	[XmlElement("Tags")]
	[DataMember]
	public string Tags { get; set; }

	[XmlArray]
	[XmlArrayItem("Entity")]
	[DataMember]
	public List<EntityManifest> Entities { get; set; }

	[XmlArray]
	[XmlArrayItem("Enum")]
	[DataMember]
	public List<EnumManifest> Enums { get; set; }

	[XmlArray]
	[XmlArrayItem("Package")]
	[DataMember]
	public List<PackageDependencyManifest> Dependencies { get; set; }

	[XmlArray]
	[XmlArrayItem("StoredProcedure")]
	[DataMember]
	public List<StoredProcedureManifest> StoredProcedures { get; set; }

	[XmlArray]
	[XmlArrayItem("ExtensionPoint")]
	[DataMember]
	public List<ExtensionPointManifest> ExtensionPoints { get; set; }

	[XmlArray]
	[XmlArrayItem("Component")]
	[DataMember]
	public List<ComponentManifest> Components { get; set; }

	public PackageManifest()
	{
		Dependencies = new List<PackageDependencyManifest>();
		StoredProcedures = new List<StoredProcedureManifest>();
		ExtensionPoints = new List<ExtensionPointManifest>();
		Components = new List<ComponentManifest>();
		Enums = new List<EnumManifest>();
		Entities = new List<EntityManifest>();
	}

	public string GetFileName()
	{
		return Id + "." + Version + ".nupkg";
	}

	public override string ToString()
	{
		return Id + " " + Version;
	}
}
