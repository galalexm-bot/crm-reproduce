using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPortletImageTitle
{
	bool AvailableFilterType(Guid TypeUid);

	void GetImageTitle(Guid TypeUid, Guid? Code, out string imageUrl, out string title);

	string GetImage(Guid TypeUid, Guid? Code);
}
