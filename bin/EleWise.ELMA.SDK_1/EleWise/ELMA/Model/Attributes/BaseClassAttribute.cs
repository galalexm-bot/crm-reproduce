// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.BaseClassAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Базовый класс для сущности</summary>
  public class BaseClassAttribute : Attribute
  {
    private Guid baseClassUid;
    private static BaseClassAttribute sAZVDEouzKKyml85YO3x;

    public Guid BaseClassUid
    {
      get => this.baseClassUid;
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
              this.baseClassUid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

    public BaseClassAttribute()
    {
      BaseClassAttribute.wMYqnmoIW3x0wAFY87ny();
      this.baseClassUid = Guid.Empty;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="baseClassUid">Uid базового класса</param>
    public BaseClassAttribute(string baseClassUid)
    {
      BaseClassAttribute.wMYqnmoIW3x0wAFY87ny();
      this.baseClassUid = Guid.Empty;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.baseClassUid = new Guid(baseClassUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool L86tbAoIFPnmLyGAXJ17() => BaseClassAttribute.sAZVDEouzKKyml85YO3x == null;

    internal static BaseClassAttribute QKei2ioIBFA3dd8NtmXW() => BaseClassAttribute.sAZVDEouzKKyml85YO3x;

    internal static void wMYqnmoIW3x0wAFY87ny() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
