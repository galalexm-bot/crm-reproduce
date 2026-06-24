// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.EntityFilterExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для фильтров сущности</summary>
  public static class EntityFilterExtensions
  {
    private static EntityFilterExtensions fjBN4wGafCcIFuSxTVFZ;

    /// <summary>EQL-запрос с параметрами</summary>
    /// <param name="filter">Фильтр сущности</param>
    /// <param name="query">EQL-запрос</param>
    /// <param name="queryParameters">Параметры EQL-запроса</param>
    public static void SetQueryWithParameters(
      this IEntityFilter filter,
      string query,
      params KeyValuePair<string, object>[] queryParameters)
    {
      int num = 2;
      int index;
      KeyValuePair<string, object>[] keyValuePairArray;
      KeyValuePair<string, object> keyValuePair;
      while (true)
      {
        switch (num)
        {
          case 1:
            keyValuePairArray = queryParameters;
            num = 4;
            continue;
          case 2:
            EntityFilterExtensions.n1DqOcGavBaJKICZbI3v((object) filter, (object) query);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
            continue;
          case 3:
            EntityFilterExtensions.qMvjh9GaZuOm8kXJnnIv(EntityFilterExtensions.sMubjHGa8XBeXcKHsEMf((object) filter), (object) keyValuePair.Key, keyValuePair.Value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 4 : 7;
            continue;
          case 4:
            index = 0;
            num = 8;
            continue;
          case 5:
            goto label_2;
          case 6:
            keyValuePair = keyValuePairArray[index];
            num = 3;
            continue;
          case 7:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          default:
            if (index >= keyValuePairArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 5 : 1;
              continue;
            }
            goto case 6;
        }
      }
label_2:;
    }

    internal static void n1DqOcGavBaJKICZbI3v([In] object obj0, [In] object obj1) => ((IEntityFilter) obj0).Query = (string) obj1;

    internal static object sMubjHGa8XBeXcKHsEMf([In] object obj0) => (object) ((IEntityFilter) obj0).QueryParameters;

    internal static object qMvjh9GaZuOm8kXJnnIv([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((QueryParameters) obj0).Set((string) obj1, obj2);

    internal static bool J4FOqjGaQIO6VcyjqPZE() => EntityFilterExtensions.fjBN4wGafCcIFuSxTVFZ == null;

    internal static EntityFilterExtensions WJBZgZGaCN2wgWlqPnQG() => EntityFilterExtensions.fjBN4wGafCcIFuSxTVFZ;
  }
}
