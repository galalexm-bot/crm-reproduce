using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content;

[Component]
public class PageContentActionProvider : IControllerActionProvider
{
	private static string _formMetadataItemHeaderEql;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public static string ConfigurationPageContentActionId(IFormMetadataItemHeader header)
	{
		return ContentActionStatics.ConfigurationPageContentActionId(header.Name, RuntimeVersion.Version1);
	}

	public virtual IEnumerable<IContentAction> Actions()
	{
		_formMetadataItemHeaderEql = _formMetadataItemHeaderEql ?? $"not {LinqUtils.NameOf((Expression<Func<IFormMetadataItemHeader, object>>)((IFormMetadataItemHeader h) => h.Published))} is null and {LinqUtils.NameOf((Expression<Func<IFormMetadataItemHeader, object>>)((IFormMetadataItemHeader h) => h.MetadataType))}=Guid('{PageMetadata.TypeUid}')";
		return from p in AbstractNHEntityManager<IFormMetadataItemHeader, long>.Instance.Find(_formMetadataItemHeaderEql)
			select new ContentAction
			{
				Id = ConfigurationPageContentActionId(p),
				DescriptionForLocalization = p.DisplayName,
				Image24 = "#page_fill.svg",
				NameForLocalization = p.DisplayName,
				ReferenceType = "Page",
				LinkTemplate = (RequestContext context) => "/UI/Page/" + p.Name,
				Category = SR.M("Страницы конфигурации")
			};
	}

	public IEnumerable<IContentCategory> Categories()
	{
		return Enumerable.Empty<IContentCategory>();
	}
}
