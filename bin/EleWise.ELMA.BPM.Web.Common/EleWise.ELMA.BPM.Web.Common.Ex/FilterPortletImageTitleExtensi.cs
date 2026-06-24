using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = 10000)]
public class FilterPortletImageTitleExtensions : IFilterPortletImageTitle
{
	public FilterMenuProvider FilterMenuProvider { get; set; }

	public bool AvailableFilterType(Guid TypeUid)
	{
		return true;
	}

	public void GetImageTitle(Guid TypeUid, Guid? Code, out string imageUrl, out string title)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(TypeUid) as EntityMetadata;
		ContentAction contentAction = new ContentAction();
		try
		{
			FilterMenuItem filterMenuItem = FilterMenuProvider.FilterMenuItemByTypeUidandCode(TypeUid, Code);
			contentAction = Locator.GetServiceNotNull<ControllerActionRegistry>().Action(filterMenuItem.Routes);
			title = contentAction.Name;
		}
		catch
		{
			title = ((entityMetadata != null) ? entityMetadata.DisplayName : SR.T("Данные по фильтру"));
		}
		if (contentAction.Image24 == null && entityMetadata != null && entityMetadata.Images != null && entityMetadata.Images.Count > 0)
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
			imageUrl = contentAction.Image24;
		}
	}

	public string GetImage(Guid TypeUid, Guid? Code)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(TypeUid) as EntityMetadata;
		try
		{
			FilterMenuItem filterMenuItem = FilterMenuProvider.FilterMenuItemByTypeUidandCode(TypeUid, Code);
			return Locator.GetServiceNotNull<ControllerActionRegistry>().Action(filterMenuItem.Routes).GetImage();
		}
		catch
		{
			if (entityMetadata != null && entityMetadata.Images != null && entityMetadata.Images.Count > 0)
			{
				return new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext).Action("Object", "Images", (object)new
				{
					area = "EleWise.ELMA.SDK.Web",
					id = TypeUid
				});
			}
			return null;
		}
	}
}
