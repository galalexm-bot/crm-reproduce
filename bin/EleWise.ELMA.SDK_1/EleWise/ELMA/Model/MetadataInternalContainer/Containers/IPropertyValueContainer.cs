// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.IPropertyValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>
  /// Интерфейс контейнера хранения данных свойств контейнерного объекта с нетипизованными методами получения и присвоения значения
  /// </summary>
  public interface IPropertyValueContainer
  {
    /// <summary>Получить значение</summary>
    /// <param name="obj">Контейнерный объект</param>
    /// <returns>Значение</returns>
    object Get(object obj);

    /// <summary>Установить значение</summary>
    /// <param name="obj">Контейнерный объект</param>
    /// <param name="value">Значение</param>
    void Set(object obj, object value);

    /// <summary>Тип свойства</summary>
    Type PropertyType { get; }
  }
}
