// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Groups.TypesGroupDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Groups
{
  /// <summary>Абстрактный класс описания группы типов данных</summary>
  [Component]
  public abstract class TypesGroupDescriptor : ITypeDescriptor, IXsiType
  {
    internal static TypesGroupDescriptor xY0eZOor7ZXxxZsXFn1P;

    /// <summary>Uid группы типов</summary>
    public abstract Guid Uid { get; }

    /// <summary>Видима для определенного типа метаданных</summary>
    /// <param name="classMetadata"></param>
    /// <returns></returns>
    public bool IsVisibleForMetadata(ClassMetadata classMetadata) => true;

    /// <summary>Uid подтипа - пустой</summary>
    public Guid SubTypeUid => Guid.Empty;

    /// <summary>Uid родительской группы типов данных</summary>
    public virtual Guid ParentUid => Guid.Empty;

    /// <summary>Имя группы</summary>
    public abstract string Name { get; }

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

    /// <summary>
    /// Можно ли использовать тип для идентификаторов сущностей
    /// </summary>
    public bool UseForId => false;

    /// <summary>Можно ли использовать тип для сущностей</summary>
    public bool UseForEntity => false;

    /// <summary>Является ли тип группой типов</summary>
    public bool IsGroup => true;

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
    public virtual bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val) => TypesGroupDescriptor.KRbDj3ormqfR4psUYTVb((object) this, (object) propertyMetadata, val);

    /// <summary>Получить список подтипов (для групп и сложных типов)</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>Список подтипов</returns>
    public IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
    {
      IEnumerable<ITypeDescriptor> source = MetadataServiceContext.Service.GetTypeDescriptors().Where<ITypeDescriptor>((Func<ITypeDescriptor, bool>) (t =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!TypesGroupDescriptor.Yde7WKory36Rhoj5K4R6((object) t))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return TypesGroupDescriptor.slrkK1or9DpMavciDmHv(TypesGroupDescriptor.lgVMNuorMPnA1S9iCCKU((object) t), TypesGroupDescriptor.w0LTAlorJG2jDlB8Gc4g((object) this));
label_3:
        return false;
      }));
      if (this.OrderTypesByName)
      {
        // ISSUE: reference to a compiler-generated method
        source = (IEnumerable<ITypeDescriptor>) source.OrderBy<ITypeDescriptor, string>((Func<ITypeDescriptor, string>) (t => (string) TypesGroupDescriptor.\u003C\u003Ec.d6UwxTCRm4vTnoQZgT5M((object) t)));
      }
      return (IEnumerable<ITypeDescriptor>) source.ToList<ITypeDescriptor>();
    }

    /// <summary>Поддерживается поиск в индексе</summary>
    public virtual bool IsSupportedSearchInIndex => false;

    /// <summary>Поддерживается полнотекстовый поиск в индексе</summary>
    public virtual bool IsSupportedFullTextSearchInIndex => false;

    /// <summary>Выстраивать ли типы по имени</summary>
    protected virtual bool OrderTypesByName => true;

    public bool HasRealColumn(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return false;
    }

    public List<string> SearchField() => (List<string>) null;

    public object FilterFiled() => (object) null;

    protected TypesGroupDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qVwlNQorxpp8vNcTVhw9() => TypesGroupDescriptor.xY0eZOor7ZXxxZsXFn1P == null;

    internal static TypesGroupDescriptor hWBGZAor022f2Sca3c73() => TypesGroupDescriptor.xY0eZOor7ZXxxZsXFn1P;

    internal static bool KRbDj3ormqfR4psUYTVb([In] object obj0, [In] object obj1, [In] object obj2) => ((TypesGroupDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static bool Yde7WKory36Rhoj5K4R6([In] object obj0) => ((ITypeDescriptor) obj0).Visible;

    internal static Guid lgVMNuorMPnA1S9iCCKU([In] object obj0) => ((ITypeDescriptor) obj0).ParentUid;

    internal static Guid w0LTAlorJG2jDlB8Gc4g([In] object obj0) => ((TypesGroupDescriptor) obj0).Uid;

    internal static bool slrkK1or9DpMavciDmHv([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
