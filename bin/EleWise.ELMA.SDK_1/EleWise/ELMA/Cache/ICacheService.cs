// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ICacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Cache
{
  /// <summary>Интерфейс работы с кэшем</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface ICacheService
  {
    /// <summary>
    /// Добавить или изменить элемент кэша по ключу с указанием зависимости и времени кеширования
    /// </summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="value">Кэшируемый элемент</param>
    /// <param name="region">Регион</param>
    /// <param name="cacheDuration">Длительность хранения значения в кэше</param>
    /// <param name="onRemoveItemCallback">Функция, которая будет вызвана при удалении элемента из кэша. НЕ работает на распределенном кэше</param>
    [Obsolete("Этот метод поддерживается полностью только на локальном кэше AspNet")]
    void Insert<T>(
      string key,
      T value,
      string region,
      TimeSpan cacheDuration,
      CacheItemRemovedCallback<T> onRemoveItemCallback);

    /// <summary>
    /// Добавить или изменить элемент кэша по ключу с указанием зависимости и времени кеширования
    /// </summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="value">Кэшируемый элемент</param>
    /// <param name="region">Регион</param>
    /// <param name="cacheDuration">Длительность хранения значения в кэше</param>
    void Insert<T>(string key, T value, string region, TimeSpan cacheDuration);

    /// <summary>
    /// Добавить или изменить элемент кэша по ключу с указанием времени кеширования
    /// </summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="value">Кэшируемый элемент</param>
    /// <param name="cacheDuration">Длительность хранения значения в кэше</param>
    void Insert<T>(string key, T value, TimeSpan cacheDuration);

    /// <summary>
    /// Добавить или изменить элемент кэша по ключу c зависимостью
    /// </summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="value">Кэшируемый элемент</param>
    /// <param name="region">Регион</param>
    void Insert<T>(string key, T value, string region);

    /// <summary>Добавить или изменить элемент кэша по ключу</summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="value">Кэшируемый элемент</param>
    void Insert<T>(string key, T value);

    /// <summary>
    /// Проверить наличие элемента в кэше по ключу. !!! Не использовать без крайней необходимости (вместо Contains+Get нужно использовать TryGetValue)!
    /// </summary>
    /// <param name="key">Ключ</param>
    /// <returns>True, если элемент есть в кэше</returns>
    bool Contains(string key);

    /// <summary>
    /// Проверить наличие элемента в кэше по ключу и региону. !!! Не использовать без крайней необходимости (вместо Contains+Get нужно использовать TryGetValue)!
    /// </summary>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    /// <returns>True, если элемент есть в кэше</returns>
    bool Contains(string key, string region);

    /// <summary>Получить элемент из кэша по ключу</summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <returns>Значение</returns>
    T Get<T>(string key);

    /// <summary>Получить элемент из кэша по ключу</summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    /// <returns>Значение</returns>
    T Get<T>(string key, string region);

    /// <summary>Попытаться получить элемент из кэша по ключу</summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="value">Полученный элемент (или значение по умолчанию для типа <typeparamref name="T" />, если элемент не найден)</param>
    /// <returns>True, если элемент найден в кэше</returns>
    bool TryGetValue<T>(string key, out T value);

    /// <summary>
    /// Попытаться получить элемент из кэша по ключу и региону
    /// </summary>
    /// <typeparam name="T">Тип кэшируемого значения в кэше</typeparam>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    /// <returns>True, если элемент найден в кэше</returns>
    bool TryGetValue<T>(string key, string region, out T value);

    /// <summary>Удалить элемент из кэша по ключу</summary>
    /// <param name="key">Ключ</param>
    void Remove(string key);

    /// <summary>Удалить элемент из кэша по ключу</summary>
    /// <param name="key">Ключ</param>
    /// <param name="region">Регион</param>
    void Remove(string key, string region);

    /// <summary>Удалить все данные из региона</summary>
    /// <param name="region">Регион</param>
    void ClearRegion(string region);

    /// <summary>Признак, что кэш распределенный</summary>
    bool IsDistributed { get; }
  }
}
