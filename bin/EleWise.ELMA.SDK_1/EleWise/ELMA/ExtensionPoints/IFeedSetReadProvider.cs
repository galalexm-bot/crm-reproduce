// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IFeedSetReadProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Провайдер для установки сообщениям флага "Прочитано"</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IFeedSetReadProvider
  {
    /// <summary>
    /// Отметить все сообщения по указанному объекту, как прочитанные.
    /// </summary>
    /// <param name="objectUid">Идентификатор типа объекта.</param>
    /// <param name="objectId">Идентификатор объекта.</param>
    /// <param name="recipientId">Идентификатор получателя.</param>
    void SetAsReadForObject(Guid objectUid, long objectId, long? recipientId = null);
  }
}
