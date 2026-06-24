using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[Component]
public abstract class GridStateProvider : IGridStateProvider
{
	public abstract Guid Uid { get; }

	public virtual string Description => null;

	public virtual GridState Load(string gridId)
	{
		return null;
	}

	public virtual void Save(string gridId, GridState state)
	{
	}

	public virtual bool OnRefresh(GridState state, string data)
	{
		return false;
	}
}
