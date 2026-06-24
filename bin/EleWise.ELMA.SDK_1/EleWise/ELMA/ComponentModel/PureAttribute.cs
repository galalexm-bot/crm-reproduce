// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.PureAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that a method does not make any observable state changes.
  /// The same as <c>PureAttribute</c>.
  /// </summary>
  /// <example><code>
  /// [Pure] private int Multiply(int x, int y) { return x * y; }
  /// public void Foo() {
  ///   const int a = 2, b = 2;
  ///   Multiply(a, b); // Waring: Return value of pure method is not used
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class PureAttribute : Attribute
  {
    private static PureAttribute CcjfmbffL74JgppSZCMe;

    public PureAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qg6JEiffUCVXgdtahShY() => PureAttribute.CcjfmbffL74JgppSZCMe == null;

    internal static PureAttribute VZo8YRffsWef3WyqdJxJ() => PureAttribute.CcjfmbffL74JgppSZCMe;
  }
}
