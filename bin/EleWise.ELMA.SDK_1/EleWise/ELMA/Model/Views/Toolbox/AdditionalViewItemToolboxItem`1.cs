// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbox.AdditionalViewItemToolboxItem`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Toolbox
{
  /// <summary>
  /// Элемент представления в панели инструментов на основе заданного типа элемента (в группе дополнительных)
  /// </summary>
  public abstract class AdditionalViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
  {
    internal static object TBT9Dyop79EqI6TNoZgv;

    public override Guid GroupUid => AdditionalViewItemToolboxGroup.UID;

    protected AdditionalViewItemToolboxItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool pxVymhopxW8vfUwYmnJ3() => AdditionalViewItemToolboxItem<TViewItem>.TBT9Dyop79EqI6TNoZgv == null;

    internal static object NYgXAaop0VHLqVljPjq0() => AdditionalViewItemToolboxItem<TViewItem>.TBT9Dyop79EqI6TNoZgv;
  }
}
