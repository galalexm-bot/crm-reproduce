// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.ColumnsLayoutViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class ColumnsLayoutViewItemBuilder<TM> : 
    ViewItemBuilder<TM, ColumnsLayoutViewItem, ColumnsLayoutViewItemBuilder<TM>>
    where TM : IEntity
  {
    internal static object Wnmg5joa28Jp3OuoLDl0;

    public ColumnsLayoutViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal ColumnsLayoutViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ColumnsLayoutViewItemBuilder<TM> Column(Action<ColumnViewItemBuilder<TM>> builder = null)
    {
      ColumnViewItemBuilder<TM> columnViewItemBuilder = new ColumnViewItemBuilder<TM>((ViewItemBuilder) this);
      if (builder != null)
        builder(columnViewItemBuilder);
      return this;
    }

    public ColumnsLayoutViewItemBuilder<TM> DefaultContainer(
      bool defaultContainer = true,
      int startColumnIndex = 0)
    {
      DefaultContainerViewItem containerViewItem = this.ViewItem.FormViewItem.FindItem<DefaultContainerViewItem>(DefaultContainerViewItem.ItemUid) ?? new DefaultContainerViewItem();
      containerViewItem.StartColumnIndex = startColumnIndex;
      if (defaultContainer)
        this.Add((EleWise.ELMA.Model.Views.ViewItem) containerViewItem);
      else
        this.ViewItem.FormViewItem.Items.Add((EleWise.ELMA.Model.Views.ViewItem) containerViewItem);
      return this;
    }

    internal static bool HMVAhJoaeCXwQ8P1gUQQ() => ColumnsLayoutViewItemBuilder<TM>.Wnmg5joa28Jp3OuoLDl0 == null;

    internal static object TayXTFoaP6IRYMhXli8k() => ColumnsLayoutViewItemBuilder<TM>.Wnmg5joa28Jp3OuoLDl0;
  }
}
