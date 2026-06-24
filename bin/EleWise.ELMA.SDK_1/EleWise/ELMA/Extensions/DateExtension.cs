// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.DateExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  public static class DateExtension
  {
    internal static DateExtension HjVOqxG4AgaaAK4UnTWu;

    /// <summary>Сравнение экземпляров DateTime с точностью до минут</summary>
    /// <param name="date"></param>
    /// <param name="equals"></param>
    /// <returns></returns>
    public static bool EqualsUpToMinute(this DateTime date, DateTime equals)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_3;
            case 3:
              if (date.Year == equals.Year)
              {
                num2 = 2;
                continue;
              }
              goto label_10;
            case 4:
              if (date.Day == equals.Day)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            default:
              if (date.Hour == equals.Hour)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                continue;
              }
              goto label_10;
          }
        }
label_3:
        if (date.Month == equals.Month)
          num1 = 4;
        else
          goto label_10;
      }
label_9:
      return date.Minute == equals.Minute;
label_10:
      return false;
    }

    /// <summary>Привести к времени начала</summary>
    /// <param name="dateTime"></param>
    /// <param name="time"></param>
    /// <returns></returns>
    public static DateTime NormalizeStartDate(this DateTime dateTime, bool time)
    {
      int num = 1;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            flag = DateExtension.wXImdtG405K1hRLLTDKj() != DateExtension.eV5nY3G4m51HoQ3hnFX8();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, !(time | flag) ? 0 : dateTime.Hour, time | flag ? dateTime.Minute : 0, !time ? 10 : 0);
    }

    /// <summary>Привести к времени завершения</summary>
    /// <param name="dateTime"></param>
    /// <param name="time"></param>
    /// <returns></returns>
    public static DateTime NormalizeEndDate(this DateTime dateTime, bool time)
    {
      int num = 1;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            flag = DateExtension.wXImdtG405K1hRLLTDKj() != DateExtension.eV5nY3G4m51HoQ3hnFX8();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, time | flag ? dateTime.Hour : 23, !(time | flag) ? 59 : dateTime.Minute, !time ? 50 : 0);
    }

    /// <summary>Представить в виде строки время начала</summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static string DamperStartDateTime(this DateTime dateTime)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!DateExtension.W4GPGhG4yCjEqoxjW80b(dateTime))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            str = dateTime.ToShortDateString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
            continue;
          case 3:
            str = (string) DateExtension.GyaHCwG4MZAg2PJ2LWf4((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501453995), (object) dateTime.ToShortTimeString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 3 : 4;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return str;
    }

    /// <summary>Представить в виде строки время завершения</summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static string DamperEndDateTime(this DateTime dateTime)
    {
      int num = 3;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (DateExtension.A0AQIaG4JpDhyD1F9dOA(dateTime))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            str = dateTime.ToShortDateString();
            num = 2;
            continue;
          default:
            str = (string) DateExtension.GyaHCwG4MZAg2PJ2LWf4((object) str, DateExtension.NCvAuYG49X995jFfgxtU(1917998801 >> 2 ^ 479517846), (object) dateTime.ToShortTimeString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      return str;
    }

    /// <summary>
    ///  НЕ ИСПОЛЬЗОВАТЬ В RUNTIME SCOPE! Указано время даты начала (для использования в представлениях)
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static bool IsStartDamperTime(this DateTime dateTime)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_2;
          case 3:
            if (dateTime.Minute == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 4:
            if (dateTime.Hour == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 3 : 0;
              continue;
            }
            goto label_3;
          default:
            if (dateTime.Second < 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return dateTime.Second > 10;
label_3:
      return true;
    }

    /// <summary>
    /// НЕ ИСПОЛЬЗОВАТЬ В RUNTIME SCOPE! Указано время даты завершения (для использования в представлениях)
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static bool IsEndDamperTime(this DateTime dateTime)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (dateTime.Minute == 59)
            {
              num = 4;
              continue;
            }
            goto label_3;
          case 2:
            if (dateTime.Hour == 23)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          case 3:
            goto label_3;
          case 4:
            if (dateTime.Second < 50)
            {
              num = 3;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return dateTime.Second > 59;
label_3:
      return true;
    }

    /// <summary>
    /// Указано время даты начала (без учета смещения часовых поясов)
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static bool IsStartDamperTimeBySeconds(this DateTime dateTime)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (dateTime.Second < 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return dateTime.Second > 10;
label_5:
      return true;
    }

    /// <summary>
    /// Указано время даты завершения (без учета смещения часовых поясов)
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static bool IsEndDamperTimeBySeconds(this DateTime dateTime)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (dateTime.Second >= 50)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return dateTime.Second > 59;
label_5:
      return true;
    }

    /// <summary>Сбросить минуты до значения кратного 15</summary>
    /// <param name="minutes">Минуты</param>
    /// <returns></returns>
    public static int LeadMinutesToFifteen(this int minutes)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (minutes >= 15)
            {
              num = 3;
              continue;
            }
            goto label_6;
          case 3:
            goto label_7;
          case 4:
            if (minutes >= 30)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
            }
            goto case 2;
          case 5:
            if (minutes < 45)
            {
              num = 4;
              continue;
            }
            goto label_9;
          default:
            goto label_6;
        }
      }
