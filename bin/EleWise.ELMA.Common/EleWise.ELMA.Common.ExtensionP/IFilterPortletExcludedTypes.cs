using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPortletExcludedTypes
{
	Guid GetExcludedTypeUid();
}
