// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.CacheLockInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о блокировке в кэше</summary>
  [Serializable]
  public class CacheLockInfo : CacheQueryInfo
  {
    internal static CacheLockInfo YtWItJEBos9jhiWAcLBt;

    /// <summary>Ctor</summary>
    public CacheLockInfo()
    {
      CacheLockInfo.QZotOOEBGZ2lByY6LRpx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Operation = (string) CacheLockInfo.McUS5vEBEOipgwWXsCnn(-1867198571 ^ -1867454493);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    internal static void QZotOOEBGZ2lByY6LRpx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object McUS5vEBEOipgwWXsCnn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool rjA08nEBb6Pyu9N7qb22() => CacheLockInfo.YtWItJEBos9jhiWAcLBt == null;

    internal static CacheLockInfo naeo4bEBhbeMinLnYRxK() => CacheLockInfo.YtWItJEBos9jhiWAcLBt;
  }
}
