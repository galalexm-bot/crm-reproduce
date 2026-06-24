// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbox.CommonViewItemToolboxItem`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Toolbox
{
  /// <summary>
  /// Элемент представления в панели инструментов на основе заданного типа элемента (в общей группе)
  /// </summary>
  public abstract class CommonViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
  {
    private static object Fqtncwop59P4Fx1hGCJb;

    public override Guid GroupUid => CommonViewItemToolboxGroup.UID;

    protected CommonViewItemToolboxItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EE2JOJopjGbI7ON12rtD() => CommonViewItemToolboxItem<TViewItem>.Fqtncwop59P4Fx1hGCJb == null;

    internal static object IY6t6sopYMT564aalA3S() => CommonViewItemToolboxItem<TViewItem>.Fqtncwop59P4Fx1hGCJb;
  }
}
