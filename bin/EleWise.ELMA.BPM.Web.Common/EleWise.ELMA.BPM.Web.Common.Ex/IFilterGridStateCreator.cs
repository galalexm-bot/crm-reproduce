using System;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterGridStateCreator
{
	bool CheckType(FilterModel model);

	GridState Create(FilterModel model);

	GridState Refresh(FilterModel model, GridState sourceRefresh = null);

	Type GetGridStateEntityType(FilterModel model);
}
