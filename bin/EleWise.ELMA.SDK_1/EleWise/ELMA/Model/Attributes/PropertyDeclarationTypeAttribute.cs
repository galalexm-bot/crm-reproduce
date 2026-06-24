// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PropertyDeclarationTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут навешивается на свойство реализации интерфейса и указывает тип, в котором было объявлено данное свойство (автореализуемый интерфейс или расширение)
  /// </summary>
  [AttributeUsage(AttributeTargets.Property)]
  public class PropertyDeclarationTypeAttribute : Attribute
  {
    private Type type;
    private static PropertyDeclarationTypeAttribute TNmSK2oZhWg0e0JM1LRl;

    /// <summary>Ctor</summary>
    /// <param name="type">Тип</param>
    public PropertyDeclarationTypeAttribute(Type type)
    {
      PropertyDeclarationTypeAttribute.XmaLWSoZfwvrWmrjFROM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип</summary>
    public Type Type => this.type;

    internal static void XmaLWSoZfwvrWmrjFROM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QfSxBpoZGrL8jHUJloxa() => PropertyDeclarationTypeAttribute.TNmSK2oZhWg0e0JM1LRl == null;

    internal static PropertyDeclarationTypeAttribute EDYk6poZEntZAhCAHA3P() => PropertyDeclarationTypeAttribute.TNmSK2oZhWg0e0JM1LRl;
  }
}
