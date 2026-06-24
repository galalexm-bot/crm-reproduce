// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.ComponentDependenciesExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Реализация точки расширения работы с зависимостями для компонентов
  /// </summary>
  [Component]
  internal sealed class ComponentDependenciesExtension : IDependenciesExtension
  {
    /// <summary>Менеджер заголовка метаданных</summary>
    private readonly IEntityManager<ComponentMetadataItemHeader, long> componentMetadataItemManager;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemManager">Менеджер заголовков метаданных компонентов</param>
    public ComponentDependenciesExtension(
      IEntityManager<ComponentMetadataItemHeader, long> componentMetadataItemManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.componentMetadataItemManager = componentMetadataItemManager;
    }

    /// <inheritdoc />
    public IEnumerable<IDependencyContainer> GetDependencyContainers(Guid uid)
    {
      List<IDependencyContainer> dependencyContainers = new List<IDependencyContainer>();
      ComponentMetadataItemHeader metadataItemHeader = this.componentMetadataItemManager.LoadOrNull(uid);
      ComponentMetadata metadata;
      if (metadataItemHeader?.Draft != null)
      {
        metadata = metadataItemHeader.Draft.Metadata as ComponentMetadata;
      }
      else
      {
        if (metadataItemHeader?.Published == null)
          return (IEnumerable<IDependencyContainer>) dependencyContainers;
        metadata = metadataItemHeader.Published.Metadata as ComponentMetadata;
      }
      if (metadata != null)
      {
        ComponentDependencyContainer dependencyContainer = new ComponentDependencyContainer();
        dependencyContainer.ComponentDependencies.AddRange((IEnumerable<ComponentDependency>) metadata.ComponentDependencies);
        dependencyContainer.EntityDependencies.AddRange((IEnumerable<EntityDependency>) metadata.EntityDependencies);
        dependencyContainer.EnumDependencies.AddRange((IEnumerable<EnumDependency>) metadata.EnumDependencies);
        dependencyContainer.DataClassDependencies.AddRange((IEnumerable<DataClassDependency>) metadata.DataClassDependencies);
        dependencyContainer.FunctionDependencies.AddRange((IEnumerable<FunctionDependency>) metadata.FunctionDependencies);
        dependencyContainers.Add((IDependencyContainer) dependencyContainer);
      }
      return (IEnumerable<IDependencyContainer>) dependencyContainers;
    }
  }
}
