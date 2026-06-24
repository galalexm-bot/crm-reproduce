// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.TabLayoutViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class TabLayoutViewItemBuilder<TM> : 
    ViewItemBuilder<TM, TabLayoutViewItem, TabLayoutViewItemBuilder<TM>>
    where TM : IEntity
  {
    internal static object p32i2woapiqvrIFoEwL6;

    public TabLayoutViewItemBuilder()
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

    internal TabLayoutViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TabLayoutViewItemBuilder<TM> Tab(Action<TabViewItemBuilder<TM>> builder = null)
    {
      if (builder != null)
        builder(new TabViewItemBuilder<TM>((ViewItemBuilder) this));
      return this;
    }

    public TabLayoutViewItemBuilder<TM> UseTabProvider(bool useTabProvider = true, bool useOriginalModel = true)
    {
      this.ViewItem.UseTabProvider = useTabProvider;
      this.ViewItem.TabProviderUseOriginalModel = useOriginalModel;
      return this;
    }

    internal static bool uGwZ3soaa9HaZuHgoCmN() => TabLayoutViewItemBuilder<TM>.p32i2woapiqvrIFoEwL6 == null;

    internal static object W0GjYFoaDdxFxe81OcWb() => TabLayoutViewItemBuilder<TM>.p32i2woapiqvrIFoEwL6;
  }
}
