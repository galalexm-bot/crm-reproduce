using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Telerik.Grids;
using EleWise.ELMA.Web.Mvc.Util;
using Iesi.Collections.Generic;
using Newtonsoft.Json;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.Extensions;
using Telerik.Web.Mvc.Infrastructure;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Fluent;
using Telerik.Web.Mvc.UI.Grid;
using Telerik.Web.Mvc.UI.Html;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class GridBuilderExtensions
{
	private class GridDataRowResult
	{
		public Dictionary<string, object> ResultSet { get; set; }

		public Dictionary<string, int> ColspanSet { get; set; }

		public Dictionary<string, object> ResultEditSet { get; set; }

		public Dictionary<string, bool> ResultEditHidden { get; set; }

		public Dictionary<string, object> ValidationMetadata { get; set; }

		public string RowClass { get; set; }

		public string RowStyle { get; set; }

		public Dictionary<string, string> RowHtmlAttributes { get; set; }

		public Dictionary<string, IDictionary<string, string>> CellAttributesSet { get; set; }

		public GridDataRowResult()
		{
			ResultSet = new Dictionary<string, object>();
			ColspanSet = new Dictionary<string, int>();
		}
	}

	public const string ColumnViewPostfix = "_$view";

	public const string ColumnExportPostfix = "_$export";

	private const string isRowEditing_key = "1089EFE7-837A-4CC9-A011-41692427E7A9";

	internal static bool IsRowInEditMode
	{
		get
		{
			return ContextVars.GetOrDefault<bool>("1089EFE7-837A-4CC9-A011-41692427E7A9");
		}
		set
		{
			ContextVars.Set("1089EFE7-837A-4CC9-A011-41692427E7A9", value);
		}
	}

	public static IGridData GetGridData<T>(GridCommand command) where T : IEntity
	{
		GridData<T> obj = new GridData<T>
		{
			Command = command
		};
		IEntityManager<T> manager = EntityManager<T>.Instance;
		obj.SetCount((GridData<T> d, FetchOptions f) => manager.Count());
		obj.SetDataSource((GridData<T> d, FetchOptions f) => manager.Find(f));
		return obj;
	}

	internal static IGridData GetFilteredGridData<T, TF>(Guid entityTypeUid, int page, int pageSize, IEnumerable<TableViewSortDescriptor> sortDescriptors, IEnumerable<TableViewGroupDescriptor> groupDescriptors, string filter, TF entityFilter) where T : IEntity where TF : IEntityFilter
	{
		return GetFilteredGridData<T, IEntityFilter>(CreateGridCommand(entityTypeUid, page, pageSize, sortDescriptors, groupDescriptors, filter), manager: ModelHelper.GetEntityManager(entityTypeUid), filter: entityFilter);
	}

	internal static IGridData<T> GetBlockData<T>(Guid entityTypeUid, IEnumerable items, ClassMetadata metadata, string gridId, int page, int pageSize, bool pageable, int count, IEnumerable<TableViewSortDescriptor> sortDescriptors, IEnumerable<TableViewGroupDescriptor> groupDescriptors)
	{
		GridCommand val = CreateBlockCommand(metadata, gridId, pageSize, page, sortDescriptors, groupDescriptors);
		GridData<T> gridData = new GridData<T>
		{
			Command = val,
			IsPageable = pageable
		};
		gridData.SortDirection = (val.get_SortDescriptors().Any() ? val.get_SortDescriptors()[0].get_SortDirection() : ListSortDirection.Ascending);
		gridData.SortExpression = (val.get_SortDescriptors().Any() ? val.get_SortDescriptors()[0].get_Member() : null);
		gridData.PageSize = ((val.get_PageSize() > 1) ? val.get_PageSize() : 15);
		gridData.PageIndex = ((val.get_Page() <= 1) ? 1 : val.get_Page());
		if (val.get_GroupDescriptors().Any())
		{
			gridData.GroupDescriptors = new List<GridGroupDescriptor>();
			foreach (GroupDescriptor groupDescriptor in val.get_GroupDescriptors())
			{
				gridData.GroupDescriptors.Add(new GridGroupDescriptor
				{
					Member = ((SortDescriptor)groupDescriptor).get_Member(),
					SortDirection = ((SortDescriptor)groupDescriptor).get_SortDirection()
				});
			}
		}
		bool flag = true;
		IEnumerable<T> enumerable = ((items != null) ? items.OfType<T>() : null);
		if (items != null)
		{
			if (count != 0)
			{
				flag = false;
			}
			enumerable = (IEnumerable<T>)(items = val.ApplySorting(enumerable));
			if (pageable && pageSize > 0 && !flag)
			{
				int num = ((val.get_PageSize() > 0) ? ((enumerable.Count() - 1) / val.get_PageSize() + 1) : int.MaxValue);
				if (val.get_Page() > num)
				{
					val.set_Page((num <= 1) ? 1 : num);
				}
				enumerable = (IEnumerable<T>)(items = val.ApplyPaging(enumerable));
			}
			if (val.get_GroupDescriptors().Any())
			{
				items = val.ApplyGrouping(enumerable);
			}
		}
		int count2 = ((count != 0) ? count : (enumerable?.Count() ?? 0));
		gridData.SetData(count2, items);
		if (flag)
		{
			gridData.SetDataSource((GridData<T> d, FetchOptions f) => items.Cast<object>().Skip(f.FirstResult));
		}
		return gridData;
	}

	private static GridCommand CreateBlockCommand(ClassMetadata metadata, string gridStateId, int pageSize, int page, IEnumerable<TableViewSortDescriptor> sortDescriptors, IEnumerable<TableViewGroupDescriptor> groupDescriptors)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		GridState gridState = GridPersonalizationAdministration.LoadState(gridStateId, Guid.Empty);
		GridCommand val = new GridCommand();
		val.set_Page((page > 0) ? page : gridState.CurrentPage);
		val.set_PageSize((pageSize > 1) ? pageSize : gridState.PageSize);
		if (metadata != null && groupDescriptors != null)
		{
			val.get_GroupDescriptors().Clear();
			foreach (TableViewGroupDescriptor groupDescriptor in groupDescriptors)
			{
				Guid propertyUid2 = groupDescriptor.PropertyUid;
				PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == propertyUid2);
				if (propertyMetadata != null)
				{
					IList<GroupDescriptor> groupDescriptors2 = val.get_GroupDescriptors();
					GroupDescriptor val2 = new GroupDescriptor();
					((SortDescriptor)val2).set_Member(propertyMetadata.Name);
					((SortDescriptor)val2).set_SortDirection(groupDescriptor.Direction);
					groupDescriptors2.Add(val2);
				}
			}
		}
		else if (gridState != null && gridState.GroupDescriptors != null)
		{
			val.get_GroupDescriptors().Clear();
			foreach (GridGroupDescriptor groupDescriptor2 in gridState.GroupDescriptors)
			{
				IList<GroupDescriptor> groupDescriptors3 = val.get_GroupDescriptors();
				GroupDescriptor val3 = new GroupDescriptor();
				((SortDescriptor)val3).set_Member(groupDescriptor2.Member);
				((SortDescriptor)val3).set_SortDirection(groupDescriptor2.SortDirection);
				groupDescriptors3.Add(val3);
			}
		}
		if (metadata != null && sortDescriptors != null)
		{
			val.get_SortDescriptors().Clear();
			{
				foreach (TableViewSortDescriptor sortDescriptor in sortDescriptors)
				{
					Guid propertyUid = sortDescriptor.PropertyUid;
					PropertyMetadata propertyMetadata2 = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == propertyUid);
					if (propertyMetadata2 != null)
					{
						IList<SortDescriptor> sortDescriptors2 = val.get_SortDescriptors();
						SortDescriptor val4 = new SortDescriptor();
						val4.set_Member(propertyMetadata2.Name);
						val4.set_SortDirection(sortDescriptor.Direction);
						sortDescriptors2.Add(val4);
					}
				}
				return val;
			}
		}
		if (gridState != null && !gridState.SortExpression.IsNullOrWhiteSpace())
		{
			val.get_SortDescriptors().Clear();
			IList<SortDescriptor> sortDescriptors3 = val.get_SortDescriptors();
			SortDescriptor val5 = new SortDescriptor();
			val5.set_Member(gridState.SortExpression);
			val5.set_SortDirection(gridState.SortDirection);
			sortDescriptors3.Add(val5);
		}
		return val;
	}

	private static GridCommand CreateGridCommand(Guid entityTypeUid, int page, int pageSize, IEnumerable<TableViewSortDescriptor> sortDescriptors, IEnumerable<TableViewGroupDescriptor> groupDescriptors, string filter)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		GridCommand val = GridCommand.Parse(page, pageSize, "", "", filter);
		if (MetadataLoader.LoadMetadata(entityTypeUid) is ClassMetadata classMetadata)
		{
			foreach (TableViewSortDescriptor sortDescriptor in sortDescriptors)
			{
				string nameSortExpression = PropertyHelper.GetNameSortExpression(classMetadata.Properties.Find((PropertyMetadata a) => a.Uid == sortDescriptor.PropertyUid));
				IList<SortDescriptor> sortDescriptors2 = val.get_SortDescriptors();
				SortDescriptor val2 = new SortDescriptor();
				val2.set_Member(nameSortExpression);
				val2.set_SortDirection(sortDescriptor.Direction);
				sortDescriptors2.Add(val2);
			}
			{
				foreach (TableViewGroupDescriptor groupDescriptor in groupDescriptors)
				{
					string nameSortExpression2 = PropertyHelper.GetNameSortExpression(classMetadata.Properties.Find((PropertyMetadata a) => a.Uid == groupDescriptor.PropertyUid));
					IList<GroupDescriptor> groupDescriptors2 = val.get_GroupDescriptors();
					GroupDescriptor val3 = new GroupDescriptor();
					((SortDescriptor)val3).set_Member(nameSortExpression2);
					((SortDescriptor)val3).set_SortDirection(groupDescriptor.Direction);
					groupDescriptors2.Add(val3);
				}
				return val;
			}
		}
		return val;
	}

	public static IGridData GetFilteredGridData<T, TF>(GridCommand command, TF filter) where T : IEntity where TF : IEntityFilter
	{
		IEntityManager entityManagerByFilter = GetEntityManagerByFilter<T>(filter);
		return GetFilteredGridData<T, TF>(command, filter, entityManagerByFilter);
	}

	internal static IGridData GetFilteredGridData<T, TF>(GridCommand command, TF filter, IEntityManager manager) where T : IEntity where TF : IEntityFilter
	{
		GridData<T, TF> gridData = new GridData<T, TF>();
		gridData.Command = command;
		gridData.DataFilter = filter;
		gridData.SetCount((GridData<T, TF> d, FetchOptions f) => manager.Count(d.DataFilter));
		gridData.SetDataSource((GridData<T, TF> d, FetchOptions f) => manager.Find(d.DataFilter, f).Cast<T>());
		return gridData;
	}

	public static IGridData GetFilteredGridNoData<T, TF>(GridCommand command, TF filter) where T : IEntity where TF : IEntityFilter
	{
		return new GridData<T, TF>
		{
			Command = command,
			DataFilter = filter
		};
	}

	public static IList<GridColumn> GetDefaultColumns(Type type, ClassMetadata metadata, GridState state, bool childs = false, IEnumerable<Guid> availablePropertyUids = null)
	{
		return GetDefaultColumns(type, metadata, state, childs, availablePropertyUids, null);
	}

	public static IList<GridColumn> GetDefaultColumns(Type type, ClassMetadata metadata, GridState state, bool childs, IEnumerable<Guid> availablePropertyUids, IEnumerable<Guid> propertyUids)
	{
		Type type2 = InterfaceActivator.TypeOf(type);
		List<GridColumn> list = new List<GridColumn>();
		List<KeyValuePair<PropertyMetadata, ClassMetadata>> metadataProperties = MetadataLoader.GetBasePropertiesAndMetadata(metadata);
		IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> enumerable;
		if (!childs)
		{
			enumerable = metadata.Properties.Select((PropertyMetadata p) => new KeyValuePair<PropertyMetadata, ClassMetadata>(p, metadata));
		}
		else
		{
			IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> childProperties = MetadataLoader.GetChildProperties(metadata);
			enumerable = childProperties;
		}
		IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> source = enumerable;
		HashSet<Guid> basePropertiesMetadata = metadataProperties.Select((KeyValuePair<PropertyMetadata, ClassMetadata> a) => a.Key.Uid).ToHashSet();
		metadataProperties.AddRange(source.Where((KeyValuePair<PropertyMetadata, ClassMetadata> p) => !basePropertiesMetadata.Contains(p.Key.Uid)));
		List<ICustomSortable> source2 = ComponentManager.Current.GetExtensionPoints<ICustomSortable>().ToList();
		IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> enumerable2;
		if (propertyUids != null)
		{
			enumerable2 = from u in propertyUids
				select metadataProperties.FirstOrDefault((KeyValuePair<PropertyMetadata, ClassMetadata> p) => p.Key.Uid == u) into p
				where p.Key != null
				select p;
		}
		else
		{
			IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> childProperties = metadataProperties;
			enumerable2 = childProperties;
		}
		Guid[] array = availablePropertyUids?.ToArray();
		HashedSet<string> val = new HashedSet<string>();
		HashSet<Guid> hashSet = metadata.Properties.Select((PropertyMetadata a) => a.Uid).ToHashSet();
		foreach (KeyValuePair<PropertyMetadata, ClassMetadata> item2 in enumerable2)
		{
			PropertyMetadata key = item2.Key;
			Guid uid = key.Uid;
			if (array != null && !array.Contains(uid))
			{
				continue;
			}
			ViewAttribute forView = key.ViewSettings.GetForView(ViewType.List);
			if (forView.Visibility == Visibility.ForceHidden)
			{
				continue;
			}
			ClassMetadata value = item2.Value;
			string text = ((childs && !hashSet.Contains(uid)) ? CustomPropertyProjection.GetStringFromExpression(key.Name, value.FullTypeName) : key.Name);
			if (((Set<string>)(object)val).Add(text))
			{
				Type typeObject = key.DeclaringType ?? ((value.Uid == metadata.Uid) ? type2 : MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(value.Uid));
				Type propertyType = (typeObject.GetPropertyCached(key.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public) ?? typeObject.GetPropertyCached(key.Name)).PropertyType;
				string uidStr = key.UidStr;
				ColumnState columnState = state?.ColumnStates[uidStr];
				bool flag = columnState?.Hidden ?? (!forView.Visible);
				EntitySettings entitySettings = key.Settings as EntitySettings;
				string sortExpression = PropertyHelper.GetSortExpression(key, text);
				ICustomSortable customSortable = source2.FirstOrDefault((ICustomSortable s) => s.CheckMetadata(metadata, sortExpression));
				DynamicGridColumn item = new DynamicGridColumn
				{
					Header = key.DisplayName.HtmlEncode(),
					SortExpression = sortExpression,
					Sortable = (customSortable?.IsSortable(metadata, key) ?? (key.Sortable && (entitySettings == null || entitySettings.RelationType == RelationType.OneToOne))),
					Groupable = key.Groupable,
					CellAlignment = key.TableCellAlignment,
					Visible = !flag,
					UniqueName = uid.ToString(),
					Name = text,
					Metadata = value,
					ValueType = propertyType,
					Width = ((columnState != null && !string.IsNullOrEmpty(columnState.WidthAttribute)) ? (columnState.WidthAttribute + "px") : ((key.TableColumnWidth > 0) ? (key.TableColumnWidth + "px") : ""))
				};
				list.Add(item);
			}
		}
		return list;
	}

	public static GridUtilityBuilder GridUtility(this HtmlHelper html, string id, GridCommands command = GridCommands.Custom)
	{
		return new GridUtilityBuilder(id, command);
	}

	public static MvcHtmlString Grid(this HtmlHelper html, DynamicGrid model)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		return (MvcHtmlString)typeof(GridBuilderExtensions).GetMethod("GenericGrid", BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(model.Type).Invoke(null, new object[2] { html, model });
	}

	public static MvcHtmlString CardGrid(this HtmlHelper html, DynamicGrid model)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		model.HeaderVisible = false;
		model.AlternationClass += "t-card-grid-table";
		return (MvcHtmlString)typeof(GridBuilderExtensions).GetMethod("GenericGrid", BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(model.Type).Invoke(null, new object[2] { html, model });
	}

	public static MvcHtmlString TableGrid(this HtmlHelper html, TableGrid model)
	{
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		try
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}
			if (model == null)
			{
				throw new ArgumentNullException("model");
			}
			GridBuilder<DataRowView> tableGrid = GetTableGrid(html, model);
			if (((ControllerContext)html.get_ViewContext()).get_HttpContext() != null)
			{
				if (!AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)html.get_ViewContext()).get_HttpContext().Request) && ((ControllerContext)html.get_ViewContext()).get_HttpContext().Items != null && ((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["GridResultDictionary"] != null)
				{
					((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["GridResultDictionary"] = null;
				}
				if (AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)html.get_ViewContext()).get_HttpContext().Request) && ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.HttpMethod == "POST" && !string.IsNullOrWhiteSpace(((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.Params.Get("gridId")) && !((ControllerContext)html.get_ViewContext()).get_HttpContext().EditingFormEnabled())
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					IEnumerable value = new List<Dictionary<string, object>>();
					Dictionary<int, Dictionary<string, int>> dictionary2 = new Dictionary<int, Dictionary<string, int>>();
					Dictionary<int, string> dictionary3 = new Dictionary<int, string>();
					Dictionary<int, string> dictionary4 = new Dictionary<int, string>();
					Dictionary<int, IDictionary<string, string>> dictionary5 = new Dictionary<int, IDictionary<string, string>>();
					Dictionary<int, Dictionary<string, IDictionary<string, string>>> dictionary6 = new Dictionary<int, Dictionary<string, IDictionary<string, string>>>();
					Grid<DataRowView> val = ViewComponentBuilderBase<Grid<DataRowView>, GridBuilder<DataRowView>>.op_Implicit((ViewComponentBuilderBase<Grid<DataRowView>, GridBuilder<DataRowView>>)(object)tableGrid);
					IGridCellBuilderFactory cellBuilderFactory = DI.get_Current().Resolve<IGridCellBuilderFactory>();
					GridHtmlHelper<DataRowView> gridHtmlHelper = new GridHtmlHelper<DataRowView>(((ViewComponentBase)val).get_ViewContext(), val.get_DataKeyStore());
					if (model.Total > 0)
					{
						int rowIndex = 0;
						IEnumerable enumerable;
						if (!model.Groupable || !model.GroupDescriptors.Any())
						{
							IEnumerable dataSource = val.get_DataSource();
							enumerable = dataSource;
						}
						else
						{
							enumerable = GridDataExtensions.ApplyTableGrouping(model.GroupDescriptors.Select((GridGroupDescriptor gd) => gd.Member), val.get_DataSource());
						}
						IEnumerable dataSource2 = enumerable;
						value = CreateTableGridInputs(html, ViewComponentBuilderBase<Grid<DataRowView>, GridBuilder<DataRowView>>.op_Implicit((ViewComponentBuilderBase<Grid<DataRowView>, GridBuilder<DataRowView>>)(object)tableGrid), cellBuilderFactory, gridHtmlHelper, dataSource2, model, dictionary2, dictionary3, dictionary4, dictionary5, dictionary6, ref rowIndex, out var _);
					}
					dictionary["data"] = value;
					dictionary["total"] = model.Total;
					dictionary["currentPage"] = model.PageIndex;
					dictionary["colspans"] = dictionary2;
					dictionary["rowclasses"] = dictionary3;
					dictionary["rowstyles"] = dictionary4;
					dictionary["cellhtmlattributes"] = dictionary6;
					dictionary["rowHtmlAttributes"] = dictionary5;
					dictionary["headerSummary"] = ((model.HeaderSummary != null) ? model.HeaderSummary(html).ToString() : "");
					dictionary["headerVisible"] = model.HeaderVisible;
					if (model.ShowEditorsDescription)
					{
						dictionary["showEditorsDescription"] = "true";
					}
					if (!string.IsNullOrEmpty(html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix()))
					{
						dictionary["prefix"] = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
					}
					if (model.ExtendedAjaxProperties != null)
					{
						foreach (KeyValuePair<string, object> extendedAjaxProperty in model.ExtendedAjaxProperties)
						{
							dictionary[extendedAjaxProperty.Key] = extendedAjaxProperty.Value;
						}
					}
					if (((ControllerContext)html.get_ViewContext()).get_HttpContext().Items != null)
					{
						((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["GridResultDictionary"] = dictionary;
					}
					return MvcHtmlString.Empty;
				}
			}
			return new MvcHtmlString(((object)tableGrid).ToString());
		}
		catch (Exception ex)
		{
			Logger.Log.Error(SR.T("Ошибка при формировании таблицы", ex));
			throw;
		}
	}

	private static GridBuilder<DataRowView> GetTableGrid([NotNull] HtmlHelper html, [NotNull] TableGrid model)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		GridState state = model.State;
		if (model.Customizable || model.Columns.Count == 0)
		{
			IEnumerable<ColumnState> columnStates = state.ColumnStates;
			foreach (ColumnState column in columnStates ?? EleWise.ELMA.Helpers.EmptyArray<ColumnState>.Instance)
			{
				if (!model.Table.Columns.Contains(column.Name))
				{
					continue;
				}
				if (model.Columns.All((GridColumn c) => c.UniqueName != column.UniqueName))
				{
					try
					{
						DataColumn dataColumn = model.Table.Columns[column.Name];
						Type dataType = dataColumn.DataType;
						if (model.Table.Columns.Contains(dataColumn.ColumnName + "_$view"))
						{
							dataType = model.Table.Columns[dataColumn.ColumnName + "_$view"].DataType;
						}
						else if (model.Table.Columns.Contains(dataColumn.ColumnName + "_$export"))
						{
							dataType = model.Table.Columns[dataColumn.ColumnName + "_$export"].DataType;
						}
						model.Columns.Add(new DynamicGridColumn
						{
							Header = column.DisplayName,
							SortExpression = column.Name,
							Visible = !column.Hidden,
							UniqueName = column.UniqueName,
							Name = column.Name,
							ValueType = dataType.NullableType(),
							Width = ((!string.IsNullOrEmpty(column.WidthAttribute)) ? (column.WidthAttribute + "px") : ""),
							Sortable = column.Sortable,
							Groupable = column.Sortable
						});
					}
					catch (Exception exception)
					{
						Logger.Log.Warn(SR.T("Невозможно добавить колонку {0} в таблицу", column.UniqueName), exception);
					}
				}
				GridColumn gridColumn = model.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == column.UniqueName);
				if (gridColumn != null && gridColumn.Order == int.MinValue)
				{
					gridColumn.Order = column.Order;
				}
			}
		}
		model.Columns = model.Columns.OrderBy((GridColumn c) => c.Order).ToList();
		GridBuilder<DataRowView> grid = ((ViewComponentBuilderBase<Grid<DataRowView>, GridBuilder<DataRowView>>)(object)HtmlHelperExtension.Telerik(html).Grid(model.Table)).Name(model.UniqueName);
		((ViewComponentBuilderBase<Grid<DataRowView>, GridBuilder<DataRowView>>)(object)grid).AddHtmlAttribute("provider", (object)model.StateProviderUid);
		grid.Columns((Action<GridColumnFactory<DataRowView>>)delegate(GridColumnFactory<DataRowView> columns)
		{
			foreach (GridColumn column2 in model.Columns)
			{
				if (column2.Visible && model.Table.Columns.Contains(column2.Name))
				{
					GetGenericMethod("BoundTableColumn", column2.ValueType).Invoke(null, new object[4] { html, model, column2, columns });
				}
			}
			columns.AutoGenerate(false);
		});
		GridExportExcelUtility.ExportExcelStatus exportExcelStatus = (model.ExportExcel ? GridExportExcelUtility.GetExportExcelStatus(HttpContext.Current.Session.SessionID, AuthenticationService.GetCurrentUser().GetId(), model.UniqueName) : null);
		grid.ExportExcel(model.ExportExcel, model.ExportExcelFileName, (ExportExcelStatus)((exportExcelStatus != null && string.IsNullOrEmpty(exportExcelStatus.Error)) ? ((!exportExcelStatus.Ready) ? 1 : 2) : 0), (exportExcelStatus != null && string.IsNullOrEmpty(exportExcelStatus.Error)) ? (html.Url().Action("Download", "BinaryFiles", (object)new
		{
			area = "EleWise.ELMA.SDK.Web"
		}) + "/" + exportExcelStatus.FileGuid) : null, exportExcelStatus?.Error);
		if (model.HeaderSummary != null)
		{
			grid.HeaderSummary(model.HeaderSummary(html).ToString());
		}
		grid.Settings(model.Customizable && model.EnableCustomize);
		if (model.ClientEvents != null)
		{
			grid.ClientEvents(model.ClientEvents);
		}
		List<string> list = new List<string>();
		if (!model.HeaderVisible)
		{
			list.Add("noth");
		}
		if (!string.IsNullOrEmpty(model.AlternationClass))
		{
			list.Add(model.AlternationClass);
		}
		if (model.Resizeable)
		{
			if (!model.LockedResizeMode.HasValue)
			{
				list.Add("resize-mode-web");
			}
			else
			{
				list.Add((model.LockedResizeMode == ColumnResizeMode.Web) ? "resize-mode-web" : "resize-mode-gui");
				list.Add("locked-mode");
			}
		}
		if (model.Total == 0L)
		{
			list.Add("t-grid-no-data");
		}
		if (list.Any())
		{
			grid.TableHtmlAttributes((object)new
			{
				@class = string.Join(" ", list)
			});
		}
		grid.EnableCustomBinding(model.IsServerBinding);
		if (model.IsAjax)
		{
			string action = ((!string.IsNullOrEmpty(model.Action)) ? model.Action : (((ControllerContext)html.get_ViewContext()).get_RouteData().Values.ContainsKey("action") ? ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["action"].ToString() : "Grid"));
			string controller = ((!string.IsNullOrEmpty(model.Controller)) ? model.Controller : ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["controller"].ToString());
			RouteValueDictionary routeValues = model.RouteValues ?? new RouteValueDictionary();
			if (!routeValues.ContainsKey("gridId"))
			{
				routeValues.Add("gridId", model.UniqueName);
			}
			if (!routeValues.ContainsKey("provider"))
			{
				routeValues.Add("provider", model.StateProviderUid);
			}
			grid.DataBinding((Action<GridDataBindingConfigurationBuilder>)delegate(GridDataBindingConfigurationBuilder dataBinding)
			{
				GridBindingSettingsBuilder val2 = dataBinding.Ajax().Select(action, controller, routeValues);
				if (model.ExportExcel)
				{
					val2.ExportExcelReset("GridExportExcelReset", controller, routeValues);
				}
			});
		}
		if (model.IsPageable)
		{
			grid.Pageable((Action<GridPagerSettingsBuilder>)delegate(GridPagerSettingsBuilder paging)
			{
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				paging.Total((model.Total > int.MaxValue) ? int.MaxValue : Convert.ToInt32(model.Total)).Position(model.PagerPosition).PageSize(model.PageSize)
					.CardPager(model.IsCardPager);
			});
		}
		grid.Resizable((Action<GridResizingSettingsBuilder>)delegate(GridResizingSettingsBuilder s)
		{
			s.Columns(model.Resizeable);
		});
		if (model.Resizeable)
		{
			grid.Scrollable((Action<GridScrollSettingsBuilder>)delegate(GridScrollSettingsBuilder s)
			{
				s.Height("100%");
			});
		}
		if (model.Reorderable)
		{
			grid.Reorderable((Action<GridReorderingSettingsBuilder>)delegate(GridReorderingSettingsBuilder s)
			{
				s.Columns(true);
			});
		}
		grid.Sortable((Action<GridSortSettingsBuilder<DataRowView>>)delegate(GridSortSettingsBuilder<DataRowView> sorting)
		{
			if (model.Sortable)
			{
				sorting.SortMode((GridSortMode)0);
			}
			else
			{
				grid.Sortable((Action<GridSortSettingsBuilder<DataRowView>>)delegate(GridSortSettingsBuilder<DataRowView> s)
				{
					s.Enabled(false);
				});
			}
			if (!string.IsNullOrEmpty(model.SortExpression))
			{
				sorting.OrderBy((Action<GridSortDescriptorFactory<DataRowView>>)delegate(GridSortDescriptorFactory<DataRowView> o)
				{
					GridSortDescriptorBuilder val = o.Add(model.SortExpression);
					if (model.SortDirection == ListSortDirection.Ascending)
					{
						val.Ascending();
					}
					else
					{
						val.Descending();
					}
				});
			}
		});
		grid.Groupable((Action<GridGroupingSettingsBuilder<DataRowView>>)delegate(GridGroupingSettingsBuilder<DataRowView> grouping)
		{
			grouping.Visible(model.Groupable);
			if (model.GroupDescriptors != null && model.GroupDescriptors.Any())
			{
				grouping.Groups((Action<GridGroupDescriptorFactory<DataRowView>>)delegate(GridGroupDescriptorFactory<DataRowView> g)
				{
					foreach (GridGroupDescriptor groupDescriptor in model.GroupDescriptors)
					{
						g.Add(groupDescriptor.Member, groupDescriptor.SortDirection);
					}
				});
			}
		});
		grid.Footer(model.Footer);
		if (model.DetailViewClientTemplate != null || model.DetailViewTemplate != null)
		{
			grid.DetailView((Action<GridDetailViewBuilder<DataRowView>>)delegate(GridDetailViewBuilder<DataRowView> d)
			{
				if (model.DetailViewClientTemplate != null)
				{
					d.ClientTemplate(model.DetailViewClientTemplate());
				}
				if (model.DetailViewTemplate != null)
				{
					d.Template((Func<DataRowView, object>)model.DetailViewTemplate);
				}
				if (model.DetailViewTemplateVisible != null)
				{
					d.TemplateVisible((Func<DataRowView, bool>)model.DetailViewTemplateVisible);
				}
				d.ExpandDetailRows(model.ExpandDetailRows);
			});
		}
		grid = grid.Localizable(Thread.CurrentThread.CurrentCulture.ToString());
		return grid;
	}

	public static DynamicGridBuilder<TData> DynamicGrid<TData>(this HtmlHelper htmlHelper, string uniqueName, IGridData<TData> gridData, Guid? stateProvider = null) where TData : class
	{
		return new DynamicGridBuilder<TData>(htmlHelper, uniqueName, uniqueName, gridData, stateProvider);
	}

	public static DynamicGridBuilder<T> Table<T>(this HtmlHelper html, IEnumerable<T> source) where T : class
	{
		return html.Table(html.GenerateName(), source);
	}

	public static DynamicGridBuilder<T> Table<T>(this HtmlHelper html, string name, IEnumerable<T> source) where T : class
	{
		GridData<T> gridData = new GridData<T>
		{
			DataSource = source,
			IsAjax = false,
			IsPageable = false
		};
		gridData.SetCount((GridData<T> d, FetchOptions f) => source.Count());
		return new DynamicGridBuilder<T>(html, name, $"{name}_dynamicContentId", gridData);
	}

	public static void InitSelectedColumnsFromState(Type entityType, GridState state, FetchOptions f, bool useProjection)
	{
		if (state == null || state.ColumnStates == null || state.ColumnStates.Count <= 0)
		{
			return;
		}
		FetchOptionsBuilder fetchOptionsBuilder = FetchOptionsBuilder.Create(f).UseProjections(useProjection).UsePartialFetching(useProjection);
		foreach (ColumnState item in state.ColumnStates.Where((ColumnState c) => !c.Hidden))
		{
			string dbName = item.GetDbName(withParent: true);
			if (dbName != null)
			{
				fetchOptionsBuilder.SelectColumns(dbName);
			}
		}
		foreach (KeyValuePair<PropertyMetadata, EntityMetadata> item2 in (from p in ComponentManager.Current.GetExtensionPoints<IDefaultSelectedColumnsProvider>()
			where entityType.IsAssignableFrom(p.EntityType) || p.EntityType.IsAssignableFrom(entityType)
			select p).ToList().SelectMany((IDefaultSelectedColumnsProvider p) => p.GetProperties()).ToList())
		{
			string propertyName = ColumnState.FormatFullColumnDescription(item2.Value, item2.Key);
			fetchOptionsBuilder.SelectColumns(propertyName);
		}
	}

	public static void InitFetchColumns(IGridData gridData, FetchOptions f)
	{
		if (gridData.GridModel.FetchColumns != null && gridData.GridModel.FetchColumns.Count > 0)
		{
			f.FetchRelations = new List<string>();
			f.FetchRelations.AddRange(gridData.GridModel.FetchColumns);
		}
	}

	public static IEntityManager GetEntityManagerByFilter<T>(IEntityFilter filter)
	{
		Type type = AttributeHelper<FilterForAttribute>.GetAttribute(filter.GetType(), inherited: true)?.EntityType;
		if (type == null || !type.IsInheritOrSame<T>())
		{
			type = typeof(T);
		}
		return ModelHelper.GetEntityManager(type);
	}

	public static GridCommand GetCommandFromRequest(NameValueCollection param, string gridUniqueName)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		string text = param.Get("gridUniqueName");
		string text2 = param.Get("gridId");
		if (!string.IsNullOrWhiteSpace(text) && text.Contains(gridUniqueName) && text2 == null)
		{
			GridCommand val = new GridCommand();
			string text3 = param.Get($"{gridUniqueName}-{GridUrlParameters.get_PageSize()}");
			if (!string.IsNullOrWhiteSpace(text3) && int.TryParse(text3, out var result))
			{
				val.set_PageSize(result);
			}
			string text4 = param.Get($"{gridUniqueName}-{GridUrlParameters.get_CurrentPage()}");
			if (!string.IsNullOrWhiteSpace(text4) && int.TryParse(text4, out var result2))
			{
				val.set_Page(result2);
			}
			string text5 = param.Get($"{gridUniqueName}-{GridUrlParameters.get_OrderBy()}");
			if (text5 != null)
			{
				IList<SortDescriptor> list = GridDescriptorSerializer.Deserialize<SortDescriptor>(text5);
				if (list != null && list.Any())
				{
					IList<SortDescriptor> sortDescriptors = val.get_SortDescriptors();
					SortDescriptor val2 = new SortDescriptor();
					val2.set_Member(list[0].get_Member());
					val2.set_SortDirection(list[0].get_SortDirection());
					sortDescriptors.Add(val2);
				}
			}
			return val;
		}
		return null;
	}

	private static MethodInfo GetGenericMethod(string methodName, params Type[] modelType)
	{
		return typeof(GridBuilderExtensions).GetMethod(methodName, BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(modelType);
	}

	private static string InvokeExpression<TModel, TValue>(Expression expression, TModel VARIABLE)
	{
		return ((Expression<Func<TModel, TValue>>)expression).Compile()(VARIABLE).ToString();
	}

	[UsedImplicitly]
	private static void BoundColumn<TModel, TValue>(HtmlHelper htmlHelper, DynamicGrid model, GridColumn column, GridColumnFactory<TModel> columns, ClassMetadata metadata, bool checkCellPermissions) where TModel : class
	{
		string expressionString = ((!string.IsNullOrEmpty(column.Name)) ? column.Name : ((!string.IsNullOrEmpty(column.SortExpression)) ? column.SortExpression.Replace(',', '$') : ("column_" + columns.get_Container().get_Columns().Count)));
		Func<object, string> valueAccessor = column.ValueAccessor;
		TelerikGridBoundColumn<TModel, TValue> telerikGridBoundColumn = new TelerikGridBoundColumn<TModel, TValue>(columns.get_Container(), (Expression<Func<TModel, TValue>>)column.Expression, expressionString, column.SortExpression, valueAccessor, metadata);
		if (column.Template != null)
		{
			((GridColumnBase<TModel>)(object)telerikGridBoundColumn).set_InlineTemplate((Func<TModel, object>)column.Template);
		}
		if (column.CellVisible != null)
		{
			((GridColumnBase<TModel>)(object)telerikGridBoundColumn).set_CellVisible((Func<TModel, bool>)column.CellVisible);
		}
		if (column.HtmlAttributes != null && column.HtmlAttributes.Any())
		{
			((GridColumnBase<TModel>)(object)telerikGridBoundColumn).get_HtmlAttributes().AddSequense(column.HtmlAttributes);
		}
		if (!string.IsNullOrEmpty(column.Width))
		{
			((GridColumnBase<TModel>)(object)telerikGridBoundColumn).set_Width(column.Width);
		}
		if (column.CellAlignment != 0)
		{
			string text = null;
			switch (column.CellAlignment)
			{
			case LineAlignment.Right:
				text = "right";
				break;
			case LineAlignment.Center:
				text = "center";
				break;
			}
			if (text != null)
			{
				((GridColumnBase<TModel>)(object)telerikGridBoundColumn).get_HtmlAttributes()["style"] = (((GridColumnBase<TModel>)(object)telerikGridBoundColumn).get_HtmlAttributes().ContainsKey("style") ? string.Concat(((GridColumnBase<TModel>)(object)telerikGridBoundColumn).get_HtmlAttributes()["style"], ";") : "") + "text-align:" + text;
			}
		}
		((GridColumnBase<TModel>)(object)telerikGridBoundColumn).set_Visible(column.Visible);
		((GridColumnBase<TModel>)(object)telerikGridBoundColumn).set_Hidden(column.Hidden);
		((GridColumnBase<TModel>)(object)telerikGridBoundColumn).set_Title((string)column.Header);
		((GridBoundColumn<TModel, TValue>)telerikGridBoundColumn).set_Sortable(column.Sortable);
		((GridBoundColumn<TModel, TValue>)telerikGridBoundColumn).set_SortExpression(column.SortExpression);
		((GridBoundColumn<TModel, TValue>)telerikGridBoundColumn).set_Resizable(column.Resizable);
		((GridBoundColumn<TModel, TValue>)telerikGridBoundColumn).set_Groupable(column.Groupable);
		((GridColumnBase<TModel>)(object)telerikGridBoundColumn).set_UniqueName(column.UniqueName);
		if (column.GroupHeaderTemplate != null)
		{
			((GridBoundColumn<TModel, TValue>)telerikGridBoundColumn).get_GroupHeaderTemplate().set_InlineTemplate((Func<GridGroupAggregateResult, object>)((GridGroupAggregateResult d) => column.GroupHeaderTemplate(new GridGroupResult(d.get_Title(), d.get_Key()))));
		}
		if (column.GroupFooterTemplate != null)
		{
			((GridBoundColumn<TModel, TValue>)telerikGridBoundColumn).get_GroupFooterTemplate().set_InlineTemplate((Func<GridAggregateResult, object>)((GridAggregateResult d) => column.GroupFooterTemplate(d)));
		}
		((GridBoundColumn<TModel, TValue>)telerikGridBoundColumn).set_ReadOnly(column.ReadOnly);
		telerikGridBoundColumn.CheckCellPermissions = checkCellPermissions;
		((GridColumnBase<TModel>)(object)telerikGridBoundColumn).set_EditableInTable(column.EditableInTable);
		Guid columnUid = Guid.Empty;
		if (!string.IsNullOrEmpty(column.UniqueName))
		{
			Guid.TryParse(column.UniqueName, out columnUid);
		}
		if (columnUid != Guid.Empty && model != null && model.GridData != null && model.GridData.EditingItemView != null)
		{
			PropertyViewItem propertyViewItem = model.GridData.EditingItemView.FindItem((PropertyViewItem p) => p.PropertyUid == columnUid);
			if (propertyViewItem != null)
			{
				telerikGridBoundColumn.ViewAttributes = propertyViewItem.Attributes;
			}
		}
		columns.get_Container().get_Columns().Add((GridColumnBase<TModel>)(object)telerikGridBoundColumn);
	}

	[UsedImplicitly]
	private static void BoundTableColumn<TValue>(HtmlHelper htmlHelper, TableGrid model, GridColumn column, GridColumnFactory<DataRowView> columns)
	{
		string text = ((!string.IsNullOrEmpty(column.Name)) ? column.Name : ("column_" + columns.get_Container().get_Columns().Count));
		if (text.EndsWith("_$view") || text.EndsWith("_$export"))
		{
			return;
		}
		string fieldName = text;
		bool encoded = true;
		if (model.Table.Columns.Contains(text + "_$view"))
		{
			fieldName += "_$view";
			encoded = false;
		}
		else if (model.Table.Columns.Contains(text + "_$export"))
		{
			fieldName += "_$export";
			encoded = false;
		}
		TelerikGridBoundColumn<DataRowView, TValue> telerikGridBoundColumn = new TelerikGridBoundColumn<DataRowView, TValue>(columns.get_Container(), (DataRowView x) => x.Row.Field<TValue>(fieldName), text, text, null, null);
		((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).set_Encoded(encoded);
		if (column.Template != null)
		{
			((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).set_InlineTemplate((Func<DataRowView, object>)column.Template);
		}
		if (column.CellVisible != null)
		{
			((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).set_CellVisible((Func<DataRowView, bool>)column.CellVisible);
		}
		if (column.HtmlAttributes != null && column.HtmlAttributes.Any())
		{
			((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).get_HtmlAttributes().AddSequense(column.HtmlAttributes);
		}
		if (!string.IsNullOrEmpty(column.Width))
		{
			((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).set_Width(column.Width);
		}
		if (column.CellAlignment != 0)
		{
			string text2 = null;
			switch (column.CellAlignment)
			{
			case LineAlignment.Right:
				text2 = "right";
				break;
			case LineAlignment.Center:
				text2 = "center";
				break;
			}
			if (text2 != null)
			{
				((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).get_HtmlAttributes()["style"] = (((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).get_HtmlAttributes().ContainsKey("style") ? string.Concat(((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).get_HtmlAttributes()["style"], ";") : "") + "text-align:" + text2;
			}
		}
		((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).set_Visible(column.Visible);
		((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).set_Hidden(column.Hidden);
		((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).set_Title((string)column.Header);
		((GridBoundColumn<DataRowView, TValue>)telerikGridBoundColumn).set_Sortable(column.Sortable && !int.TryParse(text, out var _));
		((GridBoundColumn<DataRowView, TValue>)telerikGridBoundColumn).set_SortExpression(column.SortExpression);
		((GridBoundColumn<DataRowView, TValue>)telerikGridBoundColumn).set_Resizable(column.Resizable);
		((GridBoundColumn<DataRowView, TValue>)telerikGridBoundColumn).set_Groupable(column.Groupable);
		((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn).set_UniqueName(column.UniqueName);
		if (column.GroupHeaderTemplate != null)
		{
			((GridBoundColumn<DataRowView, TValue>)telerikGridBoundColumn).get_GroupHeaderTemplate().set_InlineTemplate((Func<GridGroupAggregateResult, object>)((GridGroupAggregateResult d) => column.GroupHeaderTemplate(new GridGroupResult(d.get_Title(), d.get_Key()))));
		}
		if (column.GroupFooterTemplate != null)
		{
			((GridBoundColumn<DataRowView, TValue>)telerikGridBoundColumn).get_GroupFooterTemplate().set_InlineTemplate((Func<GridAggregateResult, object>)((GridAggregateResult d) => column.GroupFooterTemplate(d)));
		}
		columns.get_Container().get_Columns().Add((GridColumnBase<DataRowView>)(object)telerikGridBoundColumn);
	}

	private static GridDataRowResult CreateGridDataItemInputs<T>(HtmlHelper html, object row, object dataKeyValue, bool isRowEditing, Grid<T> grid, IGridCellBuilderFactory cellBuilderFactory, GridHtmlHelper<T> gridHtmlHelper, DynamicGrid model) where T : class
	{
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		GridDataRowResult result = new GridDataRowResult();
		if (isRowEditing)
		{
			result.ResultEditSet = new Dictionary<string, object>();
			result.ResultEditHidden = new Dictionary<string, bool>();
		}
		if (row is T || row == null)
		{
			Action<string> action = delegate(string rowClass)
			{
				if (!string.IsNullOrEmpty(result.RowClass))
				{
					result.RowClass += " ";
				}
				result.RowClass += rowClass;
			};
			if ((object)model.RowClassDelegate != null)
			{
				if (model.RowClassDelegate is Func<T, Grid<T>, string>)
				{
					action(GetDelegateValue<T, Grid<T>, string>(model.RowClassDelegate, grid, (T)row));
				}
			}
			else if (model.RowClassFunc != null && model.RowClassFunc is Expression<Func<T, string>>)
			{
				action(GetExpressionValue<T, string>(model.RowClassFunc, (T)row));
			}
			if (model.RowPresetClassDelegate != null)
			{
				foreach (Func<T, Grid<T>, string> item in model.RowPresetClassDelegate.Cast<Func<T, Grid<T>, string>>())
				{
					action(GetDelegateValue<T, Grid<T>, string>(item, grid, (T)row));
				}
			}
			else if (model.RowPresetClassFunc != null)
			{
				foreach (Expression<Func<T, string>> item2 in model.RowPresetClassFunc.Cast<Expression<Func<T, string>>>())
				{
					action(GetExpressionValue<T, string>(item2, (T)row));
				}
			}
			Action<HtmlStyle> action2 = delegate(HtmlStyle style)
			{
				if (style != null)
				{
					result.RowStyle = style.ToString();
				}
			};
			if ((object)model.RowStyleDelegate != null)
			{
				if (model.RowStyleDelegate is Func<T, Grid<T>, HtmlStyle>)
				{
					action2(GetDelegateValue<T, Grid<T>, HtmlStyle>(model.RowStyleDelegate, grid, (T)row));
				}
			}
			else if (model.RowStyleFunc != null && model.RowStyleFunc is Expression<Func<T, HtmlStyle>>)
			{
				action2(GetExpressionValue<T, HtmlStyle>(model.RowStyleFunc, (T)row));
			}
			Func<object, Dictionary<string, string>> func = delegate(object attrs)
			{
				if (attrs == null)
				{
					return null;
				}
				RouteValueDictionary enumeration = new RouteValueDictionary(attrs);
				Dictionary<string, string> attrDict = new Dictionary<string, string>();
				enumeration.ForEach(delegate(KeyValuePair<string, object> p)
				{
					attrDict.Add(p.Key, (p.Value != null) ? HttpUtility.HtmlEncode(p.Value.ToString()) : "");
				});
				return attrDict;
			};
			if ((object)model.RowHtmlAttributesDelegate != null)
			{
				if (model.RowHtmlAttributesDelegate is Func<T, Grid<T>, object>)
				{
					Dictionary<string, string> dictionary = func(GetDelegateValue<T, Grid<T>, object>(model.RowHtmlAttributesDelegate, grid, (T)row));
					if (dictionary != null)
					{
						result.RowHtmlAttributes = dictionary;
					}
					if (model.RowPresetHtmlAttributesDelegate != null)
					{
						foreach (Delegate item3 in model.RowPresetHtmlAttributesDelegate)
						{
							Dictionary<string, string> dictionary2 = func(GetDelegateValue<T, Grid<T>, object>(item3, grid, (T)row));
							if (dictionary2 != null)
							{
								if (result.RowHtmlAttributes != null)
								{
									DictionaryExtensions.Merge<string>((IDictionary<string, string>)result.RowHtmlAttributes, (IDictionary<string, string>)dictionary2);
								}
								else
								{
									result.RowHtmlAttributes = dictionary2;
								}
							}
						}
					}
				}
			}
			else if (model.RowHtmlAttributesFunc != null && model.RowHtmlAttributesFunc is Expression<Func<T, object>>)
			{
				Dictionary<string, string> dictionary3 = func(GetExpressionValue<T, object>(model.RowHtmlAttributesFunc, (T)row));
				if (dictionary3 != null)
				{
					result.RowHtmlAttributes = dictionary3;
				}
				if (model.RowPresetHtmlAttributesFunc != null)
				{
					foreach (Expression item4 in model.RowPresetHtmlAttributesFunc)
					{
						Dictionary<string, string> dictionary4 = func(GetExpressionValue<T, object>(item4, (T)row));
						if (dictionary4 != null)
						{
							if (result.RowHtmlAttributes != null)
							{
								DictionaryExtensions.Merge<string>((IDictionary<string, string>)result.RowHtmlAttributes, (IDictionary<string, string>)dictionary4);
							}
							else
							{
								result.RowHtmlAttributes = dictionary4;
							}
						}
					}
				}
			}
		}
		bool clientValidationEnabled = html.get_ViewContext().get_ClientValidationEnabled();
		FormContext formContext = html.get_ViewContext().get_FormContext();
		if (isRowEditing)
		{
			html.get_ViewContext().set_ClientValidationEnabled(true);
			ViewContext viewContext = html.get_ViewContext();
			FormContext val = new FormContext();
			val.set_FormId(((ViewComponentBase)grid).get_Name() + "form");
			viewContext.set_FormContext(val);
		}
		try
		{
			foreach (GridColumnBase<T> column in grid.get_VisibleColumns())
			{
				if (string.IsNullOrEmpty(column.get_Member()))
				{
					continue;
				}
				object obj = null;
				object obj2 = null;
				IsRowInEditMode = false;
				IGridDataCellBuilder val2 = cellBuilderFactory.CreateDisplayCellBuilder((IGridColumn)(object)column, (IGridHtmlHelper)(object)gridHtmlHelper);
				obj = ((object)((val2 != null) ? val2.CreateCellContent(row) : null))?.ToString();
				string columnUniqueName = (string)((object)column).GetType().GetProperty("UniqueName").GetValue(column, null);
				Guid columnUid = Guid.Empty;
				if (!string.IsNullOrEmpty(columnUniqueName))
				{
					Guid.TryParse(columnUniqueName, out columnUid);
				}
				if (isRowEditing)
				{
					IsRowInEditMode = true;
					bool flag = false;
					IGridDataCellBuilder val3 = cellBuilderFactory.CreateEditCellBuilder((IGridColumn)(object)column, (IGridHtmlHelper)(object)gridHtmlHelper);
					if (val3 is ITelerikGridEditorForCellBuilder telerikGridEditorForCellBuilder && columnUid != Guid.Empty && model.GridData != null && model.GridData.EditingItemView != null)
					{
						PropertyViewItem propertyViewItem = model.GridData.EditingItemView.FindItem((PropertyViewItem p) => p.PropertyUid == columnUid);
						if (propertyViewItem != null)
						{
							telerikGridEditorForCellBuilder.ViewAttributes = propertyViewItem.Attributes;
							flag = propertyViewItem.IsReadOnly();
							if (!propertyViewItem.IsVisible())
							{
								result.ResultEditHidden[column.get_Member()] = true;
							}
						}
					}
					IHtmlNode val4 = ((val3 != null) ? val3.CreateCellContent(row) : null);
					obj2 = ((val4 == null) ? null : (flag ? obj : ((object)val4).ToString()));
				}
				int num = 1;
				if (column.get_CellVisible() != null && !column.get_CellVisible()((T)row))
				{
					num = 0;
				}
				else
				{
					for (int i = grid.get_Columns().IndexOf(column) + 1; i < grid.get_Columns().Count; i++)
					{
						GridColumnBase<T> val5 = grid.get_Columns()[i];
						if (val5.get_CellVisible() == null || val5.get_CellVisible()((T)row))
						{
							break;
						}
						num++;
					}
				}
				if (num != 1)
				{
					result.ColspanSet[column.get_Member()] = num;
				}
				result.ResultSet[column.get_Member()] = ((obj != null) ? obj.ToString() : string.Empty);
				if (isRowEditing && obj2 != null)
				{
					result.ResultEditSet[column.get_Member()] = ((obj2 != null) ? obj2.ToString().Replace("%", "%25").Replace("<", "%3c")
						.Replace(">", "%3e") : string.Empty);
				}
				GridColumn gridColumn = model.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == columnUniqueName);
				if (gridColumn == null)
				{
					continue;
				}
				Action<object> action3 = delegate(object attributes)
				{
					if (attributes != null)
					{
						if (result.CellAttributesSet == null)
						{
							result.CellAttributesSet = new Dictionary<string, IDictionary<string, string>>();
						}
						Dictionary<string, string> dictionary5 = new Dictionary<string, string>();
						foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(attributes))
						{
							object value = property.GetValue(attributes);
							if (value != null)
							{
								dictionary5.Add(property.Name, html.Encode(value.ToString()));
							}
						}
						result.CellAttributesSet[column.get_Member()] = dictionary5;
					}
				};
				if ((object)gridColumn.CellHtmlAttributesDelegate != null)
				{
					if (gridColumn.CellHtmlAttributesDelegate is Func<T, GridColumn, object>)
					{
						action3(GetDelegateValue<T, GridColumn, object>(gridColumn.CellHtmlAttributesDelegate, gridColumn, (T)row));
					}
				}
				else if (gridColumn != null && gridColumn.CellHtmlAttributesFunc != null && gridColumn.CellHtmlAttributesFunc is Expression<Func<T, object>>)
				{
					action3(GetExpressionValue<T, object>(gridColumn.CellHtmlAttributesFunc, (T)row));
				}
			}
			if (isRowEditing)
			{
				result.ValidationMetadata = new Dictionary<string, object>();
				result.ValidationMetadata["Fields"] = grid.ProcessValidationMetadata();
				result.ValidationMetadata["FormId"] = html.get_ViewContext().get_FormContext().get_FormId();
			}
		}
		finally
		{
			if (isRowEditing)
			{
				html.get_ViewContext().set_FormContext(formContext);
				html.get_ViewContext().set_ClientValidationEnabled(clientValidationEnabled);
			}
		}
		if (dataKeyValue != null && !result.ResultSet.ContainsKey(model.DataKeyPropertyName))
		{
			result.ResultSet[model.DataKeyPropertyName] = dataKeyValue;
		}
		return result;
	}

	private static GridDataRowResult CreateGridDataItemInputs(HtmlHelper html, DataRowView row, Grid<DataRowView> grid, IGridCellBuilderFactory cellBuilderFactory, GridHtmlHelper<DataRowView> gridHtmlHelper, TableGrid model)
	{
		GridDataRowResult gridDataRowResult = new GridDataRowResult();
		if (model.RowClassFunc != null && model.RowClassFunc is Expression<Func<DataRowView, string>>)
		{
			Expression<Func<DataRowView, string>> expression = (Expression<Func<DataRowView, string>>)model.RowClassFunc;
			gridDataRowResult.RowClass = expression.Compile()(row);
		}
		if (model.RowPresetClassFunc != null)
		{
			foreach (Expression<Func<DataRowView, string>> item in model.RowPresetClassFunc.Cast<Expression<Func<DataRowView, string>>>())
			{
				if (!string.IsNullOrEmpty(gridDataRowResult.RowClass))
				{
					gridDataRowResult.RowClass += " ";
				}
				gridDataRowResult.RowClass += item.Compile()(row);
			}
		}
		if (model.RowStyleFunc != null && model.RowStyleFunc is Expression<Func<DataRowView, HtmlStyle>>)
		{
			HtmlStyle htmlStyle = ((Expression<Func<DataRowView, HtmlStyle>>)model.RowStyleFunc).Compile()(row);
			if (htmlStyle != null)
			{
				gridDataRowResult.RowStyle = htmlStyle.ToString();
			}
		}
		Func<Expression, Dictionary<string, string>> func = delegate(Expression expr)
		{
			if (!(expr is Expression<Func<DataRowView, object>> expression2))
			{
				return null;
			}
			object obj3 = expression2.Compile()(row);
			if (obj3 == null)
			{
				return null;
			}
			RouteValueDictionary enumeration = new RouteValueDictionary(obj3);
			Dictionary<string, string> attrDict = new Dictionary<string, string>();
			enumeration.ForEach(delegate(KeyValuePair<string, object> p)
			{
				attrDict.Add(p.Key, (p.Value != null) ? p.Value.ToString() : "");
			});
			return attrDict;
		};
		Dictionary<string, string> dictionary = func(model.RowHtmlAttributesFunc);
		if (dictionary != null)
		{
			gridDataRowResult.RowHtmlAttributes = dictionary;
		}
		if (model.RowPresetHtmlAttributesFunc != null)
		{
			foreach (Expression item2 in model.RowPresetHtmlAttributesFunc)
			{
				Dictionary<string, string> dictionary2 = func(item2);
				if (dictionary2 != null)
				{
					if (gridDataRowResult.RowHtmlAttributes != null)
					{
						DictionaryExtensions.Merge<string>((IDictionary<string, string>)gridDataRowResult.RowHtmlAttributes, (IDictionary<string, string>)dictionary2);
					}
					else
					{
						gridDataRowResult.RowHtmlAttributes = dictionary2;
					}
				}
			}
		}
		try
		{
			foreach (GridColumnBase<DataRowView> visibleColumn in grid.get_VisibleColumns())
			{
				if (string.IsNullOrEmpty(visibleColumn.get_Member()))
				{
					continue;
				}
				object obj = null;
				IGridDataCellBuilder val = cellBuilderFactory.CreateDisplayCellBuilder((IGridColumn)(object)visibleColumn, (IGridHtmlHelper)(object)gridHtmlHelper);
				obj = ((object)((val != null) ? val.CreateCellContent((object)row) : null))?.ToString();
				string columnUniqueName = (string)((object)visibleColumn).GetType().GetProperty("UniqueName").GetValue(visibleColumn, null);
				Guid result = Guid.Empty;
				if (!string.IsNullOrEmpty(columnUniqueName))
				{
					Guid.TryParse(columnUniqueName, out result);
				}
				int num = 1;
				if (visibleColumn.get_CellVisible() != null && !visibleColumn.get_CellVisible()(row))
				{
					num = 0;
				}
				else
				{
					for (int i = grid.get_Columns().IndexOf(visibleColumn) + 1; i < grid.get_Columns().Count; i++)
					{
						GridColumnBase<DataRowView> val2 = grid.get_Columns()[i];
						if (val2.get_CellVisible() == null || val2.get_CellVisible()(row))
						{
							break;
						}
						num++;
					}
				}
				if (num != 1)
				{
					gridDataRowResult.ColspanSet[visibleColumn.get_Member()] = num;
				}
				gridDataRowResult.ResultSet[visibleColumn.get_Member()] = ((obj != null) ? obj.ToString() : string.Empty);
				GridColumn gridColumn = model.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == columnUniqueName);
				if (gridColumn == null || gridColumn.CellHtmlAttributesFunc == null || !(gridColumn.CellHtmlAttributesFunc is Expression<Func<DataRowView, object>>))
				{
					continue;
				}
				object obj2 = ((Expression<Func<DataRowView, object>>)gridColumn.CellHtmlAttributesFunc).Compile()(row);
				if (obj2 == null)
				{
					continue;
				}
				if (gridDataRowResult.CellAttributesSet == null)
				{
					gridDataRowResult.CellAttributesSet = new Dictionary<string, IDictionary<string, string>>();
				}
				Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
				foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(obj2))
				{
					object value = property.GetValue(obj2);
					if (value != null)
					{
						dictionary3.Add(property.Name, html.Encode(value.ToString()));
					}
				}
				gridDataRowResult.CellAttributesSet[visibleColumn.get_Member()] = dictionary3;
			}
			return gridDataRowResult;
		}
		catch (Exception)
		{
			return gridDataRowResult;
		}
	}

	private static IEnumerable CreateGridInputs<T>(HtmlHelper html, Grid<T> grid, IGridCellBuilderFactory cellBuilderFactory, GridHtmlHelper<T> gridHtmlHelper, IEnumerable dataSource, DynamicGrid model, PropertyInfo dataKeyProperty, Dictionary<int, Dictionary<string, int>> colspanResult, Dictionary<int, string> classRowResult, Dictionary<int, string> styleRowResult, Dictionary<int, IDictionary<string, string>> rowHtmlAttributesResult, Dictionary<int, Dictionary<string, IDictionary<string, string>>> cellAttributesResult, ref int rowIndex, ref Dictionary<string, object> resultEditData, ref Dictionary<string, bool> resultEditDataHidden, out Dictionary<string, object> firstDataRow, out Dictionary<string, object> validationMetadata, out Dictionary<int, string> beforeRowContent) where T : class
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		firstDataRow = null;
		validationMetadata = null;
		beforeRowContent = new Dictionary<int, string>();
		if (dataSource == null || !dataSource.Cast<object>().Any())
		{
			return dataSource;
		}
		if (dataSource.Cast<object>().First() is IGroup)
		{
			foreach (Group item in dataSource)
			{
				Group val = item;
				val.set_Key((object)((val.get_Key() != null) ? val.get_Key().ToString() : null));
				val.set_Items(CreateGridInputs<T>(html, grid, cellBuilderFactory, gridHtmlHelper, val.get_Items(), model, dataKeyProperty, colspanResult, classRowResult, styleRowResult, rowHtmlAttributesResult, cellAttributesResult, ref rowIndex, ref resultEditData, ref resultEditDataHidden, out var firstDataRow2, out var validationMetadata2, out var _));
				if (firstDataRow == null)
				{
					firstDataRow = firstDataRow2;
				}
				if (validationMetadata2 != null && validationMetadata2.Count > 0)
				{
					validationMetadata = ((validationMetadata == null) ? validationMetadata2 : validationMetadata.Concat(validationMetadata2).ToDictionary((KeyValuePair<string, object> m) => m.Key, (KeyValuePair<string, object> m) => m.Value));
				}
				if (firstDataRow2 != null && !string.IsNullOrEmpty(val.get_KeyMember()) && firstDataRow2.TryGetValue(val.get_KeyMember(), out var value))
				{
					val.set_Key(value);
				}
			}
			return dataSource;
		}
		List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
		TypeConverter typeConverter = ((model.GridData.EditingRowKeyValue != null && dataKeyProperty != null && dataKeyProperty.CanRead) ? TypeDescriptor.GetConverter(dataKeyProperty.PropertyType) : null);
		object obj = ((typeConverter != null && typeConverter.CanConvertFrom(model.GridData.EditingRowKeyValue.GetType())) ? typeConverter.ConvertFrom(model.GridData.EditingRowKeyValue) : model.GridData.EditingRowKeyValue);
		foreach (object item2 in dataSource)
		{
			object obj2 = null;
			if (dataKeyProperty != null && dataKeyProperty.CanRead && item2 != null)
			{
				obj2 = dataKeyProperty.GetValue(item2, null);
			}
			bool isRowEditing = obj2 != null && obj != null && obj.Equals(obj2);
			GridDataRowResult gridDataRowResult = CreateGridDataItemInputs<T>(html, item2, obj2, isRowEditing, grid, cellBuilderFactory, gridHtmlHelper, model);
			list.Add(gridDataRowResult.ResultSet);
			if (gridDataRowResult.ResultEditSet != null)
			{
				resultEditData = gridDataRowResult.ResultEditSet;
			}
			if (gridDataRowResult.ResultEditHidden != null)
			{
				resultEditDataHidden = gridDataRowResult.ResultEditHidden;
			}
			if (firstDataRow == null)
			{
				firstDataRow = gridDataRowResult.ResultSet;
			}
			if (gridDataRowResult.ColspanSet != null && gridDataRowResult.ColspanSet.Count > 0)
			{
				colspanResult.Add(rowIndex, gridDataRowResult.ColspanSet);
			}
			if (!string.IsNullOrEmpty(gridDataRowResult.RowClass))
			{
				classRowResult.Add(rowIndex, gridDataRowResult.RowClass);
			}
			if (!string.IsNullOrEmpty(gridDataRowResult.RowStyle))
			{
				styleRowResult.Add(rowIndex, gridDataRowResult.RowStyle);
			}
			if (gridDataRowResult.RowHtmlAttributes != null)
			{
				rowHtmlAttributesResult.Add(rowIndex, gridDataRowResult.RowHtmlAttributes);
			}
			if (gridDataRowResult.CellAttributesSet != null)
			{
				cellAttributesResult.Add(rowIndex, gridDataRowResult.CellAttributesSet);
			}
			if (gridDataRowResult.ValidationMetadata != null)
			{
				validationMetadata = gridDataRowResult.ValidationMetadata;
			}
			if (model.BeforeRowContent is Expression<Func<T, IEnumerable<string>>>)
			{
				List<string> values = (from c in (model.BeforeRowContent as Expression<Func<T, IEnumerable<string>>>).Compile()(item2 as T)
					select string.Format($"<div class=\"before-row-content-item\">{c}</div>")).ToList();
				beforeRowContent.Add(rowIndex, string.Join("", values));
			}
			rowIndex++;
		}
		return list;
	}

	private static IEnumerable CreateTableGridInputs(HtmlHelper html, Grid<DataRowView> grid, IGridCellBuilderFactory cellBuilderFactory, GridHtmlHelper<DataRowView> gridHtmlHelper, IEnumerable dataSource, TableGrid model, Dictionary<int, Dictionary<string, int>> colspanResult, Dictionary<int, string> classRowResult, Dictionary<int, string> styleRowResult, Dictionary<int, IDictionary<string, string>> rowHtmlAttributesResult, Dictionary<int, Dictionary<string, IDictionary<string, string>>> cellAttributesResult, ref int rowIndex, out Dictionary<string, object> firstDataRow)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		firstDataRow = null;
		if (dataSource == null || !dataSource.Cast<object>().Any())
		{
			return dataSource;
		}
		if (dataSource.Cast<object>().First() is IGroup)
		{
			foreach (Group item in dataSource)
			{
				Group val = item;
				val.set_Key((object)((val.get_Key() != null) ? val.get_Key().ToString() : null));
				val.set_Items(CreateTableGridInputs(html, grid, cellBuilderFactory, gridHtmlHelper, val.get_Items(), model, colspanResult, classRowResult, styleRowResult, rowHtmlAttributesResult, cellAttributesResult, ref rowIndex, out var firstDataRow2));
				if (firstDataRow == null)
				{
					firstDataRow = firstDataRow2;
				}
				if (firstDataRow2 != null && !string.IsNullOrEmpty(val.get_KeyMember()) && firstDataRow2.TryGetValue(val.get_KeyMember(), out var value))
				{
					val.set_Key(value);
				}
			}
			return dataSource;
		}
		List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
		foreach (DataRowView item2 in dataSource)
		{
			GridDataRowResult gridDataRowResult = CreateGridDataItemInputs(html, item2, grid, cellBuilderFactory, gridHtmlHelper, model);
			list.Add(gridDataRowResult.ResultSet);
			if (firstDataRow == null)
			{
				firstDataRow = gridDataRowResult.ResultSet;
			}
			if (gridDataRowResult.ColspanSet != null && gridDataRowResult.ColspanSet.Count > 0)
			{
				colspanResult.Add(rowIndex, gridDataRowResult.ColspanSet);
			}
			if (!string.IsNullOrEmpty(gridDataRowResult.RowClass))
			{
				classRowResult.Add(rowIndex, gridDataRowResult.RowClass);
			}
			if (!string.IsNullOrEmpty(gridDataRowResult.RowStyle))
			{
				styleRowResult.Add(rowIndex, gridDataRowResult.RowStyle);
			}
			if (gridDataRowResult.RowHtmlAttributes != null)
			{
				rowHtmlAttributesResult.Add(rowIndex, gridDataRowResult.RowHtmlAttributes);
			}
			if (gridDataRowResult.CellAttributesSet != null)
			{
				cellAttributesResult.Add(rowIndex, gridDataRowResult.CellAttributesSet);
			}
			rowIndex++;
		}
		return list;
	}

	[UsedImplicitly]
	private static MvcHtmlString GenericGrid<T>([NotNull] this HtmlHelper html, [NotNull] DynamicGrid model) where T : class
	{
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected O, but got Unknown
		try
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}
			if (model == null)
			{
				throw new ArgumentNullException("model");
			}
			GridBuilder<T> grid = GetGrid<T>(html, model);
			if (((ControllerContext)html.get_ViewContext()).get_HttpContext() != null)
			{
				if (!AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)html.get_ViewContext()).get_HttpContext().Request) && ((ControllerContext)html.get_ViewContext()).get_HttpContext().Items != null && ((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["GridResultDictionary"] != null)
				{
					((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["GridResultDictionary"] = null;
				}
				if (AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)html.get_ViewContext()).get_HttpContext().Request) && ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.HttpMethod == "POST" && !string.IsNullOrWhiteSpace(((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.Params.Get("gridId")) && !((ControllerContext)html.get_ViewContext()).get_HttpContext().EditingFormEnabled())
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					IEnumerable value = new List<Dictionary<string, object>>();
					Dictionary<string, object> resultEditData = null;
					Dictionary<string, bool> resultEditDataHidden = null;
					Dictionary<int, Dictionary<string, int>> dictionary2 = new Dictionary<int, Dictionary<string, int>>();
					Dictionary<int, string> dictionary3 = new Dictionary<int, string>();
					Dictionary<int, string> dictionary4 = new Dictionary<int, string>();
					Dictionary<int, IDictionary<string, string>> dictionary5 = new Dictionary<int, IDictionary<string, string>>();
					Dictionary<int, Dictionary<string, IDictionary<string, string>>> dictionary6 = new Dictionary<int, Dictionary<string, IDictionary<string, string>>>();
					Dictionary<string, object> validationMetadata = null;
					Dictionary<int, string> beforeRowContent = null;
					Grid<T> val = ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid);
					IGridCellBuilderFactory cellBuilderFactory = DI.get_Current().Resolve<IGridCellBuilderFactory>();
					GridHtmlHelper<T> gridHtmlHelper = new GridHtmlHelper<T>(((ViewComponentBase)val).get_ViewContext(), val.get_DataKeyStore());
					if (!model.GridData.DataSourceIsNull)
					{
						int rowIndex = 0;
						PropertyInfo dataKeyProperty = ((!string.IsNullOrEmpty(model.DataKeyPropertyName)) ? typeof(T).GetReflectionProperty(model.DataKeyPropertyName) : null);
						object value2 = ((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["InputContainerId"];
						((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["InputContainerId"] = ((ViewComponentBase)val).get_Id();
						try
						{
							value = CreateGridInputs<T>(html, ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid), cellBuilderFactory, gridHtmlHelper, model.GridData.DataSource, model, dataKeyProperty, dictionary2, dictionary3, dictionary4, dictionary5, dictionary6, ref rowIndex, ref resultEditData, ref resultEditDataHidden, out var _, out validationMetadata, out beforeRowContent);
						}
						finally
						{
							((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["InputContainerId"] = value2;
						}
					}
					if (model.DefaultDataItem != null && model.RenderDefaultDataItemEditors)
					{
						GridDataRowResult gridDataRowResult = CreateGridDataItemInputs<T>(html, model.DefaultDataItem, 0L, isRowEditing: true, ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid), cellBuilderFactory, gridHtmlHelper, model);
						resultEditData = gridDataRowResult.ResultEditSet;
						resultEditDataHidden = gridDataRowResult.ResultEditHidden;
						validationMetadata = gridDataRowResult.ValidationMetadata;
					}
					dictionary["data"] = value;
					dictionary["total"] = model.GridData.Count;
					dictionary["currentPage"] = model.GridData.PageIndex;
					dictionary["emptyDataPage"] = model.EmptyDataPage;
					dictionary["colspans"] = dictionary2;
					dictionary["rowclasses"] = dictionary3;
					dictionary["rowstyles"] = dictionary4;
					dictionary["cellhtmlattributes"] = dictionary6;
					dictionary["hasExitFromGroup"] = model.GridData.HasExitFromGroup;
					dictionary["rowHtmlAttributes"] = dictionary5;
					dictionary["headerSummary"] = ((model.HeaderSummary != null) ? model.HeaderSummary(html).ToString() : "");
					dictionary["headerVisible"] = model.HeaderVisible;
					dictionary["useCardGridTemplate"] = model.UseCardGridTemplate;
					if (!string.IsNullOrEmpty(model.GridData.JsonDataHiddenFieldId))
					{
						dictionary["jsonDataHiddenFieldId"] = model.GridData.JsonDataHiddenFieldId;
					}
					if (!string.IsNullOrEmpty(model.GridData.ParentDataHiddenFieldId))
					{
						dictionary["parentDataHiddenFieldId"] = model.GridData.ParentDataHiddenFieldId;
					}
					if (model.GridData.JsonData != null)
					{
						dictionary["jsondata"] = JsonConvert.SerializeObject(model.GridData.JsonData);
					}
					if (!string.IsNullOrEmpty(model.GridData.ParentDataObjectId))
					{
						dictionary["parentDataObjectId"] = model.GridData.ParentDataObjectId;
					}
					if (!string.IsNullOrEmpty(model.GridData.ParentDataMetadataUid))
					{
						dictionary["parentDataMetadataUid"] = model.GridData.ParentDataMetadataUid;
					}
					if (model.ShowEditorsDescription)
					{
						dictionary["showEditorsDescription"] = "true";
					}
					if (!string.IsNullOrEmpty(html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix()))
					{
						dictionary["prefix"] = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
					}
					if (TablePartController.GetLastTemporaryId() != 0L)
					{
						dictionary["lastTemporaryId"] = TablePartController.GetLastTemporaryId();
					}
					if (resultEditData != null)
					{
						dictionary["editingData"] = resultEditData;
					}
					if (resultEditDataHidden != null)
					{
						dictionary["editingDataHidden"] = resultEditDataHidden;
					}
					if (model.FormContentAccessor != null)
					{
						dictionary["editingFormContent"] = model.FormContentAccessor(html);
					}
					if (beforeRowContent != null)
					{
						dictionary["beforeRowContent"] = beforeRowContent;
					}
					if (model.GridData.EditingItem != null)
					{
						bool value3 = ((ControllerContext)html.get_ViewContext()).get_HttpContext().EditingFormEnabled();
						((ControllerContext)html.get_ViewContext()).get_HttpContext().EditingFormEnabled(true);
						bool clientValidationEnabled = html.get_ViewContext().get_ClientValidationEnabled();
						FormContext formContext = html.get_ViewContext().get_FormContext();
						html.get_ViewContext().set_ClientValidationEnabled(true);
						ViewContext viewContext = html.get_ViewContext();
						FormContext val2 = new FormContext();
						val2.set_FormId(((ViewComponentBase)ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid)).get_Name() + "form");
						viewContext.set_FormContext(val2);
						try
						{
							using (new ObjectViewData(html, html.get_ViewData(), model.GridData.EditingItem, initialize: false)
							{
								ShowDescription = model.ShowEditorsDescription
							})
							{
								string text = ((HtmlString)(object)PartialExtensions.Partial(html, "EditorTemplates/TablePartItem", model.GridData.EditingItem, html.get_ViewData())).ToHtmlString();
								dictionary["editingRowForm"] = text.Replace("%", "%25").Replace("<", "%3c").Replace(">", "%3e");
								validationMetadata = new Dictionary<string, object>();
								validationMetadata["Fields"] = ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid).ProcessValidationMetadata();
								validationMetadata["FormId"] = html.get_ViewContext().get_FormContext().get_FormId();
							}
						}
						finally
						{
							html.get_ViewContext().set_FormContext(formContext);
							html.get_ViewContext().set_ClientValidationEnabled(clientValidationEnabled);
						}
						((ControllerContext)html.get_ViewContext()).get_HttpContext().EditingFormEnabled(value3);
					}
					if (validationMetadata != null)
					{
						dictionary["validationMetadata"] = validationMetadata;
					}
					if (model.ExtendedAjaxProperties != null)
					{
						foreach (KeyValuePair<string, object> extendedAjaxProperty in model.ExtendedAjaxProperties)
						{
							dictionary[extendedAjaxProperty.Key] = extendedAjaxProperty.Value;
						}
					}
					if (((ControllerContext)html.get_ViewContext()).get_HttpContext().Items != null)
					{
						((ControllerContext)html.get_ViewContext()).get_HttpContext().Items["GridResultDictionary"] = dictionary;
					}
					return MvcHtmlString.Empty;
				}
			}
			return new MvcHtmlString(((object)grid).ToString());
		}
		catch (Exception ex)
		{
			Logger.Log.Error(SR.T("Ошибка при формировании таблицы", ex), ex);
			throw;
		}
	}

	private static GridBuilder<T> GetGrid<T>([NotNull] HtmlHelper html, [NotNull] DynamicGrid model) where T : class
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		bool isStateLoaded = false;
		GridState gridState = null;
		Action initModelState = delegate
		{
			if (!isStateLoaded)
			{
				bool flag3 = MetadataLoader.LoadMetadata(model.Type, inherit: false) is ITablePartMetadata;
				gridState = (flag3 ? model.GetState(withSave: false) : model.State);
				isStateLoaded = true;
			}
		};
		if (model.GridData is IGridData<T>)
		{
			((IGridData<T>)model.GridData).AddDataSourceExecuting(delegate(GridData<T> d, FetchOptions f)
			{
				initModelState();
				if (html.get_ViewContext() != null && ((ControllerContext)html.get_ViewContext()).get_HttpContext() != null)
				{
					GridCommand val3 = GetCommandFromRequest(((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.Params, model.UniqueName) ?? (model.GridData as GridData<T>)?.Command;
					if (val3 != null)
					{
						bool flag2 = false;
						if (val3.get_PageSize() > 0 && gridState.PageSize != val3.get_PageSize())
						{
							gridState.PageSize = val3.get_PageSize();
							f.MaxResults = gridState.PageSize;
							flag2 = true;
						}
						if (val3.get_Page() > 0 && gridState.CurrentPage != val3.get_Page())
						{
							gridState.CurrentPage = val3.get_Page();
							f.FirstResult = gridState.PageSize * (gridState.CurrentPage - 1);
							flag2 = true;
						}
						if (val3.get_SortDescriptors().Any())
						{
							SortDescriptor val4 = val3.get_SortDescriptors().FirstOrDefault();
							gridState.SortExpression = val4.get_Member();
							gridState.SortDirection = val4.get_SortDirection();
							f.SortDirection = gridState.SortDirection;
							f.SortExpression = gridState.SortExpression;
							flag2 = true;
						}
						if (flag2 && gridState.Refresh(typeof(T)))
						{
							GridPersonalizationAdministration.SaveState(model.UniqueName, gridState, null, false);
							GridPersonalizationAdministration.SaveState(model.UniqueName, gridState, null, true);
						}
					}
				}
				InitSelectedColumnsFromState(model.GridData.EntityType ?? typeof(T), gridState, f, model.Childs);
			});
		}
		((IGridData<T>)model.GridData).AddDataSourceExecuting(delegate(GridData<T> d, FetchOptions f)
		{
			InitFetchColumns(model.GridData, f);
		});
		IEnumerable<T> enumerable = ((!model.GridData.DataSourceIsNull) ? model.GridData.DataSource.AsGenericEnumerable<T>() : null);
		List<GridColumn> list = (List<GridColumn>)model.Columns;
		if (model.Customizable)
		{
			initModelState();
			IEnumerable<ColumnState> columnStates = gridState.ColumnStates;
			ColumnState[] array = (columnStates ?? EleWise.ELMA.Helpers.EmptyArray<ColumnState>.Instance).ToArray();
			Dictionary<string, GridColumn[]> dictionary = (from c in list
				group c by c.UniqueName).ToDictionary((IGrouping<string, GridColumn> a) => a.Key, (IGrouping<string, GridColumn> b) => b.ToArray());
			ColumnState[] array2 = array;
			string dbName;
			foreach (ColumnState column in array2)
			{
				if (!dictionary.TryGetValue(column.UniqueName, out var value))
				{
					try
					{
						dbName = column.GetDbName(model.Childs);
						if (string.IsNullOrEmpty(dbName))
						{
							continue;
						}
						string name = dbName;
						string sortExpression = dbName;
						if (model.Childs)
						{
							string[] array3 = dbName.Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
							name = CustomPropertyProjection.GetStringFromExpression(array3[2], array3[0]);
							sortExpression = array3[2];
						}
						ClassMetadata metadata = null;
						if (array.Any((ColumnState c) => !c.Equals(column) && c.GetDbName(model.Childs) == dbName))
						{
							sortExpression = ColumnState.GetDbColumnDescription(column.GetDbName(withParent: true));
							metadata = MetadataLoader.LoadMetadata(column.TypeUid) as ClassMetadata;
						}
						DynamicGridColumn dynamicGridColumn = new DynamicGridColumn
						{
							Header = column.DisplayName,
							SortExpression = sortExpression,
							Visible = !column.Hidden,
							UniqueName = column.UniqueName,
							Name = name,
							ValueType = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(column.TypeUid),
							Metadata = metadata,
							Width = ((!string.IsNullOrEmpty(column.WidthAttribute)) ? (column.WidthAttribute + "px") : ""),
							Sortable = column.Sortable
						};
						list.Add(dynamicGridColumn);
						GridColumn[] array4 = new DynamicGridColumn[1] { dynamicGridColumn };
						value = array4;
						dictionary.Add(column.UniqueName, value);
						goto IL_040e;
					}
					catch (Exception exception)
					{
						Logger.Log.Warn(SR.T("Невозможно добавить колонку {0} в таблицу", column.UniqueName), exception);
						goto IL_040e;
					}
				}
				goto IL_040e;
				IL_040e:
				GridColumn gridColumn = value.FirstOrDefault();
				if (gridColumn != null && gridColumn.Order == int.MinValue)
				{
					gridColumn.Order = column.Order;
				}
			}
		}
		Dictionary<Guid, PropertyPermissionType> globalPermissions = new Dictionary<Guid, PropertyPermissionType>();
		IPropertyPermissionService service = Locator.GetService<IPropertyPermissionService>();
		model.Columns = (from c in list
			where c.Visible
			orderby c.Order
			select c).ToList();
		bool checkPermissions = service != null && service.HasPermissions(typeof(T));
		if (checkPermissions)
		{
			foreach (GridColumn column2 in model.Columns)
			{
				if (Guid.TryParse(column2.UniqueName, out var result))
				{
					bool flag = service.HasPermissionsByRole(typeof(T), result);
					PropertyPermissionType propertyPermissionType = service.CheckPropertyPermissionByGlobalOnly(typeof(T), result);
					globalPermissions[result] = propertyPermissionType;
					if (propertyPermissionType == PropertyPermissionType.Hide && !flag)
					{
						column2.Visible = false;
					}
					else if (propertyPermissionType == PropertyPermissionType.Read)
					{
						column2.ReadOnly = true;
					}
				}
			}
		}
		GridBuilder<T> grid = ((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)((enumerable != null) ? HtmlHelperExtension.Telerik(html).Grid<T>(enumerable) : HtmlHelperExtension.Telerik(html).Grid<T>())).Name(model.UniqueName);
		((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid).AddHtmlAttribute("provider", (object)model.StateProviderUid);
		if (gridState != null && gridState.ExpandedWidth > 0)
		{
			((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid).AddHtmlAttribute("expandedWidth", (object)gridState.ExpandedWidth);
		}
		grid.InitEmptyDataPage(model.EmptyDataPage);
		if (model.RowStyleFunc is Expression<Func<T, HtmlStyle>>)
		{
			grid.RowAction((Action<GridRow<T>>)delegate(GridRow<T> row)
			{
				HtmlStyle htmlStyle = ((Expression<Func<T, HtmlStyle>>)model.RowStyleFunc).Compile()(row.get_DataItem());
				if (htmlStyle != null)
				{
					row.get_HtmlAttributes()["style"] = htmlStyle.ToString();
				}
			});
		}
		bool isRowClassExt = model.RowClassDelegate is Func<T, Grid<T>, string>;
		bool isRowHtmlAttributeExt = model.RowHtmlAttributesDelegate is Func<T, Grid<T>, object>;
		bool isRowPresetClassExt = model.RowPresetClassDelegate != null && model.RowPresetClassDelegate.Any();
		bool isRowPresetHtmlAttributesExt = model.RowPresetHtmlAttributesDelegate != null && model.RowPresetHtmlAttributesDelegate.Any();
		bool isRowClass = model.RowClassFunc is Expression<Func<T, string>>;
		bool isRowPresetClass = model.RowPresetClassFunc != null && model.RowPresetClassFunc.Any();
		bool isRowHtmlAttribute = model.RowHtmlAttributesFunc is Expression<Func<T, object>>;
		bool isRowPresetHtmlAttributes = model.RowPresetHtmlAttributesFunc != null && model.RowPresetHtmlAttributesFunc.Any();
		if (isRowClass || isRowPresetClass || isRowHtmlAttribute || isRowPresetHtmlAttributes || isRowClassExt || isRowHtmlAttributeExt || isRowPresetClassExt || isRowPresetHtmlAttributesExt)
		{
			Action<GridRow<T>, string> setRowClass = delegate(GridRow<T> row, string @class)
			{
				if (!string.IsNullOrEmpty(@class))
				{
					if (!row.get_HtmlAttributes().ContainsKey("class") || row.get_HtmlAttributes()["class"] == null)
					{
						row.get_HtmlAttributes()["class"] = "";
					}
					IDictionary<string, object> htmlAttributes;
					if (!string.IsNullOrEmpty(row.get_HtmlAttributes()["class"].ToString()))
					{
						htmlAttributes = row.get_HtmlAttributes();
						htmlAttributes["class"] = string.Concat(htmlAttributes["class"], " ");
					}
					htmlAttributes = row.get_HtmlAttributes();
					htmlAttributes["class"] = string.Concat(htmlAttributes["class"], @class);
				}
			};
			Action<GridRow<T>, object> setRowHtmlAttributes = delegate(GridRow<T> row, object attrs)
			{
				if (attrs != null)
				{
					new RouteValueDictionary(attrs).ForEach(delegate(KeyValuePair<string, object> d)
					{
						row.get_HtmlAttributes()[d.Key] = d.Value;
					});
				}
			};
			grid.RowAction((Action<GridRow<T>>)delegate(GridRow<T> row)
			{
				if (isRowClassExt)
				{
					setRowClass(row, GetDelegateValue<T, Grid<T>, string>(model.RowClassDelegate, ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid), row.get_DataItem()));
				}
				else if (isRowClass)
				{
					setRowClass(row, GetExpressionValue<T, string>(model.RowClassFunc, row.get_DataItem()));
				}
				if (isRowPresetClassExt)
				{
					foreach (Func<T, Grid<T>, string> item in model.RowPresetClassDelegate.Cast<Func<T, Grid<T>, string>>())
					{
						setRowClass(row, GetDelegateValue<T, Grid<T>, string>(item, ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid), row.get_DataItem()));
					}
				}
				else if (isRowPresetClass)
				{
					foreach (Expression<Func<T, string>> item2 in model.RowPresetClassFunc.Cast<Expression<Func<T, string>>>())
					{
						_ = item2;
						setRowClass(row, GetExpressionValue<T, string>(model.RowClassFunc, row.get_DataItem()));
					}
				}
				if (isRowHtmlAttributeExt)
				{
					setRowHtmlAttributes(row, GetDelegateValue<T, Grid<T>, object>(model.RowHtmlAttributesDelegate, ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid), row.get_DataItem()));
				}
				else if (isRowHtmlAttribute)
				{
					setRowHtmlAttributes(row, GetExpressionValue<T, object>(model.RowHtmlAttributesFunc, row.get_DataItem()));
				}
				if (isRowPresetHtmlAttributesExt)
				{
					foreach (Delegate item3 in model.RowPresetHtmlAttributesDelegate)
					{
						setRowHtmlAttributes(row, GetDelegateValue<T, Grid<T>, object>(item3, ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>.op_Implicit((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid), row.get_DataItem()));
					}
					return;
				}
				if (isRowPresetHtmlAttributes)
				{
					foreach (Expression item4 in model.RowPresetHtmlAttributesFunc)
					{
						setRowHtmlAttributes(row, GetExpressionValue<T, object>(item4, row.get_DataItem()));
					}
				}
			});
		}
		if (model.CanEdit || model.CanInsert)
		{
			grid.Editable((Action<GridEditingSettingsBuilder<T>>)delegate(GridEditingSettingsBuilder<T> e)
			{
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				e.DefaultDataItem((model.DefaultDataItem != null && typeof(T).IsAssignableFrom(model.DefaultDataItem.GetType())) ? ((T)model.DefaultDataItem) : InterfaceActivator.Create<T>());
				e.BeginEdit((GridBeginEditEvent)1);
				e.AddRowMode(ConvertRowEditMode(model.AddRowMode));
				e.EditRowMode(ConvertRowEditMode(model.EditRowMode));
				if (!string.IsNullOrEmpty(model.ItemEditorTemplateName))
				{
					e.TemplateName(model.ItemEditorTemplateName);
				}
				if (model.FormContentAccessor != null)
				{
					e.FormContent(model.FormContentAccessor(html));
				}
			});
		}
		Action<GridCell<T>, object> setHtmlAttributes = delegate(GridCell<T> cell, object attributes)
		{
			if (attributes != null)
			{
				DictionaryExtensions.Merge(cell.get_HtmlAttributes(), (IDictionary<string, object>)new RouteValueDictionary(attributes));
			}
		};
		grid.CellAction((Action<GridCell<T>>)delegate(GridCell<T> cell)
		{
			if (cell.get_Column() is ITelerikGridBoundColumn telerikGridBoundColumn)
			{
				string uniqueName = telerikGridBoundColumn.UniqueName;
				GridColumn gridColumn2 = model.Columns.FirstOrDefault((GridColumn c) => c.UniqueName.Equals(uniqueName, StringComparison.OrdinalIgnoreCase));
				if (gridColumn2 != null)
				{
					if (service != null && checkPermissions && Guid.TryParse(uniqueName, out var result2))
					{
						PropertyPermissionType propertyPermissionType2 = service.CheckPropertyPermissionByRoleOnly(cell.get_DataItem(), result2);
						if (propertyPermissionType2 == PropertyPermissionType.None && globalPermissions.ContainsKey(result2))
						{
							propertyPermissionType2 = globalPermissions[result2];
						}
						if (propertyPermissionType2 == PropertyPermissionType.Hide)
						{
							cell.get_Template().set_Html("<div></div>");
							return;
						}
					}
					if (gridColumn2.CellHtmlAttributesDelegate is Func<T, GridColumn, object>)
					{
						setHtmlAttributes(cell, GetDelegateValue<T, GridColumn, object>(gridColumn2.CellHtmlAttributesDelegate, gridColumn2, cell.get_DataItem()));
					}
					else if (gridColumn2.CellHtmlAttributesFunc is Expression<Func<T, object>>)
					{
						setHtmlAttributes(cell, GetExpressionValue<T, object>(gridColumn2.CellHtmlAttributesFunc, cell.get_DataItem()));
					}
				}
			}
		});
		grid.Columns((Action<GridColumnFactory<T>>)delegate(GridColumnFactory<T> columns)
		{
			foreach (GridColumn column3 in model.Columns)
			{
				if (column3.Visible || column3.Groupable)
				{
					GetGenericMethod("BoundColumn", typeof(T), column3.ValueType).Invoke(null, new object[6] { html, model, column3, columns, column3.Metadata, checkPermissions });
				}
			}
			if (model.CanEdit || model.CanDelete || model.CanInsert)
			{
				((GridColumnBuilderBase<IGridColumn, GridActionColumnBuilder>)(object)columns.Command((Action<GridActionCommandFactory<T>>)delegate(GridActionCommandFactory<T> cmd)
				{
					if (model.CanEdit)
					{
						((GridActionCommandBuilderBase<GridEditActionCommand, GridEditActionCommandBuilder>)(object)cmd.Edit()).ButtonType((GridButtonType)0);
					}
					if (model.CanDelete)
					{
						((GridActionCommandBuilderBase<GridDeleteActionCommand, GridDeleteActionCommandBuilder>)(object)cmd.Delete()).ButtonType((GridButtonType)0);
					}
					if (!model.CanEdit && model.CanInsert)
					{
						((GridActionCommandBuilderBase<GridInsertOnlyActionCommand, GridInsertOnlyCommandBuilder>)(object)cmd.InsertOnly()).ButtonType((GridButtonType)0);
					}
				})).Width(80);
			}
			columns.AutoGenerate(false);
		});
		if ((model.CanInsert || model.CanEdit || model.CanDelete) && !string.IsNullOrEmpty(model.DataKeyPropertyName))
		{
			grid.DataKeys((Action<GridDataKeyFactory<T>>)delegate(GridDataKeyFactory<T> keys)
			{
				keys.Add(model.DataKeyPropertyName);
			});
		}
		GridExportExcelUtility.ExportExcelStatus exportExcelStatus = (model.ExportExcel ? GridExportExcelUtility.GetExportExcelStatus(HttpContext.Current.Session.SessionID, AuthenticationService.GetCurrentUser().GetId(), model.UniqueName) : null);
		grid.ExportExcel(model.ExportExcel, model.ExportExcelFileName, (ExportExcelStatus)((exportExcelStatus != null && string.IsNullOrEmpty(exportExcelStatus.Error)) ? ((!exportExcelStatus.Ready) ? 1 : 2) : 0), (exportExcelStatus != null && string.IsNullOrEmpty(exportExcelStatus.Error)) ? html.Url().Action("Download", "BinaryFiles", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			id = exportExcelStatus.FileGuid
		}) : null, exportExcelStatus?.Error);
		if (model.HeaderSummary != null)
		{
			grid.HeaderSummary(model.HeaderSummary(html).ToString());
		}
		grid.Settings(model.Customizable && model.EnableCustomize);
		if (model.ClientEvents != null)
		{
			grid.ClientEvents(model.ClientEvents);
		}
		List<string> list2 = new List<string>();
		if (!model.HeaderVisible)
		{
			list2.Add("noth");
		}
		if (!string.IsNullOrEmpty(model.AlternationClass))
		{
			list2.Add(model.AlternationClass);
		}
		if (model.Resizeable)
		{
			if (!model.LockedResizeMode.HasValue)
			{
				initModelState();
				list2.Add((gridState.ColumnResizeMode == ColumnResizeMode.Web) ? "resize-mode-web" : "resize-mode-gui");
			}
			else
			{
				list2.Add((model.LockedResizeMode == ColumnResizeMode.Web) ? "resize-mode-web" : "resize-mode-gui");
				list2.Add("locked-mode");
			}
		}
		if (model.WithDefaultSettings)
		{
			list2.Add("width-default-settings");
		}
		if (model.GridData.Count == 0)
		{
			list2.Add("t-grid-no-data");
		}
		if (list2.Any())
		{
			grid.TableHtmlAttributes((object)new
			{
				@class = string.Join(" ", list2)
			});
		}
		grid.EnableCustomBinding(model.GridData.IsServerBinding);
		if (!string.IsNullOrEmpty(model.StateId))
		{
			((ViewComponentBuilderBase<Grid<T>, GridBuilder<T>>)(object)grid).AddHtmlAttribute("stateId", (object)model.StateId);
		}
		if (model.GridData.IsAjax)
		{
			string action = ((!string.IsNullOrEmpty(model.Action)) ? model.Action : (((ControllerContext)html.get_ViewContext()).get_RouteData().Values.ContainsKey("action") ? ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["action"].ToString() : "Grid"));
			string controller = ((!string.IsNullOrEmpty(model.Controller)) ? model.Controller : ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["controller"].ToString());
			RouteValueDictionary routeValues = model.RouteValues ?? new RouteValueDictionary();
			string insertAction = action + "_Insert";
			string updateAction = action + "_Update";
			string deleteAction = action + "_Delete";
			if (!routeValues.ContainsKey("gridId"))
			{
				routeValues.Add("gridId", model.UniqueName);
			}
			if (!routeValues.ContainsKey("provider"))
			{
				routeValues.Add("provider", model.StateProviderUid);
			}
			grid.DataBinding((Action<GridDataBindingConfigurationBuilder>)delegate(GridDataBindingConfigurationBuilder dataBinding)
			{
				GridBindingSettingsBuilder val2 = dataBinding.Ajax().Select(action, controller, routeValues);
				if (model.ExportExcel)
				{
					val2.ExportExcelReset("GridExportExcelReset", controller, routeValues);
				}
				if (model.CanInsert)
				{
					val2.Insert(insertAction, controller, routeValues);
				}
				if (model.CanEdit)
				{
					val2.Update(updateAction, controller, routeValues);
				}
				if (model.CanDelete)
				{
					val2.Delete(deleteAction, controller, routeValues);
				}
			});
		}
		if (model.CanInsert)
		{
			grid.ToolBar((Action<GridToolBarCommandFactory<T>>)delegate(GridToolBarCommandFactory<T> c)
			{
				((GridToolBarCommandBuilderBase<T, GridToolBarCommandBase<T>, GridToolBarCommandBuilder<T>>)(object)c.Insert()).ButtonType((GridButtonType)1);
			});
		}
		if (model.GridData.IsPageable)
		{
			grid.Pageable((Action<GridPagerSettingsBuilder>)delegate(GridPagerSettingsBuilder paging)
			{
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				paging.Total(model.GridData.Count).Position(model.PagerPosition).PageSize((gridState != null && gridState.PageSize > 0) ? gridState.PageSize : model.GridData.PageSize)
					.CardPager(model.IsCardPager);
			});
		}
		grid.Resizable((Action<GridResizingSettingsBuilder>)delegate(GridResizingSettingsBuilder s)
		{
			s.Columns(model.Resizeable);
		});
		if (model.Resizeable)
		{
			grid.Scrollable((Action<GridScrollSettingsBuilder>)delegate(GridScrollSettingsBuilder s)
			{
				s.Height("100%");
			});
		}
		if (model.Reorderable)
		{
			grid.Reorderable((Action<GridReorderingSettingsBuilder>)delegate(GridReorderingSettingsBuilder s)
			{
				s.Columns(true);
			});
		}
		grid.Sortable((Action<GridSortSettingsBuilder<T>>)delegate(GridSortSettingsBuilder<T> sorting)
		{
			if (model.Sortable)
			{
				sorting.SortMode((GridSortMode)0);
			}
			else
			{
				grid.Sortable((Action<GridSortSettingsBuilder<T>>)delegate(GridSortSettingsBuilder<T> s)
				{
					s.Enabled(false);
				});
			}
			if (!string.IsNullOrEmpty(model.GridData.SortExpression))
			{
				sorting.OrderBy((Action<GridSortDescriptorFactory<T>>)delegate(GridSortDescriptorFactory<T> o)
				{
					GridSortDescriptorBuilder val = o.Add(model.GridData.SortExpression);
					if (model.GridData.SortDirection == ListSortDirection.Ascending)
					{
						val.Ascending();
					}
					else
					{
						val.Descending();
					}
				});
			}
		});
		grid.Groupable((Action<GridGroupingSettingsBuilder<T>>)delegate(GridGroupingSettingsBuilder<T> grouping)
		{
			grouping.Visible(model.Groupable);
			if (model.GridData.GroupDescriptors != null && model.GridData.GroupDescriptors.Any())
			{
				grouping.Groups((Action<GridGroupDescriptorFactory<T>>)delegate(GridGroupDescriptorFactory<T> g)
				{
					foreach (GridGroupDescriptor groupDescriptor in model.GridData.GroupDescriptors)
					{
						g.Add(groupDescriptor.Member, groupDescriptor.SortDirection);
					}
				});
			}
		});
		grid.Footer(model.Footer);
		if (model.DetailViewClientTemplate != null || model.DetailViewTemplate != null)
		{
			grid.DetailView((Action<GridDetailViewBuilder<T>>)delegate(GridDetailViewBuilder<T> d)
			{
				if (model.DetailViewClientTemplate != null)
				{
					d.ClientTemplate(model.DetailViewClientTemplate());
				}
				if (model.DetailViewTemplate != null)
				{
					d.Template((Func<T, object>)model.DetailViewTemplate);
				}
				if (model.DetailViewTemplateVisible != null)
				{
					d.TemplateVisible((Func<T, bool>)model.DetailViewTemplateVisible);
				}
				d.ExpandDetailRows(model.ExpandDetailRows);
			});
		}
		grid.UseCardGridTemplate(model.UseCardGridTemplate);
		if (model.BeforeRowContent is Expression<Func<T, IEnumerable<string>>>)
		{
			grid.BeforeRowContent(model.BeforeRowContent as Expression<Func<T, IEnumerable<string>>>);
		}
		grid = grid.Localizable(Thread.CurrentThread.CurrentCulture.ToString());
		return grid;
	}

	private static GridRowEditMode ConvertRowEditMode(TableRowEditMode mode)
	{
		return (GridRowEditMode)(mode switch
		{
			TableRowEditMode.Table => 1, 
			TableRowEditMode.PopUpAndTable => 2, 
			_ => 0, 
		});
	}

	private static TDelegateValue GetDelegateValue<T, TGridObject, TDelegateValue>(Delegate @delegate, TGridObject grid, T obj)
	{
		return (TDelegateValue)@delegate.DynamicInvoke(obj, grid);
	}

	private static TValue GetExpressionValue<T, TValue>(Expression expr, T obj)
	{
		Func<TValue> func = () => ((Expression<Func<T, TValue>>)expr).Compile()(obj);
		string name = "GridExtensions_GetExpressionName";
		object value2;
		if (ContextVars.TryGetValue<Dictionary<object, object>>(name, out var value))
		{
			if (value.TryGetValue(expr, out value2))
			{
				return (TValue)value2;
			}
			value2 = func();
			value.Add(expr, value2);
			ContextVars.Set(name, value);
			return (TValue)value2;
		}
		value2 = func();
		value = new Dictionary<object, object> { { expr, value2 } };
		ContextVars.Set(name, value);
		return (TValue)value2;
	}
}
