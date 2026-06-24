// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.DynamicViewItemsAnalyzer
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
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Dependencies.Analyzers
{
  /// <summary>
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.IDynamicViewItem" />
  /// </summary>
  internal class DynamicViewItemsAnalyzer : BaseViewItemAnalyzer<IDynamicViewItem>
  {
    internal static DynamicViewItemsAnalyzer uJhsAOhRYATLL4uiniVe;

    /// <inheritdoc />
    protected override bool CheckViewItem(ViewItem viewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (viewItem is IDynamicViewItem dynamicViewItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return DynamicViewItemsAnalyzer.z4vV5chRcKlwDnH7f0Cq(DynamicViewItemsAnalyzer.yEigMnhRsGbsx1ljVI8l((object) dynamicViewItem), Guid.Empty);
label_3:
      return false;
    }

    /// <inheritdoc />
    protected override DependencyAnalysisResult ProcessViewItems(
      IEnumerable<IDynamicViewItem> viewItems,
      ClassMetadata contextMetadata,
      IMetadata metadata,
      DependencyServiceOptions options)
    {
      Guid moduleUid = contextMetadata.ModuleUid;
      Dictionary<Guid, EnumDependency> enumDependencies = new Dictionary<Guid, EnumDependency>();
      Dictionary<Guid, EntityDependency> entityDependencies = new Dictionary<Guid, EntityDependency>();
      Dictionary<Guid, DataClassDependency> dataClassDependencies = new Dictionary<Guid, DataClassDependency>();
      foreach (IDynamicViewItem viewItem in viewItems)
      {
        (ClassMetadata metadata1, IPropertyMetadata propertyMetadata) = DynamicViewItemsAnalyzer.ProcessDynamicViewItem((object) viewItem, (object) contextMetadata, (object) options, enumDependencies, entityDependencies, dataClassDependencies);
        if (metadata1 != null && propertyMetadata != null)
          this.AdditionalProcess(viewItem, moduleUid, metadata1, options, enumDependencies, entityDependencies, dataClassDependencies);
      }
      return new DependencyAnalysisResult()
      {
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>(),
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dataClassDependencies.Values.ToList<DataClassDependency>()
      };
    }

    /// <summary>
    /// Дополнительная обработка динамического элемента представления
    /// </summary>
    /// <param name="dynamicViewItem">Динамический элемент представления</param>
    /// <param name="currentModuleUid">Текущий модуль</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <param name="enumDependencies">Зависимости от перечислений</param>
    /// <param name="entityDependencies">Зависимости от сущностей</param>
    /// <param name="dataClassDependencies">Зависимости от структур обмена данными</param>
    protected virtual void AdditionalProcess(
      IDynamicViewItem dynamicViewItem,
      Guid currentModuleUid,
      ClassMetadata metadata,
      DependencyServiceOptions options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
    }

    private static (ClassMetadata, IPropertyMetadata) ProcessDynamicViewItem(
      object dynamicViewItem,
      object rootMetadata,
      object options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      switch (((IViewItemWithPropertyParents) dynamicViewItem).PropertyParents.Count)
      {
        case 0:
          return ViewItemsAnalyzerHelper.CaseZeroPropertyParents(((IDynamicViewItem) dynamicViewItem).PropertyUid, (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
        case 1:
          return ViewItemsAnalyzerHelper.CaseOnePropertyParents(((IDynamicViewItem) dynamicViewItem).PropertyUid, ((IViewItemWithPropertyParents) dynamicViewItem).PropertyParents.ToArray(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
        default:
          return ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(((IDynamicViewItem) dynamicViewItem).PropertyUid, ((IViewItemWithPropertyParents) dynamicViewItem).PropertyParents.ToArray(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
      }
    }

    public DynamicViewItemsAnalyzer()
    {
      DynamicViewItemsAnalyzer.HwsRXDhRz6en2PSOmMsD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid yEigMnhRsGbsx1ljVI8l([In] object obj0) => ((IDynamicViewItem) obj0).PropertyUid;

    internal static bool z4vV5chRcKlwDnH7f0Cq([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool oUa3SkhRLphvnDcGQF5J() => DynamicViewItemsAnalyzer.uJhsAOhRYATLL4uiniVe == null;

    internal static DynamicViewItemsAnalyzer Wy1y97hRUFQgPn8dISEU() => DynamicViewItemsAnalyzer.uJhsAOhRYATLL4uiniVe;

    internal static void HwsRXDhRz6en2PSOmMsD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
