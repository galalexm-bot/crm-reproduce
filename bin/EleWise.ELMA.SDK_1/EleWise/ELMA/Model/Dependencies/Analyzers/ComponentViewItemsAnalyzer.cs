// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.ComponentViewItemsAnalyzer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Dependencies.Analyzers
{
  /// <summary>
  /// Анализатор для <see cref="T:EleWise.ELMA.Model.Views.ComponentViewItem" />
  /// </summary>
  internal sealed class ComponentViewItemsAnalyzer : BaseViewItemAnalyzer<ComponentViewItem>
  {
    internal static ComponentViewItemsAnalyzer AeOANWhRgaiYJfcPwdbC;

    /// <inheritdoc />
    protected override DependencyAnalysisResult ProcessViewItems(
      IEnumerable<ComponentViewItem> viewItems,
      ClassMetadata contextMetadata,
      IMetadata metadata,
      DependencyServiceOptions options)
    {
      Guid moduleUid = contextMetadata.ModuleUid;
      Dictionary<Guid, EnumDependency> enumDependencies = new Dictionary<Guid, EnumDependency>();
      Dictionary<Guid, EntityDependency> entityDependencies = new Dictionary<Guid, EntityDependency>();
      Dictionary<Guid, DataClassDependency> dataClassDependencies = new Dictionary<Guid, DataClassDependency>();
      List<ComponentDependency> componentDependencyList = new List<ComponentDependency>();
      Dictionary<Guid, FunctionDependency> functionDependencies = new Dictionary<Guid, FunctionDependency>();
      foreach (ComponentViewItem viewItem in viewItems)
      {
        if (!(MetadataServiceContext.Service.GetMetadata(viewItem.HeaderUid) is ComponentMetadata metadata1))
          throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108061488), (object) viewItem.HeaderUid));
        if (!DependencyServiceHelper.SkipDependency((IMetadata) metadata1, moduleUid, options))
        {
          List<InputComputedValue> list = viewItem.DynamicProperties.OfType<InputComputedValue>().ToList<InputComputedValue>();
          foreach (InputComputedValue inputComputedValue1 in list)
          {
            switch (inputComputedValue1.ComputedValueType)
            {
              case ComputedValueType.Input:
                if (inputComputedValue1.Value == null)
                  continue;
                break;
              case ComputedValueType.Function:
                if (string.IsNullOrWhiteSpace(inputComputedValue1.MethodName))
                  continue;
                break;
              case ComputedValueType.CalculateScript:
                if (string.IsNullOrWhiteSpace(inputComputedValue1.CalculateScript))
                  continue;
                break;
            }
            if (DependencyServiceHelper.IsAction(inputComputedValue1.TypeUid) && inputComputedValue1 is ActionInputComputedValue inputComputedValue2)
            {
              DependencyServiceHelper.AnalyseTypeSignature(inputComputedValue2.ReturnType, (IDictionary<Guid, DataClassDependency>) dataClassDependencies, (IDictionary<Guid, EntityDependency>) entityDependencies, (IDictionary<Guid, EnumDependency>) enumDependencies, moduleUid, options);
              DependencyServiceHelper.AnalyseTypeSignature(inputComputedValue2.ParameterType, (IDictionary<Guid, DataClassDependency>) dataClassDependencies, (IDictionary<Guid, EntityDependency>) entityDependencies, (IDictionary<Guid, EnumDependency>) enumDependencies, moduleUid, options);
              if (inputComputedValue1.Value is ActionValue actionValue && actionValue.CodeType == CodeType.GlobalFunction)
              {
                Guid functionHeaderUid = actionValue.FunctionHeaderUid;
                if (!(MetadataServiceContext.Service.GetMetadata(functionHeaderUid) is FunctionMetadata metadata2))
                  throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867088869), (object) functionHeaderUid));
                if (!DependencyServiceHelper.SkipDependency((IMetadata) metadata2, moduleUid, options))
                  DependencyServiceHelper.AddFunctionDependency((IDictionary<Guid, FunctionDependency>) functionDependencies, metadata2);
              }
            }
          }
          List<InputComputedValue> collection = new List<InputComputedValue>();
          if (viewItem.Items.Count > 0)
            collection.AddRange(viewItem.Items.OfType<SlotViewItem>().Where<SlotViewItem>((Func<SlotViewItem, bool>) (s => s.Items.Any<ViewItem>())).Select<SlotViewItem, InputComputedValue>((Func<SlotViewItem, InputComputedValue>) (s =>
            {
              InputComputedValue inputComputedValue = new InputComputedValue();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              ComponentViewItemsAnalyzer.\u003C\u003Ec.kcFQXRvbW6EF64YjQitb((object) inputComputedValue, ComponentViewItemsAnalyzer.\u003C\u003Ec.Dej9ZVvbBQMCF0qyiWS6(ComponentViewItemsAnalyzer.\u003C\u003Ec.KiCVamvozxoulfd9kUS3(1178210108 ^ 1178579510), ComponentViewItemsAnalyzer.\u003C\u003Ec.hZLAPSvbFNPFRrjQm2CQ((object) s)));
              // ISSUE: reference to a compiler-generated method
              ComponentViewItemsAnalyzer.\u003C\u003Ec.nKytEyvbo7be9Z6ElpVC((object) inputComputedValue, SlotViewItem.TypeUid);
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              ComponentViewItemsAnalyzer.\u003C\u003Ec.iKbZfnvbhAkibSuvKP1I((object) inputComputedValue, ComponentViewItemsAnalyzer.\u003C\u003Ec.uswgE6vbb4jEagPqIK4b((object) s));
              return inputComputedValue;
            })));
          ComponentDependency dependency = metadata1.GetDependency(viewItem);
          dependency.Inputs.AddRange((IEnumerable<InputComputedValue>) list);
          dependency.Inputs.AddRange((IEnumerable<InputComputedValue>) collection);
          componentDependencyList.Add(dependency);
        }
      }
      return new DependencyAnalysisResult()
      {
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>(),
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dataClassDependencies.Values.ToList<DataClassDependency>(),
        FunctionDependencies = functionDependencies.Values.ToList<FunctionDependency>(),
        ComponentDependencies = componentDependencyList
      };
    }

    public ComponentViewItemsAnalyzer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool U5ngWLhR57FrBndN733r() => ComponentViewItemsAnalyzer.AeOANWhRgaiYJfcPwdbC == null;

    internal static ComponentViewItemsAnalyzer h1w7DLhRj4me55Wk47Bd() => ComponentViewItemsAnalyzer.AeOANWhRgaiYJfcPwdbC;
  }
}
