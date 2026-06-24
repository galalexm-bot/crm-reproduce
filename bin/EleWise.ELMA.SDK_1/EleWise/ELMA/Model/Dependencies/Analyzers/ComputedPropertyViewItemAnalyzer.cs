// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.ComputedPropertyViewItemAnalyzer
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
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.ViewItem" />
  /// </summary>
  internal class ComputedPropertyViewItemAnalyzer : BaseViewItemAnalyzer<ViewItem>
  {
    private static ComputedPropertyViewItemAnalyzer FrOZhZhR3L1YcdBvuepf;

    /// <inheritdoc />
    protected override bool CheckViewItem(ViewItem viewItem) => viewItem.DynamicProperties.Any<ComputedValue>((Func<ComputedValue, bool>) (d => ComputedPropertyViewItemAnalyzer.\u003C\u003Ec.NGM9lcvoCvHJcbDMoYOT((object) d) == ComputedValueType.Property));

    /// <inheritdoc />
    protected override DependencyAnalysisResult ProcessViewItems(
      IEnumerable<ViewItem> viewItems,
      ClassMetadata contextMetadata,
      IMetadata metadata,
      DependencyServiceOptions options)
    {
      Guid moduleUid = contextMetadata.ModuleUid;
      Dictionary<Guid, EnumDependency> enumDependencies = new Dictionary<Guid, EnumDependency>();
      Dictionary<Guid, EntityDependency> entityDependencies = new Dictionary<Guid, EntityDependency>();
      Dictionary<Guid, DataClassDependency> dataClassDependencies = new Dictionary<Guid, DataClassDependency>();
      foreach (ViewItem viewItem in viewItems)
      {
        foreach (ComputedValue dynamicProperty in viewItem.DynamicProperties)
        {
          if (dynamicProperty.ComputedValueType == ComputedValueType.Property && !(dynamicProperty.PropertyUid == Guid.Empty))
            ComputedPropertyViewItemAnalyzer.ComputedPropertyViewItem((object) dynamicProperty, (object) contextMetadata, (object) options, enumDependencies, entityDependencies, dataClassDependencies);
        }
      }
      return new DependencyAnalysisResult()
      {
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>(),
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dataClassDependencies.Values.ToList<DataClassDependency>()
      };
    }

    private static (ClassMetadata, IPropertyMetadata) ComputedPropertyViewItem(
      object computedValue,
      object rootMetadata,
      object options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      switch (((ComputedValue) computedValue).PropertyParents.Count)
      {
        case 0:
          return ViewItemsAnalyzerHelper.CaseZeroPropertyParents(((ComputedValue) computedValue).PropertyUid, (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
        case 1:
          return ViewItemsAnalyzerHelper.CaseOnePropertyParents(((ComputedValue) computedValue).PropertyUid, ((ComputedValue) computedValue).PropertyParents.ToArray(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
        default:
          return ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(((ComputedValue) computedValue).PropertyUid, ((ComputedValue) computedValue).PropertyParents.ToArray(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
      }
    }

    public ComputedPropertyViewItemAnalyzer()
    {
      ComputedPropertyViewItemAnalyzer.LhZP0khRDnxMP9rg2xE8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Eawp8mhRpPuHmkDq7AGC() => ComputedPropertyViewItemAnalyzer.FrOZhZhR3L1YcdBvuepf == null;

    internal static ComputedPropertyViewItemAnalyzer oINBs4hRarn0ek0K55Kb() => ComputedPropertyViewItemAnalyzer.FrOZhZhR3L1YcdBvuepf;

    internal static void LhZP0khRDnxMP9rg2xE8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
