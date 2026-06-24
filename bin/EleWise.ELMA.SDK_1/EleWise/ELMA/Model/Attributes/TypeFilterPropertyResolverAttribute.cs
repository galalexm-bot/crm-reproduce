// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.TypeFilterPropertyResolverAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Класс обертки для сохранения в фильтре</summary>
  public class TypeFilterPropertyResolverAttribute : Attribute
  {
    private Guid value;
    internal static TypeFilterPropertyResolverAttribute Jhv8ygovBtM4sSF7uIvZ;

    public TypeFilterPropertyResolverAttribute()
    {
      TypeFilterPropertyResolverAttribute.KiwJ7dovbMyofd5gBmml();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TypeFilterPropertyResolverAttribute(string value)
    {
      TypeFilterPropertyResolverAttribute.KiwJ7dovbMyofd5gBmml();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.value = new Guid(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public Guid Value
    {
      get => this.value;
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
              this.value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    internal static void KiwJ7dovbMyofd5gBmml() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ysvaZ6ovWXwUOQ8bqOSv() => TypeFilterPropertyResolverAttribute.Jhv8ygovBtM4sSF7uIvZ == null;

    internal static TypeFilterPropertyResolverAttribute yoahhsovomykuThFgxmt() => TypeFilterPropertyResolverAttribute.Jhv8ygovBtM4sSF7uIvZ;
  }
}
