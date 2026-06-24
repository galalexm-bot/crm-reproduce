using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IGridStateProvider
{
	Guid Uid { get; }

	string Description { get; }

	GridState Load(string gridId);

	void Save(string gridId, GridState state);

	bool OnRefresh(GridState state, string data);
}
