using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Web.Mvc;

[Service]
public class CSSStylesCachedMergerService
{
	public const string StyleUpdateTimestampKey = "StyleUpdateTimestampKey";

	private const int WaitUpdateSeconds = 300;

	private const string EmptyFilesHashKey = "EMPTY_FILES_HASH_KEY";

	private string filesHash = "";

	private string filesHashSHA1 = "";

	private DateTime lastUpdate = DateTime.MinValue;

	private string lastColorSchemeUpdateTimestamp = "";

	private string pageAppfilesHash = "";

	private string pageAppfilesHashSHA1 = "";

	private DateTime pageApplastUpdate = DateTime.MinValue;

	private readonly ILessService lessService;

	private readonly IColorSchemeLessService colorSchemeLessService;

	private ConcurrentDictionary<string, string> singleFileHashes = new ConcurrentDictionary<string, string>();

	private ConcurrentDictionary<string, string> singleFileHashesSHA1 = new ConcurrentDictionary<string, string>();

	private ConcurrentDictionary<string, DateTime> singleFileLastUpdates = new ConcurrentDictionary<string, DateTime>();

	public static CSSStylesCachedMergerService Instance => Locator.GetServiceNotNull<CSSStylesCachedMergerService>();

	public ILogger Logger { get; set; }

	public CSSStylesCachedMergerService(ILessService lessService, IColorSchemeLessService colorSchemeLessService)
	{
		this.lessService = lessService;
		this.colorSchemeLessService = colorSchemeLessService;
		Logger = NullLogger.Instance;
	}

