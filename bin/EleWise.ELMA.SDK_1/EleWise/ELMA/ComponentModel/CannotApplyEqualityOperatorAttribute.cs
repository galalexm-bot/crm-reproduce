// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.CannotApplyEqualityOperatorAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that the value of the marked type (or its derivatives)
  /// cannot be compared using '==' or '!=' operators and <c>Equals()</c>
  /// should be used instead. However, using '==' or '!=' for comparison
  /// with <c>null</c> is always permitted.
  /// </summary>
  /// <example><code>
  /// [CannotApplyEqualityOperator]
  /// class NoEquality { }
  /// class UsesNoEquality {
  ///   public void Test() {
  ///     var ca1 = new NoEquality();
  ///     var ca2 = new NoEquality();
  ///     if (ca1 != null) { // OK
  ///       bool condition = ca1 == ca2; // Warning
  ///     }
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute
  {
    private static CannotApplyEqualityOperatorAttribute epbEm0ffe4dkxW0XbY6y;

    public CannotApplyEqualityOperatorAttribute()
    {
      CannotApplyEqualityOperatorAttribute.WguRiBffN3yh0oHmbnqv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void WguRiBffN3yh0oHmbnqv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vbucrcffPCCXAqWSZpBR() => CannotApplyEqualityOperatorAttribute.epbEm0ffe4dkxW0XbY6y == null;

    internal static CannotApplyEqualityOperatorAttribute ibH4Ebff10nLqCTq97Sb() => CannotApplyEqualityOperatorAttribute.epbEm0ffe4dkxW0XbY6y;
  }
}
