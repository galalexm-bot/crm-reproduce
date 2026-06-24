// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.DateTimeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Дата / время"</summary>
  [Component(Order = 600)]
  public class DateTimeDescriptor : 
    CLRTypeDescriptor<DateTime, DateTimeSettings>,
    IMappingTypeDescriptor
  {
    /// <summary>
    /// Ключ к смещению часового пояса текущего пользователя относительно UTC в минутах
    /// </summary>
    public const string ClientTimeZoneOffsetKey = "ClientTimeZoneOffsetKey";
    /// <summary>Uid типа</summary>
    public const string UID_S = "{DAC9211E-E02B-47CD-8868-89A3BFC0F749}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private static readonly TimeSpan afterDayStart;
    private static readonly TimeSpan beforDayEnd;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static DateTimeDescriptor vJakCkox4C9PYsRLjl8a;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        DateTimeSettings dateTimeSettings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (dateTimeSettings == null)
              {
                num2 = 2;
                continue;
              }
              goto case 6;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            case 4:
              goto label_5;
            case 5:
              if (!DateTimeDescriptor.RKkCkMoxxYHx5GPTUZmJ((object) dateTimeSettings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 6:
              if (DateTimeDescriptor.X6vmIUox7Owt3fTy4flO((object) dateTimeSettings))
              {
                num2 = 9;
                continue;
              }
              goto case 5;
            case 7:
              dateTimeSettings = (DateTimeSettings) DateTimeDescriptor.lAdMqKoxAhEQAyDtJ7RN((object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
              continue;
            case 8:
              base.ExtendSimplePropertyMapping(mapper, propertyMetadata);
              num2 = 7;
              continue;
            default:
              mapper.Type<DateTimeWithoutOffsetNHType>();
              num2 = 3;
              continue;
          }
        }
label_6:
        mapper.Type<DateTimeNHType>();
        num1 = 4;
      }
label_7:
      return;
label_5:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => DateTimeDescriptor.UID;

    /// <summary>Имя "Дата / время"</summary>
    public override string Name => (string) DateTimeDescriptor.ub4W5hox03iD4EKd4I3A((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811863318));

    /// <inheritdoc />
    public override IDictionary<string, object> Serialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418454964));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998520728));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object clientDateTime = property.GetValue(obj, (object[]) null);
      int offset;
      if (ContextVars.TryGetValue<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669472043), out offset) && propertyMetadata.Settings is DateTimeSettings settings2 && !settings2.WithoutOffset && settings2.ShowTime && clientDateTime is DateTime runtimeDateTime)
      {
        TZSettings tz = settings2.TZ;
        TZSettings settings1 = new TZSettings((object) tz != null ? tz.Type : TZSettings.TZType.Custom, offset);
        clientDateTime = (object) runtimeDateTime.ToClientDateTime(settings1);
      }
      object obj1 = this.SerializeSimple(clientDateTime, property.PropertyType, settings);
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      serializableDictionary.Add(propertyMetadata.Name, obj1);
      return (IDictionary<string, object>) serializableDictionary;
    }

    /// <inheritdoc />
    public override void Deserialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583759414));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021391399));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanWrite)
        return;
      object obj1;
      if (!values.TryGetValue(propertyMetadata.Name, out obj1))
        return;
      try
      {
        object obj2 = this.DeserializeSimple(obj1, property.PropertyType);
        int offset;
        if (ContextVars.TryGetValue<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765951510), out offset) && propertyMetadata.Settings is DateTimeSettings settings1 && !settings1.WithoutOffset && settings1.ShowTime && obj2 is DateTime clientDateTime)
        {
          TZSettings tz = settings1.TZ;
          TZSettings settings = new TZSettings((object) tz != null ? tz.Type : TZSettings.TZType.Custom, offset);
          obj2 = (object) clientDateTime.ToRuntimeDateTimeFromClient(settings);
        }
        property.SetValue(obj, obj2, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, (object[]) null, (CultureInfo) null);
      }
      catch (Exception ex)
      {
        this.Logger.Debug((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606749714), (object) this.Name, (object) this.GetType(), (object) propertyMetadata.Name, (object) metadata.FullTypeName), ex);
      }
    }

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
    {
      int num = 7;
      while (true)
      {
        DateTimeSettings dateTimeSettings1;
        DateTimeSettings dateTimeSettings2;
        switch (num)
        {
          case 1:
            if (dateTimeSettings1 == null)
            {
              num = 3;
              continue;
            }
            goto case 2;
          case 2:
            if (!DateTimeDescriptor.GIeBiqoxmFycuAI6uxvg((object) dateTimeSettings1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 3:
            goto label_11;
          case 4:
            dateTimeSettings2 = (DateTimeSettings) null;
            break;
          case 5:
            goto label_9;
          case 6:
            dateTimeSettings2 = (DateTimeSettings) DateTimeDescriptor.lAdMqKoxAhEQAyDtJ7RN((object) propertyMetadata);
            break;
          case 7:
            if (propertyMetadata != null)
            {
              num = 6;
              continue;
            }
            goto case 4;
          default:
            if (!dateTimeSettings1.RangeInFilter)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 5 : 5;
              continue;
            }
            goto label_10;
        }
        dateTimeSettings1 = dateTimeSettings2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
      }
label_9:
      return DateTimeDescriptor.UID;
label_10:
      return DateTimeRangeDescriptor.UID;
label_11:
      return RelativeDateTimeDescriptor.UID;
    }

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 1;
      DateTime? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            nullable = (DateTime?) val;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            if (!nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return nullable.Value == DateTime.MinValue;
label_3:
      return true;
    }

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num = 11;
      DateTime? defaultValue;
      DateTimeSettings dateTimeSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_15;
          case 2:
            if (!DateTimeDescriptor.KGpdsfoxM2S1esZfEnLQ((object) propertyMetadata))
            {
              dateTimeSettings = (DateTimeSettings) DateTimeDescriptor.lAdMqKoxAhEQAyDtJ7RN((object) propertyMetadata);
              num = 4;
              continue;
            }
            num = 5;
            continue;
          case 3:
            defaultValue = dateTimeSettings.DefaultValue;
            num = 6;
            continue;
          case 4:
            if (dateTimeSettings != null)
            {
              defaultValue = dateTimeSettings.DefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 9;
            continue;
          case 5:
            goto label_9;
          case 6:
            goto label_4;
          case 7:
            goto label_5;
          case 8:
            goto label_20;
          case 9:
            goto label_11;
          case 10:
            if (DateTimeDescriptor.WICHSAoxy5rrrESD7xbY((object) this, (object) propertyMetadata, val))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
              continue;
            }
            if (propertyMetadata != null)
            {
              num = 2;
              continue;
            }
            goto label_20;
          case 11:
            if (val != null)
            {
              num = 10;
              continue;
            }
            goto label_15;
          default:
            if (!defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 7 : 0;
              continue;
            }
            goto case 3;
        }
      }
