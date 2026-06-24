// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.TemplateGenerator.INotificationFunctions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator
{
  /// <summary>
  /// Точка расширения для создания собственных функций в шаблонах оповещения
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-811.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ComponentType.All)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface INotificationFunctions
  {
  }
}
