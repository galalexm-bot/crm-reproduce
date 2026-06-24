// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Models.IExportCheckingResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Export.Enums;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export.Models
{
  /// <summary>Результат проверки экспорта</summary>
  public interface IExportCheckingResult
  {
    /// <summary>Сообщения</summary>
    IReadOnlyCollection<ExportCheckingMessage> Messages { get; }

    /// <summary>Добавить сообщение</summary>
    /// <param name="type">Тип сообщения</param>
    /// <param name="text">Текст сообщения</param>
    void AddMessage(ExportCheckingMessageType type, string text);

    /// <summary>Добавить сообщение</summary>
    /// <param name="type">Тип сообщения</param>
    /// <param name="text">Текст сообщения</param>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    void AddMessage(ExportCheckingMessageType type, string text, Guid uid);

    /// <summary>Добавить сообщение</summary>
    /// <param name="message">Сообщение</param>
    void AddMessage(ExportCheckingMessage message);

    /// <summary>Добавить сообщения</summary>
    /// <param name="messages">Сообщения</param>
    void AddMessages(IEnumerable<ExportCheckingMessage> messages);
  }
}
