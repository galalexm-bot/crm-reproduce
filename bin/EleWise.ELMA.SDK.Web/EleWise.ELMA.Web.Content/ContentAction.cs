using System;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;

namespace EleWise.ELMA.Web.Content;

public class ContentAction : IContentAction, IContentItem
{
	public static readonly ContentAction EmptyAction = new ContentAction();

	private string _lastCacheKey;

	private string _cachedUrl;

	private object _cachedRoutes;

	private RouteValueDictionary _cachedRoutesDict;

	public static string ActionTypePage => SR.M("Страница");

	public static string ActionTypeDialog => SR.M("Диалог");

	public string Id { get; set; }

	public string NameForLocalization { get; set; }

	public string Name => SR.T(NameForLocalization);

	public string DescriptionForLocalization { get; set; }

	public string Description => SR.T(DescriptionForLocalization);

	public string Image16 { get; set; }

	public string Image24 { get; set; }

	public string Image32 { get; set; }

	public string ReferenceType { get; set; }

	public string Category { get; set; }

	public string ActionType { get; set; }

	public int Order { get; set; }

	public ActionRoute Routes { get; set; }

	public Func<RequestContext, string> LinkTemplate { get; set; }

	public Action<HtmlHelper> OnRenderDelegate { get; set; }

	public Func<MvcHtmlString, HtmlHelper> RenderMarkupDelegate { get; set; }

	public Func<RequestContext, bool> IsAvalilableDelegate { get; set; }

	public Func<RequestContext, int> MatchCurrentDelegate { get; set; }

	public ContentAction()
	{
		ActionType = ActionTypePage;
	}

	public string GetHref(RequestContext requestContext)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		if (LinkTemplate != null)
		{
			return LinkTemplate(requestContext);
		}
		if (Routes != null)
		{
			string text = GetType().FullName + "_" + ((Routes.Routes != null) ? Routes.Routes.GetHashCode().ToString(CultureInfo.InvariantCulture) : "") + "+" + Routes.Action + "+" + Routes.Controller;
			if (_cachedUrl == null || text != _lastCacheKey)
			{
				lock (this)
				{
					RouteValueDictionary routesDictionary = GetRoutesDictionary();
					routesDictionary["action"] = Routes.Action;
					routesDictionary["controller"] = Routes.Controller;
					RouteData routeData = requestContext.RouteData;
					requestContext.RouteData = new RouteData();
					UrlHelper val = new UrlHelper(requestContext);
					_cachedUrl = val.RouteUrl(routesDictionary);
					requestContext.RouteData = routeData;
					_lastCacheKey = text;
				}
			}
			return _cachedUrl;
		}
		return null;
	}

	public string GetImage(ObjectIconFormat size = ObjectIconFormat.x16)
	{
		return ImageBySizeAccessor(() => Image16, () => Image24, () => Image32, size);
	}

	public static string ImageBySizeAccessor([NotNull] Func<string> image16Accessor, [NotNull] Func<string> image24Accessor, [NotNull] Func<string> image32Accessor, ObjectIconFormat size)
	{
		if (image16Accessor == null)
		{
			throw new ArgumentNullException("image16Accessor");
		}
		if (image24Accessor == null)
		{
			throw new ArgumentNullException("image24Accessor");
		}
		if (image32Accessor == null)
		{
			throw new ArgumentNullException("image32Accessor");
		}
		string text = image16Accessor();
		string text2 = image24Accessor();
		string text3 = image32Accessor();
		switch (size)
		{
		case ObjectIconFormat.x24:
			if (string.IsNullOrEmpty(text2))
			{
				if (string.IsNullOrEmpty(text))
				{
					return "#unk.svg";
				}
				return text;
			}
			return text2;
		case ObjectIconFormat.x32:
			if (string.IsNullOrEmpty(text3))
			{
				if (string.IsNullOrEmpty(text2))
				{
					return "#unk.svg";
				}
				return text2;
			}
			return text3;
		default:
			if (string.IsNullOrEmpty(text))
			{
				if (!IconPack.HasSvgExtension(text2))
				{
					if (!IconPack.HasSvgExtension(text3))
					{
						return "#unk.svg";
					}
					return text3;
				}
				return text2;
			}
			return text;
		}
	}

	public void OnRender(HtmlHelper htmlHelper)
	{
		if (OnRenderDelegate != null)
		{
			OnRenderDelegate(htmlHelper);
		}
	}

	public bool IsAvalilable(RequestContext requestContext)
	{
		if (IsAvalilableDelegate != null)
		{
			return IsAvalilableDelegate(requestContext);
		}
		return true;
	}

	public int MatchCurrent(RequestContext requestContext)
	{
		string href = GetHref(requestContext);
		Uri uriHref = new Uri(href, UriKind.RelativeOrAbsolute);
		if (!uriHref.IsAbsoluteUri && !Uri.TryCreate(new Uri(Locator.GetServiceNotNull<CommonSettingsModule>().Settings.ApplicationBaseUrl), uriHref, out uriHref))
		{
			return 0;
		}
		if (href.StartsWith("javascript:"))
		{
			return 0;
		}
		Uri url = ((requestContext.HttpContext != null && requestContext.HttpContext.Request != null) ? requestContext.HttpContext.Request.Url : null);
		if (url != null && (href == url.ToString() || href == url.PathAndQuery))
		{
			return 10;
		}
		if (MatchCurrentDelegate != null)
		{
			return MatchCurrentDelegate(requestContext);
		}
		if (Routes != null)
		{
			ActionRoute routes = Routes;
			string area = (string)GetRoutesDictionary()["area"];
			return (from p in ComponentManager.Current.GetExtensionPoints<IContentActionCurrentMatcher>()
				select p.MatchCurrent(area, routes, requestContext)).FirstOrDefault((int r) => r > 0);
		}
		try
		{
			if (url != null)
			{
				return (from p in ComponentManager.Current.GetExtensionPoints<IContentActionCurrentMatcher>()
					select p.MatchCurrent(uriHref, url)).FirstOrDefault((int r) => r > 0);
			}
		}
		catch
		{
		}
		return 0;
	}

	private RouteValueDictionary GetRoutesDictionary()
	{
		if (Routes == null)
		{
			return null;
		}
		if (_cachedRoutes != Routes.Routes)
		{
			lock (this)
			{
				_cachedRoutesDict = new RouteValueDictionary(Routes.Routes);
				_cachedRoutes = Routes.Routes;
			}
		}
		return _cachedRoutesDict;
	}
}
