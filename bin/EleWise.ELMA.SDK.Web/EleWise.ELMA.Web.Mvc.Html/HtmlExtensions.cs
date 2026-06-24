using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Components.Previews;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.Buttons;
using EleWise.ELMA.Web.Mvc.Html.Forms;
using EleWise.ELMA.Web.Mvc.Html.Tooltips;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Models.Inputs;
using EleWise.ELMA.Web.Mvc.Models.Previews;
using EleWise.ELMA.Web.Mvc.Models.Translate;
using EleWise.ELMA.Web.Mvc.Telerik.Grids;
using EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;
using EleWise.ELMA.Web.Mvc.Util;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class HtmlExtensions
{
	public const string UI = "UI/";

	public const string GLOBALFORMID = "GlobalForm";

	private const string MobileAppInterfaceQueryValue = "mobile";

	public static LabeledContainerRenderer LabeledContainer(this HtmlHelper html, string label, object attributes)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		return html.LabeledContainer(new MvcHtmlString(label), attributes);
	}

	public static LabeledContainerRenderer LabeledContainer(this HtmlHelper html, string label)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return html.LabeledContainer(new MvcHtmlString(label));
	}

	public static LabeledContainerRenderer LabeledContainer(this HtmlHelper html)
	{
		return html.LabeledContainer(MvcHtmlString.Empty);
	}

	public static LabeledContainerRenderer LabeledContainer(this HtmlHelper html, MvcHtmlString label)
	{
		return html.LabeledContainer(label, null);
	}

	public static LabeledContainerRenderer LabeledContainer(this HtmlHelper html, MvcHtmlString label, object attributes)
	{
		LabeledContainerRenderer labeledContainerRenderer = new LabeledContainerRenderer(new LabeledContainerModel
		{
			Label = label,
			Attributes = new RouteValueDictionary(attributes)
		}, html);
		labeledContainerRenderer.RenderStart();
		return labeledContainerRenderer;
	}

	public static string GetSystemGateway(this HtmlHelper html)
	{
		return Locator.GetServiceNotNull<IFileGatewayService>().SystemGateway;
	}

	public static string GetClosestGateway(this HtmlHelper html)
	{
		return Locator.GetServiceNotNull<IFileGatewayService>().GetClosestGateway();
	}

	public static string GetUploadUrl(this HtmlHelper html)
	{
		IUploadUrlGenerator service = Locator.GetService<IUploadUrlGenerator>();
		if (service == null)
		{
			return html.Url().Action("UploadAjax", "BinaryFiles", (object)new
			{
				area = "EleWise.ELMA.SDK.Web"
			});
		}
		return service.GetClosestBaseUploadUrl().AbsoluteUri;
	}

	private static MvcHtmlString MetadataImageAction(HtmlHelper html, Guid uid, string imageName, int size, object htmlAttributes, MetadataImageFormat imageType)
	{
		return ChildActionExtensions.Action(html, "MetadataImage", "Images", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			uid = uid,
			image = imageName,
			size = size,
			htmlAttributes = htmlAttributes,
			imageType = imageType
		});
	}

	private static MvcHtmlString MetadataEnumImageAction(HtmlHelper html, Guid uid, object enumValue, string imageName, int size, object htmlAttributes, MetadataImageFormat imageType)
	{
		return ChildActionExtensions.Action(html, "MetadataImageEnum", "Images", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			uid = uid,
			enumValue = enumValue,
			image = imageName,
			size = size,
			htmlAttributes = htmlAttributes,
			imageType = imageType
		});
	}

	[NotNull]
	public static UrlHelper Url(this HtmlHelper html)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		return new UrlHelper(((ControllerContext)html.get_ViewContext()).get_RequestContext());
	}

	public static string Path(this HtmlHelper html)
	{
		HttpRequestBase request = ((ControllerContext)html.get_ViewContext()).get_RequestContext().HttpContext.Request;
		if (!(request.Url != null))
		{
			if (request.RawUrl.IndexOf("?") != -1)
			{
				return request.RawUrl.Substring(0, request.RawUrl.IndexOf("?"));
			}
			return request.RawUrl;
		}
		return request.Url.AbsolutePath;
	}

	public static MvcHtmlString BuildUrl(this HtmlHelper helper, string url, Dictionary<string, string> @params)
	{
		return helper.BuildUrl(url, @params, asJsString: false, absolute: false);
	}

	public static MvcHtmlString BuildUrl(this HtmlHelper helper, string url, Dictionary<string, string> @params, bool asJsString)
	{
		return helper.BuildUrl(url, @params, asJsString, absolute: false);
	}

	public static MvcHtmlString BuildUrl(this HtmlHelper helper, string url, Dictionary<string, string> @params, bool asJsString, bool absolute)
	{
		return MvcHtmlString.Create(helper.Url().Build(url, @params, asJsString, absolute));
	}

	public static string GetFullHtmlFieldId(this HtmlHelper html, string id)
	{
		return html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId(id);
	}

	public static string GetFullHtmlFieldName(this HtmlHelper html, string name)
	{
		return html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldName(name);
	}

	public static MvcHtmlString Image(this HtmlHelper helper, string imageRelativeUrl)
	{
		return helper.Image(imageRelativeUrl, (string)null, (IDictionary<string, object>)null);
	}

	public static MvcHtmlString Image(this HtmlHelper helper, string imageRelativeUrl, string alt)
	{
		return helper.Image(imageRelativeUrl, alt, (IDictionary<string, object>)null);
	}

	public static MvcHtmlString Image(this HtmlHelper html, string imageRelativeUrl, string alt, string style)
	{
		return html.Image(imageRelativeUrl, alt, style, null);
	}

	public static MvcHtmlString Image(this HtmlHelper helper, string imageRelativeUrl, string alt, string style, object htmlAttributes)
	{
		return helper.Image(imageRelativeUrl, alt, style, UIExtensions.ObjectToDictionary(htmlAttributes));
	}

	public static MvcHtmlString Image(this HtmlHelper helper, string imageRelativeUrl, string alt, object htmlAttributes)
	{
		return helper.Image(imageRelativeUrl, alt, UIExtensions.ObjectToDictionary(htmlAttributes));
	}

	public static MvcHtmlString Image(this HtmlHelper helper, string imageRelativeUrl, object htmlAttributes)
	{
		return helper.Image(imageRelativeUrl, null, UIExtensions.ObjectToDictionary(htmlAttributes));
	}

	public static MvcHtmlString Image(this HtmlHelper helper, string imageRelativeUrl, IDictionary<string, object> htmlAttributes)
	{
		return helper.Image(imageRelativeUrl, null, htmlAttributes);
	}

	public static MvcHtmlString Image(this HtmlHelper helper, string imageRelativeUrl, string alt, IDictionary<string, object> htmlAttributes)
	{
		return helper.Image(imageRelativeUrl, alt, null, htmlAttributes);
	}

	public static MvcHtmlString Image(this HtmlHelper helper, string imageRelativeUrl, string alt, string style, IDictionary<string, object> htmlAttributes)
	{
		if (string.IsNullOrEmpty(imageRelativeUrl))
		{
			throw new ArgumentException("Common_NullOrEmpty", "imageRelativeUrl");
		}
		return MvcHtmlString.Create(Image(UrlHelper.GenerateContentUrl(helper.Url().Image(imageRelativeUrl), ((ControllerContext)helper.get_ViewContext()).get_HttpContext()), alt, style, htmlAttributes).ToString((TagRenderMode)3));
	}

	public static string Image(UrlHelper url, string imageUrl, string alt = null, string style = null, object htmlAttributes = null)
	{
		return Image(url, imageUrl, alt, style, UIExtensions.ObjectToDictionary(htmlAttributes));
	}

	public static string Image(UrlHelper url, string imageUrl, string alt, string style, IDictionary<string, object> htmlAttributes)
	{
		return Image(url.Image(imageUrl), alt, style, UIExtensions.ObjectToDictionary(htmlAttributes)).ToString((TagRenderMode)3);
	}

	public static string Image(string fullImageUrl, object htmlAttributes)
	{
		return Image(fullImageUrl, "", "", UIExtensions.ObjectToDictionary(htmlAttributes)).ToString((TagRenderMode)3);
	}

	public static TagBuilder Image(string imageUrl, string alt, string style, IDictionary<string, object> htmlAttributes)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		if (string.IsNullOrEmpty(imageUrl))
		{
			throw new ArgumentException("Common_NullOrEmpty", "imageUrl");
		}
		TagBuilder val = new TagBuilder("img");
		if (!string.IsNullOrEmpty(imageUrl))
		{
			val.MergeAttribute("src", imageUrl);
		}
		if (!string.IsNullOrEmpty(alt))
		{
			val.MergeAttribute("title", alt);
		}
		if (!string.IsNullOrEmpty(style))
		{
			val.MergeAttribute("style", style);
		}
		val.MergeAttributes<string, object>(htmlAttributes, true);
		if (val.get_Attributes().ContainsKey("alt") && !val.get_Attributes().ContainsKey("title"))
		{
			val.MergeAttribute("title", val.get_Attributes()["alt"] ?? string.Empty);
		}
		if (IconPack.HasSvgExtension(imageUrl))
		{
			val.AddCssClass("svg-element");
			val.get_Attributes()["height"] = "24";
			val.get_Attributes()["width"] = "24";
		}
		if (IconPack.IsMetadataIcon(imageUrl))
		{
			val.AddCssClass(UIConstants.MetadataIconClass);
		}
		return val;
	}

	public static MvcHtmlString SvgImage(this HtmlHelper html, string imageUrl, object htmlAttributes)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		if (!IconPack.HasSvgExtension(imageUrl))
		{
			return html.Image(imageUrl, "", htmlAttributes);
		}
		imageUrl = html.Url().Image(imageUrl);
		string content = SvgService.GetContent(imageUrl, resetColor: true);
		if (content.IsNullOrEmpty())
		{
			return MvcHtmlString.Empty;
		}
		TagBuilder val = new TagBuilder("i");
		if (htmlAttributes != null)
		{
			if (htmlAttributes is IDictionary<string, object> dictionary)
			{
				val.MergeAttributes<string, object>(dictionary, true);
			}
			else
			{
				val.MergeAttributes<string, object>(UIExtensions.ObjectToDictionary(htmlAttributes), true);
			}
		}
		val.get_Attributes()["data-source"] = imageUrl;
		val.AddCssClass("svg-element");
		val.set_InnerHtml(content);
		return MvcHtmlString.Create(((object)val).ToString());
	}

	public static MvcHtmlString SvgImage(this HtmlHelper html, string imageUrl)
	{
		return html.SvgImage(imageUrl, null);
	}

	public static MvcHtmlString RotatableArrow(this HtmlHelper html, bool isRotated, object htmlAttributes = null)
	{
		return html.RotatableIcon("#arrow_down.svg", isRotated, htmlAttributes);
	}

	public static MvcHtmlString RotatableIcon(this HtmlHelper html, string icon, bool isRotated, object htmlAttributes)
	{
		return html.RotatableIcon(icon, isRotated, 180, htmlAttributes);
	}

	public static MvcHtmlString RotatableIcon(this HtmlHelper html, string icon, bool isRotated, int rotateDeg, object htmlAttributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("div");
		if (htmlAttributes != null)
		{
			if (htmlAttributes is IDictionary<string, object> dictionary)
			{
				val.MergeAttributes<string, object>(dictionary, true);
			}
			else
			{
				val.MergeAttributes<string, object>(UIExtensions.ObjectToDictionary(htmlAttributes), true);
			}
		}
		string style = "";
		val.AddCssClass((isRotated ? "isRotated" : "") + " rotatable-icon");
		if (rotateDeg != 0)
		{
			string arg = $"rotate({rotateDeg}deg);";
			style = string.Format("-webkit-transform:{0} -ms-transform:{0} transform:{0}", arg);
		}
		MvcHtmlString val2 = html.SvgImage(icon, new { style });
		val.set_InnerHtml(((object)val2).ToString());
		return MvcHtmlString.Create(((object)val).ToString());
	}

	public static MvcHtmlString TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, string prefix, Expression<Func<TModel, TProperty>> expression)
	{
		return htmlHelper.TextBoxFor(prefix, expression, null);
	}

	public static MvcHtmlString TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, string prefix, Expression<Func<TModel, TProperty>> expression, object htmlAttributes)
	{
		return htmlHelper.TextBoxFor(prefix, expression, UIExtensions.ObjectToDictionary(htmlAttributes));
	}

	public static MvcHtmlString TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, string prefix, Expression<Func<TModel, TProperty>> expression, IDictionary<string, object> htmlAttributes)
	{
		return InputExtensions.TextBox((HtmlHelper)(object)htmlHelper, $"{prefix}.{ExpressionHelper.GetExpressionText((LambdaExpression)expression)}", ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.get_ViewData()).get_Model(), htmlAttributes);
	}

	public static MvcHtmlString ImageLink(this HtmlHelper html, string imageUrl, string text, string href, object imgHtmlAttributes = null, object anchorHtmlAttributes = null, string title = "", bool textRight = true)
	{
		return MvcHtmlString.Create(html.Button(imageUrl, text).Url(href).Attributes(anchorHtmlAttributes)
			.IconAttributes(imgHtmlAttributes)
			.AsLink()
			.ToHtmlString());
	}

	[Obsolete("Использовать ImageLink с HtmlHelper")]
	public static string ImageLink(UrlHelper url, string imageUrl, string text, string href, object imgHtmlAttributes = null, object anchorHtmlAttributes = null, string title = "", bool textRight = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		string value = ((href.IndexOf("javascript:") == 0) ? href.Substring("javascript:".Length) : "");
		TagBuilder val = new TagBuilder("a");
		if (string.IsNullOrWhiteSpace(value))
		{
			val.AddCssClass("image-link");
			val.get_Attributes()["href"] = href;
		}
		else
		{
			val.get_Attributes()["href"] = "#";
			val.get_Attributes()["onclick"] = value;
		}
		if (anchorHtmlAttributes != null)
		{
			IDictionary<string, object> dictionary = UIExtensions.ObjectToDictionary(anchorHtmlAttributes);
			val.MergeAttributes<string, object>(dictionary, true);
		}
		val.AddCssClass("image-button");
		val.set_InnerHtml(Image(url, imageUrl, null, null, new Dictionary<string, object> { { "style", "vertical-align: middle;" } }));
		if (!string.IsNullOrEmpty(title))
		{
			val.get_Attributes()["tooltiptext"] = HttpUtility.HtmlAttributeEncode(title);
		}
		if (!string.IsNullOrEmpty(text))
		{
			val.AddCssClass("hasText");
			TagBuilder val2 = new TagBuilder("span");
			val2.SetInnerText(text);
			if (textRight)
			{
				val2.AddCssClass("right-text");
				val.set_InnerHtml(val.get_InnerHtml() + ((object)val2).ToString());
			}
			else
			{
				val2.AddCssClass("left-text");
				val.set_InnerHtml(((object)val2).ToString() + val.get_InnerHtml());
			}
		}
		return ((object)val).ToString();
	}

	public static MvcHtmlString ImageHighlightLink(this HtmlHelper html, string imageUrl, string highlightText, string href, object imgHtmlAttributes = null, object anchorHtmlAttributes = null, string title = "", string openTag = null, string closeTag = null)
	{
		IDictionary<string, object> dictionary = UIExtensions.ObjectToDictionary(imgHtmlAttributes);
		dictionary.Add("title", title);
		return MvcHtmlString.Create(html.Button(imageUrl, HighlightText(highlightText)).Url(href).Attributes(anchorHtmlAttributes)
			.IconAttributes(dictionary)
			.AsLink()
			.ToHtmlString());
	}

	[Obsolete("Использовать ImageHighlightLink с HtmlHelper")]
	public static string ImageHighlightLink(UrlHelper url, string imageUrl, string highlightText, string href, object imgHtmlAttributes = null, object anchorHtmlAttributes = null, string title = "", string openTag = null, string closeTag = null)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("a");
		val.get_Attributes()["href"] = href;
		val.AddCssClass("image-button");
		val.AddCssClass("image-link");
		if (anchorHtmlAttributes != null)
		{
			IDictionary<string, object> dictionary = UIExtensions.ObjectToDictionary(anchorHtmlAttributes);
			val.MergeAttributes<string, object>(dictionary, true);
		}
		TagBuilder val2 = new TagBuilder("img");
		val2.get_Attributes()["src"] = url.Image(imageUrl);
		val2.get_Attributes()["style"] = "vertical-align: middle;";
		if (imgHtmlAttributes != null)
		{
			IDictionary<string, object> dictionary2 = UIExtensions.ObjectToDictionary(imgHtmlAttributes);
			val2.MergeAttributes<string, object>(dictionary2, true);
		}
		if (!string.IsNullOrEmpty(title))
		{
			val2.get_Attributes()["alt"] = HttpUtility.HtmlAttributeEncode(title);
			val.get_Attributes()["title"] = HttpUtility.HtmlAttributeEncode(title);
		}
		string text = ((!string.IsNullOrEmpty(highlightText)) ? HighlightText(highlightText) : "");
		if (!string.IsNullOrWhiteSpace(text))
		{
			val.AddCssClass("hasText");
			val2.get_Attributes()["style"] = "margin-right: 5px;";
		}
		val.set_InnerHtml(((object)val2).ToString() + text);
		return ((object)val).ToString();
	}

	public static string HighlightText(string highlightText)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (string.IsNullOrEmpty(highlightText))
		{
			return string.Empty;
		}
		string text = string.Empty;
		foreach (KeyValuePair<bool, string> item in HighlightsHelper.HighlightToHtml(highlightText))
		{
			TagBuilder val = new TagBuilder("span");
			val.SetInnerText(WebUtility.HtmlDecode(item.Value));
			val.get_Attributes()["style"] = "vertical-align: middle;";
			if (item.Key)
			{
				val.AddCssClass("highlight-text");
			}
			text += ((object)val).ToString();
		}
		return text;
	}

	public static ActionButtonBuilder ImageButton(this HtmlHelper html, string imageUrl)
	{
		return html.Button().IconUrl(imageUrl).Circle()
			.NoBorder();
	}

	public static MvcHtmlString ImageButton(this HtmlHelper html, string imageUrl, string alt, string clickAction, object imgHtmlAttributes = null, object anchorHtmlAttributes = null, string text = "", bool textRight = true)
	{
		return MvcHtmlString.Create(html.Button(imageUrl, text).IconAttributes(imgHtmlAttributes).Attributes(anchorHtmlAttributes)
			.Click(clickAction)
			.ToHtmlString());
	}

	[Obsolete("Использовать ImageButton с HtmlHelper")]
	public static string ImageButton(UrlHelper url, string imageUrl, string alt, string clickAction, object imgHtmlAttributes = null, object anchorHtmlAttributes = null, string text = "", bool textRight = true)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("a");
		val.get_Attributes()["href"] = "javascript:void(0)";
		val.get_Attributes()["onclick"] = clickAction;
		IDictionary<string, object> dictionary = UIExtensions.ObjectToDictionary(anchorHtmlAttributes);
		val.MergeAttributes<string, object>(dictionary, true);
		val.AddCssClass("image-button");
		IDictionary<string, object> dictionary2 = UIExtensions.ObjectToDictionary(imgHtmlAttributes);
		if (!string.IsNullOrEmpty(alt))
		{
			dictionary2.Add("alt", HttpUtility.HtmlAttributeEncode(alt));
			dictionary2.Add("title", HttpUtility.HtmlAttributeEncode(alt));
		}
		val.set_InnerHtml(Image(url, imageUrl, alt, "", dictionary2));
		if (!string.IsNullOrEmpty(text))
		{
			val.AddCssClass("hasText");
			TagBuilder val2 = new TagBuilder("span");
			val2.SetInnerText(text);
			if (textRight)
			{
				val2.AddCssClass("right-text");
				val.set_InnerHtml(val.get_InnerHtml() + ((object)val2).ToString());
			}
			else
			{
				val2.AddCssClass("left-text");
				val.set_InnerHtml(((object)val2).ToString() + val.get_InnerHtml());
			}
		}
		else
		{
			val.AddCssClass("no-text");
		}
		return ((object)val).ToString();
	}

	public static MvcHtmlString ImageSubmit(this HtmlHelper html, string iconUrl, string text = "", string script = "", Guid? uid = null)
	{
		if (!uid.HasValue)
		{
			uid = Guid.NewGuid();
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		routeValueDictionary.Add("id", uid);
		return MvcHtmlString.Create(html.Button().Click(script).IconUrl(iconUrl)
			.Attributes(routeValueDictionary)
			.Text(text)
			.ToHtmlString());
	}

	public static MvcHtmlString MetadataImage(this HtmlHelper html, Guid uid, string imageName, int size, object htmlAttributes)
	{
		return MetadataImageAction(html, uid, imageName, size, htmlAttributes, MetadataImageFormat.Image);
	}

	public static MvcHtmlString MetadataImage(this HtmlHelper html, Guid uid)
	{
		return html.MetadataImage(uid, "", 16, null);
	}

	public static MvcHtmlString MetadataImage(this HtmlHelper html, Guid uid, object htmlAttributes)
	{
		return html.MetadataImage(uid, "", 16, htmlAttributes);
	}

	public static MvcHtmlString MetadataMarkupImage(this HtmlHelper html, Guid uid, string imageName, int size, object htmlAttributes)
	{
		return MetadataImageAction(html, uid, imageName, size, htmlAttributes, MetadataImageFormat.Markup);
	}

	public static MvcHtmlString MetadataMarkupImage(this HtmlHelper html, Guid uid)
	{
		return html.MetadataMarkupImage(uid, "", 16, null);
	}

	public static MvcHtmlString MetadataMarkupImage(this HtmlHelper html, Guid uid, object htmlAttributes)
	{
		return html.MetadataMarkupImage(uid, "", 16, htmlAttributes);
	}

	public static MvcHtmlString MetadataMarkupEnumImage(this HtmlHelper html, object enumValue, object htmlAttributes)
	{
		Guid uid = MetadataLoader.LoadMetadata(enumValue.GetType()).Uid;
		return MetadataEnumImageAction(html, uid, enumValue, "", 16, htmlAttributes, MetadataImageFormat.Markup);
	}

	public static MvcHtmlString Link(this HtmlHelper html, string url, string rel, string type, object htmlAttributes)
	{
		return html.Url().Link(url, rel, type, htmlAttributes);
	}

	public static MvcHtmlString Link(this HtmlHelper html, string url, string rel, string type)
	{
		return html.Link(url, rel, type, null);
	}

	public static MvcHtmlString LinkCss(this HtmlHelper html, string url)
	{
		return html.LinkCss(url, useHashCode: false);
	}

	public static MvcHtmlString LinkCss(this HtmlHelper html, string url, bool useHashCode)
	{
		if (!useHashCode)
		{
			return html.Link(url, "stylesheet", "text/css", null);
		}
		return html.Link(CSSStylesCachedMergerService.Instance.GetSingleFileContentUrl(html, url), "stylesheet", "text/css", null);
	}

	public static MvcHtmlString LinkLess([NotNull] this HtmlHelper htmlHelper, [NotNull] string src, [NotNull] string zone)
	{
		return htmlHelper.LinkLess(src, zone, null);
	}

	public static MvcHtmlString LinkLess([NotNull] this HtmlHelper htmlHelper, [NotNull] string src, [NotNull] string zone, object htmlAttributes)
	{
		return htmlHelper.Url().LinkLess(src, zone, htmlAttributes);
	}

	public static MvcHtmlString Script(this HtmlHelper html, string src, string type, string text, object htmlAttributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("script");
		IDictionary<string, object> dictionary = UIExtensions.ObjectToDictionary(htmlAttributes);
		if (!src.IsNullOrEmpty())
		{
			val.get_Attributes()["src"] = html.Url().Content(src);
		}
		if (!text.IsNullOrEmpty())
		{
			val.set_InnerHtml(text);
		}
		if (!type.IsNullOrEmpty())
		{
			val.get_Attributes()["type"] = type;
		}
		val.MergeAttributes<string, object>(dictionary, true);
		return MvcHtmlString.Create(((object)val).ToString());
	}

	public static MvcHtmlString Script(this HtmlHelper html, string src, string type, string text)
	{
		return html.Script(src, type, text, null);
	}

	public static MvcHtmlString Script(this HtmlHelper html, string src, string type = "text/javascript")
	{
		return html.Script(src, type, null, null);
	}

	public static MvcHtmlString ClientIdFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
	{
		return MvcHtmlString.Create(((HtmlHelper)htmlHelper).get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldId(ExpressionHelper.GetExpressionText((LambdaExpression)expression)));
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper)
	{
		return htmlHelper.ELMAForm(null);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, bool confirmOnClose)
	{
		return htmlHelper.ELMAForm(null, confirmOnClose);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, object routeValues)
	{
		return htmlHelper.ELMAForm(null, null, new RouteValueDictionary(routeValues));
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, RouteValueDictionary routeValues)
	{
		return htmlHelper.ELMAForm(null, null, routeValues);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, RouteValueDictionary routeValues, bool confirmOnClose)
	{
		return htmlHelper.ELMAForm(null, null, routeValues, confirmOnClose);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName)
	{
		return htmlHelper.ELMAForm(actionName, controllerName, null, (FormMethod)1, null);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues)
	{
		return htmlHelper.ELMAForm(actionName, controllerName, new RouteValueDictionary(routeValues));
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues)
	{
		return htmlHelper.ELMAForm(actionName, controllerName, routeValues, (FormMethod)1, null);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, bool confirmOnClose)
	{
		return htmlHelper.ELMAForm(actionName, controllerName, routeValues, (FormMethod)1, null, confirmOnClose);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, FormMethod method)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.ELMAForm(actionName, controllerName, null, method, null);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, FormMethod method)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.ELMAForm(actionName, controllerName, new RouteValueDictionary(routeValues), method, null);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.ELMAForm(actionName, controllerName, new RouteValueDictionary(routeValues), method, null);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, FormMethod method, object htmlAttributes)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.ELMAForm(actionName, controllerName, null, method, UIExtensions.ObjectToDictionary(htmlAttributes));
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, FormMethod method, IDictionary<string, object> htmlAttributes)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.ELMAForm(actionName, controllerName, null, method, htmlAttributes);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, FormMethod method, object htmlAttributes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.ELMAForm(actionName, controllerName, new RouteValueDictionary(routeValues), method, UIExtensions.ObjectToDictionary(htmlAttributes));
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, FormMethod method, object htmlAttributes, bool confirmOnClose)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return htmlHelper.ELMAForm(actionName, controllerName, new RouteValueDictionary(routeValues), method, UIExtensions.ObjectToDictionary(htmlAttributes), confirmOnClose);
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		htmlHelper.EnableClientValidation();
		MvcForm result = ((actionName.IsNullOrWhiteSpace() && controllerName.IsNullOrWhiteSpace() && (routeValues == null || !routeValues.Any())) ? FormExtensions.BeginForm(htmlHelper) : FormExtensions.BeginForm(htmlHelper, actionName, controllerName, routeValues, method, htmlAttributes));
		htmlHelper.get_ViewContext().get_Writer().Write(((HtmlString)(object)htmlHelper.AntiForgeryToken()).ToHtmlString());
		return result;
	}

	public static MvcForm ELMAForm(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes, bool confirmOnClose)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		htmlHelper.EnableClientValidation();
		htmlAttributes = htmlAttributes ?? new Dictionary<string, object>();
		if (confirmOnClose)
		{
			htmlAttributes.Add("confirmOnClose", "");
		}
		MvcForm result = FormExtensions.BeginForm(htmlHelper, actionName, controllerName, routeValues, method, htmlAttributes);
		htmlHelper.get_ViewContext().get_Writer().Write(((HtmlString)(object)htmlHelper.AntiForgeryToken()).ToHtmlString());
		return result;
	}

	public static MvcForm ElmaForm(this HtmlHelper html, string id, object routeValues)
	{
		return html.ElmaForm(id, confirmOnClose: false, routeValues);
	}

	public static MvcForm ElmaForm(this HtmlHelper html, string id, RouteValueDictionary routeValueDictionary)
	{
		return html.ElmaForm(id, confirmOnClose: false, routeValueDictionary);
	}

	public static MvcForm ElmaForm(this HtmlHelper html, string id = "GlobalForm", bool confirmOnClose = false, object routeValues = null)
	{
		RouteValueDictionary routeValueDictionary = ((routeValues != null) ? new RouteValueDictionary(routeValues) : null);
		return html.ElmaForm(id, confirmOnClose, routeValueDictionary);
	}

	public static MvcForm ElmaForm(this HtmlHelper html, string id, bool confirmOnClose, RouteValueDictionary routeValueDictionary)
	{
		html.EnableClientValidation();
		string actionName = ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["action"].ToString();
		string controllerName = ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["controller"].ToString();
		if (routeValueDictionary != null)
		{
			if (routeValueDictionary.ContainsKey("action"))
			{
				actionName = routeValueDictionary["action"].ToString();
			}
			if (routeValueDictionary.ContainsKey("controller"))
			{
				controllerName = routeValueDictionary["controller"].ToString();
			}
		}
		RouteValueDictionary routeValueDictionary2 = HtmlHelper.AnonymousObjectToHtmlAttributes((object)new
		{
			id = id,
			enctype = "multipart/form-data"
		});
		if (confirmOnClose)
		{
			routeValueDictionary2.Add("confirmonclose", "");
		}
		return html.ELMAForm(actionName, controllerName, routeValueDictionary, (FormMethod)1, routeValueDictionary2);
	}

	public static MvcForm JavascriptForm(this HtmlHelper html, string id, string onsubmit, object htmlAttributes)
	{
		return html.JavascriptForm(id, onsubmit, confirmOnClose: false, htmlAttributes);
	}

	public static MvcForm JavascriptForm(this HtmlHelper html, string id, string onsubmit, IDictionary<string, object> htmlAttributes)
	{
		return html.JavascriptForm(id, onsubmit, confirmOnClose: false, htmlAttributes);
	}

	public static MvcForm JavascriptForm(this HtmlHelper html, string id = "GlobalForm", string onsubmit = "", bool confirmOnClose = false, object htmlAttributes = null)
	{
		return html.JavascriptForm(id, onsubmit, confirmOnClose, (htmlAttributes != null) ? UIExtensions.ObjectToDictionary(htmlAttributes) : null);
	}

	public static MvcForm JavascriptKeyDownForm(this HtmlHelper html, string id, string onsubmit, object htmlAttributes)
	{
		return html.JavascriptKeyDownForm(id, onsubmit, confirmOnClose: false, (htmlAttributes != null) ? new RouteValueDictionary(htmlAttributes) : null);
	}

	public static MvcForm JavascriptKeyDownForm(this HtmlHelper html, string id, string onsubmit, bool confirmOnClose, IDictionary<string, object> htmlAttributes)
	{
		htmlAttributes = htmlAttributes ?? new Dictionary<string, object>();
		htmlAttributes["onkeydown"] = $"canRunSubmit({id}, {onsubmit}, event)";
		return html.JavascriptForm(id, $"canRunSubmit({id}, {onsubmit}, undefined)", confirmOnClose, htmlAttributes);
	}

	public static MvcForm JavascriptForm(this HtmlHelper html, string id, string onsubmit, bool confirmOnClose, IDictionary<string, object> htmlAttributes)
	{
		htmlAttributes = htmlAttributes ?? new Dictionary<string, object>();
		htmlAttributes["onsubmit"] = onsubmit;
		htmlAttributes["action"] = "javascript:void(0)";
		if (confirmOnClose)
		{
			htmlAttributes["confirmOnClose"] = "";
		}
		if (id != null)
		{
			htmlAttributes["id"] = id;
		}
		MvcForm result = FormExtensions.BeginForm(html, (string)null, (string)null, (FormMethod)1, htmlAttributes);
		html.get_ViewContext().get_Writer().Write(((HtmlString)(object)html.AntiForgeryToken()).ToHtmlString());
		return result;
	}

	public static MvcForm ModelForm(this HtmlHelper html, FormViewModel model, bool ajax, string callback)
	{
		return html.ModelForm(model, confirmOnClose: false, ajax, callback);
	}

	public static MvcForm ModelForm(this HtmlHelper html, FormViewModel model, bool confirmOnClose = false, bool ajax = false, string callback = null)
	{
		string id = model.Id ?? html.GenerateName("model_form");
		if (confirmOnClose)
		{
			TypeHelper.MergeTypes(model.HtmlAttributes, new
			{
				confirmonclose = ""
			});
		}
		if (!ajax)
		{
			MvcForm result = FormExtensions.BeginForm(html, model.PostAction, model.PostController, (object)((model.PostArea != null) ? new
			{
				area = model.PostArea
			} : null), (FormMethod)1, (model.HtmlAttributes != null) ? TypeHelper.MergeTypes(model.HtmlAttributes, new
			{
				id = id,
				enctype = "multipart/form-data"
			}) : new
			{
				id = id,
				enctype = "multipart/form-data"
			});
			html.get_ViewContext().get_Writer().Write(((HtmlString)(object)html.AntiForgeryToken()).ToHtmlString());
			return result;
		}
		return html.AjaxForm(model.PostAction, model.PostController, (model.PostArea != null) ? new
		{
			area = model.PostArea
		} : null, (FormMethod)1, model.HtmlAttributes, callback ?? model.Callback);
	}

	public static MvcHtmlString SubmitOnClick(this HtmlHelper html, FormViewModel model, string prepend = null, string append = null)
	{
		List<string> list = (from p in ComponentManager.Current.GetExtensionPoints<IFormSubmitFunction>()
			where p.SupportFormViewModel(model)
			select p.FunctionName(model) into f
			where !string.IsNullOrWhiteSpace(f)
			select f).ToList();
		if (!string.IsNullOrWhiteSpace(prepend))
		{
			list.Insert(0, prepend);
		}
		if (!string.IsNullOrWhiteSpace(append))
		{
			list.Add(append);
		}
		if (list.Count == 0)
		{
			return MvcHtmlString.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("onclick=\"");
		stringBuilder.Append("var btn=this;");
		foreach (string item in list)
		{
			stringBuilder.Append(item).Append("(btn,function(){");
		}
		stringBuilder.Append("$(btn.form).AddAntiForgeryToken().submit();");
		foreach (string item2 in list)
		{
			_ = item2;
			stringBuilder.Append("});");
		}
		stringBuilder.Append("return false;\"");
		return MvcHtmlString.Create(stringBuilder.ToString());
	}

	public static MvcHtmlString DownloadOnClick(this HtmlHelper html, BinaryFile file, string url)
	{
		if (file == null)
		{
			MvcHtmlString.Create("return true;");
		}
		IDownloadFunction downloadFunction = ComponentManager.Current.GetExtensionPoints<IDownloadFunction>().FirstOrDefault((IDownloadFunction p) => p.IsSupported(file));
		if (downloadFunction == null || string.IsNullOrWhiteSpace(downloadFunction.FunctionName(file)))
		{
			return MvcHtmlString.Create("return true;");
		}
		return MvcHtmlString.Create($"return {downloadFunction.FunctionName(file)}('{file.Uid}','{url}','{downloadFunction.GetData(file)}');");
	}

	public static MvcHtmlString BuildForm([NotNull] this HtmlHelper html, [NotNull] object model, ViewType viewType, Action<FormBuilder> builder = null)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		FormBuilder formBuilder = new FormBuilder(html, model, viewType);
		builder?.Invoke(formBuilder);
		return MvcHtmlString.Create(formBuilder.ToHtmlString());
	}

	public static MvcHtmlString BuildForm([NotNull] this HtmlHelper html, string elementId, [NotNull] object model, ViewType viewType, Action<FormBuilder> builder = null)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		FormBuilder formBuilder = new FormBuilder(html, elementId ?? html.GenerateName("auto_form"), model, viewType);
		builder?.Invoke(formBuilder);
		return MvcHtmlString.Create(formBuilder.ToHtmlString());
	}

	public static MvcHtmlString BuildFormForModel<TModel>([NotNull] this HtmlHelper html, TModel model, ViewType viewType, Action<FormBuilder<TModel>> builder = null)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		FormBuilder<TModel> formBuilder = new FormBuilder<TModel>(html, model, viewType);
		builder?.Invoke(formBuilder);
		return MvcHtmlString.Create(formBuilder.ToHtmlString());
	}

	public static MvcHtmlString BuildFormFor<THelperModel, TModel>([NotNull] this HtmlHelper<THelperModel> html, Expression<Func<THelperModel, TModel>> modelExpr, ViewType viewType, Action<FormBuilder<TModel>> builder = null, bool renderSimple = false, bool onlyUserProperties = false) where TModel : class
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		TModel val = modelExpr.Compile()(html.get_ViewData().get_Model());
		if (val == null)
		{
			throw new ArgumentException(SR.T("Невозможно вычислить значение выражения {0}", modelExpr), "modelExpr");
		}
		FormBuilder<TModel> formBuilder = new FormBuilder<TModel>((HtmlHelper)(object)html, val, viewType);
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)modelExpr);
		formBuilder.Prefix(expressionText);
		if (renderSimple)
		{
			formBuilder.HideForm();
			formBuilder.LayoutConfig(delegate(DefaultFormLayout l)
			{
				l.RenderTable = false;
			});
		}
		if (onlyUserProperties)
		{
			formBuilder.ShowOnlyUserProperties();
		}
		builder?.Invoke(formBuilder);
		return MvcHtmlString.Create(formBuilder.ToHtmlString());
	}

	public static MvcHtmlString BuildFormForModel<TModel>([NotNull] this HtmlHelper html, string elementId, TModel model, ViewType viewType, Action<FormBuilder<TModel>> builder = null)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		FormBuilder<TModel> formBuilder = new FormBuilder<TModel>(html, elementId ?? html.GenerateName("auto_form"), model, viewType);
		builder?.Invoke(formBuilder);
		return MvcHtmlString.Create(formBuilder.ToHtmlString());
	}

	public static MvcForm AjaxForm(this HtmlHelper html, string action, string controller, object routeValues, FormMethod method, object htmlAttributes, string callback, bool imageSubmit)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return html.AjaxForm(action, controller, new RouteValueDictionary(routeValues), method, htmlAttributes, callback, confirmOnClose: false, imageSubmit);
	}

	public static MvcForm AjaxForm(this HtmlHelper html, string action, string controller, object routeValues, FormMethod method = 1, object htmlAttributes = null, string callback = "", bool confirmOnClose = false, bool imageSubmit = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return html.AjaxForm(action, controller, new RouteValueDictionary(routeValues), method, htmlAttributes, callback, confirmOnClose, imageSubmit);
	}

	public static MvcForm AjaxForm(this HtmlHelper html, string action, string controller, RouteValueDictionary routeValues, FormMethod method, object htmlAttributes, string callback, bool imageSubmit)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return html.AjaxForm(action, controller, routeValues, method, htmlAttributes, callback, confirmOnClose: false, imageSubmit);
	}

	public static MvcForm AjaxForm(this HtmlHelper html, string action, string controller, RouteValueDictionary routeValues, FormMethod method, object htmlAttributes, string callback, bool confirmOnClose, bool imageSubmit)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return html.AjaxForm(action, controller, routeValues, method, htmlAttributes, callback, confirmOnClose, imageSubmit, null);
	}

	public static MvcForm AjaxForm(this HtmlHelper html, string action, string controller, RouteValueDictionary routeValues, FormMethod method, object htmlAttributes, string callback, bool confirmOnClose, bool imageSubmit, string callbackFunc)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		var anon = new
		{
			type = "ajaxForm",
			callback = callback,
			imageSubmit = imageSubmit,
			id = html.GenerateName("ajax_form"),
			callbackFunc = callbackFunc
		};
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary((htmlAttributes != null) ? TypeHelper.MergeTypes(htmlAttributes, anon) : anon);
		if (confirmOnClose)
		{
			routeValueDictionary.Add("confirmonclose", "");
		}
		MvcForm result = FormExtensions.BeginForm(html, action, controller, routeValues, method, (IDictionary<string, object>)routeValueDictionary);
		html.get_ViewContext().get_Writer().Write(((HtmlString)(object)html.AntiForgeryToken()).ToHtmlString());
		return result;
	}

	public static MvcForm AjaxModelForm(this HtmlHelper html, FormViewModel model)
	{
		return html.AjaxForm(model.PostAction, model.PostController, new
		{
			area = model.PostArea
		}, (FormMethod)1, new
		{
			id = (model.Id ?? html.GenerateName("ajax_form")),
			enctype = "multipart/form-data"
		});
	}

	public static MvcForm AjaxForm(this HtmlHelper html, bool confirmOnClose = false, string callback = "")
	{
		string action = ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["action"].ToString();
		string controller = ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["controller"].ToString();
		string area = ((ControllerContext)html.get_ViewContext()).get_RouteData().Values["area"].ToString();
		var routeValues = new { area };
		bool confirmOnClose2 = confirmOnClose;
		return html.AjaxForm(action, controller, routeValues, (FormMethod)1, null, callback, confirmOnClose2, imageSubmit: false);
	}

	public static MvcForm AjaxForm(this HtmlHelper html, string callback)
	{
		return html.AjaxForm(confirmOnClose: false, callback);
	}

	public static MvcHtmlString RadioButtonList(this HtmlHelper html, string name, string legend, IEnumerable<ExtendedSelectListItem> items)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("fieldset");
		val.AddCssClass("radio-button-list");
		if (!string.IsNullOrEmpty(legend))
		{
			TagBuilder val2 = new TagBuilder("legend");
			val2.set_InnerHtml(html.Encode(legend));
			TagBuilder val3 = val2;
			val.set_InnerHtml(((object)val3).ToString());
		}
		foreach (ExtendedSelectListItem item in items)
		{
			TagBuilder val4 = new TagBuilder("div");
			val4.AddCssClass("radio-button-item");
			string rbId = name + "_" + ((SelectListItem)item).get_Value();
			ModernRadioButtonBuilder modernRadioButtonBuilder = html.ModernRadioButton().Id(rbId).Name(name)
				.Value(((SelectListItem)item).get_Value())
				.Checked(((SelectListItem)item).get_Selected())
				.Attributes(item.HtmlAttributes)
				.LabelText(((SelectListItem)item).get_Text())
				.ContainerAttributes(delegate(HtmlAttributes a)
				{
					a["id"] = rbId + "_label";
				});
			val4.set_InnerHtml(modernRadioButtonBuilder.ToHtmlString());
			if (!string.IsNullOrEmpty(item.Description))
			{
				TagBuilder val5 = new TagBuilder("span");
				val5.set_InnerHtml(html.Encode(item.Description));
				TagBuilder val6 = val5;
				val6.AddCssClass("description");
				val4.set_InnerHtml(val4.get_InnerHtml() + ((object)val6).ToString());
			}
			val.set_InnerHtml(val.get_InnerHtml() + ((object)val4).ToString());
		}
		return MvcHtmlString.Create(((object)val).ToString());
	}

	public static MvcHtmlString Caption(this HtmlHelper html, string text, bool required)
	{
		return PartialExtensions.Partial(html, "Templates/PropertyCaption", (object)new PropertyCaption
		{
			Required = required,
			Text = text
		});
	}

	public static MvcHtmlString FormatTextForDisplay(this HtmlHelper html, string text, bool wrap = true)
	{
		if (string.IsNullOrEmpty(text))
		{
			return MvcHtmlString.Create(text);
		}
		text = text.Replace("<", "&lt;").Replace(">", "&gt;");
		text = Regex.Replace(text, "\\b(https?|ftp|file)://[-\\w+&@#/%?=~_|!:,.;()]*[\\w+&@#/%=~_|]", (Match match) => string.Format("<a href='{0}'>{0}</a>", match.Value), RegexOptions.IgnoreCase);
		if (html != null)
		{
			text = Regex.Replace(text, "~(/[-\\w+&@#/%?=~_|!:,.;()]*[\\w+&@#/%=~_|])?", (Match match) => string.Format("<a href='{0}'>{1}</a>", html.Url().Content(match.Value), match.Value.Replace("~", "")), RegexOptions.IgnoreCase);
		}
		if (wrap)
		{
			text = text.Replace("\r\n", "<br/>").Replace("\r", "<br/>").Replace("\n", "<br/>");
		}
		if (html == null)
		{
			return MvcHtmlString.Create(text);
		}
		return html.FormatBaseUrl(text);
	}

	public static MvcHtmlString FormatBaseUrl(this HtmlHelper html, string text)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (string.IsNullOrEmpty(text))
		{
			return MvcHtmlString.Create(text);
		}
		text = text.Replace("{#BaseUrl#}/", "{#BaseUrl#}").Replace("{#BaseUrl#}", html.Url().Content("~/"));
		return MvcHtmlString.Create(text);
	}

	public static MvcHtmlString ShortCutText(this HtmlHelper html, string text, int maxLength = 250, int maxParagraphCount = 3)
	{
		if (TranslateService.Instance.IsTranslationModeEnabled())
		{
			return MvcHtmlString.Create(text);
		}
		if (string.IsNullOrEmpty(text))
		{
			return MvcHtmlString.Create(text);
		}
		string textOld = text;
		Func<MvcHtmlString> func = () => MvcHtmlString.Create((text == textOld) ? text : (text + "..."));
		text = Regex.Replace(text.Trim(" \r\n\t".ToCharArray()).Replace("\r", ""), "(?=\\n)\\n+", "\n");
		if (string.IsNullOrEmpty(text))
		{
			return func();
		}
		string[] array = text.Split("\n".ToCharArray());
		if (array.Length > maxParagraphCount)
		{
			string[] array2 = new string[maxParagraphCount];
			for (int i = 0; i < maxParagraphCount; i++)
			{
				array2[i] = array[i];
			}
			text = string.Join("\r\n", array2);
		}
		if (text.Length <= maxLength)
		{
			return func();
		}
		text = text.Substring(0, Math.Min(maxLength, text.Length));
		MatchCollection matchCollection = Regex.Matches(text, "\\s|,|\\.|\\:|\\!|\\?|\\;|\\(|\\)|'|\\\"|-|\\+|=");
		if (matchCollection.Count != 0)
		{
			text = text.Substring(0, matchCollection[matchCollection.Count - 1].Index);
		}
		return func();
	}

	public static TooltipBuilder Tooltip(this HtmlHelper html, string selector)
	{
		return new TooltipBuilder(selector);
	}

	public static void HtmlHelperAction<TModel>([NotNull] this HtmlHelper html, object modelData, [NotNull] Action<HtmlHelper<TModel>> action)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (html is HtmlHelper<TModel>)
		{
			action((HtmlHelper<TModel>)(object)html);
			return;
		}
		ViewDataDictionary viewData = html.get_ViewData();
		ViewDataDictionary val;
		if (modelData == null)
		{
			val = ((viewData != null) ? new ViewDataDictionary(viewData) : new ViewDataDictionary(html.get_ViewData()));
		}
		else if (viewData == null)
		{
			val = new ViewDataDictionary(modelData);
		}
		else
		{
			ViewDataDictionary val2 = new ViewDataDictionary(viewData);
			val2.set_Model(modelData);
			val = val2;
		}
		TelerikGridViewDataContainer<TModel> telerikGridViewDataContainer = new TelerikGridViewDataContainer<TModel>((TModel)modelData, val);
		HtmlHelper<TModel> obj = new HtmlHelper<TModel>(new ViewContext((ControllerContext)(object)html.get_ViewContext(), html.get_ViewContext().get_View(), val, html.get_ViewContext().get_TempData(), html.get_ViewContext().get_Writer()), (IViewDataContainer)(object)telerikGridViewDataContainer);
		action(obj);
	}

	public static MvcHtmlString HtmlHelperFunc<TModel>([NotNull] this HtmlHelper html, TModel modelData, string prefix, [NotNull] Func<HtmlHelper<TModel>, MvcHtmlString> action)
	{
		string htmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		MvcHtmlString result = html.HtmlHelperFunc(modelData, action);
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
		return result;
	}

	public static MvcHtmlString HtmlHelperFunc<TModel>([NotNull] this HtmlHelper html, TModel modelData, [NotNull] Func<HtmlHelper<TModel>, MvcHtmlString> action)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		MvcHtmlString result = MvcHtmlString.Empty;
		html.HtmlHelperAction(modelData, delegate(HtmlHelper<TModel> helper)
		{
			result = action(helper);
		});
		return result;
	}

	public static bool IsIE11([NotNull] this HtmlHelper html)
	{
		string userAgent = ((ControllerContext)html.get_ViewContext()).get_RequestContext().HttpContext.Request.UserAgent;
		if (userAgent != null && userAgent.Contains("Trident/7.0"))
		{
			return userAgent.Contains("rv:11.0");
		}
		return false;
	}

	public static string GetErrorMessage([NotNull] this HtmlHelper html)
	{
		string text = (string)HttpContext.Current.Session["ErrorMessage"];
		if (text.IsNullOrEmpty())
		{
			ModelState val = html.get_ViewData().get_ModelState().get_Values()
				.FirstOrDefault((ModelState ms) => ms.get_Errors() != null && ((IEnumerable<ModelError>)ms.get_Errors()).Any());
			if (val != null)
			{
				text = ((Collection<ModelError>)(object)val.get_Errors())[0].get_ErrorMessage();
			}
			else if (html.get_ViewContext().get_TempData().get_Item("ErrorMessage") != null)
			{
				text = (string)html.get_ViewContext().get_TempData().get_Item("ErrorMessage");
			}
		}
		return text;
	}

	public static bool IsIE([NotNull] this HtmlHelper html)
	{
		string userAgent = ((ControllerContext)html.get_ViewContext()).get_RequestContext().HttpContext.Request.UserAgent;
		if (userAgent == null || !userAgent.Contains("IE"))
		{
			return html.IsIE11();
		}
		return true;
	}

	public static bool IsFirefox([NotNull] this HtmlHelper html)
	{
		return ((ControllerContext)html.get_ViewContext()).get_RequestContext().HttpContext.Request.UserAgent?.Contains("Firefox") ?? false;
	}

	public static MvcHtmlString DynamicFormSettings(this HtmlHelper html, Guid providerUid, Action<DynamicFormSettings> action)
	{
		DynamicFormSettings dynamicFormSettings = new DynamicFormSettings();
		dynamicFormSettings.DynamicFormsProviderUid = providerUid;
		action?.Invoke(dynamicFormSettings);
		return html.DynamicFormSettings(dynamicFormSettings);
	}

	public static MvcHtmlString DynamicFormSettings(this HtmlHelper html, DynamicFormSettings settings)
	{
		return html.DynamicFormSettings(settings, "Entity");
	}

	public static MvcHtmlString DynamicFormSettings(this HtmlHelper html, DynamicFormSettings settings, string prefix)
	{
		if (settings == null)
		{
			return MvcHtmlString.Empty;
		}
		if (ContextVars.TryGetValue<bool>("DisableDynamicFormSettingsRender", out var value) && value)
		{
			return MvcHtmlString.Empty;
		}
		string htmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
		if (!string.IsNullOrEmpty(prefix))
		{
			html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldName(prefix));
		}
		if (ContextVars.TryGetValue<string>("FormViewItemFormId", out var value2))
		{
			if (!string.IsNullOrWhiteSpace(value2))
			{
				settings.FormId = value2;
			}
			ContextVars.Remove("FormViewItemFormId");
		}
		try
		{
			return PartialExtensions.Partial(html, "Templates/DynamicFormSettings", (object)settings);
		}
		finally
		{
			html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
		}
	}

	public static BindClientEventsBuilder BindClientEvents(this HtmlHelper html, string id)
	{
		return new BindClientEventsBuilder(new BindClientEventsComponent(html.get_ViewContext(), id));
	}

	public static BindClientEventsBuilder BindClientEvents(this HtmlHelper html)
	{
		string fullHtmlFieldId = html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("");
		return html.BindClientEvents(fullHtmlFieldId);
	}

	public static CustomFormViewsModel GetCustomFormViewsModel(this HtmlHelper html, IEntity entity, ViewType viewType, bool inTab, bool twoColumnsLayout = false)
	{
		return twoColumnsLayout switch
		{
			false => html.GetCustomFormViewsModel(entity, viewType, inTab, delegate(CustomFormViewsModel v)
			{
				v.CustomView = html.BuildFormForModel(entity, viewType, delegate(FormBuilder<IEntity> b)
				{
					b.HideForm();
					b.Prefix("Entity");
					b.LayoutConfig(delegate(DefaultFormLayout l)
					{
						l.RenderTable = false;
					});
					b.ShowOnlyUserProperties();
					b.EachPropertyRow(delegate(EleWise.ELMA.Web.Mvc.Html.Forms.PropertyRowModel r)
					{
						if (r.Visible)
						{
							v.CustomPropCount++;
						}
					});
				});
			}), 
			true => html.GetCustomFormViewsModel(entity, viewType, inTab, delegate(CustomFormViewsModel v)
			{
				v.CustomView = html.BuildFormForModel(entity, viewType, delegate(FormBuilder<IEntity> b)
				{
					b.HideForm();
					b.Layout(new TwoColumnsFormLayout());
					b.ShowOnlyUserProperties();
					b.EachPropertyRow(delegate(EleWise.ELMA.Web.Mvc.Html.Forms.PropertyRowModel r)
					{
						if (r.Visible)
						{
							v.CustomPropCount++;
						}
					});
				});
			}), 
			_ => null, 
		};
	}

	public static CustomFormViewsModel GetCustomFormViewsModel(this HtmlHelper html, IEntity entity, ViewType viewType, bool inTab, Action<CustomFormViewsModel> createCustomView = null)
	{
		try
		{
			CustomFormViewsModel customFormViewsModel = new CustomFormViewsModel();
			customFormViewsModel.CustomPropCount = 0L;
			customFormViewsModel.HasCommonView = EntityHelper.HasCustomFormViews(entity, viewType, inTab);
			customFormViewsModel.FormView = EntityHelper.GetCustomFormView(entity, viewType, inTab);
			customFormViewsModel.CustomView = MvcHtmlString.Empty;
			if (customFormViewsModel.HasCommonView && !customFormViewsModel.FormView.UseRazorView)
			{
				createCustomView?.Invoke(customFormViewsModel);
			}
			if (customFormViewsModel.HasCommonView && customFormViewsModel.FormView.UseRazorView)
			{
				string htmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
				if (!string.IsNullOrWhiteSpace(htmlFieldPrefix))
				{
					TemplateInfo templateInfo = html.get_ViewData().get_TemplateInfo();
					templateInfo.set_HtmlFieldPrefix(templateInfo.get_HtmlFieldPrefix() + ".Entity");
				}
				else
				{
					html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("Entity");
				}
				try
				{
					customFormViewsModel.CustomView = PartialExtensions.Partial(html, inTab ? customFormViewsModel.FormView.RazorTabViewName : customFormViewsModel.FormView.RazorCommonViewName, (object)entity);
					customFormViewsModel.CustomPropCount = 1L;
				}
				catch (Exception ex)
				{
					customFormViewsModel.CustomView = PartialExtensions.Partial(html, "RazorViewError/RazorViewError", (object)ex);
					customFormViewsModel.CustomPropCount = 1L;
				}
				finally
				{
					html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
				}
			}
			return customFormViewsModel;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static long MaxFileSize(this HtmlHelper html)
	{
		CommonSettingsModule serviceNotNull = Locator.GetServiceNotNull<CommonSettingsModule>();
		if (serviceNotNull != null)
		{
			return serviceNotNull.Settings.MaxFileSize;
		}
		return 0L;
	}

	public static MvcHtmlString InvalidFileExtensions(this HtmlHelper html)
	{
		CommonSettingsModule serviceNotNull = Locator.GetServiceNotNull<CommonSettingsModule>();
		if (serviceNotNull != null && !string.IsNullOrEmpty(serviceNotNull.Settings.InvalidFileExtensions))
		{
			List<string> obj = (from e in serviceNotNull.Settings.GetInvalidFileExtensions()
				select e.TrimStart('.')).ToList();
			return MvcHtmlString.Create(new JsonSerializer().Serialize(obj));
		}
		return MvcHtmlString.Create("[]");
	}

	public static void RenderEntityLinkActions(this HtmlHelper html, IEntity entity, bool subclass)
	{
		List<IEntityLinkRenderAction> source = ComponentManager.Current.GetExtensionPoints<IEntityLinkRenderAction>().ToList();
		if (source.Any())
		{
			Guid entityUid = ((entity is IInheritable) ? ((IInheritable)entity).TypeUid : InterfaceActivator.UID(entity.GetType()));
			List<Guid> baseUids = (subclass ? (from m in MetadataLoader.GetBaseClasses((ClassMetadata)MetadataLoader.LoadMetadata(entityUid))
				select m.Uid).ToList() : new List<Guid>());
			(source.FirstOrDefault((IEntityLinkRenderAction e) => e.TypeUid == entityUid || (subclass && baseUids.Contains(e.TypeUid))) ?? source.FirstOrDefault((IEntityLinkRenderAction e) => e.EntityType != null && (e.EntityType == entity.GetType() || (subclass && e.EntityType.IsInstanceOfType(entity)))))?.Render(html, entity);
		}
	}

	public static void RenderEntityLinkActions(this HtmlHelper html, Guid entityTypeUid, long entityId, bool subclass)
	{
		if (entityTypeUid == Guid.Empty || entityId == 0L)
		{
			return;
		}
		List<IEntityLinkRenderAction> source = ComponentManager.Current.GetExtensionPoints<IEntityLinkRenderAction>().ToList();
		if (!source.Any())
		{
			return;
		}
		Type entityType = null;
		try
		{
			entityType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityTypeUid);
		}
		catch (Exception)
		{
			return;
		}
		List<Guid> baseUids = (subclass ? (from m in MetadataLoader.GetBaseClasses((ClassMetadata)MetadataLoader.LoadMetadata(entityTypeUid))
			select m.Uid).ToList() : new List<Guid>());
		IEntityLinkRenderAction entityLinkRenderAction = source.FirstOrDefault((IEntityLinkRenderAction e) => e.TypeUid == entityTypeUid || (subclass && baseUids.Contains(e.TypeUid))) ?? source.FirstOrDefault((IEntityLinkRenderAction e) => e.EntityType != null && (e.EntityType == entityType || (subclass && e.EntityType.IsAssignableFrom(entityType))));
		if (entityLinkRenderAction != null)
		{
			IEntity entity = null;
			if (entityLinkRenderAction.LoadEntityIfNull)
			{
				entity = (IEntity)ModelHelper.GetEntityManager(entityType).LoadOrNull(entityId);
			}
			entityLinkRenderAction.Render(html, entity);
		}
	}

	public static MvcHtmlString TranslateControls(this HtmlHelper html)
	{
		if (!TranslateService.Instance.Initialized || !TranslateService.Instance.IsTranslationModeEnabled())
		{
			return MvcHtmlString.Empty;
		}
		TranslateSettings translateSettings = new TranslateSettings
		{
			CurrentLocal = SR.GetCurrentCulture().Name
		};
		long value = Convert.ToInt64(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId());
		string text = (translateSettings.TargetLocal = TranslateService.Instance.GetTranslateLocalization(value));
		return PartialExtensions.Partial(html, "Translate/TranslateScripts", (object)translateSettings);
	}

	public static MvcHtmlString TranslationPanel(this HtmlHelper html)
	{
		if (!TranslateService.Instance.Initialized || !TranslateService.Instance.IsTranslationModeEnabled())
		{
			return MvcHtmlString.Empty;
		}
		TranslateSettings translateSettings = new TranslateSettings
		{
			CurrentLocal = SR.GetCurrentCulture().Name
		};
		long value = Convert.ToInt64(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId());
		string text = (translateSettings.TargetLocal = TranslateService.Instance.GetTranslateLocalization(value));
		return PartialExtensions.Partial(html, "Translate/TranslationPanel", (object)translateSettings);
	}

	public static MvcHtmlString PreviewFileControls(this HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Previews/PreviewPopupButtonViews");
	}

	public static MvcHtmlString PreviewFileButton(this HtmlHelper html, BinaryFile binaryFile, string uniqueGlobalPrefix)
	{
		PreviewPopupButtonInfo preview = new PreviewPopupButtonInfo
		{
			File = binaryFile,
			UniqueGlobalPrefix = uniqueGlobalPrefix
		};
		return html.PreviewFileButton(preview);
	}

	public static MvcHtmlString PreviewFileButton(this HtmlHelper html, PreviewPopupButtonInfo preview)
	{
		return PartialExtensions.Partial(html, "Previews/PreviewPopupButton", (object)preview);
	}

	public static bool IsSupportPreview(this HtmlHelper html, BinaryFile binaryFile)
	{
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		if (!serviceNotNull.IsSupportPreview(binaryFile))
		{
			return false;
		}
		IFilePreviewCreator previewCreator = serviceNotNull.GetPreviewCreator(binaryFile);
		if (previewCreator == null || !previewCreator.IsAvaliable(binaryFile))
		{
			return false;
		}
		return true;
	}

	public static string PreviewPopupOpen(this HtmlHelper html, BinaryFile binaryFile, string uniqueGlobalPrefix)
	{
		return html.PreviewPopupOpen(binaryFile, uniqueGlobalPrefix, canLoadFile: true);
	}

	public static string PreviewPopupOpen(this HtmlHelper html, BinaryFile binaryFile, string uniqueGlobalPrefix, bool canLoadFile)
	{
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		if (!serviceNotNull.IsSupportPreview(binaryFile))
		{
			return string.Empty;
		}
		IFilePreviewCreator previewCreator = serviceNotNull.GetPreviewCreator(binaryFile);
		if (previewCreator == null || !previewCreator.IsAvaliable(binaryFile))
		{
			return string.Empty;
		}
		Type creatorType = previewCreator.GetType();
		IFilePreviewCreatorRenderer filePreviewCreatorRenderer = ComponentManager.Current.GetExtensionPoints<IFilePreviewCreatorRenderer>().FirstOrDefault((IFilePreviewCreatorRenderer r) => r.CreatorType == creatorType);
		if (filePreviewCreatorRenderer == null)
		{
			return string.Empty;
		}
		string text = filePreviewCreatorRenderer.CloseFunctionName(uniqueGlobalPrefix);
		return string.Format("refreshPopup('PreviewPopup', '{0}', null, '{1}', '{2}', {3}, null, true, true); return false;", html.Url().Action("PreviewPopup", "BinaryFiles", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			id = binaryFile.Id,
			uniqueGlobalPrefix = uniqueGlobalPrefix,
			canLoadFile = canLoadFile
		}), HttpUtility.JavaScriptStringEncode(binaryFile.Name) ?? SR.T("Предпросмотр"), $"PreviewAjaxBinding(\"{filePreviewCreatorRenderer.Uid}\", \"{$"{uniqueGlobalPrefix}{UIExtensions.PrepareId(binaryFile.Id ?? binaryFile.Uid.ToString())}"}\")", (!string.IsNullOrWhiteSpace(text)) ? $"'{text}()'" : "null");
	}

	public static string PreviewSelectorPopupOpen(this HtmlHelper html, BinaryFile binaryFile)
	{
		if (!html.IsSupportPreview(binaryFile) || binaryFile.Id == null)
		{
			return string.Empty;
		}
		return string.Format("refreshPopup('DownloadPreviewSelector', '{0}', null, '{1}', null, null, null, true, true); return false;", html.Url().Action("DownloadPreviewSelectorPopup", "BinaryFiles", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			id = (binaryFile.Id ?? binaryFile.Uid.ToString())
		}), HttpUtility.JavaScriptStringEncode(binaryFile.Name) ?? SR.T("Выберите действие"));
	}

	public static MvcHtmlString MultiButtonsPanel([NotNull] this HtmlHelper htmlHelper, MultiButtons multiButtons)
	{
		return PartialExtensions.Partial(htmlHelper, "UI/MultiButtons", (object)multiButtons);
	}

	public static MvcHtmlString MultiEdit([NotNull] this HtmlHelper htmlHelper, MultiEditModel multiEditModel)
	{
		return PartialExtensions.Partial(htmlHelper, "UI/MultiEdit", (object)multiEditModel);
	}

	public static MvcHtmlString ListEditor<T>([NotNull] this HtmlHelper<T> htmlHelper, string itemViewName = null) where T : IEnumerable
	{
		if (itemViewName == null)
		{
			if (!(MetadataLoader.LoadMetadata((from t in Enumerable.Repeat(typeof(T), 1).Concat(typeof(T).GetInterfaces())
				where t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)
				select t.GetGenericArguments()[0]).FirstOrDefault() ?? typeof(object)) is EntityMetadata entityMetadata))
			{
				throw new Exception("Can not get TypeMetadata");
			}
			itemViewName = "EditorTemplates/Entities/" + entityMetadata.Name;
		}
		return PartialExtensions.Partial((HtmlHelper)(object)htmlHelper, "UI/ListEditor", (object)new Tuple<IEnumerable, string, ViewAttributes, HtmlAttributes>(htmlHelper.get_ViewData().get_Model(), itemViewName, htmlHelper.get_ViewData().ViewAttributes<T>(), htmlHelper.get_ViewData().HtmlAttributes<T>()));
	}

	public static MvcHtmlString LocalizatoinJsObject(this HtmlHelper html, string id)
	{
		string msg;
		Dictionary<string, string> jSPoStrings = LocalizationUtility.GetJSPoStrings(id, out msg);
		if (jSPoStrings == null)
		{
			return MvcHtmlString.Create("{}");
		}
		return MvcHtmlString.Create(new JsonSerializer().Serialize(jSPoStrings));
	}

	public static MvcHtmlString LocalizatoinCurrentJsObject(this HtmlHelper html)
	{
		Dictionary<string, string> jSPoStringsSource = LocalizationUtility.GetJSPoStringsSource();
		if (jSPoStringsSource == null)
		{
			return MvcHtmlString.Create("{}");
		}
		return MvcHtmlString.Create(new JsonSerializer().Serialize(jSPoStringsSource));
	}

	public static MvcHtmlString LocalizatoinTargetJsObject(this HtmlHelper html)
	{
		Dictionary<string, string> jSPoStringsTarget = LocalizationUtility.GetJSPoStringsTarget();
		if (jSPoStringsTarget == null)
		{
			return MvcHtmlString.Create("{}");
		}
		return MvcHtmlString.Create(new JsonSerializer().Serialize(jSPoStringsTarget));
	}

	public static void RemovePrefix(this HtmlHelper html, string prefix)
	{
		string htmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
		if (htmlFieldPrefix == prefix || htmlFieldPrefix.EndsWith("." + prefix))
		{
			html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix.Remove(Math.Max(htmlFieldPrefix.Length - prefix.Length - 1, 0)));
		}
	}

	public static void AddPrefix(this HtmlHelper html, string prefix)
	{
		string text = (string.IsNullOrEmpty(html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix()) ? "" : ".");
		TemplateInfo templateInfo = html.get_ViewData().get_TemplateInfo();
		templateInfo.set_HtmlFieldPrefix(templateInfo.get_HtmlFieldPrefix() + text + prefix);
	}

	public static bool GetEditableInTablePropertyValue(this HtmlHelper html)
	{
		bool result = false;
		if (html.get_ViewData().get_Item("View") is PropertyViewItem propertyViewItem)
		{
			result = propertyViewItem.EditableInTable && !GridBuilderExtensions.IsRowInEditMode;
		}
		return result;
	}

	public static bool IsMobileApp([NotNull] this HtmlHelper html)
	{
		return ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.QueryString["interface"] == "mobile";
	}

	public static IEnumerable<string> GetPagesWithoutSpa(this HtmlHelper htmlHelper)
	{
		return Locator.GetServiceNotNull<ICacheService>().GetOrAdd("PagesWithoutSpa", delegate
		{
			UrlHelper url = htmlHelper.Url();
			IEnumerable<Type> extensionPointTypes = ComponentManager.Current.GetExtensionPointTypes(typeof(IBaseController));
			Type attrType = typeof(WithoutSpaAttribute);
			List<string> list = new List<string>();
			foreach (Type controllerType in extensionPointTypes)
			{
				MethodInfo[] methods = controllerType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
				list.AddRange(methods.Where((MethodInfo m) => m.CustomAttributes.Any((CustomAttributeData a) => a.AttributeType == attrType)).Select(delegate(MethodInfo a)
				{
					int length = controllerType.Name.LastIndexOf("Controller");
					string name = controllerType.Assembly.GetName().Name;
					return url.Action(a.Name, controllerType.Name.Substring(0, length), (object)new
					{
						area = name
					});
				}));
			}
			return list;
		});
	}
}
