// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.IPublicServiceEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>
  /// Точка расширения, позволяющая добавить события для действий публичного сервиса
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-795.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IPublicServiceEventHandler : IEventHandler
  {
    /// <summary>Перед выполнением действия</summary>
    /// <param name="e">Параметры события</param>
    void ActionExecuting(PublicServiceMethodEventArgs e);

    /// <summary>После выполнения действия</summary>
    /// <param name="e">Параметры события</param>
    void ActionExecuted(PublicServiceMethodEventArgs e);
  }
}
