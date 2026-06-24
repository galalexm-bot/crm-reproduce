using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPortletFilterModifier
{
	bool AvailableFilterType(Guid filterTypeUid, Guid? Code);

	IEntityFilter ModifyFilter(IEntityFilter filter);
}
