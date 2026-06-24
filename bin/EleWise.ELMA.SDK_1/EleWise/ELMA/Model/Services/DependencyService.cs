// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.DependencyService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Dependencies.Analyzers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class DependencyService : IDependencyService
  {
    private readonly IEnumerable<IViewItemAnalyzer> viewItemAnalyzers;
    internal static DependencyService sp0IUXbvK8bdSDlJQl18;

    /// <summary>Ctor</summary>
    /// <param name="viewItemAnalyzers">Анализаторы элементов представления</param>
    public DependencyService(IEnumerable<IViewItemAnalyzer> viewItemAnalyzers)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.viewItemAnalyzers = viewItemAnalyzers;
    }

    /// <inheritdoc />
    public MetadataDependencyContainer GetClassMetadataDependencies(
      ClassMetadata contextMetadata,
      IMetadata metadata,
      IEnumerable<FormViewItem> forms,
      DependencyServiceOptions options = null)
    {
      Contract.ArgumentNotNull((object) contextMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643803557));
      DependencyAnalysisResult dependencyAnalysisResult1 = this.AnalyzeMetadata(contextMetadata, options);
      MetadataDependencyContainer metadataDependencies = new MetadataDependencyContainer();
      metadataDependencies.EntityDependencies.AddRange((IEnumerable<EntityDependency>) dependencyAnalysisResult1.EntityDependencies);
      metadataDependencies.EnumDependencies.AddRange((IEnumerable<EnumDependency>) dependencyAnalysisResult1.EnumDependencies);
      metadataDependencies.FunctionDependencies.AddRange((IEnumerable<FunctionDependency>) dependencyAnalysisResult1.FunctionDependencies);
      metadataDependencies.DataClassDependencies.AddRange((IEnumerable<DataClassDependency>) dependencyAnalysisResult1.DataClassDependencies);
      foreach (FormViewItem form in forms)
      {
        DependencyAnalysisResult dependencyAnalysisResult2 = this.SimpleFormDependencyAnalysis(contextMetadata, metadata, form, (DependencyServiceOptions) null);
        FormViewItemDependencyContainer dependencyContainer = new FormViewItemDependencyContainer()
        {
          FormUid = form.Uid
        };
        dependencyContainer.EnumDependencies.AddRange((IEnumerable<EnumDependency>) dependencyAnalysisResult2.EnumDependencies);
        dependencyContainer.EntityDependencies.AddRange((IEnumerable<EntityDependency>) dependencyAnalysisResult2.EntityDependencies);
        dependencyContainer.DataClassDependencies.AddRange((IEnumerable<DataClassDependency>) dependencyAnalysisResult2.DataClassDependencies);
        dependencyContainer.ComponentDependencies.AddRange((IEnumerable<ComponentDependency>) dependencyAnalysisResult2.ComponentDependencies);
        metadataDependencies.FormDependencies.Add(dependencyContainer);
      }
      return metadataDependencies;
    }

    /// <inheritdoc />
    public DependencyAnalysisResult SimpleFormDependencyAnalysis(
      ClassMetadata contextMetadata,
      IMetadata metadata,
      FormViewItem form,
      DependencyServiceOptions options = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DependencyService.F9eHGZbvnkXa4Mk1Y2ru((object) contextMetadata, DependencyService.c2gICTbvk65apcXGfW2n(1253244298 - 1829393894 ^ -576165882));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            DependencyService.F9eHGZbvnkXa4Mk1Y2ru((object) form, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70011450));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return this.AnalyzeForm(contextMetadata, metadata, form, options);
    }

    /// <inheritdoc />
    public DependencyAnalysisResult SimpleFunctionDependencyAnalysis(
      FunctionMetadata metadata,
      DependencyServiceOptions options)
    {
      int num1 = 2;
      Dictionary<Guid, DataClassDependency> dataClassDependencies;
      Dictionary<Guid, EnumDependency> enumDependencies;
      Dictionary<Guid, EntityDependency> entityDependencies;
      while (true)
      {
        int num2 = num1;
        Guid currentModuleUid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              currentModuleUid = DependencyService.HEKy63bvOApmSq91eyFs((object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
              continue;
            case 3:
              entityDependencies = new Dictionary<Guid, EntityDependency>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              continue;
            case 4:
              DependencyServiceHelper.AnalyseTypeSignature((TypeSignature) DependencyService.jlmiATbve17BFPFXcRrv((object) metadata), (IDictionary<Guid, DataClassDependency>) dataClassDependencies, (IDictionary<Guid, EntityDependency>) entityDependencies, (IDictionary<Guid, EnumDependency>) enumDependencies, currentModuleUid, options);
              num2 = 6;
              continue;
            case 5:
              DependencyServiceHelper.AnalyseTypeSignature((TypeSignature) DependencyService.n0YRSObv2XAxpoX0UQlM((object) metadata), (IDictionary<Guid, DataClassDependency>) dataClassDependencies, (IDictionary<Guid, EntityDependency>) entityDependencies, (IDictionary<Guid, EnumDependency>) enumDependencies, currentModuleUid, options);
              num2 = 4;
              continue;
            case 6:
              goto label_4;
            default:
              dataClassDependencies = new Dictionary<Guid, DataClassDependency>();
              num2 = 5;
              continue;
          }
        }
label_6:
        enumDependencies = new Dictionary<Guid, EnumDependency>();
        num1 = 3;
      }
label_4:
      return new DependencyAnalysisResult()
      {
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>(),
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dataClassDependencies.Values.ToList<DataClassDependency>()
      };
    }

    /// <inheritdoc />
    public CompatibilityResult CheckFunctionCompatibility(
      FunctionDependency current,
      FunctionDependency candidate)
    {
      int num1 = 1;
      CompatibilityResult compatibilityResult1;
      CompatibilityResult compatibilityResult2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            compatibilityResult2 = (CompatibilityResult) DependencyService.kgbPeabvPAtDlQBNfhBw((object) current.ParameterType, (object) candidate.ParameterType);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!DependencyService.orUEiNbvNLsroV3H7Pjg((object) compatibilityResult2))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 3;
              continue;
            }
            goto label_2;
          case 3:
            goto label_7;
          case 4:
            goto label_2;
          default:
            compatibilityResult1 = (CompatibilityResult) DependencyService.kgbPeabvPAtDlQBNfhBw(DependencyService.axXn7dbv1ladSSjMWnDj((object) current), DependencyService.axXn7dbv1ladSSjMWnDj((object) candidate));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      int num2 = DependencyService.orUEiNbvNLsroV3H7Pjg((object) compatibilityResult1) ? 1 : 0;
      goto label_8;
