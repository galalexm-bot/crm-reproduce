// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Интерфейс провайдера приложения</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IProvider : IConfigurableProvider, IDisposable
  {
    /// <summary>Uid провайдера</summary>
    Guid Uid { get; }

    /// <summary>Имя СУБД</summary>
    string Name { get; }

    /// <summary>Создать объект настроек</summary>
    /// <returns>Объект настроек</returns>
    ProviderSettingsSection CreateSettings();

    /// <summary>
    /// Начать инициализацию.
    /// Доступен <see cref="P:EleWise.ELMA.ComponentModel.ComponentManager.Current" /> и <see cref="P:EleWise.ELMA.ComponentModel.ComponentManager.Builder" />
    /// </summary>
    void Init();

    /// <summary>
    /// Завершить инициализацию (вызывается после инициализации <see cref="T:EleWise.ELMA.Services.Locator" />)
    /// </summary>
    void InitComplete();

    /// <summary>
    /// Синтаксис использования Guid для провайдера авторизации
    /// </summary>
    /// <param name="guid"></param>
    /// <returns></returns>
    string GuidQuerySintaxis(Guid guid);
  }
}
