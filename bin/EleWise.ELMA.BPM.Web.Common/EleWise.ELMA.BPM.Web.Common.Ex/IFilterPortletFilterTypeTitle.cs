using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPortletFilterTypeTitle
{
	bool AvailableType(Guid TypeUid);

	string GetTitle(Guid TypeUid, Guid? Code);
}
