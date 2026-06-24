// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.IExportActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Export;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Интерфейс актора экспорта конфигурации</summary>
  internal interface IExportActor : IActorWithGuidKey, IActor
  {
    /// <summary>Запустить экспорт</summary>
    /// <param name="settings">Настройки экспорта</param>
    Task Export(ConfigExportSettings settings);

    /// <summary>Запустить экспорт с подписью файла конфигурации</summary>
    /// <param name="settings">Настройки экспорта</param>
    /// <param name="certificate">Сертификат</param>
    /// <param name="password">Пароль сертификата</param>
    Task Export(ConfigExportSettings settings, byte[] certificate, string password);

    /// <summary>Получить новые сообщения лога</summary>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<DeployLogMessage>> GetLog(int offset, int count);
  }
}
