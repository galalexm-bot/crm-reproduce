// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.TableColumnBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;
using System.Web.UI.WebControls;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class TableColumnBuilder
  {
    private readonly TableColumnSettings columnSettings;
    internal static TableColumnBuilder vtcIWmoaJt4FLDR61Emd;

    internal TableColumnBuilder(TableColumnSettings columnSettings)
    {
      TableColumnBuilder.VSEb8ooal1MOZePUZwSY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.columnSettings = columnSettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public TableColumnBuilder Width(string width)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.columnSettings.Width = new Unit(width);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    public TableColumnBuilder Width(Unit width)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TableColumnBuilder.RVNmKioarkcUKTm013l2((object) this.columnSettings, width);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    internal static void VSEb8ooal1MOZePUZwSY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QpjfZCoa9iDZkewVx2WS() => TableColumnBuilder.vtcIWmoaJt4FLDR61Emd == null;

    internal static TableColumnBuilder l0iuLRoadc8Lnp4pTsmt() => TableColumnBuilder.vtcIWmoaJt4FLDR61Emd;

    internal static void RVNmKioarkcUKTm013l2([In] object obj0, Unit value) => ((TableColumnSettings) obj0).Width = value;
  }
}
