using System;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.ActorModel.Starting;

public interface IServerStatusEventHandler : IEventHandler
{
	void ServerStarting(Guid serverUid);

	void ServerStarted(Guid serverUid, Version serverVersion);

	void ServerStoped(Guid serverUid);
}
