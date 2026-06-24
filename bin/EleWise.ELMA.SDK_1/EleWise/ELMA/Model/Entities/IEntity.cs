// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IEntity
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types.Settings;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Базовый интерфейс сущности</summary>
  [ExtensionPoint(false, ComponentType.All, ServiceScope.Application)]
  [Component]
  public interface IEntity : IIdentified
  {
    /// <summary>Возвращает строковое представление сущности</summary>
    /// <param name="format">Формат отображения, свойства доступны через {$Имя свойства}</param>
    /// <returns>Строка представляющая сущность</returns>
    string ToString(string format);

    /// <summary>
    /// Получить значение свойства по его уникальному идентификатору
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>Значение свойства</returns>
    object GetPropertyValue(Guid propertyUid);

    /// <summary>
    /// Получить значение свойства по его уникальному идентификатору
    /// </summary>
    /// <typeparam name="T">Тип свойства</typeparam>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>Значение свойства</returns>
    T GetPropertyValue<T>(Guid propertyUid);

    /// <summary>
    /// Установить значение свойства по его уникальному идентификатору
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="value">Значение свойства</param>
    void SetPropertyValue(Guid propertyUid, object value);

    /// <summary>
    /// Получить настройки свойства (возвращаются настройки для данного экземпляра сущности, либо копия общих)
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    TSettings GetPropertySettings<TSettings>(Guid propertyUid) where TSettings : TypeSettings;

    /// <summary>
    /// Получить настройки свойства (возвращаются настройки для данного экземпляра сущности, либо копия общих)
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    TypeSettings GetPropertySettings(Guid propertyUid);

    /// <summary>
    /// Получить настройки свойства (возвращаются настройки для данного экземпляра сущности, либо копия общих)
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="defaultSettings">Настройки по умолчанию</param>
    TypeSettings GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings);

    /// <summary>
    /// Получить настройки свойства, сохраненные для данного объекта. Если их нет - то возвращается null
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    TypeSettings LoadPropertyInstanceSettings(Guid propertyUid);

    /// <summary>Сохранить настройки свойства для данного объекта</summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="settings">Настройки</param>
    void SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings);

    /// <summary>Загрузить хранилище настроек свойств даннного объекта</summary>
    /// <param name="createIfNotExists">Создавать ли хранилище, если оно не существует</param>
    /// <param name="loadIfNotLoaded">Загружать, если не были загружены</param>
    /// <returns></returns>
    ITypeSettingsInstanceStore LoadSettingsInstanceStore(
      bool createIfNotExists,
      bool loadIfNotLoaded);

    /// <summary>
    /// Получить сущности, которые содержатся в данной сущности (например, элементы блока, настройки сущности)
    /// </summary>
    /// <returns></returns>
    IEnumerable<IEntity> GetContainedEntities();

    /// <summary>
    /// Получить корневую сущность (если это элемент блока, то возвращается первый родитель)
    /// </summary>
    /// <returns></returns>
    IEntity GetRootEntity();

    /// <summary>Сохранить сущность</summary>
    void Save();

    /// <summary>Удалить сущность</summary>
    void Delete();

    /// <summary>Обновить сущность из БД</summary>
    void Refresh();

    /// <summary>Сущность не сохранялась в базе</summary>
    /// <returns></returns>
    bool IsNew();

    /// <summary>Есть ли несохраненные изменения в сущности</summary>
    /// <returns>True, если есть</returns>
    bool IsDirty();

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <returns>Список идентификаторов свойств</returns>
    Guid[] GetDirtyPropertyUids();
  }
}
