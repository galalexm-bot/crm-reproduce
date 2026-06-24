// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.Messages.MessageType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Files.Previews.Messages
{
  /// <summary>Тип сообщения отправляемого очередь</summary>
  public enum MessageType
  {
    /// <summary>Добавить сообщение в очередь</summary>
    Add = 1,
    /// <summary>Удалить сообщение из очереди</summary>
    Delete = 2,
    /// <summary>Ответ от внешнего сервиса</summary>
    Response = 3,
  }
}
