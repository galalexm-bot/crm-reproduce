using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class GridSettingsViewModel
{
	public GridState State { get; set; }

	public Guid? ProviderUid { get; set; }

	public Guid? CustomStateProvider { get; set; }

	public string CallbackFunction { get; set; }

	public string TypeName { get; set; }

	public string Description { get; set; }

	public bool GridHasDefaultSettings(string gridId, Guid? provider = null)
	{
		return PersonalizationAdministration.LoadState<GridState>("elma", gridId) != null;
	}

	public bool HasPermissionToDefaultSettings(string gridId, Guid? provider = null)
	{
		return !ComponentManager.Current.GetExtensionPoints<IGridStatePermissionResolver>().Any((IGridStatePermissionResolver r) => !r.HasPermission(gridId, provider));
	}
}
