// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.INotificationTemplateDataSource
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications.Impl;
using System.Collections.Generic;

namespace EleWise.ELMA.Notifications
{
  /// <summary>
  /// Источник данных шаблонов оповещений. Используется стандартным загрузчиком при старте приложения.
  /// </summary>
  [ExtensionPoint(ComponentType.WebServer)]
  public interface INotificationTemplateDataSource
  {
    /// <summary>
    /// Получить список с информацией о файлах шаблонов оповещения
    /// </summary>
    /// <returns>Список с информацией о файлах шаблонов оповещения</returns>
    IEnumerable<NotificationTemplateFileInfo> GetFiles();
  }
}
