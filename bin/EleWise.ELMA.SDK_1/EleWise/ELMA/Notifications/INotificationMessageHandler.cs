// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.INotificationMessageHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Notifications
{
  /// <summary>
  /// Обработчик действий, связанных с отправкой нотификации
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface INotificationMessageHandler : IEventHandler
  {
    /// <summary>
    /// Обработать нотификацию <paramref name="notification" /> и установить нужные данные в сообщении <paramref name="message" />
    /// </summary>
    /// <param name="notification">Системная нотификация</param>
    /// <param name="message">Сообщение, готовое для отправки по каналам рассылки</param>
    void ProcessNotificationToMessage(INotification notification, IMessage message);
  }
}
