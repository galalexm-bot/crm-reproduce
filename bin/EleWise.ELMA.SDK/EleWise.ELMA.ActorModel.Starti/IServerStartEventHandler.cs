using System;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.ActorModel.Starting;

internal interface IServerStartEventHandler : IEventHandler
{
	void StartServer(Version clusterVersion);
}
