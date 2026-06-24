// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RangeDateTimeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Validation
{
  public class RangeDateTimeAttribute : ValidationAttribute
  {
    internal static RangeDateTimeAttribute aV3Rmhogbcl681x4gSLd;

    private static string GetMessage(object minimum, object maximum)
    {
      int num = 10;
      string message;
      while (true)
      {
        DateTime dateTime;
        switch (num)
        {
          case 1:
          case 6:
          case 11:
            goto label_8;
          case 2:
            if (!string.IsNullOrEmpty((string) maximum))
            {
              num = 4;
              continue;
            }
            goto label_8;
          case 3:
          case 5:
          case 12:
            if (!RangeDateTimeAttribute.LMxPB8ogQ5rlFWlmLR9b(minimum))
            {
              num = 8;
              continue;
            }
            goto case 2;
          case 4:
            object obj1 = RangeDateTimeAttribute.H70cFeogf7xixKqpB68g(RangeDateTimeAttribute.rTj787ogEwfmbH70umkx(1470440286 ^ 1470432544));
            dateTime = new DateTime(RangeDateTimeAttribute.ayX6Y6ogCsRa0rlNBXkK(maximum));
            string str1 = dateTime.ToString((string) RangeDateTimeAttribute.rTj787ogEwfmbH70umkx(-542721635 ^ -542749155));
            message = (string) RangeDateTimeAttribute.DSLupTog8BQB7V2qUvy5(obj1, (object) str1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 6 : 6;
            continue;
          case 7:
            if (RangeDateTimeAttribute.LMxPB8ogQ5rlFWlmLR9b(maximum))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 12 : 3;
              continue;
            }
            break;
          case 8:
            object obj2 = RangeDateTimeAttribute.H70cFeogf7xixKqpB68g(RangeDateTimeAttribute.rTj787ogEwfmbH70umkx(-1839087379 - 334718690 ^ 2121170119));
            dateTime = new DateTime(RangeDateTimeAttribute.ayX6Y6ogCsRa0rlNBXkK(minimum));
            string str2 = dateTime.ToString((string) RangeDateTimeAttribute.rTj787ogEwfmbH70umkx(1574260816 ^ 1574283216));
            message = (string) RangeDateTimeAttribute.DSLupTog8BQB7V2qUvy5(obj2, (object) str2);
            num = 11;
            continue;
          case 9:
            if (RangeDateTimeAttribute.LMxPB8ogQ5rlFWlmLR9b(minimum))
            {
              num = 5;
              continue;
            }
            goto case 7;
          case 10:
            message = (string) RangeDateTimeAttribute.H70cFeogf7xixKqpB68g(RangeDateTimeAttribute.rTj787ogEwfmbH70umkx(-867826612 ^ -867819082));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 9 : 9;
            continue;
        }
        object obj3 = RangeDateTimeAttribute.H70cFeogf7xixKqpB68g(RangeDateTimeAttribute.rTj787ogEwfmbH70umkx(-53329496 >> 4 ^ -3341822));
        dateTime = new DateTime(RangeDateTimeAttribute.ayX6Y6ogCsRa0rlNBXkK(minimum));
        string str3 = dateTime.ToString((string) RangeDateTimeAttribute.rTj787ogEwfmbH70umkx(1917256330 ^ 1917318410));
        dateTime = new DateTime(RangeDateTimeAttribute.ayX6Y6ogCsRa0rlNBXkK(maximum));
        string str4 = dateTime.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867765300));
        message = (string) RangeDateTimeAttribute.aULF8mogvOJwZQOgsog0(obj3, (object) str3, (object) str4);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
      }
label_8:
      return message;
    }

    public string Min
    {
      get => this.\u003CMin\u003Ek__BackingField;
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
              this.\u003CMin\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    public string Max
    {
      get => this.\u003CMax\u003Ek__BackingField;
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
              this.\u003CMax\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    public RangeDateTimeAttribute(string min, string max)
    {
      RangeDateTimeAttribute.oZ6DfrogZDj0k538CAym();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Max = max;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 3;
            continue;
          case 3:
            this.ErrorMessage = (string) RangeDateTimeAttribute.r7l0Rjogu0ElvxfN2f60((object) this.Min, (object) this.Max);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
            continue;
          default:
            this.Min = min;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 2;
            continue;
        }
      }
label_3:;
    }

    public RangeDateTimeAttribute(string min, string max, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RangeDateTimeAttribute.LeoJsuogIeTmCyOMEjgV((object) this, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 2:
            this.Min = min;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 3 : 3;
            continue;
          case 3:
            this.Max = max;
            num = 4;
            continue;
          case 4:
            if (RangeDateTimeAttribute.LMxPB8ogQ5rlFWlmLR9b((object) message))
            {
              num = 5;
              continue;
            }
            goto case 1;
          case 5:
            message = (string) RangeDateTimeAttribute.r7l0Rjogu0ElvxfN2f60((object) this.Min, (object) this.Max);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:;
    }

    private bool CalcValid(DateTime d)
    {
      int num = 6;
      DateTime dateTime1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_14;
          case 2:
            if (!RangeDateTimeAttribute.LMxPB8ogQ5rlFWlmLR9b((object) this.Max))
            {
              num = 9;
              continue;
            }
            goto label_5;
          case 3:
            DateTime dateTime2 = new DateTime(RangeDateTimeAttribute.ayX6Y6ogCsRa0rlNBXkK((object) this.Min));
            dateTime1 = new DateTime(RangeDateTimeAttribute.ayX6Y6ogCsRa0rlNBXkK((object) this.Max));
            DateTime dateTime3 = d;
            if (!(dateTime2 < dateTime3))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 8 : 4;
              continue;
            }
            goto label_8;
          case 4:
            goto label_8;
          case 5:
          case 7:
            if (string.IsNullOrEmpty(this.Min))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 2;
              continue;
            }
            goto label_14;
          case 6:
            if (RangeDateTimeAttribute.LMxPB8ogQ5rlFWlmLR9b((object) this.Min))
            {
              num = 5;
              continue;
            }
            goto default;
          case 8:
            goto label_9;
          case 9:
            goto label_4;
          default:
            if (RangeDateTimeAttribute.LMxPB8ogQ5rlFWlmLR9b((object) this.Max))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 7;
              continue;
            }
            goto case 3;
        }
      }