label_7:
      num2 = 0;
label_8:
      IEnumerable<string> errors = ((IEnumerable<string>) DependencyService.iiPPVpbv3BQSSI4Ofp5X((object) compatibilityResult2)).Concat<string>((IEnumerable<string>) DependencyService.iiPPVpbv3BQSSI4Ofp5X((object) compatibilityResult1));
      return new CompatibilityResult(num2 != 0, errors);
    }

    /// <inheritdoc />
    public CompatibilityResult CheckDataClassCompatibility(
      DataClassDependency current,
      DataClassDependency candidate)
    {
      return (CompatibilityResult) DependencyService.sjZe6YbvpKOvBcW3EKPb((object) current, (object) candidate);
    }

    /// <summary>Объединить результаты анализа</summary>
    /// <param name="results">Экземпляры анализа</param>
    /// <returns>Объединенный результат анализа</returns>
    public static DependencyAnalysisResult CombineAnalysis(params DependencyAnalysisResult[] results)
    {
      DependencyAnalysisResult dependencyAnalysisResult = new DependencyAnalysisResult();
      DependencyAnalysisResult[] source1 = results;
      // ISSUE: reference to a compiler-generated field
      Func<DependencyAnalysisResult, IEnumerable<FunctionDependency>> func1 = DependencyService.\u003C\u003Ec.\u003C\u003E9__7_0;
      Func<DependencyAnalysisResult, IEnumerable<FunctionDependency>> selector1;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        DependencyService.\u003C\u003Ec.\u003C\u003E9__7_0 = selector1 = (Func<DependencyAnalysisResult, IEnumerable<FunctionDependency>>) (r => (IEnumerable<FunctionDependency>) r.FunctionDependencies);
      }
      else
        goto label_12;
label_2:
      dependencyAnalysisResult.FunctionDependencies = DependencyHelper.CombineDependencies<FunctionDependency>(((IEnumerable<DependencyAnalysisResult>) source1).SelectMany<DependencyAnalysisResult, FunctionDependency>(selector1)).ToList<FunctionDependency>();
      dependencyAnalysisResult.EnumDependencies = DependencyHelper.CombineDependencies<EnumDependency>(((IEnumerable<DependencyAnalysisResult>) results).SelectMany<DependencyAnalysisResult, EnumDependency>((Func<DependencyAnalysisResult, IEnumerable<EnumDependency>>) (r => (IEnumerable<EnumDependency>) r.EnumDependencies))).ToList<EnumDependency>();
      DependencyAnalysisResult[] source2 = results;
      // ISSUE: reference to a compiler-generated field
      Func<DependencyAnalysisResult, IEnumerable<EntityDependency>> func2 = DependencyService.\u003C\u003Ec.\u003C\u003E9__7_2;
      Func<DependencyAnalysisResult, IEnumerable<EntityDependency>> selector2;
      if (func2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        DependencyService.\u003C\u003Ec.\u003C\u003E9__7_2 = selector2 = (Func<DependencyAnalysisResult, IEnumerable<EntityDependency>>) (r => (IEnumerable<EntityDependency>) r.EntityDependencies);
      }
      else
        goto label_3;
label_5:
      dependencyAnalysisResult.EntityDependencies = DependencyHelper.CombineClassDependencies<EntityDependency>(((IEnumerable<DependencyAnalysisResult>) source2).SelectMany<DependencyAnalysisResult, EntityDependency>(selector2)).ToList<EntityDependency>();
      DependencyAnalysisResult[] source3 = results;
      // ISSUE: reference to a compiler-generated field
      Func<DependencyAnalysisResult, IEnumerable<DataClassDependency>> func3 = DependencyService.\u003C\u003Ec.\u003C\u003E9__7_3;
      Func<DependencyAnalysisResult, IEnumerable<DataClassDependency>> selector3;
      if (func3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        DependencyService.\u003C\u003Ec.\u003C\u003E9__7_3 = selector3 = (Func<DependencyAnalysisResult, IEnumerable<DataClassDependency>>) (r => (IEnumerable<DataClassDependency>) r.DataClassDependencies);
      }
      else
        goto label_6;
label_8:
      dependencyAnalysisResult.DataClassDependencies = DependencyHelper.CombineClassDependencies<DataClassDependency>(((IEnumerable<DependencyAnalysisResult>) source3).SelectMany<DependencyAnalysisResult, DataClassDependency>(selector3)).ToList<DataClassDependency>();
      DependencyAnalysisResult[] source4 = results;
      // ISSUE: reference to a compiler-generated field
      Func<DependencyAnalysisResult, IEnumerable<ComponentDependency>> func4 = DependencyService.\u003C\u003Ec.\u003C\u003E9__7_4;
      Func<DependencyAnalysisResult, IEnumerable<ComponentDependency>> selector4;
      if (func4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        DependencyService.\u003C\u003Ec.\u003C\u003E9__7_4 = selector4 = (Func<DependencyAnalysisResult, IEnumerable<ComponentDependency>>) (a => (IEnumerable<ComponentDependency>) a.ComponentDependencies);
      }
      else
        goto label_9;
