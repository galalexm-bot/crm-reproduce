// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.SubTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание абстрактного подтипа</summary>
  public class SubTypeDescriptor : ITypeDescriptor, IXsiType, IPublicApplicationTypeDescriptor
  {
    private ITypeDescriptor baseTypeDescriptor;
    private Guid subTypeUid;
    private string name;
    private static SubTypeDescriptor VE7FLIolIRuOwhWjf4bd;

    /// <summary>Ctor</summary>
    /// <param name="baseTypeDescriptor">Дескриптор базового типа</param>
    /// <param name="subTypeUid">Uid подтипа</param>
    /// <param name="name">Имя типа</param>
    public SubTypeDescriptor(ITypeDescriptor baseTypeDescriptor, Guid subTypeUid, string name)
    {
      SubTypeDescriptor.sQ3BmOoliHLEf98L59k4();
      // ISSUE: explicit constructor call
      this.\u002Ector(baseTypeDescriptor, SubTypeDescriptor.i9ScV4olRCBcqidCP6uS((object) baseTypeDescriptor), subTypeUid, name);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            SubTypeDescriptor.E930GLolqhbVxTlyWKmx((object) baseTypeDescriptor, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133073487));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="baseTypeDescriptor">Дескриптор базового типа</param>
    /// <param name="typeUid">Uid типа</param>
    /// <param name="subTypeUid">Uid подтипа</param>
    /// <param name="name">Имя типа</param>
    public SubTypeDescriptor(
      ITypeDescriptor baseTypeDescriptor,
      Guid typeUid,
      Guid subTypeUid,
      string name)
    {
      SubTypeDescriptor.sQ3BmOoliHLEf98L59k4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.baseTypeDescriptor = baseTypeDescriptor;
            num = 6;
            continue;
          case 2:
            this.SettingsType = SubTypeDescriptor.i658gBolXVRNDSG3volE((object) baseTypeDescriptor);
            num = 9;
            continue;
          case 3:
            SubTypeDescriptor.E930GLolqhbVxTlyWKmx((object) baseTypeDescriptor, SubTypeDescriptor.wfjNI9olKt4h8f33lIX4(1470440286 ^ 1470610478));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
            continue;
          case 4:
            this.name = name;
            num = 7;
            continue;
          case 5:
            goto label_2;
          case 6:
            this.subTypeUid = subTypeUid;
            num = 4;
            continue;
          case 7:
            this.Uid = typeUid;
            num = 2;
            continue;
          case 8:
            this.DefaultNullableValue = baseTypeDescriptor.DefaultNullableValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 5;
            continue;
          case 9:
            this.UseForEntity = SubTypeDescriptor.nUTHi7olThH53YtpNdEh((object) baseTypeDescriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          default:
            this.CanBeNullable = SubTypeDescriptor.N9bikPolkB50iUvg838b((object) baseTypeDescriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 3 : 8;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа данных или группы типов</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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

    /// <summary>Видима для определенно типа метаданных</summary>
    /// <param name="classMetadata"></param>
    /// <returns></returns>
    public bool IsVisibleForMetadata(ClassMetadata classMetadata) => true;

    /// <summary>Uid подтипа данных</summary>
    public Guid SubTypeUid => this.subTypeUid;

    /// <summary>Uid родительской группы типов данных</summary>
    public Guid ParentUid => this.Uid;

    /// <summary>Является ли тип группой типов - False</summary>
    public bool IsGroup => false;

    /// <summary>Имя типа данных</summary>
    public string Name => this.name;

    /// <summary>Показывать ли данный элемент в списке типов</summary>
    public virtual bool Visible => true;

    /// <summary>Может ли тип быть Nullable</summary>
    public bool CanBeNullable
    {
      get => this.\u003CCanBeNullable\u003Ek__BackingField;
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
              this.\u003CCanBeNullable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    /// <summary>
    /// Значение признака Nullable по умолчанию (используется, если CanBeNullable=true)
    /// </summary>
    public bool? DefaultNullableValue { get; set; }

    /// <summary>Тип класса настроек типа данных</summary>
    public Type SettingsType
    {
      get => this.\u003CSettingsType\u003Ek__BackingField;
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
              this.\u003CSettingsType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    public Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata) => Guid.Empty;

    /// <summary>
    /// Создать настройки для свойства фильтра, построенного по свойству сущности (должен быть определен у дескриптора типа свойства фильтра)
    /// </summary>
    /// <param name="propertyMetadata">Свойство сущности</param>
    /// <returns></returns>
    public TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata) => (TypeSettings) null;

    /// <summary>Получить список подтипов (для групп и сложных типов)</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>NULL</returns>
    public IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata) => (IEnumerable<ITypeDescriptor>) null;

    /// <summary>
    /// Можно ли использовать тип для идентификаторов сущностей - false
    /// </summary>
    public bool UseForId => false;

    /// <summary>Можно ли использовать тип для сущностей</summary>
    public bool UseForEntity
    {
      get => this.\u003CUseForEntity\u003Ek__BackingField;
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
              this.\u003CUseForEntity\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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

    /// <summary>
    /// Разрешено ли использовать данный тип в блоке на редактирование как таблица
    /// </summary>
    public virtual bool IsAvailibleEditPropertyTable => false;

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public virtual bool IsEmpty(PropertyMetadata propertyMetadata, object val) => val == null;

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public virtual bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val) => SubTypeDescriptor.HpTf9VolnccDUmwwDVgP((object) this, (object) propertyMetadata, val);

    public bool HasRealColumn(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return true;
    }

    public bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
    {
      int num = 3;
      IPublicApplicationTypeDescriptor baseTypeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (baseTypeDescriptor == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            baseTypeDescriptor = this.baseTypeDescriptor as IPublicApplicationTypeDescriptor;
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return baseTypeDescriptor.IsPublicApplicationDisplayEnabled(subTypeUid);
label_6:
      return true;
    }

    public bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
    {
      int num = 1;
      IPublicApplicationTypeDescriptor baseTypeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            baseTypeDescriptor = this.baseTypeDescriptor as IPublicApplicationTypeDescriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (baseTypeDescriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 0;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return SubTypeDescriptor.MIOtbrolO1NIvgVIaCvf((object) baseTypeDescriptor, subTypeUid);
label_6:
      return true;
    }

    public void CheckPublicApplicationCompatibility(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      PropertyViewItem viewItem,
      string parentPropertyName,
      List<IPublicApplicationCompatibilityError> errors)
    {
      if (!(this.baseTypeDescriptor is IPublicApplicationTypeDescriptor baseTypeDescriptor))
        return;
      baseTypeDescriptor.CheckPublicApplicationCompatibility(classMetadata, propertyMetadata, viewItem, parentPropertyName, errors);
    }

    internal static void sQ3BmOoliHLEf98L59k4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Guid i9ScV4olRCBcqidCP6uS([In] object obj0) => ((ITypeDescriptor) obj0).Uid;

    internal static void E930GLolqhbVxTlyWKmx([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool kN5l6volVNlfH0HM8Bor() => SubTypeDescriptor.VE7FLIolIRuOwhWjf4bd == null;

    internal static SubTypeDescriptor JMB5twolSbdCF3xRgCMn() => SubTypeDescriptor.VE7FLIolIRuOwhWjf4bd;

    internal static object wfjNI9olKt4h8f33lIX4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type i658gBolXVRNDSG3volE([In] object obj0) => ((ITypeDescriptor) obj0).SettingsType;

    internal static bool nUTHi7olThH53YtpNdEh([In] object obj0) => ((ITypeDescriptor) obj0).UseForEntity;

    internal static bool N9bikPolkB50iUvg838b([In] object obj0) => ((ITypeDescriptor) obj0).CanBeNullable;

    internal static bool HpTf9VolnccDUmwwDVgP([In] object obj0, [In] object obj1, [In] object obj2) => ((SubTypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static bool MIOtbrolO1NIvgVIaCvf([In] object obj0, Guid subTypeUid) => ((IPublicApplicationTypeDescriptor) obj0).IsPublicApplicationEditorEnabled(subTypeUid);
  }
}
