// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.IMessage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Messaging
{
  /// <summary>Сообщение</summary>
  public interface IMessage : IMessageBase
  {
    /// <summary>Получатель</summary>
    object Recipient { get; set; }

    /// <summary>Автор</summary>
    object Author { get; set; }

    /// <summary>Имя автора в виде текста</summary>
    string AuthorText { get; set; }

    /// <summary>Отправлять ли сообщение автору принудительно</summary>
    bool SendToAuthor { get; set; }

    /// <summary>Идентификатор объекта</summary>
    Guid? ObjectUid { get; set; }

    /// <summary>Идентификатор действия</summary>
    Guid? ActionUid { get; set; }

    /// <summary>Приоритет</summary>
    int Priority { get; set; }

    /// <summary>URL</summary>
    string URL { get; set; }

    /// <summary>Тема</summary>
    string Subject { get; set; }

    /// <summary>Короткое сообщение в виде текста</summary>
    string ShortMessageText { get; set; }

    /// <summary>Короткое сообщение в виде HTML</summary>
    string ShortMessageHtml { get; set; }

    /// <summary>Полное сообщение в виде текста</summary>
    string FullMessageText { get; set; }

    /// <summary>Полное сообщение в виде HTML</summary>
    string FullMessageHtml { get; set; }

    /// <summary>
    /// Идентификатор объекта, по которому отсылается сообщение
    /// </summary>
    string ObjectId { get; set; }

    /// <summary>
    /// Идентификаторы приложенных файлов.<para />
    /// Эти файлы будут отправлены по почте как вложения.<para />
    /// Можно отправить их одним архивом, установив <seealso cref="P:EleWise.ELMA.Messaging.IMessage.AttachmentsBySingleFile" /> в <c>true</c>
    /// </summary>
    string[] AttachmentIds { get; set; }

    /// <summary>
    /// Отсылать вложения указанные в <seealso cref="P:EleWise.ELMA.Messaging.IMessage.AttachmentIds" /> одним файлом
    /// </summary>
    bool AttachmentsBySingleFile { get; set; }

    /// <summary>
    /// Вложения приложенные к сообщению.<para />
    /// Используются для отображения конечного сообщения.
    /// </summary>
    MessageAttachment[] MessageAttachments { get; set; }

    /// <summary>Получить список получателей сообщения</summary>
    /// <returns>Список пользователей - получателей сообщения</returns>
    IEnumerable<IUser> GetRecipients();

    /// <summary>Отложенная отправка</summary>
    bool Delayed { get; set; }

    /// <summary>Список кастомных сообщений</summary>
    CustomMessage[] CustomMessages { get; set; }
  }
}
