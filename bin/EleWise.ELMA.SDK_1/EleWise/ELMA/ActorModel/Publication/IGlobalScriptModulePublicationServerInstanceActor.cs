// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.IGlobalScriptModulePublicationServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>
  /// Интерфейс актора экземпляра сервера (для публикации глобальных модулей <see cref="T:EleWise.ELMA.Model.Scripts.IGlobalScriptModule" />)
  /// </summary>
  internal interface IGlobalScriptModulePublicationServerInstanceActor : 
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    /// <summary>Публикация завершена</summary>
    /// <param name="globalScriptModuleId">Идентификатор глобального модуля</param>
    Task PublicationSuccess(long globalScriptModuleId);

    /// <summary>Публикация завершена с ошибкой</summary>
    /// <param name="globalScriptModuleId">Идентификатор глобального модуля</param>
    /// <param name="exception">Ошибка публикации</param>
    Task PublicationError(long globalScriptModuleId, Exception exception);
  }
}
