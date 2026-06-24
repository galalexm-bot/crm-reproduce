// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.IMetadataImport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Интерфейс точки расширения обработки метаданных при импорте
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IMetadataImport
  {
    /// <summary>
    /// Создание фальшифого раздела метаданных дерева импортируемых объектов
    /// </summary>
    void CreateFakeChapter(
      NamedMetadata namedMd,
      BPMAppFakeManifest fakeManifest,
      BPMAppManifest manifest);

    /// <summary>
    /// Объединение настроек импортируемых и имеющихся метаданных
    /// </summary>
    void MergeMetadataSettings(
      NamedMetadata mdBase,
      NamedMetadata mdImported,
      Dictionary<string, string> serviceData);
  }
}
