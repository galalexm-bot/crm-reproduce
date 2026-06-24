using System.Collections.Generic;

namespace EleWise.ELMA.Hubs;

public interface IHubConnectionContextWrapper<T>
{
	T All { get; }

	T AllExcept(params string[] excludeConnectionIds);

	T Client(string connectionId);

	T Clients(IList<string> connectionIds);

	T Group(string groupName, params string[] excludeConnectionIds);

	T Groups(IList<string> groupNames, params string[] excludeConnectionIds);

	T User(string userId);

	T Users(IList<string> userIds);
}
