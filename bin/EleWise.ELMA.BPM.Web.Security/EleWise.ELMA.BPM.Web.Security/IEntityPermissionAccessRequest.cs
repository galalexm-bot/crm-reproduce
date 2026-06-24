using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
internal interface IEntityPermissionAccessRequestRenderer
{
	bool CanRender(IEntityPermissionAccessRequestProvider permissionAccessRequestProvider);

	void Render(Guid entityTypeUid, long entityId, HtmlHelper helper);
}
