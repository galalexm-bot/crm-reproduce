// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.INotificationFlowObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Notifications
{
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface INotificationFlowObject
  {
    bool Can(Guid flowUid);

    IDictionary<Guid, Guid[]> Get();
  }
}
