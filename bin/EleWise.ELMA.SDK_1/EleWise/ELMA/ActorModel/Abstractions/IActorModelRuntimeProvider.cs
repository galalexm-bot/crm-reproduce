// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Abstractions.IActorModelRuntimeProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ActorModel.Abstractions
{
  /// <summary>Провайдер среды Actor Model</summary>
  public interface IActorModelRuntimeProvider : 
    IActorModelRuntime,
    IProvider,
    IConfigurableProvider,
    IDisposable
  {
    /// <summary>Идентификатор подключения локального сервера</summary>
    Guid LocalConnection { get; }

    /// <summary>
    /// Идентификаторы всех активных подключений серверов кластера
    /// </summary>
    IEnumerable<Guid> ActiveConnections { get; }
  }
}
