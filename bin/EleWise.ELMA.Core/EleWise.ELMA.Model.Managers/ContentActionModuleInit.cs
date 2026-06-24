using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Managers;

[Component]
internal sealed class ContentActionModuleInit : IModuleInit
{
	private readonly ContentActionManager contentActionManager;

	public ContentActionModuleInit(ContentActionManager contentActionManager)
	{
		this.contentActionManager = contentActionManager;
	}

	public System.Threading.Tasks.Task Init(Guid moduleUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return contentActionManager.Init(moduleUid);
	}
}
