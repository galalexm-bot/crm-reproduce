// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Int16Descriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Целое число (16 бит)"</summary>
  public class Int16Descriptor : CLRTypeDescriptor<short, Int16Settings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    private static Int16Descriptor TPMeb8olDPgIa6yCEqOY;

    /// <summary>Uid типа</summary>
    public override Guid Uid => Int16Descriptor.UID;

    /// <summary>Имя "Целое число (16 бит)"</summary>
    public override string Name => (string) Int16Descriptor.K8uHLbol6IGSCkvLcbpG(Int16Descriptor.NvuXkLol4jxIAyfwEvra(381945751 ^ 1158627804 ^ 1405740635));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Разрешить использовать для идентификатора сущности</summary>
    public override bool UseForId => true;

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num = 7;
      Int16Settings settings;
      short? defaultValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!defaultValue.HasValue)
            {
              num = 5;
              continue;
            }
            goto case 3;
          case 2:
            goto label_8;
          case 3:
            defaultValue = settings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_15;
          case 5:
            goto label_19;
          case 6:
          case 12:
            goto label_20;
          case 7:
            if (val == null)
            {
              num = 6;
              continue;
            }
            goto case 11;
          case 8:
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 13 : 13;
              continue;
            }
            goto label_10;
          case 9:
            goto label_10;
          case 10:
            if (settings == null)
            {
              num = 4;
              continue;
            }
            defaultValue = settings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
            continue;
          case 11:
            if (!Int16Descriptor.w3TC0qolHEZgqy2GhpOx((object) this, (object) propertyMetadata, val))
            {
              num = 8;
              continue;
            }
            goto label_20;
          case 13:
            if (!Int16Descriptor.xq5FGJolAeXlKMQdJKT8((object) propertyMetadata))
            {
              settings = (Int16Settings) propertyMetadata.Settings;
              num = 10;
              continue;
            }
            num = 2;
            continue;
          default:
            goto label_18;
        }
      }
label_8:
      return false;
label_10:
      return true;
label_15:
      return true;
label_18:
      return defaultValue.Equals(val);
label_19:
      return false;
label_20:
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
      int num = 1;
      short? defaultValue;
      Int16Settings int16Settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            Int16Descriptor.OhMe5iol7M281L2jdWD4((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16771147));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            defaultValue = int16Settings.DefaultValue;
            num = 8;
            continue;
          case 4:
          case 6:
            goto label_5;
          case 5:
            int16Settings = (Int16Settings) Int16Descriptor.jUgWeuolx05q0V2Ui6Ko((object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 7;
            continue;
          case 7:
            if (int16Settings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 6;
              continue;
            }
            goto case 3;
          case 8:
            if (defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
              continue;
            }
            goto label_5;
          case 9:
            goto label_12;
          default:
            if (!forFilter)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 5 : 1;
              continue;
            }
            goto label_12;
        }
      }
label_5:
      return (ISyntaxNode) null;
label_6:
      return (ISyntaxNode) Int16Descriptor.bkPWKCol0HiAh6RgQ6rU((object) int16Settings.DefaultValue);
label_12:
      return (ISyntaxNode) null;
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
      int num1 = 12;
      short? nullable1;
      short? nullable2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          short? nullable3;
          switch (num2)
          {
            case 1:
              goto label_19;
            case 2:
              nullable3 = nullable2;
              break;
            case 3:
            case 5:
              nullable2 = nullable1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 10;
              continue;
            case 4:
              goto label_8;
            case 6:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 3 : 3;
                continue;
              }
              goto case 7;
            case 7:
              if (!Int16Descriptor.xq5FGJolAeXlKMQdJKT8((object) propertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 5 : 0;
                continue;
              }
              goto label_6;
            case 8:
              Int16Settings int16Settings = (Int16Settings) Int16Descriptor.jUgWeuolx05q0V2Ui6Ko((object) propertyMetadata);
              if (int16Settings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              // ISSUE: explicit non-virtual call
              nullable3 = __nonvirtual (int16Settings.DefaultValue);
              break;
            case 9:
              goto label_6;
            case 10:
              if (!nullable2.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
                continue;
              }
              goto label_23;
            case 11:
              if (!forFilter)
              {
                num2 = 8;
                continue;
              }
              goto label_8;
            case 12:
              Contract.ArgumentNotNull((object) propertyMetadata, (string) Int16Descriptor.NvuXkLol4jxIAyfwEvra(-53329496 >> 4 ^ -3314360));
              num2 = 11;
              continue;
            case 13:
              nullable3 = nullable2;
              break;
            default:
              nullable2 = new short?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 2;
              continue;
          }
          nullable1 = nullable3;
          num2 = 6;
        }
