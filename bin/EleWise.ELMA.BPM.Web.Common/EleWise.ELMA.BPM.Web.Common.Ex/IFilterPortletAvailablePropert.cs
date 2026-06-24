using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPortletAvailablePropertyUids
{
	bool AvailableFilterType(Guid TypeUid, Guid? Code);

	List<Guid> AvailablePropertyUids();
}
