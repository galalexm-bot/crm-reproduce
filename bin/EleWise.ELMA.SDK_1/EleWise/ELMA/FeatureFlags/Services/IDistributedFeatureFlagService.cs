// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.Services.IDistributedFeatureFlagService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.FeatureFlags.Services
{
  /// <summary>Распределенный сервис флагов функций</summary>
  public interface IDistributedFeatureFlagService
  {
    /// <summary>Доступные сервера</summary>
    IEnumerable<Guid> AvailableServers { get; }

    /// <summary>Получить состояние флага</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <param name="name">Имя флага</param>
    /// <param name="defaultEnabled">Состояние флага по умолчанию</param>
    /// <returns>Состояние флага</returns>
    Task<bool> Enabled(Guid serverUid, string name, bool defaultEnabled);
  }
}
