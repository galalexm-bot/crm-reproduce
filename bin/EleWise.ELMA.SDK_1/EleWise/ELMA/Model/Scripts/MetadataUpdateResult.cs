// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.MetadataUpdateResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts
{
  /// <inheritdoc />
  internal sealed class MetadataUpdateResult : IMetadataUpdateResult
  {
    /// <summary>Ctor</summary>
    /// <param name="metadata">Обновлённые метаданные</param>
    /// <param name="scriptModules">Обновлённые модули сценариев</param>
    /// <param name="entities">Обновлённые сущности</param>
    public MetadataUpdateResult(
      IMetadata metadata,
      IList<ScriptModule> scriptModules,
      IList<IEntity> entities)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Metadata = metadata;
      this.ScriptModules = scriptModules;
      this.Entities = entities;
    }

    /// <inheritdoc />
    public IMetadata Metadata { get; }

    /// <inheritdoc />
    public IList<ScriptModule> ScriptModules { get; }

    /// <inheritdoc />
    public IList<IEntity> Entities { get; }
  }
}