	private static string GetLatestHash(HtmlHelper html, string[] jsStruct)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (jsStruct.Length != 0)
		{
			for (int i = 0; i < jsStruct.Length; i++)
			{
				if (string.IsNullOrWhiteSpace(jsStruct[i]))
				{
					continue;
				}
				try
				{
					if (HostingEnvironment.VirtualPathProvider.FileExists(jsStruct[i]))
					{
						stringBuilder.Append(HostingEnvironment.VirtualPathProvider.GetFileHash(jsStruct[i], Enumerable.Repeat(jsStruct[i], 1)));
					}
				}
				catch (Exception exception)
				{
					EleWise.ELMA.Logging.Logger.Log.Error("Cannot get file hash. Set NOW.", exception);
					stringBuilder.Append(DateTime.Now.Ticks);
				}
			}
		}
		else
		{
			stringBuilder.Append("EMPTY_FILES_HASH_KEY");
		}
		return stringBuilder.ToString();
	}

	private static bool UpdateSHA1Hash(string lastHash, ref string filesHash, ref string filesHashSHA1, ref DateTime lastUpdate)
	{
		if (filesHash != lastHash)
		{
			using (SHA1 item = SHA1.Create())
			{
				(string, string) tuple = MemoryHelper.ActionWithMemoryBuffer<byte, (SHA1, string), (string, string)>(Encoding.UTF8.GetByteCount(lastHash), (item, lastHash), UpdateSHA1HashAction);
				string item2 = tuple.Item1;
				string text = (filesHash = tuple.Item2);
				filesHashSHA1 = item2;
				lastUpdate = DateTime.UtcNow;
				return true;
			}
		}
		lastUpdate = DateTime.UtcNow;
		return false;
	}

	private static (string, string) UpdateSHA1HashAction(byte[] buffer, int offset, int length, (SHA1, string) param)
	{
		var (sHA, text) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, buffer, offset);
		return (BitConverter.ToString(sHA.ComputeHash(buffer, offset, length)).Replace("-", ""), text);
	}

	private string[] GetStyles(HtmlHelper html)
	{
		return ((object)PartialExtensions.Partial(html, "Shared/UI/CachedCSSStyles")).ToString().SplitToLines();
	}

	private string[] GetPageAppStyles(HtmlHelper html)
	{
		return ((object)PartialExtensions.Partial(html, "Shared/UI/CachedPageAppCSSStyles")).ToString().SplitToLines();
	}

	public string GetContentUrl(HtmlHelper html)
	{
		UrlHelper obj = html.Url();
		string text = "";
		if ((DateTime.UtcNow - lastUpdate).TotalSeconds > 300.0)
		{
			string[] styles = GetStyles(html);
			UpdateSHA1Hash(GetLatestHash(html, styles), ref filesHash, ref filesHashSHA1, ref lastUpdate);
		}
		string str = UpdateStylesHash(html, filesHashSHA1);
		text = $"~/Content/GetCss{HttpUtility.UrlEncode(str)}";
		return obj.Content(text);
	}

	public void RenderFilesContent(HtmlHelper html)
	{
		html.get_ViewContext().get_Writer().WriteLine("/* Start files */");
		VirtualPathProvider virtualPathProvider = HostingEnvironment.VirtualPathProvider;
		string[] styles = GetStyles(html);
		new StringBuilder();
		for (int i = 0; i < styles.Length; i++)
		{
			try
			{
				if (virtualPathProvider.FileExists(styles[i]))
				{
					using StreamReader streamReader = new StreamReader(virtualPathProvider.GetFile(styles[i]).Open());
					html.get_ViewContext().get_Writer().WriteLine();
					html.get_ViewContext().get_Writer().WriteLine(streamReader.ReadToEnd());
					html.get_ViewContext().get_Writer().WriteLine();
				}
			}
			catch (Exception exception)
			{
				Logger.Error("Cannot create CSS", exception);
			}
		}
		RenderLessContent(html, virtualPathProvider);
		html.get_ViewContext().get_Writer().WriteLine("/* End files */");
	}

	public string GetPageAppContentUrl(HtmlHelper html)
	{
		UrlHelper obj = html.Url();
		string text = "";
		if ((DateTime.UtcNow - pageApplastUpdate).TotalSeconds > 300.0)
		{
			string[] pageAppStyles = GetPageAppStyles(html);
			UpdateSHA1Hash(GetLatestHash(html, pageAppStyles), ref pageAppfilesHash, ref pageAppfilesHashSHA1, ref pageApplastUpdate);
		}
		string str = UpdateStylesHash(html, pageAppfilesHashSHA1);
		text = $"~/Content/GetPageAppCss{HttpUtility.UrlEncode(str)}";
		return obj.Content(text);
	}

	public string GetColorSchemeUrl(HtmlHelper html)
	{
		return html.Url().Content("~/Content/GetColorScheme");
	}

	public void RenderPageAppContent(HtmlHelper html)
	{
		html.get_ViewContext().get_Writer().WriteLine("/* Start files */");
		RenderColorScheme(html);
		VirtualPathProvider virtualPathProvider = HostingEnvironment.VirtualPathProvider;
		string[] pageAppStyles = GetPageAppStyles(html);
		for (int i = 0; i < pageAppStyles.Length; i++)
		{
			try
			{
				if (virtualPathProvider.FileExists(pageAppStyles[i]))
				{
					using StreamReader streamReader = new StreamReader(virtualPathProvider.GetFile(pageAppStyles[i]).Open());
					html.get_ViewContext().get_Writer().WriteLine();
					html.get_ViewContext().get_Writer().WriteLine(streamReader.ReadToEnd());
					html.get_ViewContext().get_Writer().WriteLine();
				}
			}
			catch (Exception exception)
			{
				Logger.Error("Cannot create CSS", exception);
			}
		}
		html.get_ViewContext().get_Writer().WriteLine("/* End files */");
	}

	public void RenderColorScheme(HtmlHelper html)
	{
		html.get_ViewContext().get_Writer().WriteLine();
		html.get_ViewContext().get_Writer().WriteLine(":root {");
		html.get_ViewContext().get_Writer().WriteLine(colorSchemeLessService.GetCssScheme().Variables);
		html.get_ViewContext().get_Writer().WriteLine("}");
		html.get_ViewContext().get_Writer().WriteLine();
	}

	private void RenderLessContent(HtmlHelper html, VirtualPathProvider provider)
	{
		string text = lessService.Bundle();
		if (!text.IsNullOrEmpty())
		{
			html.get_ViewContext().get_Writer().WriteLine();
			html.get_ViewContext().get_Writer().WriteLine(text);
			html.get_ViewContext().get_Writer().WriteLine();
		}
	}

	public string GetSingleFileContentUrl(HtmlHelper html, string virtualPath)
	{
		if (string.IsNullOrEmpty(virtualPath))
		{
			throw new ArgumentNullException("virtualPath");
		}
		UrlHelper val = html.Url();
		if (!singleFileHashes.TryGetValue(virtualPath, out var value))
		{
			value = "";
		}
		string value2 = "";
		if (!singleFileHashesSHA1.TryGetValue(virtualPath, out value2))
		{
			value2 = "";
		}
		if (!singleFileLastUpdates.TryGetValue(virtualPath, out var value3))
		{
			value3 = DateTime.MinValue;
		}
		if ((DateTime.UtcNow - value3).TotalSeconds > 300.0 && UpdateSHA1Hash(GetLatestHash(html, new string[1] { virtualPath }), ref value, ref value2, ref value3))
		{
			singleFileHashes[virtualPath] = value;
			singleFileHashesSHA1[virtualPath] = value2;
			singleFileLastUpdates[virtualPath] = value3;
		}
		string text = virtualPath;
		if (text.StartsWith("~"))
		{
			text = text.Remove(0, 1);
		}
		if (text.StartsWith("/"))
		{
			text = text.Remove(0, 1);
		}
		string str = UpdateStylesHash(html, value2);
		return val.Content($"~/Content/CssFile/{text}/{HttpUtility.UrlEncode(str)}");
	}

	public string GetTemporaryCss(UrlHelper urlHelper, string src, string zone)
	{
		string temporaryCssHref = lessService.GetTemporaryCssHref(zone, src);
		if (!string.IsNullOrWhiteSpace(temporaryCssHref))
		{
			return urlHelper.Content(temporaryCssHref);
		}
		throw new ArgumentNullException(SR.T("Не удалось найти файл или файл содержит ошибки. {0}", src));
	}

	private string UpdateStylesHash(HtmlHelper html, string stylesHash)
	{
		string text = ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.Cookies["StyleUpdateTimestampKey"]?.Value ?? string.Empty;
		if (text != lastColorSchemeUpdateTimestamp)
		{
			lastColorSchemeUpdateTimestamp = text;
		}
		return stylesHash + lastColorSchemeUpdateTimestamp;
	}
}
