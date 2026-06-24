// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Starting.IServerStartEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using System;

namespace EleWise.ELMA.ActorModel.Starting
{
  /// <summary>Событие возможности запуска сервера</summary>
  internal interface IServerStartEventHandler : IEventHandler
  {
    /// <summary>Запустить сервер</summary>
    /// <param name="clusterVersion">Версия кластера</param>
    void StartServer(Version clusterVersion);
  }
}
