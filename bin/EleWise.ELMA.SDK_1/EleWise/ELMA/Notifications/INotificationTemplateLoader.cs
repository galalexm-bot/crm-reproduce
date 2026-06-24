// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.INotificationTemplateLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections.Generic;

namespace EleWise.ELMA.Notifications
{
  /// <summary>Загрузчик шаблонов оповещений</summary>
  [ExtensionPoint(ComponentType.WebServer)]
  public interface INotificationTemplateLoader
  {
    /// <summary>
    /// Получить шаблоны, которые могут быть использованы для указанного оповещения.
    /// </summary>
    /// <param name="notification">Оповещение.</param>
    /// <returns>Список шаблонов</returns>
    IEnumerable<INotificationTemplate> GetTemplates(INotification notification);

    /// <summary>
    /// Получить частичные шаблоны оповещений для зоны расширения в шаблоне
    /// </summary>
    /// <param name="zone">Имя зоны расширения</param>
    /// <returns>Список частичных шаблонов</returns>
    IEnumerable<INotificationPartialTemplate> GetExtensionTemplates(string zone);
  }
}
