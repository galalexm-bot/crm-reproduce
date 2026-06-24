using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IImportantData
{
	Guid Uid { get; }

	IEnumerable<Version> Versions { get; }

	string Module { get; }
}
