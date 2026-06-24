using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Model.Views;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Fluent;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class Grid
{
	public const string GridResultDictionaryKey = "GridResultDictionary";

	protected IGridData gridData;

	protected IList<GridColumn> _columns;

	public string UniqueName { get; set; }

	public Type Type { get; private set; }

	public IGridData GridData => gridData;

	public string DataKeyPropertyName { get; set; }

	public virtual IList<GridColumn> Columns
	{
		get
		{
			return _columns;
		}
		set
		{
			_columns = value;
		}
	}

	public virtual IList<GridColumn> VisibleColumns => new List<GridColumn>(Columns.Where((GridColumn c) => c.Visible));

	public bool Selectable { get; set; }

	public bool Customizable { get; set; }

	public GridPagerPosition PagerPosition { get; set; }

	public bool IsCardPager { get; set; }

	public bool ExportExcel { get; set; }

	public string ExportExcelFileName { get; set; }

	public bool EnableCustomize { get; set; }

	public Func<HtmlHelper, object> HeaderSummary { get; set; }

	public string Action { get; set; }

	public string Controller { get; set; }

	public Guid StateProviderUid { get; set; }

	public Guid CustomSaveLoadSettingsProviderUid { get; set; }

	public RouteValueDictionary RouteValues { get; set; }

	public bool HeaderVisible { get; set; }

	public bool Footer { get; set; }

	public string AlternationClass { get; set; }

	public bool CanInsert { get; set; }

	public TableRowEditMode AddRowMode { get; set; }

	public bool CanEdit { get; set; }

	public TableRowEditMode EditRowMode { get; set; }

	public bool CanDelete { get; set; }

	public string ItemEditorTemplateName { get; set; }

	[Obsolete("Предпочтительнее вместо данного свойства использовать RowStyleDelegate")]
	public Expression RowStyleFunc { get; set; }

	public Delegate RowStyleDelegate { get; set; }

	[Obsolete("Предпочтительнее вместо данного свойства использовать RowClassDelegate")]
	public Expression RowClassFunc { get; set; }

	public Delegate RowClassDelegate { get; set; }

	[Obsolete("Предпочтительнее вместо данного свойства использовать RowHtmlAttributesDelegate")]
	public Expression RowHtmlAttributesFunc { get; set; }

	public Delegate RowHtmlAttributesDelegate { get; set; }

	[Obsolete("Предпочтительнее вместо данного свойства использовать RowPresetHtmlAttributesDelegate")]
	public List<Expression> RowPresetHtmlAttributesFunc { get; set; }

	public List<Delegate> RowPresetHtmlAttributesDelegate { get; set; }

	[Obsolete("Предпочтительнее вместо данного свойства использовать RowPresetClassDelegate")]
	public List<Expression> RowPresetClassFunc { get; set; }

	public List<Delegate> RowPresetClassDelegate { get; set; }

	public bool Resizeable { get; set; }

	public ColumnResizeMode? LockedResizeMode { get; set; }

	public bool Reorderable { get; set; }

	public bool Sortable { get; set; }

	public bool Groupable { get; set; }

	public bool GroupableExpand { get; set; }

	public bool WithDefaultSettings { get; set; }

	public bool UseCardGridTemplate { get; set; }

	public Expression BeforeRowContent { get; set; }

	public object DefaultDataItem { get; set; }

	public bool RenderDefaultDataItemEditors { get; set; }

	public bool ShowEditorsDescription { get; set; }

	public Func<HtmlHelper, string> FormContentAccessor { get; set; }

	public Action<GridClientEventsBuilder> ClientEvents { get; set; }

	public Func<string> DetailViewClientTemplate { get; set; }

	public Func<object, object> DetailViewTemplate { get; set; }

	public Func<object, bool> DetailViewTemplateVisible { get; set; }

	public bool ExpandDetailRows { get; set; }

	public Dictionary<string, object> ExtendedAjaxProperties { get; set; }

	public string CallbackFunction { get; set; }

	public bool Childs { get; set; }

	public List<string> CustomColumns { get; set; }

	public List<string> FetchColumns { get; set; }

	public bool EditBrowserHistory { get; set; }

	public Grid(IGridData gridData, Type type)
	{
		this.gridData = gridData;
		Type = type;
		DataKeyPropertyName = "Id";
		_columns = new List<GridColumn>();
		Customizable = true;
		ExportExcel = false;
		EnableCustomize = true;
		HeaderVisible = true;
		Footer = true;
		Sortable = true;
		AddRowMode = TableRowEditMode.PopUp;
		EditRowMode = TableRowEditMode.PopUpAndTable;
		ExtendedAjaxProperties = new Dictionary<string, object>();
		CallbackFunction = null;
		PagerPosition = (GridPagerPosition)2;
		FetchColumns = new List<string>();
		EditBrowserHistory = true;
		IsCardPager = false;
		if (this.gridData != null)
		{
			this.gridData.GridModel = this;
		}
	}

	public virtual GridColumn CreateColumn()
	{
		return new GridColumn();
	}
}
