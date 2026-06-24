// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.ISessionsContainerProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Провайдер контейнера сессий</summary>
  public interface ISessionsContainerProvider
  {
    /// <summary>Получить контейнеры сессий</summary>
    IDictionary<Guid, ISessionsContainer> GetSessionsContainers();
  }
}
