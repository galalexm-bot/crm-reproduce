// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Filters.QueryParameterInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Filters
{
  /// <summary>Информация параметре</summary>
  [XmlRoot("QueryParameterInfo")]
  public class QueryParameterInfo
  {
    internal static QueryParameterInfo vrBmfoWY92OlTERka0C0;

    /// <summary>Имя параметра</summary>
    [XmlElement("ParameterName")]
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Значение параметра</summary>
    [XmlElement("ParameterValue")]
    public object Object
    {
      get => this.\u003CObject\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CObject\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public QueryParameterInfo()
    {
      QueryParameterInfo.FelfSpWYrfNaUmawvq5x();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jMNpA9WYd2uZp2bF0ook() => QueryParameterInfo.vrBmfoWY92OlTERka0C0 == null;

    internal static QueryParameterInfo k6rYXUWYl9I1U2RkGolf() => QueryParameterInfo.vrBmfoWY92OlTERka0C0;

    internal static void FelfSpWYrfNaUmawvq5x() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
