// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.SubTypeGroupDescriptor
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
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание группы абстрактных подтипов</summary>
  public class SubTypeGroupDescriptor : ITypeDescriptor, IXsiType, IPublicApplicationTypeDescriptor
  {
    private string name;
    private ITypeDescriptor parent;
    private List<ITypeDescriptor> subTypes;
    private static SubTypeGroupDescriptor gYEsdyo9EC6abuqbi8YI;

    /// <summary>Ctor</summary>
    /// <param name="name">Имя типа</param>
    /// <param name="parent">Родительское описание</param>
    public SubTypeGroupDescriptor(string name, ITypeDescriptor parent)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.subTypes = new List<ITypeDescriptor>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.parent = parent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
            continue;
          default:
            this.name = name;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Uid типа данных или группы типов</summary>
    public Guid Uid => Guid.Empty;

    public bool IsVisibleForMetadata(ClassMetadata classMetadata) => true;

    /// <summary>Uid подтипа данных</summary>
    public Guid SubTypeUid => Guid.Empty;

    /// <summary>Uid родительской группы типов данных</summary>
    public Guid ParentUid => Guid.Empty;

    /// <summary>Список подтипов</summary>
    public List<ITypeDescriptor> SubTypes => this.subTypes;

    /// <summary>Является ли тип группой типов - True</summary>
    public bool IsGroup => true;

    /// <summary>Имя группы типов</summary>
    public string Name => this.name;

    /// <summary>Показывать ли данный элемент в списке типов</summary>
    public virtual bool Visible => true;

    /// <summary>Может ли тип быть Nullable</summary>
    public bool CanBeNullable => false;

    /// <summary>
    /// Значение признака Nullable по умолчанию (используется, если CanBeNullable=true)
    /// </summary>
    public bool? DefaultNullableValue => new bool?();

    /// <summary>Тип класса настроек типа данных</summary>
    public Type SettingsType => (Type) null;

    /// <summary>
    /// Разрешено ли использовать данный тип в блоке на редактирование как таблица
    /// </summary>
    public virtual bool IsAvailibleEditPropertyTable => false;

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
    /// <returns>Список подтипов</returns>
    public IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata) => (IEnumerable<ITypeDescriptor>) this.subTypes;

    /// <summary>
    /// Можно ли использовать тип для идентификаторов сущностей - false
    /// </summary>
    public bool UseForId => false;

    /// <summary>Можно ли использовать тип для сущностей</summary>
    public bool UseForEntity => false;

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
    public virtual bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val) => SubTypeGroupDescriptor.BajoA7o9CYVMe0RsqKYf((object) this, (object) propertyMetadata, val);

    public bool HasRealColumn(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return false;
    }

    public bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
    {
      int num = 2;
      IPublicApplicationTypeDescriptor parent;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parent != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            parent = this.parent as IPublicApplicationTypeDescriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return SubTypeGroupDescriptor.gP1rSxo9vU4tWNhDfpbI((object) parent, subTypeUid);
label_4:
      return true;
    }

    public bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
    {
      int num = 1;
      IPublicApplicationTypeDescriptor parent;
      while (true)
      {
        switch (num)
        {
          case 1:
            parent = this.parent as IPublicApplicationTypeDescriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          default:
            if (parent == null)
            {
              num = 3;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return SubTypeGroupDescriptor.IIyTJpo98SilOdl5bLgF((object) parent, subTypeUid);
label_5:
      return true;
    }

    public void CheckPublicApplicationCompatibility(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      PropertyViewItem viewItem,
      string parentPropertyName,
      List<IPublicApplicationCompatibilityError> errors)
    {
      if (!(this.parent is IPublicApplicationTypeDescriptor parent))
        return;
      parent.CheckPublicApplicationCompatibility(classMetadata, propertyMetadata, viewItem, parentPropertyName, errors);
    }

    internal static bool cF42WUo9fCx6nqQGCvBH() => SubTypeGroupDescriptor.gYEsdyo9EC6abuqbi8YI == null;

    internal static SubTypeGroupDescriptor D3IAV9o9QlmiiMuKEsdY() => SubTypeGroupDescriptor.gYEsdyo9EC6abuqbi8YI;

    internal static bool BajoA7o9CYVMe0RsqKYf([In] object obj0, [In] object obj1, [In] object obj2) => ((SubTypeGroupDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static bool gP1rSxo9vU4tWNhDfpbI([In] object obj0, Guid subTypeUid) => ((IPublicApplicationTypeDescriptor) obj0).IsPublicApplicationDisplayEnabled(subTypeUid);

    internal static bool IIyTJpo98SilOdl5bLgF([In] object obj0, Guid subTypeUid) => ((IPublicApplicationTypeDescriptor) obj0).IsPublicApplicationEditorEnabled(subTypeUid);
  }
}
