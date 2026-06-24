// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.UIBuilderConstants
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Константы КИ</summary>
  public static class UIBuilderConstants
  {
    /// <summary>
    /// Имя ключа ContextVars, обозначающий текущий Runtime КИ
    /// </summary>
    public const string UIBuilderRuntime = "UIBuilderRuntime";
    /// <summary>
    /// Имя ключа ContextVars, обозначающий используемые модули
    /// </summary>
    public const string UIBuilderAdditionalModules = "UIBuilderAdditionalModules";
    /// <summary>
    /// Имя ключа ContextVars, обозначающий дополнительные модули
    /// </summary>
    public const string UIBuilderAdditionalRuntimeModules = "UIBuilderAdditionalRuntimeModules";
    /// <summary>
    /// Имя ключа ContextVars, обозначающий уже загруженные зависимости от сущностей
    /// </summary>
    public const string UIBuilderEntityDependencies = "UIBuilderEntityDependencies";
    /// <summary>
    /// Ключ значения фича-флага работы runtime версии 2 (с конструктором интерфейсов)
    /// </summary>
    public const string UIBuilderRuntimeVersion2EnabledFeatureFlagKey = "Ops_UIBuilder.RuntimeVersion2.Enabled";
  }
}
