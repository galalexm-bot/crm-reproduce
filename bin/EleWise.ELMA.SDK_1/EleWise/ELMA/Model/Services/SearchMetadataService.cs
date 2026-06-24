// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.SearchMetadataService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class SearchMetadataService : 
    ISearchMetadataServiceInternal,
    ISearchMetadataService
  {
    private readonly ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager;
    private readonly ModuleMetadataItemManager moduleMetadataItemManager;
    private readonly IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager;
    private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;
    private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private IEnumerable<DataClassMetadata> nonInternalDraftDataClasses;
    private static SearchMetadataService mg8t4UbvSG6WDyJheU2n;

    /// <summary>Ctor</summary>
    /// <param name="moduleMetadataItemHeaderManager">Менеджер заголовков метаданных модулей</param>
    /// <param name="moduleMetadataItemManager">Менеджер метаданных модулей</param>
    /// <param name="dataClassMetadataItemHeaderManager">Менеджер заголовков метаданных DataClass</param>
    /// <param name="functionMetadataItemHeaderManager">Менеджер заголовка метаданных функций</param>
    /// <param name="componentMetadataItemHeaderManager">Менеджер заголовков метаданных компонента</param>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    public SearchMetadataService(
      ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager,
      ModuleMetadataItemManager moduleMetadataItemManager,
      IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager,
      IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager,
      IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager,
      IModuleMetadataLoader moduleMetadataLoader)
    {
      SearchMetadataService.G4vVIQbvqBSU99i6udTR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
            num = 2;
            continue;
          case 2:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = 5;
            continue;
          case 3:
            this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
            continue;
          case 4:
            this.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
            num = 3;
            continue;
          case 5:
            goto label_3;
          case 6:
            this.moduleMetadataItemHeaderManager = moduleMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          default:
            this.moduleMetadataItemManager = moduleMetadataItemManager;
            num = 4;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IEnumerable<DataClassMetadata> GetPublishedDataClasses()
    {
      // ISSUE: reference to a compiler-generated method
      List<DataClassMetadata> list = this.dataClassMetadataItemHeaderManager.GetAllPublished().Select<DataClassMetadataItemHeader, DataClassMetadataItem>((Func<DataClassMetadataItemHeader, DataClassMetadataItem>) (a => a.Published)).Select<DataClassMetadataItem, DataClassMetadata>((Func<DataClassMetadataItem, DataClassMetadata>) (configurationDataClass => (DataClassMetadata) SearchMetadataService.\u003C\u003Ec.A2qSPFCON0hTI70WJkDZ((object) configurationDataClass))).ToList<DataClassMetadata>();
      foreach (ModuleVersion allDefaultVersion in (IEnumerable<ModuleVersion>) this.moduleMetadataLoader.GetAllDefaultVersions(Enumerable.Empty<Guid>()))
        list.AddRange((IEnumerable<DataClassMetadata>) allDefaultVersion.Metadata.DataClasses);
      return (IEnumerable<DataClassMetadata>) list;
    }

    /// <inheritdoc />
    public IEnumerable<DataClassAssemblyInfo> GetPublishedDataClassAssemblies()
    {
      List<DataClassMetadataItem> list1 = this.dataClassMetadataItemHeaderManager.GetAllPublished().Select<DataClassMetadataItemHeader, DataClassMetadataItem>((Func<DataClassMetadataItemHeader, DataClassMetadataItem>) (a => a.Published)).ToList<DataClassMetadataItem>();
      // ISSUE: reference to a compiler-generated method
      List<ModuleMetadataItem> list2 = this.moduleMetadataItemHeaderManager.GetAllPublished().Select<ModuleMetadataItemHeader, ModuleMetadataItem>((Func<ModuleMetadataItemHeader, ModuleMetadataItem>) (a => (ModuleMetadataItem) SearchMetadataService.\u003C\u003Ec.elnmrmCO373LcKiG5fej((object) a))).ToList<ModuleMetadataItem>();
      List<DataClassAssemblyInfo> dataClassAssemblies1 = new List<DataClassAssemblyInfo>(list1.Count + list2.Count);
      dataClassAssemblies1.AddRange(list1.Select<DataClassMetadataItem, DataClassAssemblyInfo>((Func<DataClassMetadataItem, DataClassAssemblyInfo>) (dataClass =>
      {
        DataClassAssemblyInfo dataClassAssemblies2 = new DataClassAssemblyInfo();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.eZStCNCOaXfjk4tnjCme((object) dataClassAssemblies2, SearchMetadataService.\u003C\u003Ec.fycnWqCOpF8XlDU4D812((object) dataClass));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.AdSMQcCOt5xGKgEQMqj0((object) dataClassAssemblies2, SearchMetadataService.\u003C\u003Ec.Dc6J1SCODChmLXqhVch4((object) dataClass));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.gYOL8ACO4HGrm9mpCrGT((object) dataClassAssemblies2, SearchMetadataService.\u003C\u003Ec.jidC5xCOwbr58peZV9yg((object) dataClass));
        return dataClassAssemblies2;
      })));
      dataClassAssemblies1.AddRange(list2.Select<ModuleMetadataItem, DataClassAssemblyInfo>((Func<ModuleMetadataItem, DataClassAssemblyInfo>) (module =>
      {
        DataClassAssemblyInfo dataClassAssemblies3 = new DataClassAssemblyInfo();
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.eZStCNCOaXfjk4tnjCme((object) dataClassAssemblies3, (object) module.AssemblyName);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.AdSMQcCOt5xGKgEQMqj0((object) dataClassAssemblies3, SearchMetadataService.\u003C\u003Ec.oGUv0rCO6DTjcI4apRVc((object) module));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.gYOL8ACO4HGrm9mpCrGT((object) dataClassAssemblies3, SearchMetadataService.\u003C\u003Ec.zJB2VsCOHJ0Rb5HSS2tj((object) module));
        return dataClassAssemblies3;
      })));
      return (IEnumerable<DataClassAssemblyInfo>) dataClassAssemblies1;
    }

    /// <inheritdoc />
    public IEnumerable<DataClassMetadata> GetDraftDataClasses()
    {
      // ISSUE: reference to a compiler-generated method
      List<DataClassMetadataItem> list = this.dataClassMetadataItemHeaderManager.GetAllDrafts().Select<DataClassMetadataItemHeader, DataClassMetadataItem>((Func<DataClassMetadataItemHeader, DataClassMetadataItem>) (a => (DataClassMetadataItem) SearchMetadataService.\u003C\u003Ec.VKXxATCOA7JXVPu2QfjJ((object) a))).ToList<DataClassMetadataItem>();
      IEnumerable<DataClassMetadata> second = this.moduleMetadataItemHeaderManager.GetAllPublished().SelectMany<ModuleMetadataItemHeader, DataClassMetadata>((Func<ModuleMetadataItemHeader, IEnumerable<DataClassMetadata>>) (a => (IEnumerable<DataClassMetadata>) ((ModuleInfoMetadata) a.Published.Metadata).DataClasses));
      return list.Select<DataClassMetadataItem, DataClassMetadata>((Func<DataClassMetadataItem, DataClassMetadata>) (configurationDataClass => (DataClassMetadata) configurationDataClass.Metadata)).Concat<DataClassMetadata>(second);
    }

    /// <inheritdoc />
    public IEnumerable<DataClassMetadata> GetNonInternalDraftDataClasses()
    {
      if (this.nonInternalDraftDataClasses != null)
        return this.nonInternalDraftDataClasses;
      // ISSUE: reference to a compiler-generated method
      IEnumerable<DataClassMetadataItem> source = this.dataClassMetadataItemHeaderManager.GetAllDrafts().Select<DataClassMetadataItemHeader, DataClassMetadataItem>((Func<DataClassMetadataItemHeader, DataClassMetadataItem>) (a => (DataClassMetadataItem) SearchMetadataService.\u003C\u003Ec.VKXxATCOA7JXVPu2QfjJ((object) a)));
      // ISSUE: reference to a compiler-generated method
      IEnumerable<DataClassMetadata> second = this.moduleMetadataItemManager.GetLastPublished((IEnumerable<Guid>) ModuleMetadataItemHeaderManager.DesignerModules).SelectMany<ModuleMetadataItem, DataClassMetadata>((Func<ModuleMetadataItem, IEnumerable<DataClassMetadata>>) (a => (IEnumerable<DataClassMetadata>) ((ModuleInfoMetadata) a.Metadata).DataClasses)).Where<DataClassMetadata>((Func<DataClassMetadata, bool>) (a => !SearchMetadataService.\u003C\u003Ec.FEBpKJCO7HMj5fXYoQ8Q((object) a)));
      // ISSUE: reference to a compiler-generated method
      this.nonInternalDraftDataClasses = source.Select<DataClassMetadataItem, DataClassMetadata>((Func<DataClassMetadataItem, DataClassMetadata>) (configurationDataClass => (DataClassMetadata) SearchMetadataService.\u003C\u003Ec.A2qSPFCON0hTI70WJkDZ((object) configurationDataClass))).Concat<DataClassMetadata>(second);
      return this.nonInternalDraftDataClasses;
    }

    /// <inheritdoc />
    public IEnumerable<FunctionMetadata> GetPublishedFunctions()
    {
      // ISSUE: reference to a compiler-generated method
      List<FunctionMetadata> list = this.functionMetadataItemHeaderManager.GetAllPublished().Select<FunctionMetadataItemHeader, FunctionMetadataItem>((Func<FunctionMetadataItemHeader, FunctionMetadataItem>) (a => (FunctionMetadataItem) SearchMetadataService.\u003C\u003Ec.WwDfaMCOxnwqNXTxluSw((object) a))).ToList<FunctionMetadataItem>().Select<FunctionMetadataItem, FunctionMetadata>((Func<FunctionMetadataItem, FunctionMetadata>) (configurationFunction =>
      {
        // ISSUE: reference to a compiler-generated method
        FunctionMetadata publishedFunctions = (FunctionMetadata) ClassSerializationHelper.CloneObjectByXml<object>(SearchMetadataService.\u003C\u003Ec.CfFr7YCO0ctEVv9uUypl((object) configurationFunction));
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.odmBM5COmbXt7HG60UkV((object) publishedFunctions, configurationFunction.Header.Uid);
        return publishedFunctions;
      })).ToList<FunctionMetadata>();
      // ISSUE: reference to a compiler-generated method
      foreach (ModuleMetadataItem moduleMetadataItem in this.moduleMetadataItemHeaderManager.GetAllPublished().Select<ModuleMetadataItemHeader, ModuleMetadataItem>((Func<ModuleMetadataItemHeader, ModuleMetadataItem>) (a => (ModuleMetadataItem) SearchMetadataService.\u003C\u003Ec.elnmrmCO373LcKiG5fej((object) a))).ToList<ModuleMetadataItem>())
        list.AddRange((IEnumerable<FunctionMetadata>) ((ModuleInfoMetadata) moduleMetadataItem.Metadata).Functions);
      return (IEnumerable<FunctionMetadata>) list;
    }

    /// <inheritdoc />
    public IEnumerable<FunctionMetadata> GetDraftFunctions()
    {
      // ISSUE: reference to a compiler-generated method
      List<FunctionMetadata> list = this.functionMetadataItemHeaderManager.GetAllDrafts().Select<FunctionMetadataItemHeader, FunctionMetadataItem>((Func<FunctionMetadataItemHeader, FunctionMetadataItem>) (a => (FunctionMetadataItem) SearchMetadataService.\u003C\u003Ec.maXl9oCOyyZHp79SkOHJ((object) a))).Select<FunctionMetadataItem, FunctionMetadata>((Func<FunctionMetadataItem, FunctionMetadata>) (configurationFunction =>
      {
        // ISSUE: reference to a compiler-generated method
        FunctionMetadata draftFunctions = (FunctionMetadata) ClassSerializationHelper.CloneObjectByXml<object>(SearchMetadataService.\u003C\u003Ec.CfFr7YCO0ctEVv9uUypl((object) configurationFunction));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.odmBM5COmbXt7HG60UkV((object) draftFunctions, SearchMetadataService.\u003C\u003Ec.g2HwvXCOM9GMPPkayusC((object) configurationFunction.Header));
        return draftFunctions;
      })).ToList<FunctionMetadata>();
      // ISSUE: reference to a compiler-generated method
      foreach (ModuleMetadataItem moduleMetadataItem in this.moduleMetadataItemHeaderManager.GetAllPublished().Select<ModuleMetadataItemHeader, ModuleMetadataItem>((Func<ModuleMetadataItemHeader, ModuleMetadataItem>) (a => (ModuleMetadataItem) SearchMetadataService.\u003C\u003Ec.elnmrmCO373LcKiG5fej((object) a))).ToList<ModuleMetadataItem>())
        list.AddRange((IEnumerable<FunctionMetadata>) ((ModuleInfoMetadata) moduleMetadataItem.Metadata).Functions);
      return (IEnumerable<FunctionMetadata>) list;
    }

    /// <inheritdoc />
    public IEnumerable<ComponentMetadata> GetPublishedComponents()
    {
      // ISSUE: reference to a compiler-generated method
      List<ComponentMetadata> list = this.componentMetadataItemHeaderManager.GetAllPublished().Select<ComponentMetadataItemHeader, ComponentMetadataItem>((Func<ComponentMetadataItemHeader, ComponentMetadataItem>) (a => (ComponentMetadataItem) SearchMetadataService.\u003C\u003Ec.HcuMJWCOJaRlIl7AdQFI((object) a))).ToList<ComponentMetadataItem>().Select<ComponentMetadataItem, ComponentMetadata>((Func<ComponentMetadataItem, ComponentMetadata>) (configurationComponent =>
      {
        // ISSUE: reference to a compiler-generated method
        ComponentMetadata publishedComponents = (ComponentMetadata) ClassSerializationHelper.CloneObjectByXml<object>(SearchMetadataService.\u003C\u003Ec.lmYmW5CO9DWkELBET7Xa((object) configurationComponent));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.odmBM5COmbXt7HG60UkV((object) publishedComponents, SearchMetadataService.\u003C\u003Ec.eUZFurCOlGQ2GmdQYQid(SearchMetadataService.\u003C\u003Ec.NklCmBCOd9LN9ULsuE6k((object) configurationComponent)));
        return publishedComponents;
      })).ToList<ComponentMetadata>();
      // ISSUE: reference to a compiler-generated method
      foreach (ModuleMetadataItem moduleMetadataItem in this.moduleMetadataItemHeaderManager.GetAllPublished().Select<ModuleMetadataItemHeader, ModuleMetadataItem>((Func<ModuleMetadataItemHeader, ModuleMetadataItem>) (a => (ModuleMetadataItem) SearchMetadataService.\u003C\u003Ec.elnmrmCO373LcKiG5fej((object) a))).ToList<ModuleMetadataItem>())
        list.AddRange((IEnumerable<ComponentMetadata>) ((ModuleInfoMetadata) moduleMetadataItem.Metadata).Components);
      return (IEnumerable<ComponentMetadata>) list;
    }

    /// <inheritdoc />
    public IEnumerable<ComponentMetadata> GetDraftComponents()
    {
      // ISSUE: reference to a compiler-generated method
      List<ComponentMetadata> list = this.componentMetadataItemHeaderManager.GetAllDrafts().Select<ComponentMetadataItemHeader, ComponentMetadataItem>((Func<ComponentMetadataItemHeader, ComponentMetadataItem>) (a => (ComponentMetadataItem) SearchMetadataService.\u003C\u003Ec.JeAdL4COrVBBj2nSR0Gd((object) a))).ToList<ComponentMetadataItem>().Select<ComponentMetadataItem, ComponentMetadata>((Func<ComponentMetadataItem, ComponentMetadata>) (configurationComponent =>
      {
        // ISSUE: reference to a compiler-generated method
        ComponentMetadata draftComponents = (ComponentMetadata) ClassSerializationHelper.CloneObjectByXml<object>(SearchMetadataService.\u003C\u003Ec.lmYmW5CO9DWkELBET7Xa((object) configurationComponent));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SearchMetadataService.\u003C\u003Ec.odmBM5COmbXt7HG60UkV((object) draftComponents, SearchMetadataService.\u003C\u003Ec.eUZFurCOlGQ2GmdQYQid(SearchMetadataService.\u003C\u003Ec.NklCmBCOd9LN9ULsuE6k((object) configurationComponent)));
        return draftComponents;
      })).ToList<ComponentMetadata>();
      // ISSUE: reference to a compiler-generated method
      foreach (ModuleMetadataItem moduleMetadataItem in this.moduleMetadataItemHeaderManager.GetAllPublished().Select<ModuleMetadataItemHeader, ModuleMetadataItem>((Func<ModuleMetadataItemHeader, ModuleMetadataItem>) (a => (ModuleMetadataItem) SearchMetadataService.\u003C\u003Ec.elnmrmCO373LcKiG5fej((object) a))).ToList<ModuleMetadataItem>())
        list.AddRange((IEnumerable<ComponentMetadata>) ((ModuleInfoMetadata) moduleMetadataItem.Metadata).Components);
      return (IEnumerable<ComponentMetadata>) list;
    }

    /// <inheritdoc />
    void ISearchMetadataServiceInternal.ClearCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.nonInternalDraftDataClasses = (IEnumerable<DataClassMetadata>) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void G4vVIQbvqBSU99i6udTR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool WSQZg2bvidIAq3iRKSyV() => SearchMetadataService.mg8t4UbvSG6WDyJheU2n == null;

    internal static SearchMetadataService zgQwLqbvRtx5Mw9FThX8() => SearchMetadataService.mg8t4UbvSG6WDyJheU2n;
  }
}
