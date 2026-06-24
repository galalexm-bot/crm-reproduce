// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.LazyWithReset`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Extensions
{
  public class LazyWithReset<T>
  {
    private Lazy<T> lazy;
    private readonly Func<T> factory;
    internal static object pokFURG6pLicGDLEr5v0;

    public LazyWithReset(Func<T> factory)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.factory = factory;
      this.lazy = new Lazy<T>(factory);
    }

    public T Value => this.lazy.Value;

    public void Reset()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.lazy = new Lazy<T>(this.factory);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool D1Zq7BG6aiSGrJqsC40O() => LazyWithReset<T>.pokFURG6pLicGDLEr5v0 == null;

    internal static object UgUBeiG6DPbB9Ziu3Abm() => LazyWithReset<T>.pokFURG6pLicGDLEr5v0;
  }
}
