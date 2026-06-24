using System.Collections.Generic;

namespace EleWise.ELMA.Hubs;

public interface IHubCallerConnectionContextWrapper<T> : IHubConnectionContextWrapper<T>
{
	T Caller { get; }

	dynamic CallerState { get; }

	T Others { get; }

	T OthersInGroup(string groupName);

	T OthersInGroups(IList<string> groupNames);
}
