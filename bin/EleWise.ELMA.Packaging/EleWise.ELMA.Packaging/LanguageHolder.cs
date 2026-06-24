using System;
using System.Globalization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging;

[Serializable]
[XmlRoot("LanguageHolder")]
public class LanguageHolder
{
	[NonSerialized]
	private Lazy<CultureInfo> _culture;

	[XmlElement("Name")]
	public string Name { get; set; }

	public CultureInfo GetCulture()
	{
		if (_culture == null && !string.IsNullOrEmpty(Name))
		{
			_culture = new Lazy<CultureInfo>(delegate
			{
				try
				{
					return new CultureInfo(Name);
				}
				catch (Exception)
				{
					return null;
				}
			});
		}
		return _culture.Value;
	}
}