label_11:
      dependencyAnalysisResult.ComponentDependencies = ((IEnumerable<DependencyAnalysisResult>) source4).SelectMany<DependencyAnalysisResult, ComponentDependency>(selector4).ToList<ComponentDependency>();
      return dependencyAnalysisResult;
label_9:
      selector4 = func4;
      goto label_11;
label_6:
      selector3 = func3;
      goto label_8;
label_3:
      selector2 = func2;
      goto label_5;
label_12:
      selector1 = func1;
      goto label_2;
    }

    /// <inheritdoc />
    public void FillDependencies(
      ComponentMetadata componentMetadata,
      IEnumerable<Guid> ignoredMetadata,
      DependencyServiceOptions options = null)
    {
      HashSet<Guid> hashSet = ignoredMetadata.ToHashSet<Guid>();
      using (MetadataServiceContext.Extend((IEnumerable<IMetadata>) componentMetadata.GetMetadataToRegister().ToList<IMetadata>()))
      {
        DependencyAnalysisResult dependencyAnalysisResult = this.SimpleDependencyAnalysis(componentMetadata, options);
        componentMetadata.EnumDependencies = DependencyService.Filter<EnumDependency>((IEnumerable<EnumDependency>) dependencyAnalysisResult.EnumDependencies, (ISet<Guid>) hashSet).ToList<EnumDependency>();
        componentMetadata.EntityDependencies = DependencyService.Filter<EntityDependency>((IEnumerable<EntityDependency>) dependencyAnalysisResult.EntityDependencies, (ISet<Guid>) hashSet).ToList<EntityDependency>();
        componentMetadata.DataClassDependencies = DependencyService.Filter<DataClassDependency>((IEnumerable<DataClassDependency>) dependencyAnalysisResult.DataClassDependencies, (ISet<Guid>) hashSet).ToList<DataClassDependency>();
        componentMetadata.FunctionDependencies = DependencyService.Filter<FunctionDependency>((IEnumerable<FunctionDependency>) dependencyAnalysisResult.FunctionDependencies, (ISet<Guid>) hashSet).ToList<FunctionDependency>();
        hashSet.Add(componentMetadata.Uid);
        componentMetadata.ComponentDependencies = DependencyService.Filter<ComponentDependency>((IEnumerable<ComponentDependency>) dependencyAnalysisResult.ComponentDependencies, (ISet<Guid>) hashSet).ToList<ComponentDependency>();
      }
    }

    /// <inheritdoc />
    public ModuleDependency CalculateDependencies(
      ModuleInfoMetadata module,
      IEnumerable<Guid> ignoredMetadata)
    {
      Contract.ArgumentNotNull((object) module, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740399860));
      DependencyAnalysisResult dependencyAnalysisResult1 = new DependencyAnalysisResult();
      DependencyAnalysisResult dependencyAnalysisResult2 = new DependencyAnalysisResult();
      HashSet<Guid> hashSet = ignoredMetadata.ToHashSet<Guid>();
      foreach (ComponentMetadata component in module.Components)
      {
        using (MetadataServiceContext.Extend((IEnumerable<IMetadata>) component.DataClasses))
        {
          DependencyAnalysisResult dependencyAnalysisResult3 = this.SimpleDependencyAnalysis(component, (DependencyServiceOptions) null);
          dependencyAnalysisResult3.DataClassDependencies = DependencyService.Filter<DataClassDependency>((IEnumerable<DataClassDependency>) dependencyAnalysisResult3.DataClassDependencies, (ISet<Guid>) hashSet).ToList<DataClassDependency>();
          dependencyAnalysisResult2 = DependencyService.CombineAnalysis(dependencyAnalysisResult2, dependencyAnalysisResult3);
        }
      }
      DependencyAnalysisResult dependencyAnalysisResult4 = DependencyService.CombineAnalysis(DependencyService.CombineAnalysis(dependencyAnalysisResult1, dependencyAnalysisResult2), module.Functions.Select<FunctionMetadata, DependencyAnalysisResult>((Func<FunctionMetadata, DependencyAnalysisResult>) (function => this.SimpleFunctionDependencyAnalysis(function, (DependencyServiceOptions) null))).Aggregate<DependencyAnalysisResult, DependencyAnalysisResult>(new DependencyAnalysisResult(), (Func<DependencyAnalysisResult, DependencyAnalysisResult, DependencyAnalysisResult>) ((current, functionDependencyAnalysis) => DependencyService.CombineAnalysis(current, functionDependencyAnalysis))));
      ModuleDependency dependencies = new ModuleDependency();
      dependencies.DataClasses.AddRange((IEnumerable<DataClassDependency>) dependencyAnalysisResult4.DataClassDependencies);
      dependencies.Functions.AddRange((IEnumerable<FunctionDependency>) dependencyAnalysisResult4.FunctionDependencies);
      dependencies.Components.AddRange((IEnumerable<ComponentDependency>) dependencyAnalysisResult4.ComponentDependencies);
      dependencies.EntityDependencies.AddRange((IEnumerable<EntityDependency>) dependencyAnalysisResult4.EntityDependencies);
      dependencies.EnumDependencies.AddRange((IEnumerable<EnumDependency>) dependencyAnalysisResult4.EnumDependencies);
      return dependencies;
    }

    private DependencyAnalysisResult SimpleDependencyAnalysis(
      ComponentMetadata componentMetadata,
      DependencyServiceOptions options)
    {
      int num = 5;
      DependencyAnalysisResult dependencyAnalysisResult1;
      DependencyAnalysisResult dependencyAnalysisResult2;
      DependencyAnalysisResult dependencyAnalysisResult3;
      DependencyAnalysisResult dependencyAnalysisResult4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            dependencyAnalysisResult2 = this.AnalyzeForm(componentMetadata, options);
            num = 3;
            continue;
          case 3:
            dependencyAnalysisResult4 = this.AnalyzeImplementations(componentMetadata, options);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          case 4:
            dependencyAnalysisResult1 = this.AnalyzeMetadata((ClassMetadata) DependencyService.KrDA0TbvDVGKQFEBT9RN(DependencyService.QTI2A7bvaRJF5HHavBNU((object) componentMetadata)), options);
            num = 2;
            continue;
          case 5:
            DependencyService.F9eHGZbvnkXa4Mk1Y2ru((object) componentMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29152965));
            num = 4;
            continue;
          default:
            dependencyAnalysisResult3 = this.AnalyzeUserDefinedListInfos(componentMetadata, options);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
            continue;
        }
      }
