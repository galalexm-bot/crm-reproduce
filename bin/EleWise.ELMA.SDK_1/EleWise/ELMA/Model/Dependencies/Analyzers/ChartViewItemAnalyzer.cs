// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.ChartViewItemAnalyzer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Charts;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Dependencies.Analyzers
{
  /// <summary>
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.Charts.ChartViewItem" />
  /// </summary>
  internal sealed class ChartViewItemAnalyzer : DynamicViewItemsAnalyzer
  {
    internal static ChartViewItemAnalyzer wiBBUHhRHnhtvjkwou6W;

    /// <inheritdoc />
    protected override bool CheckViewItem(ViewItem viewItem) => viewItem is ChartViewItem;

    /// <inheritdoc />
    protected override void AdditionalProcess(
      IDynamicViewItem dynamicViewItem,
      Guid currentModuleUid,
      ClassMetadata metadata,
      DependencyServiceOptions options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      ChartViewItem chartViewItem = (ChartViewItem) dynamicViewItem;
      Guid valueUid = chartViewItem.ValueUid;
      if (valueUid != Guid.Empty)
      {
        // ISSUE: reference to a compiler-generated method
        PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => ChartViewItemAnalyzer.\u003C\u003Ec__DisplayClass1_0.oHPZ8MvoK94f4JcHjoZP(a.Uid, valueUid)));
        if (propertyMetadata != null)
          DependencyServiceHelper.ProcessMetadata(currentModuleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata);
      }
      Guid nameUid = chartViewItem.NameUid;
      if (!(nameUid != Guid.Empty))
        return;
      PropertyMetadata propertyMetadata1 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => a.Uid == nameUid));
      if (propertyMetadata1 == null)
        return;
      DependencyServiceHelper.ProcessMetadata(currentModuleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata1);
    }

    public ChartViewItemAnalyzer()
    {
      ChartViewItemAnalyzer.ISLt5yhRxIF6d6Zb7RlH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SHNBfNhRABa49M8jKMS8() => ChartViewItemAnalyzer.wiBBUHhRHnhtvjkwou6W == null;

    internal static ChartViewItemAnalyzer dYVBubhR7P4hqmQft4mi() => ChartViewItemAnalyzer.wiBBUHhRHnhtvjkwou6W;

    internal static void ISLt5yhRxIF6d6Zb7RlH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
