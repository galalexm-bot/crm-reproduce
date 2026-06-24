// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.RowViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Шаблон для строки</summary>
  [DisplayName(typeof (__Resources_RowViewItem), "DisplayName")]
  [Serializable]
  public class RowViewItem : RootViewItem, ILayoutViewItem, IContainerViewItem
  {
    private static RowViewItem o2oHXvokfPgey0m7ue7s;

    /// <summary>Левая ячейка</summary>
    [XmlIgnore]
    public CellViewItem LeftCell => this.Items[0] as CellViewItem;

    /// <summary>Правая ячейка</summary>
    [XmlIgnore]
    public CellViewItem RightCell => this.Items[1] as CellViewItem;

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => parentViewItem.IsChildValid((ViewItem) this);

    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is CellViewItem;

    public RowViewItem()
    {
      RowViewItem.olec9yokvQDWYxE63e55();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool LAEgihokQKKpbeAtmVtV() => RowViewItem.o2oHXvokfPgey0m7ue7s == null;

    internal static RowViewItem fNahh3okC7Qa7XIFB7vk() => RowViewItem.o2oHXvokfPgey0m7ue7s;

    internal static void olec9yokvQDWYxE63e55() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    [Component(Order = 150)]
    private class ToolboxItem : CommonViewItemToolboxItem<RowViewItem>
    {
      private static object BvbWmKCE4Qh3OCwbwAGB;

      public ToolboxItem()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool FjiqHZCE6yXoJOMMChZy() => RowViewItem.ToolboxItem.BvbWmKCE4Qh3OCwbwAGB == null;

      internal static RowViewItem.ToolboxItem doYpNbCEHZpIfZvPRXwv() => (RowViewItem.ToolboxItem) RowViewItem.ToolboxItem.BvbWmKCE4Qh3OCwbwAGB;
    }
  }
}
