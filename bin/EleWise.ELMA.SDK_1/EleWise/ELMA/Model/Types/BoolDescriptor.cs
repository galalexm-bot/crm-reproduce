// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.BoolDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Comparers;
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
  /// <summary>Описание типа "Да / нет"</summary>
  [Component(Order = 800)]
  public class BoolDescriptor : CLRTypeDescriptor<bool, BoolSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    private static BoolDescriptor IMuEvxo9n7j3Sqcfdvwc;

    /// <summary>Uid типа</summary>
    public override Guid Uid => BoolDescriptor.UID;

    /// <summary>Имя "Да / нет"</summary>
    public override string Name => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979611146));

    public override bool IsAvailibleEditPropertyInTable => true;

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num1 = 7;
      bool flag;
      while (true)
      {
        int num2 = num1;
        BoolSettings boolSettings;
        bool? boolDefaultValue;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_23;
            case 2:
              if (boolDefaultValue.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
                continue;
              }
              goto label_6;
            case 3:
              goto label_6;
            case 4:
              goto label_9;
            case 5:
              boolSettings = (BoolSettings) BoolDescriptor.DDRADMo9elglbNDDub7G((object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 6:
            case 12:
              goto label_11;
            case 7:
              if (val == null)
              {
                num2 = 6;
                continue;
              }
              goto case 8;
            case 8:
              if (!this.IsEmpty(propertyMetadata, val))
              {
                if (propertyMetadata != null)
                {
                  if (!propertyMetadata.Nullable)
                  {
                    num2 = 5;
                    continue;
                  }
                  goto label_21;
                }
                else
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 9;
                  continue;
                }
              }
              else
              {
                num2 = 12;
                continue;
              }
            case 9:
              goto label_3;
            case 10:
              goto label_16;
            case 11:
              goto label_21;
            default:
              if (boolSettings != null)
              {
                boolDefaultValue = boolSettings.BoolDefaultValue;
                num2 = 2;
                continue;
              }
              goto label_8;
          }
        }
label_6:
        int num3 = 0;
        goto label_24;
label_8:
        num1 = 4;
        continue;
label_23:
        num3 = boolDefaultValue.GetValueOrDefault() ? 1 : 0;
label_24:
        flag = num3 != 0;
        num1 = 10;
      }
label_3:
      return true;
label_9:
      return true;
label_11:
      return true;
label_16:
      return flag.Equals(val);
label_21:
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
      bool? boolDefaultValue;
      BoolSettings boolSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            BoolDescriptor.olVilKo913PQyAoAI74k((object) propertyMetadata, BoolDescriptor.kRTcB8o9PBjqwRuLQwqP(-1088304168 ^ -1088322934));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          case 2:
          case 5:
            goto label_13;
          case 3:
            goto label_6;
          case 4:
            if (boolDefaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 9 : 9;
              continue;
            }
            goto label_13;
          case 6:
            boolDefaultValue = boolSettings.BoolDefaultValue;
            num = 4;
            continue;
          case 7:
            if (boolSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 2;
              continue;
            }
            goto case 6;
          case 8:
            goto label_2;
          case 9:
            boolDefaultValue = boolSettings.BoolDefaultValue;
            num = 8;
            continue;
          default:
            if (!forFilter)
            {
              boolSettings = (BoolSettings) BoolDescriptor.DDRADMo9elglbNDDub7G((object) propertyMetadata);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 7 : 5;
              continue;
            }
            num = 3;
            continue;
        }
      }
label_2:
      return boolDefaultValue.Value.CreateSyntaxNode();
label_6:
      return (ISyntaxNode) null;
