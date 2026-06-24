using System.Collections.Generic;
using dotless.Core.Plugins;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Web.Mvc;

internal sealed class LayoutPathResolverPlugin : IPlugin
{
	public IEnumerable<ILayoutLessSourceProvider> Providers { get; private set; }

	public ILessFileService LessFileService { get; private set; }

	public LayoutPathResolverPlugin(IEnumerable<ILayoutLessSourceProvider> providers, ILessFileService lessFileService)
	{
		Providers = providers;
		LessFileService = lessFileService;
	}
}
