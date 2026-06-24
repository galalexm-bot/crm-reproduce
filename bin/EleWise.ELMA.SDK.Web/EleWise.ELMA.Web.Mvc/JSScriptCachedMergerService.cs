using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc;

[Service]
public class JSScriptCachedMergerService
{
	private string filesHash = "";

	private string filesHashSHA1 = "";

	private DateTime lastUpdate = DateTime.MinValue;

	private const int WaitUpdateSeconds = 300;

	private bool lastSpaEnabled;

	private const string SpaFeatureFlag = "Ops_SDKWeb_UseSPA";

	private const string SpaEnabledViewDataKey = "SpaEnabled";

	private const string JsView = "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/CachedJSScripts.cshtml";

	private const string GlobalizationView = "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/CachedGlobalizationScripts.cshtml";

	private const string PageAppView = "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/PageAppCachedJSScripts.cshtml";

	private const string InterfaceBuilderView = "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/InterfaceBuilderCachedJSScripts.cshtml";

	private const string PagesWithoutSpaView = "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/PagesWithoutSpa.cshtml";

	public static JSScriptCachedMergerService Instance => Locator.GetServiceNotNull<JSScriptCachedMergerService>();

	public ILogger Logger { get; set; }

	public IFeatureFlagService FeatureFlagService { get; set; }

	public JSScriptCachedMergerService()
	{
		Logger = NullLogger.Instance;
	}

