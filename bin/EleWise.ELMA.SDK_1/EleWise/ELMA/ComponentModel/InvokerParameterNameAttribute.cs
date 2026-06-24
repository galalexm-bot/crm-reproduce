// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.InvokerParameterNameAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that the function argument should be string literal and match one
  /// of the parameters of the caller function. For example, ReSharper annotates
  /// the parameter of <see cref="T:System.ArgumentNullException" />.
  /// </summary>
  /// <example><code>
  /// public void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute
  {
    internal static InvokerParameterNameAttribute TsTx68ff8ZJbAqexJBF8;

    public InvokerParameterNameAttribute()
    {
      InvokerParameterNameAttribute.kYWKcmffIitCCoDYDNAO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void kYWKcmffIitCCoDYDNAO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool WhiEEEffZvlHWHVJFP8v() => InvokerParameterNameAttribute.TsTx68ff8ZJbAqexJBF8 == null;

    internal static InvokerParameterNameAttribute IYM4f7ffuVg7Dg9sn6yC() => InvokerParameterNameAttribute.TsTx68ff8ZJbAqexJBF8;
  }
}
