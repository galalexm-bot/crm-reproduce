// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.ColumnViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class ColumnViewItemBuilder<TM> : 
    RootViewItemBuilder<TM, ColumnViewItem, ColumnViewItemBuilder<TM>>
    where TM : IEntity
  {
    private static object DSS6SBoa1wDaCHSPXFR7;

    public ColumnViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal ColumnViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ColumnViewItemBuilder<TM> Property(
      Expression<Func<TM, object>> property,
      Action<PropertyViewItemBuilder<TM>> builder = null)
    {
      PropertyViewItemBuilder<TM> propertyViewItemBuilder = new PropertyViewItemBuilder<TM>(property, (ViewItemBuilder) this);
      if (builder != null)
        builder(propertyViewItemBuilder);
      return this;
    }

    public ColumnViewItemBuilder<TM> Property<TM2>(
      Expression<Func<TM2, object>> property,
      Action<PropertyViewItemBuilder<TM2>> builder = null)
      where TM2 : TM
    {
      PropertyViewItemBuilder<TM2> propertyViewItemBuilder = new PropertyViewItemBuilder<TM2>(property, (ViewItemBuilder) this);
      if (builder != null)
        builder(propertyViewItemBuilder);
      return this;
    }

    public ColumnViewItemBuilder<TM> DefaultContainer(bool defaultContainer = true)
    {
      DefaultContainerViewItem containerViewItem = this.ViewItem.FormViewItem.FindItem<DefaultContainerViewItem>(DefaultContainerViewItem.ItemUid) ?? new DefaultContainerViewItem();
      if (defaultContainer)
        this.Add((EleWise.ELMA.Model.Views.ViewItem) containerViewItem);
      else
        this.ViewItem.FormViewItem.Items.Add((EleWise.ELMA.Model.Views.ViewItem) containerViewItem);
      return this;
    }

    internal static bool sw75mLoaNf38KjVVV4hy() => ColumnViewItemBuilder<TM>.DSS6SBoa1wDaCHSPXFR7 == null;

    internal static object rZUOsYoa36ad499Swusf() => ColumnViewItemBuilder<TM>.DSS6SBoa1wDaCHSPXFR7;
  }
}
