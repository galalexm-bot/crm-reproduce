using EleWise.ELMA.Security;

namespace EleWise.ELMA.Notifications;

public interface INotificationManager
{
	void Send(INotification notification);

	bool AddUserToIgnoreList(IUser user);

	void RemoveUserFromIgnoreList(IUser user);

	bool AddUserToForceSendList(IUser user);

	void RemoveUserFromForceSendList(IUser user);
}
