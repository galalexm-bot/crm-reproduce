// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.Attributes.ComplexCacheAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Cache.Attributes
{
  public class ComplexCacheAttribute : Attribute
  {
    internal static ComplexCacheAttribute c6V5y4fXCJoHPSFVF82l;

    public ComplexCacheAttribute(string timestampKey)
    {
      ComplexCacheAttribute.fPkUTpfXZ2aUvfR9BMgt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.TimestampKey = timestampKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public string TimestampKey
    {
      get => this.\u003CTimestampKey\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTimestampKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    internal static void fPkUTpfXZ2aUvfR9BMgt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool uAUnjLfXvLY6LJtK08KL() => ComplexCacheAttribute.c6V5y4fXCJoHPSFVF82l == null;

    internal static ComplexCacheAttribute mhR8B3fX81nE5OsOWkBX() => ComplexCacheAttribute.c6V5y4fXCJoHPSFVF82l;
  }
}
