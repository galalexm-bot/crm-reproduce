// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.Pair`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>
  /// Класс для работы с парой объектов, как вариант ключ = значение
  /// Картеж их двух элементов.
  /// </summary>
  /// <typeparam name="TFirst"></typeparam>
  /// <typeparam name="TSecond"></typeparam>
  [Serializable]
  public class Pair<TFirst, TSecond>
  {
    private TFirst _first;
    private TSecond _second;
    internal static object vZOcMEhXhVUlaul1MVpa;

    /// <summary>
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    public Pair(TFirst first, TSecond second)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._first = first;
      this._second = second;
    }

    /// <summary>
    /// </summary>
    public Pair()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Значение первого элемента</summary>
    public TFirst First
    {
      get => this._first;
      set => this._first = value;
    }

    /// <summary>Значение второго элемента</summary>
    public TSecond Second
    {
      get => this._second;
      set => this._second = value;
    }

    /// <summary>
    /// Создать пару с однаковыми типа и одинаковыми значениями
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Pair<TFirst, TFirst> CreateSame(TFirst value) => new Pair<TFirst, TFirst>(value, value);

    public bool Equals(Pair<TFirst, TSecond> obj)
    {
      if (obj == null)
        return false;
      if (this == obj)
        return true;
      return object.Equals((object) obj._first, (object) this._first) && object.Equals((object) obj._second, (object) this._second);
    }

    public override bool Equals(object obj)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                continue;
              }
              if (this == obj)
              {
                num2 = 3;
                continue;
              }
              goto label_6;
            case 2:
              goto label_8;
            case 3:
              goto label_5;
            case 4:
              goto label_9;
            default:
              goto label_10;
          }
        }
label_6:
        if (!(obj.GetType() != typeof (Pair<TFirst, TSecond>)))
          num1 = 4;
        else
          goto label_8;
      }
label_5:
      return true;
label_8:
      return false;
label_9:
      return this.Equals((Pair<TFirst, TSecond>) obj);
label_10:
      return false;
    }

    public override int GetHashCode()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if ((object) this._first == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      int num2 = typeof (TFirst).GetHashCode();
      goto label_6;
label_5:
      num2 = this._first.GetHashCode() * 397;
label_6:
      int num3 = (object) this._second == null ? typeof (TSecond).GetHashCode() : this._second.GetHashCode();
      return num2 ^ num3;
    }

    public override string ToString() => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867019901), (object) this._first, (object) this._second);

    internal static bool h66sFXhXGtqVVt4PLb1K() => Pair<TFirst, TSecond>.vZOcMEhXhVUlaul1MVpa == null;

    internal static object XoKpBChXEGKEYMJ0WF97() => Pair<TFirst, TSecond>.vZOcMEhXhVUlaul1MVpa;
  }
}
