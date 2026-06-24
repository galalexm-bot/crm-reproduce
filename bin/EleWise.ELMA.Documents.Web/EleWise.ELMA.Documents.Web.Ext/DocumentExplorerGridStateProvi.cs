using System;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Extensions;

public class DocumentExplorerGridStateProvider : GridStateProvider
{
	public static Guid UID = new Guid("BF2CC314-BB83-4DF6-9B23-5137D4AA9857");

	public override Guid Uid => UID;

	private static string CurrentUserName => "ude_" + AuthenticationService.CurrentUserName;

	public override GridState Load(string gridId)
	{
		try
		{
			return PersonalizationAdministration.LoadState<GridState>(CurrentUserName, "_DocumentExplorerPopup");
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
		}
		return null;
	}

	public override void Save(string gridId, GridState state)
	{
		PersonalizationAdministration.SaveState(CurrentUserName, "_DocumentExplorerPopup", state);
	}
}
