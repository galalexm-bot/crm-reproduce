using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Web.Components;

[Component]
internal sealed class PageV2ContentActionProvider : IControllerActionProvider
{
	private static readonly ComponentMetadataItemHeaderFilter Filter = new ComponentMetadataItemHeaderFilter
	{
		IsPublished = true,
		MetadataTypeUid = PageComponentMetadata.TypeUid
	};

	private readonly ComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public PageV2ContentActionProvider(ComponentMetadataItemHeaderManager componentMetadataItemHeaderManager)
	{
		this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
	}

	public IEnumerable<IContentAction> Actions()
	{
		return from header in componentMetadataItemHeaderManager.Find(Filter, FetchOptions.All)
			select new ContentAction
			{
				Id = ContentActionStatics.ConfigurationPageContentActionId(header.Name, RuntimeVersion.Version2),
				DescriptionForLocalization = header.DisplayName,
				Image24 = "#page_outline.svg",
				NameForLocalization = header.DisplayName,
				ReferenceType = "Page",
				LinkTemplate = (RequestContext context) => "/UI/Page/" + header.Name,
				Category = SR.M("Страницы конфигурации")
			};
	}

	public IEnumerable<IContentCategory> Categories()
	{
		return Enumerable.Empty<IContentCategory>();
	}
}
