// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Filters.QueryParametersListInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Filters
{
  /// <summary>Информация о коллекции параметров в фильтре</summary>
  [XmlRoot("QueryParametersListInfo")]
  public class QueryParametersListInfo
  {
    internal static QueryParametersListInfo vdgNHyWYgPn00KMssvd7;

    /// <summary>Список параметров</summary>
    [XmlArray]
    public List<QueryParameterInfo> Objects { get; set; }

    /// <summary>Создает пустой список</summary>
    public QueryParametersListInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Objects = new List<QueryParameterInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool b9EWR3WY5lE5kw37vSIa() => QueryParametersListInfo.vdgNHyWYgPn00KMssvd7 == null;

    internal static QueryParametersListInfo XPYBwDWYjLmcODGgFd5j() => QueryParametersListInfo.vdgNHyWYgPn00KMssvd7;
  }
}
