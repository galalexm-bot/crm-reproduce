// Decompiled with JetBrains decompiler
// Type: System.Runtime.Caching.MemoryCacheExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace System.Runtime.Caching
{
  /// <summary>
  /// Расширение для <see cref="T:System.Runtime.Caching.MemoryCache" />
  /// </summary>
  public static class MemoryCacheExtensions
  {
    internal static MemoryCacheExtensions CTmswkEusk35y2ZZ3EX;

    /// <summary>Очистить кэш</summary>
    /// <param name="cache">Кэш</param>
    public static void Clear(this MemoryCache cache)
    {
      int num = 1;
      MemoryCache cache1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            // ISSUE: reference to a compiler-generated method
            ((IEnumerable<string>) cache1.Select<KeyValuePair<string, object>, string>((Func<KeyValuePair<string, object>, string>) (p => p.Key)).ToArray<string>()).Select<string, object>((Func<string, object>) (k => MemoryCacheExtensions.\u003C\u003Ec__DisplayClass0_0.dFBg9ZfHVyticAUBbUUT((object) cache1, (object) k, (object) null))).Count<object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 1;
            continue;
          case 4:
            MemoryCacheExtensions.KQQPVPESCC6q802ZmO4((object) cache1, 100);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 3 : 0;
            continue;
          default:
            cache1 = cache;
            num = 4;
            continue;
        }
      }
label_2:;
    }

    internal static long KQQPVPESCC6q802ZmO4([In] object obj0, [In] int obj1) => ((MemoryCache) obj0).Trim(obj1);

    internal static bool tYCRc1EIOCcHMlT3lQf() => MemoryCacheExtensions.CTmswkEusk35y2ZZ3EX == null;

    internal static MemoryCacheExtensions mZSIKYEVLG1Ztd6eoPh() => MemoryCacheExtensions.CTmswkEusk35y2ZZ3EX;
  }
}
