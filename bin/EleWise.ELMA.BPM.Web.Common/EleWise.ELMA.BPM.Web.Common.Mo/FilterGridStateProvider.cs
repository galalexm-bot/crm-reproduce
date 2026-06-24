using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterGridStateProvider : GridStateProvider
{
	public static Guid UID = new Guid("{5E4E5223-F46B-4FB8-881F-2E71445BAD47}");

	public override Guid Uid => UID;

	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	protected virtual IFilterBase CreateNew()
	{
		return InterfaceActivator.Create<IFilter>();
	}

	protected virtual IFilterBase LoadFilterByUid(Guid uid)
	{
		return AbstractNHEntityManager<IFilter, long>.Instance.Load(uid);
	}

	public override GridState Load(string gridId)
	{
		List<string> list = gridId.Split(new string[1] { "_" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		string input = list.LastOrDefault();
		list.RemoveAt(list.Count - 1);
		string path = string.Join("_", list);
		try
		{
			if (!Guid.TryParse(input, out var result))
			{
				return null;
			}
			IFilterBase filterBase = LoadFilterByUid(result);
			GridState gridState = PersonalizationAdministration.LoadState<GridState>(CurrentUserName, gridId);
			GridState filterState = ((filterBase.GridState != null) ? GridState.Deserialize(filterBase.GridState) : null);
			if (gridState == null && filterState == null)
			{
				return null;
			}
			GridState gridState2 = PersonalizationAdministration.LoadState<GridState>("elma", path);
			if (filterBase.UseDefaultSettings)
			{
				if (gridState2 == null)
				{
					FilterModel filterModel = new FilterModel(CreateNew(), filterBase.ObjectsType.TypeUid);
					filterModel.FillGridState();
					filterState = filterModel.GridState;
					PersonalizationAdministration.SaveState("elma", path, filterState);
					return null;
				}
				GridState obj = filterState ?? gridState;
				filterState = ClassSerializationHelper.CloneObject(gridState2);
				foreach (ColumnState item in obj.ColumnStates.Where((ColumnState cs) => filterState.ColumnStates.All((ColumnState fcs) => fcs.UniqueName != cs.UniqueName)))
				{
					ColumnState columnState2 = ClassSerializationHelper.CloneObject(item);
					columnState2.Hidden = item.Hidden;
					filterState.ColumnStates.Add(columnState2);
				}
				GridStateSet columnStates = (gridState ?? filterState).ColumnStates;
				foreach (ColumnState columnState in filterState.ColumnStates)
				{
					ColumnState columnState3 = columnStates.FirstOrDefault((ColumnState s) => s.UniqueName == columnState.UniqueName);
					if (columnState3 != null)
					{
						columnState.WidthAttribute = columnState3.WidthAttribute;
					}
				}
				if (gridState == null && filterBase.UseDefaultSettingsDate.HasValue)
				{
					filterState.DateState = filterBase.UseDefaultSettingsDate.Value;
				}
				else
				{
					filterState.DateState = ((!filterBase.UseDefaultSettingsDate.HasValue) ? filterState.DateState : ((filterBase.UseDefaultSettingsDate.Value > gridState.DateState) ? filterBase.UseDefaultSettingsDate.Value : gridState.DateState));
				}
				if (gridState != null && gridState.DateState >= filterState.DateState)
				{
					filterState.SortExpression = gridState.SortExpression;
					filterState.SortDirection = gridState.SortDirection;
					filterState.PageSize = gridState.PageSize;
				}
			}
			else if (gridState != null)
			{
				if (gridState2 == null)
				{
					FilterModel filterModel2 = new FilterModel(CreateNew(), filterBase.ObjectsType.TypeUid);
					filterModel2.FillGridState();
					gridState.CustomColumns = ClassSerializationHelper.CloneObject(filterModel2.GridState.CustomColumns);
				}
				else
				{
					gridState.CustomColumns = ClassSerializationHelper.CloneObject(gridState2.CustomColumns);
				}
			}
			if (filterState == null)
			{
				return gridState;
			}
			if (gridState != null && gridState.DateState >= filterState.DateState)
			{
				if (string.IsNullOrEmpty(gridState.SortExpression) && !string.IsNullOrEmpty(filterState.SortExpression))
				{
					gridState.SortExpression = filterState.SortExpression;
				}
				return gridState;
			}
			return filterState;
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
