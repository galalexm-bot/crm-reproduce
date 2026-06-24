using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = 1000)]
public class FilterPortletImageTitleCatalogsExtensions : IFilterPortletImageTitle
{
	public FilterMenuProvider FilterMenuProvider { get; set; }

	public bool AvailableFilterType(Guid TypeUid)
	{
		IMetadata metadata = MetadataLoader.LoadMetadata(TypeUid);
		if (metadata is EntityMetadata)
		{
			return ((EntityMetadata)metadata).ShowInCatalogList;
		}
		return false;
	}

	public void GetImageTitle(Guid TypeUid, Guid? Code, out string imageUrl, out string title)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(TypeUid) as EntityMetadata;
		if (entityMetadata != null && entityMetadata.Images != null && entityMetadata.Images.Count > 0)
		{
			UrlHelper val = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
			imageUrl = val.Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = TypeUid,
				size = 24
			});
		}
		else
		{
			FilterMenuItem filterMenuItem = FilterMenuProvider.FilterMenuItemByTypeUidandCode(TypeUid, Code);
			imageUrl = Locator.GetServiceNotNull<ControllerActionRegistry>().Get(filterMenuItem.Code)?.Image24;
		}
		title = ((entityMetadata != null) ? entityMetadata.DisplayName : SR.T("Данные по фильтру"));
	}

	public string GetImage(Guid TypeUid, Guid? Code)
	{
		try
		{
			FilterMenuItem filterMenuItem = FilterMenuProvider.FilterMenuItemByTypeUidandCode(TypeUid, Code);
			return Locator.GetServiceNotNull<ControllerActionRegistry>().Action(filterMenuItem.Routes).GetImage();
		}
		catch
		{
			return "#faq.svg";
		}
	}
}
