// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.Formats.TimeSpanFormat
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats
{
  public class TimeSpanFormat : ExcelCellFormat
  {
    internal static TimeSpanFormat i2UdvJEf8A1RdrCka82T;

    public static TimeSpanFormat Default { get; private set; }

    public TimeSpanFormat()
    {
      TimeSpanFormat.OgSNj3EfI9SJs9O9rdx6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TimeSpanFormat(TimeSpanStyle style)
    {
      TimeSpanFormat.OgSNj3EfI9SJs9O9rdx6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Style = style;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public TimeSpanStyle Style
    {
      get => this.\u003CStyle\u003Ek__BackingField;
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
              this.\u003CStyle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    public override void SetCellValue(Cell cell, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (!TimeSpanFormat.quyyhxEfVUVqcjCyOTHi(value.GetType(), typeof (TimeSpan)))
            {
              cell.Value = (object) (((TimeSpan) value).TotalHours / 24.0);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 3;
              continue;
            }
            num = 4;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_2;
          default:
            goto label_10;
        }
      }
label_9:
      return;
label_5:
      return;
label_2:
      return;
label_10:;
    }

    public override void ApplyFormat(Aspose.Cells.Style style)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            TimeSpanFormat.sqxj31EfiIPbp9TaOUpy((object) style, TimeSpanFormat.U29OoBEfSp3Gcbhd1aD9(1597012150 ^ 1597263082));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 2:
            if (this.Style != TimeSpanStyle.HHMMSS)
            {
              TimeSpanFormat.sqxj31EfiIPbp9TaOUpy((object) style, TimeSpanFormat.U29OoBEfSp3Gcbhd1aD9(92412609 - 1050237057 ^ -957549006));
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_2:
      return;
label_8:;
    }

    static TimeSpanFormat()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TimeSpanFormat.VJ5r6aEfRalM5337v05N((object) new TimeSpanFormat());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void OgSNj3EfI9SJs9O9rdx6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wMrsMNEfZc9qjyVkFx7x() => TimeSpanFormat.i2UdvJEf8A1RdrCka82T == null;

    internal static TimeSpanFormat X0uRUnEfuHPF9wn29iRi() => TimeSpanFormat.i2UdvJEf8A1RdrCka82T;

    internal static bool quyyhxEfVUVqcjCyOTHi([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object U29OoBEfSp3Gcbhd1aD9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void sqxj31EfiIPbp9TaOUpy([In] object obj0, [In] object obj1) => ((Aspose.Cells.Style) obj0).Custom = (string) obj1;

    internal static void VJ5r6aEfRalM5337v05N([In] object obj0) => TimeSpanFormat.Default = (TimeSpanFormat) obj0;
  }
}
