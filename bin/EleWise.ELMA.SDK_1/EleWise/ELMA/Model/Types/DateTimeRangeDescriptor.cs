// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.DateTimeRangeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Дата / время (Диапазон)"</summary>
  public class DateTimeRangeDescriptor : 
    RangeTypeDescriptor<DateTimeRange, DateTime, DateTimeSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{6FBBCA7C-A693-4791-902C-30B5984671A2}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private static DateTimeRangeDescriptor WJPZW8oJAFrWrHg3scXb;

    /// <summary>Дескриптор типа "Дата / время"</summary>
    [XmlIgnore]
    public DateTimeDescriptor DateTimeDescriptor
    {
      get => this.\u003CDateTimeDescriptor\u003Ek__BackingField;
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
              this.\u003CDateTimeDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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

    /// <summary>Uid типа</summary>
    public override Guid Uid => DateTimeRangeDescriptor.UID;

    /// <summary>Имя "Дата / время (Диапазон)"</summary>
    public override string Name => (string) DateTimeRangeDescriptor.p4db5AoJmNrv5nbuixst(DateTimeRangeDescriptor.IcVlbAoJ0aCB6DmgdLJS(964881585 - -1459193222 ^ -1870731133));

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 3;
      DateTime? nullable;
      DateTimeRange dateTimeRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (nullable.HasValue)
            {
              num = 8;
              continue;
            }
            goto label_6;
          case 2:
            nullable = dateTimeRange.From;
            num = 7;
            continue;
          case 3:
            dateTimeRange = (DateTimeRange) val;
            num = 2;
            continue;
          case 4:
            goto label_6;
          case 5:
            if (!DateTimeRangeDescriptor.stZk3HoJyHmKgh6TeUvJ(nullable.Value, DateTime.MinValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            }
            goto case 9;
          case 6:
            if (!(nullable.Value == DateTime.MinValue))
            {
              num = 11;
              continue;
            }
            goto label_6;
          case 7:
            if (nullable.HasValue)
            {
              num = 10;
              continue;
            }
            goto case 9;
          case 8:
            nullable = dateTimeRange.To;
            num = 6;
            continue;
          case 9:
            nullable = dateTimeRange.To;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
            continue;
          case 10:
            nullable = dateTimeRange.From;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 5;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return true;
label_7:
      return false;
    }

    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num = 4;
      ICriterion criterion;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (criterion != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 2;
              continue;
            }
            goto label_12;
          case 2:
            DateTimeRangeDescriptor.WCcnSZoJrnTL5dvhAxxL((object) criteria, (object) criterion);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 1;
            continue;
          case 3:
            DateTimeRangeDescriptor.UOAiZaoJMKDxNuPFrdhN((object) this, (object) criteria, (object) metadata, (object) propertyMetadata, value, (object) alias);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 4:
            if (value is DateTimeRange dateTimeRange)
            {
              criterion = (ICriterion) DateTimeRangeDescriptor.MqtCbtoJlqLDARde05RC(dateTimeRange, DateTimeRangeDescriptor.HRwV0OoJ9AgwUhhgiKNx((object) (DateTimeSettings) DateTimeRangeDescriptor.aHRJYXoJJXNC5qZnbuEb((object) propertyMetadata)), (object) alias, DateTimeRangeDescriptor.vq2uDdoJdnr08EAOOdNm((object) propertyMetadata));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
            }
            num = 3;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_11;
        }
      }
label_2:
      return;
label_3:
      return;
label_11:
      return;
label_12:;
    }

    /// <inheritdoc />
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 7;
      SerializableDictionary<string, object> serializableDictionary1;
      while (true)
      {
        int num2 = num1;
        DateTimeRange dateTimeRange;
        DateTime? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              SerializableDictionary<string, object> serializableDictionary2 = serializableDictionary1;
              string key1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643016446);
              DateTimeDescriptor dateTimeDescriptor1 = this.DateTimeDescriptor;
              nullable = dateTimeRange.From;
              DateTime dateTime1 = nullable.Value;
              object obj1 = dateTimeDescriptor1.SerializeSimple(dateTime1);
              serializableDictionary2.Add(key1, obj1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 3;
              continue;
            case 3:
            case 9:
              nullable = dateTimeRange.To;
              num2 = 8;
              continue;
            case 4:
              SerializableDictionary<string, object> serializableDictionary3 = serializableDictionary1;
              string key2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306602230);
              DateTimeDescriptor dateTimeDescriptor2 = this.DateTimeDescriptor;
              nullable = dateTimeRange.To;
              DateTime dateTime2 = nullable.Value;
              object obj2 = dateTimeDescriptor2.SerializeSimple(dateTime2);
              serializableDictionary3.Add(key2, obj2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
              continue;
            case 5:
              if (!nullable.HasValue)
              {
                num2 = 9;
                continue;
              }
              goto case 2;
            case 6:
              goto label_3;
            case 7:
              goto label_11;
            case 8:
              goto label_15;
            case 10:
              serializableDictionary1 = new SerializableDictionary<string, object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              continue;
            default:
              nullable = dateTimeRange.From;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 5;
              continue;
          }
        }
