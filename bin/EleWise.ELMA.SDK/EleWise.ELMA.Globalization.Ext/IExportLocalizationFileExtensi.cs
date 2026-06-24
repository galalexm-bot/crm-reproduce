using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization.Models;

namespace EleWise.ELMA.Globalization.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IExportLocalizationFileExtensionPoint
{
	Guid Uid { get; }

	string Header { get; }

	IDictionary<string, string> Tabs { get; }

	object GetSettingObj(IDictionary<string, string> settingsJsonData);

	IDictionary<string, IEnumerable<LocalizableData>> GetAllData();
}
