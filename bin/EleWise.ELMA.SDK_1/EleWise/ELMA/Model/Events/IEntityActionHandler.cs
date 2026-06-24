// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.IEntityActionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Events
{
  /// <summary>Обработчик действий с сущностью</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IEntityActionHandler : IEventHandler
  {
    /// <summary>После выполнения действия</summary>
    /// <param name="e">Параметры события</param>
    void ActionExecuted(EntityActionEventArgs e);
  }
}
