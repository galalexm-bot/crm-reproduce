// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.Calculated`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Аналог Lazy, но вынкция вычисленимя передается каждый рахз при запросе занчения, нет поддержки многопоточночти.
  /// </summary>
  public class Calculated<T>
  {
    private bool calculated;
    private T value;
    private static object CfL77TG44L1XcTYPUEig;

    public T Value(Func<T> func)
    {
      if (!this.calculated)
      {
        this.value = func();
        this.calculated = true;
      }
      return this.value;
    }

    public Calculated()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool v3MmK0G46qAMCXuqch6S() => Calculated<T>.CfL77TG44L1XcTYPUEig == null;

    internal static object XY1VkuG4HKqXdP1nwfbd() => Calculated<T>.CfL77TG44L1XcTYPUEig;
  }
}
