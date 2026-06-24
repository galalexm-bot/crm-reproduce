// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ITypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Интерфейс компонента с описанием типа данных или группы типов
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ITypeDescriptor : IXsiType
  {
    /// <summary>Uid типа данных или группы типов</summary>
    Guid Uid { get; }

    /// <summary>Uid родительской группы типов данных</summary>
    Guid ParentUid { get; }

    /// <summary>Является ли тип группой типов</summary>
    bool IsGroup { get; }

    /// <summary>Имя типа данных (или группы)</summary>
    string Name { get; }

    /// <summary>Показывать ли данный элемент в списке типов</summary>
    bool Visible { get; }

    /// <summary>Получить список подтипов (для групп и сложных типов)</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>Список подтипов</returns>
    IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata);

    /// <summary>Может ли быть использован в указанном типе метаданных</summary>
    /// <param name="classMetadata"></param>
    /// <returns></returns>
    bool IsVisibleForMetadata(ClassMetadata classMetadata);

    /// <summary>Uid подтипа данных</summary>
    Guid SubTypeUid { get; }

    /// <summary>
    /// Можно ли использовать тип для идентификаторов сущностей
    /// </summary>
    bool UseForId { get; }

    /// <summary>Можно ли использовать тип для сущностей</summary>
    bool UseForEntity { get; }

    /// <summary>Может ли тип быть Nullable</summary>
    bool CanBeNullable { get; }

    /// <summary>
    /// Значение признака Nullable по умолчанию (используется, если CanBeNullable=true)
    /// </summary>
    /// <remarks>
    /// Если возвращает null - то по умолчанию имеет значение !Required
    /// </remarks>
    bool? DefaultNullableValue { get; }

    /// <summary>Тип класса настроек типа данных</summary>
    Type SettingsType { get; }

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata);

    /// <summary>
    /// Создать настройки для свойства фильтра, построенного по свойству сущности (должен быть определен у дескриптора типа свойства фильтра)
    /// </summary>
    /// <param name="propertyMetadata">Свойство сущности</param>
    /// <returns></returns>
    TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata);

    /// <summary>Является ли значение пустым</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    bool IsEmpty(PropertyMetadata propertyMetadata, object val);

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val);

    /// <summary>Есть реальная колонка в БД</summary>
    bool HasRealColumn(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata);
  }
}
