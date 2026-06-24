using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using NuGet;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class StoreComponentIcon : IObjectIcon
{
	public bool CheckType(Type type)
	{
		return type.IsInheritOrSame<IStoreComponentInfo>();
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		IStoreComponentInfo storeComponentInfo = (IStoreComponentInfo)obj;
		SemanticVersion val = (storeComponentInfo.IsInstalled ? storeComponentInfo.InstalledVersion : storeComponentInfo.LastVersion);
		return url.Action("StoreComponent", "Images", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			ComponentId = storeComponentInfo.Id,
			Version = ((val != (SemanticVersion)null) ? ((object)val).ToString() : "")
		});
	}
}
