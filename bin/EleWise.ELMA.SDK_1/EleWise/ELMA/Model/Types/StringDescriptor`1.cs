// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.StringDescriptor`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Абстрактное описание типа "Строка"</summary>
  public abstract class StringDescriptor<TSettings> : 
    CLRTypeDescriptor<string, TSettings>,
    IMappingTypeDescriptor
    where TSettings : StringSettings
  {
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static object UICoF0o7balhZr6VEEjg;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 1;
      StringSettings settings;
      while (true)
      {
        switch (num1)
        {
          case 1:
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514943099));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 2:
            base.ExtendSimplePropertyMapping(mapper, propertyMetadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 6 : 4;
            continue;
          case 3:
            Contract.CheckArgument(propertyMetadata.Settings is StringSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108143258));
            num1 = 4;
            continue;
          case 4:
            settings = (StringSettings) propertyMetadata.Settings;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 2;
            continue;
          case 5:
            goto label_2;
          case 6:
            INHibernatePropertyTypeMapper propertyTypeMapper = mapper;
            int? maxValue = settings.MaxValue;
            int num2 = 0;
            int length = maxValue.GetValueOrDefault() > num2 & maxValue.HasValue ? settings.MaxValue.Value : int.MaxValue;
            propertyTypeMapper.Length(length);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 3;
            continue;
          default:
            Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574387078));
            num1 = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((StringSettings) propertyMetadata.Settings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 2:
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      return true;
label_7:
      return true;
label_8:
      return string.IsNullOrEmpty((string) val);
    }

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num1 = 5;
      StringSettings settings;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              if (settings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
                continue;
              }
              str = (string) val;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 7 : 5;
              continue;
            case 3:
              goto label_16;
            case 4:
              if (!this.IsEmpty(propertyMetadata, val))
              {
                if (propertyMetadata != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                  continue;
                }
                goto label_8;
              }
              else
              {
                num2 = 9;
                continue;
              }
            case 5:
              goto label_6;
            case 6:
              goto label_17;
            case 7:
              if (settings.DefaultValue == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 6 : 6;
                continue;
              }
              goto label_16;
            case 8:
              goto label_8;
            case 9:
              goto label_3;
            default:
              settings = (StringSettings) propertyMetadata.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 0;
              continue;
          }
        }
label_6:
        if (val != null)
          num1 = 4;
        else
          break;
      }
label_3:
      return true;
label_8:
      return true;
label_12:
      return true;
label_16:
      return settings.DefaultValue.Equals(str);
label_17:
      return false;
    }

    /// <summary>
    /// Получить выражение инициализации свойства - в соответствии со значением по умолчанию
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
      int num = 1;
      StringSettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876048387));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 2:
          case 4:
            goto label_2;
          case 3:
            if (string.IsNullOrEmpty(settings.DefaultValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 2;
              continue;
            }
            goto label_3;
          case 5:
            if (settings == null)
            {
              num = 4;
              continue;
            }
            goto case 3;
          default:
            settings = (StringSettings) propertyMetadata.Settings;
            num = 5;
            continue;
        }
      }
label_2:
      return (ISyntaxNode) null;
label_3:
      return settings.DefaultValue.CreateSyntaxNode();
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
      int num = 2;
      StringSettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            settings = (StringSettings) propertyMetadata.Settings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951500620));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
            continue;
          case 3:
          case 4:
            goto label_2;
          case 5:
            if (string.IsNullOrEmpty(settings.DefaultValue))
            {
              num = 3;
              continue;
            }
            goto label_9;
          default:
            if (settings == null)
            {
              num = 4;
              continue;
            }
            goto case 5;
        }
      }
label_2:
      string str = (string) null;
      goto label_10;
label_9:
      str = settings.DefaultValue;
label_10:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<string>(str);
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
      int num1 = 7;
      string str;
      while (true)
      {
        StringSettings settings;
        int? maxValue;
        MatchMode matchMode;
        switch (num1)
        {
          case 1:
            goto label_22;
          case 3:
            int length1 = str.Length;
            maxValue = settings.MaxValue;
            int num2 = maxValue.Value;
            if (length1 == num2)
            {
              num1 = 8;
              continue;
            }
            goto case 14;
          case 4:
            maxValue = settings.MaxValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 9;
            continue;
          case 5:
            int length2 = str.Length;
            maxValue = settings.MaxValue;
            int num3 = maxValue.Value - 2;
            if (length2 <= num3)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 6:
            if (!((string) value).Trim().Equals(string.Empty))
            {
              settings = (StringSettings) propertyMetadata.Settings;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 16 : 12;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
            continue;
          case 7:
            if (value != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 6;
              continue;
            }
            goto label_4;
          case 8:
            matchMode = MatchMode.Exact;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 17 : 5;
            continue;
          case 9:
            if (maxValue.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 19 : 6;
              continue;
            }
            break;
          case 10:
            if (maxValue.Value <= 0)
            {
              num1 = 2;
              continue;
            }
            goto case 5;
          case 11:
            goto label_13;
          case 12:
            goto label_28;
          case 13:
            int length3 = str.Length;
            maxValue = settings.MaxValue;
            int num4 = maxValue.Value;
            if (length3 > num4)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 12 : 8;
              continue;
            }
            break;
          case 14:
            int length4 = str.Length;
            maxValue = settings.MaxValue;
            int num5 = maxValue.Value - 1;
            if (length4 == num5)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 18 : 12;
              continue;
            }
            goto case 13;
          case 15:
            matchMode = MatchMode.Anywhere;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 4;
            continue;
          case 16:
            str = (string) value;
            num1 = 15;
            continue;
          case 18:
            matchMode = MatchMode.End;
            num1 = 20;
            continue;
          case 19:
            maxValue = settings.MaxValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 10 : 7;
            continue;
        }
        criteria.Add((ICriterion) ElmaRestrictions.InsensitiveLike(string.IsNullOrEmpty(alias) ? propertyMetadata.Name : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29237407), (object) alias, (object) propertyMetadata.Name), (string) value, matchMode));
        num1 = 11;
      }
label_22:
      return;
label_13:
      return;
label_4:
      return;
label_28:
      throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122017652), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77849053), (object) propertyMetadata.Name, (object) str.Length));
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 3;
      TSettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            forFilterProperty.DefaultValue = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 2:
            if ((object) forFilterProperty != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            forFilterProperty = (TSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (TypeSettings) forFilterProperty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    public override bool IsAvailibleEditPropertyInTable => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 3;
      StringSettings settings;
      while (true)
      {
        switch (num1)
        {
          case 1:
            Contract.CheckArgument(propertyMetadata.Settings is StringSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011989895));
            num1 = 4;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106361326));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87877105));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 0;
            continue;
          case 4:
            settings = (StringSettings) propertyMetadata.Settings;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      int maxValue1;
      if (settings != null)
      {
        int? maxValue2 = settings.MaxValue;
        int num2 = 0;
        if (maxValue2.GetValueOrDefault() > num2 & maxValue2.HasValue)
        {
          maxValue2 = settings.MaxValue;
          maxValue1 = maxValue2.Value;
          goto label_10;
        }
      }
      maxValue1 = int.MaxValue;
label_10:
      return new ColumnType(DbType.String, maxValue1);
    }

    public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 1;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new StringPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 2;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    protected StringDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool BLhWSGo7hKqoGYuHmJAv() => StringDescriptor<TSettings>.UICoF0o7balhZr6VEEjg == null;

    internal static object apM5olo7G4Yo6UeqbRSH() => StringDescriptor<TSettings>.UICoF0o7balhZr6VEEjg;
  }
}
