// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.ExtensionPoints.IFeatureFlagProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FeatureFlags.ExtensionPoints
{
  /// <summary>Точка расширения провайдеров флагов функций</summary>
  [ExtensionPoint(ComponentType.All)]
  internal interface IFeatureFlagProvider
  {
    /// <summary>Получить флаги функций</summary>
    /// <param name="featureFlagNames">Имена флагов функций</param>
    /// <returns>Значения флагов  функций</returns>
    IEnumerable<(string featureFlagName, bool enabled)> GetFlags(
      IEnumerable<string> featureFlagNames);

    /// <summary>Состояния флагов функций изменились</summary>
    event EventHandler FlagsChanged;
  }
}
