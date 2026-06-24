// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Int32Descriptor
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
  /// <summary>Описание типа "Целое число (32 бита)"</summary>
  public class Int32Descriptor : CLRTypeDescriptor<int, Int32Settings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    private static Int32Descriptor Erwk8Aoroa9SgCqil4jj;

    /// <summary>Uid типа</summary>
    public override Guid Uid => Int32Descriptor.UID;

    /// <summary>Имя "Целое число (32 бита)"</summary>
    public override string Name => (string) Int32Descriptor.GgDKZWorEN8mjqCKWqAF(Int32Descriptor.M8vfw6orGKEGl3fosob7(1470440286 ^ 1470595608));

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
      int num = 14;
      int? defaultValue;
      Int32Settings int32Settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 7 : 5;
              continue;
            }
            goto label_10;
          case 2:
            goto label_17;
          case 3:
            goto label_19;
          case 4:
            goto label_20;
          case 5:
            defaultValue = int32Settings.DefaultValue;
            num = 3;
            continue;
          case 6:
            int32Settings = (Int32Settings) Int32Descriptor.hD615forCyZOsCtV2qZN((object) propertyMetadata);
            num = 12;
            continue;
          case 7:
            if (!Int32Descriptor.pS7GT6orQ7CMgGpDtVxs((object) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 3 : 6;
              continue;
            }
            goto label_17;
          case 8:
            goto label_8;
          case 9:
            if (!defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 4;
              continue;
            }
            goto case 5;
          case 10:
            goto label_2;
          case 11:
            goto label_10;
          case 12:
            if (int32Settings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 13:
            if (!Int32Descriptor.yel72korfhyGiRn13AiQ((object) this, (object) propertyMetadata, val))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 14:
            if (val != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 13 : 7;
              continue;
            }
            goto label_2;
          default:
            defaultValue = int32Settings.DefaultValue;
            num = 9;
            continue;
        }
      }
label_2:
      return true;
label_8:
      return true;
label_10:
      return true;
label_17:
      return false;
label_19:
      return defaultValue.Equals(val);
label_20:
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
      int num1 = 7;
      Int32Settings int32Settings;
      while (true)
      {
        int num2 = num1;
        int? defaultValue;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (int32Settings != null)
                goto case 3;
              else
                goto label_6;
            case 3:
              defaultValue = int32Settings.DefaultValue;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            case 4:
            case 5:
              goto label_8;
            case 6:
              if (!forFilter)
              {
                int32Settings = (Int32Settings) Int32Descriptor.hD615forCyZOsCtV2qZN((object) propertyMetadata);
                num2 = 2;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
              continue;
            case 7:
              Int32Descriptor.q8S5dGorv6VPkOvfCHZU((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222144044));
              num2 = 6;
              continue;
            default:
              goto label_10;
          }
        }
label_6:
        num1 = 4;
        continue;
label_10:
        if (!defaultValue.HasValue)
          num1 = 5;
        else
          goto label_9;
      }
label_3:
      return (ISyntaxNode) null;
label_8:
      return (ISyntaxNode) null;
label_9:
      return int32Settings.DefaultValue.CreateSyntaxNode();
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
      int num1 = 8;
      int? nullable1;
      int? nullable2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int? nullable3;
          switch (num2)
          {
            case 1:
            case 3:
              nullable1 = nullable2;
              num2 = 5;
              continue;
            case 2:
              nullable3 = nullable1;
              break;
            case 4:
              nullable1 = new int?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            case 5:
              if (nullable1.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 9 : 1;
                continue;
              }
              goto label_12;
            case 6:
              goto label_13;
            case 7:
              if (forFilter)
              {
                num2 = 4;
                continue;
              }
              Int32Settings int32Settings = (Int32Settings) Int32Descriptor.hD615forCyZOsCtV2qZN((object) propertyMetadata);
              if (int32Settings == null)
              {
                num2 = 12;
                continue;
              }
              // ISSUE: explicit non-virtual call
              nullable3 = __nonvirtual (int32Settings.DefaultValue);
              break;
            case 8:
              Contract.ArgumentNotNull((object) propertyMetadata, (string) Int32Descriptor.M8vfw6orGKEGl3fosob7(372753449 ^ 372739451));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 7;
              continue;
            case 9:
              goto label_23;
            case 10:
              goto label_12;
            case 11:
              if (!propertyMetadata.Nullable)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
                continue;
              }
              goto label_13;
            case 12:
              goto label_10;
            case 13:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 3 : 0;
                continue;
              }
              goto case 11;
            default:
              nullable3 = nullable1;
              break;
          }
          nullable2 = nullable3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 11 : 13;
        }
