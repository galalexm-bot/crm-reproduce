using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IEntityExportValuesEdit
{
	Guid TypeUid { get; }

	void EditValues(Dictionary<string, object> values);
}