label_7:
      return DependencyService.CombineAnalysis(dependencyAnalysisResult1, dependencyAnalysisResult2, dependencyAnalysisResult4, dependencyAnalysisResult3);
    }

    private DependencyAnalysisResult AnalyzeUserDefinedListInfos(
      ComponentMetadata componentMetadata,
      DependencyServiceOptions options)
    {
      int num1 = 2;
      Dictionary<Guid, EnumDependency> enumDependencies;
      List<UserDefinedListInfo>.Enumerator enumerator1;
      Dictionary<Guid, EntityDependency> entityDependencies;
      Dictionary<Guid, DataClassDependency> dictionary;
      Guid currentModuleUid;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              object obj = DependencyService.KrDA0TbvDVGKQFEBT9RN(DependencyService.QTI2A7bvaRJF5HHavBNU((object) componentMetadata));
              List<PropertyMetadata> propertyMetadataList = new List<PropertyMetadata>();
              currentModuleUid = DependencyService.HEKy63bvOApmSq91eyFs(obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
              continue;
            case 3:
              entityDependencies = new Dictionary<Guid, EntityDependency>();
              num2 = 5;
              continue;
            case 4:
              goto label_52;
            case 5:
              dictionary = new Dictionary<Guid, DataClassDependency>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 6 : 4;
              continue;
            case 6:
              enumerator1 = componentMetadata.UserDefinedListInfos.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        enumDependencies = new Dictionary<Guid, EnumDependency>();
        num1 = 3;
      }
label_5:
      try
      {
label_27:
        if (enumerator1.MoveNext())
          goto label_10;
        else
          goto label_28;
label_8:
        UserDefinedListInfo current1;
        int num3;
        while (true)
        {
          int num4;
          IMetadata metadata1;
          List<IncludedProperty>.Enumerator enumerator2;
          switch (num3)
          {
            case 1:
            case 11:
            case 20:
              goto label_27;
            case 2:
            case 9:
              if (!(metadata1 is EntityMetadata metadata2))
              {
                num4 = 4;
                break;
              }
              goto case 6;
            case 3:
              metadata1 = ((IMetadataService) DependencyService.olYCngbvtaEyOhjAnm8M()).GetMetadata(DependencyService.fpnHsdbvwQcMsY9OeIVr((object) current1));
              num3 = 16;
              continue;
            case 4:
            case 18:
              if (metadata1 is EnumMetadata metadata3)
              {
                num3 = 17;
                continue;
              }
              goto label_27;
            case 5:
              goto label_52;
            case 6:
              Dictionary<Guid, EntityDependency> classDependencies = entityDependencies;
              Guid metadataUid = DependencyService.fpnHsdbvwQcMsY9OeIVr((object) current1);
              // ISSUE: reference to a compiler-generated field
              Func<EntityMetadata, EntityDependency> func = DependencyService.\u003C\u003Ec.\u003C\u003E9__11_1;
              Func<EntityMetadata, EntityDependency> createDependency;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                DependencyService.\u003C\u003Ec.\u003C\u003E9__11_1 = createDependency = (Func<EntityMetadata, EntityDependency>) (m => m.GetSignature(true));
              }
              else
                goto label_29;
label_44:
              DependencyServiceHelper.AddClassDependency<EntityDependency, EntityMetadata>((IDictionary<Guid, EntityDependency>) classDependencies, metadataUid, metadata2, createDependency);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 20 : 2;
              continue;
label_29:
              createDependency = func;
              goto label_44;
            case 7:
              enumerator2 = current1.IncludedProperties.GetEnumerator();
              num3 = 14;
              continue;
            case 8:
            case 10:
            case 15:
label_25:
              if (!(metadata1 is DataClassMetadata metadata4))
              {
                num4 = 9;
                break;
              }
              goto case 13;
            case 12:
              if (!(metadata1 is ClassMetadata rootMetadata))
              {
                num3 = 15;
                continue;
              }
              goto case 7;
            case 13:
              if (!DependencyService.HObJU3bvAJYhwU8jRwrx((object) metadata4, currentModuleUid, (object) options))
              {
                num3 = 19;
                continue;
              }
              goto label_27;
            case 14:
              try
              {
label_19:
                if (enumerator2.MoveNext())
                  goto label_17;
                else
                  goto label_20;
label_13:
                IncludedProperty current2;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      if (DependencyService.CrNTHAbvHLlWCoWxKx2A(DependencyService.rolJUebv6FAPa9koNeXH((object) current2), Guid.Empty))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 3;
                    case 2:
                      goto label_25;
                    case 3:
                      DependencyService.ProcessDynamicViewItem((object) current2, (object) rootMetadata, (object) options, entityDependencies, dictionary, enumDependencies);
                      num5 = 5;
                      continue;
                    case 4:
                      goto label_17;
                    default:
                      goto label_19;
                  }
                }
label_17:
                current2 = enumerator2.Current;
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                {
                  num5 = 1;
                  goto label_13;
                }
                else
                  goto label_13;
label_20:
                num5 = 2;
                goto label_13;
              }
              finally
              {
                enumerator2.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 16:
              if (!DependencyService.odEwB2bv4pc624v6UdPE(DependencyService.fpnHsdbvwQcMsY9OeIVr((object) current1), Guid.Empty))
              {
                num3 = 10;
                continue;
              }
              goto case 12;
            case 17:
              DependencyServiceHelper.AddEnumDependency((IDictionary<Guid, EnumDependency>) enumDependencies, metadata3);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
              continue;
            case 19:
              DependencyServiceHelper.AddClassDependency<DataClassDependency, DataClassMetadata>((IDictionary<Guid, DataClassDependency>) dictionary, DependencyService.gFoZYTbv71f0MyEiORob((object) metadata4), metadata4, (Func<DataClassMetadata, DataClassDependency>) (m => m.GetSignature(true)));
              num4 = 11;
              break;
            default:
              goto label_10;
          }
          num3 = num4;
        }
