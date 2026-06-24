// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ShowInTableAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Показывать в таблице</summary>
  public class ShowInTableAttribute : Attribute
  {
    private bool _value;
    internal static ShowInTableAttribute eKQoyooIXmCCLAiFoudG;

    public ShowInTableAttribute(bool value)
    {
      ShowInTableAttribute.uZVsKioInssYod6m87Mv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Значение атрибута</summary>
    public bool Value
    {
      get => this._value;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this._value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void uZVsKioInssYod6m87Mv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool uu9ZJ7oITpQ2Ev9VXabD() => ShowInTableAttribute.eKQoyooIXmCCLAiFoudG == null;

    internal static ShowInTableAttribute Fb1WWToIknZAPDj0t15T() => ShowInTableAttribute.eKQoyooIXmCCLAiFoudG;
  }
}
