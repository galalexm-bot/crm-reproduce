// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.WorkTime
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Интервал рабочего времени (минут)</summary>
  [TypeConverter(typeof (WorkTimeTypeConverter))]
  public struct WorkTime
  {
    private long value;
    private bool hasValue;
    private static object FJTLK4fimRVCCo5G6wOp;

    /// <summary>Конструктор</summary>
    /// <param name="minutes"></param>
    public WorkTime(int minutes)
    {
      WorkTime.YF58OMfiJUPq3Ku3yXVn();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        goto label_4;
label_1:
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.value = (long) minutes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 2;
            continue;
          case 2:
            this.hasValue = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:
      return;
label_4:
      num = 0;
      goto label_1;
    }

    /// <summary>Конструктор</summary>
    /// <param name="minutes"></param>
    public WorkTime(long minutes)
    {
      WorkTime.YF58OMfiJUPq3Ku3yXVn();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        goto label_5;
label_1:
      while (true)
      {
        switch (num)
        {
          case 1:
            this.value = minutes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.hasValue = true;
            num = 2;
            continue;
        }
      }
label_2:
      return;
label_5:
      num = 1;
      goto label_1;
    }

    /// <summary>Конструктор</summary>
    /// <param name="days"></param>
    /// <param name="hours"></param>
    /// <param name="minutes"></param>
    public WorkTime(long days, long hours, long minutes)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        goto label_5;
label_1:
      while (true)
      {
        switch (num)
        {
          case 1:
            this.hasValue = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 2;
            continue;
          case 2:
            goto label_2;
          default:
            this.value = days * WorkTime.minutesInDay + hours * 60L + minutes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
            continue;
        }
      }
label_2:
      return;
label_5:
      num = 0;
      goto label_1;
    }

    /// <summary>Конструктор</summary>
    /// <param name="hours"></param>
    /// <param name="minutes"></param>
    public WorkTime(long hours, long minutes)
    {
      WorkTime.YF58OMfiJUPq3Ku3yXVn();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        goto label_4;
label_1:
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.value = hours * 60L + minutes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            this.hasValue = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return;
label_4:
      num = 2;
      goto label_1;
    }

    /// <summary>Конструктор</summary>
    /// <param name="minutes"></param>
    public WorkTime(int? minutes)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.value = minutes.HasValue ? (long) minutes.Value : 0L;
      this.hasValue = true;
    }

    /// <summary>Конструктор</summary>
    /// <param name="minutes"></param>
    public WorkTime(long? minutes)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.value = minutes.HasValue ? minutes.Value : 0L;
      this.hasValue = true;
    }

    /// <summary>Конструктор</summary>
    /// <param name="minutes"></param>
    public WorkTime(string minutes)
    {
      WorkTime.YF58OMfiJUPq3Ku3yXVn();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        goto label_4;
label_1:
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
          case 5:
            this.hasValue = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
            continue;
          case 3:
            if (!WorkTime.q6w0xxfi9ra1GmHXrSx5((object) minutes))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 6 : 4;
              continue;
            }
            goto case 4;
          case 4:
            this.value = 0L;
            num = 2;
            continue;
          default:
            long result;
            this.value = long.TryParse(minutes, out result) ? result : 0L;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 5 : 0;
            continue;
        }
      }
label_7:
      return;
label_4:
      num = 2;
      goto label_1;
    }

    /// <summary>Значение</summary>
    public long Value
    {
      get => this.value;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.hasValue = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            case 2:
              this.value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    /// <summary>Количество минут в рабочем дне</summary>
    public long MinutesInDay => WorkTime.CLUGwkfidZmHOdRF97hH();

    private static long minutesInDay
    {
      get
      {
        int num1 = 1;
        long minutesInDay1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              minutesInDay1 = 1440L;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_12;
            default:
              goto label_2;
          }
        }
label_2:
        long minutesInDay2;
        try
        {
          TimeSpan timeSpan = WorkTime.BaJA3wfir5WxYPQW6L0N(WorkTime.mJgMZBfilVRfdK0FqubA((object) Locator.GetServiceNotNull<IProductionCalendarService>()));
          int num2 = 4;
          while (true)
          {
            switch (num2)
            {
              case 1:
                minutesInDay2 = 1440L;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 2;
                continue;
              case 2:
                goto label_13;
              case 3:
                goto label_12;
              case 4:
                minutesInDay1 = (long) Math.Floor(timeSpan.TotalMinutes);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                continue;
              default:
                if (minutesInDay1 <= 0L)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
                  continue;
                }
                goto label_12;
            }
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_12;
          }
        }
