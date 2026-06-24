// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.PropertyViewItemsAnalyzer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Dependencies.Analyzers
{
  /// <summary>
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.PropertyViewItem" />
  /// </summary>
  internal sealed class PropertyViewItemsAnalyzer : BaseViewItemAnalyzer<PropertyViewItem>
  {
    internal static PropertyViewItemsAnalyzer GcxvVFhqEAMj39lKpxlS;

    /// <inheritdoc />
    protected override DependencyAnalysisResult ProcessViewItems(
      IEnumerable<PropertyViewItem> viewItems,
      ClassMetadata contextMetadata,
      IMetadata metadata,
      DependencyServiceOptions options)
    {
      Dictionary<Guid, EnumDependency> enumDependencies = new Dictionary<Guid, EnumDependency>();
      Dictionary<Guid, EntityDependency> entityDependencies = new Dictionary<Guid, EntityDependency>();
      Dictionary<Guid, DataClassDependency> dataClassDependencies = new Dictionary<Guid, DataClassDependency>();
      foreach (PropertyViewItem viewItem in viewItems)
      {
        Guid propertyUid = viewItem.PropertyUid;
        Func<IncludedProperty, bool> func;
        if (!(metadata is ComponentMetadata componentMetadata) || componentMetadata.UserDefinedListInfos == null || !componentMetadata.UserDefinedListInfos.Any<UserDefinedListInfo>((Func<UserDefinedListInfo, bool>) (udl =>
        {
          int num1 = 3;
          while (true)
          {
            switch (num1)
            {
              case 1:
                goto label_8;
              case 2:
                List<IncludedProperty> includedProperties = udl.IncludedProperties;
                Func<IncludedProperty, bool> func1 = func;
                Func<IncludedProperty, bool> predicate = func1 == null ? (func = (Func<IncludedProperty, bool>) (ip =>
                {
                  int num2 = 1;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.uMcgHLvb8PVVcPlbfs9B((object) ip), propertyUid))
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  return PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(ip.OriginalPropertyUid, propertyUid);
label_5:
                  return true;
                })) : func1;
                if (!includedProperties.Any<IncludedProperty>(predicate))
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                  continue;
                }
                goto label_9;
              case 3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.mj2UunvbCxxmnepq2tKj((object) udl), propertyUid))
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 1;
                  continue;
                }
                goto label_9;
              default:
                if (!udl.GroupingProperties.Any<GroupingProperty>((Func<GroupingProperty, bool>) (gp =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.uMcgHLvb8PVVcPlbfs9B((object) gp), propertyUid))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_3;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  return PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.aUf2DsvbZu0pftbVLq3A((object) gp), propertyUid);
label_3:
                  return true;
                })))
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
                  continue;
                }
                goto label_9;
            }
          }
label_8:
          return udl.AggregationProperties.Any<AggregationProperty>((Func<AggregationProperty, bool>) (ap =>
          {
            int num4 = 2;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_5;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  if (PropertyViewItemsAnalyzer.\u003C\u003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(ap.Uid, propertyUid))
                  {
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
                    continue;
                  }
                  goto label_4;
                default:
                  goto label_4;
              }
            }
label_4:
            return ap.OriginalPropertyUid == propertyUid;
label_5:
            return true;
          }));
label_9:
          return true;
        })))
          PropertyViewItemsAnalyzer.ProcessPropertyViewItem((object) viewItem, (object) contextMetadata, (object) options, enumDependencies, entityDependencies, dataClassDependencies);
      }
      return new DependencyAnalysisResult()
      {
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>(),
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dataClassDependencies.Values.ToList<DataClassDependency>()
      };
    }

    private static void ProcessPropertyViewItem(
      object propertyViewItem,
      object rootMetadata,
      object options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies)
    {
      switch (((PropertyViewItem) propertyViewItem).PropertyParents.Count)
      {
        case 0:
          ViewItemsAnalyzerHelper.CaseZeroPropertyParents(((PropertyViewItem) propertyViewItem).PropertyUid, (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
          break;
        case 1:
          ViewItemsAnalyzerHelper.CaseOnePropertyParents(((PropertyViewItem) propertyViewItem).PropertyUid, ((PropertyViewItem) propertyViewItem).PropertyParents.ToArray(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
          break;
        default:
          ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(((PropertyViewItem) propertyViewItem).PropertyUid, ((PropertyViewItem) propertyViewItem).PropertyParents.ToArray(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
          break;
      }
    }

    public PropertyViewItemsAnalyzer()
    {
      PropertyViewItemsAnalyzer.CkRmhmhqCsgGjUwIOjaB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void CkRmhmhqCsgGjUwIOjaB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EagopvhqfYJYJFFS8eZu() => PropertyViewItemsAnalyzer.GcxvVFhqEAMj39lKpxlS == null;

    internal static PropertyViewItemsAnalyzer th6iJ6hqQK87OpeNGB3a() => PropertyViewItemsAnalyzer.GcxvVFhqEAMj39lKpxlS;
  }
}
