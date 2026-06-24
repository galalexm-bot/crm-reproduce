// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.PropertyViewItemBuilder`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class PropertyViewItemBuilder<TM, T, TB> : RootViewItemBuilder<TM, T, TB>
    where TM : IEntity
    where T : PropertyViewItem, new()
    where TB : PropertyViewItemBuilder<TM, T, TB>
  {
    private static object NInTa2oDQp8xaau3FTQ6;

    public PropertyViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected PropertyViewItemBuilder(
      Expression<Func<TM, object>> property,
      ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      this.ViewItem.PropertyUid = InterfaceActivator.PropertyUid<TM>(property, true);
    }

    public TB CustomViewName(string customViewName)
    {
      this.ViewItem.CustomViewName = customViewName;
      return this as TB;
    }

    public TB ReadOnly(bool readOnly = true)
    {
      this.ViewItem.Attributes.ReadOnly = new bool?(readOnly);
      return this as TB;
    }

    public TB Visible(bool visible = true)
    {
      this.ViewItem.Attributes.Visible = visible;
      return this as TB;
    }

    public TB Required(bool required = true)
    {
      this.ViewItem.Attributes.Required = required;
      return this as TB;
    }

    public TB Caption(string caption)
    {
      this.ViewItem.Attributes.Name = caption;
      return this as TB;
    }

    internal static bool e7Cu29oDCmfmXqvOpNUU() => PropertyViewItemBuilder<TM, T, TB>.NInTa2oDQp8xaau3FTQ6 == null;

    internal static object HNEISyoDvUa5S0lj8sFQ() => PropertyViewItemBuilder<TM, T, TB>.NInTa2oDQp8xaau3FTQ6;
  }
}
