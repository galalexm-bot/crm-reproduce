using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Fluent;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public class DynamicGridBuilder<T> : GridBuilder<T> where T : class
{
	private bool saveState = true;

	protected string dynamicContentId;

	protected DynamicGrid dynamicGrid;

	private readonly ClassMetadata _metadata;

	private Action<GridState> _stateLoadedAction;

	internal bool NeedSaveState { get; set; }

	public GridState State { get; set; }

	public DynamicGridBuilder(HtmlHelper html, string dynamicContentId, IGridData<T> gridData)
		: this(html, "", dynamicContentId, gridData, (Guid?)null)
	{
	}

	public DynamicGridBuilder(HtmlHelper html, string uniqueName, string dynamicContentId, IGridData<T> gridData, Guid? stateProvider = null)
		: base(html, gridData)
	{
		if (string.IsNullOrEmpty(uniqueName))
		{
			uniqueName = GridHelper.GetGridId(((ControllerContext)html.get_ViewContext()).get_RouteData());
		}
		this.dynamicContentId = dynamicContentId;
		grid = (dynamicGrid = new DynamicGrid(uniqueName, dynamicContentId, gridData, typeof(T)));
		grid.StateProviderUid = (stateProvider.HasValue ? stateProvider.Value : Guid.Empty);
		if (html.get_ViewContext() != null && ((ControllerContext)html.get_ViewContext()).get_HttpContext() != null && AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)html.get_ViewContext()).get_HttpContext().Request) && !html.get_ViewData().ContainsKey("IsDynamicInitialized"))
		{
			html.get_ViewData().Add("IsDynamicInitialized", (object)true);
		}
		_metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(T));
		if (_metadata != null)
		{
			State = LoadStateInternal();
		}
	}

	public DynamicGridBuilder<T> CallbackFunction(string callbackFunction)
	{
		grid.CallbackFunction = callbackFunction;
		return this;
	}

	public DynamicGridBuilder<T> Action(string action)
	{
		grid.Action = action;
		return this;
	}

	public DynamicGridBuilder<T> Controller(string controller)
	{
		grid.Controller = controller;
		return this;
	}

	public DynamicGridBuilder<T> RouteValues(object routeValues)
	{
		grid.RouteValues = new RouteValueDictionary(routeValues);
		return this;
	}

	public DynamicGridBuilder<T> RouteValues(RouteValueDictionary routeValues)
	{
		grid.RouteValues = routeValues;
		return this;
	}

	public DynamicGridBuilder<T> Uid(string uniqueName)
	{
		string text3 = (grid.UniqueName = (dynamicGrid.UniqueName = uniqueName));
		return this;
	}

	public DynamicGridBuilder<T> Customizable(bool value = true)
	{
		grid.Customizable = value;
		return this;
	}

	public DynamicGridBuilder<T> PagerPosition(DynamicGridPagerPosition value = DynamicGridPagerPosition.Top)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (Enum.TryParse<GridPagerPosition>(value.ToString(), out GridPagerPosition result))
		{
			grid.PagerPosition = result;
		}
		return this;
	}

	public DynamicGridBuilder<T> CardPager(bool value)
	{
		grid.IsCardPager = value;
		return this;
	}

	public DynamicGridBuilder<T> ExportExcel(string fileName)
	{
		grid.ExportExcel = true;
		grid.ExportExcelFileName = fileName;
		return this;
	}

	public DynamicGridBuilder<T> ExportExcel(bool value = true, string fileName = null)
	{
		grid.ExportExcel = value;
		grid.ExportExcelFileName = fileName;
		return this;
	}

	public DynamicGridBuilder<T> PopupStateProvider(Guid uid)
	{
		grid.CustomSaveLoadSettingsProviderUid = uid;
		return this;
	}

	public DynamicGridBuilder<T> EnableCustomize(bool value = true)
	{
		grid.EnableCustomize = value;
		return this;
	}

	public DynamicGridBuilder<T> FetchColumn(params string[] columns)
	{
		if (columns != null)
		{
			grid.FetchColumns.AddRange(columns);
		}
		return this;
	}

	public DynamicGridBuilder<T> FetchColumn<FT>(params Expression<Func<FT, object>>[] propertySpecifier)
	{
		for (int i = 0; i < propertySpecifier.Length; i++)
		{
			string text = LinqUtils.FullNameOf(propertySpecifier[i]);
			FetchColumn(text);
		}
		return this;
	}

	public DynamicGridBuilder<T> Columns(Action<DynamicColumnsBuilder<T>> columnsBuilder)
	{
		DynamicColumnsBuilder<T> obj = new DynamicColumnsBuilder<T>(html, dynamicGrid, State, _metadata, this);
		columnsBuilder(obj);
		return this;
	}

	public DynamicGridBuilder<T> HeaderSummary(Func<HtmlHelper, object> template)
	{
		grid.HeaderSummary = template;
		return this;
	}

	public DynamicGridBuilder<T> Header(bool visible = true)
	{
		grid.HeaderVisible = visible;
		return this;
	}

	public DynamicGridBuilder<T> Footer(bool visible = true)
	{
		grid.Footer = visible;
		return this;
	}

	public DynamicGridBuilder<T> AlternationClass(string @class)
	{
		grid.AlternationClass = @class;
		return this;
	}

	[Obsolete("Метод устарел")]
	public DynamicGridBuilder<T> RowStyle(Expression<Func<T, HtmlStyle>> configurator)
	{
		grid.RowStyleFunc = configurator;
		return this;
	}

	public DynamicGridBuilder<T> RowStyle(Func<T, Grid<T>, HtmlStyle> configurator)
	{
		grid.RowStyleDelegate = configurator;
		return this;
	}

	[Obsolete("Метод устарел")]
	public DynamicGridBuilder<T> RowClass(Expression<Func<T, string>> configurator)
	{
		grid.RowClassFunc = configurator;
		return this;
	}

	public DynamicGridBuilder<T> RowClass(Func<T, Grid<T>, string> configurator)
	{
		grid.RowClassDelegate = configurator;
		return this;
	}

	[Obsolete("Метод устарел")]
	public DynamicGridBuilder<T> RowHtmlAttributes(Expression<Func<T, object>> configurator)
	{
		grid.RowHtmlAttributesFunc = configurator;
		return this;
	}

	public DynamicGridBuilder<T> RowHtmlAttributes(Func<T, Grid<T>, object> configurator)
	{
		grid.RowHtmlAttributesDelegate = configurator;
		return this;
	}

	public DynamicGridBuilder<T> DefaultColumns(bool childs = false, IEnumerable<Guid> availablePropertyUids = null)
	{
		grid.Childs = childs;
		new DynamicColumnsBuilder<T>(html, dynamicGrid, State, _metadata, this).DefaultColumns(childs, availablePropertyUids);
		return this;
	}

	public DynamicGridBuilder<T> Childs(bool use = true)
	{
		grid.Childs = use;
		return this;
	}

	public DynamicGridBuilder<T> SubPropertyColumns(Expression<Func<T, object>> propertySpecifier)
	{
		Type type = propertySpecifier.Body.Type;
		ClassMetadata metadata = MetadataLoader.LoadMetadata(type) as ClassMetadata;
		foreach (GridColumn defaultColumn in GridBuilderExtensions.GetDefaultColumns(type, metadata, State))
		{
			GridColumn gc = defaultColumn;
			GridColumn gridColumn = grid.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == gc.UniqueName);
			if (gridColumn == null)
			{
				gc.SortExpression = LinqUtils.FullNameOf(propertySpecifier) + "." + gc.Name;
				gc.Visible = false;
				gc.ToState = true;
				grid.Columns.Add(gc);
			}
			else if (string.IsNullOrWhiteSpace(gridColumn.Width))
			{
				gridColumn.Width = gc.Width;
			}
		}
		return this;
	}

	public DynamicGridBuilder<T> ClientEvents(Action<GridClientEventsBuilder> configurator)
	{
		grid.ClientEvents = configurator;
		return this;
	}

	public DynamicGridBuilder<T> DefaultSortExpression(string sortExpression)
	{
		grid.GridData.SortExpression = sortExpression;
		return this;
	}

	public DynamicGridBuilder<T> DefaultSortDirection(ListSortDirection sortDirection)
	{
		grid.GridData.SortDirection = sortDirection;
		return this;
	}

	public DynamicGridBuilder<T> Resizeable(bool resizeable = true)
	{
		grid.Resizeable = resizeable;
		return this;
	}

	public DynamicGridBuilder<T> Reorderable(bool reorderable = true)
	{
		grid.Reorderable = reorderable;
		return this;
	}

	public DynamicGridBuilder<T> Sortable(bool sortable = true)
	{
		grid.Sortable = sortable;
		return this;
	}

	public DynamicGridBuilder<T> Groupable(bool groupable = true)
	{
		grid.Groupable = groupable;
		return this;
	}

	public DynamicGridBuilder<T> WithDefaultSettings(bool val = true)
	{
		grid.WithDefaultSettings = val;
		return this;
	}

	public DynamicGridBuilder<T> UseCardGridTemplate(bool val = true)
	{
		grid.UseCardGridTemplate = val;
		return this;
	}

	public DynamicGridBuilder<T> BeforeRowContent(Expression<Func<T, IEnumerable<string>>> template)
	{
		grid.BeforeRowContent = template;
		return this;
	}

	public DynamicGridBuilder<T> DetailViewClientTemplate(Func<string> template)
	{
		grid.DetailViewClientTemplate = template;
		return this;
	}

	public DynamicGridBuilder<T> DetailViewTemplate(Func<object, object> template, bool expandDetailRows = false)
	{
		grid.DetailViewTemplate = template;
		grid.ExpandDetailRows = expandDetailRows;
		return this;
	}

	public DynamicGridBuilder<T> DetailViewTemplateVisible(Func<object, bool> visible)
	{
		grid.DetailViewTemplateVisible = visible;
		return this;
	}

	public DynamicGridBuilder<T> ApplyExtensions(string uniqueName = null)
	{
		uniqueName = uniqueName ?? grid.UniqueName;
		if (string.IsNullOrEmpty(uniqueName))
		{
			return this;
		}
		(from e in ComponentManager.Current.GetExtensionPoints<IDynamicGridExtension>()
			where e.MatchUniqueName(uniqueName)
			select e).ForEach(delegate(IDynamicGridExtension e)
		{
			e.Apply(this);
		});
		return this;
	}

	public DynamicGridBuilder<T> ExtendedAjaxProperty(string key, object value)
	{
		grid.ExtendedAjaxProperties.Add(key, value);
		return this;
	}

	public DynamicGridBuilder<T> OnStateLoaded([CanBeNull] Action<GridState> stateLoadedAction)
	{
		_stateLoadedAction = stateLoadedAction;
		return this;
	}

	public DynamicGridBuilder<T> SaveState(bool value)
	{
		saveState = value;
		return this;
	}

	public DynamicGridBuilder<T> EditBrowserHistory(bool edit = true)
	{
		grid.EditBrowserHistory = edit;
		return this;
	}

	protected override string Render()
	{
		if (NeedSaveState && State != null && grid.UniqueName != State.GridId)
		{
			SaveStateInternal();
		}
		ApplyState();
		return ((object)PartialExtensions.Partial(html, "Templates/DynamicGrid", (object)grid)).ToString();
	}

	[Obsolete("Метод устарел")]
	protected DynamicGridBuilder<T> RowPresetHtmlAttributes(Expression<Func<T, object>> configurator)
	{
		if (grid.RowPresetHtmlAttributesFunc == null)
		{
			grid.RowPresetHtmlAttributesFunc = new List<Expression>();
		}
		grid.RowPresetHtmlAttributesFunc.Add(configurator);
		return this;
	}

	protected DynamicGridBuilder<T> RowPresetHtmlAttributes(Func<T, Grid<T>, object> configurator)
	{
		if (grid.RowPresetHtmlAttributesDelegate == null)
		{
			grid.RowPresetHtmlAttributesDelegate = new List<Delegate>();
		}
		grid.RowPresetHtmlAttributesDelegate.Add(configurator);
		return this;
	}

	[Obsolete("Метод устарел")]
	protected DynamicGridBuilder<T> RowPresetClass(Expression<Func<T, string>> configurator)
	{
		if (grid.RowPresetClassFunc == null)
		{
			grid.RowPresetClassFunc = new List<Expression>();
		}
		grid.RowPresetClassFunc.Add(configurator);
		return this;
	}

	protected DynamicGridBuilder<T> RowPresetClass(Func<T, Grid<T>, string> configurator)
	{
		if (grid.RowPresetClassDelegate == null)
		{
			grid.RowPresetClassDelegate = new List<Delegate>();
		}
		grid.RowPresetClassDelegate.Add(configurator);
		return this;
	}

	private bool RefreshCustomColumns()
	{
		bool result = false;
		List<GridColumn> list = grid.Columns.Where((GridColumn c) => c.ToState).ToList();
		if (list.Count > 0)
		{
			if (State.CustomColumns == null)
			{
				State.CustomColumns = new List<CustomColumnDescriptor>();
			}
			list.ForEach(delegate(GridColumn cc)
			{
				CustomColumnDescriptor customColumnDescriptor = State.CustomColumns.FirstOrDefault((CustomColumnDescriptor c) => c.UniqueName == cc.UniqueName);
				if (customColumnDescriptor == null)
				{
					State.CustomColumns.Add(new CustomColumnDescriptor
					{
						UniqueName = cc.UniqueName,
						DisplayName = cc.Header.ToString(),
						SortExpression = cc.SortExpression,
						Sortable = cc.Sortable,
						Visible = cc.Visible
					});
				}
				else
				{
					customColumnDescriptor.DisplayName = cc.Header.ToString();
					customColumnDescriptor.SortExpression = cc.SortExpression;
					customColumnDescriptor.Sortable = cc.Sortable;
				}
			});
			result = State.Refresh(typeof(T));
		}
		return result;
	}

	private void ApplyState()
	{
		if (!grid.Customizable)
		{
			return;
		}
		if (State == null && _metadata != null)
		{
			State = GridState.CreateNew(grid.UniqueName, typeof(T));
			if (grid.Columns.Any())
			{
				foreach (ColumnState columnState in State.ColumnStates)
				{
					GridColumn gridColumn = grid.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == columnState.UniqueName);
					if (gridColumn != null)
					{
						columnState.Hidden = !gridColumn.Visible;
					}
					else
					{
						columnState.Hidden = true;
					}
				}
				RefreshCustomColumns();
			}
			try
			{
				SaveStateInternal();
			}
			catch (Exception)
			{
				GridState gridState = LoadStateInternal();
				if (gridState == null)
				{
					SaveStateInternal();
				}
				else
				{
					State = gridState;
				}
			}
		}
		if (State != null && State.ColumnStates != null)
		{
			bool flag = RefreshCustomColumns();
			GridState gridState2 = null;
			if (grid.UniqueName != State.GridId)
			{
				gridState2 = LoadStateInternal();
			}
			int order = 1;
			foreach (GridColumn column in grid.Columns)
			{
				GridColumn col = column;
				if (string.IsNullOrEmpty(col.UniqueName))
				{
					col.Visible = true;
					col.Order = order;
				}
				else
				{
					ColumnState columnState2 = State.ColumnStates[col.UniqueName];
					if (columnState2 != null)
					{
						columnState2.Required = col.Required;
						col.Visible = !columnState2.Hidden;
						if (columnState2.Order == int.MinValue || columnState2.Order == 0)
						{
							columnState2.Order = order;
							flag = true;
						}
						if (col.Order == int.MinValue)
						{
							col.Order = columnState2.Order;
						}
						if (col.ToState)
						{
							string text = columnState2.WidthAttribute ?? col.Width;
							if (!string.IsNullOrEmpty(text) && !text.Contains("px"))
							{
								text += "px";
							}
							col.Width = text;
						}
					}
					else
					{
						if (col.Order == int.MaxValue || col.Order == 2147483646)
						{
							col.Order = int.MaxValue;
						}
						else
						{
							col.Order = order;
						}
						if (col.ToState)
						{
							if (State.CustomColumns == null)
							{
								State.CustomColumns = new List<CustomColumnDescriptor>();
							}
							bool flag2 = false;
							if (State.CustomColumns.All((CustomColumnDescriptor cc) => cc.UniqueName != col.UniqueName))
							{
								State.CustomColumns.Add(new CustomColumnDescriptor
								{
									UniqueName = col.UniqueName,
									DisplayName = col.Header.ToString(),
									SortExpression = col.SortExpression
								});
								flag2 = true;
							}
							if (flag2)
							{
								flag = State.Refresh(typeof(T), isNew: false, forceRefresh: true);
							}
						}
					}
					if (col.ToState && gridState2 != null)
					{
						ColumnState columnState3 = gridState2.ColumnStates[col.UniqueName];
						if (columnState3 != null)
						{
							string text2 = columnState3.WidthAttribute ?? col.Width;
							if (!string.IsNullOrEmpty(text2) && !text2.Contains("px"))
							{
								text2 += "px";
							}
							col.Width = text2;
						}
					}
				}
				if (col.Order != int.MinValue && col.Order != int.MaxValue)
				{
					order = col.Order + 1;
				}
			}
			string sortExpression = State.SortExpression;
			if (!string.IsNullOrEmpty(sortExpression) && !grid.Columns.Any((GridColumn a) => !a.Sortable && a.SortExpression == sortExpression))
			{
				string dbSortExpression = State.GetDbSortExpression(grid.Childs);
				if (!dbSortExpression.Equals(sortExpression))
				{
					State.SortExpression = dbSortExpression;
				}
				grid.GridData.SortExpression = dbSortExpression;
				grid.GridData.SortDirection = State.SortDirection;
			}
			if (grid.GridData.PageCount >= State.CurrentPage)
			{
				grid.GridData.PageIndex = State.CurrentPage;
			}
			List<ColumnState> list = State.ColumnStates.Where((ColumnState c) => c.IsOnView && grid.Columns.All((GridColumn gc) => gc.UniqueName != c.UniqueName)).ToList();
			if (list.Count > 0)
			{
				State.ColumnStates.RemoveAll(list);
				flag = true;
			}
			flag = State.Refresh(typeof(T)) || flag;
			foreach (GridColumn column2 in grid.Columns)
			{
				ColumnState columnState4 = State.ColumnStates[column2.UniqueName];
				if (columnState4 == null)
				{
					continue;
				}
				if (!columnState4.IsOnView)
				{
					columnState4.IsOnView = true;
					columnState4.Hidden = !column2.Visible;
					flag = true;
				}
				if (column2.IsChangeSortable && column2.Sortable != columnState4.Sortable)
				{
					columnState4.Sortable = column2.Sortable;
					flag = true;
				}
				if (grid.Childs && !string.IsNullOrEmpty(column2.SortExpression))
				{
					string dbColumnDescription = ColumnState.GetDbColumnDescription(columnState4.GetDbName(withParent: true, forSortExpression: true));
					if (!dbColumnDescription.Equals(column2.SortExpression))
					{
						column2.SortExpression = dbColumnDescription;
					}
				}
			}
			if (flag)
			{
				SaveStateInternal();
			}
		}
		if (_stateLoadedAction != null)
		{
			_stateLoadedAction(State);
		}
	}

	private GridState LoadStateInternal()
	{
		if (saveState)
		{
			return GridPersonalizationAdministration.LoadState(grid.UniqueName, grid.StateProviderUid);
		}
		return null;
	}

	private void SaveStateInternal()
	{
		if (saveState)
		{
			GridPersonalizationAdministration.SaveState(grid.UniqueName, State, grid.StateProviderUid);
		}
	}
}
