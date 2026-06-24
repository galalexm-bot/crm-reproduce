// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.InputAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Входящее ли свойство</summary>
  public class InputAttribute : Attribute
  {
    private bool _value;
    private static InputAttribute H4tbf9ouSbDGHsJ7M7h4;

    /// <summary>Конструктор</summary>
    /// <param name="value"></param>
    public InputAttribute(bool value)
    {
      InputAttribute.jGVeRGouq125vrwYuRbh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Входящее ли свойство</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
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

    internal static void jGVeRGouq125vrwYuRbh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool LhAAGVoui4Vdmr853HXR() => InputAttribute.H4tbf9ouSbDGHsJ7M7h4 == null;

    internal static InputAttribute zYWAKcouRXxfsIfqBLYL() => InputAttribute.H4tbf9ouSbDGHsJ7M7h4;
  }
}