label_10:
        current1 = enumerator1.Current;
        num3 = 3;
        goto label_8;
label_28:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 5 : 2;
        goto label_8;
      }
      finally
      {
        enumerator1.Dispose();
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num7 = 0;
        switch (num7)
        {
          default:
        }
      }
label_52:
      return new DependencyAnalysisResult()
      {
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dictionary.Values.ToList<DataClassDependency>(),
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>()
      };
    }

    private static (ClassMetadata, IPropertyMetadata) ProcessDynamicViewItem(
      object includedProperty,
      object rootMetadata,
      object options,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies,
      Dictionary<Guid, EnumDependency> enumDependencies)
    {
      switch (((IncludedProperty) includedProperty).PropertyParents.Count)
      {
        case 0:
          return ViewItemsAnalyzerHelper.CaseZeroPropertyParents(((UserDefinedListPropertyBase) includedProperty).OriginalPropertyUid, (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
        case 1:
          return ViewItemsAnalyzerHelper.CaseOnePropertyParents(((UserDefinedListPropertyBase) includedProperty).OriginalPropertyUid, ((IncludedProperty) includedProperty).PropertyParents.ToArray(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
        default:
          return ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(((UserDefinedListPropertyBase) includedProperty).OriginalPropertyUid, ((IncludedProperty) includedProperty).PropertyParents.ToArray(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) options, enumDependencies, entityDependencies, dataClassDependencies);
      }
    }

    private DependencyAnalysisResult AnalyzeMetadata(
      ClassMetadata metadata,
      DependencyServiceOptions options)
    {
      int num1 = 3;
      List<PropertyMetadata>.Enumerator enumerator;
      Dictionary<Guid, FunctionDependency> functionDependencies;
      Dictionary<Guid, DataClassDependency> dictionary;
      Dictionary<Guid, EntityDependency> entityDependencies;
      Dictionary<Guid, EnumDependency> enumDependencies;
      Guid moduleUid;
      while (true)
      {
        switch (num1)
        {
          case 1:
            functionDependencies = new Dictionary<Guid, FunctionDependency>();
            num1 = 5;
            continue;
          case 2:
            enumDependencies = new Dictionary<Guid, EnumDependency>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 3:
            moduleUid = metadata.ModuleUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_3;
          case 5:
            enumerator = metadata.Properties.GetEnumerator();
            num1 = 4;
            continue;
          case 6:
            dictionary = new Dictionary<Guid, DataClassDependency>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
            continue;
          case 7:
            goto label_55;
          default:
            entityDependencies = new Dictionary<Guid, EntityDependency>();
            num1 = 6;
            continue;
        }
      }
label_3:
      try
      {
label_36:
        if (enumerator.MoveNext())
          goto label_39;
        else
          goto label_37;
label_4:
        PropertyMetadata current;
        Guid functionHeaderUid;
        int num2;
        while (true)
        {
          ActionSettings actionSettings;
          int num3;
          switch (num2)
          {
            case 1:
              if (!(((IMetadataService) DependencyService.olYCngbvtaEyOhjAnm8M()).GetMetadata(DependencyService.CAXCMsbv08Jb2SVw8DtR((object) current)) is EntityMetadata metadata1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 26 : 27;
                continue;
              }
              Dictionary<Guid, EntityDependency> classDependencies = entityDependencies;
              Guid subTypeUid = current.SubTypeUid;
              // ISSUE: reference to a compiler-generated field
              Func<EntityMetadata, EntityDependency> func = DependencyService.\u003C\u003Ec.\u003C\u003E9__13_1;
              Func<EntityMetadata, EntityDependency> createDependency;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                DependencyService.\u003C\u003Ec.\u003C\u003E9__13_1 = createDependency = (Func<EntityMetadata, EntityDependency>) (m => m.GetSignature(true));
              }
              else
                goto label_8;
label_44:
              DependencyServiceHelper.AddClassDependency<EntityDependency, EntityMetadata>((IDictionary<Guid, EntityDependency>) classDependencies, subTypeUid, metadata1, createDependency);
              num2 = 3;
              continue;
label_8:
              createDependency = func;
              goto label_44;
            case 2:
              object obj = DependencyService.xFRfskbvdMR3v6c6ytRF((object) actionSettings);
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 28;
                continue;
              }
              num3 = ((ActionValue) obj).CodeType == CodeType.GlobalFunction ? 1 : 0;
              break;
            case 4:
              actionSettings = (ActionSettings) DependencyService.Rlr339bvJo5JYX4pe2h4((object) current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 10 : 3;
              continue;
            case 7:
              if (DependencyServiceHelper.IsDataClass(DependencyService.bb7abGbvxNe4cAO6Upw4((object) current), DependencyService.CAXCMsbv08Jb2SVw8DtR((object) current)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 12 : 11;
                continue;
              }
              goto case 8;
            case 8:
              if (!DependencyService.JkB6hRbvmTGcZLBeFDWM(DependencyService.bb7abGbvxNe4cAO6Upw4((object) current)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 21 : 23;
                continue;
              }
              goto case 1;
            case 10:
              DependencyServiceHelper.AnalyseTypeSignature(actionSettings.ReturnType, (IDictionary<Guid, DataClassDependency>) dictionary, (IDictionary<Guid, EntityDependency>) entityDependencies, (IDictionary<Guid, EnumDependency>) enumDependencies, moduleUid, options);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 31 : 3;
              continue;
            case 11:
            case 23:
              if (!DependencyService.XUJ2ZtbvyskaFTLMXgaN(DependencyService.bb7abGbvxNe4cAO6Upw4((object) current)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 14 : 22;
                continue;
              }
              goto case 16;
            case 12:
              if (!(((IMetadataService) DependencyService.olYCngbvtaEyOhjAnm8M()).GetMetadata(DependencyService.CAXCMsbv08Jb2SVw8DtR((object) current)) is DataClassMetadata metadata2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 11 : 15;
                continue;
              }
              if (DependencyService.HObJU3bvAJYhwU8jRwrx((object) metadata2, moduleUid, (object) options))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 7 : 9;
                continue;
              }
              goto case 17;
            case 13:
              goto label_55;
            case 14:
label_38:
              functionHeaderUid = actionSettings.DefaultValue.FunctionHeaderUid;
              num2 = 19;
              continue;
            case 15:
              goto label_16;
            case 16:
              if (MetadataServiceContext.Service.GetMetadata(DependencyService.CAXCMsbv08Jb2SVw8DtR((object) current)) is EnumMetadata metadata3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 20 : 10;
                continue;
              }
              goto label_23;
            case 17:
              DependencyServiceHelper.AddClassDependency<DataClassDependency, DataClassMetadata>((IDictionary<Guid, DataClassDependency>) dictionary, DependencyService.gFoZYTbv71f0MyEiORob((object) metadata2), metadata2, (Func<DataClassMetadata, DataClassDependency>) (m => m.GetSignature(true)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 22 : 30;
              continue;
            case 18:
              goto label_30;
            case 19:
              if (!(((IMetadataService) DependencyService.olYCngbvtaEyOhjAnm8M()).GetMetadata(functionHeaderUid) is FunctionMetadata metadata4))
              {
                num2 = 18;
                continue;
              }
              if (DependencyService.HObJU3bvAJYhwU8jRwrx((object) metadata4, moduleUid, (object) options))
              {
                num2 = 26;
                continue;
              }
              goto case 21;
            case 20:
              DependencyServiceHelper.AddEnumDependency((IDictionary<Guid, EnumDependency>) enumDependencies, metadata3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 12 : 32;
              continue;
            case 21:
              DependencyServiceHelper.AddFunctionDependency((IDictionary<Guid, FunctionDependency>) functionDependencies, metadata4);
              num2 = 6;
              continue;
            case 22:
            case 24:
              if (!DependencyService.M8wDM1bvMoEWJXaNkqmY(DependencyService.bb7abGbvxNe4cAO6Upw4((object) current)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 25:
              goto label_39;
            case 27:
              goto label_41;
            case 28:
              num3 = 0;
              break;
            case 29:
              goto label_23;
            case 31:
              DependencyServiceHelper.AnalyseTypeSignature((TypeSignature) DependencyService.ejriZ4bv9QGhOis83FfM((object) actionSettings), (IDictionary<Guid, DataClassDependency>) dictionary, (IDictionary<Guid, EntityDependency>) entityDependencies, (IDictionary<Guid, EnumDependency>) enumDependencies, moduleUid, options);
              num2 = 2;
              continue;
            default:
              goto label_36;
          }
          if (num3 == 0)
            num2 = 5;
          else
            goto label_38;
        }
label_16:
        throw new MetadataLoadException(EleWise.ELMA.SR.T((string) DependencyService.c2gICTbvk65apcXGfW2n(~-397266137 ^ 397377366), (object) DependencyService.CAXCMsbv08Jb2SVw8DtR((object) current)));
label_23:
        throw new MetadataLoadException(EleWise.ELMA.SR.T((string) DependencyService.c2gICTbvk65apcXGfW2n(712480695 ^ 712320107), (object) current.SubTypeUid));
label_30:
        throw new MetadataLoadException(EleWise.ELMA.SR.T((string) DependencyService.c2gICTbvk65apcXGfW2n(-281842504 ^ -281945914), (object) functionHeaderUid));
label_41:
        throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360507329), (object) DependencyService.CAXCMsbv08Jb2SVw8DtR((object) current)));
label_37:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 13 : 12;
        goto label_4;
label_39:
        current = enumerator.Current;
        num2 = 7;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_55:
      return new DependencyAnalysisResult()
      {
        EnumDependencies = enumDependencies.Values.ToList<EnumDependency>(),
        EntityDependencies = entityDependencies.Values.ToList<EntityDependency>(),
        DataClassDependencies = dictionary.Values.ToList<DataClassDependency>(),
        FunctionDependencies = functionDependencies.Values.ToList<FunctionDependency>()
      };
    }

    private DependencyAnalysisResult AnalyzeForm(
      ClassMetadata contextMetadata,
      IMetadata metadata,
      FormViewItem form,
      DependencyServiceOptions options)
    {
      int num = 7;
      DependencyAnalysisResult[] dependencyAnalysisResultArray;
      int index;
      IViewItemAnalyzer[] array;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 3:
          case 4:
            dependencyAnalysisResultArray[index] = array[index].Analyse(contextMetadata, metadata, form, options);
            num = 8;
            continue;
          case 5:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 6:
            dependencyAnalysisResultArray = new DependencyAnalysisResult[array.Length];
            num = 5;
            continue;
          case 7:
            array = this.viewItemAnalyzers.ToArray<IViewItemAnalyzer>();
            num = 6;
            continue;
          case 8:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 0;
            continue;
          default:
            if (index < array.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 4 : 3;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return DependencyService.CombineAnalysis(dependencyAnalysisResultArray);
    }

    private DependencyAnalysisResult AnalyzeForm(
      ComponentMetadata componentMetadata,
      DependencyServiceOptions options)
    {
      int num1 = 7;
      DependencyAnalysisResult[] dependencyAnalysisResultArray;
      while (true)
      {
        int num2 = num1;
        int index;
        ComponentContextMetadata componentContextMetadata;
        IViewItemAnalyzer[] array;
        FormViewItem formViewItem;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 5 : 5;
              continue;
            case 3:
            case 5:
              if (index >= array.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 4:
              dependencyAnalysisResultArray[index] = (DependencyAnalysisResult) DependencyService.iT5YvjbvrywIxwEQ2hRj((object) array[index], (object) componentContextMetadata, (object) componentMetadata, (object) formViewItem, (object) options);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 2;
              continue;
            case 6:
              formViewItem = (FormViewItem) DependencyService.HwxbX1bvlQB1GbYN41JP(DependencyService.QTI2A7bvaRJF5HHavBNU((object) componentMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
              continue;
            case 7:
              componentContextMetadata = (ComponentContextMetadata) DependencyService.KrDA0TbvDVGKQFEBT9RN(DependencyService.QTI2A7bvaRJF5HHavBNU((object) componentMetadata));
              num2 = 6;
              continue;
            case 8:
              dependencyAnalysisResultArray = new DependencyAnalysisResult[array.Length];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 9 : 8;
              continue;
            case 9:
              index = 0;
              num2 = 3;
              continue;
            default:
              goto label_10;
          }
        }
label_11:
        array = this.viewItemAnalyzers.ToArray<IViewItemAnalyzer>();
        num1 = 8;
      }
label_10:
      return DependencyService.CombineAnalysis(dependencyAnalysisResultArray);
    }

    private DependencyAnalysisResult AnalyzeImplementations(
      ComponentMetadata componentMetadata,
      DependencyServiceOptions options)
    {
      int num1 = 2;
      Guid currentModuleUid;
      IEnumerator<ExtensionPointViewItem> enumerator1;
      Dictionary<Guid, DataClassDependency> classDependencies;
      List<Implementation>.Enumerator enumerator2;
      FormViewItem view;
      while (true)
      {
        switch (num1)
        {
          case 1:
            classDependencies = new Dictionary<Guid, DataClassDependency>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 0;
            continue;
          case 2:
            object obj = DependencyService.KrDA0TbvDVGKQFEBT9RN(DependencyService.QTI2A7bvaRJF5HHavBNU((object) componentMetadata));
            view = ((ComponentContentMetadata) DependencyService.QTI2A7bvaRJF5HHavBNU((object) componentMetadata)).View;
            currentModuleUid = DependencyService.HEKy63bvOApmSq91eyFs(obj);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
            continue;
          case 3:
            enumerator2 = componentMetadata.Implementations.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_36;
          case 5:
            goto label_2;
          case 6:
label_40:
            enumerator1 = view.FindItems(false, (Func<ViewItem, bool>) (i => i is ExtensionPointViewItem)).OfType<ExtensionPointViewItem>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 5 : 5;
            continue;
          default:
            try
            {
label_22:
              if (enumerator2.MoveNext())
                goto label_26;
              else
                goto label_23;
label_21:
              Implementation current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 7:
                  case 8:
                    goto label_40;
                  case 2:
                    DependencyServiceHelper.AddClassDependency<DataClassDependency, DataClassMetadata>((IDictionary<Guid, DataClassDependency>) classDependencies, metadata.Uid, metadata, (Func<DataClassMetadata, DataClassDependency>) (m => m.GetSignature(true)));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                    continue;
                  case 3:
                    if (!(MetadataServiceContext.Service.GetMetadata(current.TypeUid) is DataClassMetadata metadata))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 9;
                  case 4:
                    if (DependencyService.odEwB2bv4pc624v6UdPE(DependencyService.owrdj0bvgVGy22qc8tGv((object) current), Guid.Empty))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 3 : 1;
                      continue;
                    }
                    goto label_22;
                  case 5:
                    goto label_26;
                  case 9:
                    if (DependencyService.HObJU3bvAJYhwU8jRwrx((object) metadata, currentModuleUid, (object) options))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 7 : 3;
                      continue;
                    }
                    goto case 2;
                  default:
                    goto label_22;
                }
              }
label_23:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 8 : 3;
              goto label_21;
label_26:
              current = enumerator2.Current;
              num2 = 4;
              goto label_21;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
        }
      }
label_2:
      try
      {
label_9:
        if (DependencyService.CtD8R8bvjvsysUiKoAGE((object) enumerator1))
          goto label_8;
        else
          goto label_10;
label_3:
        ExtensionPointViewItem current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
            case 5:
            case 9:
              goto label_36;
            case 2:
              if (!(((IMetadataService) DependencyService.olYCngbvtaEyOhjAnm8M()).GetMetadata(current.TypeUid) is DataClassMetadata metadata))
              {
                num4 = 4;
                continue;
              }
              goto case 7;
            case 3:
              if (DependencyService.odEwB2bv4pc624v6UdPE(DependencyService.TEVRFFbv5AbnJcG0tVVQ((object) current), Guid.Empty))
              {
                num4 = 2;
                continue;
              }
              goto label_9;
            case 4:
            case 6:
              goto label_9;
            case 7:
              if (DependencyService.HObJU3bvAJYhwU8jRwrx((object) metadata, currentModuleUid, (object) options))
              {
                num4 = 5;
                continue;
              }
              goto case 8;
            case 8:
              DependencyServiceHelper.AddClassDependency<DataClassDependency, DataClassMetadata>((IDictionary<Guid, DataClassDependency>) classDependencies, DependencyService.gFoZYTbv71f0MyEiORob((object) metadata), metadata, (Func<DataClassMetadata, DataClassDependency>) (m => m.GetSignature(true)));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        current = enumerator1.Current;
        num4 = 3;
        goto label_3;
label_10:
        num4 = 9;
        goto label_3;
      }
      finally
      {
        int num5;
        if (enumerator1 == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
        else
          goto label_17;
label_16:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_17:
        enumerator1.Dispose();
        num5 = 2;
        goto label_16;
      }
label_36:
      return new DependencyAnalysisResult()
      {
        DataClassDependencies = classDependencies.Values.ToList<DataClassDependency>()
      };
    }

    /// <summary>Отфильтровать список зависимостей</summary>
    /// <typeparam name="T">Тип элементов в списке</typeparam>
    /// <param name="dependencies">Список зависимостей</param>
    /// <param name="ignoredMetadata">Список идентификаторов зависимостей, которые игнорируем</param>
    private static IEnumerable<T> Filter<T>(IEnumerable<T> dependencies, ISet<Guid> ignoredMetadata) where T : Dependency => dependencies.Where<T>((Func<T, bool>) (d => !ignoredMetadata.Contains(d.HeaderUid)));

    internal static object c2gICTbvk65apcXGfW2n(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void F9eHGZbvnkXa4Mk1Y2ru([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool AjAjEVbvXTmbuTFqEG45() => DependencyService.sp0IUXbvK8bdSDlJQl18 == null;

    internal static DependencyService MWgt0hbvTvkPbmqdNIB1() => DependencyService.sp0IUXbvK8bdSDlJQl18;

    internal static Guid HEKy63bvOApmSq91eyFs([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static object n0YRSObv2XAxpoX0UQlM([In] object obj0) => (object) ((FunctionMetadata) obj0).ReturnType;

    internal static object jlmiATbve17BFPFXcRrv([In] object obj0) => (object) ((FunctionMetadata) obj0).ParameterType;

    internal static object kgbPeabvPAtDlQBNfhBw([In] object obj0, [In] object obj1)
    {
      return (object) CheckCompatibility((TypeSignature) obj0, (TypeSignature) obj1);

      static CompatibilityResult CheckCompatibility(
        TypeSignature currentTypeSignature,
        TypeSignature candidateTypeSignature)
      {
        int num = 2;
        CompatibilityResult compatibilityResult;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!DependencyService.orUEiNbvNLsroV3H7Pjg((object) compatibilityResult))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              compatibilityResult = (CompatibilityResult) DependencyService.hcFW6pbvYeGwmQdvUWYp((object) currentTypeSignature, (object) candidateTypeSignature);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_4;
          }
        }
label_3:
        return new CompatibilityResult(true, Array.Empty<string>());
label_4:
        return compatibilityResult;
      }
    }

    internal static object axXn7dbv1ladSSjMWnDj([In] object obj0) => (object) ((FunctionDependency) obj0).ReturnType;

    internal static bool orUEiNbvNLsroV3H7Pjg([In] object obj0) => ((CompatibilityResult) obj0).IsValid;

    internal static object iiPPVpbv3BQSSI4Ofp5X([In] object obj0) => (object) ((CompatibilityResult) obj0).Errors;

    internal static object sjZe6YbvpKOvBcW3EKPb([In] object obj0, [In] object obj1) => (object) ((DataClassDependency) obj0).Compatible((DataClassDependency) obj1);

    internal static object QTI2A7bvaRJF5HHavBNU([In] object obj0) => (object) ((ComponentMetadata) obj0).Content;

    internal static object KrDA0TbvDVGKQFEBT9RN([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;

    internal static object olYCngbvtaEyOhjAnm8M() => (object) MetadataServiceContext.Service;

    internal static Guid fpnHsdbvwQcMsY9OeIVr([In] object obj0) => ((UserDefinedListInfo) obj0).SubTypeUid;

    internal static bool odEwB2bv4pc624v6UdPE([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid rolJUebv6FAPa9koNeXH([In] object obj0) => ((UserDefinedListPropertyBase) obj0).OriginalPropertyUid;

    internal static bool CrNTHAbvHLlWCoWxKx2A([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool HObJU3bvAJYhwU8jRwrx([In] object obj0, Guid currentModuleUid, [In] object obj2) => DependencyServiceHelper.SkipDependency((IMetadata) obj0, currentModuleUid, (DependencyServiceOptions) obj2);

    internal static Guid gFoZYTbv71f0MyEiORob([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid bb7abGbvxNe4cAO6Upw4([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid CAXCMsbv08Jb2SVw8DtR([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static bool JkB6hRbvmTGcZLBeFDWM(Guid typeUid) => DependencyServiceHelper.IsEntity(typeUid);

    internal static bool XUJ2ZtbvyskaFTLMXgaN(Guid typeUid) => DependencyServiceHelper.IsEnum(typeUid);

    internal static bool M8wDM1bvMoEWJXaNkqmY(Guid typeUid) => DependencyServiceHelper.IsAction(typeUid);

    internal static object Rlr339bvJo5JYX4pe2h4([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object ejriZ4bv9QGhOis83FfM([In] object obj0) => (object) ((ActionSettings) obj0).ParameterType;

    internal static object xFRfskbvdMR3v6c6ytRF([In] object obj0) => (object) ((ActionSettings) obj0).DefaultValue;

    internal static object HwxbX1bvlQB1GbYN41JP([In] object obj0) => (object) ((ComponentContentMetadata) obj0).View;

    internal static object iT5YvjbvrywIxwEQ2hRj(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((IViewItemAnalyzer) obj0).Analyse((ClassMetadata) obj1, (IMetadata) obj2, (FormViewItem) obj3, (DependencyServiceOptions) obj4);
    }

    internal static Guid owrdj0bvgVGy22qc8tGv([In] object obj0) => ((Implementation) obj0).TypeUid;

    internal static Guid TEVRFFbv5AbnJcG0tVVQ([In] object obj0) => ((ExtensionPointViewItem) obj0).TypeUid;

    internal static bool CtD8R8bvjvsysUiKoAGE([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object hcFW6pbvYeGwmQdvUWYp([In] object obj0, [In] object obj1) => (object) ((TypeSignature) obj0).Compatible((TypeSignature) obj1);
  }
}
