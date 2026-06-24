// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.FunctorEqualityComparer`1
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
  public class FunctorEqualityComparer<T> : IEqualityComparer<T>
  {
    private readonly Func<T, T, bool> comparison;
    private readonly Func<T, int> getHashCode;

    /// <summary>ctor</summary>
    /// <param name="comparison">Метод сравнения</param>
    public FunctorEqualityComparer(Func<T, T, bool> comparison)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(comparison, (Func<T, int>) (obj => (object) obj != null ? obj.GetHashCode() : 0));
    }

    /// <summary>ctor</summary>
    /// <param name="comparison">Метод сравнения</param>
    /// <param name="getHashCode">Метод получения кэш-кода</param>
    public FunctorEqualityComparer(Func<T, T, bool> comparison, Func<T, int> getHashCode)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.NotNull((object) comparison, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536542498));
      Contract.NotNull((object) getHashCode, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951251834));
      this.comparison = comparison;
      this.getHashCode = getHashCode;
    }

    /// <summary>
    /// Создать <see cref="T:EleWise.ELMA.Extensions.FunctorEqualityComparer`1" />
    /// </summary>
    /// <param name="comparison">Метод сравнения</param>
    /// <returns><see cref="T:EleWise.ELMA.Extensions.FunctorEqualityComparer`1" /></returns>
    public static FunctorEqualityComparer<T> Create(Func<T, T, bool> comparison) => new FunctorEqualityComparer<T>(comparison);

    /// <summary>
    /// Создать <see cref="T:EleWise.ELMA.Extensions.FunctorEqualityComparer`1" />
    /// </summary>
    /// <param name="comparison">Метод сравнения</param>
    /// <param name="getHashCode">Метод получения кэш-кода</param>
    /// <returns><see cref="T:EleWise.ELMA.Extensions.FunctorEqualityComparer`1" /></returns>
    public static FunctorEqualityComparer<T> Create(
      Func<T, T, bool> comparison,
      Func<T, int> getHashCode)
    {
      return new FunctorEqualityComparer<T>(comparison, getHashCode);
    }

    /// <inheritdoc />
    public bool Equals(T x, T y) => this.comparison(x, y);

    /// <inheritdoc />
    public int GetHashCode(T obj) => this.getHashCode(obj);
  }
}
