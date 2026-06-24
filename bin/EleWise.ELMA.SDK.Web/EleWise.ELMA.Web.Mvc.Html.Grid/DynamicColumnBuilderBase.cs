using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public abstract class DynamicColumnBuilderBase
{
	internal DynamicGridColumn column;

	protected HtmlHelper html;

	protected ClassMetadata metadata;

	[UsedImplicitly]
	private string propertySpecifierExpression;

	protected DynamicColumnBuilderBase(HtmlHelper html, DynamicGridColumn column, string propertySpecifierExpression, ClassMetadata metadata)
	{
		this.html = html;
		this.column = column;
		this.metadata = metadata;
		this.propertySpecifierExpression = propertySpecifierExpression;
	}
}
public abstract class DynamicColumnBuilderBase<T, TBuilder> : DynamicColumnBuilderBase where T : class where TBuilder : DynamicColumnBuilderBase<T, TBuilder>
{
	private DynamicGridBuilder<T> dynamicGridBuilder;

	protected DynamicColumnBuilderBase(HtmlHelper html, DynamicGridColumn column, string propertySpecifierExpression, ClassMetadata metadata, DynamicGridBuilder<T> dynamicGridBuilder)
		: base(html, column, propertySpecifierExpression, metadata)
	{
		this.dynamicGridBuilder = dynamicGridBuilder;
	}

	public TBuilder Link(Expression<Func<T, string>> linkUrlExpression)
	{
		Func<T, string> linkUrlFunc = linkUrlExpression.Compile();
		column.ValueAccessor = (object obj) => html.Url().Content(linkUrlFunc((T)obj) ?? "http://TODO");
		return this as TBuilder;
	}

	public TBuilder Visible(bool visible)
	{
		column.Visible = visible;
		return this as TBuilder;
	}

	public TBuilder Hidden(bool hidden)
	{
		column.Hidden = hidden;
		return this as TBuilder;
	}

	public TBuilder Groupable(bool groupable)
	{
		column.Groupable = groupable;
		return this as TBuilder;
	}

	public TBuilder Header(object header)
	{
		column.Header = header;
		return this as TBuilder;
	}

	public TBuilder HtmlAttributes(object attributes)
	{
		if (attributes != null)
		{
			column.HtmlAttributes.Clear();
			column.HtmlAttributes = new RouteValueDictionary(attributes);
		}
		return this as TBuilder;
	}

	[Obsolete("Метод устарел")]
	public TBuilder CellHtmlAttributes(Expression<Func<T, object>> configurator)
	{
		column.CellHtmlAttributesFunc = configurator;
		return this as TBuilder;
	}

	public TBuilder CellHtmlAttributes(Func<T, GridColumn, object> configurator)
	{
		column.CellHtmlAttributesDelegate = configurator;
		return this as TBuilder;
	}

	public TBuilder Width(int width)
	{
		column.Width = width + "px";
		return this as TBuilder;
	}

	public TBuilder Required(bool required)
	{
		column.Required = required;
		if (dynamicGridBuilder != null)
		{
			dynamicGridBuilder.NeedSaveState = true;
		}
		return this as TBuilder;
	}

	public TBuilder Width(string width)
	{
		column.Width = width;
		return this as TBuilder;
	}

	public TBuilder Sortable(bool sortable)
	{
		column.Sortable = sortable;
		return this as TBuilder;
	}

	public TBuilder NotSortable()
	{
		column.Sortable = false;
		return this as TBuilder;
	}

	public TBuilder NotResizable()
	{
		column.Resizable = false;
		return this as TBuilder;
	}

	public TBuilder SortExpression(string expression)
	{
		column.SortExpression = expression;
		return this as TBuilder;
	}

	public TBuilder Template(Func<T, object> template)
	{
		if (template != null)
		{
			column.Template = (dynamic d) => template((T)d);
		}
		return this as TBuilder;
	}

	public TBuilder GroupHeaderTemplate(Func<GridGroupResult, object> groupHeaderTemplate)
	{
		if (groupHeaderTemplate != null)
		{
			column.GroupHeaderTemplate = groupHeaderTemplate;
		}
		return this as TBuilder;
	}

	public TBuilder GroupFooterTemplate(Func<object, object> groupFooterTemplate)
	{
		if (groupFooterTemplate != null)
		{
			column.GroupFooterTemplate = groupFooterTemplate;
		}
		return this as TBuilder;
	}

	public TBuilder CellVisible(Func<T, bool> cellVisible)
	{
		if (cellVisible != null)
		{
			column.CellVisible = (dynamic d) => cellVisible((T)d);
		}
		return this as TBuilder;
	}

	public TBuilder DefaultHidden()
	{
		column.DefaultHidden = false;
		return this as TBuilder;
	}

	public TBuilder Uid(string uniqueName)
	{
		column.UniqueName = uniqueName;
		return this as TBuilder;
	}

	public TBuilder UidFromMetadata(string propertyName)
	{
		if (metadata != null)
		{
			List<KeyValuePair<PropertyMetadata, ClassMetadata>> childProperties = MetadataLoader.GetChildProperties(metadata);
			if (childProperties.FindAll((KeyValuePair<PropertyMetadata, ClassMetadata> p) => p.Key.Name == propertyName).Count > 0)
			{
				KeyValuePair<PropertyMetadata, ClassMetadata> keyValuePair = childProperties.FirstOrDefault((KeyValuePair<PropertyMetadata, ClassMetadata> p) => p.Key.Name == propertyName);
				column.UniqueName = keyValuePair.Key.Uid.ToString();
			}
		}
		return this as TBuilder;
	}

	public TBuilder Order(int columnOrder)
	{
		column.Order = columnOrder;
		return this as TBuilder;
	}

	public TBuilder ToState()
	{
		column.ToState = true;
		return this as TBuilder;
	}

	public TBuilder ToState(bool toState)
	{
		column.ToState = toState;
		return this as TBuilder;
	}
}