label_13:
        return minutesInDay2;
label_12:
        return minutesInDay1;
      }
    }

    /// <summary>Количество дней</summary>
    public long Days => this.TotalDays;

    /// <summary>Количество часов</summary>
    public long Hours => (long) WorkTime.ycqrV7fig0Ofwi6BkdOJ((double) (this.value - this.TotalDays * this.MinutesInDay) / 60.0);

    /// <summary>Количество минут</summary>
    public long Minutes => this.value - this.TotalHours * 60L;

    /// <summary>Всего дней</summary>
    public long TotalDays => (long) Math.Floor((double) this.value / (double) this.MinutesInDay);

    /// <summary>Всего часов</summary>
    public long TotalHours => (long) Math.Floor((double) this.value / 60.0);

    /// <summary>Всего минут</summary>
    public long TotalMinutes => this.value;

    /// <summary>Установлено ли значение</summary>
    public bool HasValue
    {
      get => this.hasValue;
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
              this.hasValue = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    /// <summary>Получить строковое представление</summary>
    /// <returns></returns>
    public override string ToString() => this.FormatString(true);

    /// <summary>Получить строковое представление</summary>
    /// <returns></returns>
    public string ToShortFormat() => this.FormatString(true);

    /// <summary>
    /// Вывод отформатированного значения в дня, часах и минутах.
    /// </summary>
    /// <returns></returns>
    public string ToFormatString() => this.FormatString();

    /// <summary>
    /// Вывод отформатированного значения в дня, часах и минутах.
    /// </summary>
    /// <returns></returns>
    private string FormatString(bool shortValue = false)
    {
      int num1 = 10;
      Action<long, string> action;
      StringBuilder text;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 8:
            action(this.Minutes, EleWise.ELMA.SR.T((string) WorkTime.zr3PCffi5IQ82InUTEQU(277947046 - -1479185048 ^ 1757345330)));
            num1 = 4;
            continue;
          case 2:
            if (this.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            action(this.TotalHours, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112438832)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
            continue;
          case 4:
            goto label_6;
          case 5:
            if (!shortValue)
            {
              num1 = 12;
              continue;
            }
            goto case 3;
          case 6:
            action = (Action<long, string>) ((val, postfix) =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_10;
                  case 2:
                    if (val <= 0L)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                      continue;
                    }
                    goto case 6;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    WorkTime.\u003C\u003Ec__DisplayClass32_0.gAjF0P8jmHZoJ4nOjfVQ((object) text, WorkTime.\u003C\u003Ec__DisplayClass32_0.wLo1or8j0fMKaQ34FTe7(1669371371 ^ 1669389513));
                    num2 = 8;
                    continue;
                  case 4:
                    goto label_2;
                  case 5:
                    text.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426076133));
                    num2 = 7;
                    continue;
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    if (WorkTime.\u003C\u003Ec__DisplayClass32_0.UVBSCu8j7WuNgubjMJ5t((object) text) <= 0)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 5;
                  case 8:
                    // ISSUE: reference to a compiler-generated method
                    WorkTime.\u003C\u003Ec__DisplayClass32_0.gAjF0P8jmHZoJ4nOjfVQ((object) text, (object) postfix);
                    num2 = 4;
                    continue;
                  case 9:
                    if (!string.IsNullOrEmpty(postfix))
                    {
                      num2 = 3;
                      continue;
                    }
                    goto label_5;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    WorkTime.\u003C\u003Ec__DisplayClass32_0.netIrh8jxWFD3Trsyv9Z((object) text, val);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 9 : 7;
                    continue;
                }
              }
label_10:
              return;
label_2:
              return;
