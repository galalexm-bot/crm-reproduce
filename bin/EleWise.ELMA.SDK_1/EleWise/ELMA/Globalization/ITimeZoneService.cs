// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.ITimeZoneService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;
using System;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Интерфейс сервиса для работы с часовыми поясами</summary>
  public interface ITimeZoneService
  {
    /// <summary>Часовой пояс текущего пользователя в ключевой локали</summary>
    TimeZoneModel CurrentUserTimeZone { get; }

    /// <summary>
    /// Получить блокированное смещение часового пояса текущего пользователя
    /// </summary>
    /// <returns></returns>
    long? GetBlockedTimeZoneOffset();

    /// <summary>Получить часовой пояс пользователя</summary>
    /// <param name="user">EleWise.ELMA.Security.IUser</param>
    /// <returns></returns>
    TimeZoneModel GetUserTimeZone(IUser user);

    /// <summary>
    /// Использовать методы расширения <see cref="M:EleWise.ELMA.TZ.ToClientDateTime(System.DateTime,EleWise.ELMA.TZSettings)" />
    /// </summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <param name="settings">Настройки преобразования</param>
    /// <returns>Пользовательское время</returns>
    DateTime ToClientDateTime(DateTime runtimeDateTime, TZSettings settings = null);

    /// <summary>
    /// Использовать методы расширения <see cref="M:EleWise.ELMA.TZ.ToRuntimeDateTimeFromServer(System.DateTime)" />
    /// </summary>
    /// <param name="clientDateTime">Пользовательское время</param>
    /// <param name="settings">Настройки преобразования</param>
    /// <returns>Локальное время</returns>
    DateTime ToRuntimeDateTimeFromClient(DateTime clientDateTime, TZSettings settings = null);
  }
}