label_3:
        object obj3;
        dateTimeRange = (DateTimeRange) obj3;
        num1 = 10;
        continue;
label_11:
        if ((obj3 = value) is DateTimeRange)
        {
          num1 = 6;
          continue;
        }
        goto label_6;
label_15:
        if (nullable.HasValue)
          num1 = 4;
        else
          break;
      }
label_5:
      return (object) serializableDictionary1;
label_6:
      return DateTimeRangeDescriptor.sfVy3RoJgEP58RDujXXJ((object) this, value, valueType, (object) settings);
    }

    /// <inheritdoc />
    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 6;
      DateTimeRange dateTimeRange;
      while (true)
      {
        int num2 = num1;
        IDictionary<string, object> dictionary;
        object obj1;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_18;
            case 2:
              goto label_5;
            case 3:
              dateTimeRange.From = obj1 == null ? new DateTime?() : new DateTime?(this.DateTimeDescriptor.DeserializeSimple(obj1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 4;
              continue;
            case 4:
              if (!dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398549746), out obj2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              }
              goto label_18;
            case 5:
              if (DateTimeRangeDescriptor.nlJD4boJjqiFO5aTg4sp(TypeOf<DateTimeRange>.Raw, deserializeToType))
              {
                num2 = 10;
                continue;
              }
              goto label_15;
            case 6:
              DateTimeRangeDescriptor.pOyh0ooJ5jBDBeka5axU((object) deserializeToType, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470458586));
              num2 = 5;
              continue;
            case 8:
              goto label_16;
            case 9:
              if (dictionary != null)
              {
                if (dictionary.TryGetValue((string) DateTimeRangeDescriptor.IcVlbAoJ0aCB6DmgdLJS(-680446928 - -370807692 ^ -309773318), out obj1))
                {
                  num2 = 3;
                  continue;
                }
                goto case 4;
              }
              else
              {
                num2 = 2;
                continue;
              }
            case 10:
              dateTimeRange = new DateTimeRange();
              num2 = 8;
              continue;
            default:
              goto label_14;
          }
        }
label_16:
        dictionary = value as IDictionary<string, object>;
        num1 = 9;
        continue;
label_18:
        dateTimeRange.To = obj2 == null ? new DateTime?() : new DateTime?(this.DateTimeDescriptor.DeserializeSimple(obj2));
        num1 = 7;
      }
label_5:
      return (object) dateTimeRange;
label_14:
      return (object) dateTimeRange;
