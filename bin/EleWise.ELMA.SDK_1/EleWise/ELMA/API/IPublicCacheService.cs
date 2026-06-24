// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.IPublicCacheService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using System;

namespace EleWise.ELMA.API
{
  /// <summary>Интерфейс сервиса для работы с внешним кэшем</summary>
  public interface IPublicCacheService
  {
    /// <summary>Проверить, актуален ли кэш по значению</summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <param name="tokenValue">Значение кэша</param>
    /// <param name="cacheToken">Токен кэша</param>
    /// <returns><c>true</c>, если кэш актуален</returns>
    bool IsCacheValid(Guid authToken, string tokenValue, out IPublicClientCacheToken cacheToken);

    /// <summary>Удалить истекшие по времени токены</summary>
    /// <param name="expireInterval">Интервал проверки срока истечения</param>
    /// <returns>Количество удаленных токенов</returns>
    long RemoveExpired(TimeSpan expireInterval);

    /// <summary>Получить или создать токен кэша</summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <param name="tokenValue">Значение токена</param>
    /// <returns>Токен кэша</returns>
    IPublicClientCacheToken CreateCacheToken(Guid authToken, string tokenValue);

    /// <summary>Получить ключ для значения токена</summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <param name="tokenValue">Значение токена</param>
    /// <returns>Уникальный ключ по значению токена</returns>
    Guid GetTokenKey(Guid authToken, string tokenValue);

    /// <summary>Обновить дату активности токена кэша</summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <param name="tokenValue">Значение токена</param>
    /// <returns><c>true</c>, если обновление прошло успешно</returns>
    bool PromoteCacheToken(Guid authToken, string tokenValue);

    /// <summary>Получить ключ кэша по идентификатору типа и запросу</summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <param name="eqlQuery">Запрос EQL, по которому построен кэш</param>
    /// <returns>Строковый ключ, который можно использовать в кэше</returns>
    string GetTokenValue(Guid typeUid, string eqlQuery);

    /// <summary>Синхронизировать данные кэша</summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <param name="fromDate">Дата начала интервала синхронизации</param>
    /// <param name="data">Данные в кэше</param>
    /// <param name="eqlQuery">Запрос EQL, по которому построен кэш</param>
    /// <returns><c>true</c>, если синхронизация прошла успешно</returns>
    bool SyncCache(
      Guid authToken,
      Guid typeUid,
      DateTime? fromDate,
      long[] data,
      string eqlQuery);

    /// <summary>Инкрементально обновить данные в кэше</summary>
    /// <param name="authToken">Токен авторизации</param>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <param name="fromDate">Дата начала интервала синхронизации</param>
    /// <param name="updated">Обновленные\добавленные в кэш</param>
    /// <param name="deleted">Удаленные из кэша</param>
    /// <param name="eqlQuery">Запрос EQL, по которому построен кэш</param>
    /// <returns><c>true</c>, если обновление было успешно</returns>
    bool UpdateCache(
      Guid authToken,
      Guid typeUid,
      DateTime? fromDate,
      long[] updated,
      long[] deleted,
      string eqlQuery);
  }
}
