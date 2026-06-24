// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.Partitioning.HashExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache.ActorModel.Partitioning
{
  /// <summary>
  /// Вспомогательный класс для получения хэшей и углов для равномерного распределения ключей по алгоритму Consistent Hashing (<seealso cref="!:https://www.toptal.com/big-data/consistent-hashing" />).
  /// </summary>
  internal static class HashExtensions
  {
    /// <summary>Максимальное значение угла.</summary>
    public static readonly double MaxAngle;
    internal static HashExtensions QbP9TIfXgwr1tHr0GAex;

    /// <summary>
    /// Возвращает хэш от строки по алгоритму Jenkins (<seealso cref="!:https://en.wikipedia.org/wiki/Jenkins_hash_function" />).
    /// </summary>
    /// <param name="text">Строка.</param>
    /// <returns>Хэш.</returns>
    public static uint ToHash(this string text)
    {
      int num1 = 11;
      uint hash;
      while (true)
      {
        int num2 = num1;
        char ch;
        string str;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              hash += (uint) ch;
              num2 = 13;
              continue;
            case 2:
              num3 = 0;
              num2 = 6;
              continue;
            case 3:
              hash += hash << 3;
              num2 = 9;
              continue;
            case 4:
              ch = HashExtensions.FoQ8lFfXY1SL7Kw2FGWW((object) str, num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
              continue;
            case 5:
              goto label_16;
            case 6:
            case 7:
              if (num3 >= str.Length)
              {
                num2 = 3;
                continue;
              }
              goto case 4;
            case 8:
              hash += hash << 15;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            case 9:
              hash ^= hash >> 11;
              num2 = 8;
              continue;
            case 10:
              str = text;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 2;
              continue;
            case 11:
              hash = 0U;
              num2 = 10;
              continue;
            case 12:
              goto label_15;
            case 13:
              hash += hash << 10;
              num2 = 12;
              continue;
            default:
              goto label_3;
          }
        }
label_15:
        hash ^= hash >> 6;
        num1 = 5;
        continue;
label_16:
        ++num3;
        num1 = 7;
      }
label_3:
      return hash;
    }

    /// <summary>
    /// Возвращает угол для указанного <paramref name="hash" />.
    /// </summary>
    /// <param name="hash">Хэш.</param>
    /// <returns>Угол.</returns>
    public static double ToAngle(this uint hash) => (double) hash * HashExtensions.MaxAngle / (double) uint.MaxValue;

    static HashExtensions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            HashExtensions.MaxAngle = 360.0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static char FoQ8lFfXY1SL7Kw2FGWW([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static bool sJEShFfX5RaGekLFhqh0() => HashExtensions.QbP9TIfXgwr1tHr0GAex == null;

    internal static HashExtensions KiIp5yfXjpHjBbC4LJUY() => HashExtensions.QbP9TIfXgwr1tHr0GAex;
  }
}
