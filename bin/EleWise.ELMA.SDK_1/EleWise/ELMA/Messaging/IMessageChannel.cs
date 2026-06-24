// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.IMessageChannel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Messaging
{
  /// <summary>Канал отправки сообщений</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-784.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ComponentType.WebServer)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IMessageChannel
  {
    /// <summary>Уникальный идентификатор канала</summary>
    Guid Uid { get; }

    /// <summary>Имя канала</summary>
    string Name { get; }

    /// <summary>Имя для отображения</summary>
    string DisplayName { get; }

    /// <summary>Использовать по умолчанию</summary>
    bool Default { get; }

    /// <summary>Отправить сообщение</summary>
    /// <param name="message">Сообщение</param>
    void Send(IMessage message);
  }
}