label_4:
      return defaultValue.Equals(val);
label_5:
      return false;
label_9:
      return false;
label_11:
      return true;
label_15:
      return true;
label_20:
      return true;
    }

    /// <summary>
    /// Получить выражение инициализации свойства - в соответствии со значением по умолчанию, либо с флагом "Текущая дата"
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public override ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num = 9;
      DateTime? defaultValue;
      DateTimeSettings dateTimeSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (defaultValue.HasValue)
            {
              num = 6;
              continue;
            }
            goto label_7;
          case 2:
            if (dateTimeSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 3 : 2;
              continue;
            }
            goto case 5;
          case 3:
            goto label_7;
          case 4:
            goto label_15;
          case 5:
            if (!DateTimeDescriptor.CKR61woxd75ev4A5rSiK((object) dateTimeSettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            }
            goto label_15;
          case 6:
            goto label_6;
          case 7:
            goto label_8;
          case 8:
            if (!forFilter)
            {
              dateTimeSettings = (DateTimeSettings) DateTimeDescriptor.lAdMqKoxAhEQAyDtJ7RN((object) propertyMetadata);
              num = 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 7 : 5;
            continue;
          case 9:
            DateTimeDescriptor.RpiVOkox9Aqi78kkwGhn((object) propertyMetadata, DateTimeDescriptor.glVmmjoxJFuqb37mkUY1(-2107978722 ^ -2107996852));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 8 : 2;
            continue;
          default:
            defaultValue = dateTimeSettings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
        }
      }
