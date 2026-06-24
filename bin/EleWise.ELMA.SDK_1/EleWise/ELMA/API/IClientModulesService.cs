// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.IClientModulesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.API
{
  /// <summary>
  /// Интерфейс сервиса работы с модулями сессии внешних приложений
  /// </summary>
  public interface IClientModulesService
  {
    /// <summary>Получить информацию о модулях по токену сессии.</summary>
    /// <param name="sessionToken">Токен сессии</param>
    /// <returns>Информация о модулях или <c>null</c></returns>
    IClientSessionDataSets GetSessionModules(string sessionToken);

    /// <summary>Обновить список наборов данных для сессии</summary>
    /// <param name="sessionToken">Токен клиентской сессии</param>
    /// <param name="dataSets">Список наборов данных</param>
    /// <returns></returns>
    bool UpdateDataSets(string sessionToken, List<Guid> dataSets);
  }
}
