// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ClassGeneratorAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут генератора кода класса для сущности</summary>
  public class ClassGeneratorAttribute : Attribute
  {
    private static ClassGeneratorAttribute c5elcCofHDpIkAOoV19D;

    /// <summary>Генератор класса</summary>
    public Type ClassGeneretorType { get; }

    /// <summary>Конструктор</summary>
    /// <param name="classGeneretorType">Тип генератора</param>
    public ClassGeneratorAttribute(Type classGeneretorType)
    {
      ClassGeneratorAttribute.UiDiJMofxBDJEijQec0W();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ClassGeneretorType = classGeneretorType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static void UiDiJMofxBDJEijQec0W() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TGGrqpofAPK3lILwEJXh() => ClassGeneratorAttribute.c5elcCofHDpIkAOoV19D == null;

    internal static ClassGeneratorAttribute gEHSGyof7LTwH6nfpEkv() => ClassGeneratorAttribute.c5elcCofHDpIkAOoV19D;
  }
}