label_6:
      return typeof (DateTime).CreateTypeSyntax().ObjectCreationExpression((ISyntaxNode) DateTimeDescriptor.Xaf7bdoxg5iMH0U0ZM6H((object) dateTimeSettings.DefaultValue.Value.Ticks));
label_7:
      return (ISyntaxNode) null;
label_8:
      return (ISyntaxNode) null;
label_15:
      return (ISyntaxNode) DateTimeDescriptor.wZ6sySoxrBwswImuJLoG(DateTimeDescriptor.foeCMroxlYI3XKq1QkL6(typeof (DateTime)), DateTimeDescriptor.RKkCkMoxxYHx5GPTUZmJ((object) dateTimeSettings) ? DateTimeDescriptor.glVmmjoxJFuqb37mkUY1(-441065788 ^ -2092910478 ^ 1727524222) : DateTimeDescriptor.glVmmjoxJFuqb37mkUY1(-1867198571 ^ -1867103185));
    }

    /// <summary>
    /// Получить контейнер свойства сущности с данными по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Контейнер</returns>
    public override IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num1 = 15;
      DateTime dateTime1;
      DateTime? nullable1;
      DateTime? nullable2;
      while (true)
      {
        int num2 = num1;
        DateTimeSettings dateTimeSettings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              dateTimeSettings = (DateTimeSettings) DateTimeDescriptor.lAdMqKoxAhEQAyDtJ7RN((object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_33;
            case 3:
            case 19:
              nullable2 = nullable1;
              num2 = 2;
              continue;
            case 4:
              if (DateTimeDescriptor.CKR61woxd75ev4A5rSiK((object) dateTimeSettings))
              {
                num2 = 9;
                continue;
              }
              nullable1 = dateTimeSettings.DefaultValue;
              num2 = 18;
              continue;
            case 5:
              goto label_30;
            case 6:
              if (DateTimeDescriptor.KGpdsfoxM2S1esZfEnLQ((object) propertyMetadata))
                goto case 11;
              else
                goto label_12;
            case 7:
              if (!forFilter)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
                continue;
              }
              goto case 18;
            case 8:
              goto label_19;
            case 9:
              if (propertyMetadata != null)
              {
                num2 = 6;
                continue;
              }
              goto case 17;
            case 10:
              goto label_25;
            case 11:
              if (!DateTimeDescriptor.RKkCkMoxxYHx5GPTUZmJ((object) dateTimeSettings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 10 : 10;
                continue;
              }
              goto label_26;
            case 12:
              goto label_16;
            case 13:
              if (!DateTimeDescriptor.KGpdsfoxM2S1esZfEnLQ((object) propertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 7 : 19;
                continue;
              }
              goto label_19;
            case 14:
              nullable1 = new DateTime?();
              num2 = 7;
              continue;
            case 15:
              Contract.ArgumentNotNull((object) propertyMetadata, (string) DateTimeDescriptor.glVmmjoxJFuqb37mkUY1(-398663332 ^ -398678002));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 14 : 0;
              continue;
            case 16:
              dateTime1 = new DateTime();
              num2 = 12;
              continue;
            case 17:
              if (!dateTimeSettings.ShowTime)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 5;
                continue;
              }
              goto label_31;
            case 18:
              if (propertyMetadata != null)
                goto case 13;
              else
                goto label_22;
            default:
              if (dateTimeSettings != null)
              {
                num2 = 4;
                continue;
              }
              goto case 18;
          }
        }
label_12:
        num1 = 17;
        continue;
label_22:
        num1 = 3;
        continue;
label_33:
        if (!nullable2.HasValue)
          num1 = 16;
        else
          goto label_35;
      }
