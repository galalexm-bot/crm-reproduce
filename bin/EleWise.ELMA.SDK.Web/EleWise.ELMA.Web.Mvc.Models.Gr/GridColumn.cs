using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

public class GridColumn
{
	private bool? visible;

	private bool sortable;

	private bool isChangeSortable;

	private int order = int.MinValue;

	public Type ValueType { get; set; }

	public object Header { get; set; }

	public bool Sortable
	{
		get
		{
			return sortable;
		}
		set
		{
			sortable = value;
			isChangeSortable = true;
		}
	}

	public bool IsChangeSortable => isChangeSortable;

	public bool Groupable { get; set; }

	public bool Resizable { get; set; }

	public LineAlignment CellAlignment { get; set; }

	public bool DefaultHidden { get; set; }

	public bool Visible
	{
		get
		{
			if (ColumnVisible != null)
			{
				visible = ColumnVisible();
			}
			if (!visible.HasValue)
			{
				visible = !DefaultHidden;
			}
			return visible.Value;
		}
		set
		{
			visible = value;
		}
	}

	public bool Hidden { get; set; }

	public string SortExpression { get; set; }

	public Func<object, string> ValueAccessor { get; set; }

	public Expression Expression { get; set; }

	public string UniqueName { get; set; }

	public string Name { get; set; }

	public ClassMetadata Metadata { get; set; }

	public string Url { get; set; }

	public string Width { get; set; }

	public bool Required { get; set; }

	public Func<dynamic, object> Template { get; set; }

	public IDictionary<string, object> HtmlAttributes { get; set; }

	[Obsolete("Свойство устарело, используете вместо него CellHtmlAttributesDelegate")]
	public Expression CellHtmlAttributesFunc { get; set; }

	public Delegate CellHtmlAttributesDelegate { get; set; }

	public Func<dynamic, bool> CellVisible { get; set; }

	public Func<bool> ColumnVisible { get; set; }

	public Func<GridGroupResult, object> GroupHeaderTemplate { get; set; }

	public Func<object, object> GroupFooterTemplate { get; set; }

	public bool ReadOnly { get; set; }

	public int Order
	{
		get
		{
			if (ColumnOrder != null)
			{
				order = ColumnOrder();
			}
			return order;
		}
		set
		{
			order = value;
		}
	}

	public Func<int> ColumnOrder { get; set; }

	public bool ToState { get; set; }

	public bool EditableInTable { get; set; }

	public GridColumn()
	{
		sortable = true;
		Groupable = true;
		Resizable = true;
		HtmlAttributes = new Dictionary<string, object>();
		CellAlignment = LineAlignment.Left;
		UniqueName = Guid.NewGuid().ToString();
		Order = int.MinValue;
	}
}
