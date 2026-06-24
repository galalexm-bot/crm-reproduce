// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.RootViewItemBuilder`3
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
  public abstract class RootViewItemBuilder<TM, T, TB> : 
    ViewItemBuilder<TM, T, TB>,
    IRootViewItemBuilder
    where TM : IEntity
    where T : RootViewItem, new()
    where TB : RootViewItemBuilder<TM, T, TB>
  {
    internal static object HRxtRVoaSWjanCcBAIZe;

    protected RootViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected RootViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TB ColumnsLayout(Action<ColumnsLayoutViewItemBuilder<TM>> builder = null)
    {
      if (builder != null)
        builder(new ColumnsLayoutViewItemBuilder<TM>((ViewItemBuilder) this));
      return this as TB;
    }

    public TB TabLayout(Action<TabLayoutViewItemBuilder<TM>> builder = null)
    {
      if (builder != null)
        builder(new TabLayoutViewItemBuilder<TM>((ViewItemBuilder) this));
      return this as TB;
    }

    public TB TableLayout(Action<TableLayoutViewItemBuilder<TM>> builder = null)
    {
      if (builder != null)
        builder(new TableLayoutViewItemBuilder<TM>((ViewItemBuilder) this));
      return this as TB;
    }

    public TB Panel(Action<PanelViewItemBuilder<TM>> builder = null)
    {
      if (builder != null)
        builder(new PanelViewItemBuilder<TM>((ViewItemBuilder) this));
      return this as TB;
    }

    public TB PropertyValue(
      Expression<Func<TM, object>> property,
      Action<PropertyValueViewItemBuilder<TM>> builder = null)
    {
      PropertyValueViewItemBuilder<TM> valueViewItemBuilder = new PropertyValueViewItemBuilder<TM>(property, (ViewItemBuilder) this);
      if (builder != null)
        builder(valueViewItemBuilder);
      return this as TB;
    }

    public TB PropertyValue<TM2>(
      Expression<Func<TM2, object>> property,
      Action<PropertyValueViewItemBuilder<TM2>> builder = null)
      where TM2 : TM
    {
      PropertyValueViewItemBuilder<TM2> valueViewItemBuilder = new PropertyValueViewItemBuilder<TM2>(property, (ViewItemBuilder) this);
      if (builder != null)
        builder(valueViewItemBuilder);
      return this as TB;
    }

    public TB PropertyCaption(
      Expression<Func<TM, object>> property,
      Action<PropertyCaptionViewItemBuilder<TM>> builder = null)
    {
      PropertyCaptionViewItemBuilder<TM> captionViewItemBuilder = new PropertyCaptionViewItemBuilder<TM>(property, (ViewItemBuilder) this);
      if (builder != null)
        builder(captionViewItemBuilder);
      return this as TB;
    }

    public TB PropertyCaption<TM2>(
      Expression<Func<TM2, object>> property,
      Action<PropertyCaptionViewItemBuilder<TM2>> builder = null)
      where TM2 : TM
    {
      PropertyCaptionViewItemBuilder<TM2> captionViewItemBuilder = new PropertyCaptionViewItemBuilder<TM2>(property, (ViewItemBuilder) this);
      if (builder != null)
        builder(captionViewItemBuilder);
      return this as TB;
    }

    public TB PropertyDescription(
      Expression<Func<TM, object>> property,
      Action<PropertyDescriptionViewItemBuilder<TM>> builder = null)
    {
      PropertyDescriptionViewItemBuilder<TM> descriptionViewItemBuilder = new PropertyDescriptionViewItemBuilder<TM>(property, (ViewItemBuilder) this);
      if (builder != null)
        builder(descriptionViewItemBuilder);
      return this as TB;
    }

    public TB PropertyDescription<TM2>(
      Expression<Func<TM2, object>> property,
      Action<PropertyDescriptionViewItemBuilder<TM2>> builder = null)
      where TM2 : TM
    {
      PropertyDescriptionViewItemBuilder<TM2> descriptionViewItemBuilder = new PropertyDescriptionViewItemBuilder<TM2>(property, (ViewItemBuilder) this);
      if (builder != null)
        builder(descriptionViewItemBuilder);
      return this as TB;
    }

    public TB StaticText(Action<StaticTextViewItemBuilder<TM>> builder = null)
    {
      if (builder != null)
        builder(new StaticTextViewItemBuilder<TM>((string) null, (ViewItemBuilder) this));
      return this as TB;
    }

    public TB StaticText(string text, Action<StaticTextViewItemBuilder<TM>> builder = null)
    {
      StaticTextViewItemBuilder<TM> textViewItemBuilder = new StaticTextViewItemBuilder<TM>(text, (ViewItemBuilder) this);
      if (builder != null)
        builder(textViewItemBuilder);
      return this as TB;
    }

    public TB ExtensionZone(string ZoneId, Action<ExtensionZoneViewItemBuilder<TM>> builder = null)
    {
      ExtensionZoneViewItemBuilder<TM> zoneViewItemBuilder = new ExtensionZoneViewItemBuilder<TM>(ZoneId, (ViewItemBuilder) this);
      if (builder != null)
        builder(zoneViewItemBuilder);
      return this as TB;
    }

    public TB HideEmpty(HideEmptyEnum hideEmpty = HideEmptyEnum.HideEmpty)
    {
      this.ViewItem.HideEmptySettings = hideEmpty;
      return this as TB;
    }

    internal static bool NESCc6oaio8mc0BiDqDK() => RootViewItemBuilder<TM, T, TB>.HRxtRVoaSWjanCcBAIZe == null;

    internal static object phJZ10oaRE0nc0ViiHrf() => RootViewItemBuilder<TM, T, TB>.HRxtRVoaSWjanCcBAIZe;
  }
}
