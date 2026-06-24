// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.NHCacheWrapper.NHCacheWrapperSynchronizer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.NHCacheWrapper
{
  /// <inheritdoc />
  internal sealed class NHCacheWrapperSynchronizer : 
    Actor,
    INHCacheWrapperSynchronizer,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    internal static NHCacheWrapperSynchronizer M8Hcn4faMM2rMGlRVk1x;

    /// <inheritdoc />
    public Task DisableCache(IList<string> regions)
    {
      foreach (string region in (IEnumerable<string>) regions)
      {
        EleWise.ELMA.Runtime.NH.NHCacheWrapper cache;
        if (region != null && NHCacheProviderWrapper.TryGetCache(region, out cache) && cache != null)
          cache.Disable();
      }
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task EnableCache(IList<string> regions)
    {
      foreach (string region in (IEnumerable<string>) regions)
      {
        EleWise.ELMA.Runtime.NH.NHCacheWrapper cache;
        if (region != null && NHCacheProviderWrapper.TryGetCache(region, out cache) && cache != null)
          cache.Enable();
      }
      return Task.CompletedTask;
    }

    public NHCacheWrapperSynchronizer()
    {
      NHCacheWrapperSynchronizer.xjQIWwfadSdbXLneHTdt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void xjQIWwfadSdbXLneHTdt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IcvdWkfaJDy5XyvdvSwS() => NHCacheWrapperSynchronizer.M8Hcn4faMM2rMGlRVk1x == null;

    internal static NHCacheWrapperSynchronizer Ie0B0Gfa9QXUOlMSlj6u() => NHCacheWrapperSynchronizer.M8Hcn4faMM2rMGlRVk1x;
  }
}
