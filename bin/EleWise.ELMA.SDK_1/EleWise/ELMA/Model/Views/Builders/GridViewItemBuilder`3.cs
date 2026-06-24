// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.GridViewItemBuilder`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Builders
{
  public abstract class GridViewItemBuilder<TM, T, TB> : ViewItemBuilder<TM, T, TB>
    where TM : IEntity
    where T : GridViewItem, new()
    where TB : GridViewItemBuilder<TM, T, TB>
  {
    internal static object lQM7nAoDokdkYvKm1hNU;

    protected GridViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected GridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TB EntityUid(Guid entityUid)
    {
      this.ViewItem.EntityUid = entityUid;
      return this as TB;
    }

    public TB PropertyUid(Guid propertyUid)
    {
      this.ViewItem.PropertyUid = new Guid?(propertyUid);
      return this as TB;
    }

    public TB ShowCount(bool showCount = true)
    {
      this.ViewItem.ShowCount = showCount;
      return this as TB;
    }

    public TB Query(string query)
    {
      this.ViewItem.Query = query;
      return this as TB;
    }

    public TB SelectedColumns(params Guid[] selectedColumns)
    {
      this.ViewItem.SelectedColumns = selectedColumns;
      return this as TB;
    }

    internal static bool EZqp8HoDbBy4igc9U1V9() => GridViewItemBuilder<TM, T, TB>.lQM7nAoDokdkYvKm1hNU == null;

    internal static object zU6lOjoDhn9RMPnE7ipj() => GridViewItemBuilder<TM, T, TB>.lQM7nAoDokdkYvKm1hNU;
  }
}
