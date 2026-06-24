// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.IContinuedImportState
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Интерфейс для состояния импорта</summary>
  public interface IContinuedImportState
  {
    /// <summary>Список настроек для импорта</summary>
    IReadOnlyCollection<IConfigImportSettings> SettingsList { get; }

    /// <summary>Начальное количество настроек импорта</summary>
    int InitialSettingsCount { get; }
  }
}
