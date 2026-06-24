// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IModuleDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using System.Collections.Generic;

namespace EleWise.ELMA.Modules
{
  /// <summary>Работа с компонентами ElmaStore в дизайнера</summary>
  public interface IModuleDTOManager : IConfigurationService
  {
    /// <summary>Получить манифесты установленных компонентов</summary>
    /// <returns></returns>
    IEnumerable<ElmaStoreComponentManifest> GetInstalledComponentManifests();

    /// <summary>Получить пакеты компонента</summary>
    /// <param name="componentId"></param>
    /// <returns></returns>
    IEnumerable<PackageManifest> GetComponentPackages(string componentId);

    /// <summary>Получить манифест системного компонента</summary>
    /// <param name="id"></param>
    /// <param name="installed"></param>
    /// <returns></returns>
    ElmaStoreComponentManifest GetManifest(string id, out bool installed);
  }
}
