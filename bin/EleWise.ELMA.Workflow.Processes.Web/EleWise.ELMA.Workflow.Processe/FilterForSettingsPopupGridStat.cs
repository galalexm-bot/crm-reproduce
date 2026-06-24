using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class FilterForSettingsPopupGridStateProvider : GridStateProvider
{
	public static Guid UID = new Guid("{2346E172-5051-4114-86B9-64B8D902626A}");

	public override Guid Uid => UID;

	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	public override string Description => SR.T("Установленные ширина и состав колонок сохраняются для всех пользователей системы. Текущие пользовательские настройки в этом фильтре будут сброшены на сохраняемые.");

	public override GridState Load(string gridId)
	{
		string g = gridId.Split(new string[1] { "_" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
		try
		{
			Guid uid = new Guid(g);
			GridState gridState = GridState.Deserialize(AbstractNHEntityManager<IFilter, long>.Instance.Load(uid).GridState);
			gridState.CustomColumns = new List<CustomColumnDescriptor>(CustomWorkflowInstanceColumns.GetWorkflowInstanceColumns(gridState));
			return gridState;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public override void Save(string gridId, GridState state)
	{
		string g = gridId.Split(new string[1] { "_" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
		try
		{
			Guid uid = new Guid(g);
			IFilter filter = AbstractNHEntityManager<IFilter, long>.Instance.Load(uid);
			state.DateState = DateTime.Now;
			GridState gridState = PersonalizationAdministration.LoadState<GridState>(CurrentUserName, gridId);
			if (gridState != null)
			{
				try
				{
					state.ColumnsWidth = gridState.ColumnsWidth;
				}
				catch (Exception ex)
				{
					Logger.Log.Error(ex.Message, ex);
				}
			}
			filter.GridState = ClassSerializationHelper.SerializeObject(state);
			filter.Save();
		}
		catch (Exception)
		{
		}
	}
}
