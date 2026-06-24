// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IActorContextManagementService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.ComponentModel;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис управления контекстом исполнения в акторе</summary>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface IActorContextManagementService : IActorContextService
  {
    /// <summary>Получить контекст</summary>
    /// <returns>Контекст</returns>
    IDictionary<string, object> Get();

    /// <summary>Добавить в контекст</summary>
    /// <param name="incomingContext">Контекст</param>
    /// <remarks>
    /// В качестве контекста следует передавать только сериализуемые провайдером актора объекты.
    /// </remarks>
    void Set(IDictionary<string, object> incomingContext);
  }
}
