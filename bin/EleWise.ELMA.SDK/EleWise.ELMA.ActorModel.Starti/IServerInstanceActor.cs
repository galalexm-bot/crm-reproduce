using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.ActorModel.Starting;

internal interface IServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task<DbConnectionStatus> GetStatus();

	Task<Version> GetVersion();

	Task ServerStarted(Guid serverUid, Version serverVersion);
}
