// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.IMemoryCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Cache
{
  /// <summary>Сервис для кэширования в памяти</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IMemoryCacheService
  {
    /// <summary>Попытаться получить значение из кэша</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="result">Значение</param>
    /// <returns></returns>
    bool TryGetValue<T>(string key, out T result);

    /// <summary>Проверить наличие элемента в кэше по ключу</summary>
    /// <param name="key">Ключ</param>
    /// <returns>True, если элемент есть в кэше</returns>
    bool Contains(string key);

    /// <summary>Добавить или изменить элемент кеша по ключу</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="value">Значение</param>
    void Insert<T>(string key, T value);

    /// <summary>Добавить или изменить элемент кеша по ключу</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="value">Значение</param>
    /// <param name="timeout">Время хранения значения</param>
    void Insert<T>(string key, T value, TimeSpan timeout);

    /// <summary>Удалить элемент из кэша по ключу</summary>
    /// <param name="key">Ключ</param>
    void Remove(string key);

    /// <summary>Удалить по вхождению подстроки в ключ</summary>
    /// <param name="subkey"></param>
    void RemoveBySubkey(string subkey);
  }
}
