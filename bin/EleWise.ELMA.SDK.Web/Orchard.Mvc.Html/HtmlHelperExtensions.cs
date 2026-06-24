using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.Extensions;
using Orchard.Localization;
using Orchard.Utility;
using Orchard.Utility.Extensions;

namespace Orchard.Mvc.Html;

public static class HtmlHelperExtensions
{
	private class ViewDataContainer : IViewDataContainer
	{
		public ViewDataDictionary ViewData { get; set; }
	}

	public static string NameOf<T>(this HtmlHelper<T> html, Expression<Action<T>> expression)
	{
		return Reflect.NameOf(html.get_ViewData().get_Model(), expression);
	}

	public static string NameOf<T, TResult>(this HtmlHelper<T> html, Expression<Func<T, TResult>> expression)
	{
		return Reflect.NameOf(html.get_ViewData().get_Model(), expression);
	}

	public static string FieldNameFor<T, TResult>(this HtmlHelper<T> html, Expression<Func<T, TResult>> expression)
	{
		return ((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldName(ExpressionHelper.GetExpressionText((LambdaExpression)expression));
	}

	public static string FieldIdFor<T, TResult>(this HtmlHelper<T> html, Expression<Func<T, TResult>> expression)
	{
		return ((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldId(ExpressionHelper.GetExpressionText((LambdaExpression)expression)).Replace('[', '_')
			.Replace(']', '_');
	}

	public static IHtmlString LabelFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, LocalizedString labelText)
	{
		return html.LabelFor(expression, labelText.ToString());
	}

	public static IHtmlString LabelFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string labelText)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(labelText))
		{
			return (IHtmlString)MvcHtmlString.Empty;
		}
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)expression);
		TagBuilder val = new TagBuilder("label");
		val.get_Attributes().Add("for", ((HtmlHelper)html).get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldId(expressionText));
		val.SetInnerText(labelText);
		return (IHtmlString)MvcHtmlString.Create(val.ToString((TagRenderMode)0));
	}

	public static MvcHtmlString SelectOption<T>(this HtmlHelper html, T currentValue, T optionValue, string text)
	{
		return html.SelectOption(optionValue, object.Equals(optionValue, currentValue), text);
	}

	public static MvcHtmlString SelectOption<T>(this HtmlHelper html, T currentValue, T optionValue, string text, object htmlAttributes)
	{
		return html.SelectOption(optionValue, object.Equals(optionValue, currentValue), text, new RouteValueDictionary(htmlAttributes));
	}

	public static MvcHtmlString SelectOption<T>(this HtmlHelper html, T currentValue, T optionValue, string text, RouteValueDictionary htmlAttributes)
	{
		return html.SelectOption(optionValue, object.Equals(optionValue, currentValue), text, htmlAttributes);
	}

	public static MvcHtmlString SelectOption(this HtmlHelper html, object optionValue, bool selected, string text)
	{
		return html.SelectOption(optionValue, selected, text, null);
	}

	public static MvcHtmlString SelectOption(this HtmlHelper html, object optionValue, bool selected, string text, object htmlAttributes)
	{
		return html.SelectOption(optionValue, selected, text, new RouteValueDictionary(htmlAttributes));
	}

	public static MvcHtmlString SelectOption(this HtmlHelper html, object optionValue, bool selected, string text, RouteValueDictionary htmlAttributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("option");
		if (optionValue != null)
		{
			val.MergeAttribute("value", optionValue.ToString());
		}
		if (selected)
		{
			val.MergeAttribute("selected", "selected");
		}
		val.SetInnerText(text);
		if (htmlAttributes != null)
		{
			val.MergeAttributes<string, object>((IDictionary<string, object>)htmlAttributes);
		}
		return MvcHtmlString.Create(val.ToString((TagRenderMode)0));
	}

	public static WorkContext GetWorkContext(this HtmlHelper html)
	{
		return ((ControllerContext)html.get_ViewContext()).get_RequestContext().GetWorkContext() ?? throw new ApplicationException("The WorkContext cannot be found for the request");
	}

	public static IHtmlString UnorderedList<T>(this HtmlHelper htmlHelper, IEnumerable<T> items, Func<T, int, MvcHtmlString> generateContent, string cssClass)
	{
		return htmlHelper.UnorderedList(items, generateContent, cssClass, null, null);
	}

	public static IHtmlString UnorderedList<T>(this HtmlHelper htmlHelper, IEnumerable<T> items, Func<T, int, MvcHtmlString> generateContent, string cssClass, string itemCssClass, string alternatingItemCssClass)
	{
		return UnorderedList(items, (T t, int i) => (IHtmlString)generateContent(t, i), cssClass, (T t) => itemCssClass, (T t) => alternatingItemCssClass);
	}

	public static IHtmlString UnorderedList<T>(this HtmlHelper htmlHelper, IEnumerable<T> items, Func<T, int, IHtmlString> generateContent, string cssClass)
	{
		return htmlHelper.UnorderedList(items, generateContent, cssClass, null, null);
	}

	public static IHtmlString UnorderedList<T>(this HtmlHelper htmlHelper, IEnumerable<T> items, Func<T, int, IHtmlString> generateContent, string cssClass, string itemCssClass, string alternatingItemCssClass)
	{
		return UnorderedList(items, generateContent, cssClass, (T t) => itemCssClass, (T t) => alternatingItemCssClass);
	}

	private static IHtmlString UnorderedList<T>(IEnumerable<T> items, Func<T, int, IHtmlString> generateContent, string cssClass, Func<T, string> generateItemCssClass, Func<T, string> generateAlternatingItemCssClass)
	{
		if (items == null)
		{
			return new HtmlString(string.Empty);
		}
		items = items.ToArray();
		if (!items.Any())
		{
			return new HtmlString(string.Empty);
		}
		StringBuilder stringBuilder = new StringBuilder(250);
		int num = 0;
		int num2 = items.Count() - 1;
		if (string.IsNullOrEmpty(cssClass))
		{
			stringBuilder.Append("<ul>");
		}
		else
		{
			stringBuilder.Append("<ul class=\"").Append(cssClass).Append("\">");
		}
		foreach (T item in items)
		{
			StringBuilder stringBuilder2 = new StringBuilder(50);
			if (num == 0)
			{
				stringBuilder2.Append("first ");
			}
			if (num == num2)
			{
				stringBuilder2.Append("last ");
			}
			if (generateItemCssClass != null)
			{
				stringBuilder2.Append(generateItemCssClass(item)).Append(" ");
			}
			if (num % 2 != 0 && generateAlternatingItemCssClass != null)
			{
				stringBuilder2.Append(generateAlternatingItemCssClass(item)).Append(" ");
			}
			string value = stringBuilder2.ToString().TrimEnd();
			if (string.IsNullOrWhiteSpace(value))
			{
				stringBuilder.Append("<li>").Append(generateContent(item, num)).Append("</li>");
			}
			else
			{
				stringBuilder.Append("<li class=\"").Append(value).Append("\">")
					.Append(generateContent(item, num))
					.Append("</li>");
			}
			num++;
		}
		stringBuilder.Append("</ul>");
		return new HtmlString(stringBuilder.ToString());
	}

	public static IHtmlString Ellipsize(this HtmlHelper htmlHelper, string text, int characterCount)
	{
		return new HtmlString(htmlHelper.Encode(text.Ellipsize(characterCount)));
	}

	public static IHtmlString Ellipsize(this HtmlHelper htmlHelper, string text, int characterCount, string ellipsis)
	{
		return new HtmlString(htmlHelper.Encode(text.Ellipsize(characterCount, ellipsis)));
	}

	public static MvcHtmlString Excerpt(this HtmlHelper html, string markup, int length)
	{
		return MvcHtmlString.Create(html.Encode(HttpUtility.HtmlDecode(markup.RemoveTags()).Ellipsize(length)));
	}

	public static IHtmlString Link(this HtmlHelper htmlHelper, string linkContents, string href)
	{
		return htmlHelper.Link(linkContents, href, null);
	}

	public static IHtmlString Link(this HtmlHelper htmlHelper, IHtmlString linkContents, string href)
	{
		return htmlHelper.Link(linkContents, href, null);
	}

	public static IHtmlString Link(this HtmlHelper htmlHelper, string linkContents, string href, object htmlAttributes)
	{
		return htmlHelper.Link(linkContents, href, new RouteValueDictionary(htmlAttributes));
	}

	public static IHtmlString Link(this HtmlHelper htmlHelper, string linkContents, string href, IDictionary<string, object> htmlAttributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		TagBuilder val = new TagBuilder("a");
		val.set_InnerHtml(htmlHelper.Encode(linkContents));
		val.MergeAttributes<string, object>(htmlAttributes);
		val.MergeAttribute("href", href);
		return new HtmlString(val.ToString((TagRenderMode)0));
	}

	public static IHtmlString Link(this HtmlHelper htmlHelper, IHtmlString linkContents, string href, IDictionary<string, object> htmlAttributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		TagBuilder val = new TagBuilder("a");
		val.set_InnerHtml(linkContents.ToHtmlString());
		val.MergeAttributes<string, object>(htmlAttributes);
		val.MergeAttribute("href", href);
		return new HtmlString(val.ToString((TagRenderMode)0));
	}

	public static IHtmlString DescriptionLink(this HtmlHelper htmlHelper, string linkContents, string href, IDictionary<string, object> htmlAttributes)
	{
		string text = "description-link";
		if (htmlAttributes != null)
		{
			if (htmlAttributes.ContainsKey("class"))
			{
				text = string.Format("{0} {1}", htmlAttributes["class"], text);
			}
		}
		else
		{
			htmlAttributes = new Dictionary<string, object>();
		}
		htmlAttributes["class"] = text;
		return htmlHelper.Link(linkContents, href, htmlAttributes);
	}

	public static IHtmlString LinkOrDefault(this HtmlHelper htmlHelper, string linkContents, string href)
	{
		return htmlHelper.LinkOrDefault(linkContents, href, null);
	}

	public static IHtmlString LinkOrDefault(this HtmlHelper htmlHelper, string linkContents, string href, object htmlAttributes)
	{
		return htmlHelper.LinkOrDefault(linkContents, href, new RouteValueDictionary(htmlAttributes));
	}

	public static IHtmlString LinkOrDefault(this HtmlHelper htmlHelper, string linkContents, string href, IDictionary<string, object> htmlAttributes)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(href))
		{
			TagBuilder val = new TagBuilder("span");
			val.set_InnerHtml(htmlHelper.Encode(linkContents));
			return new HtmlString(val.ToString((TagRenderMode)0));
		}
		return htmlHelper.Link(linkContents, href, htmlAttributes);
	}

	public static IHtmlString DescriptionLinkOrDefault(this HtmlHelper htmlHelper, string linkContents, string href, IDictionary<string, object> htmlAttributes)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(href))
		{
			TagBuilder val = new TagBuilder("span");
			val.set_InnerHtml(htmlHelper.Encode(linkContents));
			val.MergeAttribute("class", "description-link");
			return new HtmlString(val.ToString((TagRenderMode)0));
		}
		return htmlHelper.DescriptionLink(linkContents, href, htmlAttributes);
	}

	public static IHtmlString Hint(this HtmlHelper htmlHelper, LocalizedString text)
	{
		return htmlHelper.Hint(text, (object)null);
	}

	public static IHtmlString Hint(this HtmlHelper htmlHelper, LocalizedString text, object htmlAttributes)
	{
		return htmlHelper.Hint(text, (htmlAttributes != null) ? new RouteValueDictionary(htmlAttributes) : null);
	}

	public static IHtmlString Hint(this HtmlHelper htmlHelper, LocalizedString text, IDictionary<string, object> htmlAttributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("span");
		val.set_InnerHtml(text.Text);
		TagBuilder val2 = val;
		if (htmlAttributes != null)
		{
			val2.MergeAttributes<string, object>(htmlAttributes);
		}
		val2.AddCssClass("hint");
		return new HtmlString(val2.ToString((TagRenderMode)0));
	}

	public static MvcForm BeginFormAntiForgeryPost(this HtmlHelper htmlHelper)
	{
		return htmlHelper.BeginFormAntiForgeryPost(((ControllerContext)htmlHelper.get_ViewContext()).get_HttpContext().Request.Url.PathAndQuery, (FormMethod)1, new RouteValueDictionary());
	}

	public static MvcForm BeginFormAntiForgeryPost(this HtmlHelper htmlHelper, string formAction)
	{
		return htmlHelper.BeginFormAntiForgeryPost(formAction, (FormMethod)1, new RouteValueDictionary());
	}

	public static MvcForm BeginFormAntiForgeryPost(this HtmlHelper htmlHelper, string formAction, FormMethod formMethod)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.BeginFormAntiForgeryPost(formAction, formMethod, new RouteValueDictionary());
	}

	public static MvcForm BeginFormAntiForgeryPost(this HtmlHelper htmlHelper, string formAction, FormMethod formMethod, object htmlAttributes)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.BeginFormAntiForgeryPost(formAction, formMethod, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcForm BeginFormAntiForgeryPost(this HtmlHelper htmlHelper, string formAction, FormMethod formMethod, IDictionary<string, object> htmlAttributes)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		HttpResponseBase response = ((ControllerContext)htmlHelper.get_ViewContext()).get_HttpContext().Response;
		response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1.0));
		response.Cache.SetValidUntilExpires(validUntilExpires: false);
		response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
		response.Cache.SetCacheability(HttpCacheability.NoCache);
		response.Cache.SetNoStore();
		TagBuilder val = new TagBuilder("form");
		val.MergeAttributes<string, object>(htmlAttributes);
		val.MergeAttribute("action", formAction);
		val.MergeAttribute("method", HtmlHelper.GetFormMethodString(formMethod), true);
		htmlHelper.get_ViewContext().get_Writer().Write(val.ToString((TagRenderMode)1));
		return (MvcForm)(object)new MvcFormAntiForgeryPost(htmlHelper);
	}

	public static MvcHtmlString AntiForgeryTokenOrchard(this HtmlHelper htmlHelper)
	{
		try
		{
			return htmlHelper.AntiForgeryToken();
		}
		catch (HttpAntiForgeryException)
		{
			string antiForgeryTokenName = htmlHelper.GetAntiForgeryTokenName();
			((ControllerContext)htmlHelper.get_ViewContext()).get_HttpContext().Request.Cookies.Remove(antiForgeryTokenName);
			return htmlHelper.AntiForgeryToken();
		}
	}

	private static string GetAntiForgeryTokenName(this HtmlHelper htmlHelper)
	{
		string applicationPath = ((ControllerContext)htmlHelper.get_ViewContext()).get_HttpContext().Request.ApplicationPath;
		if (string.IsNullOrEmpty(applicationPath))
		{
			return "__RequestVerificationToken";
		}
		return "__RequestVerificationToken_" + Base64EncodeForCookieName(applicationPath);
	}

	private static string Base64EncodeForCookieName(string s)
	{
		return s.ToBase64String().Replace('+', '.').Replace('/', '-')
			.Replace('=', '_');
	}

	public static IHtmlString AntiForgeryTokenValueOrchardLink(this HtmlHelper htmlHelper, string linkContents, string href)
	{
		return htmlHelper.AntiForgeryTokenValueOrchardLink(linkContents, href, (object)null);
	}

	public static IHtmlString AntiForgeryTokenValueOrchardLink(this HtmlHelper htmlHelper, string linkContents, string href, object htmlAttributes)
	{
		return htmlHelper.AntiForgeryTokenValueOrchardLink(linkContents, href, new RouteValueDictionary(htmlAttributes));
	}

	public static IHtmlString AntiForgeryTokenValueOrchardLink(this HtmlHelper htmlHelper, string linkContents, string href, IDictionary<string, object> htmlAttributes)
	{
		return htmlHelper.Link(linkContents, htmlHelper.AntiForgeryTokenGetUrl(href).ToString(), htmlAttributes);
	}

	public static IHtmlString AntiForgeryTokenGetUrl(this HtmlHelper htmlHelper, string baseUrl)
	{
		return new HtmlString(string.Format("{0}{1}__RequestVerificationToken={2}", baseUrl, (baseUrl.IndexOf('?') > -1) ? "&" : "?", ((ControllerContext)htmlHelper.get_ViewContext()).get_HttpContext().Server.UrlEncode(htmlHelper.AntiForgeryTokenValueOrchard().ToString())));
	}

	public static IHtmlString AntiForgeryTokenValueOrchard(this HtmlHelper htmlHelper)
	{
		string text = ((HtmlString)(object)htmlHelper.AntiForgeryTokenOrchard()).ToHtmlString();
		int num = text.IndexOf("value=\"") + 7;
		int num2 = text.IndexOf("\"", num);
		return new HtmlString(text.Substring(num, num2 - num));
	}

	public static HtmlHelper<TModel> HtmlHelperFor<TModel>(this HtmlHelper htmlHelper)
	{
		return htmlHelper.HtmlHelperFor(default(TModel));
	}

	public static HtmlHelper<TModel> HtmlHelperFor<TModel>(this HtmlHelper htmlHelper, TModel model)
	{
		return htmlHelper.HtmlHelperFor(model, null);
	}

	public static HtmlHelper<TModel> HtmlHelperFor<TModel>(this HtmlHelper htmlHelper, TModel model, string htmlFieldPrefix)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		IViewDataContainer val = CreateViewDataContainer(htmlHelper.get_ViewData(), model);
		TemplateInfo templateInfo = val.get_ViewData().get_TemplateInfo();
		if (!string.IsNullOrEmpty(htmlFieldPrefix))
		{
			templateInfo.set_HtmlFieldPrefix(templateInfo.GetFullHtmlFieldName(htmlFieldPrefix));
		}
		ViewContext viewContext = htmlHelper.get_ViewContext();
		return new HtmlHelper<TModel>(new ViewContext(((ControllerContext)viewContext).get_Controller().get_ControllerContext(), viewContext.get_View(), val.get_ViewData(), viewContext.get_TempData(), viewContext.get_Writer()), val, htmlHelper.get_RouteCollection());
	}

	private static IViewDataContainer CreateViewDataContainer(ViewDataDictionary viewData, object model)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(viewData);
		val.set_Model(model);
		ViewDataDictionary val2 = val;
		TemplateInfo val3 = new TemplateInfo();
		val3.set_HtmlFieldPrefix(val2.get_TemplateInfo().get_HtmlFieldPrefix());
		val2.set_TemplateInfo(val3);
		return (IViewDataContainer)(object)new ViewDataContainer
		{
			ViewData = val2
		};
	}
}
