// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.Attributes.ContextCacheAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Cache.Attributes
{
  /// <summary>
  /// Кеширование возвращаемого значения метода по значениям параметров в кеше контекста (для web приложени это HttpContext.Current)
  /// </summary>
  public class ContextCacheAttribute : Attribute
  {
    internal static ContextCacheAttribute VFMJYCfXKPewYHK36gJu;

    /// <summary>Регион контекстного кэша, если нужен</summary>
    public string Region
    {
      get => this.\u003CRegion\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CRegion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public ContextCacheAttribute()
    {
      ContextCacheAttribute.hlIMqwfXkhCryLqlWRYk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Gwca8efXX5Wi12E2pFol() => ContextCacheAttribute.VFMJYCfXKPewYHK36gJu == null;

    internal static ContextCacheAttribute fNf12ofXTa2FsOPf2GXL() => ContextCacheAttribute.VFMJYCfXKPewYHK36gJu;

    internal static void hlIMqwfXkhCryLqlWRYk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
