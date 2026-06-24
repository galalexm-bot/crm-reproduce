// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.RelativeDateTimeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Базовый класс описания относительной даты</summary>
  [Component(Order = 700)]
  public class RelativeDateTimeDescriptor : CLRTypeDescriptor<RelativeDateTime, DateTimeSettings>
  {
    public const string UID_S = "{1B104510-6460-441A-B75E-F3B7E9115E72}";
    public static readonly Guid UID;
    private static RelativeDateTimeDescriptor uQGTCHoynxoCx5uE34dS;

    /// <summary>Дескриптор типа "Дата / время (Диапазон)"</summary>
    [XmlIgnore]
    public DateTimeRangeDescriptor DateTimeRangeDescriptor
    {
      get => this.\u003CDateTimeRangeDescriptor\u003Ek__BackingField;
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
              this.\u003CDateTimeRangeDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    /// <summary>Дескриптор для типа "Да / нет"</summary>
    [XmlIgnore]
    public BoolDescriptor BoolDescriptor
    {
      get => this.\u003CBoolDescriptor\u003Ek__BackingField;
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
              this.\u003CBoolDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    /// <summary>Можно ли использовать тип для сущностей</summary>
    public override bool UseForEntity => false;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => RangeTypesDescriptor.UID;

    /// <summary>Uid типа</summary>
    public override Guid Uid => RelativeDateTimeDescriptor.UID;

    /// <summary>Имя "Относительная дата/время"</summary>
    public override string Name => (string) RelativeDateTimeDescriptor.z3uOuooyPB8fs8C7XM4E(RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(1051276242 - 990076387 ^ 61293031));

    /// <summary>Может ли тип быть Nullable</summary>
    public override bool CanBeNullable => false;

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object value)
    {
      int num1 = 3;
      DateTime? nullable;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (value != null)
              {
                nullable = ((RelativeDateTime) value).FromValue;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 6;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              if (propertyMetadata != null)
              {
                if ((DateTimeSettings) RelativeDateTimeDescriptor.sCvAvXoy1BWDNLhrRac8((object) propertyMetadata) != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
                  continue;
                }
                goto label_13;
              }
              else
                goto label_17;
            case 4:
              goto label_11;
            case 5:
              goto label_13;
            case 6:
              if (!nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 7;
                continue;
              }
              goto label_12;
            case 7:
              nullable = ((RelativeDateTime) value).ToValue;
              num2 = 4;
              continue;
            default:
              goto label_7;
          }
        }
label_17:
        num1 = 2;
      }
label_4:
      return true;
label_7:
      return true;
label_11:
      return !nullable.HasValue;
label_12:
      return false;
label_13:
      return true;
    }

    /// <inheritdoc />
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(value is RelativeDateTime relativeDateTime))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      serializableDictionary.Add((string) RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(-1978478350 ^ -1978645310), this.BoolDescriptor.SerializeSimple(relativeDateTime.IsRelative));
      serializableDictionary.Add((string) RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(-1638402543 ^ -1638571431), RelativeDateTimeDescriptor.UQfXvIoyN9D3rwicJQ7p((object) relativeDateTime));
      serializableDictionary.Add((string) RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(1917256330 ^ 1917163246), RelativeDateTimeDescriptor.mgGlRGoy3KRG5I8RMuc2((object) relativeDateTime));
      serializableDictionary.Add((string) RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(236071375 ^ 235978163), this.DateTimeRangeDescriptor.SerializeSimple(relativeDateTime.DateTimeRange));
      return (object) serializableDictionary;
