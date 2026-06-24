using System;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class PortletGridStateProvider : GridStateProvider
{
	public static Guid UID = new Guid("{BD397D42-B3AE-478B-B62A-39923552E9EB}");

	public override Guid Uid => UID;

	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	public override GridState Load(string gridId)
	{
		string instanceId = gridId.Split(new string[1] { "_" }, StringSplitOptions.RemoveEmptyEntries)[1];
		try
		{
			GridState gridState = FilterPortletPersonalization.GetGridState(instanceId, gridId);
			GridState gridState2 = PersonalizationAdministration.LoadState<GridState>(CurrentUserName, gridId);
			if (gridState2 != null && gridState != null)
			{
				gridState.CustomColumns = gridState2.CustomColumns;
			}
			if (gridState2 == null)
			{
				return gridState;
			}
			return (gridState.DateState > gridState2.DateState) ? gridState : gridState2;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			return null;
		}
	}

	public override void Save(string gridId, GridState state)
	{
		PersonalizationAdministration.SaveState(CurrentUserName, gridId, state);
	}
}
