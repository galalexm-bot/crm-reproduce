// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.IImportExecutorActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Интерфейс актора выполнения импорта</summary>
  internal interface IImportExecutorActor : IActorWithGuidKey, IActor
  {
    /// <summary>Запустить импорт</summary>
    /// <param name="settings">Настройки импорта</param>
    Task Import(IImportSettings settings);

    /// <summary>Получить новые системные сообщения</summary>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(int offset, int count);

    /// <summary>Получить новые сообщения лога</summary>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<DeployLogMessage>> GetLog(int offset, int count);

    /// <summary>Получить последние сообщения лога</summary>
    /// <param name="count">Количество последних сообщений</param>
    Task<IEnumerable<DeployLogMessage>> GetLastLog(int count);

    /// <summary>
    /// Проверка, запущена ли сессия импорта, либо есть незавершенный продолжаемый импорт
    /// </summary>
    Task<bool> IsActive();

    /// <summary>Запустить продолжаемый импорт</summary>
    /// <param name="settings">Список настроек импорта</param>
    /// <returns>Идентификатор сессии импорта</returns>
    Task ContinuedImport(IEnumerable<IConfigImportSettings> settings);

    /// <summary>Продолжить после рестарта</summary>
    Task ContinueImport();

    /// <summary>
    /// Получить список <see cref="T:EleWise.ELMA.BPMApps.BPMAppFakeManifest" />
    /// </summary>
    Task<IEnumerable<BPMAppFakeManifest>> GetFakeManifests();

    /// <summary>Получить состояние импорта</summary>
    /// <returns></returns>
    Task<IContinuedImportState> GetImportState();
  }
}
