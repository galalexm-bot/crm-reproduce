// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.GridViewItemsAnalyzer
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
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.IDynamicViewItem" />
  /// </summary>
  internal class GridViewItemsAnalyzer : BaseViewItemAnalyzer<GridViewItem>
  {
    private static GridViewItemsAnalyzer hX05cAhqFwZ423Uh93ue;

    /// <inheritdoc />
    protected override DependencyAnalysisResult ProcessViewItems(
      IEnumerable<GridViewItem> viewItems,
      ClassMetadata contextMetadata,
      IMetadata metadata,
      DependencyServiceOptions options)
    {
      Guid moduleUid = contextMetadata.ModuleUid;
      Dictionary<Guid, EnumDependency> enumDependencies = new Dictionary<Guid, EnumDependency>();
      Dictionary<Guid, EntityDependency> entityDependencies = new Dictionary<Guid, EntityDependency>();
      Dictionary<Guid, DataClassDependency> dataClassDependencies = new Dictionary<Guid, DataClassDependency>();
      foreach (GridViewItem viewItem in viewItems)
      {
        Guid entityUid = viewItem.EntityUid;
        if (!(entityUid == Guid.Empty) && MetadataServiceContext.Service.GetMetadata(entityUid) is ClassMetadata metadata1)
          DependencyServiceHelper.ProcessMetadata(moduleUid, (IMetadata) metadata1, options, enumDependencies, entityDependencies, dataClassDependencies);
      }
      return new DependencyAnalysisResult()
      {
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>(),
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dataClassDependencies.Values.ToList<DataClassDependency>()
      };
    }

    public GridViewItemsAnalyzer()
    {
      GridViewItemsAnalyzer.cn8cW2hqo14PMQbwrxW6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void cn8cW2hqo14PMQbwrxW6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool KlceflhqBm9xSCMAS0eg() => GridViewItemsAnalyzer.hX05cAhqFwZ423Uh93ue == null;

    internal static GridViewItemsAnalyzer JfCyB3hqWh1EyPhDE5bj() => GridViewItemsAnalyzer.hX05cAhqFwZ423Uh93ue;
  }
}
