// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.DateTimeFormatHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public static class DateTimeFormatHelper
  {
    internal static DateTimeFormatHelper C1HYAGhLmOCXFVfUwpkK;

    public static string GetCurrentFullFormat(string removeTemplate = null, bool forTelerik = true) => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487357978);

    public static string GetCurrentFullFormatWithSeconds(string removeTemplate = null, bool forTelerik = true)
    {
      int num = 2;
      string str1;
      string str2;
      while (true)
      {
        CultureInfo cultureInfo;
        object obj1;
        switch (num)
        {
          case 1:
            obj1 = DateTimeFormatHelper.kIHkMOhL9SKayT8PXmso();
            break;
          case 2:
            object obj2 = DateTimeFormatHelper.n16SGShLJAi1hLPGSGBu((object) Locator.GetServiceNotNull<ILocalizationService>());
            if (obj2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
              continue;
            }
            obj1 = obj2;
            break;
          case 3:
            str1 = StringParseHelper.PrepareDateMask((string) DateTimeFormatHelper.Ef4WJphLlvrtxHXLmLsA(DateTimeFormatHelper.qHrRKAhLdirVNKUPbrxO((object) cultureInfo)), (string) DateTimeFormatHelper.d7j6cphLr3mCM8nGHxPP(DateTimeFormatHelper.qHrRKAhLdirVNKUPbrxO((object) cultureInfo)), removeTemplate);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 4;
            continue;
          case 4:
            str2 = (string) DateTimeFormatHelper.kKsYqXhLj3qYQ1Iy4pOo(DateTimeFormatHelper.d5tBHwhLg93K7cjvuH9u(-1380439818 << 3 ^ 1841491760), DateTimeFormatHelper.kL3qRfhL59JPPLFdxqtJ(DateTimeFormatHelper.qHrRKAhLdirVNKUPbrxO((object) cultureInfo)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
        cultureInfo = (CultureInfo) obj1;
        num = 3;
      }
label_8:
      return string.Format((string) DateTimeFormatHelper.d5tBHwhLg93K7cjvuH9u(-1710575414 ^ -1710679978), (object) str1, (object) str2, !forTelerik ? (object) "" : DateTimeFormatHelper.d5tBHwhLg93K7cjvuH9u(589593376 ^ -1977315327 ^ -1459403883));
    }

    public static string GetCurrentShortFormat(string removeTemplate = null)
    {
      int num = 2;
      CultureInfo cultureInfo1;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            obj = DateTimeFormatHelper.kIHkMOhL9SKayT8PXmso();
            break;
          case 2:
            CultureInfo cultureInfo2 = Locator.GetServiceNotNull<ILocalizationService>().Load();
            if (cultureInfo2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            }
            obj = (object) cultureInfo2;
            break;
          default:
            goto label_2;
        }
        cultureInfo1 = (CultureInfo) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
      }
label_2:
      return StringParseHelper.PrepareDateMask((string) DateTimeFormatHelper.Ef4WJphLlvrtxHXLmLsA((object) cultureInfo1.DateTimeFormat), (string) DateTimeFormatHelper.d7j6cphLr3mCM8nGHxPP(DateTimeFormatHelper.qHrRKAhLdirVNKUPbrxO((object) cultureInfo1)), removeTemplate);
    }

    public static string GetCurrentWithShortYearFormat()
    {
      int num = 1;
      CultureInfo cultureInfo;
      string[] strArray;
      while (true)
      {
        int index;
        object obj1;
        switch (num)
        {
          case 1:
            object obj2 = DateTimeFormatHelper.n16SGShLJAi1hLPGSGBu((object) Locator.GetServiceNotNull<ILocalizationService>());
            if (obj2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            }
            obj1 = obj2;
            break;
          case 2:
            strArray = (string[]) DateTimeFormatHelper.NEivvNhLYSDGwAR3YhVr((object) StringParseHelper.PrepareDateMask((string) DateTimeFormatHelper.Ef4WJphLlvrtxHXLmLsA(DateTimeFormatHelper.qHrRKAhLdirVNKUPbrxO((object) cultureInfo)), ((DateTimeFormatInfo) DateTimeFormatHelper.qHrRKAhLdirVNKUPbrxO((object) cultureInfo)).DateSeparator), (object) new string[1]
            {
              (string) DateTimeFormatHelper.d7j6cphLr3mCM8nGHxPP((object) cultureInfo.DateTimeFormat)
            }, StringSplitOptions.RemoveEmptyEntries);
            num = 13;
            continue;
          case 3:
          case 4:
            if (index >= strArray.Length)
            {
              num = 12;
              continue;
            }
            goto case 7;
          case 5:
            if (DateTimeFormatHelper.Kv6an0hLUQtVGk875bgQ((object) strArray[index]) <= 2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 2;
              continue;
            }
            goto case 10;
          case 6:
          case 8:
          case 9:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 3;
            continue;
          case 7:
            if (!strArray[index].StartsWith((string) DateTimeFormatHelper.d5tBHwhLg93K7cjvuH9u(~541731958 ^ -541689033)))
            {
              num = 11;
              continue;
            }
            goto case 10;
          case 10:
            strArray[index] = (string) DateTimeFormatHelper.sNYOPlhLsQW78jHM7P2t((object) strArray[index], 0, 2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 3 : 9;
            continue;
          case 11:
            if (!DateTimeFormatHelper.VARRVOhLLJhUU4GhH9Jk((object) strArray[index], DateTimeFormatHelper.d5tBHwhLg93K7cjvuH9u(-2106517564 ^ -2106409216)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 5 : 8;
              continue;
            }
            goto case 5;
          case 12:
            goto label_4;
          case 13:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 4;
            continue;
          default:
            obj1 = DateTimeFormatHelper.kIHkMOhL9SKayT8PXmso();
            break;
        }
        cultureInfo = (CultureInfo) obj1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 0;
      }
label_4:
      return string.Join(((DateTimeFormatInfo) DateTimeFormatHelper.qHrRKAhLdirVNKUPbrxO((object) cultureInfo)).DateSeparator, strArray);
    }

    public static string ToCurrentFullFormat(this DateTime date) => date.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957860416));

    public static string ToCurrentFullFormatNotYear(this DateTime date) => date.ToString((string) DateTimeFormatHelper.UOcGtjhLcnsMhgs4p0WG(DateTimeFormatHelper.d5tBHwhLg93K7cjvuH9u(87862435 ^ 88015977)));

    public static string ToCurrentShortFormat(this DateTime date) => date.ToString((string) DateTimeFormatHelper.d5tBHwhLg93K7cjvuH9u(-1872275253 >> 6 ^ -29188735));

    public static string ToCurrentWithShortYearFormat(this DateTime date) => date.ToString((string) DateTimeFormatHelper.UOcGtjhLcnsMhgs4p0WG(DateTimeFormatHelper.d5tBHwhLg93K7cjvuH9u(-1334993905 ^ -1334954771)));

    internal static bool FduWCuhLyFRRiSspenTH() => DateTimeFormatHelper.C1HYAGhLmOCXFVfUwpkK == null;

    internal static DateTimeFormatHelper tYLb6BhLMA1Go62DoeZH() => DateTimeFormatHelper.C1HYAGhLmOCXFVfUwpkK;

    internal static object n16SGShLJAi1hLPGSGBu([In] object obj0) => (object) ((ILocalizationService) obj0).Load();

    internal static object kIHkMOhL9SKayT8PXmso() => (object) EleWise.ELMA.SR.GetDefaultCulture();

    internal static object qHrRKAhLdirVNKUPbrxO([In] object obj0) => (object) ((CultureInfo) obj0).DateTimeFormat;

    internal static object Ef4WJphLlvrtxHXLmLsA([In] object obj0) => (object) ((DateTimeFormatInfo) obj0).ShortDatePattern;

    internal static object d7j6cphLr3mCM8nGHxPP([In] object obj0) => (object) ((DateTimeFormatInfo) obj0).DateSeparator;

    internal static object d5tBHwhLg93K7cjvuH9u(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object kL3qRfhL59JPPLFdxqtJ([In] object obj0) => (object) ((DateTimeFormatInfo) obj0).TimeSeparator;

    internal static object kKsYqXhLj3qYQ1Iy4pOo([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object NEivvNhLYSDGwAR3YhVr([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static bool VARRVOhLLJhUU4GhH9Jk([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static int Kv6an0hLUQtVGk875bgQ([In] object obj0) => ((string) obj0).Length;

    internal static object sNYOPlhLsQW78jHM7P2t([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object UOcGtjhLcnsMhgs4p0WG([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
