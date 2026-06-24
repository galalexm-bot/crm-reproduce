using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Content.Components;

[Component]
internal class ContentIgnoreUidUI : IIgnoreUidUI
{
	public virtual bool NeedIgnoreUid(EntityMetadata md)
	{
		if (md.Uid == InterfaceActivator.UID<IPortalObjectPermission>())
		{
			return true;
		}
		return false;
	}
}
