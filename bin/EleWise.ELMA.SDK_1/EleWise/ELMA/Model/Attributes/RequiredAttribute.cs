// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.RequiredAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Обязательно для заполнения.</summary>
  public class RequiredAttribute : Attribute
  {
    private static RequiredAttribute tureY3oIimmGYndjCE9D;

    public bool Required
    {
      get => this.\u003CRequired\u003Ek__BackingField;
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
              this.\u003CRequired\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

    public RequiredAttribute(bool required)
    {
      RequiredAttribute.O7vWxQoIKxF7UKYS8VwG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Required = required;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool WQTiOvoIRdeC2HG6BKCf() => RequiredAttribute.tureY3oIimmGYndjCE9D == null;

    internal static RequiredAttribute bUGBfuoIqZkxAykLqJ4B() => RequiredAttribute.tureY3oIimmGYndjCE9D;

    internal static void O7vWxQoIKxF7UKYS8VwG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