	private string GetLatestHash(HtmlHelper html, string[] jsStruct)
	{
		StringBuilder stringBuilder = new StringBuilder();
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
				Logger.Error("Cannot get file hash. Set NOW.", exception);
				stringBuilder.Append(DateTime.Now.Ticks);
			}
		}
		return stringBuilder.ToString();
	}

	private void UpdateSHA1Hash(string lastHash)
	{
		if (filesHash != lastHash)
		{
			using SHA1 item = SHA1.Create();
			(string, string) tuple = MemoryHelper.ActionWithMemoryBuffer<byte, (SHA1, string), (string, string)>(Encoding.UTF8.GetByteCount(lastHash), (item, lastHash), UpdateSHA1HashAction);
			string item2 = tuple.Item1;
			string item3 = tuple.Item2;
			filesHashSHA1 = item2;
			filesHash = item3;
		}
		lastUpdate = DateTime.UtcNow;
	}

	private (string, string) UpdateSHA1HashAction(byte[] buffer, int offset, int length, (SHA1, string) param)
	{
		var (sHA, text) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, buffer, offset);
		return (BitConverter.ToString(sHA.ComputeHash(buffer, offset, length)).Replace("-", ""), text);
	}

	private string[] GetScripts(HtmlHelper html, string partialViewName, ViewDataDictionary viewData = null)
	{
		return ((object)PartialExtensions.Partial(html, partialViewName, viewData)).ToString().SplitToLines();
	}

	public string GetContentUrl(HtmlHelper html)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		UrlHelper obj = html.Url();
		string text = "";
		bool flag = FeatureFlagService.Enabled("Ops_SDKWeb_UseSPA", defaultEnabled: false);
		if (!FeatureFlagService.Enabled("Ops_UIBuilder.RuntimeVersion2.Enabled", defaultEnabled: false))
		{
			flag = false;
		}
		if ((DateTime.UtcNow - lastUpdate).TotalSeconds > 300.0 || flag != lastSpaEnabled)
		{
			ViewDataDictionary val = new ViewDataDictionary();
			val.Add("SpaEnabled", (object)flag);
			string[] scripts = GetScripts(html, "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/CachedJSScripts.cshtml", val);
			string latestHash = GetLatestHash(html, scripts);
			lastSpaEnabled = flag;
			UpdateSHA1Hash(latestHash);
		}
		text = $"~/SDK.Action/JS/Get/{HttpUtility.UrlEncode(filesHashSHA1)}";
		return obj.Content(text);
	}

	public void RenderJSContent(HtmlHelper html)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		html.get_ViewContext().get_Writer().WriteLine("//Start files");
		bool flag = FeatureFlagService.Enabled("Ops_SDKWeb_UseSPA", defaultEnabled: false);
		if (!FeatureFlagService.Enabled("Ops_UIBuilder.RuntimeVersion2.Enabled", defaultEnabled: false))
		{
			flag = false;
		}
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("SpaEnabled", (object)flag);
		string[] scripts = GetScripts(html, "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/CachedJSScripts.cshtml", val);
		((ControllerContext)html.get_ViewContext()).get_HttpContext();
		for (int i = 0; i < scripts.Length; i++)
		{
			try
			{
				if (HostingEnvironment.VirtualPathProvider.FileExists(scripts[i]))
				{
					using StreamReader streamReader = new StreamReader(HostingEnvironment.VirtualPathProvider.GetFile(scripts[i]).Open());
					html.get_ViewContext().get_Writer().WriteLine();
					html.get_ViewContext().get_Writer().WriteLine(streamReader.ReadToEnd());
					html.get_ViewContext().get_Writer().WriteLine();
				}
			}
			catch (Exception exception)
			{
				Logger.Error("Cannot create JS", exception);
			}
		}
		html.get_ViewContext().get_Writer().WriteLine("//End files");
		if (flag)
		{
			html.get_ViewContext().get_Writer().WriteLine(PartialExtensions.Partial(html, "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/PagesWithoutSpa.cshtml"));
		}
	}

	public string GetGlobalizationContentUrl(HtmlHelper html)
	{
		int num = 0;
		CultureInfo cultureInfo = Locator.GetServiceNotNull<ILocalizationService>().Load();
		string text = ((cultureInfo != null) ? cultureInfo.Name : Thread.CurrentThread.CurrentCulture.Name);
		if (HostingEnvironment.VirtualPathProvider.FileExists("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/CachedGlobalizationScripts.cshtml"))
		{
			string fileHash = HostingEnvironment.VirtualPathProvider.GetFileHash("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/CachedGlobalizationScripts.cshtml", Enumerable.Repeat("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/CachedGlobalizationScripts.cshtml", 1));
			num = ((fileHash != null) ? $"{fileHash}{text}".GetHashCode() : 0);
		}
		return html.Url().Content($"~/SDK.Action/JS/Globalization/{text}_{num}");
	}

	public void RenderGlobalizationContent(HtmlHelper html)
	{
		MvcHtmlString val = PartialExtensions.Partial(html, "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/CachedGlobalizationScripts.cshtml");
		html.get_ViewContext().get_Writer().Write(((HtmlString)(object)val).ToHtmlString());
	}

	public string GetPageAppContentUrl(HtmlHelper html)
	{
		int num = 0;
		if (HostingEnvironment.VirtualPathProvider.FileExists("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/PageAppCachedJSScripts.cshtml"))
		{
			string fileHash = HostingEnvironment.VirtualPathProvider.GetFileHash("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/PageAppCachedJSScripts.cshtml", Enumerable.Repeat("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/PageAppCachedJSScripts.cshtml", 1));
			num = ((fileHash != null) ? (fileHash + VersionInfo.GetInfoVersion<SR>()).GetHashCode() : 0);
		}
		return html.Url().Content($"~/SDK.Action/JS/PageAppScripts/{num}");
	}

	public void RenderPageAppContent(HtmlHelper html)
	{
		html.get_ViewContext().get_Writer().WriteLine("//Start files");
		string[] scripts = GetScripts(html, "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/PageAppCachedJSScripts.cshtml");
		for (int i = 0; i < scripts.Length; i++)
		{
			try
			{
				string virtualPath = scripts[i];
				if (HostingEnvironment.VirtualPathProvider.FileExists(virtualPath))
				{
					using StreamReader streamReader = new StreamReader(HostingEnvironment.VirtualPathProvider.GetFile(virtualPath).Open());
					html.get_ViewContext().get_Writer().WriteLine();
					html.get_ViewContext().get_Writer().WriteLine(streamReader.ReadToEnd());
					html.get_ViewContext().get_Writer().WriteLine();
				}
			}
			catch (Exception exception)
			{
				Logger.Error("Cannot create JS", exception);
			}
		}
		html.get_ViewContext().get_Writer().WriteLine("//End files");
	}

	public string GetInterfaceBuilderContentUrl(HtmlHelper html)
	{
		int num = 0;
		if (HostingEnvironment.VirtualPathProvider.FileExists("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/InterfaceBuilderCachedJSScripts.cshtml"))
		{
			num = HostingEnvironment.VirtualPathProvider.GetFileHash("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/InterfaceBuilderCachedJSScripts.cshtml", Enumerable.Repeat("~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/InterfaceBuilderCachedJSScripts.cshtml", 1))?.GetHashCode() ?? 0;
		}
		return html.Url().Content($"~/SDK.Action/JS/InterfaceBuilderScripts/{num}");
	}

	public void RenderInterfaceBuilderContent(HtmlHelper html)
	{
		html.get_ViewContext().get_Writer().WriteLine("//Start files");
		string[] scripts = GetScripts(html, "~/Modules/EleWise.ELMA.SDK.Web/Views/Shared/UI/InterfaceBuilderCachedJSScripts.cshtml");
		for (int i = 0; i < scripts.Length; i++)
		{
			try
			{
				string virtualPath = scripts[i];
				if (HostingEnvironment.VirtualPathProvider.FileExists(virtualPath))
				{
					using StreamReader streamReader = new StreamReader(HostingEnvironment.VirtualPathProvider.GetFile(virtualPath).Open());
					html.get_ViewContext().get_Writer().WriteLine();
					html.get_ViewContext().get_Writer().WriteLine(streamReader.ReadToEnd());
					html.get_ViewContext().get_Writer().WriteLine();
				}
			}
			catch (Exception exception)
			{
				Logger.Error("Cannot create JS", exception);
			}
		}
		html.get_ViewContext().get_Writer().WriteLine("//End files");
	}
}