label_13:
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
      bool? nullable1;
      bool? nullable2;
      while (true)
      {
        BoolSettings settings;
        bool? nullable3;
        switch (num1)
        {
          case 1:
          case 2:
            nullable1 = nullable2;
            num1 = 5;
            continue;
          case 3:
            nullable3 = settings.BoolDefaultValue;
            break;
          case 4:
            if (!forFilter)
            {
              if (settings != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 3;
                continue;
              }
              goto case 8;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 9 : 0;
              continue;
            }
          case 5:
            if (!nullable1.HasValue)
            {
              num1 = 7;
              continue;
            }
            goto label_23;
          case 6:
            goto label_9;
          case 7:
            goto label_11;
          case 8:
            nullable1 = new bool?();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 9:
            nullable1 = new bool?();
            num1 = 13;
            continue;
          case 10:
            if (!propertyMetadata.Nullable)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
              continue;
            }
            goto label_9;
          case 11:
            settings = (BoolSettings) propertyMetadata.Settings;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 4 : 1;
            continue;
          case 12:
            BoolDescriptor.olVilKo913PQyAoAI74k((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107996852));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 11 : 2;
            continue;
          case 13:
            nullable3 = nullable1;
            break;
          case 14:
            if (propertyMetadata == null)
            {
              num1 = 2;
              continue;
            }
            goto case 10;
          default:
            nullable3 = nullable1;
            break;
        }
        nullable2 = nullable3;
        num1 = 14;
      }
label_9:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<bool?>(nullable2);
label_11:
      int num2 = 0;
      goto label_24;
label_23:
      num2 = nullable1.GetValueOrDefault() ? 1 : 0;
label_24:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<bool>(num2 != 0);
    }

    /// <summary>
    /// Создать настройки для свойства фильтра, построенного по свойству сущности (должен быть определен у дескриптора типа свойства фильтра)
    /// </summary>
    /// <param name="propertyMetadata">Свойство сущности</param>
    /// <returns></returns>
    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 3;
      BoolSettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (forFilterProperty != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            forFilterProperty = (BoolSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = 2;
            continue;
          case 4:
            BoolDescriptor.UbKxado9NG2bmdDRNcb2((object) forFilterProperty, BoolDisplayType.RadioButtons);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
            continue;
          default:
            forFilterProperty.BoolDefaultValue = new bool?();
            num = 4;
            continue;
        }
      }
label_2:
      return (TypeSettings) forFilterProperty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    public override IComparer GetComparer(
      Type sourceType,
      LambdaExpression propertyFunc,
      ListSortDirection order)
    {
      return (IComparer) BoolDescriptor.vejQ1lo93RGGsbqEehEM(sourceType, (object) propertyFunc, order);
    }

    public override bool IsSupportSort() => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Boolean);
    }

    /// <inheritdoc />
    protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 2;
      bool? boolDefaultValue;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          BoolSettings settings;
          switch (num2)
          {
            case 1:
              if (settings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 5 : 0;
                continue;
              }
              break;
            case 2:
              settings = propertyMetadata.Settings as BoolSettings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
              continue;
            case 3:
            case 5:
              goto label_8;
            case 4:
              if (boolDefaultValue.HasValue)
              {
                boolDefaultValue = settings.BoolDefaultValue;
                num2 = 6;
                continue;
              }
              goto label_4;
            case 6:
              goto label_11;
          }
          boolDefaultValue = settings.BoolDefaultValue;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 2;
        }
label_4:
        num1 = 3;
      }
label_8:
      int dbDefaultValue = 0;
      goto label_12;
label_11:
      dbDefaultValue = boolDefaultValue.Value ? 1 : 0;
label_12:
      return (object) (bool) dbDefaultValue;
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new BoolPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public BoolDescriptor()
    {
      BoolDescriptor.oCZUfCo9pMrVJyoWFw2h();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static BoolDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BoolDescriptor.oCZUfCo9pMrVJyoWFw2h();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            BoolDescriptor.UID = new Guid((string) BoolDescriptor.kRTcB8o9PBjqwRuLQwqP(-2112703338 ^ -2112868514));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool WWiPcko9OmMaLi0NVOxm() => BoolDescriptor.IMuEvxo9n7j3Sqcfdvwc == null;

    internal static BoolDescriptor kyWRhco92oAg9aKNF14a() => BoolDescriptor.IMuEvxo9n7j3Sqcfdvwc;

    internal static object DDRADMo9elglbNDDub7G([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object kRTcB8o9PBjqwRuLQwqP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void olVilKo913PQyAoAI74k([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void UbKxado9NG2bmdDRNcb2([In] object obj0, BoolDisplayType value) => ((BoolSettings) obj0).DisplayType = value;

    internal static object vejQ1lo93RGGsbqEehEM(
      Type sourceType,
      [In] object obj1,
      ListSortDirection order)
    {
      return (object) ComparerHelper.Create(sourceType, (LambdaExpression) obj1, order);
    }

    internal static void oCZUfCo9pMrVJyoWFw2h() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
