using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.ActorModel.Starting;

internal interface IStartingActor : IActorWithGuidKey, IActor
{
	Task Start(Guid serverUid);

	Task Finish(Guid serverUid, Version serverVersion);

	Task ConfigurationScriptsRecompileRequired(Guid serverUid);
}
