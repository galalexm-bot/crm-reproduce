// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.NHCacheWrapper.INHCacheWrapperSynchronizer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.NHCacheWrapper
{
  /// <summary>Актор синхронизации включенного кэша NHibernate</summary>
  internal interface INHCacheWrapperSynchronizer : IServerPlacementActor, IActorWithGuidKey, IActor
  {
    /// <summary>Включить кэш для регионов</summary>
    /// <param name="regions">Регионы</param>
    Task EnableCache(IList<string> regions);

    /// <summary>Выключить кэш для регионов</summary>
    /// <param name="regions">Регионы</param>
    Task DisableCache(IList<string> regions);
  }
}
