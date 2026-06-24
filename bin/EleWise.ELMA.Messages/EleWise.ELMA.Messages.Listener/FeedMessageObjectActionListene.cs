using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Messages.Components;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Messages.Listeners;

[Component]
public class FeedMessageObjectActionListener : IEntityActionHandler, IEventHandler
{
	public void ActionExecuted(EntityActionEventArgs e)
	{
		if (e != null && e.Action != null)
		{
			FeedMessageObjectUpdateHelper.UpdateMessageObjectInfo(e.New, e.Action.Uid, afterCommit: true);
		}
	}
}
