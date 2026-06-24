using System.Xml.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.MetaData.Services;

public interface ISettingsFormatter : IDependency
{
	SettingsDictionary Map(XElement element);

	XElement Map(SettingsDictionary settingsDictionary);
}
