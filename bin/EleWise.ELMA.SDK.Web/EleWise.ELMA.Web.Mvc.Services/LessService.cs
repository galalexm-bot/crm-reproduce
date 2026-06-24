using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;
using dotless.Core;
using dotless.Core.Exceptions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Services;

[Service(EnableInterceptors = false, Type = ComponentType.Web)]
internal sealed class LessService : ILessService
{
	private readonly ILogger logger;

	private object locker = new object();

	private readonly LessServiceOptions lessOptions;

	private readonly ILessFileService lessFileService;

	private readonly IEnumerable<ILayoutLessSourceProvider> lessSourceProviders;

	private readonly IColorSchemeLessService colorSchemeService;

	public LessService(IEnumerable<ILayoutLessSourceProvider> lessSourceProviders, ILessFileService lessFileService, IColorSchemeLessService colorSchemeService, ILogger logger)
	{
		lessOptions = new LessServiceOptions(lessSourceProviders, lessFileService);
		this.logger = logger;
		this.lessFileService = lessFileService;
		this.lessSourceProviders = lessSourceProviders;
		this.colorSchemeService = colorSchemeService;
	}

	public string Bundle()
	{
		StringBuilder stringBuilder = new StringBuilder();
		ColorSchemeLessModel colorScheme = GetColorScheme();
		VirtualPathProvider virtualPathProvider = HostingEnvironment.VirtualPathProvider;
		foreach (ILayoutLessSourceProvider lessSourceProvider in lessSourceProviders)
		{
			LessFileModel item = GetLess(colorScheme, lessSourceProvider, lessSourceProvider.FileName, virtualPathProvider).Item1;
			if (item != null && !item.Content.IsNullOrEmpty())
			{
				stringBuilder.AppendLine(item.Content);
			}
		}
		return stringBuilder.ToString();
	}

	public string CreateTemporaryCss(string zone, string src)
	{
		string result = string.Empty;
		if (TryGetProvider(zone, out var provider))
		{
			ColorSchemeLessModel colorScheme = GetColorScheme();
			VirtualPathProvider virtualPathProvider = HostingEnvironment.VirtualPathProvider;
			var (lessFileModel, text) = GetLess(colorScheme, provider, src, virtualPathProvider);
			if (lessFileModel != null && !lessFileModel.Content.IsNullOrEmpty())
			{
				result = text;
			}
		}
		return result;
	}

	public string GetTemporaryCss(string href)
	{
		string empty = string.Empty;
		if (!href.IsNullOrEmpty())
		{
			if (!(HttpRuntime.Cache[href] is LessFileModel lessFileModel))
			{
				return string.Empty;
			}
			return lessFileModel.Content;
		}
		return empty;
	}

	public bool TemporaryCssExists(string zone, string src)
	{
		if (!string.IsNullOrWhiteSpace(src) && TryGetProvider(zone, out var provider))
		{
			ColorSchemeLessModel colorScheme = GetColorScheme();
			VirtualPathProvider virtualPathProvider = HostingEnvironment.VirtualPathProvider;
			LessFileModel item = GetLess(colorScheme, provider, src, virtualPathProvider).Item1;
			if (item != null)
			{
				return !item.Content.IsNullOrEmpty();
			}
			return false;
		}
		return false;
	}

	public string GetTemporaryCssHref(string zone, string src)
	{
		return CreateTemporaryCss(zone, src);
	}

	public LessFileModel ParseLess(string zone, string src)
	{
		if (TryGetProvider(zone, out var provider))
		{
			return ParseLess(provider, src);
		}
		return null;
	}

	public LessFileModel ParseLess(ILayoutLessSourceProvider lessSourceProvider, string src)
	{
		if (lessSourceProvider == null || src.IsNullOrEmpty())
		{
			return null;
		}
		ColorSchemeLessModel colorScheme = GetColorScheme();
		VirtualPathProvider virtualPathProvider = HostingEnvironment.VirtualPathProvider;
		return GetLess(colorScheme, lessSourceProvider, src, virtualPathProvider).Item1;
	}

	public LessFileModel ParseLess(string path)
	{
		return ParseLess(path, GetColorScheme());
	}

	private LessFileModel ParseLess(string path, ColorSchemeLessModel colorScheme)
	{
		//IL_0079: Expected O, but got Unknown
		lock (locker)
		{
			LessFileModel lessFileModel = null;
			try
			{
				ILessFileService obj = lessFileService;
				LessFileModel obj2 = new LessFileModel
				{
					FileName = Path.GetFileName(path),
					Path = path,
					Location = Path.GetDirectoryName(path)
				};
				lessFileModel = obj2;
				obj.SetCurrent(obj2);
				lessFileModel.Content = Less.Parse(lessOptions.Variables + colorScheme.Variables + File.ReadAllText(path), lessOptions.Options);
			}
			catch (ParserException val)
			{
				ParserException exception = val;
				logger.Error("Cannot compile Less to Css", (Exception)(object)exception);
			}
			return lessFileModel;
		}
	}

	private string CreateHref(string hash, string fileName)
	{
		return string.Format("{0}_{1}", hash, fileName.Replace("/", "_"));
	}

	private bool TryGetProvider(string zone, out ILayoutLessSourceProvider provider)
	{
		foreach (ILayoutLessSourceProvider lessSourceProvider in lessSourceProviders)
		{
			if (zone == lessSourceProvider.Area)
			{
				provider = lessSourceProvider;
				return true;
			}
		}
		provider = null;
		return false;
	}

	private (LessFileModel, string) GetLess(ColorSchemeLessModel colorScheme, ILayoutLessSourceProvider provider, string fileName, VirtualPathProvider virtualPathProvider)
	{
		if (fileName.IsNullOrEmpty())
		{
			return (null, string.Empty);
		}
		string virtualPath = Path.Combine(provider.ContentPath, fileName);
		string text = VirtualPathUtility.ToAbsolute(virtualPath);
		string text2 = CreateHref(colorScheme.Name, text);
		LessFileModel lessFileModel = HttpRuntime.Cache[text2] as LessFileModel;
		if (lessFileModel != null && colorScheme.CreationDate.HasValue && colorScheme.CreationDate != lessFileModel.LastModifyDate)
		{
			HttpRuntime.Cache.Remove(text2);
			lessFileModel = null;
		}
		if (lessFileModel == null)
		{
			CacheDependency cacheDependency = virtualPathProvider.GetCacheDependency(text, new string[1] { text }, DateTime.UtcNow);
			if (cacheDependency != null)
			{
				string name = virtualPathProvider.GetFile(virtualPath).Name;
				lessFileModel = ParseLess(name, colorScheme);
				if (lessFileModel != null && colorScheme.CreationDate.HasValue)
				{
					lessFileModel.LastModifyDate = colorScheme.CreationDate.Value;
				}
				HttpRuntime.Cache.Insert(text2, lessFileModel, cacheDependency);
			}
		}
		return (lessFileModel, text2);
	}

	private ColorSchemeLessModel GetColorScheme()
	{
		return ContextVars.GetOrAdd("ColorScheme", () => colorSchemeService.GetScheme(lessOptions.CompiledCssSrc));
	}
}