label_15:
      return DateTimeRangeDescriptor.C8CcOWoJYHDOY3euCxBk((object) this, value, deserializeToType);
    }

    public static ICriterion GetCriterion(
      DateTimeRange dateTimeRange,
      bool showTime,
      string alias,
      string propName)
    {
      int num = 15;
      SimpleExpression simpleExpression;
      SimpleExpression criterion1;
      SimpleExpression criterion2;
      while (true)
      {
        DateTime? nullable;
        bool less;
        string propertyName;
        object obj1;
        object obj2;
        object obj3;
        switch (num)
        {
          case 1:
            obj1 = (object) null;
            goto label_28;
          case 2:
            obj2 = DateTimeRangeDescriptor.c0MLJjoJUJlWNR4hylmy((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765834968), (object) alias, (object) propName);
            break;
          case 3:
            obj3 = DateTimeRangeDescriptor.ssAF0ioJc8M8wC0AtAt5((object) propertyName, (object) dateTimeRange.To);
            goto label_30;
          case 4:
            if (nullable.HasValue)
            {
              num = 17;
              continue;
            }
            goto case 6;
          case 5:
            goto label_31;
          case 6:
            obj3 = (object) null;
            goto label_30;
          case 7:
            obj3 = (object) Restrictions.Le(propertyName, (object) dateTimeRange.To);
            goto label_30;
          case 8:
            nullable = dateTimeRange.To;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 4;
            continue;
          case 9:
          case 12:
            criterion2 = simpleExpression;
            if (criterion2 == null)
            {
              num = 5;
              continue;
            }
            goto label_24;
          case 10:
            if (!nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            }
            obj1 = DateTimeRangeDescriptor.stN7jnoJslB50v7Mi211((object) propertyName, (object) dateTimeRange.From);
            goto label_28;
          case 11:
            if (criterion1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 9 : 2;
              continue;
            }
            goto label_13;
          case 13:
            nullable = dateTimeRange.From;
            num = 10;
            continue;
          case 14:
            if (DateTimeRangeDescriptor.NhidQHoJLJGeD0H9JJnI((object) alias))
            {
              num = 16;
              continue;
            }
            goto case 2;
          case 15:
            dateTimeRange = DateTimeRangeDescriptor.NormalizeDates(dateTimeRange, showTime, out less);
            num = 14;
            continue;
          case 16:
            obj2 = (object) propName;
            break;
          case 17:
            if (less)
            {
              num = 3;
              continue;
            }
            goto case 7;
          case 18:
            if (simpleExpression == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 12 : 11;
              continue;
            }
            goto case 11;
          default:
            goto label_13;
        }
        propertyName = (string) obj2;
        num = 13;
        continue;
label_28:
        simpleExpression = (SimpleExpression) obj1;
        num = 8;
        continue;
label_30:
        criterion1 = (SimpleExpression) obj3;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 18 : 0;
      }
label_13:
      return (ICriterion) DateTimeRangeDescriptor.x8JTfOoJzS1pkBnXRcFs((object) simpleExpression, (object) criterion1);
label_24:
      return (ICriterion) criterion2;
label_31:
      return (ICriterion) criterion1;
    }

    /// <summary>
    /// Приводит время даты к стандартному виду (00:00:10 к 00:00:00, 23:59:50 к 00:00:00)
    /// </summary>
    /// <returns></returns>
    public static DateTimeRange NormalizeDates(
      DateTimeRange dateTimeRange,
      bool showTime,
      out bool less)
    {
      int num = 13;
      while (true)
      {
        DateTime? nullable1;
        DateTime date;
        switch (num)
        {
          case 1:
            if (!nullable1.HasValue)
            {
              num = 16;
              continue;
            }
            goto case 10;
          case 2:
          case 17:
            ref DateTimeRange local1 = ref dateTimeRange;
            nullable1 = dateTimeRange.To;
            date = nullable1.Value.Date;
            DateTime? nullable2 = new DateTime?(date.AddDays(1.0));
            local1.To = nullable2;
            num = 20;
            continue;
          case 3:
          case 7:
            ref DateTimeRange local2 = ref dateTimeRange;
            nullable1 = dateTimeRange.From;
            date = nullable1.Value;
            DateTime? nullable3 = new DateTime?(date.Date);
            local2.From = nullable3;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 4:
            if (nullable1.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 7 : 14;
              continue;
            }
            goto label_13;
          case 5:
            date = nullable1.Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 8 : 5;
            continue;
          case 6:
            nullable1 = dateTimeRange.To;
            num = 9;
            continue;
          case 8:
            if (DateTimeRangeDescriptor.YiJ8Jlo9BOb0xWCsf7g7(date.TimeOfDay, TimeSpan.Zero))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 1;
              continue;
            }
            goto case 6;
          case 9:
            if (!DateTimeRangeDescriptor.IWoWRYo9W9ZXPac5XUTB(nullable1.Value))
            {
              num = 17;
              continue;
            }
            goto label_13;
          case 10:
            if (!showTime)
            {
              num = 7;
              continue;
            }
            goto case 19;
          case 11:
            if (!DateTimeRangeDescriptor.l37LI2o9Fsxi0rG34fSH(nullable1.Value))
            {
              num = 3;
              continue;
            }
            break;
          case 12:
            nullable1 = dateTimeRange.From;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
            continue;
          case 13:
            less = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 8 : 12;
            continue;
          case 14:
            if (showTime)
            {
              num = 15;
              continue;
            }
            goto case 2;
          case 15:
            nullable1 = dateTimeRange.To;
            num = 5;
            continue;
          case 18:
            goto label_13;
          case 19:
            nullable1 = dateTimeRange.From;
            num = 11;
            continue;
          case 20:
            less = true;
            num = 18;
            continue;
        }
        nullable1 = dateTimeRange.To;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 4;
      }
