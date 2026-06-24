using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;

namespace EleWise.ELMA.Content.ExtensionPoints;

[Component]
internal class ExclusionEntityNullifierContent : IExclusionEntityNullifier
{
	public List<Guid> SetExclusion()
	{
		List<Guid> result = new List<Guid>
		{
			InterfaceActivator.UID<IHomePageSetting>(),
			InterfaceActivator.UID<IWorkplacePages>(),
			InterfaceActivator.UID<IPageBase>(),
			InterfaceActivator.UID<IPortalObjectPermission>(),
			InterfaceActivator.UID<IPageFolder>(),
			InterfaceActivator.UID<IWebToolbar>(),
			InterfaceActivator.UID<IPortletPage>(),
			WorkPlaceManager.DefaultWorkplacePagesUid,
			WorkPlaceManager.DefaultWorkPlaceUid
		};
		InterfaceActivator.UID<ICreateMenu>();
		InterfaceActivator.UID<IMenu>();
		InterfaceActivator.UID<IMenuItem>();
		InterfaceActivator.UID<IMenuItemPermission>();
		return result;
	}
}
