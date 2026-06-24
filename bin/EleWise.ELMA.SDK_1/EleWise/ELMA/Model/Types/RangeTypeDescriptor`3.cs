// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.RangeTypeDescriptor`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Базовый класс описания диапазонного типа, реализующего интерфейс IRange
  /// </summary>
  /// <typeparam name="T">Тип CLR</typeparam>
  /// <typeparam name="TSettings">Тип настроек</typeparam>
  /// <typeparam name="TRangeProperty">Тип свойства диапазона</typeparam>
  public abstract class RangeTypeDescriptor<T, TRangeProperty, TSettings> : 
    RangeTypeDescriptor<T, TSettings>
    where T : IRange<TRangeProperty>
    where TRangeProperty : struct
  {
    private static object y800nuo6SemAh1ZqQSsH;

    /// <inheritdoc />
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 11;
      SerializableDictionary<string, object> serializableDictionary;
      while (true)
      {
        int num2 = num1;
        object toValue;
        Type raw;
        object fromValue;
        while (true)
        {
          switch (num2)
          {
            case 1:
              serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333612096), base.SerializeSimple(toValue, raw, (EntitySerializationSettings) null));
              num2 = 8;
              continue;
            case 2:
            case 5:
              if (toValue != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
                continue;
              }
              goto label_15;
            case 3:
              if (fromValue == null)
              {
                num2 = 2;
                continue;
              }
              goto label_12;
            case 4:
              serializableDictionary = new SerializableDictionary<string, object>();
              num2 = 9;
              continue;
            case 6:
              goto label_5;
            case 7:
              goto label_12;
            case 8:
              goto label_15;
            case 9:
              raw = TypeOf<TRangeProperty>.Raw;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 1;
              continue;
            case 11:
              if (value is T obj)
              {
                num2 = 10;
                continue;
              }
              goto label_16;
            default:
              fromValue = this.GetFromValue(obj);
              num2 = 6;
              continue;
          }
        }
label_5:
        toValue = this.GetToValue(obj);
        num1 = 3;
        continue;
label_12:
        serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195734189), base.SerializeSimple(fromValue, raw, (EntitySerializationSettings) null));
        num1 = 5;
      }
label_15:
      return (object) serializableDictionary;
label_16:
      return base.SerializeSimple(value, valueType, settings);
    }

    /// <inheritdoc />
    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 13;
      T instance;
      while (true)
      {
        int num2 = num1;
        Type raw;
        while (true)
        {
          object obj1;
          IDictionary<string, object> dictionary;
          object obj2;
          switch (num2)
          {
            case 1:
              if (dictionary != null)
              {
                num2 = 10;
                continue;
              }
              goto label_6;
            case 2:
            case 4:
              goto label_15;
            case 3:
            case 6:
              if (!dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426195605), out obj2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 2;
                continue;
              }
              goto case 11;
            case 5:
              goto label_16;
            case 7:
              goto label_6;
            case 8:
              instance.From = (TRangeProperty?) base.DeserializeSimple(obj1, raw);
              num2 = 3;
              continue;
            case 9:
              dictionary = value as IDictionary<string, object>;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
              continue;
            case 10:
              goto label_7;
            case 11:
              instance.To = (TRangeProperty?) base.DeserializeSimple(obj2, raw);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
              continue;
            case 12:
              if (!(TypeOf<T>.Raw == deserializeToType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 5;
                continue;
              }
              break;
            case 13:
              Contract.ArgumentNotNull((object) deserializeToType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124624138));
              num2 = 12;
              continue;
            case 14:
              if (!dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643016446), out obj1))
              {
                num2 = 6;
                continue;
              }
              goto case 8;
          }
          instance = Activator.CreateInstance<T>();
          num2 = 9;
        }
label_7:
        raw = TypeOf<TRangeProperty?>.Raw;
        num1 = 14;
      }
label_6:
      return (object) instance;
label_15:
      return (object) instance;
label_16:
      return base.DeserializeSimple(value, deserializeToType);
    }

    /// <inheritdoc />
    protected override object GetFromValue(T value) => (object) value.From;

    /// <inheritdoc />
    protected override object GetToValue(T value) => (object) value.To;

    protected RangeTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ewQCVjo6iYbPknliGU4k() => RangeTypeDescriptor<T, TRangeProperty, TSettings>.y800nuo6SemAh1ZqQSsH == null;

    internal static object xpnRe5o6RAw6ESSNJM0L() => RangeTypeDescriptor<T, TRangeProperty, TSettings>.y800nuo6SemAh1ZqQSsH;
  }
}
