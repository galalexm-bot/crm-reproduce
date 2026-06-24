using System;
using dotless.Core.Plugins;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Web.Mvc;

internal sealed class LessFileServicePluginParameter : IPluginParameter
{
	private readonly object providers;

	public string Name => "lessFileService";

	public bool IsMandatory => true;

	public object Value => providers;

	private Type Type => typeof(ILessFileService);

	public string TypeDescription => Type.Name;

	public LessFileServicePluginParameter(ILessFileService lessFileService)
	{
		providers = lessFileService;
	}

	public void SetValue(string value)
	{
	}
}
