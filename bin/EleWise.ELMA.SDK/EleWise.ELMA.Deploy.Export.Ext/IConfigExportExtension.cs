using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IConfigExportExtension
{
	Dictionary<Guid, object> GetNewSettingObj();

	void AddExportObjects(ExportExtensionParams parameters);
}