label_4:
      return RangeDateTimeAttribute.ja8Gw2ogVJUcTtr2gAT4(new DateTime(Convert.ToInt64(this.Max)), d);
label_5:
      return true;
label_8:
      return RangeDateTimeAttribute.ja8Gw2ogVJUcTtr2gAT4(dateTime1, d);
label_9:
      return false;
label_14:
      return RangeDateTimeAttribute.Rko5gtogS6A6aHXZU6W7(new DateTime(RangeDateTimeAttribute.ayX6Y6ogCsRa0rlNBXkK((object) this.Min)), d);
    }

    public override bool IsValid(object value)
    {
      int num = 3;
      DateTime d;
      long result;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (long.TryParse((string) value, out result))
            {
              num = 4;
              continue;
            }
            goto label_5;
          case 2:
            goto label_11;
          case 3:
            switch (value)
            {
              case null:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 2;
                continue;
              case string _:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                continue;
              case DateTime _:
                goto label_4;
              default:
                num = 5;
                continue;
            }
          case 4:
            d = new DateTime(result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_5;
          case 6:
            goto label_4;
          default:
            goto label_2;
        }
      }
label_2:
      return this.CalcValid(d);
label_4:
      return this.CalcValid((DateTime) value);
label_5:
      return false;
label_11:
      return true;
    }

    internal static object rTj787ogEwfmbH70umkx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object H70cFeogf7xixKqpB68g([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool LMxPB8ogQ5rlFWlmLR9b([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static long ayX6Y6ogCsRa0rlNBXkK([In] object obj0) => Convert.ToInt64((string) obj0);

    internal static object aULF8mogvOJwZQOgsog0([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object DSLupTog8BQB7V2qUvy5([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool D4J5ePoghMjrVZeRxBRv() => RangeDateTimeAttribute.aV3Rmhogbcl681x4gSLd == null;

    internal static RangeDateTimeAttribute iDG0H2ogGDEPmOb67uiJ() => RangeDateTimeAttribute.aV3Rmhogbcl681x4gSLd;

    internal static void oZ6DfrogZDj0k538CAym() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object r7l0Rjogu0ElvxfN2f60([In] object obj0, [In] object obj1) => (object) RangeDateTimeAttribute.GetMessage(obj0, obj1);

    internal static void LeoJsuogIeTmCyOMEjgV([In] object obj0, [In] object obj1) => ((ValidationAttribute) obj0).ErrorMessage = (string) obj1;

    internal static bool ja8Gw2ogVJUcTtr2gAT4([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static bool Rko5gtogS6A6aHXZU6W7([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;
  }
}
