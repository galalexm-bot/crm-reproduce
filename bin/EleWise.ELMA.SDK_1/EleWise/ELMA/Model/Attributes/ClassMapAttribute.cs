// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ClassMapAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут, указывающий класс маппинга для сущности</summary>
  [AttributeUsage(AttributeTargets.Class)]
  public class ClassMapAttribute : Attribute
  {
    private Type mapType;
    internal static ClassMapAttribute TSi8h8oug85MyBkmerrg;

    public ClassMapAttribute(Type mapType)
    {
      ClassMapAttribute.JhV4m8ouY64VXNmrwYVn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.mapType = mapType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public Type MapType => this.mapType;

    internal static void JhV4m8ouY64VXNmrwYVn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool u8HQXIou5i5p029n9bEh() => ClassMapAttribute.TSi8h8oug85MyBkmerrg == null;

    internal static ClassMapAttribute hnYsMyoujybAAs2nIMJY() => ClassMapAttribute.TSi8h8oug85MyBkmerrg;
  }
}
