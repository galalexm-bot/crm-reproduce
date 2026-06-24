// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.FormViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class FormViewItemBuilder<TM> : 
    RootViewItemBuilder<TM, FormViewItem, FormViewItemBuilder<TM>>
    where TM : IEntity
  {
    internal static object kB3DIxoaqjIx1fTIfrdy;

    protected FormViewItemBuilder(Guid metadataUid, ViewType viewType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.ViewItem.MetadataUid = new Guid?(metadataUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          default:
            this.ViewItem.ViewType = viewType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public FormViewItemBuilder(ViewType viewType = ViewType.Custom)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(InterfaceActivator.UID<TM>(), viewType);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public FormViewItemBuilder<TM> DisplayName(string displayName)
    {
      this.ViewItem.DisplayName = displayName;
      return this;
    }

    public FormViewItem FormView => this.ViewItem;

    public FormViewItemBuilder<TM> DefaultContainer(bool defaultContainer = true)
    {
      DefaultContainerViewItem containerViewItem = this.ViewItem.FormViewItem.FindItem<DefaultContainerViewItem>(DefaultContainerViewItem.ItemUid) ?? new DefaultContainerViewItem();
      if (defaultContainer)
        this.Add((EleWise.ELMA.Model.Views.ViewItem) containerViewItem);
      else
        this.ViewItem.FormViewItem.Items.Add((EleWise.ELMA.Model.Views.ViewItem) containerViewItem);
      return this;
    }

    internal static bool SrXw2JoaK5b2vOkX4mln() => FormViewItemBuilder<TM>.kB3DIxoaqjIx1fTIfrdy == null;

    internal static object Y6hQQooaXZnugOi8wTaG() => FormViewItemBuilder<TM>.kB3DIxoaqjIx1fTIfrdy;
  }
}
