using System.Collections.Generic;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Notifications.Impl;

internal sealed class NotificationRecipientSetFromUsers : NotificationRecipientSet
{
	private readonly IEnumerable<IUser> users;

	public NotificationRecipientSetFromUsers(IEnumerable<IUser> users)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.users = users;
		base.Name = string.Empty;
	}

	public override IEnumerable<object> GetRecipients(INotification notification)
	{
		return users;
	}
}
