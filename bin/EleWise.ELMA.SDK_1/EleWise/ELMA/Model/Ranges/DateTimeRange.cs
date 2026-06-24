// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Ranges.DateTimeRange
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Ranges
{
  /// <summary>Диапазон типа "Дата / время"</summary>
  public struct DateTimeRange : IRange<DateTime>
  {
    internal static object WvE2AqWz0KtvZXcD5em5;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Model.Ranges.DateTimeRange" />.
    /// </summary>
    public unsafe DateTimeRange(DateTime? from, DateTime? to)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      *(DateTimeRange*) ref this = new DateTimeRange();
      this.From = from;
      this.To = to;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Object" />.
    /// </summary>
    public DateTimeRange Create(DateTime? from, DateTime? to) => new DateTimeRange(from, to);

    /// <summary>От</summary>
    public DateTime? From { get; set; }

    /// <summary>До</summary>
    public DateTime? To { get; set; }

    /// <summary>Входит ли дата в промежуток</summary>
    /// <param name="date">Дата</param>
    /// <returns>True - входит, False - не входит</returns>
    public bool Contains(DateTime? date)
    {
      if (date.HasValue && date.HasValue)
      {
        DateTime dateTime1 = date.Value;
        DateTime? from = this.From;
        if ((from.HasValue ? (dateTime1 >= from.GetValueOrDefault() ? 1 : 0) : 0) != 0)
        {
          DateTime dateTime2 = date.Value;
          DateTime? to = this.To;
          return to.HasValue && dateTime2 <= to.GetValueOrDefault();
        }
      }
      return false;
    }

    /// <inheritdoc cref="!:" />
    public override string ToString()
    {
      string str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606767926);
      DateTime? nullable;
      string str2;
      if (!this.From.HasValue)
      {
        str2 = "";
      }
      else
      {
        nullable = this.From;
        str2 = nullable.ToString();
      }
      nullable = this.To;
      string str3;
      if (!nullable.HasValue)
      {
        str3 = "";
      }
      else
      {
        nullable = this.To;
        str3 = nullable.ToString();
      }
      return (string) DateTimeRange.kgXufkWzMasNKLbPkmnn((object) str1, (object) str2, (object) str3);
    }

    /// <inheritdoc cref="!:" />
    public override bool Equals(object obj)
    {
      int num1 = 10;
      DateTime? nullable1;
      DateTime? nullable2;
      while (true)
      {
        DateTimeRange dateTimeRange;
        int num2;
        switch (num1)
        {
          case 1:
            goto label_18;
          case 2:
            nullable1 = dateTimeRange.From;
            num1 = 8;
            continue;
          case 3:
            num2 = 1;
            break;
          case 4:
            goto label_14;
          case 5:
            if (nullable1.HasValue == nullable2.HasValue)
            {
              if (!nullable1.HasValue)
              {
                num1 = 3;
                continue;
              }
              num2 = DateTimeRange.SK01hZWzdhb1tuVR3dmf(nullable1.GetValueOrDefault(), nullable2.GetValueOrDefault()) ? 1 : 0;
              break;
            }
            num1 = 11;
            continue;
          case 6:
            if (nullable2.HasValue != nullable1.HasValue)
            {
              num1 = 13;
              continue;
            }
            if (nullable2.HasValue)
            {
              num1 = 4;
              continue;
            }
            goto label_13;
          case 7:
            nullable2 = dateTimeRange.To;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 12 : 0;
            continue;
          case 8:
            nullable2 = this.From;
            num1 = 5;
            continue;
          case 9:
            if (DateTimeRange.CCahuCWz9cnXlZya7KNv(obj.GetType(), DateTimeRange.Q8DIfGWzJWNm2WQIKggU((object) this)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            }
            dateTimeRange = (DateTimeRange) obj;
            num1 = 2;
            continue;
          case 10:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 8 : 9;
              continue;
            }
            goto label_18;
          case 11:
            num2 = 0;
            break;
          case 12:
            nullable1 = this.To;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 6 : 4;
            continue;
          case 13:
            goto label_22;
          case 14:
            goto label_13;
          default:
            goto label_25;
        }
        if (num2 != 0)
          num1 = 7;
        else
          goto label_15;
      }
label_13:
      return true;
label_14:
      return DateTimeRange.SK01hZWzdhb1tuVR3dmf(nullable2.GetValueOrDefault(), nullable1.GetValueOrDefault());
label_15:
      return false;
label_18:
      return false;
label_22:
      return false;
label_25:
      return false;
    }

    /// <inheritdoc cref="!:" />
    public override int GetHashCode()
    {
      int num1 = 2;
      DateTime dateTime1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          DateTime? from;
          DateTime dateTime2;
          switch (num2)
          {
            case 1:
              if (from.HasValue)
              {
                dateTime2 = from.GetValueOrDefault();
                break;
              }
              goto label_6;
            case 2:
              from = this.From;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_10;
            case 4:
              dateTime1 = new DateTime();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            default:
              dateTime2 = dateTime1;
              break;
          }
          dateTime1 = dateTime2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 0;
        }
label_6:
        num1 = 4;
      }
label_10:
      return dateTime1.GetHashCode() ^ (this.To ?? new DateTime()).GetHashCode();
    }

    internal static object kgXufkWzMasNKLbPkmnn([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool ElJXmkWzmhcjNW63qq8V() => DateTimeRange.WvE2AqWz0KtvZXcD5em5 == null;

    internal static object tf7GSlWzyEhw07hnvUlY() => DateTimeRange.WvE2AqWz0KtvZXcD5em5;

    internal static Type Q8DIfGWzJWNm2WQIKggU([In] object obj0) => obj0.GetType();

    internal static bool CCahuCWz9cnXlZya7KNv([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool SK01hZWzdhb1tuVR3dmf([In] DateTime obj0, [In] DateTime obj1) => obj0 == obj1;
  }
}
