using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class TasksPortletGridStateProvider : GridStateProvider
{
	public static Guid UID = new Guid("879B5439-D61E-4671-BCC0-59BA90D174BE");

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
