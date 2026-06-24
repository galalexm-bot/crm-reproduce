using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public static class GridPersonalizationAdministration
{
	private const string AllUsers = "elma_all";

	private const string GridStatePrefix = "GridState_";

	private const string OriginalGridSettingsPostfix = "_9ED3CE5340644A04B9A89FBDEE7B6607";

	private static IEnumerable<IGridStateProvider> gridStateProvider;

	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	private static IEnumerable<IGridStateProvider> GridStateProvider => gridStateProvider ?? (gridStateProvider = ComponentManager.Current.GetExtensionPoints<IGridStateProvider>());

	static GridPersonalizationAdministration()
	{
		if (PersonalizationAdministration.Provider == null)
		{
			throw new NotInitializedException("Cannot find default Personalization provider");
		}
	}

	public static GridState LoadState(string grid, Guid? provider = null, bool? inSession = null)
	{
		string text = "GridState_" + grid;
		GridState value = null;
		if (inSession != false && (!provider.HasValue || provider == Guid.Empty))
		{
			SessionVars.TryGetValue<GridState>(text, out value);
		}
		GridState orAdd = ContextVars.GetOrAdd(text + "_elma_all", () => PersonalizationAdministration.LoadState<GridState>("elma_all", grid));
		if (value == null)
		{
			Func<GridState> val = () => PersonalizationAdministration.LoadState<GridState>(CurrentUserName, grid);
			if (provider.HasValue && provider.Value != Guid.Empty)
			{
				IGridStateProvider stateProvider = GridStateProvider.FirstOrDefault((IGridStateProvider item) => item.Uid == provider.Value);
				if (stateProvider != null)
				{
					val = () => stateProvider.Load(grid);
				}
			}
			value = ContextVars.GetOrAdd(text, val);
		}
		if (orAdd != null && value != null && orAdd.DateState > value.DateState)
		{
			value = orAdd;
		}
		if (value == null)
		{
			return null;
		}
		return (GridState)value.Clone();
	}

	public static void SaveState(string grid, GridState state, Guid? provider = null, bool? inSession = null)
	{
		string name = "GridState_" + grid;
		state.DateState = DateTime.Now;
		ContextVars.Set(name, state);
		if (provider.HasValue && provider != Guid.Empty)
		{
			GridStateProvider.FirstOrDefault((IGridStateProvider item) => item.Uid == provider.Value)?.Save(grid, state);
			return;
		}
		if (inSession == true)
		{
			SessionVars.Set(name, state);
			return;
		}
		PersonalizationAdministration.SaveState(CurrentUserName, grid, state);
		if (state.SaveDefault)
		{
			PersonalizationAdministration.SaveState("elma", grid, state);
		}
		if (state.UseForAllUsers)
		{
			PersonalizationAdministration.SaveState("elma_all", grid, state);
		}
	}

	public static bool ValidateSortExpression(string sortExpression, IList<GridColumn> columns)
	{
		sortExpression = sortExpression.ToUpper().Replace("ASC", "").Replace("DESC", "")
			.Replace(" ", "");
		return sortExpression.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries).All((string column) => columns.ToList().Find((GridColumn p) => p.SortExpression != null && p.SortExpression.ToUpper().Contains(column)) != null);
	}

	public static OriginalGridSettings LoadOriginalGridSettings(string grid, bool? inSession = null)
	{
		string gridKey = "GridState_" + grid + "_9ED3CE5340644A04B9A89FBDEE7B6607";
		OriginalGridSettings value = null;
		if (inSession != false)
		{
			SessionVars.TryGetValue<OriginalGridSettings>(gridKey, out value);
		}
		if (value == null)
		{
			Func<OriginalGridSettings> val = () => PersonalizationAdministration.LoadState<OriginalGridSettings>(CurrentUserName, gridKey);
			value = ContextVars.GetOrAdd(gridKey, val);
		}
		return ClassSerializationHelper.CloneObject(value);
	}

	public static void SaveOriginalGridSettings(string grid, OriginalGridSettings gridSettings, bool? inSession = null)
	{
		string text = "GridState_" + grid + "_9ED3CE5340644A04B9A89FBDEE7B6607";
		ContextVars.Set(text, gridSettings);
		if (inSession == true)
		{
			SessionVars.Set(text, gridSettings);
		}
		else
		{
			PersonalizationAdministration.SaveState(CurrentUserName, text, gridSettings);
		}
	}
}
