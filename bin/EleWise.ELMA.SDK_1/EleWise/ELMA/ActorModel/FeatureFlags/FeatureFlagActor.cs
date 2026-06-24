// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.FeatureFlags.FeatureFlagActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.FeatureFlags
{
  /// <summary>Актор для работы с флагами функций в рамках кластера</summary>
  internal sealed class FeatureFlagActor : 
    Actor,
    IFeatureFlagActor,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly ILazy<FeatureFlagService> featureFlagService;
    private readonly ILazy<DistributedFeatureFlagService> distributedFeatureFlagService;

    /// <summary>Ctor</summary>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    /// <param name="distributedFeatureFlagService">Распределенный сервис флагов функций</param>
    public FeatureFlagActor(
      ILazy<FeatureFlagService> featureFlagService,
      ILazy<DistributedFeatureFlagService> distributedFeatureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.featureFlagService = featureFlagService;
      this.distributedFeatureFlagService = distributedFeatureFlagService;
    }

    /// <inheritdoc />
    public Task<bool?> Enabled(string featureFlagName) => Task.FromResult<bool?>(this.featureFlagService.Value.Enabled(featureFlagName));

    /// <inheritdoc />
    public Task UpdateCache(Guid serverUid, IDictionary<string, bool?> featureFlags) => !this.distributedFeatureFlagService.IsRegistered ? Task.CompletedTask : this.distributedFeatureFlagService.Value.UpdateCache(serverUid, featureFlags);
  }
}
