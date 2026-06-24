using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using NuGet;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot("ElmaComponent")]
public class ElmaStoreComponentDependency : ISerializable
{
	[XmlAttribute("Id")]
	[DataMember]
	public string Id { get; set; }

	[XmlAttribute("Version")]
	[DataMember]
	public string Version { get; set; }

	[XmlIgnore]
	[IgnoreDataMember]
	public IVersionSpec ManifestVersion
	{
		get
		{
			IVersionSpec result = default(IVersionSpec);
			if (!string.IsNullOrEmpty(Version) && VersionUtility.TryParseVersionSpec(Version, ref result))
			{
				return result;
			}
			return null;
		}
		set
		{
			if (value != null)
			{
				Version = ((object)value).ToString();
			}
		}
	}

	public ElmaStoreComponentDependency()
	{
	}

	public ElmaStoreComponentDependency(SerializationInfo info, StreamingContext context)
	{
		ManifestBuilder.ReadDataForDeserialization(this, info);
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		ManifestBuilder.WriteDataForSerialization(this, info);
	}

	public override string ToString()
	{
		return Id + " " + Version;
	}
}
