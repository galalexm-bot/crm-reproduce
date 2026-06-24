// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.ToolbarItemList
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  [Serializable]
  public class ToolbarItemList : EventedList<ToolbarItem>, IXsiType
  {
    internal static ToolbarItemList r89Z0OotNdyq8TbyYcOM;

    public ToolbarItemList(ToolbarItem parent)
    {
      ToolbarItemList.F71jrvotarBprPAWWOok();
      // ISSUE: explicit constructor call
      base.\u002Ector(parent);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected override Exception ListAddingException(ToolbarItem parent, ToolbarItem item) => (Exception) new ToolbarItemListAddingException(parent, item);

    protected override ToolbarItem GetParent(ToolbarItem item) => (ToolbarItem) ToolbarItemList.Sw8bkRotDqWZQJYndu33((object) item);

    protected override void SetParent(ToolbarItem item, ToolbarItem parent)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ToolbarItemList.vDuM3JottXH1BM0dGZVY((object) item, (object) (RootToolbarItem) parent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override void RemoveFromParent(ToolbarItem item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ToolbarItemList.Sw8bkRotDqWZQJYndu33((object) item) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            ((EventedList<ToolbarItem>) ToolbarItemList.Hj6k13otw9cbrUSNEEYl(ToolbarItemList.Sw8bkRotDqWZQJYndu33((object) item))).Remove(item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static void F71jrvotarBprPAWWOok() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xqsvgXot3fnWEpDiBoGg() => ToolbarItemList.r89Z0OotNdyq8TbyYcOM == null;

    internal static ToolbarItemList oFwh5IotpyFfejBnMKPW() => ToolbarItemList.r89Z0OotNdyq8TbyYcOM;

    internal static object Sw8bkRotDqWZQJYndu33([In] object obj0) => (object) ((ToolbarItem) obj0).Parent;

    internal static void vDuM3JottXH1BM0dGZVY([In] object obj0, [In] object obj1) => ((ToolbarItem) obj0).Parent = (RootToolbarItem) obj1;

    internal static object Hj6k13otw9cbrUSNEEYl([In] object obj0) => (object) ((RootToolbarItem) obj0).Items;
  }
}
