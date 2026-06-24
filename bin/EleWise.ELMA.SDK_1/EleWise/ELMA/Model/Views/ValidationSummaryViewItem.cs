// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ValidationSummaryViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Компонент валидации формы</summary>
  [Serializable]
  public sealed class ValidationSummaryViewItem : ViewItem
  {
    internal static ValidationSummaryViewItem KPck94oRtY0JSNLDFKuq;

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => false;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return ValidationSummaryViewItem.M4EA3CoR6g4pKs0PHC5N((object) parentViewItem, (object) this);
label_5:
      return true;
    }

    public ValidationSummaryViewItem()
    {
      ValidationSummaryViewItem.vfaFeMoRHieH5UpJSp1G();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool M4EA3CoR6g4pKs0PHC5N([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static bool XTVkK0oRwJ3XKZ7UhXfV() => ValidationSummaryViewItem.KPck94oRtY0JSNLDFKuq == null;

    internal static ValidationSummaryViewItem gONW5IoR4bOOOqQ2tcGV() => ValidationSummaryViewItem.KPck94oRtY0JSNLDFKuq;

    internal static void vfaFeMoRHieH5UpJSp1G() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
