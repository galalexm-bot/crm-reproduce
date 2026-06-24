// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.ViewItemBuilder`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Builders
{
  public abstract class ViewItemBuilder<TM, T, TB> : ViewItemBuilder
    where TM : IEntity
    where T : EleWise.ELMA.Model.Views.ViewItem, new()
    where TB : ViewItemBuilder<TM, T, TB>
  {
    internal static object b7JcBGoavlyiEFUv0XQF;

    protected T ViewItem => this.viewItem as T;

    protected ViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((EleWise.ELMA.Model.Views.ViewItem) new T());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected ViewItemBuilder(T viewItem)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((EleWise.ELMA.Model.Views.ViewItem) viewItem);
    }

    protected ViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentViewItemBuilder, new T());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected ViewItemBuilder(ViewItemBuilder parentViewItemBuilder, T viewItem)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(viewItem);
      (parentViewItemBuilder.viewItem as RootViewItem).Items.Add((EleWise.ELMA.Model.Views.ViewItem) this.ViewItem);
    }

    public TB Uid(Guid uid)
    {
      this.ViewItem.Uid = uid;
      return this as TB;
    }

    public TB Name(string name)
    {
      this.ViewItem.Name = name;
      return this as TB;
    }

    public TB Add(EleWise.ELMA.Model.Views.ViewItem viewItem)
    {
      if (this.ViewItem is RootViewItem viewItem1)
        viewItem1.Items.Add(viewItem);
      return this as TB;
    }

    public TB Hide(bool hide = true)
    {
      this.ViewItem.Hide = hide;
      return this as TB;
    }

    public TB If(bool condition, Action<TB> builder)
    {
      if (condition && builder != null)
        builder(this as TB);
      return this as TB;
    }

    internal static bool FJYJjtoa8oDPklqvCIKW() => ViewItemBuilder<TM, T, TB>.b7JcBGoavlyiEFUv0XQF == null;

    internal static object dMHhCioaZ20Xus2engsH() => ViewItemBuilder<TM, T, TB>.b7JcBGoavlyiEFUv0XQF;
  }
}
