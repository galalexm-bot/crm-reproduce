using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using dotless.Core.Input;
using dotless.Core.Plugins;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Web.Mvc;

internal sealed class LessImportReader : IFileReader
{
	private readonly string layoutPathResolverPluginName = "LayoutPathResolverPlugin";

	private readonly IEnumerable<ILayoutLessSourceProvider> layoutLessSourceProviders;

	private readonly ILessFileService lessFileService;

	public bool UseCacheDependencies => false;

	public LessImportReader(IEnumerable<IPluginConfigurator> configurators)
	{
		LayoutPathResolverPlugin layoutPathResolverPlugin = configurators.FirstOrDefault((IPluginConfigurator p) => p.get_Name() == layoutPathResolverPluginName).CreatePlugin() as LayoutPathResolverPlugin;
		Contract.NotNull(layoutPathResolverPlugin, "pluginResolver");
		layoutLessSourceProviders = layoutPathResolverPlugin.Providers;
		lessFileService = layoutPathResolverPlugin.LessFileService;
	}

	private bool IsImporting(string fileName)
	{
		return fileName.StartsWith("@");
	}

	private string GetFileNameWithArea(string fileName, out string area)
	{
		area = string.Empty;
		string[] array = fileName.Remove(0, 1).Split('/');
		if (array.Any())
		{
			area = array[0];
			fileName = string.Join("/", array.Skip(1));
		}
		return fileName;
	}

	private string GetUniqueKey(string fileName)
	{
		LessFileModel current = lessFileService.GetCurrent();
		if (current != null)
		{
			return $"{current.Location}_{fileName}";
		}
		return fileName;
	}

	private string ReadData(string directory, string fileName)
	{
		using StreamReader streamReader = new StreamReader(HostingEnvironment.VirtualPathProvider.GetFile(Path.Combine(directory, fileName)).Open());
		return streamReader.ReadToEnd();
	}

	private string GetFileNamePath(string fileName)
	{
		LessFileModel current = lessFileService.GetCurrent();
		if (current != null)
		{
			return Path.Combine(current.Location, fileName);
		}
		return string.Empty;
	}

	public bool DoesFileExist(string fileName)
	{
		if (IsImporting(fileName))
		{
			GetFileNameWithArea(fileName, out var area);
			return layoutLessSourceProviders.Any((ILayoutLessSourceProvider p) => p.Area == area);
		}
		return File.Exists(GetFileNamePath(fileName));
	}

	public byte[] GetBinaryFileContents(string fileName)
	{
		throw new NotImplementedException();
	}

	public string GetFileContents(string fileName)
	{
		return ContextVars.GetOrAdd(GetUniqueKey(fileName), delegate
		{
			if (IsImporting(fileName))
			{
				fileName = GetFileNameWithArea(fileName, out var area);
				ILayoutLessSourceProvider layoutLessSourceProvider = layoutLessSourceProviders.FirstOrDefault((ILayoutLessSourceProvider i) => i.Area == area);
				if (layoutLessSourceProvider != null)
				{
					return ReadData(layoutLessSourceProvider.ContentPath, fileName);
				}
			}
			return File.ReadAllText(GetFileNamePath(fileName));
		});
	}
}
