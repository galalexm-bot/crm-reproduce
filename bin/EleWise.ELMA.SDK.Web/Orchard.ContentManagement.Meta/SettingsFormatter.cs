using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.MetaData.Services;

public class SettingsFormatter : ISettingsFormatter, IDependency
{
	public SettingsDictionary Map(XElement element)
	{
		if (element == null)
		{
			return new SettingsDictionary();
		}
		return new SettingsDictionary(element.Attributes().ToDictionary((XAttribute attr) => XmlConvert.DecodeName(attr.Name.LocalName), (XAttribute attr) => attr.Value));
	}

	public XElement Map(SettingsDictionary settingsDictionary)
	{
		if (settingsDictionary == null)
		{
			return new XElement("settings");
		}
		return new XElement("settings", from kv in settingsDictionary
			where kv.Value != null
			select new XAttribute(XmlConvert.EncodeLocalName(kv.Key), kv.Value));
	}
}
