// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.CellViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Ячейка внутри строки</summary>
  [Serializable]
  public class CellViewItem : RootViewItem, ILayoutViewItem, IContainerViewItem
  {
    private static CellViewItem rJIicroTYZ5qKJiORto9;

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => parentViewItem.IsChildValid((ViewItem) this);

    public override bool IsChildValid(ViewItem childViewItem) => true;

    public CellViewItem()
    {
      CellViewItem.zMLpT9oTsADxMXEgBj2K();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool fMwmkfoTL4jpVPO28aFP() => CellViewItem.rJIicroTYZ5qKJiORto9 == null;

    internal static CellViewItem ubjZEPoTU7gT0KYiB6Wb() => CellViewItem.rJIicroTYZ5qKJiORto9;

    internal static void zMLpT9oTsADxMXEgBj2K() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
