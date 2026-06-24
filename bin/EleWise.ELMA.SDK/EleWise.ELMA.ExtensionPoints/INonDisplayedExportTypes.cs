using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface INonDisplayedExportTypes
{
	List<Guid> GetNonDisplayedTypesUids();
}
