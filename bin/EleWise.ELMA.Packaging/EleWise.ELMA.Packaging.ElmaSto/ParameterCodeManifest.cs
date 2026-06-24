using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot]
[DataContract]
public class ParameterCodeManifest
{
	[XmlAttribute("Name")]
	[DataMember]
	public string Direction { get; set; }

	[XmlAttribute("Type")]
	[DataMember]
	public string Type { get; set; }

	public bool Equals(ParameterCodeManifest other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (other.Direction == Direction)
		{
			return other.Type == Type;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((Direction == null) ? typeof(string).GetHashCode() : Direction.GetHashCode()) * 305) ^ ((Type == null) ? typeof(string).GetHashCode() : Type.GetHashCode());
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
		if (obj.GetType() != typeof(ParameterCodeManifest))
		{
			return false;
		}
		return Equals((ParameterCodeManifest)obj);
	}

	public override string ToString()
	{
		return Direction + " " + Type;
	}
}
