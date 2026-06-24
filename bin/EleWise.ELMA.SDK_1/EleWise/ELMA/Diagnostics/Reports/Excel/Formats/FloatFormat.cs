// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.Formats.FloatFormat
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats
{
  public class FloatFormat : ExcelCellFormat
  {
    private static FloatFormat iDk8rHEEMG2jsjqGENuj;

    public static FloatFormat Default { get; private set; }

    public FloatFormat()
    {
      FloatFormat.syR3tcEEd1qjvOv3xbqS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.DecimalCount = 2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public int DecimalCount
    {
      get => this.\u003CDecimalCount\u003Ek__BackingField;
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
              this.\u003CDecimalCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
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

    public override void ApplyFormat(Style style)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            style.Custom = (string) FloatFormat.oc2XPqEEl1TUQ0tOAyIx((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected virtual string GetFormat()
    {
      int num1 = 8;
      string format;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              if (num3 >= this.DecimalCount)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 3;
                continue;
              }
              goto label_4;
            case 2:
              ++num3;
              num2 = 5;
              continue;
            case 3:
              goto label_3;
            case 4:
              format = (string) FloatFormat.TcBJELEEgAybmEb9ovub((object) format, FloatFormat.YfOg1bEErbaUrhRANULe(-1426456882 ^ 2009939514 ^ -583738832));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_4;
            case 7:
              if (this.DecimalCount > 0)
              {
                num2 = 4;
                continue;
              }
              goto label_3;
            case 8:
              format = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77691779);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 7 : 3;
              continue;
            default:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
              continue;
          }
        }
label_4:
        format = (string) FloatFormat.TcBJELEEgAybmEb9ovub((object) format, FloatFormat.YfOg1bEErbaUrhRANULe(-867826612 ^ -867820608));
        num1 = 2;
      }
label_3:
      return format;
    }

    static FloatFormat()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FloatFormat.TxghGDEE5LkBLoC77iii((object) new FloatFormat());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 2:
            FloatFormat.syR3tcEEd1qjvOv3xbqS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void syR3tcEEd1qjvOv3xbqS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool oeZo3NEEJ2vs3FfqkUO4() => FloatFormat.iDk8rHEEMG2jsjqGENuj == null;

    internal static FloatFormat x6A0PgEE9DYJbsiJ4DcB() => FloatFormat.iDk8rHEEMG2jsjqGENuj;

    internal static object oc2XPqEEl1TUQ0tOAyIx([In] object obj0) => (object) ((FloatFormat) obj0).GetFormat();

    internal static object YfOg1bEErbaUrhRANULe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object TcBJELEEgAybmEb9ovub([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void TxghGDEE5LkBLoC77iii([In] object obj0) => FloatFormat.Default = (FloatFormat) obj0;
  }
}
