// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ByteArrayConstTimeEqualityExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Представляет расширение для сравнения двух массивов байтов за время не зависящее от содержимаго этих массивов.
  /// </summary>
  public static class ByteArrayConstTimeEqualityExtension
  {
    internal static ByteArrayConstTimeEqualityExtension aMpSC5GtuT25xwq5o1qx;

    /// <summary>
    /// Определяет равны ли два массива байтов за время не зависящее от содержимого этих массивов.
    /// Данный метод неэффективен. Для быстрого сравнения используйте ArrayEqualityComparer
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static bool Equals(byte[] x, byte[] y)
    {
      int num1 = 3;
      int num2;
      while (true)
      {
        int num3 = num1;
        int index;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ++index;
              num3 = 7;
              continue;
            case 2:
              index = 0;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_3;
            case 4:
              num2 |= (int) x[index] ^ (int) y[index];
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
              continue;
            case 5:
              if (index >= y.Length)
              {
                num3 = 6;
                continue;
              }
              goto case 4;
            case 6:
              goto label_10;
            default:
              if (index < x.Length)
              {
                num3 = 5;
                continue;
              }
              goto label_10;
          }
        }
label_3:
        num2 = x.Length ^ y.Length;
        num1 = 2;
      }
label_10:
      return num2 == 0;
    }

    internal static bool d0abRPGtI4f25925Y4hB() => ByteArrayConstTimeEqualityExtension.aMpSC5GtuT25xwq5o1qx == null;

    internal static ByteArrayConstTimeEqualityExtension WAW8J6GtVbpgF2RforKg() => ByteArrayConstTimeEqualityExtension.aMpSC5GtuT25xwq5o1qx;
  }
}
