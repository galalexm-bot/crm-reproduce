// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.FeatureFlags.Components.IUIRuntimeVersionChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.UI.FeatureFlags.Components
{
  /// <summary>
  /// Точка расширения для поиска версий рантайма в частях системы
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IUIRuntimeVersionChecker
  {
    /// <summary>Проверить версию рантайма</summary>
    /// <returns></returns>
    RuntimeVersion CheckRuntimeVersion();
  }
}
