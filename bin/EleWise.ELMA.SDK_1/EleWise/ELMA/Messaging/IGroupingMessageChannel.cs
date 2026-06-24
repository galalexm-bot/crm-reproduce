// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.IGroupingMessageChannel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;
using System.Collections.Generic;

namespace EleWise.ELMA.Messaging
{
  /// <summary>
  /// Интерфейс означает, что данный канал поддерживает рассылку сообщения с несколькими получателями
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-784.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IGroupingMessageChannel : IMessageChannel
  {
    /// <summary>Отправить сообщение сразу нескольким получателям</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="recipients">Список пользователей - получателей сообщения</param>
    void Send(IMessage message, IEnumerable<IUser> recipients);
  }
}
