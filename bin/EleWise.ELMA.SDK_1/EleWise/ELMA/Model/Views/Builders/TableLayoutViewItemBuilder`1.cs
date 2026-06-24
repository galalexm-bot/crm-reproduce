// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.TableLayoutViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class TableLayoutViewItemBuilder<TM> : 
    ViewItemBuilder<TM, TableLayoutViewItem, TableLayoutViewItemBuilder<TM>>
    where TM : IEntity
  {
    private static object jEFfNVoa7hhiEJXu8YfQ;

    public TableLayoutViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal TableLayoutViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TableLayoutViewItemBuilder<TM> Columns(Action<TableColumnsBuilder> builder = null)
    {
      if (builder != null)
        builder(new TableColumnsBuilder(this.ViewItem));
      return this;
    }

    public TableLayoutViewItemBuilder<TM> Row(Action<TableRowViewItemBuilder<TM>> builder = null)
    {
      if (builder != null)
        builder(new TableRowViewItemBuilder<TM>((ViewItemBuilder) this));
      return this;
    }

    internal static bool UWJNThoaxDt6765gCFjm() => TableLayoutViewItemBuilder<TM>.jEFfNVoa7hhiEJXu8YfQ == null;

    internal static object qrnOn1oa0CQv569KtHbt() => TableLayoutViewItemBuilder<TM>.jEFfNVoa7hhiEJXu8YfQ;
  }
}
