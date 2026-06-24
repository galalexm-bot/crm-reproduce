using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Components;

[Component]
internal class ConfigurationScriptsErrorHeader : IExtensionZone
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IConfigurationScriptsErrorService configurationScriptsErrorService;

	public ConfigurationScriptsErrorHeader(IMetadataRuntimeService metadataRuntimeService, IConfigurationScriptsErrorService configurationScriptsErrorService)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.configurationScriptsErrorService = configurationScriptsErrorService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "BeforeContentZone")
		{
			return metadataRuntimeService.ConfigurationScriptsRecompileRequired;
		}
		return false;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		html.get_ViewContext().get_Writer().WriteLine(PartialExtensions.Partial(html, "ConfigurationScriptsError/Header", (object)configurationScriptsErrorService));
	}
}
