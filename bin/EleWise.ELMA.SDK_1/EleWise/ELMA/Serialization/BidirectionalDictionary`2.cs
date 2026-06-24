// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.BidirectionalDictionary`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Двунаправленный словарь. Ключом может быть как значение, так и ключ
  /// </summary>
  /// <typeparam name="TFirst">Тип первого аргумента</typeparam>
  /// <typeparam name="TSecond">Тип второго аргумента</typeparam>
  internal class BidirectionalDictionary<TFirst, TSecond>
  {
    private readonly IDictionary<TFirst, TSecond> firstToSecond;
    private readonly IDictionary<TSecond, TFirst> secondToFirst;
    private readonly string duplicateFirstErrorMessage;
    private readonly string duplicateSecondErrorMessage;
    private static object p8SesBBJKHLDdHDmdLLp;

    /// <summary>Ctor</summary>
    public BidirectionalDictionary()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector((IEqualityComparer<TFirst>) EqualityComparer<TFirst>.Default, (IEqualityComparer<TSecond>) EqualityComparer<TSecond>.Default);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="firstEqualityComparer">Первый компаратор</param>
    /// <param name="secondEqualityComparer">Второй компаратор</param>
    public BidirectionalDictionary(
      IEqualityComparer<TFirst> firstEqualityComparer,
      IEqualityComparer<TSecond> secondEqualityComparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(firstEqualityComparer, secondEqualityComparer, z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813691851), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576074818));
    }

    /// <summary>Ctor</summary>
    /// <param name="firstEqualityComparer">Первый компаратор</param>
    /// <param name="secondEqualityComparer">Второй компаратор</param>
    /// <param name="duplicateFirstErrorMessage">Сообщение при ошибке первого ключа</param>
    /// <param name="duplicateSecondErrorMessage">Сообщение при ошибке второго ключа</param>
    public BidirectionalDictionary(
      IEqualityComparer<TFirst> firstEqualityComparer,
      IEqualityComparer<TSecond> secondEqualityComparer,
      string duplicateFirstErrorMessage,
      string duplicateSecondErrorMessage)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.firstToSecond = (IDictionary<TFirst, TSecond>) new Dictionary<TFirst, TSecond>(firstEqualityComparer);
      this.secondToFirst = (IDictionary<TSecond, TFirst>) new Dictionary<TSecond, TFirst>(secondEqualityComparer);
      this.duplicateFirstErrorMessage = duplicateFirstErrorMessage;
      this.duplicateSecondErrorMessage = duplicateSecondErrorMessage;
    }

    /// <summary>Присвоить значение</summary>
    /// <param name="first">Первое значение</param>
    /// <param name="second">Второе значение</param>
    /// <exception cref="T:System.ArgumentException">Возникает при несоответсвии первого(второго) значения, если оно находится в словаре</exception>
    public void Set(TFirst first, TSecond second)
    {
      TSecond second1;
      if (this.firstToSecond.TryGetValue(first, out second1) && !second1.Equals((object) second))
        throw new ArgumentException(this.duplicateFirstErrorMessage.FormatWith((IFormatProvider) CultureInfo.InvariantCulture, (object) first));
      TFirst first1;
      if (this.secondToFirst.TryGetValue(second, out first1) && !first1.Equals((object) first))
        throw new ArgumentException(this.duplicateSecondErrorMessage.FormatWith((IFormatProvider) CultureInfo.InvariantCulture, (object) second));
      this.firstToSecond.Add(first, second);
      this.secondToFirst.Add(second, first);
    }

    /// <summary>Попытаться получить по первому значению</summary>
    /// <param name="first">Первое значение</param>
    /// <param name="second">Возвращаемое значение по ключу</param>
    /// <returns><c>true</c>, если найдено второе значение по ключу</returns>
    public bool TryGetByFirst(TFirst first, out TSecond second) => this.firstToSecond.TryGetValue(first, out second);

    /// <summary>Попытаться получить по второму значению</summary>
    /// <param name="second">Второе значение</param>
    /// <param name="first">Возвращаемое значение по ключу</param>
    /// <returns><c>true</c>, если найдено первое значение по ключу</returns>
    public bool TryGetBySecond(TSecond second, out TFirst first) => this.secondToFirst.TryGetValue(second, out first);

    /// <summary>Получить значение по первому ключу</summary>
    /// <param name="first">Первое значение</param>
    /// <returns>Значение по ключу</returns>
    public TSecond GetByFirst(TFirst first) => this.firstToSecond[first];

    /// <summary>Получить значение по второму ключу</summary>
    /// <param name="second">Второе значение</param>
    /// <returns>Значение по ключу</returns>
    public TFirst GetBySecond(TSecond second) => this.secondToFirst[second];

    internal static bool FwvywNBJX0vWIO3F1oxG() => BidirectionalDictionary<TFirst, TSecond>.p8SesBBJKHLDdHDmdLLp == null;

    internal static object EpZiMDBJTpgcOpL168Ij() => BidirectionalDictionary<TFirst, TSecond>.p8SesBBJKHLDdHDmdLLp;
  }
}
