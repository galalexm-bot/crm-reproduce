using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[XmlRoot]
[DataContract]
public class MethodCodeManifest
{
	[XmlAttribute("Name")]
	[DataMember]
	public string Name { get; set; }

	[XmlAttribute("ReturnType")]
	[DataMember]
	public string ReturnType { get; set; }

	[XmlArray]
	[XmlArrayItem("Parameter")]
	[DataMember]
	public List<ParameterCodeManifest> Parametres { get; set; }

	public MethodCodeManifest()
	{
		Parametres = new List<ParameterCodeManifest>();
	}

	public bool Equals(MethodCodeManifest other)
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
		if (text == text2 && other.ReturnType == ReturnType)
		{
			if (other.Parametres != null || Parametres != null)
			{
				if (other.Parametres != null && Parametres != null && Parametres.Count == other.Parametres.Count)
				{
					if (other.Parametres.All((ParameterCodeManifest p) => Parametres.Any((ParameterCodeManifest pp) => pp.Equals(p))))
					{
						return Parametres.All((ParameterCodeManifest p) => other.Parametres.Any((ParameterCodeManifest pp) => pp.Equals(p)));
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
		string text = ComponentManifest.PrepareCodeName(Name);
		int num = ((text == null) ? typeof(string).GetHashCode() : (text.GetHashCode() * 305)) ^ ((ReturnType == null) ? typeof(string).GetHashCode() : ReturnType.GetHashCode());
		if (Parametres != null)
		{
			foreach (ParameterCodeManifest parametre in Parametres)
			{
				num ^= parametre.GetHashCode() * 267;
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
		if (obj.GetType() != typeof(MethodCodeManifest))
		{
			return false;
		}
		return Equals((MethodCodeManifest)obj);
	}

	public override string ToString()
	{
		return Name;
	}
}