label_13:
      return DateTimeRangeDescriptor.GetRangeForCriteria(dateTimeRange.From, dateTimeRange.To);
    }

    public static DateTimeRange GetRangeForCriteria(DateTime? dateTimeFrom, DateTime? dateTimeTo)
    {
      DateTimeRange rangeForCriteria;
      ref DateTimeRange local = ref rangeForCriteria;
      DateTime? nullable = dateTimeFrom;
      DateTime minValue = DateTime.MinValue;
      DateTime? from1;
      if ((nullable.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() == minValue ? 1 : 0) : 1) : 0) == 0)
      {
        from1 = dateTimeFrom;
      }
      else
      {
        nullable = new DateTime?();
        from1 = nullable;
      }
      nullable = dateTimeTo;
      DateTime maxValue = DateTime.MaxValue;
      DateTime? to1;
      if ((nullable.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() == maxValue ? 1 : 0) : 1) : 0) == 0)
      {
        to1 = dateTimeTo;
      }
      else
      {
        nullable = new DateTime?();
        to1 = nullable;
      }
      local = new DateTimeRange(from1, to1);
      ITransformationProvider service = Locator.GetService<ITransformationProvider>();
      if (service != null)
      {
        nullable = rangeForCriteria.From;
        DateTime minDateTime = service.Dialect.MinDateTime;
        DateTime? from2 = (nullable.HasValue ? (nullable.GetValueOrDefault() < minDateTime ? 1 : 0) : 0) != 0 ? new DateTime?(service.Dialect.MinDateTime) : rangeForCriteria.From;
        nullable = rangeForCriteria.To;
        DateTime maxDateTime = service.Dialect.MaxDateTime;
        DateTime? to2 = (nullable.HasValue ? (nullable.GetValueOrDefault() > maxDateTime ? 1 : 0) : 0) != 0 ? new DateTime?(service.Dialect.MaxDateTime) : rangeForCriteria.To;
        rangeForCriteria = new DateTimeRange(from2, to2);
      }
      return rangeForCriteria;
    }

    public DateTimeRangeDescriptor()
    {
      DateTimeRangeDescriptor.HISL7To9o7OtcidkmtJl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DateTimeRangeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DateTimeRangeDescriptor.HISL7To9o7OtcidkmtJl();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DateTimeRangeDescriptor.UID = new Guid((string) DateTimeRangeDescriptor.IcVlbAoJ0aCB6DmgdLJS(-1598106783 - -968262081 ^ -629682236));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool lWiVwxoJ7wH78fbCAQJS() => DateTimeRangeDescriptor.WJPZW8oJAFrWrHg3scXb == null;

    internal static DateTimeRangeDescriptor t6jSBaoJxEYHvJcRiaIf() => DateTimeRangeDescriptor.WJPZW8oJAFrWrHg3scXb;

    internal static object IcVlbAoJ0aCB6DmgdLJS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object p4db5AoJmNrv5nbuixst([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool stZk3HoJyHmKgh6TeUvJ([In] DateTime obj0, [In] DateTime obj1) => obj0 == obj1;

    internal static void UOAiZaoJMKDxNuPFrdhN(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4,
      [In] object obj5)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((RangeTypeDescriptor<DateTimeRange, DateTimeSettings>) obj0).ApplyFilterValue((ICriteria) obj1, (EntityMetadata) obj2, (EntityPropertyMetadata) obj3, obj4, (string) obj5));
    }

    internal static object aHRJYXoJJXNC5qZnbuEb([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool HRwV0OoJ9AgwUhhgiKNx([In] object obj0) => ((DateTimeSettings) obj0).ShowTime;

    internal static object vq2uDdoJdnr08EAOOdNm([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object MqtCbtoJlqLDARde05RC(
      DateTimeRange dateTimeRange,
      bool showTime,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) DateTimeRangeDescriptor.GetCriterion(dateTimeRange, showTime, (string) obj2, (string) obj3);
    }

    internal static object WCcnSZoJrnTL5dvhAxxL([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object sfVy3RoJgEP58RDujXXJ([In] object obj0, [In] object obj1, [In] Type obj2, [In] object obj3) => __nonvirtual (((RangeTypeDescriptor<DateTimeRange, DateTime, DateTimeSettings>) obj0).SerializeSimple(obj1, obj2, (EntitySerializationSettings) obj3));

    internal static void pOyh0ooJ5jBDBeka5axU([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool nlJD4boJjqiFO5aTg4sp([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object C8CcOWoJYHDOY3euCxBk([In] object obj0, [In] object obj1, [In] Type obj2) => __nonvirtual (((RangeTypeDescriptor<DateTimeRange, DateTime, DateTimeSettings>) obj0).DeserializeSimple(obj1, obj2));

    internal static bool NhidQHoJLJGeD0H9JJnI([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object c0MLJjoJUJlWNR4hylmy([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object stN7jnoJslB50v7Mi211([In] object obj0, [In] object obj1) => (object) Restrictions.Ge((string) obj0, obj1);

    internal static object ssAF0ioJc8M8wC0AtAt5([In] object obj0, [In] object obj1) => (object) Restrictions.Lt((string) obj0, obj1);

    internal static object x8JTfOoJzS1pkBnXRcFs([In] object obj0, [In] object obj1) => (object) Restrictions.And((ICriterion) obj0, (ICriterion) obj1);

    internal static bool l37LI2o9Fsxi0rG34fSH(DateTime dateTime) => dateTime.IsStartDamperTime();

    internal static bool YiJ8Jlo9BOb0xWCsf7g7([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 == obj1;

    internal static bool IWoWRYo9W9ZXPac5XUTB(DateTime dateTime) => dateTime.IsEndDamperTime();

    internal static void HISL7To9o7OtcidkmtJl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
