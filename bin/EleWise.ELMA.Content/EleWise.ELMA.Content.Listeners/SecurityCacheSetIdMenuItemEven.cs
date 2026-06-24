using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Events;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal class SecurityCacheSetIdMenuItemEventHandler : ISecurityCacheSetIdEventHandler, IEventHandler
{
	public void Execute()
	{
		MenuItemManager.Instance.ResetItemsCache();
	}

	public void PostCacheSet(SecurityCacheSetIdEventArgs args)
	{
		if (args.FullUpdate)
		{
			MenuItemManager.Instance.ResetItemsCache();
			return;
		}
		(from d in args.GroupAddUsers.Concat(args.GroupRemoveUsers).Concat(args.OrganizationItemAddUsers).Concat(args.OrganizationItemRemoveUsers)
			select d.Item2).ForEach(MenuItemManager.Instance.ResetItems4UserCache);
	}
}
