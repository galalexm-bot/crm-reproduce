using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IGridObjectSelectorExtension
{
	void EditGrid(DynamicGrid grid, Guid typeUid);
}
