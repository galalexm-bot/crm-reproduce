// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.TableColumnsBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class TableColumnsBuilder
  {
    private readonly TableLayoutViewItem tableViewItem;
    internal static TableColumnsBuilder kChVqMoamHetUAqB90qH;

    internal TableColumnsBuilder(TableLayoutViewItem tableViewItem)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.tableViewItem = tableViewItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public TableColumnsBuilder Column(Action<TableColumnBuilder> builder = null)
    {
      TableColumnSettings columnSettings = new TableColumnSettings();
      this.tableViewItem.ColumnsSettings.Add(columnSettings);
      if (builder != null)
        builder(new TableColumnBuilder(columnSettings));
      return this;
    }

    internal static bool GNmohDoayGMpEN3jwZrp() => TableColumnsBuilder.kChVqMoamHetUAqB90qH == null;

    internal static TableColumnsBuilder BGqkOGoaMjsj39MWknMr() => TableColumnsBuilder.kChVqMoamHetUAqB90qH;
  }
}
