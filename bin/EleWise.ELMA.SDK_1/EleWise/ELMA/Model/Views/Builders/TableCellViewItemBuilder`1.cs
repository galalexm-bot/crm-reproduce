// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.TableCellViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class TableCellViewItemBuilder<TM> : 
    RootViewItemBuilder<TM, TableCellViewItem, TableCellViewItemBuilder<TM>>
    where TM : IEntity
  {
    internal static object gIPH4noaY4R3q9u79dOP;

    public TableCellViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal TableCellViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TableCellViewItemBuilder<TM> ColSpan(int colSpan)
    {
      this.ViewItem.ColSpan = colSpan;
      return this;
    }

    public TableCellViewItemBuilder<TM> RowSpan(int rowSpan)
    {
      this.ViewItem.RowSpan = rowSpan;
      return this;
    }

    internal static bool jPl1KjoaLm2teEiRO2X3() => TableCellViewItemBuilder<TM>.gIPH4noaY4R3q9u79dOP == null;

    internal static object rW92vuoaUyaNlaxWobf5() => TableCellViewItemBuilder<TM>.gIPH4noaY4R3q9u79dOP;
  }
}
