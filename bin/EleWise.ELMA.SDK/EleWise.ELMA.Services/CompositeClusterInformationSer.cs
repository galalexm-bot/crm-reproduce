using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class CompositeClusterInformationService : ICompositeClusterInformationService
{
	private readonly IActorModelRuntimeProvider actorModelRuntimeProvider;

	private readonly IEnumerable<IExternalClusterInfo> externalClusters;

	public CompositeClusterInformationService(IActorModelRuntimeProvider actorModelRuntimeProvider, IEnumerable<IExternalClusterInfo> externalClusters)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.actorModelRuntimeProvider = actorModelRuntimeProvider;
		this.externalClusters = externalClusters;
	}

	public IEnumerable<Guid> GetActiveConnectionUids()
	{
		return actorModelRuntimeProvider.ActiveConnections.Concat(externalClusters.SelectMany((IExternalClusterInfo cluster) => cluster.GetActiveConnectionUids()));
	}
}
