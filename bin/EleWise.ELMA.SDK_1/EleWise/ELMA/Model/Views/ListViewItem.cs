// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ListViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  [Serializable]
  public class ListViewItem : EventedList<ViewItem>, IXsiType
  {
    private static ListViewItem yk4Yk4o2YJc8N771AltK;

    public ListViewItem(ViewItem parent)
    {
      ListViewItem.DQOZ82o2s8aqt35VxuNH();
      // ISSUE: explicit constructor call
      base.\u002Ector(parent);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected override Exception ListAddingException(ViewItem parent, ViewItem item) => (Exception) new ListViewItemAddingException(parent, item);

    protected override ViewItem GetParent(ViewItem item) => (ViewItem) ListViewItem.H6PhABo2c48fHyQ4fXkf((object) item);

    protected override void SetParent(ViewItem item, ViewItem parent)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            item.Parent = (RootViewItem) parent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override void RemoveFromParent(ViewItem item)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((EventedList<ViewItem>) ListViewItem.rDE7Ffo2zHiP0d2KHJ20(ListViewItem.H6PhABo2c48fHyQ4fXkf((object) item))).Remove(item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            if (item.Parent != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_6:;
    }

    internal static void DQOZ82o2s8aqt35VxuNH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool s3ZEhro2LaIa224avpJN() => ListViewItem.yk4Yk4o2YJc8N771AltK == null;

    internal static ListViewItem PkLcFDo2UD55DdVQiN4M() => ListViewItem.yk4Yk4o2YJc8N771AltK;

    internal static object H6PhABo2c48fHyQ4fXkf([In] object obj0) => (object) ((ViewItem) obj0).Parent;

    internal static object rDE7Ffo2zHiP0d2KHJ20([In] object obj0) => (object) ((RootViewItem) obj0).Items;
  }
}
