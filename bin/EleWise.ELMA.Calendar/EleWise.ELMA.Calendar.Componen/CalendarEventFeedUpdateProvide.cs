using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component]
internal class CalendarEventFeedUpdateProvider : FeedMessageUpdateProviderBase<ICalendarEvent>
{
	protected override bool UpdateMessage(FeedModel messageModel, [CanBeNull] FeedModel parentModel, ICalendarEvent entity, [CanBeNull] IEntity parentEntity)
	{
		bool result = base.UpdateMessage(messageModel, parentModel, entity, parentEntity);
		if (entity == null && messageModel.ActionUid == DefaultEntityActions.DeleteGuid)
		{
			messageModel.Parent = messageModel.Clone();
			messageModel.Parent.ActionUid = DefaultEntityActions.CreateGuid;
			messageModel.Text = SR.T("Событие удалено");
			return result;
		}
		int currentUserId = Convert.ToInt32(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId());
		List<IUser> source = CalendarEventManager.Instance.ConfirmParticipationRecipient(entity);
		if (source.Any((IUser u) => currentUserId == u.Id))
		{
			messageModel.Text = string.Format("{0}\r\n{1}", SR.T("НЕОБХОДИМО ПОДТВЕРДИТЬ ВАШЕ УЧАСТИЕ В ДАННОМ СОБЫТИИ!!!"), messageModel.Text);
		}
		return result;
	}
}
