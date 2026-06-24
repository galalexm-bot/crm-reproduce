// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.TreeViewItemAnalyzer
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
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.TreeViewItem" />
  /// </summary>
  internal sealed class TreeViewItemAnalyzer : DynamicViewItemsAnalyzer
  {
    internal static TreeViewItemAnalyzer xOe5n9hqvKdv4Aimnp8r;

    /// <inheritdoc />
    protected override bool CheckViewItem(ViewItem viewItem) => viewItem is ITreeViewItem;

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
      ITreeViewItem treeViewItem = (ITreeViewItem) dynamicViewItem;
      Guid keyUid = treeViewItem.KeyUid;
      if (keyUid != Guid.Empty)
      {
        PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => a.Uid == keyUid));
        if (propertyMetadata != null)
          DependencyServiceHelper.ProcessMetadata(currentModuleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata);
      }
      Guid parentUid = treeViewItem.ParentKeyUid;
      if (!(parentUid != Guid.Empty))
        return;
      // ISSUE: reference to a compiler-generated method
      PropertyMetadata propertyMetadata1 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => TreeViewItemAnalyzer.\u003C\u003Ec__DisplayClass1_0.tjP8aMvbiehWCvBVhoqF(a.Uid, parentUid)));
      if (propertyMetadata1 == null)
        return;
      DependencyServiceHelper.ProcessMetadata(currentModuleUid, (IMetadata) metadata, options, enumDependencies, entityDependencies, dataClassDependencies, (IPropertyMetadata) propertyMetadata1);
    }

    public TreeViewItemAnalyzer()
    {
      TreeViewItemAnalyzer.PSUbj7hquIx8blIr8ctA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool H2DZ0ehq88WhJV891Vk7() => TreeViewItemAnalyzer.xOe5n9hqvKdv4Aimnp8r == null;

    internal static TreeViewItemAnalyzer D2xMaihqZXiT9cdqxkGw() => TreeViewItemAnalyzer.xOe5n9hqvKdv4Aimnp8r;

    internal static void PSUbj7hquIx8blIr8ctA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
