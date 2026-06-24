// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.ObjectFormViewItemAnalyzer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Dependencies.Analyzers
{
  /// <summary>
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.ObjectFormViewItem" />
  /// </summary>
  internal class ObjectFormViewItemAnalyzer : BaseViewItemAnalyzer<ObjectFormViewItem>
  {
    internal static ObjectFormViewItemAnalyzer ybUYvqhR0DY8KPCwwG9Y;

    /// <inheritdoc />
    protected override DependencyAnalysisResult ProcessViewItems(
      IEnumerable<ObjectFormViewItem> viewItems,
      ClassMetadata contextMetadata,
      IMetadata metadata,
      DependencyServiceOptions options)
    {
      Guid moduleUid = contextMetadata.ModuleUid;
      Dictionary<Guid, EnumDependency> enumDependencies = new Dictionary<Guid, EnumDependency>();
      Dictionary<Guid, EntityDependency> entityDependencies = new Dictionary<Guid, EntityDependency>();
      Dictionary<Guid, DataClassDependency> dataClassDependencies = new Dictionary<Guid, DataClassDependency>();
      foreach (ObjectFormViewItem viewItem in viewItems)
      {
        switch (viewItem.PropertyParents.Count)
        {
          case 0:
            ViewItemsAnalyzerHelper.CaseZeroPropertyParents(viewItem.ContextPropertyUid, contextMetadata, options, enumDependencies, entityDependencies, dataClassDependencies);
            continue;
          case 1:
            ViewItemsAnalyzerHelper.CaseOnePropertyParents(viewItem.ContextPropertyUid, viewItem.PropertyParents.ToArray(), contextMetadata, options, enumDependencies, entityDependencies, dataClassDependencies);
            continue;
          default:
            ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(viewItem.ContextPropertyUid, viewItem.PropertyParents.ToArray(), contextMetadata, options, enumDependencies, entityDependencies, dataClassDependencies);
            continue;
        }
      }
      return new DependencyAnalysisResult()
      {
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>(),
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dataClassDependencies.Values.ToList<DataClassDependency>()
      };
    }

    public ObjectFormViewItemAnalyzer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool YlfSmGhRm5ewJsHBuX4X() => ObjectFormViewItemAnalyzer.ybUYvqhR0DY8KPCwwG9Y == null;

    internal static ObjectFormViewItemAnalyzer t6SnYkhRy9LJ3xc8Ayrg() => ObjectFormViewItemAnalyzer.ybUYvqhR0DY8KPCwwG9Y;
  }
}
