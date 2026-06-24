// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.NotNullAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that the value of the marked element could never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] public object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.Delegate)]
  public sealed class NotNullAttribute : Attribute
  {
    internal static NotNullAttribute k20HUmfEYR5PMp5HDy88;

    public NotNullAttribute()
    {
      NotNullAttribute.pTka8JfEs4jmZhR0hXYn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void pTka8JfEs4jmZhR0hXYn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool u2vE2DfELmJ6NP73bH0N() => NotNullAttribute.k20HUmfEYR5PMp5HDy88 == null;

    internal static NotNullAttribute sTxcJmfEUyASlCbgukAO() => NotNullAttribute.k20HUmfEYR5PMp5HDy88;
  }
}
