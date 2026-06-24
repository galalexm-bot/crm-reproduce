// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ComplexCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache
{
  [Service(EnableInterceptors = false, Type = ComponentType.Server)]
  public class ComplexCacheService : ComplexCacheServiceBase, IComplexCacheService
  {
    internal static ComplexCacheService XTfrqrfqlrIoyHNSwq3K;

    public ComplexCacheService(
      ICacheService cacheService,
      IMemoryCacheService memoryCacheService,
      IContextBoundVariableService contextCacheService)
    {
      ComplexCacheService.IkQL7efq5h4jEuxZqG6q();
      // ISSUE: explicit constructor call
      base.\u002Ector(cacheService, memoryCacheService, contextCacheService);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void IkQL7efq5h4jEuxZqG6q() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool PA7lGVfqrvOdENVutxUi() => ComplexCacheService.XTfrqrfqlrIoyHNSwq3K == null;

    internal static ComplexCacheService I40YhmfqgFemfx3Cn4Io() => ComplexCacheService.XTfrqrfqlrIoyHNSwq3K;
  }
}
