// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.IPropertyValueContainer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>
  /// Интерфейс контейнера хранения данных конкретного типа свойств контейнерного объекта
  /// </summary>
  public interface IPropertyValueContainer<T> : IPropertyValueContainer
  {
    /// <summary>Получить значение</summary>
    /// <param name="obj">Контейнерный объект</param>
    /// <returns>Значение</returns>
    T Get(object obj);

    /// <summary>Установить значение</summary>
    /// <param name="obj">Контейнерный объект</param>
    /// <param name="value">Значение</param>
    void Set(object obj, T value);
  }
}
