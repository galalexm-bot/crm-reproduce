// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.FullTextSearchResultModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Exceptions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>Модель результата полнотекстового поиска</summary>
  public class FullTextSearchResultModel
  {
    /// <summary>Uid "Тип объектов"</summary>
    public Guid TypeUid;
    public string Index;
    /// <summary>Список найденых объектов</summary>
    public List<FullTextSearchResultItem> Items;
    /// <summary>Список полей которые были запрошены</summary>
    public List<string> ListReturnFields;
    private static FullTextSearchResultModel f5B6G0GqGTGSIdvWKDHo;

    /// <summary>Количество найденых объектов</summary>
    public long Total
    {
      get
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 3:
                goto label_7;
              case 2:
                if (this.Items == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_5;
            }
          }
label_5:
          if (!this.Items.Any<FullTextSearchResultItem>())
            num1 = 3;
          else
            goto label_8;
        }
label_7:
        int total = 0;
        goto label_9;
label_8:
        total = this.Items.Count<FullTextSearchResultItem>();
label_9:
        return (long) total;
      }
    }

    /// <summary>Общее количество (вычисляется отдельным запросом)</summary>
    public int CountAllResult
    {
      get => this.\u003CCountAllResult\u003Ek__BackingField;
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
              this.\u003CCountAllResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    /// <summary>Ошибка получения данных из индекса</summary>
    public FullTextFilterException Error
    {
      get => this.\u003CError\u003Ek__BackingField;
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
              this.\u003CError\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
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

    public FullTextSearchResultModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UBF4aCGqEwWoBaLACJTe() => FullTextSearchResultModel.f5B6G0GqGTGSIdvWKDHo == null;

    internal static FullTextSearchResultModel EAiQP5GqfoQl3uWNPOR7() => FullTextSearchResultModel.f5B6G0GqGTGSIdvWKDHo;
  }
}
