using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;

namespace EleWise.ELMA.Documents.Metadata;

[Serializable]
[XmlRoot]
public class CryptoSettings : Attribute
{
	[XmlIgnore]
	public virtual Guid CryptoEntityTypeUid { get; set; }

	[XmlElement("CryptoEntityTypeUid")]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual string CryptoEntityTypeUidStr
	{
		get
		{
			if (!(CryptoEntityTypeUid != Guid.Empty))
			{
				return "";
			}
			return CryptoEntityTypeUid.ToString();
		}
		set
		{
			CryptoEntityTypeUid = ((!string.IsNullOrEmpty(value)) ? new Guid(value) : Guid.Empty);
		}
	}

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual List<Guid> CryptoAttributes
	{
		get
		{
			if (string.IsNullOrEmpty(CryptoAttributesStr))
			{
				return new List<Guid>();
			}
			return (from a in CryptoAttributesStr.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries)
				select new Guid(a)).ToList();
		}
		set
		{
			CryptoAttributesStr = string.Join(",", value);
		}
	}

	[XmlElement("CryptoAttributes")]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual string CryptoAttributesStr { get; set; }

	[XmlElement("CryptoTableName")]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual string CryptoTableName { get; set; }

	public CryptoSettings()
	{
		CryptoEntityTypeUid = Guid.NewGuid();
	}

	protected CryptoSettings(SerializationInfo info, StreamingContext context)
	{
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		enumerator.Reset();
		while (enumerator.MoveNext())
		{
			string name = enumerator.Name;
			PropertyInfo property = GetType().GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
			if (property != null)
			{
				object value = info.GetValue(enumerator.Name, enumerator.ObjectType);
				property.SetValue(this, value, null);
			}
		}
	}
}
