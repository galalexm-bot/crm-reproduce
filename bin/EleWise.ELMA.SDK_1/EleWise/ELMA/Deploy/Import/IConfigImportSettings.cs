// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.IConfigImportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Настройки кастомного импорта</summary>
  public interface IConfigImportSettings : IImportSettings
  {
    /// <summary>Имя временного файла на сервере (uid)</summary>
    string FileName { get; set; }

    /// <summary>Манифест компонента</summary>
    ElmaStoreComponentManifest Manifest { get; set; }

    /// <summary>
    /// Фальшивый манифест, используемый при отсутствии настоящего
    /// </summary>
    BPMAppFakeManifest FakeManifest { get; }
  }
}
