// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.LineChartViewItemAnalyzer
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
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.Charts.LineChartViewItem" />
  /// </summary>
  internal sealed class LineChartViewItemAnalyzer : DynamicViewItemsAnalyzer
  {
    internal static LineChartViewItemAnalyzer TfJRgvhRtv1FTtPoBV32;

    /// <inheritdoc />
    protected override bool CheckViewItem(ViewItem viewItem) => viewItem is LineChartViewItem;

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
      LineChartViewItem lineChartViewItem = (LineChartViewItem) dynamicViewItem;
      Guid lineUid = lineChartViewItem.LinePropertyUid;
      if (lineUid != Guid.Empty)
      {
        // ISSUE: reference to a compiler-generated method
        PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => LineChartViewItemAnalyzer.\u003C\u003Ec__DisplayClass1_0.D1PGcmvoIvlTDdhcIddm((object) a) == lineUid));
        if (propertyMetadata != null)
          DependencyServiceHelper.ProcessMetadata(currentModuleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata);
      }
      Guid valueUid = lineChartViewItem.ValueUid;
      if (valueUid != Guid.Empty)
      {
        // ISSUE: reference to a compiler-generated method
        PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => LineChartViewItemAnalyzer.\u003C\u003Ec__DisplayClass1_0.w9w31hvoVkgTquHeV0EG(a.Uid, valueUid)));
        if (propertyMetadata != null)
          DependencyServiceHelper.ProcessMetadata(currentModuleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata);
      }
      Guid nameUid = lineChartViewItem.NameUid;
      if (!(nameUid != Guid.Empty))
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      PropertyMetadata propertyMetadata1 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => LineChartViewItemAnalyzer.\u003C\u003Ec__DisplayClass1_0.w9w31hvoVkgTquHeV0EG(LineChartViewItemAnalyzer.\u003C\u003Ec__DisplayClass1_0.D1PGcmvoIvlTDdhcIddm((object) a), nameUid)));
      if (propertyMetadata1 == null)
        return;
      DependencyServiceHelper.ProcessMetadata(currentModuleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata1);
    }

    public LineChartViewItemAnalyzer()
    {
      LineChartViewItemAnalyzer.GA2m8hhR66GYhSiWuWWe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool nUAjlyhRwFgBrehHhNYb() => LineChartViewItemAnalyzer.TfJRgvhRtv1FTtPoBV32 == null;

    internal static LineChartViewItemAnalyzer whI4UuhR4B9bE0UmfoV8() => LineChartViewItemAnalyzer.TfJRgvhRtv1FTtPoBV32;

    internal static void GA2m8hhR66GYhSiWuWWe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
