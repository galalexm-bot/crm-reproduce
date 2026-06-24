// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.FullTextSearchResultItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>Элемент модели результата полнотекстового поиска</summary>
  public class FullTextSearchResultItem : IFullTextSearchResultItem
  {
    internal static FullTextSearchResultItem JkDp09GqWCZPdgEf3UhK;

    /// <summary>Список вхождений</summary>
    public Dictionary<string, List<string>> Highlights { get; set; }

    /// <summary>Общее количество вхождений</summary>
    public long HighlightsCount
    {
      get
      {
        int num = 2;
        int cnt;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 3:
              goto label_2;
            case 2:
              if (!this.Highlights.Any<KeyValuePair<string, List<string>>>())
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
                continue;
              }
              goto case 4;
            case 4:
              num = 5;
              continue;
            case 5:
              cnt = 0;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            default:
              this.Highlights.Values.ForEach<List<string>>((Action<List<string>>) (v =>
              {
                if (!v.Any<string>())
                  return;
                cnt += v.Count;
              }));
              num = 3;
              continue;
          }
        }
label_2:
        return 0;
      }
    }

    public Dictionary<string, object> ResultDictionary { get; set; }

    public WebData ResultData
    {
      get => this.\u003CResultData\u003Ek__BackingField;
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
              this.\u003CResultData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    public IFullTextSearchObject ResultObject
    {
      get => this.\u003CResultObject\u003Ek__BackingField;
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
              this.\u003CResultObject\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

    public FullTextSearchResultItem()
    {
      FullTextSearchResultItem.nLvHJQGqh5lKS7xaXN0o();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DY5jcNGqou2NQoTun1PP() => FullTextSearchResultItem.JkDp09GqWCZPdgEf3UhK == null;

    internal static FullTextSearchResultItem suZlY8Gqbjrk3MQ6D1c9() => FullTextSearchResultItem.JkDp09GqWCZPdgEf3UhK;

    internal static void nLvHJQGqh5lKS7xaXN0o() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
