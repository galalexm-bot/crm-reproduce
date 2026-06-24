// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.IActionInvokerProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Actions
{
  /// <summary>Точка расширения для провайдера действий с объектами</summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IActionInvokerProvider
  {
    /// <summary>Получить весь список действий</summary>
    /// <returns>Список действий</returns>
    IEnumerable<IActionInvoker> GetInvokers();

    /// <summary>
    /// Получить действие по идентификаторам объекта и типа действия
    /// </summary>
    /// <param name="actionObjectUid">Идентификатор объекта для действия</param>
    /// <param name="actionTypeUid">Идентификатор типа действия</param>
    /// <returns>Экземпляр исполнителя действия, либо <c>null</c>, если не найден</returns>
    IActionInvoker GetInvoker(Guid actionObjectUid, Guid actionTypeUid);
  }
}
