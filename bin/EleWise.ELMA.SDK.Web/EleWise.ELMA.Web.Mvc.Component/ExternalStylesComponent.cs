using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal sealed class ExternalStylesComponent : IExtensionZone
{
	private const string CssZoneId = "EleWise.ELMA.SDK.Web.DefaultStyles.ZoneAfter";

	private readonly IEnumerable<IExternalLessSourceProvider> externalProviders;

	public ExternalStylesComponent(IEnumerable<IExternalLessSourceProvider> externalProviders)
	{
		this.externalProviders = externalProviders;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		if (zoneId.Equals("EleWise.ELMA.SDK.Web.DefaultStyles.ZoneAfter"))
		{
			return externalProviders.Any();
		}
		return false;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		TextWriter writer = html.get_ViewContext().get_Writer();
		externalProviders.Where((IExternalLessSourceProvider p) => p.ShouldRender(html)).ForEach(delegate(IExternalLessSourceProvider p)
		{
			writer.Write(html.LinkCss("/Content/GetCss" + p.Prefix + "_" + p.FileName));
		});
	}
}
