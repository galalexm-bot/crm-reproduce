using System;
using System.Linq;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Extensions;

public class FilterFolderGridStateProvider : GridStateProvider
{
	public static Guid UID = new Guid("067C11B0-FCA2-46C3-8C74-E91F5CFE33D9");

	public override Guid Uid => UID;

	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	public override GridState Load(string gridId)
	{
		string g = gridId.Split(new string[1] { "_" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
		try
		{
			Guid uid = new Guid(g);
			IFilterDocumentFolder filterDocumentFolder = FilterDocumentFolderManager.Instance.Load(uid);
			GridState gridState = PersonalizationAdministration.LoadState<GridState>(CurrentUserName, gridId);
			GridState gridState2 = null;
			if (filterDocumentFolder.GridState != null && gridState == null)
			{
				gridState = GridState.Deserialize(filterDocumentFolder.GridState);
			}
			if (filterDocumentFolder.GridState == null && gridState != null)
			{
				filterDocumentFolder.GridState = ClassSerializationHelper.SerializeObject(gridState);
			}
			if (filterDocumentFolder.GridState == null || gridState == null)
			{
				return null;
			}
			gridState2 = GridState.Deserialize(filterDocumentFolder.GridState);
			if (gridState2.DateState < gridState.DateState)
			{
				if (string.IsNullOrEmpty(gridState.SortExpression) && !string.IsNullOrEmpty(gridState2.SortExpression))
				{
					gridState.SortExpression = gridState2.SortExpression;
				}
				return gridState;
			}
			return gridState2;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
		}
		return null;
	}

	public override void Save(string gridId, GridState state)
	{
		PersonalizationAdministration.SaveState(CurrentUserName, gridId, state);
	}
}