label_16:
      DateTime dateTime2 = dateTime1;
      goto label_36;
label_19:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<DateTime?>(nullable1);
label_25:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<DateTime?>(new Func<DateTime?>(DateTimeDescriptor.NullableDefaultCurrentDate));
label_26:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<DateTime?>(new Func<DateTime?>(DateTimeDescriptor.NullableDefaultCurrentTime));
label_30:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<DateTime>(new Func<DateTime>(DateTimeDescriptor.DefaultCurrentDate));
label_31:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<DateTime>(new Func<DateTime>(DateTimeDescriptor.DefaultCurrentTime));
label_35:
      dateTime2 = nullable2.GetValueOrDefault();
label_36:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<DateTime>(dateTime2);
    }

    /// <summary>Форматировать значение</summary>
    /// <param name="value">Значение</param>
    /// <param name="settings">Настройки свойства</param>
    /// <returns>Сформатированное значение</returns>
    public override string FormatValue(object value, TypeSettings settings)
    {
      int num1 = 5;
      DateTime dateTime;
      while (true)
      {
        int num2 = num1;
        DateTime? nullable;
        while (true)
        {
          bool flag1;
          bool flag2;
          DateTimeSettings dateTimeSettings;
          int num3;
          int num4;
          switch (num2)
          {
            case 1:
              num4 = 1;
              goto label_37;
            case 2:
              if (dateTimeSettings != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 8 : 6;
                continue;
              }
              goto default;
            case 3:
              num4 = 0;
              goto label_37;
            case 4:
              dateTimeSettings = settings as DateTimeSettings;
              num2 = 14;
              continue;
            case 5:
              nullable = value as DateTime?;
              num2 = 4;
              continue;
            case 6:
              goto label_13;
            case 7:
              dateTime = nullable.Value;
              num2 = 18;
              continue;
            case 8:
              num3 = DateTimeDescriptor.xJxhDEox5G5ixobmnG5D((object) dateTimeSettings) ? 1 : 0;
              break;
            case 9:
              dateTime = nullable.Value;
              num2 = 16;
              continue;
            case 10:
              if (flag1)
              {
                num2 = 9;
                continue;
              }
              goto label_27;
            case 11:
              goto label_23;
            case 12:
              dateTime = nullable.Value;
              num2 = 19;
              continue;
            case 13:
              if (!(flag2 & flag1))
              {
                if (!flag2)
                {
                  num2 = 10;
                  continue;
                }
                goto case 7;
              }
              else
              {
                num2 = 6;
                continue;
              }
            case 14:
              if (nullable.HasValue)
              {
                num2 = 2;
                continue;
              }
              goto label_23;
            case 15:
              dateTime = nullable.Value;
              num2 = 20;
              continue;
            case 16:
              goto label_26;
            case 17:
              if (dateTimeSettings != null)
              {
                num2 = 21;
                continue;
              }
              goto case 1;
            case 18:
              goto label_4;
            case 19:
              if (!DateTimeDescriptor.JnM9E0oxj1kNWv17IP4i(dateTime.TimeOfDay, DateTimeDescriptor.afterDayStart))
              {
                num2 = 3;
                continue;
              }
              goto case 15;
            case 20:
              num4 = DateTimeDescriptor.JnM9E0oxj1kNWv17IP4i(dateTime.TimeOfDay, DateTimeDescriptor.beforDayEnd) ? 1 : 0;
              goto label_37;
            case 21:
              if (DateTimeDescriptor.RKkCkMoxxYHx5GPTUZmJ((object) dateTimeSettings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 12 : 2;
                continue;
              }
              goto case 3;
            case 22:
              goto label_9;
            default:
              num3 = 1;
              break;
          }
          flag2 = num3 != 0;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 17;
          continue;
label_37:
          flag1 = num4 != 0;
          num2 = 13;
        }
label_13:
        dateTime = nullable.Value;
        num1 = 22;
      }
label_4:
      return dateTime.ToShortDateString();
label_9:
      return dateTime.ToString((string) DateTimeDescriptor.glVmmjoxJFuqb37mkUY1(-1710575414 ^ -1710602422));
label_23:
      return base.FormatValue(value, settings);
label_26:
      return dateTime.ToShortTimeString();
label_27:
      return string.Empty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    public override IComparer GetComparer(
      Type sourceType,
      LambdaExpression propertyFunc,
      ListSortDirection order)
    {
      return (IComparer) DateTimeDescriptor.iFivbYoxYrPi8OPJspEM(sourceType, (object) propertyFunc, order);
    }

    public override bool IsSupportSort() => true;

    public override bool IsAvailibleEditPropertyInTable => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.DateTime);
    }

    private static DateTime DefaultCurrentDate() => DateTime.Today;

    private static DateTime DefaultCurrentTime() => DateTimeDescriptor.CtJmG0oxLJgbUhNUxNS7();

    private static DateTime? NullableDefaultCurrentDate() => new DateTime?(DateTime.Today);

    private static DateTime? NullableDefaultCurrentTime() => new DateTime?(DateTime.Now);

    public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 2;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new DateTimePropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 2:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public DateTimeDescriptor()
    {
      DateTimeDescriptor.fMf5UcoxUtB5rIs6Z84x();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DateTimeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DateTimeDescriptor.fMf5UcoxUtB5rIs6Z84x();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            DateTimeDescriptor.afterDayStart = new TimeSpan(0, 0, 10);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            DateTimeDescriptor.beforDayEnd = new TimeSpan(23, 59, 50);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 3;
            continue;
          default:
            DateTimeDescriptor.UID = new Guid((string) DateTimeDescriptor.glVmmjoxJFuqb37mkUY1(-342626196 - 1290888215 ^ -1633679481));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object lAdMqKoxAhEQAyDtJ7RN([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool X6vmIUox7Owt3fTy4flO([In] object obj0) => ((DateTimeSettings) obj0).WithoutOffset;

    internal static bool RKkCkMoxxYHx5GPTUZmJ([In] object obj0) => ((DateTimeSettings) obj0).ShowTime;

    internal static bool AeEWIhox6UNlwS55nbgw() => DateTimeDescriptor.vJakCkox4C9PYsRLjl8a == null;

    internal static DateTimeDescriptor xWVDmtoxHYtJmDo9lKui() => DateTimeDescriptor.vJakCkox4C9PYsRLjl8a;

    internal static object ub4W5hox03iD4EKd4I3A([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool GIeBiqoxmFycuAI6uxvg([In] object obj0) => ((DateTimeSettings) obj0).RelativeInFilter;

    internal static bool WICHSAoxy5rrrESD7xbY([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static bool KGpdsfoxM2S1esZfEnLQ([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static object glVmmjoxJFuqb37mkUY1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void RpiVOkox9Aqi78kkwGhn([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool CKR61woxd75ev4A5rSiK([In] object obj0) => ((DateTimeSettings) obj0).SetCurrentDate;

    internal static object foeCMroxlYI3XKq1QkL6(Type type) => (object) type.CreateTypeSyntax();

    internal static object wZ6sySoxrBwswImuJLoG([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).MemberAccessExpression((string) obj1);

    internal static object Xaf7bdoxg5iMH0U0ZM6H([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static bool xJxhDEox5G5ixobmnG5D([In] object obj0) => ((DateTimeSettings) obj0).ShowDate;

    internal static bool JnM9E0oxj1kNWv17IP4i([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 != obj1;

    internal static object iFivbYoxYrPi8OPJspEM(
      Type sourceType,
      [In] object obj1,
      ListSortDirection order)
    {
      return (object) ComparerHelper.Create(sourceType, (LambdaExpression) obj1, order);
    }

    internal static DateTime CtJmG0oxLJgbUhNUxNS7() => DateTime.Now;

    internal static void fMf5UcoxUtB5rIs6Z84x() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
