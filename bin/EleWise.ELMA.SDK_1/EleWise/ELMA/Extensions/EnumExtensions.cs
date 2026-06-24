// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.EnumExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для перечислений</summary>
  public static class EnumExtensions
  {
    internal static EnumExtensions g31uKTG6WEYhtLLtNSXZ;

    /// <summary>
    /// Входит ли текущее значение в указанный список значений
    /// </summary>
    /// <param name="value">Текущее значение</param>
    /// <param name="values">Список значений</param>
    /// <returns>True, если входит</returns>
    public static bool In(this Enum value, params Enum[] values)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        int index;
        Enum @enum;
        Enum[] enumArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              @enum = enumArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 7 : 7;
              continue;
            case 2:
              index = 0;
              num2 = 4;
              continue;
            case 3:
              goto label_7;
            case 4:
            case 6:
              if (index >= enumArray.Length)
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            case 5:
              goto label_3;
            case 7:
              if (value.Equals((object) @enum))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              }
              ++index;
              num2 = 6;
              continue;
            default:
              goto label_11;
          }
        }
label_7:
        enumArray = values;
        num1 = 2;
      }
label_3:
      return false;
label_11:
      return true;
    }

    internal static bool afW4ujG6oQsa57veNPGX() => EnumExtensions.g31uKTG6WEYhtLLtNSXZ == null;

    internal static EnumExtensions vRpgyCG6bKt8V9YAaA77() => EnumExtensions.g31uKTG6WEYhtLLtNSXZ;
  }
}
