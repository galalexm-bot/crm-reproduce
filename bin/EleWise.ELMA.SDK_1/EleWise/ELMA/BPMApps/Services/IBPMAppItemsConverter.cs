// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.IBPMAppItemsConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;

namespace EleWise.ELMA.BPMApps.Services
{
  /// <summary>
  /// Точка расширения конвертации манифеста и настроек экспорта
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IBPMAppItemsConverter
  {
    /// <summary>Конвертировать настройки экспорта в манифест</summary>
    void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest);

    /// <summary>Конвертировать манифест в настройки экспорта</summary>
    void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings);
  }
}
