// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.CompositeClusterInformationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class CompositeClusterInformationService : ICompositeClusterInformationService
  {
    private readonly IActorModelRuntimeProvider actorModelRuntimeProvider;
    private readonly IEnumerable<IExternalClusterInfo> externalClusters;

    /// <summary>Ctor</summary>
    /// <param name="actorModelRuntimeProvider">Провайдер среды Actor Model</param>
    /// <param name="externalClusters">Информация о внешних кластерах</param>
    public CompositeClusterInformationService(
      IActorModelRuntimeProvider actorModelRuntimeProvider,
      IEnumerable<IExternalClusterInfo> externalClusters)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.actorModelRuntimeProvider = actorModelRuntimeProvider;
      this.externalClusters = externalClusters;
    }

    /// <inheritdoc />
    public IEnumerable<Guid> GetActiveConnectionUids() => this.actorModelRuntimeProvider.ActiveConnections.Concat<Guid>(this.externalClusters.SelectMany<IExternalClusterInfo, Guid>((Func<IExternalClusterInfo, IEnumerable<Guid>>) (cluster => cluster.GetActiveConnectionUids())));
  }
}
