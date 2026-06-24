using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Globalization;

[ExtensionPoint(ComponentType.All)]
public interface ILocalizationLoadCustomSettings
{
	Dictionary<Guid, object> GetNewSettingObj();
}
