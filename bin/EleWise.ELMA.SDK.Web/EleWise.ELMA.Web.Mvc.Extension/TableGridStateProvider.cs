using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Extensions;

[Component]
public class TableGridStateProvider : GridStateProvider
{
	public static Guid UID = new Guid("87A16163-9009-465C-B862-1D09A1A21959");

	public override Guid Uid => UID;

	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	public override GridState Load(string gridId)
	{
		return PersonalizationAdministration.LoadState<GridState>(CurrentUserName, gridId);
	}

	public override void Save(string gridId, GridState state)
	{
		PersonalizationAdministration.SaveState(CurrentUserName, gridId, state);
	}
}
