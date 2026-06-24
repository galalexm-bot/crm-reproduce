// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.RestartRequiredAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает, что при изменении свойства требуется перезапуск сервера, чтобы изменения в модели вступили в силу
  /// </summary>
  [AttributeUsage(AttributeTargets.Property)]
  [Obsolete("Атрибут устарел и больше не используется. Используйте EleWise.ELMA.Model.Attributes.PublicationBehaviourAttribute", true)]
  public class RestartRequiredAttribute : Attribute
  {
    internal static RestartRequiredAttribute HA5QxRoCsxEroylJrT2O;

    public RestartRequiredAttribute()
    {
      RestartRequiredAttribute.RXGnd1ovFoVVPaB6BVQi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void RXGnd1ovFoVVPaB6BVQi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TNYnHUoCcDl8J4LQSYCf() => RestartRequiredAttribute.HA5QxRoCsxEroylJrT2O == null;

    internal static RestartRequiredAttribute dyJvl3oCzsJVr8JLbFS0() => RestartRequiredAttribute.HA5QxRoCsxEroylJrT2O;
  }
}
