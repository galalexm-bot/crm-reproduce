using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public static class DynamicGridExtension
{
	[Obsolete("Метод устарел")]
	public static SelectableGridBuilder<T, TValue> SelectableGrid<T, TValue>(this HtmlHelper htmlHelper, GridDataFilter<T> gridData, Expression<Func<T, TValue>> expression) where T : class
	{
		return new SelectableGridBuilder<T, TValue>(htmlHelper, gridData, expression);
	}

	[Obsolete("Метод устарел")]
	public static SelectableGridBuilder<T, TValue> SelectableGrid<T, TValue>(this HtmlHelper htmlHelper, string gridId, IGridData<T> gridData, Expression<Func<T, TValue>> expression) where T : class
	{
		return new SelectableGridBuilder<T, TValue>(htmlHelper, gridId, gridData, expression);
	}

	[Obsolete("Метод устарел")]
	public static SelectableGridBuilder<T, TValue> SelectableGrid<T, TValue>(this HtmlHelper htmlHelper, string gridId, IGridData<T> gridData, Expression<Func<T, TValue>> expression, Guid? stateProvider) where T : class
	{
		return new SelectableGridBuilder<T, TValue>(htmlHelper, gridId, gridData, expression, stateProvider);
	}

	public static SelectableGridBuilder<T> SelectableGrid<T>(this HtmlHelper htmlHelper, GridDataFilter<T> gridData, string propertyIdName) where T : class
	{
		return new SelectableGridBuilder<T>(htmlHelper, gridData, propertyIdName);
	}

	public static SelectableGridBuilder<T> SelectableGrid<T>(this HtmlHelper htmlHelper, string gridId, IGridData<T> gridData, string propertyIdName) where T : class
	{
		return new SelectableGridBuilder<T>(htmlHelper, gridId, gridData, propertyIdName);
	}

	public static SelectableGridBuilder<T> SelectableGrid<T>(this HtmlHelper htmlHelper, string gridId, IGridData<T> gridData, string propertyIdName, Guid? stateProvider) where T : class
	{
		return new SelectableGridBuilder<T>(htmlHelper, gridId, gridData, propertyIdName, stateProvider);
	}

	public static SelectableGridBuilder<T, TValue> SelectableGrid<T, TValue>(this HtmlHelper htmlHelper, GridDataFilter<T> gridData, Func<T, Grid, TValue> @delegate) where T : class
	{
		return new SelectableGridBuilder<T, TValue>(htmlHelper, gridData, @delegate);
	}

	public static SelectableGridBuilder<T, TValue> SelectableGrid<T, TValue>(this HtmlHelper htmlHelper, string gridId, IGridData<T> gridData, Func<T, Grid, TValue> @delegate) where T : class
	{
		return new SelectableGridBuilder<T, TValue>(htmlHelper, gridId, gridData, @delegate);
	}

	public static SelectableGridBuilder<T, TValue> SelectableGrid<T, TValue>(this HtmlHelper htmlHelper, string gridId, IGridData<T> gridData, Func<T, Grid, TValue> @delegate, Guid? stateProvider) where T : class
	{
		return new SelectableGridBuilder<T, TValue>(htmlHelper, gridId, gridData, @delegate, stateProvider);
	}
}