label_5:;
            });
            num1 = 2;
            continue;
          case 7:
            action(this.Hours, (string) WorkTime.PxrklnfiYeBb0590C9Ap(WorkTime.zr3PCffi5IQ82InUTEQU(-1290212282 ^ -644262414 ^ 1787146482)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 8 : 6;
            continue;
          case 9:
            text = new StringBuilder();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 2 : 6;
            continue;
          case 10:
            num1 = 9;
            continue;
          case 11:
            goto label_3;
          case 12:
            action(this.Days, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409237976)));
            num1 = 7;
            continue;
          default:
            if (this.TotalMinutes != 0L)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 5 : 4;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return (string) WorkTime.jfSi9hfijuiuauMo1Kvo(WorkTime.zr3PCffi5IQ82InUTEQU(-1487388570 ^ -1487076712), (object) EleWise.ELMA.SR.T((string) WorkTime.zr3PCffi5IQ82InUTEQU(1574260816 ^ 1573917532)));
label_6:
      return text.ToString();
    }

    public override bool Equals(object obj)
    {
      int num = 3;
      WorkTime workTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            workTime = (WorkTime) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
            continue;
          case 3:
            if (obj is WorkTime)
            {
              num = 2;
              continue;
            }
            goto label_3;
          default:
            goto label_3;
        }
      }
label_2:
      return workTime.TotalMinutes == this.TotalMinutes;
label_3:
      return false;
    }

    public override int GetHashCode()
    {
      int num = 1;
      long totalMinutes;
      while (true)
      {
        switch (num)
        {
          case 1:
            totalMinutes = this.TotalMinutes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return totalMinutes.GetHashCode();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="m"></param>
    /// <returns></returns>
    public static implicit operator long(WorkTime m)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!m.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return 0;
label_3:
      return m.Value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="l"></param>
    /// <returns></returns>
    public static implicit operator WorkTime(long l)
    {
      int num = 1;
      WorkTime workTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            workTime = new WorkTime();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            workTime.Value = l;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:
      return workTime;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="m"></param>
    /// <returns></returns>
    public static implicit operator long?(WorkTime m) => !m.HasValue ? new long?() : new long?(m.Value);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="l"></param>
    /// <returns></returns>
    public static implicit operator WorkTime(long? l)
    {
      if (!l.HasValue)
        return new WorkTime() { HasValue = false };
      return new WorkTime()
      {
        Value = l.Value,
        HasValue = true
      };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static WorkTime operator -(WorkTime left, WorkTime right) => new WorkTime(left.TotalMinutes - right.TotalMinutes);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static WorkTime operator +(WorkTime left, WorkTime right) => new WorkTime(left.TotalMinutes + right.TotalMinutes);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(WorkTime left, WorkTime right) => left.TotalMinutes == right.TotalMinutes;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(WorkTime left, WorkTime right) => left.TotalMinutes != right.TotalMinutes;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator >(WorkTime left, WorkTime right) => left.TotalMinutes > right.TotalMinutes;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator <(WorkTime left, WorkTime right) => left.TotalMinutes < right.TotalMinutes;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator >=(WorkTime left, WorkTime right) => left.TotalMinutes >= right.TotalMinutes;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator <=(WorkTime left, WorkTime right) => left.TotalMinutes <= right.TotalMinutes;

    internal static void YF58OMfiJUPq3Ku3yXVn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool aOOko2fiyAkSI8D7dvxo() => WorkTime.FJTLK4fimRVCCo5G6wOp == null;

    internal static object GkPrnUfiMjD4OdNDGZ92() => WorkTime.FJTLK4fimRVCCo5G6wOp;

    internal static bool q6w0xxfi9ra1GmHXrSx5([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static long CLUGwkfidZmHOdRF97hH() => WorkTime.minutesInDay;

    internal static object mJgMZBfilVRfdK0FqubA([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

    internal static TimeSpan BaJA3wfir5WxYPQW6L0N([In] object obj0) => ((IProductionSchedule) obj0).GetWorkTimeInDay();

    internal static double ycqrV7fig0Ofwi6BkdOJ([In] double obj0) => Math.Floor(obj0);

    internal static object zr3PCffi5IQ82InUTEQU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jfSi9hfijuiuauMo1Kvo([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object PxrklnfiYeBb0590C9Ap([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
