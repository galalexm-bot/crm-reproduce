using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public class DynamicColumnBuilder<T, TValue> : DynamicColumnBuilderBase<T, DynamicColumnBuilder<T, TValue>> where T : class
{
	[UsedImplicitly]
	private Func<T, TValue> propertySpecifierFunc;

	public DynamicColumnBuilder(HtmlHelper html, DynamicGridColumn column, Func<T, TValue> propertySpecifierFunc, ClassMetadata metadata, DynamicGridBuilder<T> dynamicGridBuilder)
		: base(html, column, propertySpecifierFunc?.ToString(), metadata, dynamicGridBuilder)
	{
		this.propertySpecifierFunc = propertySpecifierFunc;
	}
}
public class DynamicColumnBuilder<T> : DynamicColumnBuilderBase<T, DynamicColumnBuilder<T>> where T : class
{
	public DynamicColumnBuilder(HtmlHelper html, DynamicGridColumn column, string propertySpecifierExpression, ClassMetadata metadata, DynamicGridBuilder<T> dynamicGridBuilder)
		: base(html, column, propertySpecifierExpression, metadata, dynamicGridBuilder)
	{
	}
}
