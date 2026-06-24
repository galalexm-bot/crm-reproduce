// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.INotificationRecipientTypeHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System.Collections.Generic;

namespace EleWise.ELMA.Notifications
{
  /// <summary>
  /// Обработчик типа получателя сообщения (например: Пользователь, Группа, Список пользователей и т.д.)
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-812.html">Пример реализации в базе знаний</see> <br />
  /// <see href="http://www.elma-bpm.ru/kb/article-814.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ComponentType.WebServer)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface INotificationRecipientTypeHandler
  {
    /// <summary>
    /// Имя типа получателя сообщения (соответствует имени в шаблоне)
    /// </summary>
    string Name { get; }

    /// <summary>Получить список получателей (пользователей)</summary>
    /// <param name="value">Значение</param>
    /// <returns>Список получателей (пользователей)</returns>
    IEnumerable<object> GetRecipients(object value);
  }
}
