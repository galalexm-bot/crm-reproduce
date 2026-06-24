using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Code;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.CRM.Web.Extensions;

public static class HtmlExtensions
{
	public static MvcHtmlString AddressContent<TModel, TType>(this HtmlHelper<TModel> html, Func<dynamic, object> content, params TType[] types) where TModel : IAddress where TType : struct
	{
		if (!typeof(TType).IsEnum)
		{
			throw new ArgumentException("TType must be an enumerated type");
		}
		Guid? parent = AddressComboBoxItemControl.Parent;
		object[] types2 = AddressComboBoxItemControl.Types;
		ICountry country = AddressComboBoxItemControl.Country;
		AddressComboBoxItemControl.Parent = null;
		AddressComboBoxItemControl.Types = types.Cast<object>().ToArray();
		AddressComboBoxItemControl.Country = html.get_ViewData().get_Model().Country;
		try
		{
			return MvcHtmlString.Create(string.Concat(PartialExtensions.Partial((HtmlHelper)(object)html, "Address/ContentBegin"), content(null)));
		}
		finally
		{
			AddressComboBoxItemControl.Parent = parent;
			AddressComboBoxItemControl.Types = types2;
			AddressComboBoxItemControl.Country = country;
		}
	}

	private static MvcHtmlString AddressItemComboBox(Func<Action<WebViewAttributes>, MvcHtmlString> render, bool showDropDown)
	{
		bool? showDropDownValue = AddressComboBoxItemControl.ShowDropDownValue;
		AddressComboBoxItemControl.ShowDropDownValue = showDropDown;
		try
		{
			return render(delegate(WebViewAttributes a)
			{
				a.TemplateName = "Address/ComboBox";
			});
		}
		finally
		{
			AddressComboBoxItemControl.ShowDropDownValue = showDropDownValue;
		}
	}

	private static MvcHtmlString AddressItemTextBox(Func<Action<WebViewAttributes>, MvcHtmlString> render, int? maxlength = null)
	{
		return render(delegate(WebViewAttributes a)
		{
			a.TemplateName = "Address/TextBox";
			a.AdditionalViewData = new RouteValueDictionary(new { maxlength });
		});
	}

	private static MvcHtmlString AddressItemWithAptType(HtmlHelper html, string expression, MvcHtmlString value)
	{
		return PartialExtensions.Partial(html, "Templates/PropertyRow", (object)new PropertyRowModel
		{
			ViewAttributes = new WebViewAttributes
			{
				LabelStyle = "white-space:unset;"
			},
			ModelName = html.get_ViewContext().get_ViewData().get_TemplateInfo()
				.GetFullHtmlFieldName(expression),
			Caption = html.Editor("AptType", delegate(WebViewAttributes a)
			{
				a.TemplateName = "Address/AptType";
			}),
			Value = value
		});
	}

	public static MvcHtmlString AddressItemComboBox<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, bool showDropDown = false) where TModel : IAddress
	{
		return AddressItemComboBox((Action<WebViewAttributes> action) => html.EditableProperty(expression, action), showDropDown);
	}

	public static MvcHtmlString AddressItemComboBox(this HtmlHelper html, string expression, bool showDropDown = false)
	{
		return AddressItemComboBox((Action<WebViewAttributes> action) => html.EditableProperty(expression, action), showDropDown);
	}

	public static MvcHtmlString AddressItemTextBox<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
	{
		return AddressItemTextBox((Action<WebViewAttributes> action) => html.EditableProperty(expression, action));
	}

	public static MvcHtmlString AddressItemTextBox<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, int maxlength)
	{
		return AddressItemTextBox((Action<WebViewAttributes> action) => html.EditableProperty(expression, action), maxlength);
	}

	public static MvcHtmlString AddressItemTextBox(this HtmlHelper html, string expression, int maxlength)
	{
		return AddressItemTextBox((Action<WebViewAttributes> action) => html.EditableProperty(expression, action), maxlength);
	}

	public static MvcHtmlString AddressItemTextBox(this HtmlHelper html, string expression)
	{
		return AddressItemTextBox((Action<WebViewAttributes> action) => html.EditableProperty(expression, action));
	}

	public static MvcHtmlString AddressItemComboBoxWithAptType<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, bool showDropDown = false)
	{
		return AddressItemWithAptType((HtmlHelper)(object)html, ExpressionHelper.GetExpressionText((LambdaExpression)expression), AddressItemComboBox((Action<WebViewAttributes> action) => html.Editor(expression, action), showDropDown));
	}

	public static MvcHtmlString AddressItemComboBoxWithAptType(this HtmlHelper html, string expression, bool showDropDown = false)
	{
		return AddressItemWithAptType(html, expression, AddressItemComboBox((Action<WebViewAttributes> action) => html.Editor(expression, action), showDropDown));
	}

	public static MvcHtmlString AddressItemTextBoxWithAptType<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
	{
		return AddressItemWithAptType((HtmlHelper)(object)html, ExpressionHelper.GetExpressionText((LambdaExpression)expression), AddressItemTextBox((Action<WebViewAttributes> action) => html.Editor(expression, action)));
	}

	public static MvcHtmlString AddressItemTextBoxWithAptType<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, int maxlength)
	{
		return AddressItemWithAptType((HtmlHelper)(object)html, ExpressionHelper.GetExpressionText((LambdaExpression)expression), AddressItemTextBox((Action<WebViewAttributes> action) => html.Editor(expression, action), maxlength));
	}

	public static MvcHtmlString AddressItemTextBoxWithAptType(this HtmlHelper html, string expression)
	{
		return AddressItemWithAptType(html, expression, AddressItemTextBox((Action<WebViewAttributes> action) => html.Editor(expression, action)));
	}

	public static MvcHtmlString AddressItemTextBoxWithAptType(this HtmlHelper html, string expression, int maxlength)
	{
		return AddressItemWithAptType(html, expression, AddressItemTextBox((Action<WebViewAttributes> action) => html.Editor(expression, action), maxlength));
	}
}
