// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ISerializableTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс описателя типов, который поддерживает сериализацию значений данного типа
  /// </summary>
  public interface ISerializableTypeDescriptor
  {
    /// <summary>
    /// Получить описание структуры значений для сериализации\десериализации указанного свойства объекта
    /// </summary>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Объект с описанием структуры значений</returns>
    TypeSerializationDescriptor GetSerializeDescriptor(
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata);

    /// <summary>
    /// Получить общее описание структуры значений для сериализации\десериализации произвольного свойства объекта
    /// </summary>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Объект с описанием структуры значений</returns>
    TypeSerializationDescriptor GetSerializeDescriptor(Guid subTypeUid);

    /// <summary>
    /// Получить описание структуры настроек свойств данного типа для сериализации\десериализации
    /// </summary>
    /// <returns>Объект с описанием структуры настроек</returns>
    TypeSerializationDescriptor GetSettingsSerializeDescriptor();

    /// <summary>
    /// Получить сериализуемые значения для значения свойства данного типа
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Словарь сериализуемых значений</returns>
    IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata);

    /// <summary>
    /// Получить сериализуемые значения для значения свойства данного типа
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="settings">Настройки</param>
    /// <returns>Словарь сериализуемых значений</returns>
    IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings);

    /// <summary>
    /// Восстановить значение свойства из сериализуемых значений
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="values">Словарь сериализуемых значений</param>
    void Deserialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      IDictionary<string, object> values);

    /// <summary>Сериализовать данные в объект</summary>
    /// <param name="value">Данные</param>
    /// <param name="valueType">Тип данных</param>
    /// <returns>Сериализованное представление данных</returns>
    object SerializeSimple(object value, [NotNull] Type valueType);

    /// <summary>Сериализовать данные в объект</summary>
    /// <param name="value">Данные</param>
    /// <param name="valueType">Тип данных</param>
    /// <param name="settings">Настройки</param>
    /// <returns>Сериализованное представление данных</returns>
    object SerializeSimple(object value, [NotNull] Type valueType, EntitySerializationSettings settings);

    /// <summary>Десериализовать данные</summary>
    /// <param name="value">Сериализованное представление данных</param>
    /// <param name="deserializeToType">Тип данных</param>
    /// <returns>Десериализованный объект</returns>
    object DeserializeSimple(object value, [NotNull] Type deserializeToType);
  }
}
