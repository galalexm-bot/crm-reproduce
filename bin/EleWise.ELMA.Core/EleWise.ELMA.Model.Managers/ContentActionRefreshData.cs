using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Managers;

[Component]
internal sealed class ContentActionRefreshData : IRefreshData
{
	private readonly ContentActionManager contentActionManager;

	public ContentActionRefreshData(ContentActionManager contentActionManager)
	{
		this.contentActionManager = contentActionManager;
	}

	public void Refresh(Guid moduleUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		contentActionManager.Refresh(moduleUid);
	}
}
