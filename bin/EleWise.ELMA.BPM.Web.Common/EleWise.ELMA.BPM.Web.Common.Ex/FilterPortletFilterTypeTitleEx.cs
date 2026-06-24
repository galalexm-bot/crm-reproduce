using System;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = 10000)]
public class FilterPortletFilterTypeTitleExtensions : IFilterPortletFilterTypeTitle
{
	public bool AvailableType(Guid TypeUid)
	{
		return true;
	}

	public string GetTitle(Guid TypeUid, Guid? Code = null)
	{
		try
		{
			FilterMenuItem filterMenuItem = Locator.GetServiceNotNull<FilterMenuProvider>().FilterMenuItemByTypeUidandCode(TypeUid, Code);
			return Locator.GetServiceNotNull<ControllerActionRegistry>().Action(filterMenuItem.Routes).Name;
		}
		catch
		{
			return ((ClassMetadata)MetadataLoader.LoadMetadata(TypeUid)).DisplayName;
		}
	}
}
