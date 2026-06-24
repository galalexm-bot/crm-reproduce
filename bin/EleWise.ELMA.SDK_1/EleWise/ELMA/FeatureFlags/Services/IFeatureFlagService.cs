// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.Services.IFeatureFlagService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.FeatureFlags.Services
{
  /// <summary>Сервис флагов функций</summary>
  public interface IFeatureFlagService
  {
    /// <summary>Получить состояние флага</summary>
    /// <param name="name">Имя флага</param>
    /// <param name="defaultEnabled">Состояние флага по умолчанию</param>
    /// <returns>Состояние флага</returns>
    bool Enabled(string name, bool defaultEnabled);
  }
}
