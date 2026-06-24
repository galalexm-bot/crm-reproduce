using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class ButtonsAndLinkExtensions
{
	public static MvcHtmlString SubmitButton(this HtmlHelper helper, string name)
	{
		return helper.SubmitButton(name, null, null);
	}

	public static MvcHtmlString SubmitButton(this HtmlHelper helper, string name, string buttonText)
	{
		return helper.SubmitButton(name, buttonText, null);
	}

	public static MvcHtmlString SubmitButton(this HtmlHelper helper)
	{
		return helper.SubmitButton(null, null, null);
	}

	public static MvcHtmlString SubmitButton(this HtmlHelper helper, string name, string buttonText, object htmlAttributes)
	{
		return helper.SubmitButton(name, buttonText, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString SubmitButton(this HtmlHelper helper, string name, string buttonText, IDictionary<string, object> htmlAttributes)
	{
		return MvcHtmlString.Create(ButtonBuilder.SubmitButton(name, buttonText, htmlAttributes).ToString((TagRenderMode)3));
	}

	public static MvcHtmlString SubmitImage(this HtmlHelper helper, string name, string imageSrc)
	{
		return helper.SubmitImage(name, imageSrc, null);
	}

	public static MvcHtmlString SubmitImage(this HtmlHelper helper, string name, string imageSrc, object htmlAttributes)
	{
		return helper.SubmitImage(name, imageSrc, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString SubmitImage(this HtmlHelper helper, string name, string imageSrc, IDictionary<string, object> htmlAttributes)
	{
		if (imageSrc == null)
		{
			throw new ArgumentNullException("imageSrc");
		}
		string sourceUrl = UrlHelper.GenerateContentUrl(imageSrc, ((ControllerContext)helper.get_ViewContext()).get_HttpContext());
		return MvcHtmlString.Create(ButtonBuilder.SubmitImage(name, sourceUrl, htmlAttributes).ToString((TagRenderMode)3));
	}

	public static MvcHtmlString Button(this HtmlHelper helper, string name, string buttonText, HtmlButtonType buttonType)
	{
		return helper.Button(name, buttonText, buttonType, null, null);
	}

	public static MvcHtmlString Button(this HtmlHelper helper, string name, string buttonText, HtmlButtonType buttonType, string onClickMethod)
	{
		return helper.Button(name, buttonText, buttonType, onClickMethod, null);
	}

	public static MvcHtmlString Button(this HtmlHelper helper, string name, string buttonText, HtmlButtonType buttonType, string onClickMethod, object htmlAttributes)
	{
		return helper.Button(name, buttonText, buttonType, onClickMethod, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	public static MvcHtmlString Button(this HtmlHelper helper, string name, string buttonText, HtmlButtonType buttonType, string onClickMethod, IDictionary<string, object> htmlAttributes)
	{
		return MvcHtmlString.Create(ButtonBuilder.Button(name, buttonText, buttonType, onClickMethod, htmlAttributes).ToString((TagRenderMode)0));
	}
}
