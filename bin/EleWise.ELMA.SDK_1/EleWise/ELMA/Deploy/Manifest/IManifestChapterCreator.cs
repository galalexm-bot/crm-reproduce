// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Manifest.IManifestChapterCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;

namespace EleWise.ELMA.Deploy.Manifest
{
  /// <summary>Формирование манифеста при экспорте</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IManifestChapterCreator
  {
    /// <summary>Добавить что то в манифест или убрать</summary>
    /// <param name="settings"></param>
    /// <param name="desc"></param>
    void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc);
  }
}
