// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.IEventBus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections;
using System.Collections.Generic;

namespace EleWise.ELMA.Events
{
  /// <summary>Шина событий</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IEventBus
  {
    /// <summary>Вызвать обработчики указанного события</summary>
    /// <param name="messageName">Имя события</param>
    /// <param name="eventData">Данные события</param>
    /// <returns>Результат обработки</returns>
    IEnumerable Notify(string messageName, IDictionary<string, object> eventData);
  }
}
