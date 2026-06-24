using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using Telerik.Web.Mvc.Extensions;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Html;

namespace EleWise.ELMA.Web.Mvc.Telerik.Grids;

internal class TelerikGridBoundColumn<TModel, TValue> : GridBoundColumn<TModel, TValue>, ITelerikGridBoundColumn where TModel : class
{
	private string expressionString;

	private Func<object, string> valueFunc;

	private Func<TModel, TValue> compiledExpression;

	public ClassMetadata Metadata { get; set; }

	public ViewAttributes ViewAttributes { get; set; }

	public bool CheckCellPermissions { get; set; }

	public TelerikGridBoundColumn(Grid<TModel> grid, Expression<Func<TModel, TValue>> expression, string expressionString, string sortExpression, Func<object, string> valueFunc, ClassMetadata metadata)
		: base(grid, expression)
	{
		if (expression != null && ExpressionExtensions.ToMemberExpression((LambdaExpression)expression) != null)
		{
			base.InitFromExpression(expression);
		}
		else
		{
			if (string.IsNullOrEmpty(expressionString))
			{
				throw new InvalidOperationException("Parameter 'expression' or 'expressionString' must be not null");
			}
			base.set_Expression(expression);
			this.expressionString = expressionString;
			((GridColumnBase<TModel>)(object)this).set_Member(expressionString);
			base.set_MemberType(typeof(object));
			((GridColumnBase<TModel>)(object)this).set_Title(expressionString);
		}
		this.valueFunc = valueFunc;
		if (string.IsNullOrEmpty(((GridColumnBase<TModel>)(object)this).get_Title()))
		{
			((GridColumnBase<TModel>)(object)this).set_Title(StringExtensions.AsTitle(((GridColumnBase<TModel>)(object)this).get_Member()));
		}
		base.set_SortExpression(CustomPropertyProjection.GetExpressionFromString(sortExpression ?? ((GridColumnBase<TModel>)(object)this).get_Member(), out var _));
		Metadata = metadata;
	}

	protected override IGridDataCellBuilder CreateDisplayForCellBuilder(IGridHtmlHelper htmlHelper)
	{
		if (base.get_Expression() == null)
		{
			return (IGridDataCellBuilder)(object)new TelerikGridDisplayForCellBuilder<TModel, TValue>((GridColumnBase<TModel>)(object)this, ((GridColumnBase<TModel>)(object)this).get_Member(), Metadata, ViewAttributes);
		}
		if (compiledExpression == null)
		{
			compiledExpression = base.get_Expression().Compile();
		}
		return (IGridDataCellBuilder)(object)new TelerikGridDisplayForCellBuilder<TModel, TValue>((GridColumnBase<TModel>)(object)this, base.get_Expression(), compiledExpression, valueFunc, Metadata, ViewAttributes);
	}

	protected override IGridDataCellBuilder CreateDisplayBuilderCore(IGridHtmlHelper htmlHelper)
	{
		IGridDataCellBuilder val = base.CreateDisplayBuilderCore(htmlHelper);
		int num = ((GridColumnBase<TModel>)(object)this).get_Grid().get_Columns().IndexOf((GridColumnBase<TModel>)(object)this);
		List<GridColumnBase<TModel>> list = new List<GridColumnBase<TModel>>();
		for (int i = num + 1; i < ((GridColumnBase<TModel>)(object)this).get_Grid().get_Columns().Count; i++)
		{
			list.Add(((GridColumnBase<TModel>)(object)this).get_Grid().get_Columns()[i]);
		}
		if (val == null)
		{
			return null;
		}
		return (IGridDataCellBuilder)(object)new TelerikGridNullableCellBuilder<TModel, TValue>((GridColumnBase<TModel>)(object)this, list, val);
	}

	protected override IGridDataCellBuilder CreateEditBuilderCore(IGridHtmlHelper htmlHelper)
	{
		if (!base.get_ReadOnly())
		{
			if (base.get_Expression() == null)
			{
				return (IGridDataCellBuilder)(object)new TelerikGridEditorForCellBuilder<TModel, TValue>((GridColumnBase<TModel>)(object)this, ((GridColumnBase<TModel>)(object)this).get_Member());
			}
			if (compiledExpression == null)
			{
				compiledExpression = base.get_Expression().Compile();
			}
			return (IGridDataCellBuilder)(object)new TelerikGridEditorForCellBuilder<TModel, TValue>((GridColumnBase<TModel>)(object)this, base.get_Expression(), compiledExpression, valueFunc);
		}
		return ((GridColumnBase<TModel>)(object)this).CreateDisplayBuilder(htmlHelper);
	}
}