label_8:
        nullable2 = new short?();
        num1 = 13;
      }
label_6:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<short?>(nullable1);
label_19:
      int num3 = 0;
      goto label_24;
label_23:
      num3 = (int) nullable2.GetValueOrDefault();
label_24:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<short>((short) num3);
    }

    /// <summary>Поддерживается ли автоинкремент</summary>
    public override bool AutoIncrementSupported => true;

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
    {
      int num = 2;
      while (true)
      {
        Int16Settings int16Settings1;
        Int16Settings int16Settings2;
        switch (num)
        {
          case 1:
            int16Settings2 = (Int16Settings) Int16Descriptor.jUgWeuolx05q0V2Ui6Ko((object) propertyMetadata);
            break;
          case 2:
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
              continue;
            }
            goto case 3;
          case 3:
            int16Settings2 = (Int16Settings) null;
            break;
          case 4:
            goto label_6;
          case 5:
            if (int16Settings1.RangeInFilter)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 6 : 2;
              continue;
            }
            goto label_6;
          case 6:
            goto label_7;
          default:
            if (int16Settings1 != null)
            {
              num = 5;
              continue;
            }
            goto label_7;
        }
        int16Settings1 = int16Settings2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
      }
label_6:
      return Int16Descriptor.UID;
label_7:
      return Int16RangeDescriptor.UID;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 3;
      Int16Settings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_5;
          case 2:
            if (forFilterProperty == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 4;
              continue;
            }
            break;
          case 3:
            forFilterProperty = (Int16Settings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = 2;
            continue;
        }
        forFilterProperty.DefaultValue = new short?();
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
      }
label_5:
      return (TypeSettings) forFilterProperty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    public override IComparer GetComparer(
      Type sourceType,
      LambdaExpression propertyFunc,
      ListSortDirection order)
    {
      return (IComparer) Int16Descriptor.cenA8LolmSsTnq55t6am(sourceType, (object) propertyFunc, order);
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
      return new ColumnType(DbType.Int16);
    }

    /// <inheritdoc />
    protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 3;
      short? defaultValue;
      while (true)
      {
        int num2 = num1;
        Int16Settings settings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              if (settings != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 4 : 2;
                continue;
              }
              goto label_4;
            case 3:
              settings = propertyMetadata.Settings as Int16Settings;
              num2 = 2;
              continue;
            case 4:
              goto label_10;
            case 5:
              if (!defaultValue.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              }
              defaultValue = settings.DefaultValue;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
              continue;
            default:
              goto label_4;
          }
        }
label_10:
        defaultValue = settings.DefaultValue;
        num1 = 5;
      }
label_4:
      int dbDefaultValue = 0;
      goto label_12;
label_11:
      dbDefaultValue = (int) defaultValue.Value;
label_12:
      return (object) (short) dbDefaultValue;
    }

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
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new Int16PropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            case 2:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
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

    public Int16Descriptor()
    {
      Int16Descriptor.YWInQoolyqsiWOr41rlw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Int16Descriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Int16Descriptor.YWInQoolyqsiWOr41rlw();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            Int16Descriptor.UID = new Guid((string) Int16Descriptor.NvuXkLol4jxIAyfwEvra(1178210108 ^ 1178119936));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object NvuXkLol4jxIAyfwEvra(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object K8uHLbol6IGSCkvLcbpG([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool PMJoZeoltqfEhDWsCobZ() => Int16Descriptor.TPMeb8olDPgIa6yCEqOY == null;

    internal static Int16Descriptor ShBOa2olwE6OIf4780VU() => Int16Descriptor.TPMeb8olDPgIa6yCEqOY;

    internal static bool w3TC0qolHEZgqy2GhpOx([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static bool xq5FGJolAeXlKMQdJKT8([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static void OhMe5iol7M281L2jdWD4([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object jUgWeuolx05q0V2Ui6Ko([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object bkPWKCol0HiAh6RgQ6rU([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static object cenA8LolmSsTnq55t6am(
      Type sourceType,
      [In] object obj1,
      ListSortDirection order)
    {
      return (object) ComparerHelper.Create(sourceType, (LambdaExpression) obj1, order);
    }

    internal static void YWInQoolyqsiWOr41rlw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
