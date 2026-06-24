using System;
using System.Collections.Generic;
using dotless.Core.Plugins;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc;

internal sealed class LayoutPathResolverPluginParameters : IPluginParameter
{
	private readonly object providers;

	public string Name => "providers";

	public bool IsMandatory => true;

	public object Value => providers;

	private Type Type => typeof(IEnumerable<ILayoutLessSourceProvider>);

	public string TypeDescription => Type.Name;

	public LayoutPathResolverPluginParameters(IEnumerable<ILayoutLessSourceProvider> providers)
	{
		this.providers = providers;
	}

	public void SetValue(string value)
	{
	}
}
