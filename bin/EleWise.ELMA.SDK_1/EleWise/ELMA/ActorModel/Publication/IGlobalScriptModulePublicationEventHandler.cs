// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.IGlobalScriptModulePublicationEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>
  /// Событие публикации глобального модуля <see cref="T:EleWise.ELMA.Model.Scripts.IGlobalScriptModule" />
  /// </summary>
  internal interface IGlobalScriptModulePublicationEventHandler : IEventHandler
  {
    /// <summary>Публикация завершена</summary>
    /// <param name="globalScriptModuleId">Идентификатор глобального модуля</param>
    Task Complete(long globalScriptModuleId);

    /// <summary>Публикация завершена с ошибкой</summary>
    /// <param name="globalScriptModuleId">Идентификатор глобального модуля</param>
    /// <param name="exception">Ошибка публикации</param>
    Task Error(long globalScriptModuleId, Exception exception);
  }
}
