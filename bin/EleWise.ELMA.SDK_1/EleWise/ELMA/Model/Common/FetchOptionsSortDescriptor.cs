// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.FetchOptionsSortDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Описатель сортировки</summary>
  [DataContract]
  [Serializable]
  public class FetchOptionsSortDescriptor
  {
    private static FetchOptionsSortDescriptor kpOU6uhku7mbVdZcQqNk;

    /// <summary>Ctor</summary>
    /// <param name="sortExpression">Выражение сортировки</param>
    /// <param name="sortDirection">Направление сортировки</param>
    public FetchOptionsSortDescriptor(string sortExpression, ListSortDirection sortDirection)
    {
      FetchOptionsSortDescriptor.Rr5gkJhkSELZJX8blCdQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.SortExpression = sortExpression;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.SortDirection = sortDirection;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Выражение сортировки</summary>
    [DataMember]
    public string SortExpression
    {
      get => this.\u003CSortExpression\u003Ek__BackingField;
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
              this.\u003CSortExpression\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

    /// <summary>Направление сортировки</summary>
    [DataMember]
    public ListSortDirection SortDirection
    {
      get => this.\u003CSortDirection\u003Ek__BackingField;
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
              this.\u003CSortDirection\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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

    internal static void Rr5gkJhkSELZJX8blCdQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IU5MYIhkIgMVsugjqH57() => FetchOptionsSortDescriptor.kpOU6uhku7mbVdZcQqNk == null;

    internal static FetchOptionsSortDescriptor SPJYI3hkVBdV3aLQEa58() => FetchOptionsSortDescriptor.kpOU6uhku7mbVdZcQqNk;
  }
}
