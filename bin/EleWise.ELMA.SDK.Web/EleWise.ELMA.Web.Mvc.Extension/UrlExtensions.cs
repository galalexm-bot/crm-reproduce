using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExpressionUtil;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Services;
using EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;
using EleWise.ELMA.Web.Mvc.Util;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class UrlExtensions
{
	private static EntityUrlResolverService _entityUrlResolverService;

	private const string ReturnUrlKey = "ReturnUrl";

	private static EntityUrlResolverService EntityUrlResolverService => _entityUrlResolverService ?? (_entityUrlResolverService = Locator.GetServiceNotNull<EntityUrlResolverService>());

	public static string Image([NotNull] this UrlHelper url, string relativeUrl)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (string.IsNullOrEmpty(relativeUrl))
		{
			return string.Empty;
		}
		if (relativeUrl.StartsWith("#"))
		{
			string icon = url.GetIcon(relativeUrl);
			relativeUrl = (string.IsNullOrWhiteSpace(icon) ? ("~/Content/Images/" + relativeUrl.Substring(1)) : icon);
		}
		return url.Content(relativeUrl);
	}

	public static string Image([NotNull] this UrlHelper url, string relativeUrl, string moduleUrl)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (string.IsNullOrEmpty(relativeUrl))
		{
			return string.Empty;
		}
		string text = "~/";
		if (relativeUrl.StartsWith("#"))
		{
			if (moduleUrl != null)
			{
				text = "~/Modules/" + moduleUrl + "/";
			}
			text = text + "Content/Images/" + relativeUrl.Substring(1);
		}
		return url.Content(text);
	}

	public static string Action(this UrlHelper url, string actionName, string controllerName, string area)
	{
		return GenerateUrl(url, actionName, controllerName, area, null);
	}

	public static string Action(this UrlHelper url, string actionName, string controllerName, string area, RouteValueDictionary routeValues)
	{
		return GenerateUrl(url, actionName, controllerName, area, routeValues);
	}

	public static string Action(this UrlHelper url, string actionName, string controllerName, string area, object routeValues)
	{
		return GenerateUrl(url, actionName, controllerName, area, new RouteValueDictionary(routeValues));
	}

	public static string Build(this UrlHelper helper, string url, Dictionary<string, object> @params)
	{
		return helper.Build(url, @params, asJsString: false, absolute: false);
	}

	public static string Build(this UrlHelper helper, string url, Dictionary<string, object> @params, bool asJsString)
	{
		return helper.Build(url, @params, asJsString, absolute: false);
	}

	public static string Build(this UrlHelper helper, string url, Dictionary<string, object> @params, bool asJsString, bool absolute)
	{
		if (helper == null)
		{
			throw new ArgumentNullException("url");
		}
		if (string.IsNullOrEmpty(url))
		{
			if (!asJsString)
			{
				return string.Empty;
			}
			return "''";
		}
		Uri uri = new Uri(url, UriKind.RelativeOrAbsolute);
		if (!uri.IsAbsoluteUri)
		{
			uri = new Uri(EntityUrlResolverService.ToAbsoluteUrl(url));
		}
		UriBuilder uriBuilder = new UriBuilder(uri.ToString());
		string text = (absolute ? uriBuilder.ToString() : (uriBuilder.Path + uriBuilder.Query));
		if (@params == null || @params.Count == 0)
		{
			if (!asJsString)
			{
				return text;
			}
			return $"'{text}'";
		}
		NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(uri.Query);
		int num = 0;
		foreach (KeyValuePair<string, object> param in @params)
		{
			nameValueCollection.Add(param.Key, asJsString ? $"{{{num}}}" : param.Value.ToString());
			num++;
		}
		uriBuilder.Query = nameValueCollection.ToString();
		text = (absolute ? uriBuilder.ToString() : (uriBuilder.Path + uriBuilder.Query));
		if (!asJsString)
		{
			return text;
		}
		return string.Format("jQuery.validator.format('{0}', {1})", HttpUtility.UrlDecode(text), string.Join(",", (@params != null) ? @params.Values : new Dictionary<string, object>().Values));
	}

	public static string Build(this UrlHelper helper, string url, Dictionary<string, string> @params)
	{
		return helper.Build(url, @params, asJsString: false, absolute: false);
	}

	public static string Build(this UrlHelper helper, string url, Dictionary<string, string> @params, bool asJsString)
	{
		return helper.Build(url, @params, asJsString, absolute: false);
	}

	public static string Build(this UrlHelper helper, string url, Dictionary<string, string> @params, bool asJsString, bool absolute)
	{
		return helper.Build(url, @params?.ToDictionary((Func<KeyValuePair<string, string>, string>)((KeyValuePair<string, string> p) => p.Key), (Func<KeyValuePair<string, string>, object>)((KeyValuePair<string, string> p) => p.Value)), asJsString, absolute);
	}

	public static string Action<TController>(this UrlHelper url, Expression<Action<TController>> action) where TController : Controller
	{
		RouteValueDictionary routeValuesFromExpression = GetRouteValuesFromExpression(url, action);
		return GenerateUrl(url, null, null, null, routeValuesFromExpression);
	}

	public static string Action<TController>(this UrlHelper url, Expression<Action<TController>> action, RouteValueDictionary routeValues) where TController : Controller
	{
		RouteValueDictionary routeValuesFromExpression = GetRouteValuesFromExpression(url, action);
		if (routeValues != null)
		{
			foreach (KeyValuePair<string, object> routeValue in routeValues)
			{
				if (!routeValuesFromExpression.ContainsKey(routeValue.Key))
				{
					routeValuesFromExpression.Add(routeValue.Key, routeValue.Value);
				}
			}
		}
		return GenerateUrl(url, null, null, null, routeValuesFromExpression);
	}

	public static string Action<TController>(this UrlHelper url, Expression<Action<TController>> action, object routeValues) where TController : Controller
	{
		RouteValueDictionary routeValuesFromExpression = GetRouteValuesFromExpression(url, action);
		RouteValueDictionary routeValueDictionary = ((routeValues != null) ? new RouteValueDictionary(routeValues) : null);
		if (routeValueDictionary != null)
		{
			foreach (KeyValuePair<string, object> item in routeValueDictionary)
			{
				if (!routeValuesFromExpression.ContainsKey(item.Key))
				{
					routeValuesFromExpression.Add(item.Key, item.Value);
				}
			}
		}
		return GenerateUrl(url, null, null, null, routeValuesFromExpression);
	}

	public static RouteValueDictionary GetRouteValuesFromExpression<TController>(UrlHelper url, Expression<Action<TController>> action) where TController : Controller
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		RouteValueDictionary routeValuesFromExpression = ExpressionHelper.GetRouteValuesFromExpression(action);
		foreach (RouteBase item in url.get_RouteCollection())
		{
			if (item is Route route && route.DataTokens != null && route.DataTokens["Namespaces"] is string[] source && source.FirstOrDefault((string ns) => ns == typeof(TController).Namespace) != null)
			{
				if (route.DataTokens["Area"] is string value)
				{
					routeValuesFromExpression["Area"] = value;
				}
				break;
			}
		}
		if (!routeValuesFromExpression.ContainsKey("Area") || string.IsNullOrEmpty((string)routeValuesFromExpression["Area"]))
		{
			routeValuesFromExpression["Area"] = ComponentManager.GetAssemblyShortName(typeof(TController).Assembly);
		}
		return routeValuesFromExpression;
	}

	public static string Entity(this UrlHelper url, IEntity entity)
	{
		return EntityUrlResolverService.Entity(url, entity);
	}

	public static string Entity(this UrlHelper url, Guid typeUid, string id)
	{
		return EntityUrlResolverService.Entity(url, typeUid, id);
	}

	public static string Entity(this UrlHelper url, Guid typeUid, long id)
	{
		return url.Entity(typeUid, id.ToString());
	}

	public static string EntityList(this UrlHelper url, Type entityType)
	{
		IEntityListLink entityListLink = ComponentManager.Current.GetExtensionPoints<IEntityListLink>().FirstOrDefault((IEntityListLink e) => e.CheckType(entityType.GetTypeWithoutProxy()));
		if (entityListLink != null)
		{
			return entityListLink.Url(url.get_RequestContext());
		}
		return EntityUrlResolverService.EntityList(url, entityType);
	}

	public static string ObjectLink(this UrlHelper url, object obj)
	{
		if (obj == null)
		{
			return null;
		}
		IObjectLink objectLink = ComponentManager.Current.GetExtensionPoints<IObjectLink>().FirstOrDefault((IObjectLink e) => e.CheckType(obj.GetType().GetTypeWithoutProxy()));
		if (objectLink != null)
		{
			return objectLink.Url(url.get_RequestContext(), obj);
		}
		if (obj is IEntity)
		{
			return url.Entity((IEntity)obj);
		}
		return null;
	}

	public static string ObjectPopupLink(this UrlHelper url, object obj)
	{
		if (obj == null)
		{
			return null;
		}
		return ComponentManager.Current.GetExtensionPoints<IObjectPopupLink>().FirstOrDefault((IObjectPopupLink e) => e.CheckType(obj.GetType().GetTypeWithoutProxy()))?.Url(url.get_RequestContext(), obj);
	}

	public static string ObjectIcon([NotNull] this UrlHelper url, ObjectIconFormat format, object obj)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (obj == null)
		{
			return null;
		}
		IObjectIcon objectIcon = ComponentManager.Current.GetExtensionPoints<IObjectIcon>().FirstOrDefault((IObjectIcon e) => e.CheckType(obj.GetType()));
		if (objectIcon != null)
		{
			string text = objectIcon.Icon(url, format, obj);
			if (!string.IsNullOrEmpty(text))
			{
				return url.Image(text);
			}
		}
		if (obj is IInheritable)
		{
			IMetadataRuntimeService metadataRuntimeServiceOrNull = MetadataServiceContext.MetadataRuntimeServiceOrNull;
			if (metadataRuntimeServiceOrNull != null)
			{
				if ((NamedMetadata)metadataRuntimeServiceOrNull.GetMetadata(((IInheritable)obj).TypeUid) != null)
				{
					return url.Action("Object", "Images", "EleWise.ELMA.SDK.Web", new
					{
						id = ((IInheritable)obj).TypeUid,
						size = (int)format,
						useParent = true
					});
				}
			}
		}
		if ((obj is Enum || obj is EnumBase) && MetadataLoader.LoadMetadata(obj.GetType()) is EnumMetadata enumMetadata)
		{
			EnumValueMetadata enumValueMetadata = enumMetadata.Values.FirstOrDefault((EnumValueMetadata v) => v.EnumValue != null && v.EnumValue.Equals(obj));
			if (enumValueMetadata != null && enumValueMetadata.GetImage((int)format, onlyToSize: true) != null)
			{
				return url.Action("EnumObject", "Images", "EleWise.ELMA.SDK.Web", new
				{
					id = enumMetadata.Uid,
					valueid = enumValueMetadata.Uid,
					size = (int)format
				});
			}
		}
		if (obj is IEntity && MetadataLoader.LoadMetadata(obj.GetType()) is EntityMetadata entityMetadata)
		{
			if (entityMetadata.GetImage((int)format, onlyToSize: true) != null)
			{
				return url.Action("Object", "Images", "EleWise.ELMA.SDK.Web", new
				{
					id = entityMetadata.Uid,
					size = (int)format,
					useParent = false
				});
			}
		}
		return null;
	}

	public static string FormImage([NotNull] this UrlHelper url, ObjectIconFormat format, FormDescriptor descriptor, string imageKey)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (descriptor == null)
		{
			return null;
		}
		return url.Action("Form", "Images", "EleWise.ELMA.SDK.Web", new
		{
			id = descriptor.Uid,
			typeUid = descriptor.Metadata.GetTypeUid(),
			image = imageKey,
			size = (int)format,
			useParent = true
		});
	}

	public static string EntityIcon(this UrlHelper url, Guid objectTypeUid, int size = 16)
	{
		ClassMetadata entitymetadata = MetadataLoader.LoadMetadata(objectTypeUid, inherit: true, loadImplementation: false) as ClassMetadata;
		return url.EntityIcon(entitymetadata, size);
	}

	public static string EntityIcon(this UrlHelper url, ClassMetadata entitymetadata, int size = 16)
	{
		if (url == null || entitymetadata == null)
		{
			return null;
		}
		if (entitymetadata.Images != null && entitymetadata.Images.Count > 0)
		{
			return HtmlExtensions.Image(url, url.Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = entitymetadata.Uid,
				size = size
			}), "", "", new
			{
				@class = "entityTypeIcon"
			});
		}
		if (!(entitymetadata.BaseClassUid == Guid.Empty))
		{
			return url.EntityIcon((EntityMetadata)MetadataLoader.LoadMetadata(entitymetadata.BaseClassUid), size);
		}
		return null;
	}

	public static MvcHtmlString Link([NotNull] this UrlHelper urlHelper, [NotNull] string url, string rel, string type, object htmlAttributes)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Contract.ArgumentNotNull(urlHelper, "urlHelper");
		Contract.ArgumentNotNull(url, "url");
		TagBuilder val = new TagBuilder("link");
		IDictionary<string, object> dictionary = UIExtensions.ObjectToDictionary(htmlAttributes);
		val.get_Attributes()["href"] = urlHelper.Content(url);
		if (!rel.IsNullOrEmpty())
		{
			val.get_Attributes()["rel"] = rel;
		}
		if (!type.IsNullOrEmpty())
		{
			val.get_Attributes()["type"] = type;
		}
		val.MergeAttributes<string, object>(dictionary, true);
		return MvcHtmlString.Create(val.ToString((TagRenderMode)3));
	}

	public static MvcHtmlString LinkLess([NotNull] this UrlHelper urlHelper, [NotNull] string src, [NotNull] string zone, object htmlAttributes)
	{
		Contract.ArgumentNotNull(urlHelper, "urlHelper");
		Contract.ArgumentNotNullOrEmpty(src, "src");
		Contract.ArgumentNotNullOrEmpty(zone, "zone");
		string temporaryCss = CSSStylesCachedMergerService.Instance.GetTemporaryCss(urlHelper, src, zone);
		return urlHelper.Link($"/Content/GetCss{temporaryCss}", "stylesheet", "text/css", htmlAttributes);
	}

	private static string GenerateUrl(UrlHelper url, string actionName, string controllerName, string area, RouteValueDictionary routeValues)
	{
		if (routeValues == null)
		{
			routeValues = new RouteValueDictionary();
		}
		if (area != null)
		{
			routeValues["area"] = area;
		}
		if (!routeValues.ContainsKey("area"))
		{
			routeValues["area"] = "";
		}
		return UrlHelper.GenerateUrl((string)null, actionName, controllerName, routeValues, url.get_RouteCollection(), url.get_RequestContext(), true);
	}

	public static RouteValueDictionary ActionRoute(this UrlHelper url, string actionName, string controllerName, object routeValues)
	{
		if (routeValues is RouteValueDictionary)
		{
			return url.ActionRoute(actionName, controllerName, (RouteValueDictionary)routeValues);
		}
		return url.ActionRoute(actionName, controllerName, new RouteValueDictionary(routeValues));
	}

	public static RouteValueDictionary ActionRoute(this UrlHelper url, string actionName, string controllerName, RouteValueDictionary routeValues)
	{
		return RouteValuesUtility.ActionRoute(actionName, controllerName, routeValues);
	}

	public static string ReturnUrl(this UrlHelper url, bool redirectHomeIfNull = false, string tabIndex = "", bool redirectHomeIfEqual = false)
	{
		if (url == null || url.get_RequestContext() == null || url.get_RequestContext().HttpContext == null || url.get_RequestContext().HttpContext.Request == null || url.get_RequestContext().HttpContext.Request.Params == null)
		{
			if (!redirectHomeIfNull)
			{
				return null;
			}
			return "~/";
		}
		string text = url.get_RequestContext().HttpContext.Request.Params.Get("ReturnUrl");
		if (string.IsNullOrWhiteSpace(text))
		{
			text = url.get_RequestContext().HttpContext.Request.Form.Get("ReturnUrl");
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			if (redirectHomeIfNull)
			{
				text = "~/";
			}
			else if (url.get_RequestContext().HttpContext.Request.UrlReferrer != null)
			{
				text = url.get_RequestContext().HttpContext.Request.UrlReferrer.ToString();
			}
		}
		else if (redirectHomeIfEqual)
		{
			Uri urlReferrer = url.get_RequestContext().HttpContext.Request.UrlReferrer;
			if (urlReferrer != null && urlReferrer.AbsolutePath == new Uri(text).AbsolutePath)
			{
				text = "~/";
			}
		}
		if (!string.IsNullOrEmpty(tabIndex))
		{
			int num = text.IndexOf("?", StringComparison.InvariantCultureIgnoreCase);
			int num2 = text.IndexOf("seletedTab=", StringComparison.InvariantCultureIgnoreCase);
			num2 = ((num2 >= 0) ? num2 : text.IndexOf("selectedTab=", StringComparison.InvariantCultureIgnoreCase));
			string text2 = string.Format("{0}selectedTab={1}", (num >= 0) ? "&" : "?", tabIndex);
			if (num2 < 0)
			{
				text += text2;
			}
			else
			{
				int num3 = text.IndexOf("&", num2, StringComparison.InvariantCultureIgnoreCase);
				string text3 = "";
				if (num3 < 0)
				{
					text3 = text.Substring(num2);
				}
				else
				{
					int length = num3 - num2;
					text3 = text.Substring(num2, length);
				}
				text = text.Replace(text3, text2.Substring(1));
			}
		}
		return text;
	}

	internal static NameValueCollection RemoveUnsecureParamsFromRequest(this UrlHelper url)
	{
		bool flag = false;
		HttpRequestBase request = url.get_RequestContext().HttpContext.Request;
		NameValueCollection nameValueCollection = new NameValueCollection(request.QueryString);
		string text = request.Params.Get("ReturnUrl");
		if (!string.IsNullOrWhiteSpace(text) && text.IndexOf("javascript:", StringComparison.InvariantCultureIgnoreCase) >= 0)
		{
			flag = true;
			nameValueCollection.Remove("ReturnUrl");
		}
		if (!flag)
		{
			return null;
		}
		return nameValueCollection;
	}

	internal static void RedirectWithNewQueryString(this UrlHelper url, NameValueCollection queryString)
	{
		Contract.ArgumentNotNull(queryString, "queryString");
		string text = "";
		for (int i = 0; i < queryString.Count; i++)
		{
			if (i > 0)
			{
				text += "&";
			}
			text = text + queryString.GetKey(i) + "=" + queryString[i];
		}
		string text2 = url.get_RequestContext().HttpContext.Request.Path + ((!string.IsNullOrEmpty(text)) ? ("?" + text) : string.Empty);
		if (url.get_RequestContext().HttpContext.Request.Url.PathAndQuery != text2)
		{
			url.get_RequestContext().HttpContext.Response.Redirect(text2, endResponse: true);
		}
	}
}
