// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.IUnionComplexCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Cache
{
  /// <summary>
  /// Составной кэш для хранения редко меняющихся данных (для редкого обращения к распределенному кэшу)
  /// </summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IUnionComplexCacheService
  {
    /// <summary>
    /// Получить значение из кэша или вычислить значение и записать в кэш, если не найдено
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="key">Ключ для хранения в кэше</param>
    /// <param name="timestampKey">Ключ для временного отпечатка</param>
    /// <param name="valueAccessor">Функция, возвращающая значение. Вызывается, когда в кэше информация не найдена.</param>
    /// <returns>Значение</returns>
    T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor);

    /// <summary>
    /// Получить значение из кэша или вычислить значение и записать в кэш, если не найдено
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="key">Ключ для хранения в кэше</param>
    /// <param name="timestampKey">Ключ для временного отпечатка</param>
    /// <param name="valueAccessor">Функция, возвращающая значение. Вызывается, когда в кэше информация не найдена.</param>
    /// <param name="timeout">Время хранения значения</param>
    /// <returns>Значение</returns>
    T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor, TimeSpan timeout);

    /// <summary>Обновить временной отпечаток</summary>
    /// <param name="timestampKey">Ключ для временного отпечатка</param>
    void RefreshTimestamp(string timestampKey);
  }
}
