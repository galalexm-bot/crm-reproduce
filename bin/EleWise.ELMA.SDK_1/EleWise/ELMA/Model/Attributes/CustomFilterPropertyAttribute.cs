// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.CustomFilterPropertyAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут навешивается на свойство фильтра и указывает, что это свойство кастомное (не привязанное к свойству сущности)
  /// </summary>
  [AttributeUsage(AttributeTargets.Property)]
  public class CustomFilterPropertyAttribute : Attribute
  {
    private static CustomFilterPropertyAttribute wdQE6ko8BiqQkPRBWaKd;

    public CustomFilterPropertyAttribute()
    {
      CustomFilterPropertyAttribute.f3CBEUo8b94rxlpBeuwV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void f3CBEUo8b94rxlpBeuwV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool owyZrQo8WQIF7FI9wxs7() => CustomFilterPropertyAttribute.wdQE6ko8BiqQkPRBWaKd == null;

    internal static CustomFilterPropertyAttribute ISkkTGo8og0kb1lLuOHr() => CustomFilterPropertyAttribute.wdQE6ko8BiqQkPRBWaKd;
  }
}
