// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IBLOBDataManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Интерфейс для менеджеров данных, хранящих данные объектов
  /// </summary>
  public interface IBLOBDataManager
  {
    /// <summary>Установить значение</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    /// <param name="value">Значение (объект)</param>
    void SetBLOB<T>(Guid uid, string key, T value);

    /// <summary>Получить значение</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    /// <returns>Значение (объект)</returns>
    T GetBLOB<T>(Guid uid, string key);

    /// <summary>Очистить данные</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    void RemoveBLOB<T>(Guid uid, string key);
  }
}
