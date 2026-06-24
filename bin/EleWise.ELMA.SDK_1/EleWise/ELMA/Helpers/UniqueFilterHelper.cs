// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.UniqueFilterHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Помощник для работы с уникальными фильтрами.</summary>
  public static class UniqueFilterHelper
  {
    private static readonly ConcurrentDictionary<Guid, IUniqueFilterExtension> CachedMap;
    private static UniqueFilterHelper usftLHhsdLXOhvMlDxTW;

    /// <summary>Возвращает тип фильтра для уникального фильтра.</summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    public static Type GetUniqueFilterType(Guid uid)
    {
      int num = 3;
      IUniqueFilterExtension uniqueFilterExtension;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (uniqueFilterExtension != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            uniqueFilterExtension = (IUniqueFilterExtension) UniqueFilterHelper.f1XkgwhsgwXL7O9YvRfW(uid);
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (Type) null;
label_3:
      return UniqueFilterHelper.m0dtk2hs5lm9jpp4Arci((object) uniqueFilterExtension);
    }

    /// <summary>Возвращает тип сущности для уникального фильтра.</summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    public static Type GetUniqueFilterEntityType(Guid uid)
    {
      int num = 1;
      IUniqueFilterExtension uniqueFilterExtension;
      while (true)
      {
        switch (num)
        {
          case 1:
            uniqueFilterExtension = (IUniqueFilterExtension) UniqueFilterHelper.f1XkgwhsgwXL7O9YvRfW(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (uniqueFilterExtension == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (Type) null;
label_6:
      return UniqueFilterHelper.hc4BV4hsjsSphC6SA7n0((object) uniqueFilterExtension);
    }

    public static IUniqueFilterExtension GetExtension(Guid uid)
    {
      int num1 = 1;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            uid1 = uid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return UniqueFilterHelper.CachedMap.GetOrAdd(uid1, (Func<Guid, IUniqueFilterExtension>) (guid =>
      {
        int num2 = 2;
        List<IUniqueFilterExtension> list;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (list == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              // ISSUE: reference to a compiler-generated method
              list = ((ComponentManager) UniqueFilterHelper.\u003C\u003Ec__DisplayClass3_0.jIkYT8vMqlcZXZl6RvcW()).GetExtensionPoints<IUniqueFilterExtension>(true).ToList<IUniqueFilterExtension>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return (IUniqueFilterExtension) null;
label_6:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return list.FirstOrDefault<IUniqueFilterExtension>((Func<IUniqueFilterExtension, bool>) (m => UniqueFilterHelper.\u003C\u003Ec__DisplayClass3_0.qc9puvvMXrc1EfEkwXv2(UniqueFilterHelper.\u003C\u003Ec__DisplayClass3_0.uwiemEvMKPLGoe3Gr9cM((object) m), uid1)));
      }));
    }

    static UniqueFilterHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            UniqueFilterHelper.CachedMap = new ConcurrentDictionary<Guid, IUniqueFilterExtension>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object f1XkgwhsgwXL7O9YvRfW(Guid uid) => (object) UniqueFilterHelper.GetExtension(uid);

    internal static Type m0dtk2hs5lm9jpp4Arci([In] object obj0) => ((IUniqueFilterExtension) obj0).FilterType;

    internal static bool moOw90hslxq1eLwjFFIP() => UniqueFilterHelper.usftLHhsdLXOhvMlDxTW == null;

    internal static UniqueFilterHelper eTcmCdhsrmp5l8WHKsRr() => UniqueFilterHelper.usftLHhsdLXOhvMlDxTW;

    internal static Type hc4BV4hsjsSphC6SA7n0([In] object obj0) => ((IUniqueFilterExtension) obj0).EntityType;
  }
}
