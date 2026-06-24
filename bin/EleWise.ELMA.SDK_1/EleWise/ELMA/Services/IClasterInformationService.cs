// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IClasterInformationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Интерфейс сервиса, предоставляющего информацию о серверах в кластере
  /// </summary>
  public interface IClasterInformationService
  {
    /// <summary>Получить статус сервера в кластере</summary>
    /// <param name="serverConnectionUid">Уникальный идентификатор подключения сервера</param>
    /// <returns>Статус подключения сервера</returns>
    Task<DbConnectionStatus> GetStatus(Guid serverConnectionUid);
  }
}
