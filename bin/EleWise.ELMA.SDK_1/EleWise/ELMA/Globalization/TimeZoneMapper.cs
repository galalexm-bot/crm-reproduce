// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.TimeZoneMapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Properties;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace EleWise.ELMA.Globalization
{
  /// <summary>
  /// Статический класс для получения часового пояса Windows по IANA идентификатору
  /// </summary>
  public static class TimeZoneMapper
  {
    /// <summary>
    /// Словарь соответствий IANA TimeZone Id - Windows TimeZone Id
    /// </summary>
    private static Dictionary<string, string> ianaToWindowsMap;
    private static TimeZoneMapper AKwa1tGoobjgiO2YwudA;

    /// <summary>
    /// Инициализировать словарь соответствий IANA TimeZone Id - Windows TimeZone Id
    /// </summary>
    private static void InitializeIanaToWindowsMap()
    {
      int num1 = 2;
      IEnumerator<XElement> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_28;
          case 1:
            enumerator = ((XContainer) TimeZoneMapper.KyX7BjGoEu2EgbdidViN(TimeZoneMapper.sRqKFFGoGxZj6KhWpnri())).Descendants((XName) TimeZoneMapper.COU2XyGoQFpvqhfBKwf8(TimeZoneMapper.ddY0ZfGofRCXCr8hG0cO(1461825605 - 1531863589 ^ -70191514))).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 3;
            continue;
          case 2:
            TimeZoneMapper.ianaToWindowsMap = new Dictionary<string, string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_23;
        }
      }
label_28:
      return;
label_23:
      return;
label_3:
      try
      {
label_15:
        if (TimeZoneMapper.yJO89sGo88XdEHsOgTZK((object) enumerator))
          goto label_17;
        else
          goto label_16;
label_4:
        XAttribute xattribute1;
        XAttribute xattribute2;
        string str;
        string[] strArray1;
        int index;
        string key;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = 4;
              continue;
            case 2:
            case 4:
              if (index < strArray1.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 8 : 1;
                continue;
              }
              goto label_15;
            case 3:
              if (xattribute1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 4 : 13;
                continue;
              }
              goto label_15;
            case 6:
              TimeZoneMapper.ianaToWindowsMap.Add(key, str);
              num2 = 7;
              continue;
            case 7:
            case 10:
              ++index;
              num2 = 2;
              continue;
            case 8:
            case 11:
              key = strArray1[index];
              num2 = 14;
              continue;
            case 9:
              goto label_22;
            case 12:
              string[] strArray2 = ((string) TimeZoneMapper.YdekJ2GovufS6dRhGyJg((object) xattribute1)).Split(' ');
              str = (string) TimeZoneMapper.YdekJ2GovufS6dRhGyJg((object) xattribute2);
              strArray1 = strArray2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
              continue;
            case 13:
              if (xattribute2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                continue;
              }
              goto case 12;
            case 14:
              if (TimeZoneMapper.ianaToWindowsMap.ContainsKey(key))
              {
                num2 = 10;
                continue;
              }
              goto case 6;
            case 15:
              goto label_17;
            default:
              goto label_15;
          }
        }
label_22:
        return;
label_16:
        num2 = 9;
        goto label_4;
label_17:
        XElement current = enumerator.Current;
        xattribute1 = (XAttribute) TimeZoneMapper.B8nPbWGoCKWo9dxVEMjq((object) current, TimeZoneMapper.COU2XyGoQFpvqhfBKwf8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146509055)));
        xattribute2 = (XAttribute) TimeZoneMapper.B8nPbWGoCKWo9dxVEMjq((object) current, TimeZoneMapper.COU2XyGoQFpvqhfBKwf8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218514954)));
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        {
          num2 = 3;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                TimeZoneMapper.uqXBOyGoZK4GOAbTjfZy((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                continue;
              default:
                goto label_30;
            }
          }
        }
label_30:;
      }
    }

    /// <summary>Получить часовой пояс по IANA идентификатору</summary>
    /// <param name="ianaTimeZoneId">Идентификатор часового пояса IANA</param>
    /// <param name="offset">Смещение</param>
    /// <returns></returns>
    public static TimeZoneModel GetTimeZoneByIanaTimeZoneId(string ianaTimeZoneId, int offset)
    {
      int num1 = 2;
      string windowsTimeZoneId;
      int offset1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            offset1 = offset;
            num1 = 5;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
            continue;
          case 3:
            if (TimeZoneMapper.ianaToWindowsMap == null)
            {
              num1 = 4;
              continue;
            }
            break;
          case 4:
            TimeZoneMapper.InitializeIanaToWindowsMap();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 5:
            if (!string.IsNullOrEmpty(ianaTimeZoneId))
            {
              num1 = 3;
              continue;
            }
            goto label_9;
          case 6:
            goto label_9;
          case 7:
            goto label_4;
          case 8:
            goto label_7;
        }
        if (TimeZoneMapper.ianaToWindowsMap.ContainsKey(ianaTimeZoneId))
        {
          windowsTimeZoneId = TimeZoneMapper.ianaToWindowsMap[ianaTimeZoneId];
          num1 = 7;
        }
        else
          num1 = 8;
      }
label_4:
      return TZ.TimeZones.FirstOrDefault<TimeZoneModel>((Func<TimeZoneModel, bool>) (tz =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!TimeZoneMapper.\u003C\u003Ec__DisplayClass2_0.ecD11cvdHudlU0EMVU50(TimeZoneMapper.\u003C\u003Ec__DisplayClass2_0.qjstC2vd6l7E2Xc8jqCW((object) tz), (object) windowsTimeZoneId))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return TimeZoneMapper.\u003C\u003Ec__DisplayClass2_0.I3hsApvdAuL6Han1ErMe((object) tz) == offset1;
label_3:
        return false;
      }));
label_7:
      return (TimeZoneModel) null;
label_9:
      return (TimeZoneModel) null;
    }

    internal static object sRqKFFGoGxZj6KhWpnri() => (object) Resources.WindowsZones;

    internal static object KyX7BjGoEu2EgbdidViN([In] object obj0) => (object) XDocument.Parse((string) obj0);

    internal static object ddY0ZfGofRCXCr8hG0cO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object COU2XyGoQFpvqhfBKwf8([In] object obj0) => (object) (XName) (string) obj0;

    internal static object B8nPbWGoCKWo9dxVEMjq([In] object obj0, [In] object obj1) => (object) ((XElement) obj0).Attribute((XName) obj1);

    internal static object YdekJ2GovufS6dRhGyJg([In] object obj0) => (object) ((XAttribute) obj0).Value;

    internal static bool yJO89sGo88XdEHsOgTZK([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void uqXBOyGoZK4GOAbTjfZy([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool F8rhsNGobKtRvcoFH1hC() => TimeZoneMapper.AKwa1tGoobjgiO2YwudA == null;

    internal static TimeZoneMapper hVXjafGohRgLpaaMy76P() => TimeZoneMapper.AKwa1tGoobjgiO2YwudA;
  }
}
