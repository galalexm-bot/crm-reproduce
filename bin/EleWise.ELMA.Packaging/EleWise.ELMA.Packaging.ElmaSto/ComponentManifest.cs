using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot("Component")]
[DataContract]
public class ComponentManifest : ExtensionPointManifest
{
	[XmlAttribute("ExtensionPoint")]
	[DataMember]
	public string ExtensionPoint { get; set; }

	public bool Equals(ComponentManifest other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (other.ExtensionPoint == ExtensionPoint && ((other.Properties == null && base.Properties == null) || (other.Properties != null && base.Properties != null && base.Properties.Count == other.Properties.Count && other.Properties.All((PropertyCodeManifest p) => base.Properties.Any((PropertyCodeManifest pp) => pp.Equals(p))) && base.Properties.All((PropertyCodeManifest p) => other.Properties.Any((PropertyCodeManifest pp) => pp.Equals(p))))))
		{
			if (other.Methods != null || base.Methods != null)
			{
				if (other.Methods != null && base.Methods != null && base.Methods.Count == other.Methods.Count)
				{
					if (other.Methods.All((MethodCodeManifest p) => base.Methods.Any((MethodCodeManifest pp) => pp.Equals(p))))
					{
						return base.Methods.All((MethodCodeManifest p) => other.Methods.Any((MethodCodeManifest pp) => pp.Equals(p)));
					}
					return false;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = ((base.Name == null) ? typeof(string).GetHashCode() : (base.Name.GetHashCode() * 305)) ^ ((ExtensionPoint == null) ? typeof(string).GetHashCode() : ExtensionPoint.GetHashCode());
		if (base.Properties != null)
		{
			foreach (PropertyCodeManifest property in base.Properties)
			{
				num ^= property.GetHashCode() * 267;
			}
		}
		if (base.Methods != null)
		{
			foreach (MethodCodeManifest method in base.Methods)
			{
				num ^= method.GetHashCode() * 267;
			}
			return num;
		}
		return num;
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
		if (obj.GetType() != typeof(ComponentManifest))
		{
			return false;
		}
		return Equals((ComponentManifest)obj);
	}

	public override string ToString()
	{
		return base.Name + "(" + ExtensionPoint + ")";
	}

	public static string PrepareCodeName(string name)
	{
		string text = name;
		if (text.Contains("."))
		{
			text = text.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).Last();
		}
		return text;
	}
}
