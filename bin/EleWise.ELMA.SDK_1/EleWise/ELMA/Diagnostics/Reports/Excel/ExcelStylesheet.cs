// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.ExcelStylesheet
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  public class ExcelStylesheet
  {
    internal static ExcelStylesheet wOYHWdEEDCvx3f8oqTxQ;

    public ExcelStylesheet()
    {
      ExcelStylesheet.murhVwEE43qnc8nIuaG6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.HeaderStyle = (IExcelStyle) new ExcelStyle()
            {
              BackColor = new Color?(ExcelStylesheet.buV76qEE6pEyOp6hrMP9(83, 141, 213)),
              FontColor = new Color?(Color.White),
              FontBold = new bool?(true)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.MainHeaderStyle = (IExcelStyle) new ExcelStyle()
            {
              BackColor = new Color?(ExcelStylesheet.buV76qEE6pEyOp6hrMP9(54, 96, 146)),
              FontColor = new Color?(ExcelStylesheet.bO9AXGEEHHRUAhDE3JF8()),
              FontBold = new bool?(true),
              FontSize = new int?(14)
            };
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public IExcelStyle CommonStyle
    {
      get => this.\u003CCommonStyle\u003Ek__BackingField;
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
              this.\u003CCommonStyle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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

    public IExcelStyle HeaderStyle
    {
      get => this.\u003CHeaderStyle\u003Ek__BackingField;
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
              this.\u003CHeaderStyle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    public IExcelStyle MainHeaderStyle
    {
      get => this.\u003CMainHeaderStyle\u003Ek__BackingField;
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
              this.\u003CMainHeaderStyle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    internal static void murhVwEE43qnc8nIuaG6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Color buV76qEE6pEyOp6hrMP9([In] int obj0, [In] int obj1, [In] int obj2) => Color.FromArgb(obj0, obj1, obj2);

    internal static Color bO9AXGEEHHRUAhDE3JF8() => Color.White;

    internal static bool CwPKUAEEt7i4NUex2UOS() => ExcelStylesheet.wOYHWdEEDCvx3f8oqTxQ == null;

    internal static ExcelStylesheet jXb4riEEwtRhVVONjTDI() => ExcelStylesheet.wOYHWdEEDCvx3f8oqTxQ;
  }
}
