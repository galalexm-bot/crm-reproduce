// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.NHCacheProviderWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cache;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  public class NHCacheProviderWrapper : ICacheProvider
  {
    private static readonly ICacheProvider provider;
    private static bool providerStarted;
    private static readonly ConcurrentDictionary<string, NHCacheWrapper> caches;
    internal static NHCacheProviderWrapper b1nJNOWaSsuT8ogs9Iq8;

    static NHCacheProviderWrapper()
    {
      int num = 8;
      string str;
      while (true)
      {
        INHCacheService nhCacheService1;
        IRuntimeApplication service;
        object obj;
        INHCacheService nhCacheService2;
        switch (num)
        {
          case 1:
            str = (string) NHCacheProviderWrapper.SH2LdIWaTYM7DBKVn0NC(--1333735954 ^ 1333603196);
            num = 9;
            continue;
          case 2:
            if (NHCacheProviderWrapper.nTTlTCWaXaf2vtn6iGhS((object) str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
              continue;
            }
            goto case 9;
          case 3:
            if (service == null)
            {
              num = 6;
              continue;
            }
            nhCacheService2 = service.Providers.OfType<INHCacheService>().FirstOrDefault<INHCacheService>();
            break;
          case 4:
            obj = (object) null;
            goto label_18;
          case 5:
            goto label_2;
          case 6:
            nhCacheService2 = (INHCacheService) null;
            break;
          case 7:
            NHCacheProviderWrapper.caches = new ConcurrentDictionary<string, NHCacheWrapper>();
            num = 10;
            continue;
          case 8:
            NHCacheProviderWrapper.PoI4ErWaqaCq8VJMwgOV();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 7 : 6;
            continue;
          case 9:
            Type type = NHCacheProviderWrapper.TiERECWakkl22f3cnuWH((object) str);
            if (!(type == (Type) null))
            {
              NHCacheProviderWrapper.provider = (ICacheProvider) NHCacheProviderWrapper.We1M6IWan657TNGNcipP(type);
              num = 5;
              continue;
            }
            goto label_20;
          case 10:
            service = Locator.GetService<IRuntimeApplication>();
            num = 3;
            continue;
          default:
            if (nhCacheService1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 4;
              continue;
            }
            obj = NHCacheProviderWrapper.JGZY3wWaK15GWLrwaQ24((object) nhCacheService1);
            goto label_18;
        }
        nhCacheService1 = nhCacheService2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
        continue;
label_18:
        str = (string) obj;
        num = 2;
      }
label_2:
      return;
label_20:
      throw new InvalidOperationException((string) NHCacheProviderWrapper.SH2LdIWaTYM7DBKVn0NC(1669371371 ^ 1669500911) + str);
    }

    public ICache BuildCache(string regionName, IDictionary<string, string> properties) => (ICache) NHCacheProviderWrapper.caches.GetOrAdd(regionName, (Func<string, NHCacheWrapper>) (_ =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(NHCacheProviderWrapper.provider.BuildCache(regionName, properties) is CacheBase cache2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (NHCacheWrapper) null;
label_5:
      return new NHCacheWrapper(cache2);
    }));

    public long NextTimestamp() => NHCacheProviderWrapper.provider.NextTimestamp();

    public void Start(IDictionary<string, string> properties)
    {
      if (NHCacheProviderWrapper.providerStarted)
        return;
      NHCacheProviderWrapper.provider.Start(properties);
      NHCacheProviderWrapper.providerStarted = true;
    }

    public void Stop()
    {
    }

    /// <summary>Получить кэш для региона</summary>
    /// <param name="region">Регион</param>
    /// <param name="cache">Кэша</param>
    /// <returns>Получен ли кэш</returns>
    internal static bool TryGetCache(string region, out NHCacheWrapper cache) => NHCacheProviderWrapper.caches.TryGetValue(region, out cache);

    public NHCacheProviderWrapper()
    {
      NHCacheProviderWrapper.PoI4ErWaqaCq8VJMwgOV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void PoI4ErWaqaCq8VJMwgOV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object JGZY3wWaK15GWLrwaQ24([In] object obj0) => (object) ((INHCacheService) obj0).ProviderType;

    internal static bool nTTlTCWaXaf2vtn6iGhS([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object SH2LdIWaTYM7DBKVn0NC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type TiERECWakkl22f3cnuWH([In] object obj0) => Type.GetType((string) obj0);

    internal static object We1M6IWan657TNGNcipP([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static bool wEESRpWaik1Wa4BZqywG() => NHCacheProviderWrapper.b1nJNOWaSsuT8ogs9Iq8 == null;

    internal static NHCacheProviderWrapper UOyRbJWaR53J80L5MVRG() => NHCacheProviderWrapper.b1nJNOWaSsuT8ogs9Iq8;
  }
}