label_10:
        nullable1 = new int?();
        num1 = 2;
      }
label_12:
      int num3 = 0;
      goto label_24;
label_13:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<int?>(nullable2);
label_23:
      num3 = nullable1.GetValueOrDefault();
label_24:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<int>(num3);
    }

    /// <summary>Поддерживается ли автоинкремент</summary>
    public override bool AutoIncrementSupported => true;

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
    {
      int num = 3;
      while (true)
      {
        Int32Settings int32Settings1;
        Int32Settings int32Settings2;
        switch (num)
        {
          case 1:
            if (!int32Settings1.RangeInFilter)
            {
              num = 5;
              continue;
            }
            goto label_10;
          case 2:
            int32Settings2 = (Int32Settings) Int32Descriptor.hD615forCyZOsCtV2qZN((object) propertyMetadata);
            break;
          case 3:
            if (propertyMetadata != null)
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
            int32Settings2 = (Int32Settings) null;
            break;
          case 5:
            goto label_9;
          default:
            if (int32Settings1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
              continue;
            }
            goto label_10;
        }
        int32Settings1 = int32Settings2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
      }
label_9:
      return Int32Descriptor.UID;
label_10:
      return Int32RangeDescriptor.UID;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num1 = 2;
      Int32Settings forFilterProperty;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (forFilterProperty != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              forFilterProperty = (Int32Settings) base.CreateSettingsForFilterProperty(propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_7;
            default:
              goto label_3;
          }
        }
label_3:
        forFilterProperty.DefaultValue = new int?();
        num1 = 3;
      }
label_7:
      return (TypeSettings) forFilterProperty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    public override IComparer GetComparer(
      Type sourceType,
      LambdaExpression propertyFunc,
      ListSortDirection order)
    {
      return (IComparer) Int32Descriptor.XdY6J3or8loxZrrXBbYI(sourceType, (object) propertyFunc, order);
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
      return new ColumnType(DbType.Int32);
    }

    /// <inheritdoc />
    protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 5;
      int? defaultValue;
      while (true)
      {
        int num2 = num1;
        Int32Settings settings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_11;
            case 3:
              defaultValue = settings.DefaultValue;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_7;
            case 5:
              settings = propertyMetadata.Settings as Int32Settings;
              num2 = 4;
              continue;
            default:
              if (!defaultValue.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
                continue;
              }
              defaultValue = settings.DefaultValue;
              num2 = 2;
              continue;
          }
        }
label_7:
        if (settings != null)
          num1 = 3;
        else
          break;
      }
label_6:
      int dbDefaultValue = 0;
      goto label_12;
label_11:
      dbDefaultValue = defaultValue.Value;
label_12:
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new Int32PropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public Int32Descriptor()
    {
      Int32Descriptor.jI0T0MorZGZxxZpm24mL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Int32Descriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Int32Descriptor.UID = new Guid((string) Int32Descriptor.M8vfw6orGKEGl3fosob7(-53329496 >> 4 ^ -3177106));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object M8vfw6orGKEGl3fosob7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GgDKZWorEN8mjqCKWqAF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool DJk5woorbQpCBupEBSKF() => Int32Descriptor.Erwk8Aoroa9SgCqil4jj == null;

    internal static Int32Descriptor Fx9y03orhrvorgQ6p2Sp() => Int32Descriptor.Erwk8Aoroa9SgCqil4jj;

    internal static bool yel72korfhyGiRn13AiQ([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static bool pS7GT6orQ7CMgGpDtVxs([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static object hD615forCyZOsCtV2qZN([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static void q8S5dGorv6VPkOvfCHZU([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object XdY6J3or8loxZrrXBbYI(
      Type sourceType,
      [In] object obj1,
      ListSortDirection order)
    {
      return (object) ComparerHelper.Create(sourceType, (LambdaExpression) obj1, order);
    }

    internal static void jI0T0MorZGZxxZpm24mL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
