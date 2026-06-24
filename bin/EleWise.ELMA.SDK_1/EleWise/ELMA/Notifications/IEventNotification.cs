// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.IEventNotification
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Notifications
{
  /// <summary>Оповещение о событии</summary>
  public interface IEventNotification : INotification, IExtendedPropertiesContainer
  {
    /// <summary>Имя события</summary>
    string Event { get; }

    /// <summary>Объект события</summary>
    IAuditObject Object { get; }

    /// <summary>Действие события</summary>
    IAuditAction Action { get; }
  }
}
