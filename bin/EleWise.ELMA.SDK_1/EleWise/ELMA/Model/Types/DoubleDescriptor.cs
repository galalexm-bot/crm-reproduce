// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.DoubleDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Дробное число"</summary>
  [Component(Order = 500)]
  public class DoubleDescriptor : CLRTypeDescriptor<double, DoubleSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static DoubleDescriptor Qg0rOCo9avkirKUUIhbw;

    /// <summary>Uid типа</summary>
    public override Guid Uid => DoubleDescriptor.UID;

    /// <summary>Имя "Дробное число"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) DoubleDescriptor.j1b4gho9wYIVsWNkOVcl(1021410165 ^ 1021568877));

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num = 11;
      double? defaultValue;
      DoubleSettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_10;
          case 3:
            goto label_2;
          case 4:
            if (defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 3 : 6;
              continue;
            }
            goto label_8;
          case 5:
            if (propertyMetadata == null)
            {
              num = 7;
              continue;
            }
            if (!DoubleDescriptor.sgbwMSo96yDoi4MWPAQL((object) propertyMetadata))
            {
              num = 8;
              continue;
            }
            goto label_10;
          case 6:
            defaultValue = settings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
            continue;
          case 7:
            goto label_14;
          case 8:
            settings = (DoubleSettings) propertyMetadata.Settings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 6 : 12;
            continue;
          case 9:
            defaultValue = settings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 4 : 0;
            continue;
          case 10:
            if (!DoubleDescriptor.JUTgkVo94yS3lYuvlGs4((object) this, (object) propertyMetadata, val))
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 11:
            if (val != null)
            {
              num = 10;
              continue;
            }
            goto label_2;
          case 12:
            if (settings != null)
            {
              num = 9;
              continue;
            }
            goto label_19;
          default:
            goto label_19;
        }
      }
label_2:
      return true;
label_7:
      return defaultValue.Equals(val);
label_8:
      return false;
label_10:
      return false;
label_14:
      return true;
label_19:
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
      int num1 = 3;
      double? defaultValue;
      while (true)
      {
        int num2 = num1;
        DoubleSettings doubleSettings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (!forFilter)
              {
                doubleSettings = (DoubleSettings) DoubleDescriptor.uQblWBo9AbfHD355Ca3L((object) propertyMetadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 6 : 5;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_6;
            case 5:
              goto label_9;
            case 6:
              if (doubleSettings != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 7:
              if (defaultValue.HasValue)
              {
                defaultValue = doubleSettings.DefaultValue;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 2 : 4;
                continue;
              }
              num2 = 5;
              continue;
            default:
              defaultValue = doubleSettings.DefaultValue;
              num2 = 7;
              continue;
          }
        }
label_5:
        DoubleDescriptor.d2GlXAo9HTy6UV2UsrVM((object) propertyMetadata, DoubleDescriptor.j1b4gho9wYIVsWNkOVcl(-787452571 ^ -787471305));
        num1 = 2;
      }
label_3:
      return (ISyntaxNode) null;
label_6:
      return (ISyntaxNode) DoubleDescriptor.UOGiAho973akDv3JTrCW((object) defaultValue.Value);
label_9:
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
      int num1 = 11;
      double? nullable1;
      double? nullable2;
      while (true)
      {
        double? nullable3;
        switch (num1)
        {
          case 1:
            nullable3 = nullable2;
            break;
          case 2:
            if (propertyMetadata == null)
            {
              num1 = 8;
              continue;
            }
            goto case 9;
          case 3:
            nullable3 = nullable2;
            break;
          case 4:
            nullable2 = new double?();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
            continue;
          case 5:
            nullable2 = new double?();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 0;
            continue;
          case 6:
            if (nullable2.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 7:
            goto label_2;
          case 8:
            nullable2 = nullable1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 4 : 6;
            continue;
          case 9:
            if (propertyMetadata.Nullable)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 9 : 12;
              continue;
            }
            goto case 8;
          case 10:
            if (!forFilter)
            {
              DoubleSettings doubleSettings = (DoubleSettings) DoubleDescriptor.uQblWBo9AbfHD355Ca3L((object) propertyMetadata);
              if (doubleSettings == null)
              {
                num1 = 5;
                continue;
              }
              // ISSUE: explicit non-virtual call
              nullable3 = __nonvirtual (doubleSettings.DefaultValue);
              break;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 3 : 4;
            continue;
          case 11:
            DoubleDescriptor.d2GlXAo9HTy6UV2UsrVM((object) propertyMetadata, DoubleDescriptor.j1b4gho9wYIVsWNkOVcl(-1598106783 - -968262081 ^ -629859216));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 10 : 9;
            continue;
          case 12:
            goto label_3;
          default:
            goto label_22;
        }
        nullable1 = nullable3;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 0;
      }
label_2:
      double num2 = 0.0;
      goto label_23;
label_3:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<double?>(nullable1);
label_22:
      num2 = nullable2.GetValueOrDefault();
label_23:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<double>(num2);
    }

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          DoubleSettings doubleSettings1;
          DoubleSettings doubleSettings2;
          switch (num2)
          {
            case 1:
              if (doubleSettings1.RangeInFilter)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 2;
                continue;
              }
              goto label_4;
            case 2:
              goto label_5;
            case 3:
              doubleSettings2 = (DoubleSettings) DoubleDescriptor.uQblWBo9AbfHD355Ca3L((object) propertyMetadata);
              break;
            case 4:
              if (propertyMetadata == null)
                goto case 5;
              else
                goto label_11;
            case 5:
              doubleSettings2 = (DoubleSettings) null;
              break;
            case 6:
              if (doubleSettings1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
          doubleSettings1 = doubleSettings2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 6 : 3;
        }
label_11:
        num1 = 3;
      }
