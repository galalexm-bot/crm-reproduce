// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IServerInfoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Modules;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Менеджер, предоставляющий информацию о сервере ELMA (Runtime-части). Используется в дизайнере ELMA.
  /// </summary>
  public interface IServerInfoManager : IConfigurationService
  {
    /// <summary>
    /// Получить информацию с хэш-кодами о бинарных файлах на сервере
    /// </summary>
    /// <returns>Информация о загруженных сборках</returns>
    AssemblyHashInfo[] GetBinaryHashInfos();

    /// <summary>Получить содержимое файла</summary>
    /// <param name="assemblyName">Имя бинарного файла</param>
    /// <returns>Содержимое файла</returns>
    byte[] GetAssemblyRaw(string assemblyName);

    /// <summary>Получить тип основного провайдера</summary>
    /// <returns></returns>
    string GetMainProviderType();

    /// <summary>Получить название редакции</summary>
    /// <returns></returns>
    string GetEdition();

    /// <summary>Получить информацию о статусах модулей</summary>
    /// <returns></returns>
    ModuleStatusInfo[] GetModuleStatuses();
  }
}
