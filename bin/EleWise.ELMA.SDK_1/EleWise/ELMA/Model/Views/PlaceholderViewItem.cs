// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PlaceholderViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Представление, указывающее что в в данной области у компонента есть дочерний элемент
  /// </summary>
  [Serializable]
  public class PlaceholderViewItem : ViewItem
  {
    private static PlaceholderViewItem oSZg8OoXPhjRLOyGPu1a;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => true;

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => false;

    public PlaceholderViewItem()
    {
      PlaceholderViewItem.mJqOMAoX3m2nqrYw9NXU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void mJqOMAoX3m2nqrYw9NXU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool AoMpcvoX1y2YMDlO8JV5() => PlaceholderViewItem.oSZg8OoXPhjRLOyGPu1a == null;

    internal static PlaceholderViewItem TZ6bkAoXNyRllYmIDIoc() => PlaceholderViewItem.oSZg8OoXPhjRLOyGPu1a;
  }
}
