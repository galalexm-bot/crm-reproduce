// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.NHQueryCacheFactoryWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Cache;
using NHibernate.Cfg;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.NH
{
  public class NHQueryCacheFactoryWrapper : IQueryCacheFactory
  {
    private static NHQueryCacheFactoryWrapper uTooeEWDWW0Bwn5N3aYm;

    public NHQueryCacheFactoryWrapper()
    {
      NHQueryCacheFactoryWrapper.nkDSKsWDhJbc0DJErjJw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public IQueryCache GetQueryCache(
      string regionName,
      UpdateTimestampsCache updateTimestampsCache,
      Settings settings,
      IDictionary<string, string> props)
    {
      return (IQueryCache) new NHQueryCacheWrapper(regionName, updateTimestampsCache, settings, props);
    }

    internal static void nkDSKsWDhJbc0DJErjJw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool LFuk5xWDoTvhB4wEGFMR() => NHQueryCacheFactoryWrapper.uTooeEWDWW0Bwn5N3aYm == null;

    internal static NHQueryCacheFactoryWrapper ziPYSVWDbhrASZyROB4O() => NHQueryCacheFactoryWrapper.uTooeEWDWW0Bwn5N3aYm;
  }
}
