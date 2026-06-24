// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IWebHostEnvironmentManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Менеджер для работы с хостом веб-сервера</summary>
  public interface IWebHostEnvironmentManager : IConfigurationService
  {
    /// <summary>Перезапустить хост</summary>
    void RestartHost();

    /// <summary>
    /// Получить уникальный идентификатор для сессии запуска данного хоста
    /// </summary>
    /// <returns></returns>
    Guid GetHostSessionUid();
  }
}
