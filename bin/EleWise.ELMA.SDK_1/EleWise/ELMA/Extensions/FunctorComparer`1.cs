// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.FunctorComparer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Extensions
{
  public class FunctorComparer<T> : IComparer<T>
  {
    private readonly Comparison<T> comparison;

    public static FunctorComparer<T> Create(Comparison<T> comparison) => new FunctorComparer<T>(comparison);

    public FunctorComparer(Comparison<T> comparison)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.comparison = comparison != null ? comparison : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199683909));
    }

    public int Compare(T x, T y) => this.comparison(x, y);
  }
}
