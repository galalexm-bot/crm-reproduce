// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.IModelAssemblyBuilderHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Точка расширения, реагирующая на построение динамических сборок
  /// </summary>
  public interface IModelAssemblyBuilderHandler : IEventHandler
  {
    /// <summary>Событие после построения сборки ConfigurationModel</summary>
    /// <param name="publishMetadataList">Список метаданных, публикуемых для конфигурации</param>
    void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> publishMetadataList);

    /// <summary>Событие после построения сборки DynamicModel</summary>
    /// <param name="systemMetadata">Список построенных метаданных DynamicModel</param>
    void DynamicModelAssemblyBuilt(IEnumerable<EntityMetadata> systemMetadata);

    /// <summary>Событие после построения всех динамических сборок</summary>
    /// <param name="publishMetadataList">Список метаданных, публикуемых для конфигурации</param>
    /// <param name="scriptModules">Список модулей серверных скриптов</param>
    /// <param name="clientScriptModules">Список модулей клиентских скриптов</param>
    void AfterAll(
      IEnumerable<AbstractMetadata> publishMetadataList,
      IEnumerable<ScriptModule> scriptModules,
      IEnumerable<ScriptModule> clientScriptModules);
  }
}
