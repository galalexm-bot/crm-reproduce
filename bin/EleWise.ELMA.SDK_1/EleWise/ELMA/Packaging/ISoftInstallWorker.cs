// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.ISoftInstallWorker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;
using System.IO;

namespace EleWise.ELMA.Packaging
{
  /// <summary>
  /// Интерфейс установщика компонентов, не требующих перезапуска сервера ("мягкий" установщик).
  /// </summary>
  [Obsolete("Интерфейс утратил актуальность - не используйте его", true)]
  public interface ISoftInstallWorker
  {
    /// <summary>Идентификатор установки/обновления компонентов.</summary>
    Guid UpdatingUid { get; }

    /// <summary>Вернуть признак завершённой установки.</summary>
    bool InstallationComplete { get; }

    /// <summary>
    /// Вернуть наличие ошибок в процедуре "мягкой" установки/обновления.
    /// </summary>
    bool HasErrors { get; }

    /// <summary>Состояние установки/обновления текущего компонента.</summary>
    ISoftInstallState CurrentInstallationStatus { get; }

    /// <summary>Полное состояние установки/обновления.</summary>
    IDictionary<string, ISoftInstallState> InstallationStatus { get; }

    /// <summary>Получить поток с содержимым журнала развёртывания.</summary>
    /// <returns>Поток с содержимым журнала развёртывания.</returns>
    Stream GetLog();

    /// <summary>Установить компоненты.</summary>
    /// <param name="componentsInfos">Устанавливаемые компоненты.</param>
    /// <param name="saveStatusToDb">Флаг необходимости сохранения состояния в БД.</param>
    /// <param name="notificationCallback">Делегат уведомления об изменениях.</param>
    void Install(
      IEnumerable<IStoreComponentInfo> componentsInfos,
      bool saveStatusToDb,
      SoftInstallWorkerNotificationCallback notificationCallback = null);
  }
}
