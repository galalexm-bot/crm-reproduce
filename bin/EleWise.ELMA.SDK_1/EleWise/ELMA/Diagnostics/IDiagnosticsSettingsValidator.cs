// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.IDiagnosticsSettingsValidator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Интерфейс для проверки настроек диагностики</summary>
  public interface IDiagnosticsSettingsValidator
  {
    /// <summary>Проверить настройки</summary>
    /// <param name="settings">Настройки</param>
    void ValidateSettings(EventProcessorsInfo settings);
  }
}
