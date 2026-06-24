using System;
using System.Collections.Generic;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Html;

namespace EleWise.ELMA.Web.Mvc.Telerik.Grids;

internal class TelerikGridNullableCellBuilder<TModel, TValue> : IGridDataCellBuilder, IGridDecoratableCellBuilder where TModel : class
{
	private GridColumnBase<TModel> currentColumn;

	private List<GridColumnBase<TModel>> nextColumns;

	private IGridDataCellBuilder builder;

	public ICollection<IGridCellBuilderDecorator> Decorators => ((IGridDecoratableCellBuilder)builder).get_Decorators();

	public IDictionary<string, object> HtmlAttributes
	{
		get
		{
			return builder.get_HtmlAttributes();
		}
		set
		{
			builder.set_HtmlAttributes(value);
		}
	}

	public Action<object> Callback
	{
		get
		{
			return builder.get_Callback();
		}
		set
		{
			builder.set_Callback(value);
		}
	}

	public string Html
	{
		get
		{
			return builder.get_Html();
		}
		set
		{
			builder.set_Html(value);
		}
	}

	public TelerikGridNullableCellBuilder(GridColumnBase<TModel> currentColumn, List<GridColumnBase<TModel>> nextColumns, IGridDataCellBuilder builder)
	{
		this.currentColumn = currentColumn;
		this.nextColumns = nextColumns;
		this.builder = builder;
	}

	public IHtmlNode CreateCell(object dataItem)
	{
		try
		{
			Callback(dataItem);
			if (!ApplyColspan(dataItem))
			{
				return null;
			}
			return builder.CreateCell(dataItem);
		}
		finally
		{
			if (HtmlAttributes != null && HtmlAttributes.ContainsKey("colspan"))
			{
				HtmlAttributes.Remove("colspan");
			}
		}
	}

	public IHtmlNode CreateCellContent(object dataItem)
	{
		if (!ApplyColspan(dataItem))
		{
			return null;
		}
		return builder.CreateCellContent(dataItem);
	}

	private bool ApplyColspan(object dataItem)
	{
		if (HtmlAttributes != null && HtmlAttributes.ContainsKey("colspan"))
		{
			HtmlAttributes.Remove("colspan");
		}
		if (currentColumn.get_CellVisible() != null && !currentColumn.get_CellVisible()((TModel)dataItem))
		{
			return false;
		}
		int num = 1;
		foreach (GridColumnBase<TModel> nextColumn in nextColumns)
		{
			if (nextColumn.get_CellVisible() != null && !nextColumn.get_CellVisible()((TModel)dataItem))
			{
				num++;
				continue;
			}
			break;
		}
		if (HtmlAttributes != null && num > 1)
		{
			HtmlAttributes.Add("colspan", num);
		}
		return true;
	}
}
