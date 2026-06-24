using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISolveTaskQuickMode
{
	Guid TypeUid { get; }

	string DisplayName { get; }
}