label_6:
      return 0;
label_7:
      return 15;
label_8:
      return 30;
label_9:
      return 45;
    }

    /// <summary>Если начало дня - вывести только дату</summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static string DamperStartDateTime(this DateTime? dateTime) => !dateTime.HasValue ? string.Empty : dateTime.Value.DamperStartDateTime();

    /// <summary>Если конец дня - вывести только дату</summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static string DamperEndDateTime(this DateTime? dateTime) => !dateTime.HasValue ? string.Empty : dateTime.Value.DamperEndDateTime();

    /// <summary>Преобразовать время в формате UTC в локальное</summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static DateTime ConvertUtcToLocal(this DateTime dateTime)
    {
      int num = 1;
      DateTime dateTime1;
      while (true)
      {
        switch (num)
        {
          case 1:
            dateTime1 = DateExtension.n7tFd3G4dIDNiGgSWnLQ(dateTime, DateTimeKind.Utc);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return dateTime1.ToLocalTime();
    }

    /// <summary>Локальное время принадлежит текущей локальной дате</summary>
    /// <param name="runtimeDateTime"></param>
    /// <returns></returns>
    public static bool IsToday(this DateTime runtimeDateTime) => DateExtension.rZQFecG4rJdqipQRiwIO(runtimeDateTime.Date, DateExtension.JkG18MG4lg4ZGbcUUf74());

    /// <summary>
    /// Возвращает дату в строковом виде, в соответствии с текущей датой
    /// </summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>"Вчера", "Сегодня", "Завтра" или время</returns>
    public static string ToDisplayDateString(this DateTime runtimeDateTime)
    {
      int num = 2;
      DateTime dateTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (runtimeDateTime.IsToday())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            }
            if (!(runtimeDateTime.Date == dateTime.AddDays(1.0)))
            {
              num = 4;
              continue;
            }
            goto label_7;
          case 2:
            dateTime = DateExtension.JkG18MG4lg4ZGbcUUf74();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (DateExtension.rZQFecG4rJdqipQRiwIO(runtimeDateTime.Date, dateTime.AddDays(-1.0)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 2 : 5;
              continue;
            }
            goto label_12;
          case 5:
            goto label_11;
          default:
            goto label_4;
        }
      }
label_4:
      return EleWise.ELMA.SR.Today;
label_7:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902019471));
label_11:
      return (string) DateExtension.chDfxaG4gvuOogEyJf0n((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138280453));
label_12:
      return runtimeDateTime.ToLongDateString();
    }

    /// <summary>Пользовательское время принадлежит текущей дате</summary>
    /// <param name="clientDateTime">Пользовательское время</param>
    /// <returns></returns>
    public static bool IsCurrentClientDate(this DateTime clientDateTime) => DateExtension.rZQFecG4rJdqipQRiwIO(clientDateTime.Date, DateExtension.HNRFDrG451BNIbkkcyl6());

    /// <summary>
    /// Если начало дня - вывести только дату в пользовательском часовом поясе, иначе - время в пользовательском часовом поясе
    /// </summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns></returns>
    public static string DamperStartDateTimeWithTransformationToClient(
      this DateTime? runtimeDateTime)
    {
      return !runtimeDateTime.HasValue ? string.Empty : runtimeDateTime.Value.ToClientDateTime(TZ.Client).DamperStartDateTime();
    }

    /// <summary>
    /// Если конец дня - вывести только дату в пользовательском часовом поясе, иначе - время в пользовательском часовом поясе
    /// </summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns></returns>
    public static string DamperEndDateTimeWithTransformationToClient(this DateTime? runtimeDateTime) => !runtimeDateTime.HasValue ? string.Empty : runtimeDateTime.Value.ToClientDateTime(TZ.Client).DamperEndDateTime();

    internal static bool fgpewZG47wMC4eAi8AMa() => DateExtension.HjVOqxG4AgaaAK4UnTWu == null;

    internal static DateExtension qT41jbG4xdmwaxWvnChV() => DateExtension.HjVOqxG4AgaaAK4UnTWu;

    internal static int wXImdtG405K1hRLLTDKj() => TZ.ClientOffset;

    internal static int eV5nY3G4m51HoQ3hnFX8() => TZ.ServerOffset;

    internal static bool W4GPGhG4yCjEqoxjW80b(DateTime dateTime) => dateTime.IsStartDamperTime();

    internal static object GyaHCwG4MZAg2PJ2LWf4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool A0AQIaG4JpDhyD1F9dOA(DateTime dateTime) => dateTime.IsEndDamperTime();

    internal static object NCvAuYG49X995jFfgxtU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime n7tFd3G4dIDNiGgSWnLQ([In] DateTime obj0, [In] DateTimeKind obj1) => DateTime.SpecifyKind(obj0, obj1);

    internal static DateTime JkG18MG4lg4ZGbcUUf74() => DateTime.Today;

    internal static bool rZQFecG4rJdqipQRiwIO([In] DateTime obj0, [In] DateTime obj1) => obj0 == obj1;

    internal static object chDfxaG4gvuOogEyJf0n([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static DateTime HNRFDrG451BNIbkkcyl6() => TZ.CurrentClientDate;
  }
}
