// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.PanelViewItemBuilder`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders
{
  public abstract class PanelViewItemBuilder<TM, T, TB> : RootViewItemBuilder<TM, T, TB>
    where TM : IEntity
    where T : PanelViewItem, new()
    where TB : PanelViewItemBuilder<TM, T, TB>
  {
    private static object Un8qAPoasjsnJwZBu4fe;

    protected PanelViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected PanelViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentViewItemBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TB Collapsible(bool collapsible = true)
    {
      this.ViewItem.Collapsible = collapsible;
      return this as TB;
    }

    public TB Collapsed(bool collapsed = true)
    {
      this.ViewItem.DefaultCollapseState = collapsed ? PanelViewItemCollapseType.DefaultCollapsed : PanelViewItemCollapseType.DefaultExpanded;
      return this as TB;
    }

    public TB SaveState(bool saveState = true)
    {
      this.ViewItem.SaveState = saveState;
      return this as TB;
    }

    public TB Style(PanelViewItemStyle style)
    {
      this.ViewItem.Style = style;
      return this as TB;
    }

    public TB CssClass(string cssClass)
    {
      this.ViewItem.CssClass = cssClass;
      return this as TB;
    }

    public TB Caption(string caption)
    {
      this.ViewItem.Caption = caption;
      return this as TB;
    }

    public TB CustomViewName(string customViewName, bool useOriginalModel = false)
    {
      this.ViewItem.CustomViewName = customViewName;
      this.ViewItem.UseOriginalModel = useOriginalModel;
      return this as TB;
    }

    internal static bool aVi7pwoacRn2OUK9YKDg() => PanelViewItemBuilder<TM, T, TB>.Un8qAPoasjsnJwZBu4fe == null;

    internal static object skyoOVoazeBhQAltvttF() => PanelViewItemBuilder<TM, T, TB>.Un8qAPoasjsnJwZBu4fe;
  }
}
