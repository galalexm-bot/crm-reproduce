using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Content.Listeners;

[Component]
public class MenuItemActionHandler : IEntityActionHandler, IEventHandler
{
	public void ActionExecuted(EntityActionEventArgs e)
	{
		IMenuItem menuItem = e.Old as IMenuItem;
		IMenuItem menuItem2 = e.New as IMenuItem;
		if (menuItem != null || menuItem2 != null)
		{
			if (e.Action != null && e.Action.Uid != DefaultEntityActions.CreateGuid && e.Action.Uid != DefaultEntityActions.UpdateGuid)
			{
				_ = e.Action.Uid != DefaultEntityActions.DeleteGuid;
			}
			if (menuItem != null && menuItem.Menu != null)
			{
				MenuItemManager.Instance.ResetItemsCache(menuItem.Menu.Uid);
			}
			if (menuItem2 != null && menuItem2.Menu != null)
			{
				MenuItemManager.Instance.ResetItemsCache(menuItem2.Menu.Uid);
			}
		}
	}
}
