// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.FeatureFlags.IFeatureFlagActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.FeatureFlags
{
  /// <summary>Актор для работы с флагами функций в рамках кластера</summary>
  internal interface IFeatureFlagActor : IServerPlacementActor, IActorWithGuidKey, IActor
  {
    /// <summary>Получить состояние флага</summary>
    /// <param name="featureFlagName">Название флага функций</param>
    /// <returns>Состояние флага, или <see langword="null" />, если не задано значение</returns>
    Task<bool?> Enabled(string featureFlagName);

    /// <summary>Обновить кэш состояний флагов на сервере</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <param name="featureFlags">Состояния флагов</param>
    Task UpdateCache(Guid serverUid, IDictionary<string, bool?> featureFlags);
  }
}
