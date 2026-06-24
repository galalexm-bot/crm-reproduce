// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.TableRowViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Web.UI.WebControls;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class TableRowViewItemBuilder<TM> : 
    ViewItemBuilder<TM, TableRowViewItem, TableRowViewItemBuilder<TM>>
    where TM : IEntity
  {
    internal static object JMYbepoagXTrVQdF8kFj;

    public TableRowViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal TableRowViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TableRowViewItemBuilder<TM> Height(string height)
    {
      this.ViewItem.Height = new Unit(height);
      return this;
    }

    public TableRowViewItemBuilder<TM> Height(Unit height)
    {
      this.ViewItem.Height = height;
      return this;
    }

    public TableRowViewItemBuilder<TM> Cell(Action<TableCellViewItemBuilder<TM>> builder = null)
    {
      TableCellViewItemBuilder<TM> cellViewItemBuilder = new TableCellViewItemBuilder<TM>((ViewItemBuilder) this);
      if (builder != null)
        builder(cellViewItemBuilder);
      return this;
    }

    internal static bool bN36eBoa5g4hG1bwmKvY() => TableRowViewItemBuilder<TM>.JMYbepoagXTrVQdF8kFj == null;

    internal static object diUJ0YoajyoiScvTs5nu() => TableRowViewItemBuilder<TM>.JMYbepoagXTrVQdF8kFj;
  }
}
