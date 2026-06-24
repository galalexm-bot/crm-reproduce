// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.RelativeDateTimeParser
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Common;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Разбор относительных дат</summary>
  public static class RelativeDateTimeParser
  {
    private static RelativeDateTimeParser jVjkP7hjYKdFyOHI4xYL;

    /// <summary>Разбор относительной даты начала временного интервала</summary>
    /// <param name="str">Входная строка относительной даты</param>
    /// <param name="result">Абсолютная дата, соответсвующаяя входной строке <paramref name="str" /></param>
    /// <param name="errorMessage">Текст ошибки</param>
    /// <returns><see langword="true" />, если относительная дата разобрана, иначе <see langword="false" /> и ошибка в <paramref name="errorMessage" /></returns>
    public static bool TryParseFromDate(string str, out DateTime? result, out string errorMessage) => RelativeDateTimeParser.TryParse((object) str, true, out result, out errorMessage);

    /// <summary>Разбор относительной даты конца временного интервала</summary>
    /// <param name="str">Входная строка относительной даты</param>
    /// <param name="result">Абсолютная дата, соответсвующаяя входной строке <paramref name="str" /></param>
    /// <param name="errorMessage">Текст ошибки</param>
    /// <returns><see langword="true" />, если относительная дата разобрана, иначе <see langword="false" /> и ошибка в <paramref name="errorMessage" /></returns>
    public static bool TryParseToDate(string str, out DateTime? result, out string errorMessage) => RelativeDateTimeParser.TryParse((object) str, false, out result, out errorMessage);

    /// <summary>Разбор относительной даты начала временного интервала</summary>
    /// <param name="str">Входная строка относительной даты</param>
    /// <param name="result">Абсолютная дата, соответсвующаяя входной строке <paramref name="str" /></param>
    /// <returns><see langword="true" />, если относительная дата разобрана, иначе <see langword="false" /></returns>
    public static bool TryParseFromDate(string str, out DateTime? result) => RelativeDateTimeParser.TryParse((object) str, true, out result, out string _);

    /// <summary>Разбор относительной даты конца временного интервала</summary>
    /// <param name="str">Входная строка относительной даты</param>
    /// <param name="result">Абсолютная дата, соответсвующаяя входной строке <paramref name="str" /></param>
    /// <returns><see langword="true" />, если относительная дата разобрана, иначе <see langword="false" /></returns>
    public static bool TryParseToDate(string str, out DateTime? result) => RelativeDateTimeParser.TryParse((object) str, false, out result, out string _);

    /// <summary>Разбор относительной даты начала временного интервала</summary>
    /// <param name="str">Входная строка относительной даты</param>
    /// <returns>Абсолютная дата, соответсвующаяя входной строке <paramref name="str" /></returns>
    public static DateTime ParseFromDate(string str)
    {
      int num = 1;
      DateTime? result;
      string errorMessage;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (RelativeDateTimeParser.TryParse((object) str, true, out result, out errorMessage))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return result.Value;
label_3:
      throw new Exception(errorMessage);
    }

    /// <summary>Разбор относительной даты конца временного интервала</summary>
    /// <param name="str">Входная строка относительной даты</param>
    /// <returns>Абсолютная дата, соответсвующаяя входной строке <paramref name="str" /></returns>
    public static DateTime ParseToDate(string str)
    {
      int num = 1;
      DateTime? result;
      string errorMessage;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (RelativeDateTimeParser.TryParse((object) str, false, out result, out errorMessage))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return result.Value;
label_3:
      throw new Exception(errorMessage);
    }

    /// <summary>
    /// Разбор относительной даты начала временного интервала, используется для тестов
    /// </summary>
    /// <param name="str">Входная строка относительной даты</param>
    /// <param name="now">Значение для текущего времени</param>
    /// <returns>Абсолютная дата, соответсвующаяя входной строке <paramref name="str" /></returns>
    internal static DateTime ParseFromDate(string str, DateTime now)
    {
      int num = 1;
      DateTime? result;
      string errorMessage;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!RelativeDateTimeParser.TryParse((object) str, true, out result, out errorMessage, new DateTime?(now)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return result.Value;
label_5:
      throw new Exception(errorMessage);
    }

    /// <summary>
    /// Разбор относительной даты конца временного интервала, используется для тестов
    /// </summary>
    /// <param name="str">Входная строка относительной даты</param>
    /// <param name="now">Значение для текущего времени</param>
    /// <returns>Абсолютная дата, соответсвующаяя входной строке <paramref name="str" /></returns>
    internal static DateTime ParseToDate(string str, DateTime now)
    {
      int num = 2;
      DateTime? result;
      string errorMessage;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!RelativeDateTimeParser.TryParse((object) str, false, out result, out errorMessage, new DateTime?(now)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return result.Value;
label_5:
      throw new Exception(errorMessage);
    }

    private static bool TryParse(
      object str,
      bool isFrom,
      out DateTime? result,
      out string errorMessage,
      DateTime? now = null)
    {
      result = new DateTime?();
      errorMessage = "";
      if (string.IsNullOrEmpty((string) str))
        return false;
      str = (object) Regex.Replace((string) str, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323243646), string.Empty).ToLower();
      if (string.IsNullOrEmpty((string) str))
      {
        errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334952359));
        return false;
      }
      MatchCollection source = Regex.Matches((string) str, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29212699), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824413371), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426315823)));
      // ISSUE: reference to a compiler-generated method
      if (source.Count < 1 || source.Cast<Match>().Sum<Match>((Func<Match, int>) (m => RelativeDateTimeParser.\u003C\u003Ec.VgV4P8vmyQCw69ksQnyt((object) m.Value))) != ((string) str).Length)
      {
        errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218724274));
        return false;
      }
      List<Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>> list = source.Cast<Match>().Select<Match, Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>>((Func<Match, Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>>) (match => new Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>(int.Parse(match.Groups[2].Value), match.Groups[6].Value.ToRelativeDateTimeMeter()))).ToList<Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>>();
      if (!isFrom)
      {
        RelativeDateTimeParser.RelativeDateTimeMeter minType = list.Min<Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>, RelativeDateTimeParser.RelativeDateTimeMeter>((Func<Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>, RelativeDateTimeParser.RelativeDateTimeMeter>) (v => v.Second));
        ++list.First<Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>>((Func<Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>, bool>) (v => v.Second == minType)).First;
      }
      result = new DateTime?(now ?? DateTime.Now);
      DateTime date;
      switch (list[0].Second)
      {
        case RelativeDateTimeParser.RelativeDateTimeMeter.Hour:
          ref DateTime? local1 = ref result;
          date = result.Value;
          date = date.Date;
          DateTime? nullable1 = new DateTime?(date.AddHours((double) result.Value.Hour));
          local1 = nullable1;
          break;
        case RelativeDateTimeParser.RelativeDateTimeMeter.Day:
          ref DateTime? local2 = ref result;
          date = result.Value;
          DateTime? nullable2 = new DateTime?(date.Date);
          local2 = nullable2;
          break;
        case RelativeDateTimeParser.RelativeDateTimeMeter.Week:
          ref DateTime? local3 = ref result;
          date = result.Value;
          date = date.Date;
          DateTime? nullable3 = new DateTime?(date.AddDays((double) -((int) (result.Value.DayOfWeek - 1 + 7) % 7)));
          local3 = nullable3;
          break;
        case RelativeDateTimeParser.RelativeDateTimeMeter.Month:
          ref DateTime? local4 = ref result;
          date = result.Value;
          int year1 = date.Year;
          date = result.Value;
          int month1 = date.Month;
          DateTime? nullable4 = new DateTime?(new DateTime(year1, month1, 1));
          local4 = nullable4;
          break;
        case RelativeDateTimeParser.RelativeDateTimeMeter.Quarter:
          ref DateTime? local5 = ref result;
          date = result.Value;
          int year2 = date.Year;
          date = result.Value;
          int month2 = date.Month;
          date = result.Value;
          int num = (date.Month - 1) % 3;
          int month3 = month2 - num;
          DateTime? nullable5 = new DateTime?(new DateTime(year2, month3, 1));
          local5 = nullable5;
          break;
        case RelativeDateTimeParser.RelativeDateTimeMeter.Year:
          ref DateTime? local6 = ref result;
          date = result.Value;
          DateTime? nullable6 = new DateTime?(new DateTime(date.Year, 1, 1));
          local6 = nullable6;
          break;
      }
      foreach (Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter> pair in list.Where<Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>>((Func<Pair<int, RelativeDateTimeParser.RelativeDateTimeMeter>, bool>) (v => v.First != 0)))
      {
        switch (pair.Second)
        {
          case RelativeDateTimeParser.RelativeDateTimeMeter.Hour:
            ref DateTime? local7 = ref result;
            date = result.Value;
            DateTime? nullable7 = new DateTime?(date.AddHours((double) pair.First));
            local7 = nullable7;
            continue;
          case RelativeDateTimeParser.RelativeDateTimeMeter.Day:
            ref DateTime? local8 = ref result;
            date = result.Value;
            DateTime? nullable8 = new DateTime?(date.AddDays((double) pair.First));
            local8 = nullable8;
            continue;
          case RelativeDateTimeParser.RelativeDateTimeMeter.Week:
            ref DateTime? local9 = ref result;
            date = result.Value;
            DateTime? nullable9 = new DateTime?(date.AddDays((double) (7 * pair.First)));
            local9 = nullable9;
            continue;
          case RelativeDateTimeParser.RelativeDateTimeMeter.Month:
            ref DateTime? local10 = ref result;
            date = result.Value;
            DateTime? nullable10 = new DateTime?(date.AddMonths(pair.First));
            local10 = nullable10;
            continue;
          case RelativeDateTimeParser.RelativeDateTimeMeter.Quarter:
            ref DateTime? local11 = ref result;
            date = result.Value;
            DateTime? nullable11 = new DateTime?(date.AddMonths(3 * pair.First));
            local11 = nullable11;
            continue;
          case RelativeDateTimeParser.RelativeDateTimeMeter.Year:
            ref DateTime? local12 = ref result;
            date = result.Value;
            DateTime? nullable12 = new DateTime?(date.AddYears(pair.First));
            local12 = nullable12;
            continue;
          default:
            continue;
        }
      }
      if (!isFrom && result.Value.TimeOfDay == TimeSpan.Zero)
        result = new DateTime?(result.Value.AddSeconds(-10.0));
      return true;
    }

    /// <summary>Локализация для 'ч'</summary>
    public static string Hour => (string) RelativeDateTimeParser.JhhEMghjs9gqJJeBFJrw(RelativeDateTimeParser.RelativeDateTimeMeter.Hour);

    /// <summary>Локализация для 'д'</summary>
    public static string Day => (string) RelativeDateTimeParser.JhhEMghjs9gqJJeBFJrw(RelativeDateTimeParser.RelativeDateTimeMeter.Day);

    /// <summary>Локализация для 'н'</summary>
    public static string Week => RelativeDateTimeParser.SR(RelativeDateTimeParser.RelativeDateTimeMeter.Week);

    /// <summary>Локализация для 'м'</summary>
    public static string Month => (string) RelativeDateTimeParser.JhhEMghjs9gqJJeBFJrw(RelativeDateTimeParser.RelativeDateTimeMeter.Month);

    /// <summary>Локализация для 'к'</summary>
    public static string Quarter => (string) RelativeDateTimeParser.JhhEMghjs9gqJJeBFJrw(RelativeDateTimeParser.RelativeDateTimeMeter.Quarter);

    /// <summary>Локализация для 'г'</summary>
    public static string Year => (string) RelativeDateTimeParser.JhhEMghjs9gqJJeBFJrw(RelativeDateTimeParser.RelativeDateTimeMeter.Year);

    private static string SR(
      RelativeDateTimeParser.RelativeDateTimeMeter relativeDateTimeMeter)
    {
      int num = 6;
      char ch;
      while (true)
      {
        CultureInfo cultureInfo;
        object obj1;
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            ch = RelativeDateTimeParser.KNEyrqhYhtHWB2up5ILq(RelativeDateTimeParser.z4H6kPhYojCMhbsoHJPD(~538519529 ^ -538608946), (int) relativeDateTimeMeter);
            num = 3;
            continue;
          case 3:
            goto label_4;
          case 4:
            ch = ((string) RelativeDateTimeParser.z4H6kPhYojCMhbsoHJPD(-16752921 ^ -16516081))[(int) relativeDateTimeMeter];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
            continue;
          case 5:
            obj1 = RelativeDateTimeParser.cK6qnfhYF0ONYquy0ax1(RelativeDateTimeParser.SXEmNshjzqotttlp4uVG());
            break;
          case 6:
            object obj2 = RelativeDateTimeParser.BMAT4nhjcUirB4NwlwvP();
            if (obj2 == null)
            {
              num = 5;
              continue;
            }
            obj1 = obj2;
            break;
          default:
            if (!RelativeDateTimeParser.IOPh2IhYbwrp0Bp9AEMl(RelativeDateTimeParser.Xw3MLthYWu8XpblvOlVJ((object) ((LanguagesMap) RelativeDateTimeParser.dmbJAThYB7tlmLfaF3cr()).GetBaseCultureInfo((string) RelativeDateTimeParser.Xw3MLthYWu8XpblvOlVJ((object) cultureInfo))), RelativeDateTimeParser.z4H6kPhYojCMhbsoHJPD(~538519529 ^ -538525102), StringComparison.InvariantCultureIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 4;
              continue;
            }
            goto case 2;
        }
        cultureInfo = (CultureInfo) obj1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
      }
label_3:
      return ch.ToString();
label_4:
      return ch.ToString();
    }

    private static RelativeDateTimeParser.RelativeDateTimeMeter ToRelativeDateTimeMeter(
      this object symbol)
    {
      int num = 4;
      int relativeDateTimeMeter;
      while (true)
      {
        switch (num)
        {
          case 1:
            relativeDateTimeMeter = ((string) RelativeDateTimeParser.z4H6kPhYojCMhbsoHJPD(1470440286 ^ 1470529974)).IndexOf((string) symbol);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 3:
            if (relativeDateTimeMeter >= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 1;
              continue;
            }
            goto case 1;
          case 4:
            relativeDateTimeMeter = RelativeDateTimeParser.sKkMughYGtbVsptYQSOv(RelativeDateTimeParser.z4H6kPhYojCMhbsoHJPD(-53329496 >> 4 ^ -3242302), symbol);
            num = 3;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (RelativeDateTimeParser.RelativeDateTimeMeter) relativeDateTimeMeter;
    }

    internal static bool TWtjMPhjL2OcyIwB8DA2() => RelativeDateTimeParser.jVjkP7hjYKdFyOHI4xYL == null;

    internal static RelativeDateTimeParser dg64YbhjUUon8N5nXeZv() => RelativeDateTimeParser.jVjkP7hjYKdFyOHI4xYL;

    internal static object JhhEMghjs9gqJJeBFJrw(
      RelativeDateTimeParser.RelativeDateTimeMeter relativeDateTimeMeter)
    {
      return (object) RelativeDateTimeParser.SR(relativeDateTimeMeter);
    }

    internal static object BMAT4nhjcUirB4NwlwvP() => (object) EleWise.ELMA.SR.GetCurrentCulture();

    internal static object SXEmNshjzqotttlp4uVG() => (object) Thread.CurrentThread;

    internal static object cK6qnfhYF0ONYquy0ax1([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static object dmbJAThYB7tlmLfaF3cr() => (object) EleWise.ELMA.SR.LanguagesMap;

    internal static object Xw3MLthYWu8XpblvOlVJ([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object z4H6kPhYojCMhbsoHJPD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool IOPh2IhYbwrp0Bp9AEMl([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static char KNEyrqhYhtHWB2up5ILq([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static int sKkMughYGtbVsptYQSOv([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    private enum RelativeDateTimeMeter
    {
      Hour,
      Day,
      Week,
      Month,
      Quarter,
      Year,
    }
  }
}
