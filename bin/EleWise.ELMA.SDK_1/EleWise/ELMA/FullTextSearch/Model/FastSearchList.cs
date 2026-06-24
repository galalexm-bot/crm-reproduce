// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.FastSearchList
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Enum;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>
  /// Список полей для быстрого поиска в полнотекстовом поиске
  /// </summary>
  public class FastSearchList
  {
    private List<string> fields;
    private Dictionary<string, Weight> weights;
    internal static FastSearchList FbkukqGi0nK6lDEKEmMu;

    public FastSearchList(string value, List<string> fields, Dictionary<string, Weight> weights)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.fields = new List<string>();
      this.weights = new Dictionary<string, Weight>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Value = value;
      this.fields = fields;
      this.weights = weights;
    }

    public string Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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

    public List<string> Fields => this.fields.Where<string>((Func<string, bool>) (s => !FastSearchList.\u003C\u003Ec.EJWjQtvcbBZAXBxP6E9Z((object) s))).Distinct<string>().ToList<string>();

    public Dictionary<string, Weight> Weights => this.weights;

    internal static bool wSTvKmGimG6YHjEpp51V() => FastSearchList.FbkukqGi0nK6lDEKEmMu == null;

    internal static FastSearchList DWR8V2GiyYZdYapHf0lN() => FastSearchList.FbkukqGi0nK6lDEKEmMu;
  }
}
