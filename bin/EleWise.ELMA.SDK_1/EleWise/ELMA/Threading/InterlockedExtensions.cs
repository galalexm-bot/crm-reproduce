// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.InterlockedExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Threading;

namespace EleWise.ELMA.Threading
{
  /// <summary>
  /// Предоставляет атомарные операции для переменных, общедоступных нескольким потокам
  /// </summary>
  public static class InterlockedExtensions
  {
    internal static InterlockedExtensions N9FZN1Bi1pjX82NZi0xr;

    /// <summary>Сравнить и увеличить значение переменной</summary>
    /// <remarks>
    /// Если значение по адресу location меньше чем comparand, то инкрементировать его
    /// </remarks>
    /// <param name="location">Адрес операнда который сравниваем и увеличиваем</param>
    /// <param name="comparand">Значение с которым сравниваем</param>
    /// <returns><c>true</c> если значение было инкрементировано</returns>
    public static bool IncrementIfLess(ref int location, int comparand)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        int comparand1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (num3 == comparand1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              if (num3 == comparand1)
              {
                num2 = 5;
                continue;
              }
              goto label_7;
            case 3:
              goto label_7;
            case 4:
              num3 = location;
              num2 = 3;
              continue;
            case 5:
              goto label_3;
            case 6:
              if (comparand1 >= comparand)
              {
                num3 = location;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 2;
                continue;
              }
              num2 = 7;
              continue;
            case 7:
              num3 = Interlocked.CompareExchange(ref location, comparand1 + 1, comparand1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_7:
        comparand1 = num3;
        num1 = 6;
      }
label_3:
      return false;
label_5:
      return true;
    }

    internal static bool C5Xp1MBiN1yc5RufqOvn() => InterlockedExtensions.N9FZN1Bi1pjX82NZi0xr == null;

    internal static InterlockedExtensions oRtmHCBi3UBJ43YDFYGZ() => InterlockedExtensions.N9FZN1Bi1pjX82NZi0xr;
  }
}
