// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.MoneyDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Деньги"</summary>
  [Component(Order = 1000)]
  public class MoneyDescriptor : CLRTypeDescriptor<Money, MoneySettings>, IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{38934BC2-601F-45DA-851F-1BBF1054D85E}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static MoneyDescriptor dKM5pEo7qtHYhlUXscia;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MoneyDescriptor.mHnImio7TwiIVECbowWH((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            mapper.Type<MoneyNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => MoneyDescriptor.UID;

    /// <summary>Имя "Деньги"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) MoneyDescriptor.S9dJrJo7kTSwiPPNwc29(1461625753 ^ 1461462267));

    /// <summary>Может ли тип быть Nullable</summary>
    public override bool CanBeNullable => false;

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 5;
      Money money;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(val is Money))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 3 : 1;
              continue;
            }
            goto case 2;
          case 2:
            money = (Money) val;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_4;
          case 5:
            if (val == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 4 : 4;
              continue;
            }
            goto case 1;
          default:
            goto label_2;
        }
      }
label_2:
      return !money.HasValue;
label_3:
      return false;
label_4:
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
      int num1 = 12;
      double? defaultValue;
      double num2;
      while (true)
      {
        int num3 = num1;
        MoneySettings settings;
        while (true)
        {
          Money money;
          double num4;
          switch (num3)
          {
            case 1:
              if (propertyMetadata != null)
              {
                num3 = 19;
                continue;
              }
              goto label_26;
            case 2:
              // ISSUE: type reference
              if (MoneyDescriptor.UppvZgo7eGAwUy8L1DbI(val.GetType(), MoneyDescriptor.U6RoK4o72b5tvvJyKXhF(__typeref (double))))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 4;
                continue;
              }
              goto case 20;
            case 3:
              if (!MoneyDescriptor.S04OqZo7n3xwg0JObree((object) this, (object) propertyMetadata, val))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
                continue;
              }
              goto label_14;
            case 4:
              num4 = (double) val;
              break;
            case 5:
              goto label_26;
            case 6:
              // ISSUE: type reference
              if (MoneyDescriptor.UppvZgo7eGAwUy8L1DbI(val.GetType(), MoneyDescriptor.U6RoK4o72b5tvvJyKXhF(__typeref (Money))))
              {
                num3 = 13;
                continue;
              }
              goto case 2;
            case 7:
              goto label_21;
            case 8:
              goto label_17;
            case 9:
              goto label_3;
            case 10:
              settings = (MoneySettings) propertyMetadata.Settings;
              num3 = 14;
              continue;
            case 11:
            case 16:
              goto label_14;
            case 12:
              if (val == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 11 : 10;
                continue;
              }
              goto case 3;
            case 13:
              money = (Money) val;
              num3 = 15;
              continue;
            case 14:
              if (settings != null)
              {
                num3 = 6;
                continue;
              }
              goto label_17;
            case 15:
              num4 = money.Value;
              break;
            case 17:
              goto label_4;
            case 18:
              defaultValue = settings.DefaultValue;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 6 : 7;
              continue;
            case 19:
              if (!MoneyDescriptor.H4s84xo7OOXSCI6oeYOV((object) propertyMetadata))
              {
                num3 = 10;
                continue;
              }
              goto label_10;
            case 20:
              num4 = 0.0;
              break;
            default:
              goto label_10;
          }
          num2 = num4;
          num3 = 18;
        }
label_3:
        defaultValue = settings.DefaultValue;
        num1 = 17;
        continue;
label_21:
        if (defaultValue.HasValue)
          num1 = 9;
        else
          goto label_5;
      }
label_4:
      return defaultValue.Equals((object) num2);
label_5:
      return false;
label_10:
      return false;
label_14:
      return true;
label_17:
      return true;
label_26:
      return true;
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
      int num = 3;
      MoneySettings moneySettings;
      double? defaultValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            if (forFilter)
            {
              num = 4;
              continue;
            }
            moneySettings = (MoneySettings) MoneyDescriptor.S9F2cto71VlssZrjvmIM((object) propertyMetadata);
            num = 6;
            continue;
          case 3:
            MoneyDescriptor.sJbmRKo7PUsgoUiHeEZO((object) propertyMetadata, MoneyDescriptor.S9dJrJo7kTSwiPPNwc29(-97972138 ^ -97953532));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 2;
            continue;
          case 4:
            goto label_7;
          case 5:
            defaultValue = moneySettings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 6:
            if (moneySettings != null)
            {
              num = 5;
              continue;
            }
            goto label_11;
          default:
            if (!defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
              continue;
            }
            goto label_12;
        }
      }
label_7:
      return (ISyntaxNode) null;
label_11:
      return (ISyntaxNode) null;
label_12:
      return (ISyntaxNode) MoneyDescriptor.A7GPtoo7NM0WASIjweci((object) moneySettings.DefaultValue);
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
      int num = 3;
      double? nullable1;
      Money money1;
      while (true)
      {
        double? nullable2;
        double? nullable3;
        switch (num)
        {
          case 1:
            nullable2 = new double?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 6;
            continue;
          case 2:
            if (forFilter)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 6 : 8;
              continue;
            }
            MoneySettings moneySettings = (MoneySettings) MoneyDescriptor.S9F2cto71VlssZrjvmIM((object) propertyMetadata);
            if (moneySettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
              continue;
            }
            // ISSUE: explicit non-virtual call
            nullable3 = __nonvirtual (moneySettings.DefaultValue);
            break;
          case 3:
            MoneyDescriptor.sJbmRKo7PUsgoUiHeEZO((object) propertyMetadata, MoneyDescriptor.S9dJrJo7kTSwiPPNwc29(-1978478350 ^ -1978492512));
            num = 2;
            continue;
          case 4:
            money1 = new Money();
            num = 7;
            continue;
          case 5:
            if (!nullable1.HasValue)
            {
              num = 4;
              continue;
            }
            goto label_17;
          case 6:
            nullable3 = nullable2;
            break;
          case 7:
            goto label_10;
          case 8:
            nullable2 = new double?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            nullable3 = nullable2;
            break;
        }
        nullable1 = nullable3;
        num = 5;
      }
