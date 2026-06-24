// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IConfigurationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Интерфейс сервиса конфигурирования приложения ELMA.
  /// Компоненты, реализующие данную точку расширения, могут быть доступны в дизайнере при удаленном подключении к серверу.
  /// </summary>
  [ExtensionPoint(false, ComponentType.WebServer, ServiceScope.Application)]
  public interface IConfigurationService
  {
  }
}
