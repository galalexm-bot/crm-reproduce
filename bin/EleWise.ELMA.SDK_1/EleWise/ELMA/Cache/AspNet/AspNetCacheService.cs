// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.AspNet.AspNetCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Caching;

namespace EleWise.ELMA.Cache.AspNet
{
  public class AspNetCacheService : CacheService, INHCacheService
  {
    private static AspNetCacheService shpxH1fKpqKwMu7OGK47;

    protected override void InsertValue<T>(
      string key,
      object value,
      string region,
      TimeSpan cacheDuration,
      CacheItemRemovedCallback<T> onRemoveItemCallback)
    {
      DateTime absoluteExpiration = DateTime.Now.Add(cacheDuration);
      CacheDependency dependencies = (CacheDependency) null;
      if (region != null)
      {
        if (HttpRuntime.Cache.Get(region) == null)
          HttpRuntime.Cache.Insert(region, new object(), (CacheDependency) null, absoluteExpiration, TimeSpan.Zero, CacheItemPriority.Normal, (CacheItemRemovedCallback) null);
        dependencies = new CacheDependency((string[]) null, new string[1]
        {
          region
        });
      }
      HttpRuntime.Cache.Insert(key, CacheService.AssembleValue<object>(value), dependencies, absoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Normal, onRemoveItemCallback == null ? (CacheItemRemovedCallback) null : (CacheItemRemovedCallback) ((s, o, reason) =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              onRemoveItemCallback(s, CacheService.DisassembleValue<T>(o), (EleWise.ELMA.Cache.CacheItemRemovedReason) reason);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    protected override bool ContainsInternal(string key, string region) => ((System.Web.Caching.Cache) AspNetCacheService.Ln301EfKt9ijy8Gsj80h()).Get(key) != null;

    protected override object GetValue(string key, string region) => ((System.Web.Caching.Cache) AspNetCacheService.Ln301EfKt9ijy8Gsj80h()).Get(key);

    protected override void RemoveInternal(string key, string region)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_2;
          case 2:
            if (!string.IsNullOrEmpty(key))
            {
              AspNetCacheService.owURaufKwvuKcmWMkm4P(AspNetCacheService.Ln301EfKt9ijy8Gsj80h(), (object) key);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    protected override void ClearRegionInternal(string region)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            AspNetCacheService.owURaufKwvuKcmWMkm4P(AspNetCacheService.Ln301EfKt9ijy8Gsj80h(), (object) region);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 3;
            continue;
          case 2:
            if (!AspNetCacheService.W9naR1fK4nNNTm7VSe8i((object) region))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 3:
            goto label_6;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_6:
      return;
label_8:
      return;
label_2:;
    }

    string INHCacheService.ProviderType => (string) AspNetCacheService.S4FoXLfK6oV5aGBTy6ih(-951514650 ^ -951381880);

    public AspNetCacheService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Ln301EfKt9ijy8Gsj80h() => (object) HttpRuntime.Cache;

    internal static bool lilA7DfKaW9X66w0i9ao() => AspNetCacheService.shpxH1fKpqKwMu7OGK47 == null;

    internal static AspNetCacheService mR9s7MfKDClURLc9Mv8h() => AspNetCacheService.shpxH1fKpqKwMu7OGK47;

    internal static object owURaufKwvuKcmWMkm4P([In] object obj0, [In] object obj1) => ((System.Web.Caching.Cache) obj0).Remove((string) obj1);

    internal static bool W9naR1fK4nNNTm7VSe8i([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object S4FoXLfK6oV5aGBTy6ih(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
