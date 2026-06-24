// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.Formats.DateTimeFormat
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
  public class DateTimeFormat : ExcelCellFormat
  {
    private static DateTimeFormat bnwa1hEfoLKjn8NuwPoA;

    public static DateTimeFormat Default { get; private set; }

    public DateTimeFormat()
    {
      DateTimeFormat.Ydp9BxEfGrpFDtahSrky();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ShowTime = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public bool ShowTime
    {
      get => this.\u003CShowTime\u003Ek__BackingField;
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
              this.\u003CShowTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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
      int num = 5;
      DateTime dateTime;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            DateTimeFormat.Ue7kTrEfCaqmaZxnfC9g((object) cell, !this.ShowTime ? (object) dateTime.ToShortDateString() : (object) dateTime.ToString((string) DateTimeFormat.XleEdbEfQH0gkbTHP2SF(1149433385 + 173655049 ^ 1323060658)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: type reference
            if (DateTimeFormat.PIShbqEffPfMXDLogRJP(value.GetType(), DateTimeFormat.NYUlWCEfExv3mP2CVJWs(__typeref (DateTime))))
            {
              num = 3;
              continue;
            }
            dateTime = (DateTime) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_11;
          case 4:
            goto label_9;
          case 5:
            if (value == null)
            {
              num = 4;
              continue;
            }
            goto case 2;
          default:
            goto label_2;
        }
      }
label_7:
      return;
label_11:
      return;
label_9:
      return;
label_2:;
    }

    static DateTimeFormat()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DateTimeFormat.sQbyVrEfvekjURQNBWxt((object) new DateTimeFormat());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          case 2:
            DateTimeFormat.Ydp9BxEfGrpFDtahSrky();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void Ydp9BxEfGrpFDtahSrky() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool o5ukfnEfbZq2ipMNniuQ() => DateTimeFormat.bnwa1hEfoLKjn8NuwPoA == null;

    internal static DateTimeFormat WDxHoBEfhyhuH5htxE8F() => DateTimeFormat.bnwa1hEfoLKjn8NuwPoA;

    internal static Type NYUlWCEfExv3mP2CVJWs([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool PIShbqEffPfMXDLogRJP([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object XleEdbEfQH0gkbTHP2SF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Ue7kTrEfCaqmaZxnfC9g([In] object obj0, [In] object obj1) => ((Cell) obj0).Value = obj1;

    internal static void sQbyVrEfvekjURQNBWxt([In] object obj0) => DateTimeFormat.Default = (DateTimeFormat) obj0;
  }
}