label_10:
      Money money2 = money1;
      goto label_18;
label_17:
      money2 = MoneyDescriptor.MpZPqRo73VKa9Kkqg9rj(nullable1.Value);
label_18:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<Money>(money2);
    }

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
    {
      int num = 4;
      while (true)
      {
        MoneySettings moneySettings1;
        MoneySettings moneySettings2;
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!MoneyDescriptor.lPhPVao7p8OuSCCJ58gT((object) moneySettings1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            moneySettings2 = (MoneySettings) null;
            break;
          case 4:
            if (propertyMetadata == null)
            {
              num = 3;
              continue;
            }
            moneySettings2 = (MoneySettings) propertyMetadata.Settings;
            break;
          case 5:
            if (moneySettings1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
              continue;
            }
            goto case 2;
          default:
            goto label_2;
        }
        moneySettings1 = moneySettings2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 2;
      }
label_2:
      return MoneyDescriptor.UID;
label_3:
      return MoneyRangeDescriptor.UID;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 1;
      MoneySettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            forFilterProperty = (MoneySettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
          case 4:
            goto label_4;
          case 3:
            forFilterProperty.DefaultValue = new double?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 4;
            continue;
          default:
            if (forFilterProperty == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 2;
              continue;
            }
            goto case 3;
        }
      }
label_4:
      return (TypeSettings) forFilterProperty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_14;
            case 2:
              num2 = value is Money money ? 6 : 12;
              continue;
            case 3:
              base.ApplyFilterValue(criteria, metadata, propertyMetadata, value, alias);
              num2 = 5;
              continue;
            case 4:
              if (criteria == null)
              {
                num2 = 10;
                continue;
              }
              goto case 9;
            case 5:
              goto label_19;
            case 6:
              if (money.HasValue)
                goto case 3;
              else
                goto label_10;
            case 7:
              if (propertyMetadata != null)
              {
                num2 = 4;
                continue;
              }
              goto label_3;
            case 8:
              if (metadata != null)
              {
                num2 = 7;
                continue;
              }
              goto label_14;
            case 9:
              if (value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 0;
                continue;
              }
              goto label_8;
            case 10:
              goto label_13;
            case 11:
              goto label_17;
            case 12:
              goto label_7;
            default:
              goto label_3;
          }
        }
label_10:
        num1 = 11;
      }
label_19:
      return;
label_13:
      return;
label_17:
      return;
label_7:
      return;
label_3:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272605223));
label_14:
      throw new ArgumentNullException((string) MoneyDescriptor.S9dJrJo7kTSwiPPNwc29(1505778440 - 1981636111 ^ -475875897));
label_8:;
    }

    public override bool IsAvailibleEditPropertyInTable => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Double);
    }

    /// <inheritdoc />
    protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
    {
      int num = 3;
      MoneySettings moneySettings;
      double? defaultValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            defaultValue = moneySettings.DefaultValue;
            num = 4;
            continue;
          case 2:
            if (moneySettings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
              continue;
            }
            goto label_9;
          case 3:
            moneySettings = MoneyDescriptor.S9F2cto71VlssZrjvmIM((object) propertyMetadata) as MoneySettings;
            num = 2;
            continue;
          case 4:
            if (defaultValue.HasValue)
            {
              defaultValue = moneySettings.DefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 3 : 5;
            continue;
          case 5:
            goto label_9;
          default:
            goto label_10;
        }
      }
label_9:
      double dbDefaultValue = 0.0;
      goto label_11;
label_10:
      dbDefaultValue = defaultValue.Value;
label_11:
      return (object) dbDefaultValue;
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new MoneyPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 2;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public MoneyDescriptor()
    {
      MoneyDescriptor.uKoRVZo7aWbIXkqnx50B();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MoneyDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MoneyDescriptor.uKoRVZo7aWbIXkqnx50B();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MoneyDescriptor.UID = new Guid((string) MoneyDescriptor.S9dJrJo7kTSwiPPNwc29(92412609 - 1050237057 ^ -957725390));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void mHnImio7TwiIVECbowWH([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<Money>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool v3XM5Eo7KDtwirGaSMOJ() => MoneyDescriptor.dKM5pEo7qtHYhlUXscia == null;

    internal static MoneyDescriptor uBC9NRo7X25GEErHi68v() => MoneyDescriptor.dKM5pEo7qtHYhlUXscia;

    internal static object S9dJrJo7kTSwiPPNwc29(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool S04OqZo7n3xwg0JObree([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static bool H4s84xo7OOXSCI6oeYOV([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type U6RoK4o72b5tvvJyKXhF([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool UppvZgo7eGAwUy8L1DbI([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void sJbmRKo7PUsgoUiHeEZO([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object S9F2cto71VlssZrjvmIM([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object A7GPtoo7NM0WASIjweci([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static Money MpZPqRo73VKa9Kkqg9rj(double d) => (Money) d;

    internal static bool lPhPVao7p8OuSCCJ58gT([In] object obj0) => ((MoneySettings) obj0).RangeInFilter;

    internal static void uKoRVZo7aWbIXkqnx50B() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
