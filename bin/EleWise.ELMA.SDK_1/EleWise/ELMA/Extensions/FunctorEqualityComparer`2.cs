// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.FunctorEqualityComparer`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Extensions
{
  public class FunctorEqualityComparer<T, TV> : IEqualityComparer<T>
  {
    private readonly Func<T, TV> func;

    public FunctorEqualityComparer(Func<T, TV> func)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.func = func;
    }

    public static FunctorEqualityComparer<T, TV> Create(Func<T, TV> func) => new FunctorEqualityComparer<T, TV>(func);

    public bool Equals(T x, T y) => object.Equals((object) this.func(x), (object) this.func(y));

    public int GetHashCode(T obj)
    {
      object obj1 = (object) this.func(obj);
      return obj1 is null ? 0 : obj1.GetHashCode();
    }
  }
}