label_5:
      return base.SerializeSimple(value, valueType, settings);
    }

    /// <inheritdoc />
    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 21;
      string from;
      string to;
      DateTimeRange dateTimeRange;
      while (true)
      {
        int num2 = num1;
        IDictionary<string, object> dictionary;
        while (true)
        {
          object obj1;
          object obj2;
          object obj3;
          bool flag;
          object obj4;
          string str1;
          string str2;
          switch (num2)
          {
            case 1:
            case 10:
              goto label_7;
            case 2:
              from = (string) null;
              num2 = 19;
              continue;
            case 3:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 6 : 8;
              continue;
            case 4:
              goto label_24;
            case 5:
            case 22:
              if (!dictionary.TryGetValue((string) RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(-630932142 - 1120244082 ^ -1751269500), out obj1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 10 : 1;
                continue;
              }
              goto case 12;
            case 6:
              str1 = obj1.ToString();
              goto label_38;
            case 7:
              if (obj4 != null)
              {
                num2 = 18;
                continue;
              }
              goto case 13;
            case 8:
              if (!dictionary.TryGetValue((string) RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(1669371371 ^ 1669464539), out obj3))
              {
                num2 = 23;
                continue;
              }
              goto case 15;
            case 9:
              goto label_17;
            case 11:
              goto label_13;
            case 12:
              if (obj1 != null)
              {
                num2 = 6;
                continue;
              }
              goto case 24;
            case 13:
              str2 = (string) null;
              break;
            case 14:
              goto label_15;
            case 15:
              flag = this.BoolDescriptor.DeserializeSimple(obj3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            case 16:
              if (!dictionary.TryGetValue((string) RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(~210725948 ^ -210630773), out obj4))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 22 : 18;
                continue;
              }
              goto case 7;
            case 17:
              dictionary = value as IDictionary<string, object>;
              num2 = 11;
              continue;
            case 18:
              str2 = obj4.ToString();
              break;
            case 19:
              to = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 16 : 1;
              continue;
            case 20:
              // ISSUE: type reference
              if (!RelativeDateTimeDescriptor.CegpdSoya45DgqLEEsvc(__typeref (RelativeDateTime)).IsAssignableFrom(deserializeToType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 9 : 2;
                continue;
              }
              goto case 17;
            case 21:
              RelativeDateTimeDescriptor.KNgigVoypMeBUJGq8rAZ((object) deserializeToType, RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(1470440286 ^ 1470458586));
              num2 = 20;
              continue;
            case 24:
              str1 = (string) null;
              goto label_38;
            case 25:
              dateTimeRange = this.DateTimeRangeDescriptor.DeserializeSimple(obj2);
              num2 = 14;
              continue;
            default:
              if (!flag)
              {
                if (dictionary.TryGetValue((string) RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(-1852837372 ^ -1853004168), out obj2))
                {
                  num2 = 25;
                  continue;
                }
                goto label_16;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 2;
                continue;
              }
          }
          from = str2;
          num2 = 5;
          continue;
label_38:
          to = str1;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
        }
label_13:
        if (dictionary != null)
          num1 = 3;
        else
          goto label_24;
      }
label_7:
      return (object) new RelativeDateTime(from, to);
label_15:
      return (object) new RelativeDateTime(dateTimeRange.From, dateTimeRange.To);
label_16:
      return (object) new RelativeDateTime();
label_17:
      return base.DeserializeSimple(value, deserializeToType);
label_24:
      return (object) null;
    }

    /// <summary>Применить в критерий NHibernate условия</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="value">Значение фильтра</param>
    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        ICriterion criterion;
        RelativeDateTime relativeDateTime;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (criterion != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 4;
                continue;
              }
              goto label_13;
            case 2:
              goto label_3;
            case 3:
              goto label_7;
            case 4:
              RelativeDateTimeDescriptor.SiTfqeoy414Sdc0g0rt3((object) criteria, (object) criterion);
              num2 = 2;
              continue;
            case 5:
              if (relativeDateTime == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              criterion = DateTimeRangeDescriptor.GetCriterion(RelativeDateTimeDescriptor.PKMnxeoyD3tn6DUtUIMi((object) relativeDateTime), RelativeDateTimeDescriptor.OQoeUtoytPEejRQOyJpj((object) (DateTimeSettings) RelativeDateTimeDescriptor.sCvAvXoy1BWDNLhrRac8((object) propertyMetadata)), alias, (string) RelativeDateTimeDescriptor.nXGeUtoywC4pyyl3Z0JO((object) propertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
              continue;
            case 6:
              goto label_8;
            default:
              base.ApplyFilterValue(criteria, metadata, propertyMetadata, value, alias);
              num2 = 3;
              continue;
          }
        }
label_8:
        relativeDateTime = value as RelativeDateTime;
        num1 = 5;
      }
label_3:
      return;
label_7:
      return;
label_13:;
    }

    /// <summary>Возвращает диапазон дат.</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static DateTimeRange GetDateTimeRange(RelativeDateTime value)
    {
      int num = 1;
      DateTimeRange dateTimeRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            }
            dateTimeRange = new DateTimeRange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 1;
            continue;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return dateTimeRange;
label_5:
      return new DateTimeRange(value.FromValue, value.ToValue);
    }

    public static DateTimeRange GetDateTimeRange(string fromValue, string toValue) => RelativeDateTimeDescriptor.PKMnxeoyD3tn6DUtUIMi((object) new RelativeDateTime()
    {
      IsRelative = true,
      RelativeFrom = fromValue,
      RelativeTo = toValue
    });

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      throw new InvalidOperationException((string) RelativeDateTimeDescriptor.z3uOuooyPB8fs8C7XM4E(RelativeDateTimeDescriptor.QQfnjVoyetf7YyqQHvqP(~-122002947 ^ 122152408)));
    }

    public RelativeDateTimeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static RelativeDateTimeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RelativeDateTimeDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138253598));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 2:
            RelativeDateTimeDescriptor.asaSM7oy6Yxh4kZPjxBu();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool QYSZaNoyOdKRYDnKNNY2() => RelativeDateTimeDescriptor.uQGTCHoynxoCx5uE34dS == null;

    internal static RelativeDateTimeDescriptor BdHDP2oy2M0EwDCrwL8u() => RelativeDateTimeDescriptor.uQGTCHoynxoCx5uE34dS;

    internal static object QQfnjVoyetf7YyqQHvqP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object z3uOuooyPB8fs8C7XM4E([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object sCvAvXoy1BWDNLhrRac8([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object UQfXvIoyN9D3rwicJQ7p([In] object obj0) => (object) ((RelativeDateTime) obj0).RelativeFrom;

    internal static object mgGlRGoy3KRG5I8RMuc2([In] object obj0) => (object) ((RelativeDateTime) obj0).RelativeTo;

    internal static void KNgigVoypMeBUJGq8rAZ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type CegpdSoya45DgqLEEsvc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static DateTimeRange PKMnxeoyD3tn6DUtUIMi([In] object obj0) => RelativeDateTimeDescriptor.GetDateTimeRange((RelativeDateTime) obj0);

    internal static bool OQoeUtoytPEejRQOyJpj([In] object obj0) => ((DateTimeSettings) obj0).ShowTime;

    internal static object nXGeUtoywC4pyyl3Z0JO([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object SiTfqeoy414Sdc0g0rt3([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static void asaSM7oy6Yxh4kZPjxBu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
