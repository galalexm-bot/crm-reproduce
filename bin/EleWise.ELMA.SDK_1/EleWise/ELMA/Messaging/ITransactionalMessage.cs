// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.ITransactionalMessage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Messaging
{
  /// <summary>
  /// Сообщение, которое будет отправлено только в случае успешного завершения транзакции.
  /// Класс, реализующий данный интерфейс, должен быть XML-сериализуемым.
  /// </summary>
  /// <remarks>
  /// Сообщения данного типа отправляются в фоновом режиме после завершения транзации.
  /// </remarks>
  public interface ITransactionalMessage : IMessageBase
  {
  }
}
