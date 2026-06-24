using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component(Order = 500, Type = ComponentType.Server, EnableInterceptiors = true)]
public class FeedModuleEvents : IModuleContainerEvents
{
	public IEnumerable<IFeedMessageUpdateProvider> FeedMessageUpdateProviders { get; set; }

	public ISecurityService SecurityService => Locator.GetService<ISecurityService>();

	private static void IndexesEnable()
	{
		FeedManager.Instance.IndexesEnable();
	}

	private static void FeedRepair()
	{
		IBLOBDataManager bLOBManager = DataAccessManager.BLOBManager;
		int num = bLOBManager.GetBLOB<int?>(MessagesConstants.AssemblyUid, "FeedRepair") ?? 0;
		if (num != 1)
		{
			bLOBManager.SetBLOB(MessagesConstants.AssemblyUid, "FeedRepair", (int?)1);
		}
	}

	public void Activated()
	{
		FeedRepair();
		IndexesEnable();
	}

	public void Terminating()
	{
	}
}
