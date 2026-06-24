using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.SessionState;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Controllers;

[SessionState(SessionStateBehavior.Required)]
public class GridSettingsController : BaseController
{
	public ActionResult Settings(string gridId, Guid? provider = null, string callbackFunction = null, string typeName = null, bool? withDefaultSettings = null, Guid? customStateProvider = null)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		GridState gridState = null;
		IGridStateProvider gridStateProvider = null;
		if (customStateProvider.HasValue && customStateProvider.Value != Guid.Empty)
		{
			gridStateProvider = ComponentManager.Current.GetExtensionPoints<IGridStateProvider>().FirstOrDefault((IGridStateProvider p) => p.Uid == customStateProvider.Value);
			if (gridStateProvider != null)
			{
				gridState = gridStateProvider.Load(gridId);
			}
		}
		if (gridStateProvider == null && provider.HasValue && provider.Value != Guid.Empty)
		{
			gridStateProvider = ComponentManager.Current.GetExtensionPoints<IGridStateProvider>().FirstOrDefault((IGridStateProvider p) => p.Uid == provider.Value);
		}
		if (gridState == null)
		{
			gridState = GridPersonalizationAdministration.LoadState(gridId, provider, false);
		}
		if (gridState == null)
		{
			return (ActionResult)new EmptyResult();
		}
		if (!string.IsNullOrWhiteSpace(typeName))
		{
			Type type = ReflectionType.GetType(typeName);
			gridState.Refresh(type, isNew: false, forceRefresh: false, addEntityName: false);
		}
		gridState.GridId = gridId;
		gridState.UseForAllUsers = false;
		((ControllerBase)this).get_ViewData().set_Item("WithDefaultSettings", (object)(withDefaultSettings.HasValue && withDefaultSettings.Value));
		return (ActionResult)(object)((Controller)this).PartialView("Templates/GridSettings", (object)new GridSettingsViewModel
		{
			State = gridState,
			ProviderUid = provider,
			CallbackFunction = callbackFunction,
			TypeName = typeName,
			CustomStateProvider = customStateProvider,
			Description = gridStateProvider?.Description
		});
	}

	[HttpPost]
	public ActionResult Save(GridState model, Guid? provider = null, string typeName = null, Guid? CustomStateProvider = null)
	{
		GridState gridState = null;
		if (CustomStateProvider.HasValue && CustomStateProvider.Value != Guid.Empty)
		{
			IGridStateProvider gridStateProvider = ComponentManager.Current.GetExtensionPoints<IGridStateProvider>().FirstOrDefault((IGridStateProvider p) => p.Uid == CustomStateProvider.Value);
			if (gridStateProvider != null)
			{
				gridState = gridStateProvider.Load(model.GridId);
			}
		}
		if (gridState == null)
		{
			gridState = GridPersonalizationAdministration.LoadState(model.GridId, provider, false);
		}
		if (!string.IsNullOrWhiteSpace(typeName))
		{
			Type type = ReflectionType.GetType(typeName);
			gridState.Refresh(type);
		}
		if (gridState != null)
		{
			gridState.CurrentPage = model.CurrentPage;
			gridState.PageSize = model.PageSize;
			gridState.SortDirection = model.SortDirection;
			bool flag = gridState.ColumnStates.Any((ColumnState c) => c.UniqueName == model.SortColumnUniqueName) || gridState.CustomColumns.Any((CustomColumnDescriptor c) => c.UniqueName == model.SortColumnUniqueName);
			gridState.SortColumnUniqueName = (flag ? model.SortColumnUniqueName : "");
			gridState.AvailableColumns = model.AvailableColumns;
			gridState.SelectedColumns = model.SelectedColumns;
			gridState.SaveDefault = model.SaveDefault;
			gridState.UseForAllUsers = model.UseForAllUsers;
			if (CustomStateProvider.HasValue && CustomStateProvider.Value != Guid.Empty)
			{
				ComponentManager.Current.GetExtensionPoints<IGridStateProvider>().FirstOrDefault((IGridStateProvider p) => p.Uid == CustomStateProvider.Value)?.Save(model.GridId, gridState);
			}
			else
			{
				GridPersonalizationAdministration.SaveState(model.GridId, gridState, provider, false);
				GridPersonalizationAdministration.SaveState(model.GridId, gridState, provider, true);
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[HttpPost]
	public ActionResult LoadDefault(string gridId, Guid? provider = null)
	{
		string text = null;
		try
		{
			GridState gridState = GridPersonalizationAdministration.LoadState(gridId, provider, false);
			GridState gridState2 = PersonalizationAdministration.LoadState<GridState>("elma", gridId);
			if (gridState2 != null)
			{
				gridState.CurrentPage = gridState2.CurrentPage;
				gridState.PageSize = gridState2.PageSize;
				gridState.SortDirection = gridState2.SortDirection;
				gridState.SortColumnUniqueName = gridState2.SortColumnUniqueName;
				gridState.AvailableColumns = gridState2.AvailableColumns;
				gridState.SelectedColumns = gridState2.SelectedColumns;
				gridState.ColumnsWidth = gridState2.ColumnsWidth;
				gridState.ColumnsOrder = gridState2.ColumnsOrder;
				gridState.ColumnResizeMode = gridState2.ColumnResizeMode;
				gridState.SaveDefault = gridState2.SaveDefault;
				gridState.UseForAllUsers = false;
				if (!gridState.SaveOnlyInSession)
				{
					GridPersonalizationAdministration.SaveState(gridId, gridState, provider, false);
				}
				GridPersonalizationAdministration.SaveState(gridId, gridState, provider, true);
			}
		}
		catch (Exception ex)
		{
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Ошибка загрузки настроек по умолчанию", ex), ex);
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		});
	}

	private bool HasDefaultSaveButton(string gridId, Guid? provider = null)
	{
		return !ComponentManager.Current.GetExtensionPoints<IGridStatePermissionResolver>().Any((IGridStatePermissionResolver r) => !r.HasPermission(gridId, provider));
	}

	[HttpPost]
	public ActionResult SetColumnOrder(string gridId, string columnOrders, Guid? provider = null, string stateId = null)
	{
		try
		{
			string grid = ((!string.IsNullOrEmpty(stateId)) ? stateId : gridId);
			GridState gridState = GridPersonalizationAdministration.LoadState(grid, provider);
			if (gridState != null && !string.IsNullOrWhiteSpace(columnOrders))
			{
				Dictionary<string, int> source = new JsonSerializer().Deserialize<Dictionary<string, int>>(columnOrders);
				gridState.ColumnsOrder = source.Select((KeyValuePair<string, int> columnOrder) => new Tuple<string, int>(columnOrder.Key, columnOrder.Value)).ToList();
				if (!gridState.SaveOnlyInSession)
				{
					GridPersonalizationAdministration.SaveState(grid, gridState, provider, false);
				}
				GridPersonalizationAdministration.SaveState(grid, gridState, provider, true);
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			});
		}
		catch (Exception exception)
		{
			base.Logger.Error("Ошибка сохранения положения колонок", exception);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			});
		}
	}

	[HttpPost]
	public ActionResult SetColumnWidth(string gridId, string columnWidths, Guid? provider = null, string stateId = null)
	{
		return SetColumnWidthWithExpandedWidth(gridId, columnWidths, 0, provider, stateId);
	}

	[HttpPost]
	public ActionResult SetColumnWidthWithExpandedWidth(string gridId, string columnWidths, int expandedWidth, Guid? provider = null, string stateId = null)
	{
		try
		{
			string text = ((!string.IsNullOrEmpty(stateId)) ? stateId : gridId);
			GridState gridState = GridPersonalizationAdministration.LoadState(text, provider);
			if (gridState != null && !string.IsNullOrEmpty(columnWidths))
			{
				Dictionary<string, string> source = new JsonSerializer().Deserialize<Dictionary<string, string>>(columnWidths);
				gridState.ColumnsWidth = source.Select((KeyValuePair<string, string> columnWidth) => new Tuple<string, string>(columnWidth.Key, columnWidth.Value)).ToList();
				if (expandedWidth > 0)
				{
					gridState.ExpandedWidth = expandedWidth;
				}
				if (!gridState.SaveOnlyInSession)
				{
					GridPersonalizationAdministration.SaveState(text, gridState, provider, false);
				}
				GridPersonalizationAdministration.SaveState(text, gridState, provider, true);
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				cansave = HasDefaultSaveButton(text, provider)
			});
		}
		catch (Exception exception)
		{
			base.Logger.Error("Ошибка сохранения ширины колонок", exception);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				cansave = false
			});
		}
	}

	[HttpPost]
	public ActionResult SetColumnResizeMode(int mode, string gridId, Guid? provider = null, string stateId = null)
	{
		try
		{
			string text = ((!string.IsNullOrEmpty(stateId)) ? stateId : gridId);
			GridState gridState = GridPersonalizationAdministration.LoadState(text, provider, false);
			if (gridState != null)
			{
				switch (mode)
				{
				case 0:
					gridState.ColumnResizeMode = ColumnResizeMode.Web;
					break;
				case 1:
					gridState.ColumnResizeMode = ColumnResizeMode.Gui;
					break;
				}
				if (!gridState.SaveOnlyInSession)
				{
					GridPersonalizationAdministration.SaveState(text, gridState, provider, false);
				}
				GridPersonalizationAdministration.SaveState(text, gridState, provider, true);
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				cansave = HasDefaultSaveButton(text, provider)
			});
		}
		catch (Exception exception)
		{
			base.Logger.Error("Ошибка сохранения режима отображения колонок", exception);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				cansave = false
			});
		}
	}
}
