// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemFont
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Шрифт элемента</summary>
  public class ViewItemFont
  {
    private static ViewItemFont dPjt9wokYH4CpTv2Md4B;

    /// <summary>Тип шрифта</summary>
    [DefaultValue(null)]
    public FontFamilyType? FamilyType { get; set; }

    /// <summary>Размер</summary>
    [DefaultValue(null)]
    public float? Size { get; set; }

    /// <summary>Единица измерения</summary>
    [DefaultValue(GraphicsUnit.Pixel)]
    public GraphicsUnit Unit
    {
      get => this.\u003CUnit\u003Ek__BackingField;
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
              this.\u003CUnit\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    /// <summary>Стиль</summary>
    [DefaultValue(null)]
    public FontStyle? Style { get; set; }

    /// <summary>Применить указанный стиль</summary>
    /// <param name="font"></param>
    public void Apply(ViewItemFont font)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        FontStyle? style;
        float? size;
        FontFamilyType? familyType;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_10;
            case 2:
              this.FamilyType = font.FamilyType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
              continue;
            case 3:
              if (familyType.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
                continue;
              }
              goto label_10;
            case 4:
              if (style.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 11 : 11;
                continue;
              }
              goto label_3;
            case 5:
              if (!size.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 3 : 6;
                continue;
              }
              goto case 7;
            case 6:
            case 12:
              style = font.Style;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 4 : 4;
              continue;
            case 7:
              this.Size = font.Size;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 5 : 8;
              continue;
            case 8:
              this.Unit = font.Unit;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 12 : 7;
              continue;
            case 9:
              familyType = font.FamilyType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 3 : 1;
              continue;
            case 10:
              ViewItemFont.m3lsokokcC4tKIkuODgO((object) font, ViewItemFont.mX4Zjvokshmki87EwVTM(1669212571 ^ 1669100647));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 9 : 1;
              continue;
            case 11:
              this.Style = font.Style;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            default:
              goto label_19;
          }
        }
label_10:
        size = font.Size;
        num1 = 5;
      }
label_9:
      return;
label_19:
      return;
label_3:;
    }

    public ViewItemFont()
    {
      ViewItemFont.GITb8pokzwerZuDg4pS3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rRca5PokLUBya6vkYsL3() => ViewItemFont.dPjt9wokYH4CpTv2Md4B == null;

    internal static ViewItemFont JkrEOBokUPKV7BJAHFXu() => ViewItemFont.dPjt9wokYH4CpTv2Md4B;

    internal static object mX4Zjvokshmki87EwVTM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void m3lsokokcC4tKIkuODgO([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void GITb8pokzwerZuDg4pS3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
