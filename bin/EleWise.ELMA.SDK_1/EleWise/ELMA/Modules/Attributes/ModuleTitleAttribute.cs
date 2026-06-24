// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.ModuleTitleAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>Указывает отображаемое имя модуля ELMA</summary>
  [AttributeUsage(AttributeTargets.Assembly)]
  public class ModuleTitleAttribute : Attribute
  {
    private string title;
    private static ModuleTitleAttribute QmMARRaIuukceTMBVTZ;

    /// <summary>Ctor</summary>
    /// <param name="title">Отображаемое имя модуля</param>
    public ModuleTitleAttribute(string title)
    {
      ModuleTitleAttribute.ckpTnwai04tZqKHMhvf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.title = title;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Отображаемое имя модуля</summary>
    public string Title => this.title;

    internal static void ckpTnwai04tZqKHMhvf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MbVT72aVDiPxk5Wnr6Z() => ModuleTitleAttribute.QmMARRaIuukceTMBVTZ == null;

    internal static ModuleTitleAttribute dPY57RaSDycM8x6JuCi() => ModuleTitleAttribute.QmMARRaIuukceTMBVTZ;
  }
}
