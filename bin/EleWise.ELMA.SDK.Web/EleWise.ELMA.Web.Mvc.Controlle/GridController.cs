using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.SDK.Web.ExtensionPoints;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Util;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class GridController : BaseController
{
	private readonly IEnumerable<IExcelExportPermissionHandler> excelExportPermissionHandlers;

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public GridController(IEnumerable<IExcelExportPermissionHandler> excelExportPermissionHandlers)
	{
		this.excelExportPermissionHandlers = excelExportPermissionHandlers;
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, Guid entityTypeUid, Guid viewItemUid, string query, [JsonBinder] string[] selectedColumns, [JsonBinder] TableViewSortDescriptor[] sortDescriptors, string parentEntityName, string pageUrl)
	{
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_0287: Expected O, but got Unknown
		string text = $"Grid_{viewItemUid}";
		Type type = MetadataRuntimeService.GetTypeByUid(entityTypeUid);
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(type);
		Func<PropertyMetadata, DynamicGridColumn> func;
		if (command == null)
		{
			OriginalGridSettings originalGridSettings = new OriginalGridSettings(metadata, selectedColumns, sortDescriptors);
			GridState state = (originalGridSettings.Equals(GridPersonalizationAdministration.LoadOriginalGridSettings(text)) ? GridPersonalizationAdministration.LoadState(text) : null);
			bool flag = false;
			if (state == null)
			{
				GridPersonalizationAdministration.SaveOriginalGridSettings(text, originalGridSettings);
				state = GridState.CreateNew(text, type);
				state.ColumnStates.ForEach(delegate(ColumnState columnState)
				{
					int num = Array.IndexOf(selectedColumns, columnState.UniqueName);
					if (num >= 0)
					{
						columnState.Hidden = false;
						columnState.Order = num;
					}
					else
					{
						columnState.Hidden = true;
					}
				});
				if (sortDescriptors != null && sortDescriptors.Length != 0 && sortDescriptors[0] != null)
				{
					string uniqueName = sortDescriptors[0].PropertyUid.ToString();
					state.SortExpression = (from columnState in state.ColumnStates
						where columnState.UniqueName == uniqueName
						select columnState.GetDbName()).FirstOrDefault();
					state.SortDirection = sortDescriptors[0].Direction;
				}
				flag = true;
			}
			else
			{
				flag = state.Refresh(type);
			}
			if (flag)
			{
				GridPersonalizationAdministration.SaveState(text, state, null, false);
				GridPersonalizationAdministration.SaveState(text, state, null, true);
			}
			GridCommand val = new GridCommand();
			val.set_PageSize(state.PageSize);
			val.set_Page(state.CurrentPage);
			IList<SortDescriptor> sortDescriptors2 = val.get_SortDescriptors();
			SortDescriptor val2 = new SortDescriptor();
			val2.set_Member(state.SortExpression);
			val2.set_SortDirection(state.SortDirection);
			sortDescriptors2.Add(val2);
			command = val;
			func = delegate(PropertyMetadata prop)
			{
				ColumnState columnState2 = state.ColumnStates[prop.UidStr];
				bool flag3 = columnState2?.Hidden ?? (!prop.ViewSettings.GetForView(ViewType.List).Visible);
				EntitySettings entitySettings = prop.Settings as EntitySettings;
				ICustomSortable customSortable = ComponentManager.Current.GetExtensionPoints<ICustomSortable>().FirstOrDefault((ICustomSortable s) => s.CheckMetadata(metadata, prop.Name));
				return new DynamicGridColumn
				{
					Header = prop.DisplayName,
					SortExpression = prop.Name,
					Sortable = (customSortable?.IsSortable(metadata, prop) ?? (prop.Sortable && (entitySettings == null || entitySettings.RelationType == RelationType.OneToOne))),
					Groupable = prop.Groupable,
					CellAlignment = prop.TableCellAlignment,
					Visible = !flag3,
					UniqueName = prop.Uid.ToString(),
					Name = prop.Name,
					Metadata = metadata,
					ValueType = type.GetReflectionProperty(prop.Name).PropertyType,
					Width = ((columnState2 != null && !string.IsNullOrEmpty(columnState2.WidthAttribute)) ? (columnState2.WidthAttribute + "px") : ((prop.TableColumnWidth > 0) ? (prop.TableColumnWidth + "px") : "")),
					Template = (dynamic e) => TitleCellTemplate(e, prop.Uid)
				};
			};
		}
		else
		{
			func = (PropertyMetadata prop) => new DynamicGridColumn
			{
				Header = prop.DisplayName,
				SortExpression = prop.Name,
				Groupable = prop.Groupable,
				CellAlignment = prop.TableCellAlignment,
				UniqueName = prop.Uid.ToString(),
				Name = prop.Name,
				Metadata = metadata,
				ValueType = type.GetReflectionProperty(prop.Name).PropertyType,
				Template = (dynamic e) => TitleCellTemplate(e, prop.Uid)
			};
		}
		if (((Controller)this).get_HttpContext() != null && AjaxRequestExtensions.IsAjaxRequest(((Controller)this).get_HttpContext().Request) && !((ControllerBase)this).get_ViewData().ContainsKey("IsDynamicInitialized"))
		{
			((ControllerBase)this).get_ViewData().Add("IsDynamicInitialized", (object)true);
		}
		IGridData gridData = GetGridData(command, entityTypeUid, viewItemUid, query);
		bool flag2 = excelExportPermissionHandlers.Any((IExcelExportPermissionHandler x) => x.CanExportType(metadata));
		DynamicGrid grid = new DynamicGrid(text, text, gridData, type)
		{
			Columns = new List<GridColumn>(),
			ExportExcel = flag2,
			Customizable = true,
			EnableCustomize = true,
			HeaderVisible = true,
			Resizeable = true,
			Sortable = true,
			Reorderable = true,
			ExportExcelFileName = parentEntityName
		};
		PropertyMetadata titleProperty = metadata.GetTitleProperty();
		if (titleProperty != null)
		{
			grid.Columns.Add(func(titleProperty));
		}
		if (flag2)
		{
			return ExportExcel(gridData, type, () => (ActionResult)(object)((Controller)this).PartialView("Templates/DynamicGrid", (object)grid), new GridExportExcelOptions
			{
				Title = parentEntityName,
				TitleUrl = pageUrl
			});
		}
		return (ActionResult)(object)((Controller)this).PartialView("Templates/DynamicGrid", (object)grid);
	}

	public static long Count(IEntity entity, GridViewItem viewItem)
	{
		return GetGridData(null, viewItem.EntityUid, viewItem.Uid, viewItem.GetFilterQuery(entity))?.Count ?? 0;
	}

	private string TitleCellTemplate(IEntity entity, Guid titlePropertyUid)
	{
		object propertyValue = entity.GetPropertyValue(titlePropertyUid);
		propertyValue = HttpUtility.HtmlEncode(propertyValue ?? string.Empty);
		return $"<a href=\"{((Controller)this).get_Url().Entity(entity)}\">{propertyValue}</a>";
	}

	private static IGridData GetGridData(GridCommand command, Guid entityTypeUid, Guid viewItemUid, string query)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(entityTypeUid);
		if (typeByUidOrNull == null)
		{
			return null;
		}
		return (IGridData)typeof(GridController).GetMethod("GetGridDataGeneric", BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(typeByUidOrNull).Invoke(null, new object[3] { command, viewItemUid, query });
	}

	[UsedImplicitly]
	private static IGridData GetGridDataGeneric<T>(GridCommand command, Guid viewItemUid, string query) where T : IEntity
	{
		return ContextVars.GetOrAdd("GridController_GridDatas", () => new ConcurrentDictionary<Guid, IGridData>()).AddOrUpdate(viewItemUid, (Guid item) => GridBuilderExtensions.GetFilteredGridData<T, IEntityFilter>(command, new Filter
		{
			Query = query
		}), delegate(Guid item, IGridData data)
		{
			((GridData<T, IEntityFilter>)data).Command = command;
			return data;
		});
	}
}
