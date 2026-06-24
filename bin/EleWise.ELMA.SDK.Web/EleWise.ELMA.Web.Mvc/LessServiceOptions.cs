using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using dotless.Core.configuration;
using dotless.Core.Plugins;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Web.Mvc;

internal class LessServiceOptions
{
	private const string VariablesFile = "import.less";

	private readonly string compiledCssSrc;

	private readonly string variables;

	private readonly DotlessConfiguration options;

	public string Variables => variables;

	public DotlessConfiguration Options => options;

	public string CompiledCssSrc
	{
		get
		{
			if (!Directory.Exists(compiledCssSrc))
			{
				CompiledCssSrcInitialize();
			}
			return compiledCssSrc;
		}
	}

	public LessServiceOptions(IEnumerable<ILayoutLessSourceProvider> lessSourceProviders, ILessFileService lessFileService)
	{
		variables = VariablesInitialize(lessSourceProviders);
		options = OptionsInitialize(lessSourceProviders, lessFileService);
		compiledCssSrc = CompiledCssSrcInitialize();
	}

	private string VariablesInitialize(IEnumerable<ILayoutLessSourceProvider> lessSourceProviders)
	{
		ILayoutLessSourceProvider layoutLessSourceProvider = lessSourceProviders.FirstOrDefault((ILayoutLessSourceProvider i) => i.Area == "EleWise.ELMA.SDK.Web");
		if (layoutLessSourceProvider != null)
		{
			using (StreamReader streamReader = new StreamReader(HostingEnvironment.VirtualPathProvider.GetFile(Path.Combine(layoutLessSourceProvider.ContentPath, "import.less")).Open()))
			{
				return streamReader.ReadToEnd();
			}
		}
		return string.Empty;
	}

	private DotlessConfiguration OptionsInitialize(IEnumerable<ILayoutLessSourceProvider> lessSourceProviders, ILessFileService lessFileService)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		DotlessConfiguration val = new DotlessConfiguration();
		val.set_LessSource(typeof(LessImportReader));
		val.set_Logger(typeof(LessLogger));
		val.set_MinifyOutput(true);
		GenericPluginConfigurator<LayoutPathResolverPlugin> val2 = new GenericPluginConfigurator<LayoutPathResolverPlugin>();
		val2.SetParameterValues((IEnumerable<IPluginParameter>)new List<IPluginParameter>
		{
			(IPluginParameter)(object)new LayoutPathResolverPluginParameters(lessSourceProviders),
			(IPluginParameter)(object)new LessFileServicePluginParameter(lessFileService)
		});
		val.get_Plugins().Add((IPluginConfigurator)(object)val2);
		return val;
	}

	private string CompiledCssSrcInitialize()
	{
		string text = HostingEnvironment.MapPath("~/App_Data/LessCompiledSrc");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}
}
