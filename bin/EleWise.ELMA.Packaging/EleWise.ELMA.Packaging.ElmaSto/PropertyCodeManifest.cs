using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot]
[DataContract]
public class PropertyCodeManifest
{
	[XmlAttribute("Name")]
	[DataMember]
	public string Name { get; set; }

	[XmlAttribute("Type")]
	[DataMember]
	public string Type { get; set; }

	public bool Equals(PropertyCodeManifest other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		string text = ComponentManifest.PrepareCodeName(other.Name);
		string text2 = ComponentManifest.PrepareCodeName(Name);
		if (text == text2)
		{
			return other.Type == Type;
		}
		return false;
	}

	public override int GetHashCode()
	{
		string text = ComponentManifest.PrepareCodeName(Name);
		return ((Name == null) ? typeof(string).GetHashCode() : (text.GetHashCode() * 305)) ^ ((Type == null) ? typeof(string).GetHashCode() : Type.GetHashCode());
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != typeof(PropertyCodeManifest))
		{
			return false;
		}
		return Equals((PropertyCodeManifest)obj);
	}

	public override string ToString()
	{
		return Name;
	}
}
