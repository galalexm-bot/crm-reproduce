// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.ISettingsManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Интерфейс для менеджеров данных, хранящих настройки (строка-строка)
  /// </summary>
  public interface ISettingsManager
  {
    /// <summary>Установить значение</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    /// <param name="value">Значение</param>
    void SetString(Guid uid, string key, string value);

    /// <summary>Установить значения для компонента</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="strings">Словарь значений</param>
    void SetStrings(Guid uid, IDictionary<string, string> strings);

    /// <summary>Получить значение</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    /// <returns>Значение</returns>
    string GetString(Guid uid, string key);

    /// <summary>Получить все значения для компонента</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <returns>Значения</returns>
    IDictionary<string, string> GetAllStrings(Guid uid);

    /// <summary>Удалить значение полностью</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    void RemoveString(Guid uid, string key);

    /// <summary>Удалить все значения полностью</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    void RemoveAllStrings(Guid uid);
  }
}