label_4:
      return DoubleDescriptor.UID;
label_5:
      return DoubleRangeDescriptor.UID;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 2;
      DoubleSettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (forFilterProperty != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            forFilterProperty = (DoubleSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            forFilterProperty.DefaultValue = new double?();
            num = 3;
            continue;
        }
      }
label_5:
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
      return new ColumnType(DbType.Double);
    }

    /// <inheritdoc />
    protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
    {
      int num = 4;
      double? defaultValue;
      while (true)
      {
        DoubleSettings doubleSettings;
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
          case 5:
            goto label_6;
          case 3:
            if (doubleSettings == null)
            {
              num = 5;
              continue;
            }
            break;
          case 4:
            doubleSettings = DoubleDescriptor.uQblWBo9AbfHD355Ca3L((object) propertyMetadata) as DoubleSettings;
            num = 3;
            continue;
          case 6:
            if (defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 5;
              continue;
            }
            goto label_6;
          case 7:
            defaultValue = doubleSettings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
            continue;
        }
        defaultValue = doubleSettings.DefaultValue;
        num = 6;
      }
label_6:
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new DoublePropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public DoubleDescriptor()
    {
      DoubleDescriptor.uFvkrAo9xU80gJmijsB6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DoubleDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DoubleDescriptor.UID = new Guid((string) DoubleDescriptor.j1b4gho9wYIVsWNkOVcl(-882126494 ^ -882291372));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object j1b4gho9wYIVsWNkOVcl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Kis5ESo9D5gyUqjl6S5r() => DoubleDescriptor.Qg0rOCo9avkirKUUIhbw == null;

    internal static DoubleDescriptor RLCm2fo9tRhrdIYhl4MD() => DoubleDescriptor.Qg0rOCo9avkirKUUIhbw;

    internal static bool JUTgkVo94yS3lYuvlGs4([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static bool sgbwMSo96yDoi4MWPAQL([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static void d2GlXAo9HTy6UV2UsrVM([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object uQblWBo9AbfHD355Ca3L([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object UOGiAho973akDv3JTrCW([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static void uFvkrAo9xU80gJmijsB6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
