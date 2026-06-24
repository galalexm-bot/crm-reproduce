// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IEmailFormat
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Notifications;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Формат email-сообщения</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IEmailFormat
  {
    string Name { get; }

    string DisplayName { get; }

    string SubjectPrefix { get; }

    IEnumerable<Pair<INotificationFlow, IMessageChannel>> AllowPairs { get; }

    void Prepare(IMessage message);
  }
}
