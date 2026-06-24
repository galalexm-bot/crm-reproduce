using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using Telerik.Web.Mvc.Extensions;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Html;

namespace EleWise.ELMA.Web.Mvc.Telerik.Grids;

public class TelerikGridEditorForCellBuilder<TModel, TValue> : GridDataCellBuilderBase, ITelerikGridEditorForCellBuilder, IGridDataCellBuilder, IGridDecoratableCellBuilder where TModel : class
{
	private bool checkPermissions;

	private readonly string expressionString;

	private Func<object, string> valueFunc;

	private Func<TModel, TValue> compiledExpression;

	private ClassMetadata metadata;

	public Expression<Func<TModel, TValue>> Expression { get; set; }

	public ViewContext ViewContext { get; set; }

	public string TemplateName { get; set; }

	public string Member { get; set; }

	public ViewAttributes ViewAttributes { get; set; }

	public TelerikGridEditorForCellBuilder(GridColumnBase<TModel> column, Expression<Func<TModel, TValue>> expression, Func<TModel, TValue> compiledExpression, Func<object, string> valueFunc, ClassMetadata metadata = null)
	{
		ViewContext = ((ViewComponentBase)column.get_Grid()).get_ViewContext();
		Expression = expression;
		((GridDataCellBuilderBase)this).set_HtmlAttributes((IDictionary<string, object>)((column.get_HtmlAttributes() != null) ? new RouteValueDictionary(column.get_HtmlAttributes()) : null));
		this.valueFunc = valueFunc;
		this.compiledExpression = compiledExpression;
		this.metadata = metadata;
		checkPermissions = (column as ITelerikGridBoundColumn)?.CheckCellPermissions ?? false;
	}

	public TelerikGridEditorForCellBuilder(GridColumnBase<TModel> column, string expressionString, ClassMetadata metadata = null)
	{
		ViewContext = ((ViewComponentBase)column.get_Grid()).get_ViewContext();
		((GridDataCellBuilderBase)this).set_HtmlAttributes((IDictionary<string, object>)((column.get_HtmlAttributes() != null) ? new RouteValueDictionary(column.get_HtmlAttributes()) : null));
		this.expressionString = expressionString;
		this.metadata = metadata;
		checkPermissions = (column as ITelerikGridBoundColumn)?.CheckCellPermissions ?? false;
	}

	protected override void AppendCellContent(IHtmlNode td, object dataItem)
	{
		HtmlHelper<TModel> val = new HtmlHelper<TModel>(ViewContext, (IViewDataContainer)(object)new TelerikGridViewDataContainer<TModel>((TModel)dataItem, ViewContext.get_ViewData()));
		string text = "";
		IPropertyPermissionService propertyPermissionService = (checkPermissions ? Locator.GetService<IPropertyPermissionService>() : null);
		if (Expression != null && ExpressionExtensions.ToMemberExpression((LambdaExpression)Expression) != null)
		{
			if (propertyPermissionService != null)
			{
				IPropertyMetadata propertyMetadata = ModelMetadata.FromLambdaExpression<TModel, TValue>(Expression, val.get_ViewData()).GetPropertyMetadata();
				if (propertyMetadata != null && propertyPermissionService.CheckPropertyPermission(dataItem, propertyMetadata.PropertyUid) == PropertyPermissionType.Hide)
				{
					text = "<div></div>";
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				text = ((HtmlString)(object)val.Editor(Expression, delegate(WebViewAttributes a)
				{
					if (ViewAttributes != null)
					{
						a.CopyFrom(ViewAttributes);
					}
					a.Html.style.width = "100%";
					a.ViewStyle = ModelViewStyle.GridEditor;
					a.AdditionalViewData = new RouteValueDictionary(new
					{
						ShowRequiredLabel = true
					});
				})).ToHtmlString();
			}
		}
		else if (Expression != null)
		{
			TValue val2 = compiledExpression((TModel)dataItem);
			text = ((val2 != null) ? val2.ToString() : "");
		}
		else
		{
			bool flag = false;
			string entityName;
			string exp = CustomPropertyProjection.GetExpressionFromString(expressionString, out entityName);
			if (!string.IsNullOrEmpty(entityName))
			{
				IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				flag = !string.IsNullOrEmpty(entityName) && metadata != null && !serviceNotNull.GetTypeByUid(metadata.Uid).IsAssignableFrom(dataItem.GetType().GetTypeWithoutProxy());
			}
			if (propertyPermissionService != null)
			{
				IPropertyMetadata propertyMetadata2 = ModelMetadata.FromStringExpression(exp, (ViewDataDictionary)(object)val.get_ViewData()).GetPropertyMetadata();
				if (propertyMetadata2 == null)
				{
					propertyMetadata2 = ((dataItem != null) ? ((ClassMetadata)MetadataLoader.LoadMetadata(dataItem.GetType().GetTypeWithoutProxy())) : null)?.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == exp);
				}
				if (propertyMetadata2 != null && propertyPermissionService.CheckPropertyPermission(dataItem, propertyMetadata2.PropertyUid) == PropertyPermissionType.Hide)
				{
					text = "<div></div>";
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				int num = 0;
				if (!flag && (num = exp.LastIndexOf('.')) > 0)
				{
					flag = ModelMetadata.FromStringExpression(exp.Remove(num), (ViewDataDictionary)(object)val.get_ViewData()).get_Model() == null;
				}
				text = (flag ? "" : ((HtmlString)(object)((HtmlHelper)(object)val).Editor(exp, delegate(WebViewAttributes a)
				{
					if (ViewAttributes != null)
					{
						a.CopyFrom(ViewAttributes);
					}
					a.Html.style.width = "100%";
					a.ViewStyle = ModelViewStyle.GridEditor;
					a.AdditionalViewData = new RouteValueDictionary(new
					{
						ShowRequiredLabel = true
					});
				})).ToHtmlString());
				if (!flag)
				{
					while (num > 0)
					{
						string text2 = exp.Remove(num);
						ModelMetadata val3 = ModelMetadata.FromStringExpression(text2 + ".Id", (ViewDataDictionary)(object)val.get_ViewData());
						if (val3.get_Model() != null)
						{
							text += ((HtmlString)(object)InputExtensions.Hidden((HtmlHelper)(object)val, text2 + ".Id", val3.get_Model())).ToHtmlString();
						}
						num = text2.LastIndexOf('.');
					}
				}
			}
		}
		if (valueFunc != null)
		{
			text = (string.IsNullOrEmpty(text) ? "<div></div>" : ((HtmlString)(object)MvcHtmlString.Create($"<a href=\"{valueFunc(dataItem)}\">{text}</a>")).ToHtmlString());
		}
		td.Html(StringExtensions.HasValue(text) ? text : "&nbsp;");
	}
}
