using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Models.Help;

[Component]
public abstract class XmlMapHelpPageUrlProvider : IHelpPageUrlProviderEx, IHelpPageUrlProvider
{
	private readonly string _xmlFileMapVirtualPath;

	private readonly object _sync = new object();

	private IMemoryCacheService MemoryCacheService => Locator.GetServiceNotNull<IMemoryCacheService>();

	protected string XmlFileMapVirtualPath => _xmlFileMapVirtualPath;

	public ILogger Logger { get; set; }

	public virtual bool IsGlobalModuleProvider => true;

	protected abstract string Index { get; }

	protected abstract string Icon { get; }

	protected abstract string Name { get; }

	protected abstract string Description { get; }

	protected XmlMapHelpPageUrlProvider(string xmlFileMapVirtualPath)
	{
		_xmlFileMapVirtualPath = xmlFileMapVirtualPath;
		Logger = NullLogger.Instance;
	}

	public virtual string IconUrl(UrlHelper url)
	{
		return url.Image(Icon);
	}

	public virtual string IndexUrl(UrlHelper url)
	{
		return url.Content(Index);
	}

	public virtual MvcHtmlString RenderHeader(HtmlHelper html)
	{
		return MvcHtmlString.Create(Name);
	}

	public virtual MvcHtmlString RenderDescription(HtmlHelper html)
	{
		return MvcHtmlString.Create(Description);
	}

	public string FindUrl(ControllerContext controllerContext)
	{
		return FindUrl(controllerContext.get_HttpContext(), null);
	}

	public string FindUrl(ControllerContext controllerContext, string pagePath)
	{
		return FindUrl(controllerContext.get_HttpContext(), pagePath);
	}

	public string FindUrl(HttpContextBase httpContext, string pagePath)
	{
		if (httpContext == null || httpContext.Request == null || string.IsNullOrWhiteSpace(httpContext.Request.AppRelativeCurrentExecutionFilePath))
		{
			throw new InvalidOperationException(SR.T("Не задан контекст запроса, или невозможно определить виртуальный путь"));
		}
		pagePath = pagePath ?? httpContext.Request.AppRelativeCurrentExecutionFilePath;
		CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture ?? SR.GetCurrentCulture();
		string path = string.Format(XmlFileMapVirtualPath, cultureInfo.Name);
		string text = httpContext.Server.MapPath(path);
		if (!File.Exists(text))
		{
			path = string.Format(XmlFileMapVirtualPath, "en-US");
			text = httpContext.Server.MapPath(path);
			if (!File.Exists(text))
			{
				Logger.Info(SR.T("Не найден файла индекса справки {0}", text));
				return null;
			}
		}
		try
		{
			string key = "HelpItemsCacheKey" + GetType().FullName + cultureInfo.Name;
			HelpItem[] result = null;
			if (!MemoryCacheService.TryGetValue<HelpItem[]>(key, out result))
			{
				lock (_sync)
				{
					result = ClassSerializationHelper.DeserializeObjectByXml<HelpItem[]>(File.ReadAllText(text));
				}
				MemoryCacheService.Insert(key, result);
			}
			return result.FirstOrDefault((HelpItem helpItem) => Regex.IsMatch(pagePath, helpItem.PageId, RegexOptions.IgnoreCase))?.PageUrl;
		}
		catch (SystemException exception)
		{
			Logger.Error(SR.T("Ошибка десериализации файла индекса справки {0}", text), exception);
		}
		catch (Exception exception2)
		{
			Logger.Error(SR.T("Ошибка при поиске ссылки справки для страницы {0} в файле {1}", pagePath, text), exception2);
		}
		return null;
	}
}
