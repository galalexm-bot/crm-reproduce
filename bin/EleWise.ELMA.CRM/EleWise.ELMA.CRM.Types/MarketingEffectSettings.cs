using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.CRM.Types;

[Serializable]
public class MarketingEffectSettings : EntitySettings
{
	[XmlElement("Composite")]
	[DefaultValue(false)]
	public bool IsComposite { get; set; }

	[XmlIgnore]
	public Guid MarketingGroupPropertyUid { get; set; }

	[XmlIgnore]
	public Guid MarketingActivityPropertyUid { get; set; }

	[XmlElement("MarketingGroupPropertyUid")]
	[DefaultValue("")]
	public string MarketingGroupPropertyUidStr
	{
		get
		{
			if (!(MarketingGroupPropertyUid != Guid.Empty))
			{
				return "";
			}
			return MarketingGroupPropertyUid.ToString();
		}
		set
		{
			MarketingGroupPropertyUid = ((!string.IsNullOrEmpty(value)) ? new Guid(value) : Guid.Empty);
		}
	}

	[XmlElement("MarketingActivityPropertyUid")]
	[DefaultValue("")]
	public string MarketingActivityPropertyUidStr
	{
		get
		{
			if (!(MarketingActivityPropertyUid != Guid.Empty))
			{
				return "";
			}
			return MarketingActivityPropertyUid.ToString();
		}
		set
		{
			MarketingActivityPropertyUid = ((!string.IsNullOrEmpty(value)) ? new Guid(value) : Guid.Empty);
		}
	}

	public MarketingEffectSettings()
	{
	}

	protected MarketingEffectSettings(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
