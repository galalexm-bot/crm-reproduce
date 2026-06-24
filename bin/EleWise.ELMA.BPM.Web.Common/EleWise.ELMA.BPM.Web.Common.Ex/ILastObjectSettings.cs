using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ILastObjectSettings
{
	string Version { get; set; }

	bool RestrictTypes { get; set; }

	List<Guid> ObjectTypes { get; set; }

	int ObjectCount { get; set; }
}
