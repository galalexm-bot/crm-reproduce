using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal class MenuItemListener : EntityEventsListener
{
	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IMenuItem menuItem)
		{
			if (menuItem.MenuUid == Guid.Empty)
			{
				menuItem.MenuUid = menuItem.Uid;
			}
			if (menuItem.Menu != null)
			{
				menuItem.Menu.ItemsChangeDate = DateTime.Now;
			}
		}
		return false;
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		UpdateMenuItemsChangeDate(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMenuItem);
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		UpdateMenuItemsChangeDate(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMenuItem);
	}

	private void UpdateMenuItemsChangeDate(IMenuItem menuItem)
	{
		if (menuItem != null && menuItem.Menu != null)
		{
			menuItem.Menu.ItemsChangeDate = DateTime.Now;
			menuItem.Menu.Save();
		}
	}
}
