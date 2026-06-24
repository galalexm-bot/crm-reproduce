using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Security.Extensions;

namespace EleWise.ELMA.Messages.Listeners;

[Component]
public class InformationChannelSecurityCacheSetIdAction : ISecurityCacheSetIdAction
{
	public void Execute()
	{
		InformationChannelManager.Instance.RefreshPermissionsCacheType();
	}
}
