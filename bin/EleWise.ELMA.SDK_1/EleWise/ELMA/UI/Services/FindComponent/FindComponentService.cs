// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.FindComponent.FindComponentService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Components;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Components.Dependency;
using EleWise.ELMA.UI.Components.Dependency.Models;
using EleWise.ELMA.UI.Helpers;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services.FindComponent.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services.FindComponent
{
  /// <inheritdoc />
  [Service]
  internal sealed class FindComponentService : 
    ICleanUIObjectsService,
    IFindComponentServiceInternal,
    IFindComponentService
  {
    private readonly IEnumerable<IDependencyFinder> dependencyFinders;
    private readonly ITransformationProvider transformationProvider;
    private readonly ISessionProvider sessionProvider;
    private readonly IModuleReferenceManager moduleReferenceManager;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private readonly IDependencyService dependencyService;
    private readonly ModuleMetadataCompatibilityChecker moduleMetadataCompatibilityChecker;
    private readonly Dictionary<Guid, ComponentMetadataItem> loadedComponents;
    private readonly Dictionary<Guid, FunctionMetadataItem> loadedFunctions;
    private readonly ConcurrentDictionary<Guid, RecursiveComponentModel> moduleApplicationCacheResult;
    internal static FindComponentService P0XQefzXow7msOjblcG;

    private void CleanModules(Guid[] modules)
    {
      int num = 4;
      ModuleVersionHeader[] array;
      Dictionary<Guid, List<ModuleVersionHeader>> modulesDictionary;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.DeleteVersions(array);
            num = 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            array = this.FirstStepCleanCompatibleVersions((IEnumerable<Guid>) modules, modulesDictionary).Concat<ModuleVersionHeader>(this.SecondStepCleanCompatibleVersions((IEnumerable<Guid>) modules, modulesDictionary)).ToArray<ModuleVersionHeader>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 4:
            modulesDictionary = new Dictionary<Guid, List<ModuleVersionHeader>>();
            num = 3;
            continue;
          default:
            if (array.Length != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
              continue;
            }
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    private void DeleteVersions(ModuleVersionHeader[] versionsToDelete)
    {
      int num1 = 2;
      HashSet<Guid> hashSet;
      IEnumerator<IEnumerable<Guid>> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_24;
          case 1:
            if (FindComponentService.ehvH7RznYpL4PA3dcfB((object) hashSet) != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 3 : 5;
              continue;
            }
            goto label_20;
          case 2:
            ModuleVersionHeader[] source = versionsToDelete;
            // ISSUE: reference to a compiler-generated field
            Func<ModuleVersionHeader, Guid> func = FindComponentService.\u003C\u003Ec.\u003C\u003E9__1_0;
            Func<ModuleVersionHeader, Guid> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              FindComponentService.\u003C\u003Ec.\u003C\u003E9__1_0 = selector = (Func<ModuleVersionHeader, Guid>) (v => FindComponentService.\u003C\u003Ec.mpWVMEfcaVevVJr0RSIV((object) v));
            }
            else
              goto label_27;
label_26:
            hashSet = ((IEnumerable<ModuleVersionHeader>) source).Select<ModuleVersionHeader, Guid>(selector).ToHashSet<Guid>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
label_27:
            selector = func;
            goto label_26;
          case 3:
            goto label_2;
          case 4:
            goto label_4;
          case 5:
            enumerator = hashSet.Chunk<Guid>(1000).GetEnumerator();
            num1 = 4;
            continue;
          default:
            goto label_17;
        }
      }
label_24:
      return;
label_2:
      return;
label_17:
      return;
label_4:
      try
      {
label_8:
        if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator))
          goto label_10;
        else
          goto label_9;
label_5:
        int num2;
        IEnumerable<Guid> chunk;
        FindComponentService componentService;
        while (true)
        {
          switch (num2)
          {
            case 1:
              chunk = enumerator.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 5 : 0;
              continue;
            case 2:
              componentService = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_10;
            case 4:
              goto label_12;
            case 5:
              FindComponentService.a1VJ1AzO2HAIBOnZwkj((object) this.Session, 0, (object) (System.Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      FindComponentService.\u003C\u003Ec__DisplayClass1_0.iVTYyYfcPZHFstBNEdDj(FindComponentService.\u003C\u003Ec__DisplayClass1_0.EiVempfceJuSna2PsAU4(FindComponentService.\u003C\u003Ec__DisplayClass1_0.K4gpxcfc2eOmeWSb7NZO((object) componentService.Session, FindComponentService.\u003C\u003Ec__DisplayClass1_0.jXKQDvfcOF7YkZcMLjXw(FindComponentService.\u003C\u003Ec__DisplayClass1_0.l0bPPxfcTUwHcG9xR2Ff(~-122002947 ^ 121697410), FindComponentService.\u003C\u003Ec__DisplayClass1_0.kB8FKIfcnxmRE9waa7GW(FindComponentService.\u003C\u003Ec__DisplayClass1_0.jmF1KOfcky2ohdSJY34I((object) componentService.transformationProvider), FindComponentService.\u003C\u003Ec__DisplayClass1_0.l0bPPxfcTUwHcG9xR2Ff(1251470110 >> 2 ^ 312968373)), (object) ((Dialect) FindComponentService.\u003C\u003Ec__DisplayClass1_0.jmF1KOfcky2ohdSJY34I((object) componentService.transformationProvider)).QuoteIfNeeded((string) FindComponentService.\u003C\u003Ec__DisplayClass1_0.l0bPPxfcTUwHcG9xR2Ff(~-306453669 ^ 306475830)), FindComponentService.\u003C\u003Ec__DisplayClass1_0.l0bPPxfcTUwHcG9xR2Ff(132912447 ^ 132743157))), FindComponentService.\u003C\u003Ec__DisplayClass1_0.l0bPPxfcTUwHcG9xR2Ff(1178210108 ^ 1178559990), (object) chunk.ToArray<Guid>()));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            default:
              goto label_8;
          }
        }
label_12:
        return;
label_9:
        num2 = 4;
        goto label_5;
label_10:
        num2 = 2;
        goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
label_20:;
    }

    private IEnumerable<ModuleVersionHeader> FirstStepCleanCompatibleVersions(
      IEnumerable<Guid> modules,
      Dictionary<Guid, List<ModuleVersionHeader>> modulesDictionary)
    {
      List<ModuleVersionHeader> moduleVersionHeaderList1 = new List<ModuleVersionHeader>();
      foreach (Guid module in modules)
      {
        List<ModuleVersionHeader> list = this.moduleMetadataLoader.GetModuleVersionHeaders(module).ToList<ModuleVersionHeader>();
        modulesDictionary[module] = list;
        List<ModuleVersionHeader> moduleVersionHeaderList2 = new List<ModuleVersionHeader>();
        this.CheckModuleCompatibilityAndDeleteCompatibleVersions(list, moduleVersionHeaderList2);
        moduleVersionHeaderList1.AddRange((IEnumerable<ModuleVersionHeader>) moduleVersionHeaderList2);
        foreach (ModuleVersionHeader moduleVersionHeader in moduleVersionHeaderList2)
          list.Remove(moduleVersionHeader);
      }
      return (IEnumerable<ModuleVersionHeader>) moduleVersionHeaderList1;
    }

    private IEnumerable<ModuleVersionHeader> SecondStepCleanCompatibleVersions(
      IEnumerable<Guid> modules,
      Dictionary<Guid, List<ModuleVersionHeader>> modulesDictionary)
    {
      List<DependencyRequest> dependencyRequestList = new List<DependencyRequest>();
      foreach (Guid module in modules)
      {
        List<ModuleVersionHeader> moduleVersionHeaderList;
        if (modulesDictionary.TryGetValue(module, out moduleVersionHeaderList) && moduleVersionHeaderList.Count != 0 && moduleVersionHeaderList.Count != 1)
        {
          DependencyRequest dependencyRequest = new DependencyRequest()
          {
            ModuleUid = module
          };
          dependencyRequestList.Add(dependencyRequest);
        }
      }
      List<ModuleVersionHeader> moduleVersionHeaderList1 = new List<ModuleVersionHeader>();
      if (dependencyRequestList.Count == 0)
        return (IEnumerable<ModuleVersionHeader>) moduleVersionHeaderList1;
      List<EleWise.ELMA.Model.Dependencies.Dependency> collection1 = new List<EleWise.ELMA.Model.Dependencies.Dependency>();
      foreach (IDependencyFinder dependencyFinder in this.dependencyFinders)
      {
        IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> dependencies = dependencyFinder.GetDependencies((IEnumerable<IDependencyRequest>) dependencyRequestList);
        collection1.AddRange(dependencies);
      }
      List<EleWise.ELMA.Model.Dependencies.Dependency> dependencyList = new List<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) collection1);
      Dictionary<Guid, List<ModuleVersionHeader>> dictionary = new Dictionary<Guid, List<ModuleVersionHeader>>();
      foreach (EleWise.ELMA.Model.Dependencies.Dependency dependency in collection1)
      {
        Guid moduleUid = dependency.ModuleUid;
        List<ModuleVersionHeader> moduleVersionHeaderList2;
        if (modulesDictionary.TryGetValue(moduleUid, out moduleVersionHeaderList2))
        {
          List<ModuleVersionHeader> moduleVersionHeaderList3;
          if (!dictionary.TryGetValue(moduleUid, out moduleVersionHeaderList3))
            moduleVersionHeaderList3 = dictionary[moduleUid] = new List<ModuleVersionHeader>();
          foreach (ModuleVersionHeader moduleVersionHeader in moduleVersionHeaderList2)
          {
            ModuleSignature signature = moduleVersionHeader.Signature;
            if (signature != null)
            {
              if (dependency is FunctionDependency current1)
              {
                Guid functionDependencyHeaderUid = current1.HeaderUid;
                // ISSUE: reference to a compiler-generated method
                FunctionDependency candidate = signature.Functions.FirstOrDefault<FunctionDependency>((Func<FunctionDependency, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass3_0.yGZLwFfcl44janhxqkip(a.HeaderUid, functionDependencyHeaderUid)));
                if (candidate != null)
                {
                  if (this.dependencyService.CheckFunctionCompatibility(current1, candidate).IsValid)
                  {
                    dependencyList.Remove(dependency);
                    moduleVersionHeaderList3.Add(moduleVersionHeader);
                    break;
                  }
                }
                else
                  continue;
              }
              if (dependency is DataClassDependency current2)
              {
                Guid dataclassDependencyHeaderUid = current2.HeaderUid;
                // ISSUE: reference to a compiler-generated method
                DataClassDependency candidate = signature.DataClasses.FirstOrDefault<DataClassDependency>((Func<DataClassDependency, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass3_1.K1myH1fcYqbGtkFklqnd(a.HeaderUid, dataclassDependencyHeaderUid)));
                if (candidate != null)
                {
                  if (this.dependencyService.CheckDataClassCompatibility(current2, candidate).IsValid)
                  {
                    dependencyList.Remove(dependency);
                    moduleVersionHeaderList3.Add(moduleVersionHeader);
                    break;
                  }
                }
                else
                  continue;
              }
              if (dependency is ComponentDependency componentDependency)
              {
                Guid componentDependencyHeaderUid = componentDependency.HeaderUid;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ComponentSignature componentSignature = signature.Components.FirstOrDefault<ComponentSignature>((Func<ComponentSignature, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass3_2.OacXmVfzFg45TNt1FtVh(FindComponentService.\u003C\u003Ec__DisplayClass3_2.Ovpl5XfczFwcjfGJXJY6((object) a), componentDependencyHeaderUid)));
                if (componentSignature != null && CheckComponentHelper.CheckSignature(componentDependency, componentSignature).IsValid)
                {
                  dependencyList.Remove(dependency);
                  moduleVersionHeaderList3.Add(moduleVersionHeader);
                  break;
                }
              }
            }
          }
        }
      }
      if (dependencyList.Count > 0)
        EleWise.ELMA.Logging.Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154127503)));
      foreach (KeyValuePair<Guid, List<ModuleVersionHeader>> keyValuePair in dictionary)
      {
        List<ModuleVersionHeader> collection2 = new List<ModuleVersionHeader>((IEnumerable<ModuleVersionHeader>) modulesDictionary[keyValuePair.Key]);
        foreach (ModuleVersionHeader moduleVersionHeader in keyValuePair.Value)
          collection2.Remove(moduleVersionHeader);
        moduleVersionHeaderList1.AddRange((IEnumerable<ModuleVersionHeader>) collection2);
      }
      return (IEnumerable<ModuleVersionHeader>) moduleVersionHeaderList1;
    }

    private void CheckModuleCompatibilityAndDeleteCompatibleVersions(
      List<ModuleVersionHeader> moduleVersions,
      List<ModuleVersionHeader> versionsToDelete)
    {
      if (moduleVersions.Count <= 1)
        return;
      ModuleVersionHeader moduleVersion = moduleVersions[0];
      List<ModuleVersionHeader> list = moduleVersions.Except<ModuleVersionHeader>((IEnumerable<ModuleVersionHeader>) new ModuleVersionHeader[1]
      {
        moduleVersion
      }).ToList<ModuleVersionHeader>();
      foreach (ModuleVersionHeader moduleVersionHeader in this.Check((IEnumerable<ModuleVersionHeader>) list, moduleVersion).ToArray<ModuleVersionHeader>())
      {
        versionsToDelete.Add(moduleVersionHeader);
        list.Remove(moduleVersionHeader);
      }
      this.CheckModuleCompatibilityAndDeleteCompatibleVersions(list, versionsToDelete);
    }

    private IEnumerable<ModuleVersionHeader> Check(
      IEnumerable<ModuleVersionHeader> oldVersions,
      ModuleVersionHeader newVersion)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ModuleVersionHeader>) new FindComponentService.\u003CCheck\u003Ed__5(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__oldVersions = oldVersions,
        \u003C\u003E3__newVersion = newVersion
      };
    }

    private bool FindCustomTypes(FindComponentService.SearchContext searchContext)
    {
      int num1 = 1;
      List<ComponentMetadataItemWrapper>.Enumerator enumerator1;
      List<ModuleVersion>.Enumerator enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.LoadData(searchContext);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_17;
          case 3:
            try
            {
label_4:
              if (enumerator1.MoveNext())
                goto label_8;
              else
                goto label_5;
label_3:
              ComponentMetadataItemWrapper current;
              CustomTypeImplementationModel customType;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    List<CustomTypeModel> customTypes = searchContext.CustomTypes;
                    CustomTypeModel customTypeModel = new CustomTypeModel();
                    FindComponentService.SEdqeFzN2Wids1PlI5K((object) customTypeModel, customType.TypeUid);
                    customTypeModel.SubTypeUid = customType.SubTypeUid;
                    FindComponentService.kmWlLozpIDaOhPsyqEK((object) customTypeModel, FindComponentService.Tpq3Slz3nJ8ch1Jm4Y6((object) customType));
                    customTypeModel.HeaderUid = current.HeaderUid;
                    FindComponentService.vFLZn2zDunAfWQQI5BK((object) customTypeModel, FindComponentService.A3K5WQza9pDvO3NWvq1((object) current));
                    customTypes.Add(customTypeModel);
                    num2 = 7;
                    continue;
                  case 2:
                    goto label_8;
                  case 3:
                    goto label_16;
                  case 4:
                    FindComponentService.bwoDqGz1JjsA7K0CQeq((object) customType);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
                    continue;
                  case 5:
                    customType = ((ComponentSignature) FindComponentService.bJZRQIzPaXpi6pREbbm((object) current)).CustomType;
                    num2 = 6;
                    continue;
                  case 6:
                    if (customType == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 4;
                  default:
                    goto label_4;
                }
              }
label_5:
              num2 = 3;
              goto label_3;
label_8:
              current = enumerator1.Current;
              num2 = 5;
              goto label_3;
            }
            finally
            {
              enumerator1.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 4:
            goto label_44;
          case 5:
label_16:
            enumerator2 = searchContext.CacheTypeModules.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 2 : 2;
            continue;
          default:
            enumerator1 = searchContext.CacheTypeLastPublishedComponents.GetEnumerator();
            num1 = 3;
            continue;
        }
      }
label_17:
      try
      {
label_36:
        if (enumerator2.MoveNext())
          goto label_34;
        else
          goto label_37;
label_18:
        List<ComponentMetadata>.Enumerator enumerator3;
        ModuleVersion current1;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_34;
            case 2:
              goto label_44;
            case 3:
              goto label_19;
            case 4:
              goto label_36;
            default:
              enumerator3 = ((ModuleInfoMetadata) FindComponentService.iMlyy1ztkAWCr8rEdWj((object) current1)).Components.Where<ComponentMetadata>((Func<ComponentMetadata, bool>) (c => c.CustomTypeImplementation != null)).ToList<ComponentMetadata>().GetEnumerator();
              num4 = 3;
              continue;
          }
        }
label_19:
        try
        {
label_26:
          if (enumerator3.MoveNext())
            goto label_22;
          else
            goto label_27;
label_20:
          ComponentMetadata current2;
          CustomTypeImplementationModel implementationModel;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
                List<CustomTypeModel> customTypes = searchContext.CustomTypes;
                CustomTypeModel customTypeModel = new CustomTypeModel();
                FindComponentService.SEdqeFzN2Wids1PlI5K((object) customTypeModel, FindComponentService.bwoDqGz1JjsA7K0CQeq((object) implementationModel));
                FindComponentService.BJfHPkz4usOYVkh496y((object) customTypeModel, implementationModel.SubTypeUid);
                FindComponentService.kmWlLozpIDaOhPsyqEK((object) customTypeModel, FindComponentService.Tpq3Slz3nJ8ch1Jm4Y6((object) implementationModel));
                FindComponentService.UCkqCpz6l2NnPWwCrjt((object) customTypeModel, current2.Uid);
                FindComponentService.hHaIsgzHbTKOkWBZkvL((object) customTypeModel, current2.ModuleUid);
                customTypeModel.ModuleItemUid = FindComponentService.zhf61FzAs08ZdStq71m((object) current1.Header);
                customTypes.Add(customTypeModel);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 1;
                continue;
              case 2:
                if (implementationModel != null)
                {
                  num5 = 3;
                  continue;
                }
                goto label_26;
              case 3:
                FindComponentService.bwoDqGz1JjsA7K0CQeq((object) implementationModel);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                continue;
              case 4:
                goto label_22;
              case 5:
                goto label_26;
              case 6:
                goto label_36;
              default:
                implementationModel = (CustomTypeImplementationModel) FindComponentService.CvRW6lzwwq0EQ5KXDKY((object) current2);
                num5 = 2;
                continue;
            }
          }
label_22:
          current2 = enumerator3.Current;
          num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
          {
            num5 = 0;
            goto label_20;
          }
          else
            goto label_20;
label_27:
          num5 = 6;
          goto label_20;
        }
        finally
        {
          enumerator3.Dispose();
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
            num6 = 0;
          switch (num6)
          {
            default:
          }
        }
label_34:
        current1 = enumerator2.Current;
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        {
          num4 = 0;
          goto label_18;
        }
        else
          goto label_18;
label_37:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 2;
        goto label_18;
      }
      finally
      {
        enumerator2.Dispose();
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
          num7 = 0;
        switch (num7)
        {
          default:
        }
      }
label_44:
      return true;
    }

    private void LoadData(FindComponentService.SearchContext searchContext)
    {
      int num1 = 7;
      while (true)
      {
        IEnumerable<ModuleMetadataItemWrapper> source;
        IEnumerable<Guid> notLoaded;
        switch (num1)
        {
          case 1:
            searchContext.CacheTypeLastPublishedComponents.AddRange(this.GetLastPublishedComponents().Where<ComponentMetadataItemWrapper>((Func<ComponentMetadataItemWrapper, bool>) (i =>
            {
              int num2 = 2;
              while (true)
              {
                ComponentSignature componentSignature;
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (FindComponentService.\u003C\u003Ec.nmdQlXfct7SNDYNys4iu((object) componentSignature) == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 5 : 1;
                      continue;
                    }
                    break;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    componentSignature = (ComponentSignature) FindComponentService.\u003C\u003Ec.ArdWkkfcDyYnjCXt3mlt((object) i);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
                    continue;
                  case 3:
                  case 5:
                    goto label_7;
                  case 4:
                    goto label_8;
                }
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!FindComponentService.\u003C\u003Ec.PK0Gr7fc40TskNZCDro3(FindComponentService.\u003C\u003Ec.xPJcJDfcwONi9yCYs4cF((object) componentSignature.CustomType), Guid.Empty))
                  num2 = 4;
                else
                  break;
              }
label_7:
              return false;
label_8:
              return true;
            })));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 4 : 4;
            continue;
          case 2:
            goto label_11;
          case 3:
            IEnumerable<ModuleMetadataItemWrapper> publishedHeaders = this.moduleMetadataLoader.GetLastPublishedHeaders(notLoaded);
            // ISSUE: reference to a compiler-generated field
            Func<ModuleMetadataItemWrapper, bool> func = FindComponentService.\u003C\u003Ec.\u003C\u003E9__7_3;
            Func<ModuleMetadataItemWrapper, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              FindComponentService.\u003C\u003Ec.\u003C\u003E9__7_3 = predicate = (Func<ModuleMetadataItemWrapper, bool>) (i => FindComponentService.\u003C\u003Ec.cYdRK7fcAsqhorX8Xkjs((object) i.Signature.CustomTypes) > 0);
            }
            else
              goto label_14;
label_13:
            source = publishedHeaders.Where<ModuleMetadataItemWrapper>(predicate);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 5;
            continue;
label_14:
            predicate = func;
            goto label_13;
          case 4:
          case 6:
            if (searchContext.CacheTypeModules.Count != 0)
            {
              num1 = 8;
              continue;
            }
            break;
          case 5:
            searchContext.CacheTypeModules.AddRange((IEnumerable<ModuleVersion>) source.Select<ModuleMetadataItemWrapper, ModuleVersion>((Func<ModuleMetadataItemWrapper, ModuleVersion>) (w => (ModuleVersion) FindComponentService.vHy53qzduNL4la1OiPP((object) this.moduleMetadataLoader, w.HeaderUid, w.Uid))).ToArray<ModuleVersion>());
            num1 = 2;
            continue;
          case 7:
            if (FindComponentService.n3qm1lz7Myf3kxLsn3P((object) searchContext.CacheTypeLastPublishedComponents) != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 4 : 6;
              continue;
            }
            goto case 1;
          case 8:
            goto label_7;
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        notLoaded = ((IEnumerable<ModuleVersion>) this.GetAdditionalModules().Select<ClientComponentModel, ModuleVersion>((Func<ClientComponentModel, ModuleVersion>) (w => (ModuleVersion) FindComponentService.vHy53qzduNL4la1OiPP((object) this.moduleMetadataLoader, FindComponentService.MJd4j0BFSxyqrmO88VXq((object) w), w.ModuleItemUid))).ToArray<ModuleVersion>()).Select<ModuleVersion, Guid>((Func<ModuleVersion, Guid>) (m => FindComponentService.\u003C\u003Ec.c5ynBufcHHweeI3ve4iw(FindComponentService.\u003C\u003Ec.u1os3Xfc6rAqw6yX12Cg((object) m))));
        num1 = 3;
      }
label_11:
      return;
label_7:;
    }

    private ISession Session => (ISession) FindComponentService.GxSR99zx3ss5c8h2MMw((object) this.sessionProvider, (object) "");

    /// <inheritdoc />
    public void Clean(ICleanUIObjectsModel model)
    {
      int num = 4;
      Guid[] modules;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_2;
          case 2:
            this.CleanModules(modules);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
            continue;
          case 3:
            if (modules.Length == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 4:
            modules = (Guid[]) FindComponentService.MTyav2z0mMKCuXrTiIo((object) model);
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_2:
      return;
label_8:;
    }

    /// <inheritdoc />
    public IEnumerable<ClientComponentModel> GetAdditionalModules()
    {
      UIRuntimeModel orDefault1 = ContextVars.GetOrDefault<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289698926));
      if (orDefault1 == null)
        return Enumerable.Empty<ClientComponentModel>();
      HashSet<Guid> orDefault2 = ContextVars.GetOrDefault<HashSet<Guid>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360387285));
      if (orDefault2 == null || orDefault2.Count <= 0)
        return Enumerable.Empty<ClientComponentModel>();
      List<Guid> guidList = new List<Guid>();
      List<ItemRuntimeModel> runtimeModules = orDefault1.RuntimeModules;
      foreach (Guid guid in orDefault2)
      {
        Guid additionalModule = guid;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!(additionalModule == Guid.Empty) && runtimeModules.Find((Predicate<ItemRuntimeModel>) (a => FindComponentService.\u003C\u003Ec__DisplayClass11_0.Rt87cXfzZLriNIHoWFA6(FindComponentService.\u003C\u003Ec__DisplayClass11_0.Pl4LDhfz8YPlOaHbq0tt((object) a), additionalModule))) == null)
          guidList.Add(additionalModule);
      }
      UIRuntimeModel orAdd = ContextVars.GetOrAdd<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633529003), (Func<UIRuntimeModel>) (() => new UIRuntimeModel()));
      List<ClientComponentModel> second = new List<ClientComponentModel>();
      foreach (ItemRuntimeModel runtimeModule in orAdd.RuntimeModules)
      {
        Guid header = runtimeModule.HeaderUid;
        Guid itemUid = runtimeModule.ItemUid;
        if (!(header == Guid.Empty) && !(runtimeModule.ItemUid == Guid.Empty))
        {
          if (guidList.Find((Predicate<Guid>) (a => a == header)) != Guid.Empty)
            guidList.Remove(header);
          second.Add(new ClientComponentModel()
          {
            ModuleUid = header,
            ModuleItemUid = itemUid
          });
        }
      }
      if (guidList.Count <= 0)
        return (IEnumerable<ClientComponentModel>) second;
      FindComponentOptions options = new FindComponentOptions()
      {
        NeededModules = guidList
      };
      options.LoadedModules.AddRange((IEnumerable<ItemRuntimeModel>) runtimeModules);
      options.LoadedModules.AddRange((IEnumerable<ItemRuntimeModel>) orAdd.RuntimeModules);
      return ((IEnumerable<ClientComponentModel>) this.FindModules(options)).Concat<ClientComponentModel>((IEnumerable<ClientComponentModel>) second);
    }

    /// <summary>Поиск необходимых модулей</summary>
    /// <param name="options">Опции поиска</param>
    /// <returns>Клиентская модель</returns>
    private ClientComponentModel[] FindModules(FindComponentOptions options)
    {
      int num1 = 16;
      FindComponentService.SearchContext searchContext;
      while (true)
      {
        int num2 = num1;
        int index1;
        List<ItemRuntimeModel> loadedModules;
        Guid key;
        int index2;
        ItemRuntimeModel itemRuntimeModel;
        Guid guid;
        List<Guid>.Enumerator enumerator;
        List<Guid> neededModules;
        Guid[] array;
        ClientComponentModel[] componentsWithModule;
        ModuleVersion version;
        while (true)
        {
          switch (num2)
          {
            case 1:
              guid = FindComponentService.OLpPL4zMhFxCvpk9kMd((object) itemRuntimeModel);
              num2 = 17;
              continue;
            case 2:
              array = searchContext.ChosenComponentModules.Keys.Except<Guid>((IEnumerable<Guid>) neededModules).ToArray<Guid>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 13 : 5;
              continue;
            case 3:
            case 23:
              if (index2 >= array.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 4:
              index1 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 14 : 14;
              continue;
            case 5:
              enumerator = neededModules.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 12 : 7;
              continue;
            case 6:
              key = array[index2];
              num2 = 18;
              continue;
            case 7:
              ++index1;
              num2 = 22;
              continue;
            case 8:
              version = (ModuleVersion) FindComponentService.vHy53qzduNL4la1OiPP((object) this.moduleMetadataLoader, FindComponentService.NBVX77z9qIdCwXt3ICf((object) itemRuntimeModel), FindComponentService.OLpPL4zMhFxCvpk9kMd((object) itemRuntimeModel));
              num2 = 11;
              continue;
            case 9:
              ++index2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 3;
              continue;
            case 10:
              componentsWithModule = new ClientComponentModel[FindComponentService.Er7FNezy60ZGrjl8Cre((object) loadedModules)];
              num2 = 4;
              continue;
            case 11:
              this.FillСompatibilityTable(version, searchContext);
              num2 = 7;
              continue;
            case 12:
              try
              {
label_15:
                if (enumerator.MoveNext())
                  goto label_14;
                else
                  goto label_16;
label_13:
                Guid current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_14;
                    case 2:
                      searchContext.AllModules.Add(current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_32;
                    default:
                      goto label_15;
                  }
                }
label_14:
                current = enumerator.Current;
                num3 = 2;
                goto label_13;
label_16:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 3 : 3;
                goto label_13;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 13:
              index2 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 23 : 23;
              continue;
            case 14:
            case 22:
              if (index1 >= loadedModules.Count)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 19 : 20;
                continue;
              }
              goto case 21;
            case 15:
              loadedModules = ((FindComponentOptions) FindComponentService.lTCXFgzmDwbANeh2YWG((object) searchContext)).LoadedModules;
              num2 = 10;
              continue;
            case 16:
              goto label_9;
            case 17:
              ClientComponentModel[] clientComponentModelArray = componentsWithModule;
              int index3 = index1;
              ClientComponentModel clientComponentModel = new ClientComponentModel();
              clientComponentModel.ModuleUid = itemRuntimeModel.HeaderUid;
              FindComponentService.M82BL7zJJj9ytsx4xAS((object) clientComponentModel, guid);
              clientComponentModelArray[index3] = clientComponentModel;
              num2 = 8;
              continue;
            case 18:
              searchContext.ChosenComponentModules.Remove(key);
              num2 = 9;
              continue;
            case 19:
label_32:
              this.FindModule(componentsWithModule, searchContext);
              num2 = 2;
              continue;
            case 20:
              neededModules = ((FindComponentOptions) FindComponentService.lTCXFgzmDwbANeh2YWG((object) searchContext)).NeededModules;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 5;
              continue;
            case 21:
              itemRuntimeModel = loadedModules[index1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_9:
        searchContext = new FindComponentService.SearchContext(options);
        num1 = 15;
      }
label_3:
      return searchContext.ChosenComponentModules.Values.ToArray<ClientComponentModel>();
    }

    private Guid FindComponentRecursive(
      Guid headerUid,
      FindComponentService.SearchContext searchContext)
    {
      int num = 6;
      Guid moduleUid;
      while (true)
      {
        Guid guid;
        switch (num)
        {
          case 1:
            if (moduleUid == Guid.Empty)
            {
              num = 4;
              continue;
            }
            goto default;
          case 2:
          case 3:
            goto label_2;
          case 4:
            this.GetComponentFromConfiguration(headerUid, searchContext);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
            continue;
          case 5:
            guid = Guid.Empty;
            break;
          case 6:
            ModuleReference moduleReference = this.moduleReferenceManager.LoadOrNull(headerUid);
            if (moduleReference == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 5 : 0;
              continue;
            }
            guid = FindComponentService.x23RTCzl072F9mR0SP8((object) moduleReference);
            break;
          default:
            this.GetComponentFromModule(moduleUid, headerUid, searchContext);
            num = 3;
            continue;
        }
        moduleUid = guid;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
      }
label_2:
      return moduleUid;
    }

    private void GetComponentFromConfiguration(
      Guid headerUid,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 22;
      while (true)
      {
        int num2 = num1;
        ComponentMetadataItem componentMetadataItem;
        ComponentMetadataItemHeader metadataItemHeader1;
        while (true)
        {
          InterfaceBuilderViewMode interfaceBuilderViewMode;
          IEnumerable<ClientFunctionModel> functionModels;
          IEnumerator<ClientFunctionModel> enumerator1;
          Guid parent;
          IEnumerable<ClientDataClassModel> dataClassModels;
          ComponentGraph.Vertex vertex;
          IEnumerator<ClientDataClassModel> enumerator2;
          Guid guid;
          ComponentMetadataItemHeader metadataItemHeader2;
          switch (num2)
          {
            case 0:
              goto label_23;
            case 1:
              if (metadataItemHeader1 != null)
              {
                interfaceBuilderViewMode = FindComponentService.RQgC0czgFSWQ4XvqAxr((object) searchContext.Options);
                num2 = 42;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 14 : 2;
              continue;
            case 2:
              guid = FindComponentService.sjUd4ZzLHZM6ksBmvHP((object) componentMetadataItem);
              goto label_84;
            case 3:
              goto label_31;
            case 4:
              goto label_75;
            case 5:
              if (this.FindConfigurationImpl(parent, FindComponentService.sjUd4ZzLHZM6ksBmvHP((object) componentMetadataItem), FindComponentService.sjUd4ZzLHZM6ksBmvHP((object) componentMetadataItem), componentMetadata.Uid, componentMetadataItem, searchContext))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 18 : 13;
                continue;
              }
              goto label_77;
            case 6:
              this.loadedComponents[FindComponentService.sjUd4ZzLHZM6ksBmvHP((object) componentMetadataItem)] = componentMetadataItem;
              num2 = 9;
              continue;
            case 7:
              goto label_25;
            case 8:
              searchContext.Errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323063834), (object) typeof (ComponentMetadata).FullName));
              num2 = 4;
              continue;
            case 9:
              functionModels = this.GetFunctions((string) FindComponentService.BcBEmvzUHSE6Hf3AR79((object) componentMetadata), (IReadOnlyCollection<FunctionDependency>) componentMetadata.FunctionDependencies, searchContext, true).functionModels;
              num2 = 44;
              continue;
            case 10:
              searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(-420743386 ^ -420800592), FindComponentService.BcBEmvzUHSE6Hf3AR79((object) componentMetadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 17;
              continue;
            case 11:
              goto label_32;
            case 12:
              if (FindComponentService.vKChURzsrUf3vkTTcIY((object) searchContext.Errors) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 28 : 33;
                continue;
              }
              vertex = ((ComponentGraph) FindComponentService.cKHlxVzcgw9q1aIwTx5((object) searchContext)).AddHeadVertex(headerUid, FindComponentService.sjUd4ZzLHZM6ksBmvHP((object) componentMetadataItem), Guid.Empty, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 35 : 32;
              continue;
            case 13:
              searchContext.Errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867771424), (object) FindComponentService.RQgC0czgFSWQ4XvqAxr(FindComponentService.lTCXFgzmDwbANeh2YWG((object) searchContext))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 11 : 5;
              continue;
            case 14:
              searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(1051802738 - -1831968059 ^ -1411250453), (object) headerUid));
              num2 = 16;
              continue;
            case 15:
            case 29:
            case 32:
            case 40:
              if (componentMetadataItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 27 : 9;
                continue;
              }
              goto case 13;
            case 16:
              goto label_7;
            case 17:
              goto label_17;
            case 18:
              if (!this.FindCustomTypes(searchContext))
              {
                num2 = 36;
                continue;
              }
              goto label_30;
            case 19:
              dataClassModels = this.GetDataClasses((string) FindComponentService.BcBEmvzUHSE6Hf3AR79((object) componentMetadata), (IReadOnlyCollection<DataClassDependency>) componentMetadata.DataClassDependencies, searchContext, true).dataClassModels;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 6 : 12;
              continue;
            case 20:
label_9:
              componentMetadataItem = (ComponentMetadataItem) FindComponentService.z3Gya3zjOeKvblRLCEF((object) metadataItemHeader1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 29 : 13;
              continue;
            case 21:
              metadataItemHeader2 = (ComponentMetadataItemHeader) null;
              break;
            case 22:
              IComponentMetadataItemHeaderManager itemHeaderManager = this.ComponentMetadataItemHeaderManager;
              if (itemHeaderManager == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 21 : 19;
                continue;
              }
              metadataItemHeader2 = itemHeaderManager.LoadOrNull(headerUid);
              break;
            case 23:
              enumerator1 = functionModels.GetEnumerator();
              num2 = 26;
              continue;
            case 24:
              goto label_38;
            case 25:
label_10:
              if (FindComponentService.RQgC0czgFSWQ4XvqAxr(FindComponentService.lTCXFgzmDwbANeh2YWG((object) searchContext)) != InterfaceBuilderViewMode.Design)
              {
                num2 = 2;
                continue;
              }
              guid = Guid.Empty;
              goto label_84;
            case 26:
              try
              {
label_64:
                if (enumerator1.MoveNext())
                  goto label_67;
                else
                  goto label_65;
label_63:
                ClientFunctionModel current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_64;
                    case 2:
                      goto label_61;
                    case 3:
                      goto label_67;
                    default:
                      searchContext.Functions[FindComponentService.JjPtnYBFoMWBXtGgW9M3((object) current)] = current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
                      continue;
                  }
                }
label_65:
                num3 = 2;
                goto label_63;
label_67:
                current = enumerator1.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                {
                  num3 = 0;
                  goto label_63;
                }
                else
                  goto label_63;
              }
              finally
              {
                int num4;
                if (enumerator1 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                else
                  goto label_73;
label_71:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_73:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator1);
                num4 = 2;
                goto label_71;
              }
            case 27:
              if (FindComponentService.DFASlozYEBdlcbhTFVo((object) componentMetadataItem) is ComponentMetadata componentMetadata)
              {
                num2 = 6;
                continue;
              }
              goto case 8;
            case 28:
              goto label_12;
            case 30:
              searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(1461825605 - 1531863589 ^ -70012998), FindComponentService.BcBEmvzUHSE6Hf3AR79((object) componentMetadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 9 : 28;
              continue;
            case 31:
              goto label_77;
            case 33:
              goto label_41;
            case 34:
label_61:
              enumerator2 = dataClassModels.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 37 : 4;
              continue;
            case 35:
              Dictionary<Guid, ClientComponentModel> components = searchContext.Components;
              Guid key = FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex);
              ClientComponentModel clientComponentModel = new ClientComponentModel();
              FindComponentService.gHf6qOBFF83pESH2yeSb((object) clientComponentModel, FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex));
              FindComponentService.aJiRH2BFWqD71eFO0MDW((object) clientComponentModel, FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex));
              clientComponentModel.RenderUidList = vertex.ViewItemUidList;
              components.Add(key, clientComponentModel);
              num2 = 23;
              continue;
            case 36:
              searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(-87337865 ^ -87312915), FindComponentService.BcBEmvzUHSE6Hf3AR79((object) componentMetadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            case 37:
              try
              {
label_49:
                if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator2))
                  goto label_52;
                else
                  goto label_50;
label_48:
                ClientDataClassModel current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_49;
                    case 2:
                      goto label_10;
                    case 3:
                      searchContext.DataClasses[current.HeaderUid] = current;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
                      continue;
                    default:
                      goto label_52;
                  }
                }
label_50:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 1;
                goto label_48;
label_52:
                current = enumerator2.Current;
                num5 = 3;
                goto label_48;
              }
              finally
              {
                int num6;
                if (enumerator2 == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                else
                  goto label_56;
label_55:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_56:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator2);
                num6 = 2;
                goto label_55;
              }
            case 38:
            case 41:
              componentMetadataItem = (ComponentMetadataItem) null;
              num2 = 32;
              continue;
            case 39:
              FindComponentService.uir9COBFbdBxBXhvM3Cg(FindComponentService.lTCXFgzmDwbANeh2YWG((object) searchContext), InterfaceBuilderViewMode.Runtime);
              num2 = 43;
              continue;
            case 42:
              switch (interfaceBuilderViewMode)
              {
                case InterfaceBuilderViewMode.Runtime:
                  goto label_9;
                case InterfaceBuilderViewMode.Design:
                  goto label_35;
                case InterfaceBuilderViewMode.Emulation:
                  goto label_25;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 38 : 22;
                  continue;
              }
            case 43:
              if (this.FindComponent(parent, FindComponentService.sjUd4ZzLHZM6ksBmvHP((object) componentMetadataItem), FindComponentService.sjUd4ZzLHZM6ksBmvHP((object) componentMetadataItem), FindComponentService.cMLTumBFhHIoYiMbgbG3((object) componentMetadata), (IEnumerable<ComponentDependency>) componentMetadata.ComponentDependencies, searchContext))
              {
                num2 = 5;
                continue;
              }
              goto case 30;
            case 44:
              if (searchContext.Errors.Count <= 0)
              {
                num2 = 19;
                continue;
              }
              goto case 10;
            case 45:
label_35:
              componentMetadataItem = metadataItemHeader1.Draft;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 40 : 26;
              continue;
            default:
              goto label_72;
          }
          metadataItemHeader1 = metadataItemHeader2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
          continue;
label_84:
          parent = guid;
          num2 = 39;
        }
label_25:
        componentMetadataItem = (ComponentMetadataItem) FindComponentService.QOMAZEz50QRLoH9oiWM((object) metadataItemHeader1);
        num1 = 15;
        continue;
label_41:
        searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(132912447 ^ 132969527), FindComponentService.BcBEmvzUHSE6Hf3AR79((object) componentMetadata)));
        num1 = 24;
        continue;
label_77:
        searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(-1921202237 ^ -1921243559), (object) componentMetadata.DisplayName));
        num1 = 3;
      }
label_23:
      return;
label_31:
      return;
label_75:
      return;
label_32:
      return;
label_7:
      return;
label_17:
      return;
label_38:
      return;
label_12:
      return;
label_72:
      return;
label_30:;
    }

    private bool FindComponent(
      Guid parent,
      Guid itemUid,
      Guid owner,
      Guid parentComponentUid,
      IEnumerable<ComponentDependency> componentDependencies,
      FindComponentService.SearchContext searchContext)
    {
      foreach (ComponentDependency componentDependency in componentDependencies)
      {
        Guid moduleUid = componentDependency.ModuleUid;
        if (moduleUid == Guid.Empty)
        {
          if (!this.FindConfigurationComponent(parent, itemUid, owner, componentDependency, searchContext))
            return false;
        }
        else if (!this.FindModuleComponent(itemUid, owner, moduleUid, parentComponentUid, componentDependency, searchContext))
          return false;
      }
      return true;
    }

    private bool FindConfigurationComponent(
      Guid parent,
      Guid parentItemUid,
      Guid owner,
      ComponentDependency dependency,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 2;
      IEnumerator<ComponentGraph.Vertex> enumerator1;
      Guid guid1;
      FindComponentService.SearchContext searchContext1;
      Guid owner1;
      while (true)
      {
        int num2 = num1;
        ComponentMetadataItemWrapper[] array;
        IEnumerable<ComponentMetadataItemWrapper> source;
        IEnumerable<ComponentMetadataItemWrapper> componentCandidates;
        Guid parent1;
        ComponentDependency dependency1;
        Guid parentItemUid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              parent1 = parent;
              num2 = 13;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
              continue;
            case 3:
              guid1 = FindComponentService.S8hxbYBFGlZbv2GJuYvK((object) dependency1);
              num2 = 11;
              continue;
            case 4:
              parentItemUid1 = parentItemUid;
              num2 = 7;
              continue;
            case 5:
              searchContext1.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(1304605005 ^ 1304580311), (object) dependency1.DisplayName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 9 : 1;
              continue;
            case 6:
              goto label_101;
            case 7:
              owner1 = owner;
              num2 = 3;
              continue;
            case 8:
              goto label_8;
            case 9:
              goto label_108;
            case 10:
              searchContext1.ComponentVersions[guid1] = componentCandidates = this.GetConfigurationComponentCandidates(guid1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            case 11:
              if (!searchContext1.ComponentVersions.TryGetValue(guid1, out source))
              {
                num2 = 10;
                continue;
              }
              goto case 12;
            case 12:
              array = source.Where<ComponentMetadataItemWrapper>((Func<ComponentMetadataItemWrapper, bool>) (c =>
              {
                int num3 = 3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (FindComponentService.\u003C\u003Ec__DisplayClass17_0.RhNo8nfzkN0dqJZTSd5q(FindComponentService.\u003C\u003Ec__DisplayClass17_0.oGpNrZfzTlaR4ZHM0SLy((object) searchContext1)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_6;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      if (!FindComponentService.\u003C\u003Ec__DisplayClass17_0.dgaZU3fzXmRNp3EODO3l(parent1, Guid.Empty))
                      {
                        num3 = 2;
                        continue;
                      }
                      goto label_2;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return true;
label_5:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return FindComponentService.\u003C\u003Ec__DisplayClass17_0.LeKTLdfzO0hcVKURLXvr((object) CheckComponentHelper.CheckSignature(dependency1, (ComponentSignature) FindComponentService.\u003C\u003Ec__DisplayClass17_0.DFs9bAfznIshknLihgYQ((object) c)));
label_6:
                return true;
              })).ToArray<ComponentMetadataItemWrapper>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 15 : 0;
              continue;
            case 13:
              searchContext1 = searchContext;
              num2 = 14;
              continue;
            case 14:
              dependency1 = dependency;
              num2 = 4;
              continue;
            case 15:
              if (array.Length != 0)
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                enumerator1 = ((IEnumerable<ComponentMetadataItemWrapper>) array).Select<ComponentMetadataItemWrapper, ComponentGraph.Vertex>((Func<ComponentMetadataItemWrapper, ComponentGraph.Vertex>) (candidate => ((ComponentGraph) FindComponentService.\u003C\u003Ec__DisplayClass17_0.WrbiM9fz2l1tXvly1xjO((object) searchContext1)).AddVertex(candidate.HeaderUid, FindComponentService.\u003C\u003Ec__DisplayClass17_0.W5tYmwfzeZGYwn2GV9vI((object) candidate), Guid.Empty, parentItemUid1, (string) FindComponentService.\u003C\u003Ec__DisplayClass17_0.WxjulgfzNSdomrKcX6J4(FindComponentService.\u003C\u003Ec__DisplayClass17_0.aSV90LfzP0AZW2UYsL5m(-281842504 ^ -281924516), (object) parent1, (object) FindComponentService.\u003C\u003Ec__DisplayClass17_0.ye0emQfz15GHBfhiwXE4((object) dependency1)), owner1, FindComponentService.\u003C\u003Ec__DisplayClass17_0.VMtkkkfz3o7eHgXak3UY((object) dependency1)))).GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 8;
                continue;
              }
              goto label_6;
            default:
              source = componentCandidates;
              num2 = 12;
              continue;
          }
        }
label_6:
        num1 = 5;
      }
label_8:
      bool configurationComponent;
      try
      {
label_30:
        if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator1))
          goto label_54;
        else
          goto label_31;
label_10:
        int num4;
        while (true)
        {
          int num5;
          bool result1;
          Guid guid2;
          ClientComponentModel clientComponentModel1;
          ComponentMetadataItem componentMetadataItem1;
          IEnumerator<ClientDataClassModel> enumerator2;
          ComponentMetadataItem componentMetadataItem2;
          HashSet<string>.Enumerator enumerator3;
          ComponentMetadata componentMetadata;
          bool result2;
          IEnumerable<ClientFunctionModel> clientFunctionModels;
          IEnumerator<ClientFunctionModel> enumerator4;
          IEnumerator<Guid> enumerator5;
          IEnumerable<ClientDataClassModel> dataClassModels;
          ComponentGraph.Vertex vertex;
          switch (num4)
          {
            case 1:
              enumerator3 = vertex.ViewItemUidList.GetEnumerator();
              num4 = 28;
              continue;
            case 2:
            case 9:
label_90:
              // ISSUE: reference to a compiler-generated method
              enumerator4 = clientFunctionModels.Where<ClientFunctionModel>((Func<ClientFunctionModel, bool>) (function => !searchContext1.Functions.ContainsKey(FindComponentService.\u003C\u003Ec__DisplayClass17_0.p8ngMQfzpZCWdZIi4Uwy((object) function)))).GetEnumerator();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 10 : 23;
              continue;
            case 3:
              if (!result2)
              {
                num4 = 19;
                continue;
              }
              goto case 30;
            case 4:
              if (searchContext1.Components.TryGetValue(guid2, out clientComponentModel1))
              {
                num4 = 29;
                continue;
              }
              goto case 26;
            case 8:
label_15:
              configurationComponent = true;
              num5 = 27;
              break;
            case 10:
              if (this.ComponentMetadataItemManager == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 11:
              guid2 = FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex);
              num4 = 34;
              continue;
            case 12:
              try
              {
label_20:
                if (enumerator2.MoveNext())
                  goto label_22;
                else
                  goto label_21;
label_19:
                ClientDataClassModel current;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_15;
                    case 2:
                      goto label_22;
                    case 3:
                      searchContext1.DataClasses[FindComponentService.KQ588fBFfP6HcAVOGSkp((object) current)] = current;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_20;
                  }
                }
label_21:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                goto label_19;
label_22:
                current = enumerator2.Current;
                num6 = 3;
                goto label_19;
              }
              finally
              {
                int num7;
                if (enumerator2 == null)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
                else
                  goto label_27;
label_26:
                switch (num7)
                {
                  case 1:
                  case 2:
                }
label_27:
                enumerator2.Dispose();
                num7 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                {
                  num7 = 2;
                  goto label_26;
                }
                else
                  goto label_26;
              }
            case 13:
              goto label_101;
            case 14:
label_91:
              IEnumerable<ClientDataClassModel> source = dataClassModels;
              Func<ClientDataClassModel, bool> func;
              Func<ClientDataClassModel, bool> func1 = func;
              Func<ClientDataClassModel, bool> predicate = func1 == null ? (func = (Func<ClientDataClassModel, bool>) (dataClass => !searchContext1.DataClasses.ContainsKey(dataClass.HeaderUid))) : func1;
              enumerator2 = source.Where<ClientDataClassModel>(predicate).GetEnumerator();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 12 : 10;
              continue;
            case 15:
              vertex = enumerator1.Current;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 10 : 6;
              continue;
            case 16:
              (result2, clientFunctionModels) = this.GetFunctions((string) FindComponentService.BcBEmvzUHSE6Hf3AR79((object) componentMetadata), (IReadOnlyCollection<FunctionDependency>) componentMetadata.FunctionDependencies, searchContext1);
              num5 = 3;
              break;
            case 17:
              componentMetadataItem2 = componentMetadataItem1;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 31 : 6;
              continue;
            case 18:
              goto label_54;
            case 20:
              if (!result1)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 7;
                continue;
              }
              goto case 4;
            case 21:
              if (!this.FindComponent(guid2, guid2, FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex) ? guid2 : owner1, guid1, (IEnumerable<ComponentDependency>) componentMetadata.ComponentDependencies, searchContext1))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 6;
                continue;
              }
              goto case 16;
            case 22:
              this.loadedComponents[guid2] = componentMetadataItem1 = this.ComponentMetadataItemManager.Load(guid2);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 17 : 13;
              continue;
            case 23:
              try
              {
label_43:
                if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator4))
                  goto label_41;
                else
                  goto label_44;
label_40:
                ClientFunctionModel current;
                int num8;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_91;
                    case 2:
                      goto label_41;
                    case 3:
                      searchContext1.Functions[current.HeaderUid] = current;
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_43;
                  }
                }
label_41:
                current = enumerator4.Current;
                num8 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                {
                  num8 = 3;
                  goto label_40;
                }
                else
                  goto label_40;
label_44:
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                goto label_40;
              }
              finally
              {
                if (enumerator4 != null)
                {
                  int num9 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
                    num9 = 1;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator4);
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_51;
                    }
                  }
                }
label_51:;
              }
            case 24:
label_89:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              enumerator5 = vertex.Owners.Where<Guid>((Func<Guid, bool>) (ownerUid => FindComponentService.\u003C\u003Ec__DisplayClass17_1.SGQro5fz6bpQZcYfXFFb(ownerUid, FindComponentService.\u003C\u003Ec__DisplayClass17_1.OK0d2Kfz4rb5JJDTfvg0((object) vertex)))).GetEnumerator();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 33 : 1;
              continue;
            case 25:
              FindComponentService.aJiRH2BFWqD71eFO0MDW((object) clientComponentModel1, false);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
              continue;
            case 26:
              Dictionary<Guid, ClientComponentModel> components = searchContext1.Components;
              Guid key = guid2;
              ClientComponentModel clientComponentModel2 = new ClientComponentModel();
              clientComponentModel2.ItemUid = guid2;
              FindComponentService.aJiRH2BFWqD71eFO0MDW((object) clientComponentModel2, FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex));
              clientComponentModel2.RenderUidList = vertex.ViewItemUidList;
              clientComponentModel2.Owners = vertex.Owners;
              components[key] = clientComponentModel2;
              num4 = 2;
              continue;
            case 27:
              goto label_102;
            case 28:
              try
              {
label_58:
                if (enumerator3.MoveNext())
                  goto label_60;
                else
                  goto label_59;
label_57:
                string current;
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      goto label_89;
                    case 2:
                      goto label_58;
                    case 3:
                      goto label_60;
                    default:
                      clientComponentModel1.RenderUidList.Add(current);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 2;
                      continue;
                  }
                }
label_59:
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
                goto label_57;
label_60:
                current = enumerator3.Current;
                num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                {
                  num10 = 0;
                  goto label_57;
                }
                else
                  goto label_57;
              }
              finally
              {
                enumerator3.Dispose();
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                }
              }
            case 29:
            case 32:
              if (FindComponentService.SODVc5BFE1jGqDmIIqZJ((object) clientComponentModel1) != FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex))
              {
                num4 = 25;
                continue;
              }
              goto case 1;
            case 30:
              (result1, dataClassModels) = this.GetDataClasses((string) FindComponentService.BcBEmvzUHSE6Hf3AR79((object) componentMetadata), (IReadOnlyCollection<DataClassDependency>) componentMetadata.DataClassDependencies, searchContext1);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 20 : 10;
              continue;
            case 31:
              componentMetadata = (ComponentMetadata) FindComponentService.DFASlozYEBdlcbhTFVo((object) componentMetadataItem2);
              num4 = 21;
              continue;
            case 33:
              try
              {
label_75:
                if (enumerator5.MoveNext())
                  goto label_77;
                else
                  goto label_76;
label_74:
                Guid current;
                int num12;
                while (true)
                {
                  switch (num12)
                  {
                    case 1:
                      clientComponentModel1.Owners.Add(current);
                      num12 = 3;
                      continue;
                    case 2:
                      goto label_90;
                    case 3:
                      goto label_75;
                    default:
                      goto label_77;
                  }
                }
label_76:
                num12 = 2;
                goto label_74;
label_77:
                current = enumerator5.Current;
                num12 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                {
                  num12 = 1;
                  goto label_74;
                }
                else
                  goto label_74;
              }
              finally
              {
                if (enumerator5 != null)
                {
                  int num13 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                    num13 = 0;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 1:
                        goto label_85;
                      default:
                        FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator5);
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_85:;
              }
            case 34:
              if (!this.loadedComponents.TryGetValue(guid2, out componentMetadataItem2))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 22 : 8;
                continue;
              }
              goto case 31;
            default:
              goto label_30;
          }
          num4 = num5;
        }
label_31:
        num4 = 13;
        goto label_10;
label_54:
        num4 = 13;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        {
          num4 = 15;
          goto label_10;
        }
        else
          goto label_10;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num14 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
            num14 = 0;
          while (true)
          {
            switch (num14)
            {
              case 1:
                goto label_97;
              default:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator1);
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_97:;
      }
label_102:
      return configurationComponent;
label_101:
      return false;
label_108:
      return false;
    }

    private IEnumerable<ComponentMetadataItemWrapper> GetConfigurationComponentCandidates(
      Guid dependencyUid)
    {
      return this.ComponentMetadataItemManager?.GetCandidates(dependencyUid) ?? Enumerable.Empty<ComponentMetadataItemWrapper>();
    }

    /// <summary>Менеджер метаданных функций</summary>
    public IFunctionMetadataItemManager FunctionMetadataItemManager
    {
      get => this.\u003CFunctionMetadataItemManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFunctionMetadataItemManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Менеджер метаданных компонентов</summary>
    public IComponentMetadataItemManager ComponentMetadataItemManager
    {
      get => this.\u003CComponentMetadataItemManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CComponentMetadataItemManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Менеджер заголовков компонентов</summary>
    public IComponentMetadataItemHeaderManager ComponentMetadataItemHeaderManager
    {
      get => this.\u003CComponentMetadataItemHeaderManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CComponentMetadataItemHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Менеджер метаданных датаклассов</summary>
    public IDataClassMetadataItemManager DataClassMetadataItemManager
    {
      get => this.\u003CDataClassMetadataItemManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDataClassMetadataItemManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Менеджер заголовков датаклассов</summary>
    public IDataClassMetadataItemHeaderManager DataClassMetadataItemHeaderManager
    {
      get => this.\u003CDataClassMetadataItemHeaderManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDataClassMetadataItemHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    /// <param name="moduleMetadataLoader">Сервис загрузки метаданных модуля</param>
    /// <param name="dependencyService">Сервис по работе с зависимостями</param>
    /// <param name="moduleMetadataCompatibilityChecker">Сервис проверки совместимости модулей</param>
    /// <param name="dependencyFinders">Точка расширения по поиску зависимостей в системе</param>
    /// <param name="transformationProvider">Интерфейс провайдера преобразования БД</param>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public FindComponentService(
      IModuleReferenceManager moduleReferenceManager,
      IModuleMetadataLoader moduleMetadataLoader,
      IDependencyService dependencyService,
      ModuleMetadataCompatibilityChecker moduleMetadataCompatibilityChecker = null,
      IEnumerable<IDependencyFinder> dependencyFinders = null,
      ITransformationProvider transformationProvider = null,
      ISessionProvider sessionProvider = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.loadedComponents = new Dictionary<Guid, ComponentMetadataItem>();
      this.loadedFunctions = new Dictionary<Guid, FunctionMetadataItem>();
      this.moduleApplicationCacheResult = new ConcurrentDictionary<Guid, RecursiveComponentModel>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.moduleReferenceManager = moduleReferenceManager;
      this.moduleMetadataLoader = moduleMetadataLoader;
      this.dependencyService = dependencyService;
      this.moduleMetadataCompatibilityChecker = moduleMetadataCompatibilityChecker;
      this.dependencyFinders = dependencyFinders;
      this.transformationProvider = transformationProvider;
      this.sessionProvider = sessionProvider;
    }

    /// <inheritdoc />
    public RecursiveComponentModel FindComponent(Guid headerUid, FindComponentOptions options)
    {
      int num = 1;
      FindComponentService.SearchContext searchContext;
      RecursiveComponentModel component;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (FindComponentService.RQgC0czgFSWQ4XvqAxr((object) options) != InterfaceBuilderViewMode.Runtime)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            if (!this.moduleApplicationCacheResult.TryGetValue(headerUid, out component))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 5 : 1;
              continue;
            }
            goto label_5;
          case 4:
            goto label_5;
          default:
            searchContext = new FindComponentService.SearchContext(options);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return this.FindComponentInternal(headerUid, searchContext);
label_5:
      return component;
    }

    /// <inheritdoc />
    void IFindComponentServiceInternal.ClearCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.moduleApplicationCacheResult.Clear();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private RecursiveComponentModel FindComponentInternal(
      Guid headerUid,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 36;
      List<string>.Enumerator enumerator1;
      RecursiveComponentModel recursiveModel;
      FindComponentService.SearchContext searchContext1;
      while (true)
      {
        int num2 = num1;
        ClientComponentModel[] array;
        FindComponentService componentService;
        while (true)
        {
          ClientComponentModel clientComponentModel1;
          IEnumerator<ClientFunctionModel> enumerator2;
          KeyValuePair<Guid, ClientComponentModel> keyValuePair;
          Guid componentRecursive;
          Dictionary<Guid, ClientComponentModel>.Enumerator enumerator3;
          IEnumerator<ClientDataClassModel> enumerator4;
          switch (num2)
          {
            case 1:
label_99:
              Dictionary<Guid, ClientDataClassModel>.ValueCollection values1 = searchContext1.DataClasses.Values;
              Func<ClientDataClassModel, bool> func1;
              Func<ClientDataClassModel, bool> func3 = func1;
              // ISSUE: reference to a compiler-generated method
              Func<ClientDataClassModel, bool> predicate1 = func3 == null ? (func1 = (Func<ClientDataClassModel, bool>) (dataClass => !searchContext1.Components.ContainsKey(FindComponentService.\u003C\u003Ec__DisplayClass52_0.PfHFZJfz0T7ylTjuhR4X((object) dataClass)))) : func3;
              enumerator4 = values1.Where<ClientDataClassModel>(predicate1).GetEnumerator();
              num2 = 14;
              continue;
            case 2:
              searchContext1.Clear();
              num2 = 37;
              continue;
            case 3:
              Dictionary<Guid, ClientFunctionModel>.ValueCollection values2 = searchContext1.Functions.Values;
              Func<ClientFunctionModel, bool> func2;
              Func<ClientFunctionModel, bool> func4 = func2;
              // ISSUE: reference to a compiler-generated method
              Func<ClientFunctionModel, bool> predicate2 = func4 == null ? (func2 = (Func<ClientFunctionModel, bool>) (function => !searchContext1.Components.ContainsKey(FindComponentService.\u003C\u003Ec__DisplayClass52_0.QIdH97fzxu1Bf9ua5vUn((object) function)))) : func4;
              enumerator2 = values2.Where<ClientFunctionModel>(predicate2).GetEnumerator();
              num2 = 5;
              continue;
            case 4:
              goto label_61;
            case 5:
              try
              {
label_12:
                if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator2))
                  goto label_10;
                else
                  goto label_13;
label_8:
                ClientFunctionModel current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_99;
                    case 2:
                      goto label_10;
                    case 3:
                      goto label_12;
                    default:
                      clientComponentModel1.Functions.Add(current);
                      num3 = 3;
                      continue;
                  }
                }
label_10:
                current = enumerator2.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                {
                  num3 = 0;
                  goto label_8;
                }
                else
                  goto label_8;
label_13:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                goto label_8;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_20;
                      default:
                        FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator2);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_20:;
              }
            case 6:
              Dictionary<Guid, ClientComponentModel>.ValueCollection values3 = searchContext1.Components.Values;
              // ISSUE: reference to a compiler-generated field
              Func<ClientComponentModel, bool> func5 = FindComponentService.\u003C\u003Ec.\u003C\u003E9__52_0;
              Func<ClientComponentModel, bool> predicate3;
              if (func5 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                FindComponentService.\u003C\u003Ec.\u003C\u003E9__52_0 = predicate3 = (Func<ClientComponentModel, bool>) (component => FindComponentService.\u003C\u003Ec.pgSCdFfcxyg867jk9orx(FindComponentService.\u003C\u003Ec.ShhqEQfc7H6IQMgWUjuY((object) component), Guid.Empty));
              }
              else
                goto label_14;
label_102:
              array = values3.Where<ClientComponentModel>(predicate3).ToArray<ClientComponentModel>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 30 : 26;
              continue;
label_14:
              predicate3 = func5;
              goto label_102;
            case 7:
              goto label_78;
            case 8:
              if (!FindComponentService.SHwxCpBFI8kUKZhtBG8g(componentRecursive, Guid.Empty))
              {
                num2 = 18;
                continue;
              }
              break;
            case 9:
              recursiveModel.Errors.AddRange((IEnumerable<string>) searchContext1.Errors);
              num2 = 23;
              continue;
            case 10:
label_94:
              searchContext1.AllModules.Clear();
              num2 = 16;
              continue;
            case 11:
            case 18:
              searchContext1.Errors.Reverse();
              num2 = 7;
              continue;
            case 12:
              goto label_80;
            case 13:
              recursiveModel.ExtensionPoints.AddRange((IEnumerable<ClientExtensionPointModel>) searchContext1.ExtensionPoints);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 4 : 27;
              continue;
            case 14:
              try
              {
label_49:
                if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator4))
                  goto label_52;
                else
                  goto label_50;
label_48:
                ClientDataClassModel current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_52;
                    case 2:
                      goto label_94;
                    case 3:
                      goto label_49;
                    default:
                      clientComponentModel1.DataClasses.Add(current);
                      num5 = 3;
                      continue;
                  }
                }
label_50:
                num5 = 2;
                goto label_48;
label_52:
                current = enumerator4.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                {
                  num5 = 0;
                  goto label_48;
                }
                else
                  goto label_48;
              }
              finally
              {
                int num6;
                if (enumerator4 == null)
                  num6 = 2;
                else
                  goto label_57;
label_56:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_57:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator4);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                {
                  num6 = 0;
                  goto label_56;
                }
                else
                  goto label_56;
              }
            case 15:
              try
              {
label_85:
                if (enumerator3.MoveNext())
                  goto label_89;
                else
                  goto label_86;
label_84:
                KeyValuePair<Guid, ClientComponentModel> current;
                ClientComponentModel clientComponentModel2;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_89;
                    case 2:
                      goto label_85;
                    case 3:
                      goto label_44;
                    case 4:
                      clientComponentModel2 = current.Value;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                      continue;
                    default:
                      searchContext1.Components.Add(FindComponentService.MeY255BFZT4ltNIPAYVj((object) clientComponentModel2), clientComponentModel2);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 2;
                      continue;
                  }
                }
label_86:
                num7 = 3;
                goto label_84;
label_89:
                current = enumerator3.Current;
                num7 = 4;
                goto label_84;
              }
              finally
              {
                enumerator3.Dispose();
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                }
              }
            case 16:
              searchContext1.AllModules.AddRange<Guid>((IEnumerable<Guid>) searchContext1.ChosenModules);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 4 : 6;
              continue;
            case 17:
              enumerator3 = searchContext1.ChosenComponentModules.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 15 : 2;
              continue;
            case 19:
              goto label_66;
            case 20:
              if (this.FindModule(array, searchContext1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 10 : 17;
                continue;
              }
              goto case 2;
            case 21:
label_40:
              this.FillEntityDependencies(recursiveModel);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 39 : 31;
              continue;
            case 22:
              clientComponentModel1 = keyValuePair.Value;
              num2 = 3;
              continue;
            case 23:
              enumerator1 = searchContext1.Errors.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 19 : 2;
              continue;
            case 24:
              enumerator1 = searchContext1.Errors.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 29 : 41;
              continue;
            case 25:
              goto label_64;
            case 26:
label_44:
              FindComponentService.In1G9QBFu5mGyHOPsJhK((object) recursiveModel, (object) clientComponentModel1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 21 : 31;
              continue;
            case 27:
              recursiveModel.CustomTypes.AddRange((IEnumerable<CustomTypeModel>) searchContext1.CustomTypes);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 8;
              continue;
            case 28:
              searchContext1.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(~289714581 ^ -289689698), (object) headerUid));
              num2 = 29;
              continue;
            case 29:
              FindComponentService.GhjFjEBFCndCXlt42s75((object) searchContext1.Errors);
              num2 = 9;
              continue;
            case 30:
              goto label_95;
            case 31:
              RecursiveComponentModel recursiveComponentModel = recursiveModel;
              IEnumerable<KeyValuePair<Guid, ClientComponentModel>> source = searchContext1.Components.Except<KeyValuePair<Guid, ClientComponentModel>>((IEnumerable<KeyValuePair<Guid, ClientComponentModel>>) new KeyValuePair<Guid, ClientComponentModel>[1]
              {
                keyValuePair
              });
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel> func6 = FindComponentService.\u003C\u003Ec.\u003C\u003E9__52_2;
              Func<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel> selector;
              if (func6 == null)
              {
                // ISSUE: reference to a compiler-generated field
                FindComponentService.\u003C\u003Ec.\u003C\u003E9__52_2 = selector = (Func<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel>) (a => a.Value);
              }
              else
                goto label_106;
label_105:
              List<ClientComponentModel> list = source.Select<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel>(selector).ToList<ClientComponentModel>();
              recursiveComponentModel.ComponentCache = list;
              num2 = 13;
              continue;
label_106:
              selector = func6;
              goto label_105;
            case 32:
              keyValuePair = searchContext1.Components.First<KeyValuePair<Guid, ClientComponentModel>>();
              num2 = 22;
              continue;
            case 33:
              if (FindComponentService.sDdEm3BFQbJHm5tfqV9U((object) searchContext1.Components) > 0)
              {
                num2 = 32;
                continue;
              }
              goto case 28;
            case 34:
              componentRecursive = this.FindComponentRecursive(headerUid, searchContext1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 33 : 19;
              continue;
            case 35:
              searchContext1 = searchContext;
              num2 = 40;
              continue;
            case 36:
              goto label_79;
            case 37:
              goto label_37;
            case 38:
              goto label_34;
            case 39:
              goto label_82;
            case 40:
              componentService = this;
              num2 = 25;
              continue;
            case 41:
              try
              {
label_24:
                if (enumerator1.MoveNext())
                  goto label_23;
                else
                  goto label_25;
label_22:
                string current;
                int num9;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_23;
                    case 2:
                      goto label_24;
                    case 3:
                      FindComponentService.qAo95vBF8H25WWCSTQYN((object) EleWise.ELMA.Logging.Logger.Log, (object) current);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
                      continue;
                    default:
                      goto label_40;
                  }
                }
label_23:
                current = enumerator1.Current;
                num9 = 3;
                goto label_22;
label_25:
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                goto label_22;
              }
              finally
              {
                enumerator1.Dispose();
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                  num10 = 0;
                switch (num10)
                {
                  default:
                }
              }
          }
          this.moduleApplicationCacheResult[headerUid] = recursiveModel;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 11 : 5;
        }
label_34:
        searchContext1.Clear();
        num1 = 4;
        continue;
label_64:
        recursiveModel = new RecursiveComponentModel();
        num1 = 34;
        continue;
label_78:
        recursiveModel.Errors.AddRange((IEnumerable<string>) searchContext1.Errors);
        num1 = 24;
        continue;
label_79:
        num1 = 35;
        continue;
label_95:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (((IEnumerable<ClientComponentModel>) array).All<ClientComponentModel>((Func<ClientComponentModel, bool>) (component => componentService.FillСompatibilityTable((ModuleVersion) FindComponentService.\u003C\u003Ec__DisplayClass52_0.KuwcsFfzypZqIycoECLg((object) componentService.moduleMetadataLoader, FindComponentService.\u003C\u003Ec__DisplayClass52_0.Y131fwfzm602sXcLFaVV((object) component), component.ModuleItemUid), searchContext1))))
          num1 = 20;
        else
          goto label_34;
      }
label_37:
      return this.FindComponentInternal(headerUid, searchContext1);
label_61:
      return this.FindComponentInternal(headerUid, searchContext1);
label_66:
      try
      {
label_69:
        if (enumerator1.MoveNext())
          goto label_71;
        else
          goto label_70;
label_67:
        string current;
        int num11;
        while (true)
        {
          switch (num11)
          {
            case 1:
              FindComponentService.qAo95vBF8H25WWCSTQYN(FindComponentService.OnTNHEBFvIM8M49ecnRy(), (object) current);
              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_80;
            case 3:
              goto label_71;
            default:
              goto label_69;
          }
        }
label_70:
        num11 = 2;
        goto label_67;
label_71:
        current = enumerator1.Current;
        num11 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        {
          num11 = 1;
          goto label_67;
        }
        else
          goto label_67;
      }
      finally
      {
        enumerator1.Dispose();
        int num12 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
          num12 = 0;
        switch (num12)
        {
          default:
        }
      }
label_80:
      return recursiveModel;
label_82:
      return recursiveModel;
    }

    private void FillEntityDependencies(RecursiveComponentModel recursiveModel)
    {
      int num1 = 3;
      ClientComponentModel header;
      IEnumerator<ClientComponentModel> enumerator1;
      List<CustomTypeModel>.Enumerator enumerator2;
      List<ClientExtensionPointModel>.Enumerator enumerator3;
      RecursiveComponentModel recursiveModel1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_59;
          case 2:
            recursiveModel1 = recursiveModel;
            num1 = 8;
            continue;
          case 3:
            FindComponentService componentService = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 0;
            continue;
          case 4:
            try
            {
label_29:
              if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator1))
                goto label_34;
              else
                goto label_30;
label_5:
              ClientComponentModel current1;
              Guid moduleItemUid1;
              List<ClientFunctionModel>.Enumerator enumerator4;
              Guid itemUid1;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    LoadComponentConfiguration(itemUid1);
                    num2 = 5;
                    continue;
                  case 2:
                    if (!(moduleItemUid1 != Guid.Empty))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 4 : 1;
                      continue;
                    }
                    goto case 9;
                  case 3:
                    itemUid1 = FindComponentService.E9tAxZBFV0HgOdgjNQ3I((object) current1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 7;
                    continue;
                  case 5:
                    moduleItemUid1 = FindComponentService.MeY255BFZT4ltNIPAYVj((object) current1);
                    num2 = 2;
                    continue;
                  case 6:
                    goto label_7;
                  case 7:
                    if (FindComponentService.SHwxCpBFI8kUKZhtBG8g(itemUid1, Guid.Empty))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
                      continue;
                    }
                    goto case 5;
                  case 8:
                    goto label_34;
                  case 9:
                    LoadModule(FindComponentService.MJd4j0BFSxyqrmO88VXq((object) current1), moduleItemUid1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                    continue;
                  case 10:
                    goto label_29;
                  case 11:
                    goto label_94;
                  default:
                    enumerator4 = current1.Functions.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 6;
                    continue;
                }
              }
label_7:
              try
              {
label_12:
                if (enumerator4.MoveNext())
                  goto label_15;
                else
                  goto label_13;
label_8:
                ClientFunctionModel current2;
                Guid moduleItemUid2;
                Guid itemUid2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      LoadModule(current2.ModuleUid, moduleItemUid2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_15;
                    case 3:
                      if (FindComponentService.SHwxCpBFI8kUKZhtBG8g(moduleItemUid2, Guid.Empty))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_12;
                    case 4:
                      moduleItemUid2 = FindComponentService.DrepmcBFiXaxOYhG0UYT((object) current2);
                      num3 = 3;
                      continue;
                    case 5:
                      goto label_29;
                    case 6:
                      itemUid2 = current2.ItemUid;
                      num3 = 7;
                      continue;
                    case 7:
                      if (FindComponentService.SHwxCpBFI8kUKZhtBG8g(itemUid2, Guid.Empty))
                      {
                        num3 = 8;
                        continue;
                      }
                      goto case 4;
                    case 8:
                      LoadFunctionConfiguration(itemUid2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 4;
                      continue;
                    default:
                      goto label_12;
                  }
                }
label_13:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 5;
                goto label_8;
label_15:
                current2 = enumerator4.Current;
                num3 = 6;
                goto label_8;
              }
              finally
              {
                enumerator4.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
label_30:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 11;
              goto label_5;
label_34:
              current1 = enumerator1.Current;
              num2 = 3;
              goto label_5;
            }
            finally
            {
              int num5;
              if (enumerator1 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              else
                goto label_38;
label_37:
              switch (num5)
              {
                case 1:
                  break;
                default:
              }
label_38:
              FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator1);
              num5 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
              {
                num5 = 2;
                goto label_37;
              }
              else
                goto label_37;
            }
          case 5:
            enumerator1 = recursiveModel1.ComponentCache.Concat<ClientComponentModel>((IEnumerable<ClientComponentModel>) new ClientComponentModel[1]
            {
              header
            }).GetEnumerator();
            num1 = 4;
            continue;
          case 6:
label_91:
            enumerator3 = recursiveModel1.ExtensionPoints.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
            continue;
          case 7:
label_94:
            enumerator2 = recursiveModel1.CustomTypes.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 8:
            header = recursiveModel1.Header;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 5;
            continue;
          case 9:
            goto label_89;
          default:
            try
            {
label_52:
              if (enumerator2.MoveNext())
                goto label_54;
              else
                goto label_53;
label_43:
              CustomTypeModel current;
              Guid itemUid;
              Guid moduleItemUid;
              int num6;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                  case 4:
                    moduleItemUid = current.ModuleItemUid;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 3 : 3;
                    continue;
                  case 2:
                    goto label_54;
                  case 3:
                    if (!FindComponentService.SHwxCpBFI8kUKZhtBG8g(moduleItemUid, Guid.Empty))
                    {
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 6 : 0;
                      continue;
                    }
                    goto case 8;
                  case 5:
                    LoadComponentConfiguration(itemUid);
                    num6 = 11;
                    continue;
                  case 6:
                  case 10:
                  case 11:
                    goto label_52;
                  case 7:
                    itemUid = FindComponentService.RoQqCaBFRmwxZQEEr95e((object) current);
                    num6 = 9;
                    continue;
                  case 8:
                    LoadModule(current.ModuleUid, moduleItemUid);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 9 : 10;
                    continue;
                  case 9:
                    if (!FindComponentService.SHwxCpBFI8kUKZhtBG8g(itemUid, Guid.Empty))
                    {
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
                      continue;
                    }
                    goto case 5;
                  default:
                    goto label_91;
                }
              }
label_53:
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              goto label_43;
label_54:
              current = enumerator2.Current;
              num6 = 7;
              goto label_43;
            }
            finally
            {
              enumerator2.Dispose();
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                num7 = 0;
              switch (num7)
              {
                default:
              }
            }
        }
      }
label_89:
      return;
label_59:
      try
      {
label_61:
        if (enumerator3.MoveNext())
          goto label_63;
        else
          goto label_62;
label_60:
        List<ClientImplementationModel>.Enumerator enumerator5;
        int num8;
        switch (num8)
        {
          case 1:
            return;
          case 2:
            goto label_63;
          case 3:
            goto label_61;
          default:
            try
            {
label_74:
              if (enumerator5.MoveNext())
                goto label_69;
              else
                goto label_75;
label_68:
              ClientImplementationModel current;
              int num9;
              while (true)
              {
                int num10;
                Guid itemUid;
                Guid moduleItemUid;
                switch (num9)
                {
                  case 1:
                    itemUid = FindComponentService.anstrnBFq6qDS1uSunmG((object) current);
                    num10 = 8;
                    break;
                  case 2:
                    LoadModule(FindComponentService.zZ5tqXBFXc8CW3jfJJC3((object) current), moduleItemUid);
                    num9 = 6;
                    continue;
                  case 3:
                  case 9:
                    moduleItemUid = FindComponentService.u9VTAiBFKr2hcEsUT9CQ((object) current);
                    num9 = 4;
                    continue;
                  case 4:
                    if (FindComponentService.SHwxCpBFI8kUKZhtBG8g(moduleItemUid, Guid.Empty))
                    {
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 2;
                      continue;
                    }
                    goto label_74;
                  case 5:
                    LoadComponentConfiguration(itemUid);
                    num10 = 7;
                    break;
                  case 6:
                  case 7:
                    goto label_74;
                  case 8:
                    if (!FindComponentService.SHwxCpBFI8kUKZhtBG8g(itemUid, Guid.Empty))
                    {
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 9;
                      continue;
                    }
                    goto case 5;
                  case 10:
                    goto label_61;
                  default:
                    goto label_69;
                }
                num9 = num10;
              }
label_69:
              current = enumerator5.Current;
              num9 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
              {
                num9 = 0;
                goto label_68;
              }
              else
                goto label_68;
label_75:
              num9 = 10;
              goto label_68;
            }
            finally
            {
              enumerator5.Dispose();
              int num11 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
                num11 = 0;
              switch (num11)
              {
                default:
              }
            }
        }
label_62:
        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
        goto label_60;
label_63:
        enumerator5 = enumerator3.Current.Implementations.GetEnumerator();
        num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        {
          num8 = 0;
          goto label_60;
        }
        else
          goto label_60;
      }
      finally
      {
        enumerator3.Dispose();
        int num12 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
          num12 = 0;
        switch (num12)
        {
          default:
        }
      }

      void LoadComponentConfiguration(Guid itemUid)
      {
        int num = 2;
        ComponentMetadataItem componentMetadataItem;
        ComponentMetadata componentMetadata;
        List<EntityDependency> entityDependencies;
        List<EnumDependency> enumDependencies;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              if (!this.loadedComponents.TryGetValue(itemUid, out componentMetadataItem))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
                continue;
              }
              goto case 3;
            case 3:
              componentMetadata = (ComponentMetadata) FindComponentService.DFASlozYEBdlcbhTFVo((object) componentMetadataItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            case 4:
              recursiveModel1.EntityDependencies.AddRange((IEnumerable<EntityDependency>) entityDependencies);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 8;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated method
              recursiveModel1.EnumMetadataUids.AddRange<Guid>(enumDependencies.Select<EnumDependency, Guid>((Func<EnumDependency, Guid>) (e => FindComponentService.\u003C\u003Ec.iAlAUUfc0plFGpGBPEZO((object) e))));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 4 : 7;
              continue;
            case 6:
              recursiveModel1.EnumDependencies.AddRange((IEnumerable<EnumDependency>) componentMetadata.EnumDependencies);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 5 : 5;
              continue;
            case 7:
              goto label_2;
            case 8:
              recursiveModel1.EntityMetadataUids.AddRange<Guid>(FindComponentService.GetEntityMetadataGuids((IEnumerable<EntityDependency>) entityDependencies));
              num = 9;
              continue;
            case 9:
              enumDependencies = componentMetadata.EnumDependencies;
              num = 6;
              continue;
            default:
              entityDependencies = componentMetadata.EntityDependencies;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 4;
              continue;
          }
        }
label_6:
        return;
label_2:;
      }

      void LoadFunctionConfiguration(Guid itemUid)
      {
        int num = 1;
        FunctionMetadata metadata;
        List<EntityDependency> entityDependencies;
        FunctionMetadataItem functionMetadataItem;
        List<EnumDependency> enumDependencies;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_8;
            case 1:
              if (!this.loadedFunctions.TryGetValue(itemUid, out functionMetadataItem))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 2:
              entityDependencies = metadata.EntityDependencies;
              num = 9;
              continue;
            case 3:
              recursiveModel1.EnumDependencies.AddRange((IEnumerable<EnumDependency>) metadata.EnumDependencies);
              num = 5;
              continue;
            case 4:
              goto label_2;
            case 5:
              // ISSUE: reference to a compiler-generated method
              recursiveModel1.EnumMetadataUids.AddRange<Guid>(enumDependencies.Select<EnumDependency, Guid>((Func<EnumDependency, Guid>) (e => FindComponentService.\u003C\u003Ec.iAlAUUfc0plFGpGBPEZO((object) e))));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 4 : 1;
              continue;
            case 6:
              enumDependencies = metadata.EnumDependencies;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 3;
              continue;
            case 7:
              metadata = (FunctionMetadata) functionMetadataItem.Metadata;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 2 : 2;
              continue;
            case 8:
              recursiveModel1.EntityMetadataUids.AddRange<Guid>(FindComponentService.GetEntityMetadataGuids((IEnumerable<EntityDependency>) entityDependencies));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 6 : 2;
              continue;
            case 9:
              recursiveModel1.EntityDependencies.AddRange((IEnumerable<EntityDependency>) entityDependencies);
              num = 8;
              continue;
            default:
              goto label_13;
          }
        }
label_8:
        return;
label_2:
        return;
label_13:;
      }

      void LoadModule(Guid moduleUid, Guid moduleItemUid)
      {
        int num = 2;
        ModuleVersion specificModuleVersion;
        List<EnumDependency> enumDependencies;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (specificModuleVersion == null)
              {
                num = 6;
                continue;
              }
              goto case 4;
            case 2:
              specificModuleVersion = this.moduleMetadataLoader.GetSpecificModuleVersion(moduleUid, moduleItemUid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_10;
            case 4:
              ModuleDependency dependency = ((ModuleInfoMetadata) FindComponentService.iMlyy1ztkAWCr8rEdWj((object) specificModuleVersion)).Dependency;
              List<EntityDependency> entityDependencies = dependency.EntityDependencies;
              recursiveModel1.EntityDependencies.AddRange((IEnumerable<EntityDependency>) entityDependencies);
              recursiveModel1.EntityMetadataUids.AddRange<Guid>(FindComponentService.GetEntityMetadataGuids((IEnumerable<EntityDependency>) entityDependencies));
              enumDependencies = dependency.EnumDependencies;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 5;
              continue;
            case 5:
              recursiveModel1.EnumDependencies.AddRange((IEnumerable<EnumDependency>) enumDependencies);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_8;
            default:
              HashSet<Guid> enumMetadataUids = recursiveModel1.EnumMetadataUids;
              List<EnumDependency> source = enumDependencies;
              // ISSUE: reference to a compiler-generated field
              Func<EnumDependency, Guid> func = FindComponentService.\u003C\u003Ec.\u003C\u003E9__53_5;
              Func<EnumDependency, Guid> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                FindComponentService.\u003C\u003Ec.\u003C\u003E9__53_5 = selector = (Func<EnumDependency, Guid>) (e => e.HeaderUid);
              }
              else
                goto label_2;
label_12:
              IEnumerable<Guid> items = source.Select<EnumDependency, Guid>(selector);
              enumMetadataUids.AddRange<Guid>(items);
              num = 3;
              continue;
label_2:
              selector = func;
              goto label_12;
          }
        }
label_10:
        return;
label_8:;
      }
    }

    private static IEnumerable<Guid> GetEntityMetadataGuids(
      IEnumerable<EntityDependency> entityDependencies)
    {
      List<EntityMetadata> entityMetadataList = new List<EntityMetadata>();
      foreach (EntityDependency entityDependency in entityDependencies)
      {
        try
        {
          if (MetadataServiceContext.Service.GetMetadata(entityDependency.HeaderUid) is EntityMetadata metadata)
            entityMetadataList.Add(metadata);
        }
        catch
        {
        }
      }
      HashSet<EntityMetadata> source = new HashSet<EntityMetadata>();
      foreach (EntityMetadata metadata in entityMetadataList)
      {
        source.Add(metadata);
        foreach (ClassMetadata childClass in MetadataLoader.GetChildClasses((ClassMetadata) metadata))
        {
          try
          {
            source.Add((EntityMetadata) MetadataServiceContext.Service.GetMetadata(childClass.Uid));
          }
          catch
          {
          }
        }
        foreach (ClassMetadata baseClass in MetadataLoader.GetBaseClasses((ClassMetadata) metadata))
        {
          try
          {
            source.Add((EntityMetadata) MetadataServiceContext.Service.GetMetadata(baseClass.Uid));
          }
          catch
          {
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      return source.Select<EntityMetadata, Guid>((Func<EntityMetadata, Guid>) (a => FindComponentService.\u003C\u003Ec.XRNhnPfcmoy5wWgdQfjw((object) a)));
    }

    private (bool result, IEnumerable<ClientDataClassModel> dataClassModels) GetDataClasses(
      string componentName,
      IReadOnlyCollection<DataClassDependency> dataClassDependencies,
      FindComponentService.SearchContext searchContext,
      bool throwException = false)
    {
      if (dataClassDependencies.Count == 0)
        return (true, Enumerable.Empty<ClientDataClassModel>());
      (bool result, IEnumerable<ClientDataClassModel> dataClassModels) = this.GetRuntimeDataClasses((IEnumerable<DataClassDependency>) dataClassDependencies, searchContext);
      if (result)
        return (true, dataClassModels);
      if (!throwException)
        return (false, Enumerable.Empty<ClientDataClassModel>());
      searchContext.Errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137960567), (object) componentName));
      return (false, Enumerable.Empty<ClientDataClassModel>());
    }

    private (bool result, IEnumerable<ClientDataClassModel> dataClassModels) GetRuntimeDataClasses(
      IEnumerable<DataClassDependency> dataClassDependencies,
      FindComponentService.SearchContext searchContext)
    {
      Dictionary<Guid, ClientDataClassModel> result = new Dictionary<Guid, ClientDataClassModel>();
      foreach (DataClassDependency dataClassDependency in dataClassDependencies)
      {
        if (dataClassDependency.ModuleUid == Guid.Empty)
        {
          if (!this.GetDataClassFromConfiguration((EleWise.ELMA.Model.Dependencies.Dependency) dataClassDependency, searchContext, (IDictionary<Guid, ClientDataClassModel>) result))
            return (false, Enumerable.Empty<ClientDataClassModel>());
        }
        else if (!this.GetDataClassFromModule((EleWise.ELMA.Model.Dependencies.Dependency) dataClassDependency, searchContext, (IDictionary<Guid, ClientDataClassModel>) result))
          return (false, Enumerable.Empty<ClientDataClassModel>());
      }
      return (true, (IEnumerable<ClientDataClassModel>) result.Values);
    }

    private bool GetDataClassFromConfiguration(
      EleWise.ELMA.Model.Dependencies.Dependency dependency,
      FindComponentService.SearchContext searchContext,
      IDictionary<Guid, ClientDataClassModel> result)
    {
      Guid headerUid = dependency.HeaderUid;
      if (result.ContainsKey(headerUid))
        return true;
      DataClassMetadataItemHeader metadataItemHeader = this.DataClassMetadataItemHeaderManager?.LoadOrNull(headerUid);
      if (metadataItemHeader == null)
      {
        searchContext.Errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470480468), (object) dependency.DisplayName, (object) headerUid));
        return false;
      }
      DataClassMetadataItem published = metadataItemHeader.Published;
      if (published == null)
      {
        searchContext.Errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978518646), (object) dependency.DisplayName, (object) headerUid));
        return false;
      }
      result[headerUid] = new ClientDataClassModel()
      {
        HeaderUid = headerUid,
        ItemUid = published.Uid
      };
      return true;
    }

    private bool FindConfigurationImpl(
      Guid parent,
      Guid itemUid,
      Guid owner,
      Guid parentComponentUid,
      ComponentMetadataItem item,
      FindComponentService.SearchContext searchContext)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (FindComponentService.nlTaJcBFT5Ie2t4OOk9o((object) item) is ComponentSignature componentSignature)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return this.FindImplInternal(parent, itemUid, owner, parentComponentUid, componentSignature.ExtensionPoints, searchContext);
label_5:
      return true;
    }

    private bool FindModuleImpl(
      Guid parent,
      Guid itemUid,
      Guid owner,
      Guid parentComponentUid,
      ModuleVersion moduleVersion,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 2;
      List<ImplementationSignature> extensionPoints;
      IEnumerable<ImplementationSignature> second;
      FindComponentService.SearchContext searchContext1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              searchContext1 = searchContext;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_4;
            case 4:
              IEnumerable<ModuleVersion> source1 = ((ModuleInfoMetadata) FindComponentService.iMlyy1ztkAWCr8rEdWj((object) moduleVersion)).DependencyModules.Select<LinkToModule, ModuleVersion>((Func<LinkToModule, ModuleVersion>) (m =>
              {
                int num5 = 1;
                LinkToModule m1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_3;
                    default:
                      m1 = m;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 0;
                      continue;
                  }
                }
label_3:
                return searchContext1.CacheRuntimeModules.FirstOrDefault<ModuleVersion>((Func<ModuleVersion, bool>) (r =>
                {
                  int num6 = 3;
                  Guid? nullable4;
                  Guid moduleUid;
                  while (true)
                  {
                    int num7 = num6;
                    Guid? nullable5;
                    object obj;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 1:
                          goto label_14;
                        case 2:
                          nullable5 = new Guid?();
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
                          continue;
                        case 3:
                          // ISSUE: reference to a compiler-generated method
                          obj = FindComponentService.\u003C\u003Ec__DisplayClass59_1.SQi1EVfzLDKJaxO71y5r((object) r);
                          if (obj == null)
                          {
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 0;
                            continue;
                          }
                          goto label_15;
                        case 4:
                          goto label_11;
                        case 5:
                          if (nullable4.HasValue)
                          {
                            num7 = 8;
                            continue;
                          }
                          goto label_11;
                        case 6:
                          goto label_8;
                        case 7:
                          moduleUid = m1.ModuleUid;
                          num7 = 5;
                          continue;
                        case 8:
                          if (nullable4.HasValue)
                          {
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_8;
                        default:
                          goto label_9;
                      }
                    }
label_14:
                    Guid? nullable6 = nullable5;
                    goto label_16;
label_15:
                    // ISSUE: reference to a compiler-generated method
                    nullable6 = new Guid?(FindComponentService.\u003C\u003Ec__DisplayClass59_1.HAd6eSfzUy3RDa3Dk1mu(obj));
label_16:
                    nullable4 = nullable6;
                    num6 = 7;
                  }
label_8:
                  return true;
label_9:
                  // ISSUE: reference to a compiler-generated method
                  return FindComponentService.\u003C\u003Ec__DisplayClass59_1.rvBkWTfzsyf2QDwDLME0(nullable4.GetValueOrDefault(), moduleUid);
label_11:
                  return false;
                }));
              }));
              // ISSUE: reference to a compiler-generated field
              Func<ModuleVersion, bool> func1 = FindComponentService.\u003C\u003Ec.\u003C\u003E9__59_1;
              Func<ModuleVersion, bool> predicate;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                FindComponentService.\u003C\u003Ec.\u003C\u003E9__59_1 = predicate = (Func<ModuleVersion, bool>) (m => m != null);
              }
              else
                goto label_13;
label_9:
              IEnumerable<ModuleVersion> source2 = source1.Where<ModuleVersion>(predicate);
              // ISSUE: reference to a compiler-generated field
              Func<ModuleVersion, IEnumerable<ImplementationSignature>> func2 = FindComponentService.\u003C\u003Ec.\u003C\u003E9__59_2;
              Func<ModuleVersion, IEnumerable<ImplementationSignature>> selector;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                FindComponentService.\u003C\u003Ec.\u003C\u003E9__59_2 = selector = (Func<ModuleVersion, IEnumerable<ImplementationSignature>>) (m => (IEnumerable<ImplementationSignature>) m.Header.Signature.ExtensionPoints);
              }
              else
                goto label_12;
label_11:
              second = source2.SelectMany<ModuleVersion, ImplementationSignature>(selector);
              num2 = 3;
              continue;
label_12:
              selector = func2;
              goto label_11;
label_13:
              predicate = func1;
              goto label_9;
            default:
              goto label_5;
          }
        }
label_5:
        extensionPoints = ((ModuleSignature) FindComponentService.Myq9P5BFkln6ljxvfiBh((object) moduleVersion.Header)).ExtensionPoints;
        num1 = 4;
      }
label_4:
      return this.FindImplInternal(parent, itemUid, owner, parentComponentUid, extensionPoints.Concat<ImplementationSignature>(second).ToList<ImplementationSignature>(), searchContext1);
    }

    private bool FindImplInternal(
      Guid parent,
      Guid itemUid,
      Guid owner,
      Guid parentComponentUid,
      List<ImplementationSignature> extensionPoints,
      FindComponentService.SearchContext searchContext)
    {
      if (parent == Guid.Empty || extensionPoints.Count == 0)
        return true;
      if (searchContext.CacheLastPublishedComponents.Count == 0)
        searchContext.CacheLastPublishedComponents.AddRange(this.GetLastPublishedComponents().Where<ComponentMetadataItemWrapper>((Func<ComponentMetadataItemWrapper, bool>) (item =>
        {
          int num1 = 1;
          ComponentSignature componentSignature;
          while (true)
          {
            int num2 = num1;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  componentSignature = (ComponentSignature) FindComponentService.\u003C\u003Ec.ArdWkkfcDyYnjCXt3mlt((object) item);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                  continue;
                case 2:
                  goto label_6;
                case 3:
                  goto label_7;
                default:
                  goto label_3;
              }
            }
label_3:
            if (componentSignature != null)
              num1 = 3;
            else
              break;
          }
label_6:
          return false;
label_7:
          return componentSignature.Implementations.Any<ImplementationSignature>();
        })));
      if (searchContext.CacheRuntimeModules.Count == 0)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ModuleVersion[] array = this.GetAdditionalModules().Select<ClientComponentModel, ModuleVersion>((Func<ClientComponentModel, ModuleVersion>) (w => this.moduleMetadataLoader.GetSpecificModuleVersion(FindComponentService.\u003C\u003Ec__DisplayClass60_0.Y0THF0QFBrUKJEyb0kPI((object) w), FindComponentService.\u003C\u003Ec__DisplayClass60_0.XAiSAoQFWhvZqkNagebV((object) w)))).ToArray<ModuleVersion>();
        // ISSUE: reference to a compiler-generated method
        IEnumerable<Guid> excluded = ((IEnumerable<ModuleVersion>) array).Select<ModuleVersion, Guid>((Func<ModuleVersion, Guid>) (m => FindComponentService.\u003C\u003Ec.c5ynBufcHHweeI3ve4iw((object) m.Header)));
        searchContext.CacheRuntimeModules.AddRange(((IEnumerable<ModuleVersion>) array).Concat<ModuleVersion>((IEnumerable<ModuleVersion>) this.moduleMetadataLoader.GetAllDefaultVersions(excluded)));
      }
      if (searchContext.CacheImplementationModules.Count == 0 && searchContext.CacheRuntimeModules.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        searchContext.CacheImplementationModules.AddRange(searchContext.CacheRuntimeModules.Where<ModuleVersion>((Func<ModuleVersion, bool>) (item => FindComponentService.\u003C\u003Ec.pZScyGfcygmr2jmD5OD7((object) ((ModuleVersionHeader) FindComponentService.\u003C\u003Ec.u1os3Xfc6rAqw6yX12Cg((object) item)).Signature.Implementations) > 0)));
      }
      if (searchContext.CacheLastPublishedDataClasses.Count == 0)
        searchContext.CacheLastPublishedDataClasses.AddRange(this.GetLastPublishedDataClasses());
      foreach (ImplementationSignature extensionPoint1 in extensionPoints)
      {
        ImplementationSignature extensionPoint = extensionPoint1;
        if (!(extensionPoint.TypeUid == Guid.Empty))
        {
          Dictionary<Guid, ClientDataClassModel> types = new Dictionary<Guid, ClientDataClassModel>();
          GetIncludes(extensionPoint.TypeUid, Guid.Empty, Guid.Empty, types, false);
          if (searchContext.ExtensionPoints.FirstOrDefault<ClientExtensionPointModel>((Func<ClientExtensionPointModel, bool>) (i =>
          {
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_3;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (!FindComponentService.\u003C\u003Ec__DisplayClass60_3.UNBInUQFTJjJb4LPmIjw(FindComponentService.\u003C\u003Ec__DisplayClass60_3.tyd6FhQFKRvJpqykqEG3((object) i), FindComponentService.\u003C\u003Ec__DisplayClass60_3.vlFNfjQFX76W7qRpV5RR((object) extensionPoint)))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
                    continue;
                  }
                  goto label_2;
                default:
                  goto label_2;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return FindComponentService.\u003C\u003Ec__DisplayClass60_3.hN5qmTQFnU5ij5U0EgQQ(FindComponentService.\u003C\u003Ec__DisplayClass60_3.FUdjcnQFkVuqOnEJAgyw((object) i), extensionPoint.TypeUid);
label_3:
            return false;
          })) == null)
          {
            ClientExtensionPointModel extensionPointModel = new ClientExtensionPointModel()
            {
              PointId = extensionPoint.PointId,
              TypeUid = extensionPoint.TypeUid
            };
            searchContext.ExtensionPoints.Add(extensionPointModel);
            foreach (ComponentMetadataItemWrapper publishedComponent in searchContext.CacheLastPublishedComponents)
            {
              if (publishedComponent.Signature.Implementations.Any<ImplementationSignature>((Func<ImplementationSignature, bool>) (i =>
              {
                int num3 = 8;
                ImplementationSignature i1;
                while (true)
                {
                  int num4 = num3;
                  IEnumerator<KeyValuePair<Guid, ClientDataClassModel>> enumerator;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_5;
                      case 2:
                        goto label_9;
                      case 3:
                        goto label_10;
                      case 4:
                        goto label_24;
                      case 5:
                        Dictionary<Guid, ClientDataClassModel> source = types;
                        Func<KeyValuePair<Guid, ClientDataClassModel>, bool> func = closure_0;
                        Func<KeyValuePair<Guid, ClientDataClassModel>, bool> predicate = func == null ? (closure_0 = (Func<KeyValuePair<Guid, ClientDataClassModel>, bool>) (dataClass => !searchContext.DataClasses.ContainsKey(dataClass.Key))) : func;
                        enumerator = source.Where<KeyValuePair<Guid, ClientDataClassModel>>(predicate).GetEnumerator();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                        continue;
                      case 6:
label_3:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!FindComponentService.\u003C\u003Ec__DisplayClass60_4.vBPSFbQFpXfuCD2VpBxc(FindComponentService.\u003C\u003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo((object) extensionPoint)))
                        {
                          num4 = 3;
                          continue;
                        }
                        goto label_9;
                      case 7:
                        i1 = i;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
                        continue;
                      case 8:
                        num4 = 7;
                        continue;
                      default:
                        try
                        {
label_15:
                          // ISSUE: reference to a compiler-generated method
                          if (FindComponentService.\u003C\u003Ec__DisplayClass60_4.xAHTQoQF1WRbMqE1bfrj((object) enumerator))
                            goto label_17;
                          else
                            goto label_16;
label_13:
                          KeyValuePair<Guid, ClientDataClassModel> current;
                          int num5;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 1:
                                searchContext.DataClasses[current.Key] = current.Value;
                                num5 = 3;
                                continue;
                              case 2:
                                goto label_3;
                              case 3:
                                goto label_15;
                              default:
                                goto label_17;
                            }
                          }
label_16:
                          num5 = 2;
                          goto label_13;
label_17:
                          current = enumerator.Current;
                          num5 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
                          {
                            num5 = 0;
                            goto label_13;
                          }
                          else
                            goto label_13;
                        }
                        finally
                        {
                          int num6;
                          if (enumerator == null)
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
                          else
                            goto label_22;
label_21:
                          switch (num6)
                          {
                            case 1:
                            case 2:
                          }
label_22:
                          // ISSUE: reference to a compiler-generated method
                          FindComponentService.\u003C\u003Ec__DisplayClass60_4.IPi6m7QFNCnaRfLtDk70((object) enumerator);
                          num6 = 2;
                          goto label_21;
                        }
                    }
                  }
label_5:
                  if (!types.All<KeyValuePair<Guid, ClientDataClassModel>>((Func<KeyValuePair<Guid, ClientDataClassModel>, bool>) (d => d.Key != i1.TypeUid)))
                    num3 = 5;
                  else
                    goto label_24;
                }
label_9:
                return true;
label_10:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return (string) FindComponentService.\u003C\u003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo((object) i1) == (string) FindComponentService.\u003C\u003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo((object) extensionPoint);
label_24:
                return false;
              })) && this.FindImplConfigurationComponent(parent, itemUid, owner, publishedComponent, searchContext))
                extensionPointModel.Implementations.Add(new ClientImplementationModel()
                {
                  HeaderUid = publishedComponent.HeaderUid,
                  ItemUid = publishedComponent.Uid
                });
            }
            foreach (ModuleVersion implementationModule in searchContext.CacheImplementationModules)
            {
              if (implementationModule.Header.Signature.Implementations.Any<ImplementationSignature>((Func<ImplementationSignature, bool>) (i =>
              {
                int num = 3;
                ImplementationSignature i4;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (!string.IsNullOrWhiteSpace((string) FindComponentService.\u003C\u003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo((object) extensionPoint)))
                      {
                        num = 6;
                        continue;
                      }
                      goto label_9;
                    case 2:
                      i4 = i;
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                      continue;
                    case 3:
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 2;
                      continue;
                    case 4:
                      goto label_4;
                    case 5:
                      goto label_9;
                    case 6:
                      goto label_10;
                    default:
                      if (!types.All<KeyValuePair<Guid, ClientDataClassModel>>((Func<KeyValuePair<Guid, ClientDataClassModel>, bool>) (d => d.Key != i4.TypeUid)))
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_4;
                  }
                }
label_4:
                return false;
label_9:
                return true;
label_10:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return FindComponentService.\u003C\u003Ec__DisplayClass60_4.OhShT3QFaOKRRtQKMxhV(FindComponentService.\u003C\u003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo((object) i4), (object) extensionPoint.PointId);
              })))
              {
                Func<Implementation, bool> func;
                foreach (ComponentMetadata componentMetadata in implementationModule.Metadata.Components.Where<ComponentMetadata>((Func<ComponentMetadata, bool>) (c =>
                {
                  List<Implementation> implementations = c.Implementations;
                  Func<Implementation, bool> func1 = func;
                  Func<Implementation, bool> predicate = func1 == null ? (func = (Func<Implementation, bool>) (i =>
                  {
                    int num9 = 1;
                    Implementation i3;
                    while (true)
                    {
                      int num10 = num9;
                      while (true)
                      {
                        switch (num10)
                        {
                          case 1:
                            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                            continue;
                          case 2:
                            if (types.All<KeyValuePair<Guid, ClientDataClassModel>>((Func<KeyValuePair<Guid, ClientDataClassModel>, bool>) (d => d.Key != i3.TypeUid)))
                            {
                              num10 = 3;
                              continue;
                            }
                            goto label_6;
                          case 3:
                            goto label_5;
                          case 4:
                            goto label_10;
                          default:
                            i3 = i;
                            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 2;
                            continue;
                        }
                      }
label_6:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (FindComponentService.\u003C\u003Ec__DisplayClass60_4.vBPSFbQFpXfuCD2VpBxc(FindComponentService.\u003C\u003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo((object) extensionPoint)))
                        num9 = 4;
                      else
                        goto label_11;
                    }
label_5:
                    return false;
label_10:
                    return true;
label_11:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    return FindComponentService.\u003C\u003Ec__DisplayClass60_4.OhShT3QFaOKRRtQKMxhV(FindComponentService.\u003C\u003Ec__DisplayClass60_4.jyjImoQFDE2wqa7M96a7((object) i3), FindComponentService.\u003C\u003Ec__DisplayClass60_4.Fa1XD6QF3rV69VaMtxpo((object) extensionPoint));
                  })) : func1;
                  return implementations.Any<Implementation>(predicate);
                })))
                {
                  if (this.FindImplModuleComponent(parent, itemUid, owner, parentComponentUid, componentMetadata, implementationModule, searchContext))
                    extensionPointModel.Implementations.Add(new ClientImplementationModel()
                    {
                      HeaderUid = componentMetadata.Uid,
                      ModuleItemUid = implementationModule.Header.VersionUid,
                      ModuleUid = implementationModule.Header.HeaderUid
                    });
                }
              }
            }
          }
        }
      }
      return true;

      void GetIncludes(
        Guid uid,
        Guid iUid,
        Guid mUid,
        Dictionary<Guid, ClientDataClassModel> list,
        bool onlyModules)
      {
        if (searchContext.CacheIncludeDataClasses.ContainsKey(uid))
        {
          foreach (KeyValuePair<Guid, ClientDataClassModel> keyValuePair in searchContext.CacheIncludeDataClasses[uid])
            list.Add(keyValuePair.Key, keyValuePair.Value);
        }
        else
        {
          if (iUid == Guid.Empty && mUid == Guid.Empty)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            DataClassMetadataItem classMetadataItem = searchContext.CacheLastPublishedDataClasses.Find((Predicate<DataClassMetadataItem>) (i => FindComponentService.\u003C\u003Ec__DisplayClass60_1.fs0Ot7QFfvu8T8CJmu35(FindComponentService.\u003C\u003Ec__DisplayClass60_1.wNc7UvQFEVbr39OrU0L6(FindComponentService.\u003C\u003Ec__DisplayClass60_1.rsNGrNQFGIalq2guD1oO((object) i)), uid)));
            if (classMetadataItem != null)
            {
              iUid = classMetadataItem.Uid;
            }
            else
            {
              Func<DataClassMetadata, bool> func;
              mUid = searchContext.CacheRuntimeModules.Find((Predicate<ModuleVersion>) (m =>
              {
                // ISSUE: reference to a compiler-generated method
                List<DataClassMetadata> dataClasses = ((ModuleInfoMetadata) FindComponentService.\u003C\u003Ec__DisplayClass60_1.ERwujfQFQcSBo1URodsC((object) m)).DataClasses;
                Func<DataClassMetadata, bool> func = func;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                Func<DataClassMetadata, bool> predicate = func == null ? (func = (Func<DataClassMetadata, bool>) (d => FindComponentService.\u003C\u003Ec__DisplayClass60_1.fs0Ot7QFfvu8T8CJmu35(FindComponentService.\u003C\u003Ec__DisplayClass60_1.iQWivMQFCJOqfwHQrxNS((object) d), uid))) : func;
                return dataClasses.Any<DataClassMetadata>(predicate);
              })).Header.VersionUid;
            }
          }
          list.Add(uid, new ClientDataClassModel()
          {
            HeaderUid = uid,
            ItemUid = iUid,
            ModuleItemUid = mUid
          });
          if (!onlyModules)
          {
            Func<DataClassDependency, bool> func;
            foreach (DataClassMetadataItem classMetadataItem in searchContext.CacheLastPublishedDataClasses.Where<DataClassMetadataItem>((Func<DataClassMetadataItem, bool>) (item =>
            {
              int num = 1;
              DataClassMetadata dataClassMetadata;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    dataClassMetadata = FindComponentService.\u003C\u003Ec__DisplayClass60_1.P19j3MQFvSGNVUJUOUJM((object) item) as DataClassMetadata;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_5;
                  case 3:
                    goto label_6;
                  default:
                    if (dataClassMetadata != null)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 3;
                      continue;
                    }
                    goto label_5;
                }
              }
label_5:
              return false;
label_6:
              List<DataClassDependency> includeList = dataClassMetadata.IncludeList;
              Func<DataClassDependency, bool> func = func;
              // ISSUE: reference to a compiler-generated method
              Func<DataClassDependency, bool> predicate = func == null ? (func = (Func<DataClassDependency, bool>) (i => FindComponentService.\u003C\u003Ec__DisplayClass60_1.UviXkcQF8rK4vv3b6rgy((object) i) == uid)) : func;
              return includeList.Any<DataClassDependency>(predicate);
            })))
              GetIncludes(classMetadataItem.Header.Uid, classMetadataItem.Uid, Guid.Empty, list, false);
          }
          List<DataClassMetadata> dataClassMetadataList = new List<DataClassMetadata>();
          foreach (ModuleVersion cacheRuntimeModule in searchContext.CacheRuntimeModules)
          {
            ModuleInfoMetadata metadata = cacheRuntimeModule.Metadata;
            Func<DataClassDependency, bool> func;
            dataClassMetadataList.AddRange(metadata.DataClasses.Where<DataClassMetadata>((Func<DataClassMetadata, bool>) (d =>
            {
              List<DataClassDependency> includeList = d.IncludeList;
              Func<DataClassDependency, bool> func = func;
              // ISSUE: reference to a compiler-generated method
              Func<DataClassDependency, bool> predicate = func == null ? (func = (Func<DataClassDependency, bool>) (i => FindComponentService.\u003C\u003Ec__DisplayClass60_1.UviXkcQF8rK4vv3b6rgy((object) i) == uid)) : func;
              return includeList.Any<DataClassDependency>(predicate);
            })));
          }
          foreach (DataClassMetadata dataClassMetadata in dataClassMetadataList)
          {
            DataClassMetadata moduleDtoType = dataClassMetadata;
            // ISSUE: reference to a compiler-generated method
            Guid versionUid = searchContext.CacheRuntimeModules.Find((Predicate<ModuleVersion>) (m => FindComponentService.\u003C\u003Ec__DisplayClass60_2.slbmWDQFVaepnMpHPgDy(m.Header.HeaderUid, moduleDtoType.ModuleUid))).Header.VersionUid;
            GetIncludes(moduleDtoType.Uid, Guid.Empty, versionUid, list, true);
          }
          searchContext.CacheIncludeDataClasses.Add(uid, list);
        }
      }
    }

    private IEnumerable<DataClassMetadataItem> GetLastPublishedDataClasses() => this.DataClassMetadataItemManager?.GetLastPublished() ?? Enumerable.Empty<DataClassMetadataItem>();

    private IEnumerable<ComponentMetadataItemWrapper> GetLastPublishedComponents() => this.ComponentMetadataItemManager?.GetLastPublished() ?? Enumerable.Empty<ComponentMetadataItemWrapper>();

    private bool FindImplConfigurationComponent(
      Guid parent,
      Guid parentItemUid,
      Guid owner,
      ComponentMetadataItemWrapper componentMetadataWrapper,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 4;
      IEnumerator<ClientDataClassModel> enumerator1;
      FindComponentService.SearchContext searchContext1;
      while (true)
      {
        int num2 = num1;
        Guid itemUid;
        IEnumerator<Guid> enumerator2;
        ClientComponentModel clientComponentModel1;
        HashSet<string>.Enumerator enumerator3;
        ComponentMetadataItem componentMetadataItem1;
        bool result1;
        bool result2;
        ComponentMetadata metadata;
        IEnumerable<ClientDataClassModel> clientDataClassModels;
        ComponentMetadataItem componentMetadataItem2;
        IEnumerator<ClientFunctionModel> enumerator4;
        IEnumerable<ClientFunctionModel> functionModels;
        Guid parentComponentUid;
        ComponentGraph.Vertex vertex;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_85;
            case 2:
              (result1, functionModels) = this.GetFunctions((string) FindComponentService.BcBEmvzUHSE6Hf3AR79((object) metadata), (IReadOnlyCollection<FunctionDependency>) metadata.FunctionDependencies, searchContext1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 28 : 10;
              continue;
            case 3:
              searchContext1 = searchContext;
              num2 = 29;
              continue;
            case 4:
              num2 = 3;
              continue;
            case 5:
              goto label_28;
            case 6:
              metadata = (ComponentMetadata) componentMetadataItem2.Metadata;
              num2 = 16;
              continue;
            case 7:
              try
              {
label_58:
                if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator4))
                  goto label_61;
                else
                  goto label_59;
label_57:
                ClientFunctionModel current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_90;
                    case 2:
                      searchContext1.Functions[FindComponentService.JjPtnYBFoMWBXtGgW9M3((object) current)] = current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_61;
                    default:
                      goto label_58;
                  }
                }
label_59:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                goto label_57;
label_61:
                current = enumerator4.Current;
                num3 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
                {
                  num3 = 0;
                  goto label_57;
                }
                else
                  goto label_57;
              }
              finally
              {
                int num4;
                if (enumerator4 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                else
                  goto label_66;
label_65:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_66:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator4);
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
                {
                  num4 = 0;
                  goto label_65;
                }
                else
                  goto label_65;
              }
            case 8:
label_90:
              // ISSUE: reference to a compiler-generated method
              enumerator1 = clientDataClassModels.Where<ClientDataClassModel>((Func<ClientDataClassModel, bool>) (dataClass => !searchContext1.DataClasses.ContainsKey(FindComponentService.\u003C\u003Ec__DisplayClass63_0.rHMB7gQFjQfAvigbK2sL((object) dataClass)))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 21 : 24;
              continue;
            case 9:
              if (FindComponentService.SODVc5BFE1jGqDmIIqZJ((object) clientComponentModel1) != FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 17 : 4;
                continue;
              }
              goto label_28;
            case 10:
              if (result2)
              {
                if (!searchContext1.Components.TryGetValue(itemUid, out clientComponentModel1))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 23 : 19;
                  continue;
                }
                goto case 9;
              }
              else
                goto label_33;
            case 11:
            case 19:
label_89:
              IEnumerable<ClientFunctionModel> source = functionModels;
              Func<ClientFunctionModel, bool> func;
              Func<ClientFunctionModel, bool> func1 = func;
              // ISSUE: reference to a compiler-generated method
              Func<ClientFunctionModel, bool> predicate = func1 == null ? (func = (Func<ClientFunctionModel, bool>) (function => !searchContext1.Functions.ContainsKey(FindComponentService.\u003C\u003Ec__DisplayClass63_0.fTWrk5QF5FbSH9uuCoR6((object) function)))) : func1;
              enumerator4 = source.Where<ClientFunctionModel>(predicate).GetEnumerator();
              num2 = 7;
              continue;
            case 12:
              componentMetadataItem2 = componentMetadataItem1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 6 : 5;
              continue;
            case 13:
              itemUid = vertex.ItemUid;
              num2 = 20;
              continue;
            case 14:
              goto label_77;
            case 15:
              goto label_69;
            case 16:
              if (!this.FindComponent(itemUid, itemUid, FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex) ? itemUid : owner, parentComponentUid, (IEnumerable<ComponentDependency>) metadata.ComponentDependencies, searchContext1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
                continue;
              }
              if (this.FindConfigurationImpl(itemUid, itemUid, FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex) ? itemUid : owner, parentComponentUid, componentMetadataItem2, searchContext1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 1;
                continue;
              }
              goto label_69;
            case 17:
              FindComponentService.aJiRH2BFWqD71eFO0MDW((object) clientComponentModel1, false);
              num2 = 5;
              continue;
            case 18:
label_88:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              enumerator2 = vertex.Owners.Where<Guid>((Func<Guid, bool>) (ownerUid => FindComponentService.\u003C\u003Ec__DisplayClass63_0.aa32ZWQFge2jpeA2aV9c(ownerUid, FindComponentService.\u003C\u003Ec__DisplayClass63_0.JJx6sPQFrPiEUWqvjDrZ((object) vertex)))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            case 20:
              if (!this.loadedComponents.TryGetValue(itemUid, out componentMetadataItem2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 30 : 25;
                continue;
              }
              goto case 6;
            case 21:
              try
              {
label_22:
                if (enumerator3.MoveNext())
                  goto label_20;
                else
                  goto label_23;
label_18:
                string current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_88;
                    case 2:
                      goto label_22;
                    case 3:
                      goto label_20;
                    default:
                      clientComponentModel1.RenderUidList.Add(current);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 2;
                      continue;
                  }
                }
label_20:
                current = enumerator3.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                {
                  num5 = 0;
                  goto label_18;
                }
                else
                  goto label_18;
label_23:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
                goto label_18;
              }
              finally
              {
                enumerator3.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 22:
              goto label_80;
            case 23:
              Dictionary<Guid, ClientComponentModel> components = searchContext1.Components;
              Guid key = itemUid;
              ClientComponentModel clientComponentModel2 = new ClientComponentModel();
              FindComponentService.gHf6qOBFF83pESH2yeSb((object) clientComponentModel2, itemUid);
              clientComponentModel2.Async = FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex);
              clientComponentModel2.RenderUidList = vertex.ViewItemUidList;
              clientComponentModel2.Owners = vertex.Owners;
              components[key] = clientComponentModel2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 11 : 11;
              continue;
            case 24:
              goto label_34;
            case 25:
              goto label_55;
            case 26:
              goto label_48;
            case 27:
              vertex = ((ComponentGraph) FindComponentService.cKHlxVzcgw9q1aIwTx5((object) searchContext1)).AddVertex(componentMetadataWrapper.HeaderUid, FindComponentService.A3K5WQza9pDvO3NWvq1((object) componentMetadataWrapper), Guid.Empty, parentItemUid, string.Empty, owner, true);
              num2 = 13;
              continue;
            case 28:
              if (!result1)
              {
                num2 = 26;
                continue;
              }
              (result2, clientDataClassModels) = this.GetDataClasses((string) FindComponentService.BcBEmvzUHSE6Hf3AR79((object) metadata), (IReadOnlyCollection<DataClassDependency>) metadata.DataClassDependencies, searchContext1);
              num2 = 10;
              continue;
            case 29:
              if (this.ComponentMetadataItemManager == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 18 : 22;
                continue;
              }
              parentComponentUid = FindComponentService.YxYSFPBFnmNjPCHUXxcv((object) componentMetadataWrapper);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 27 : 9;
              continue;
            case 30:
              this.loadedComponents[itemUid] = componentMetadataItem1 = this.ComponentMetadataItemManager.Load(itemUid);
              num2 = 12;
              continue;
            default:
              try
              {
label_7:
                if (enumerator2.MoveNext())
                  goto label_10;
                else
                  goto label_8;
label_6:
                Guid current;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_89;
                    case 2:
                      goto label_7;
                    case 3:
                      clientComponentModel1.Owners.Add(current);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 2;
                      continue;
                    default:
                      goto label_10;
                  }
                }
label_8:
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
                goto label_6;
label_10:
                current = enumerator2.Current;
                num7 = 3;
                goto label_6;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                    num8 = 0;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        goto label_16;
                      default:
                        enumerator2.Dispose();
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_16:;
              }
          }
        }
label_28:
        enumerator3 = vertex.ViewItemUidList.GetEnumerator();
        num1 = 21;
        continue;
label_33:
        num1 = 14;
      }
label_34:
      try
      {
label_36:
        if (enumerator1.MoveNext())
          goto label_38;
        else
          goto label_37;
label_35:
        ClientDataClassModel current;
        int num9;
        while (true)
        {
          switch (num9)
          {
            case 1:
              goto label_36;
            case 2:
              goto label_38;
            case 3:
              goto label_55;
            default:
              searchContext1.DataClasses[FindComponentService.KQ588fBFfP6HcAVOGSkp((object) current)] = current;
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
              continue;
          }
        }
label_37:
        num9 = 3;
        goto label_35;
label_38:
        current = enumerator1.Current;
        num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        {
          num9 = 0;
          goto label_35;
        }
        else
          goto label_35;
      }
      finally
      {
        int num10;
        if (enumerator1 == null)
          num10 = 2;
        else
          goto label_44;
label_43:
        switch (num10)
        {
          case 1:
            break;
          default:
        }
label_44:
        FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator1);
        num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        {
          num10 = 0;
          goto label_43;
        }
        else
          goto label_43;
      }
label_48:
      return false;
label_55:
      return true;
label_69:
      return false;
label_77:
      return false;
label_80:
      return false;
label_85:
      return false;
    }

    private bool FindImplModuleComponent(
      Guid parent,
      Guid owner,
      Guid moduleUid,
      Guid parentComponentUid,
      ComponentMetadata componentMetadata,
      ModuleVersion moduleVersion,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        Guid guid;
        IEnumerator<Guid> enumerator1;
        ClientComponentModel clientComponentModel1;
        HashSet<string>.Enumerator enumerator2;
        ComponentGraph.Vertex vertex;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            case 2:
            case 10:
              goto label_19;
            case 3:
              enumerator2 = vertex.ViewItemUidList.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 4 : 9;
              continue;
            case 4:
label_40:
              HashSet<Guid> owners = vertex.Owners;
              Func<Guid, bool> func;
              Func<Guid, bool> func1 = func;
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              Func<Guid, bool> predicate = func1 == null ? (func = (Func<Guid, bool>) (ownerUid => FindComponentService.\u003C\u003Ec__DisplayClass64_0.zHTZ1WQFzUgxuVohGQuA(ownerUid, FindComponentService.\u003C\u003Ec__DisplayClass64_0.LbmDGbQFcZZR0FIC3UIE((object) vertex)))) : func1;
              enumerator1 = owners.Where<Guid>(predicate).GetEnumerator();
              num2 = 7;
              continue;
            case 5:
              goto label_33;
            case 6:
              goto label_21;
            case 7:
              goto label_6;
            case 8:
              guid = FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex);
              num2 = 11;
              continue;
            case 9:
              try
              {
label_25:
                if (enumerator2.MoveNext())
                  goto label_27;
                else
                  goto label_26;
label_23:
                string current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      clientComponentModel1.RenderUidList.Add(current);
                      num3 = 3;
                      continue;
                    case 2:
                      goto label_40;
                    case 3:
                      goto label_25;
                    default:
                      goto label_27;
                  }
                }
label_26:
                num3 = 2;
                goto label_23;
label_27:
                current = enumerator2.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                {
                  num3 = 1;
                  goto label_23;
                }
                else
                  goto label_23;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 11:
              this.FindComponent(guid, guid, vertex.Async ? guid : owner, FindComponentService.cMLTumBFhHIoYiMbgbG3((object) componentMetadata), (IEnumerable<ComponentDependency>) componentMetadata.ComponentDependencies, searchContext);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 13;
              continue;
            case 12:
              if (!searchContext.Components.TryGetValue(guid, out clientComponentModel1))
              {
                num2 = 14;
                continue;
              }
              goto case 3;
            case 13:
              goto label_38;
            case 14:
              Dictionary<Guid, ClientComponentModel> components = searchContext.Components;
              Guid key = guid;
              ClientComponentModel clientComponentModel2 = new ClientComponentModel();
              FindComponentService.n8FEILBFPLdNFpd5yqyN((object) clientComponentModel2, FindComponentService.o91ZZ6BFe7tmdgKxfgXN((object) vertex));
              FindComponentService.M82BL7zJJj9ytsx4xAS((object) clientComponentModel2, guid);
              clientComponentModel2.RenderUidList = vertex.ViewItemUidList;
              clientComponentModel2.Owners = vertex.Owners;
              components[key] = clientComponentModel2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 0;
              continue;
            default:
              vertex = (ComponentGraph.Vertex) FindComponentService.ar2MpGBF2WR9Iqk4CT2u(FindComponentService.cKHlxVzcgw9q1aIwTx5((object) searchContext), FindComponentService.cMLTumBFhHIoYiMbgbG3((object) componentMetadata), FindComponentService.zhf61FzAs08ZdStq71m(FindComponentService.wyDj5JBFOvUp3aNhic5o((object) moduleVersion)), ((ModuleVersionHeader) FindComponentService.wyDj5JBFOvUp3aNhic5o((object) moduleVersion)).HeaderUid, parent, (object) string.Empty, owner, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 8 : 8;
              continue;
          }
        }
label_6:
        try
        {
label_8:
          if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator1))
            goto label_11;
          else
            goto label_9;
label_7:
          Guid current;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_8;
              case 2:
                goto label_19;
              case 3:
                goto label_11;
              default:
                clientComponentModel1.Owners.Add(current);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                continue;
            }
          }
label_9:
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 1;
          goto label_7;
label_11:
          current = enumerator1.Current;
          num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
          {
            num5 = 0;
            goto label_7;
          }
          else
            goto label_7;
        }
        finally
        {
          int num6;
          if (enumerator1 == null)
            num6 = 2;
          else
            goto label_16;
label_15:
          switch (num6)
          {
            case 1:
            case 2:
          }
label_16:
          enumerator1.Dispose();
          num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
          {
            num6 = 0;
            goto label_15;
          }
          else
            goto label_15;
        }
label_19:
        searchContext.ChosenModules.Add(FindComponentService.o91ZZ6BFe7tmdgKxfgXN((object) vertex));
        num1 = 6;
        continue;
label_38:
        if (this.FindModuleImpl(guid, guid, !FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex) ? owner : guid, FindComponentService.cMLTumBFhHIoYiMbgbG3((object) componentMetadata), moduleVersion, searchContext))
          num1 = 12;
        else
          goto label_33;
      }
label_21:
      return true;
label_33:
      return false;
    }

    private (bool result, IEnumerable<ClientFunctionModel> functionModels) GetFunctions(
      string componentName,
      IReadOnlyCollection<FunctionDependency> functionDependencies,
      FindComponentService.SearchContext searchContext,
      bool throwException = false)
    {
      if (functionDependencies.Count == 0)
        return (true, Enumerable.Empty<ClientFunctionModel>());
      (bool result, IEnumerable<ClientFunctionModel> functionModels) = this.GetRuntimeFunctions((IEnumerable<FunctionDependency>) functionDependencies, searchContext);
      if (result)
        return (true, functionModels);
      if (!throwException)
        return (false, Enumerable.Empty<ClientFunctionModel>());
      searchContext.Errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44828541), (object) componentName));
      return (false, Enumerable.Empty<ClientFunctionModel>());
    }

    private (bool result, IEnumerable<ClientFunctionModel> functionModels) GetRuntimeFunctions(
      IEnumerable<FunctionDependency> functionDependencies,
      FindComponentService.SearchContext searchContext)
    {
      Dictionary<Guid, ClientFunctionModel> result = new Dictionary<Guid, ClientFunctionModel>();
      foreach (FunctionDependency functionDependency in functionDependencies)
      {
        if (functionDependency.ModuleUid == Guid.Empty)
        {
          if (!this.GetFunctionFromConfiguration(functionDependency, (IDictionary<Guid, ClientFunctionModel>) result))
            return (false, Enumerable.Empty<ClientFunctionModel>());
        }
        else if (!this.GetFunctionFromModule(functionDependency, searchContext, (IDictionary<Guid, ClientFunctionModel>) result))
          return (false, Enumerable.Empty<ClientFunctionModel>());
      }
      return (true, (IEnumerable<ClientFunctionModel>) result.Values);
    }

    private bool GetFunctionFromConfiguration(
      FunctionDependency dependency,
      IDictionary<Guid, ClientFunctionModel> result)
    {
      if (result.ContainsKey(dependency.HeaderUid))
        return true;
      Guid? nullable = new Guid?();
      foreach (FunctionMetadataItem functionCandidate in this.GetConfigurationFunctionCandidates(dependency))
      {
        if (functionCandidate.Metadata is FunctionMetadata metadata && this.dependencyService.CheckFunctionCompatibility(dependency, metadata.GetSignature()).IsValid)
        {
          nullable = new Guid?(functionCandidate.Uid);
          this.loadedFunctions[functionCandidate.Uid] = functionCandidate;
          break;
        }
      }
      if (!nullable.HasValue)
        return false;
      result[dependency.HeaderUid] = new ClientFunctionModel()
      {
        HeaderUid = dependency.HeaderUid,
        ItemUid = nullable.Value,
        ModuleUid = dependency.ModuleUid
      };
      return true;
    }

    private IEnumerable<FunctionMetadataItem> GetConfigurationFunctionCandidates(
      FunctionDependency dependency)
    {
      return this.FunctionMetadataItemManager?.GetCandidates(dependency.HeaderUid) ?? Enumerable.Empty<FunctionMetadataItem>();
    }

    private bool FillСompatibilityTable(
      ModuleVersion version,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 8;
      // ISSUE: variable of a compiler-generated type
      FindComponentService.\u003C\u003Ec__DisplayClass69_0 cDisplayClass690;
      ModuleInfoMetadata metadata;
      List<LinkToModule>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
            goto label_4;
          case 3:
            enumerator1 = metadata.DependencyModules.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass690.moduleDependencies = metadata.Dependency;
            num1 = 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass690.searchContext = searchContext;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 6:
            goto label_79;
          case 7:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass690.version = version;
            num1 = 5;
            continue;
          case 8:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass690 = new FindComponentService.\u003C\u003Ec__DisplayClass69_0();
            num1 = 7;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass690.searchContext.CandidateModules.ContainsKey(FindComponentService.zhf61FzAs08ZdStq71m(FindComponentService.wyDj5JBFOvUp3aNhic5o((object) cDisplayClass690.version))))
            {
              num1 = 6;
              continue;
            }
            // ISSUE: reference to a compiler-generated field
            metadata = cDisplayClass690.version.Metadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 4 : 1;
            continue;
        }
      }
label_4:
      return true;
label_8:
      bool flag1;
      try
      {
label_17:
        if (enumerator1.MoveNext())
          goto label_60;
        else
          goto label_18;
label_9:
        int num2;
        int num3 = num2;
label_10:
        // ISSUE: variable of a compiler-generated type
        FindComponentService.\u003C\u003Ec__DisplayClass69_1 cDisplayClass691;
        List<FindComponentService.CandidateDependModule> list;
        bool flag2;
        List<FindComponentService.CandidateDependModule>.Enumerator enumerator2;
        LinkToModule current1;
        IEnumerable<ModuleVersionHeader> moduleVersionHeaders;
        IEnumerable<ModuleVersionHeader> source;
        while (true)
        {
          switch (num3)
          {
            case 2:
              goto label_60;
            case 3:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass691 = new FindComponentService.\u003C\u003Ec__DisplayClass69_1();
              num3 = 7;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass691.dependencyModuleUid = FindComponentService.OMUDSfBF1aZmZMxuFVxw((object) current1);
              num3 = 14;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.ModuleVersions[cDisplayClass691.dependencyModuleUid] = moduleVersionHeaders = (IEnumerable<ModuleVersionHeader>) this.moduleMetadataLoader.GetModuleVersionHeaders(cDisplayClass691.dependencyModuleUid);
              num3 = 26;
              continue;
            case 6:
              goto label_4;
            case 7:
              goto label_67;
            case 8:
            case 22:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.CandidateModules.ContainsKey(((ModuleVersionHeader) FindComponentService.wyDj5JBFOvUp3aNhic5o((object) cDisplayClass691.CS\u0024\u003C\u003E8__locals1.version)).VersionUid))
                goto case 19;
              else
                goto label_21;
            case 9:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.IncompatibleModuleItems.Add(FindComponentService.zhf61FzAs08ZdStq71m(FindComponentService.wyDj5JBFOvUp3aNhic5o((object) cDisplayClass691.CS\u0024\u003C\u003E8__locals1.version)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 18 : 21;
              continue;
            case 10:
            case 25:
              flag2 = false;
              num3 = 12;
              continue;
            case 12:
              enumerator2 = list.GetEnumerator();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 18 : 9;
              continue;
            case 13:
            case 29:
              goto label_5;
            case 14:
              // ISSUE: reference to a compiler-generated field
              if (FindComponentService.PjqLdUBFN5nTFGxfWBq3((object) this.moduleMetadataLoader, cDisplayClass691.dependencyModuleUid))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                continue;
              }
              goto case 24;
            case 15:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.IncompatibleModuleItems.Add(((ModuleVersionHeader) FindComponentService.wyDj5JBFOvUp3aNhic5o((object) cDisplayClass691.CS\u0024\u003C\u003E8__locals1.version)).VersionUid);
              num3 = 30;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (!cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.ChosenModules.Contains(cDisplayClass691.dependencyModuleUid))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 17 : 3;
                continue;
              }
              goto label_17;
            case 17:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.ModuleVersions.TryGetValue(cDisplayClass691.dependencyModuleUid, out source))
                goto case 23;
              else
                goto label_66;
            case 18:
              try
              {
label_34:
                if (enumerator2.MoveNext())
                  goto label_33;
                else
                  goto label_35;
label_24:
                FindComponentService.CandidateDependModule current2;
                ModuleVersion version1;
                List<FindComponentService.CandidateDependModule>.Enumerator enumerator3;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 5:
                    case 9:
                      goto label_34;
                    case 2:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (!this.FillСompatibilityTable(version1, cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 3 : 0;
                        continue;
                      }
                      goto case 6;
                    case 3:
                      FindComponentService.MjCaSABFDI60LPKqXDpH((object) current2, false);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
                      continue;
                    case 4:
                      try
                      {
label_40:
                        if (enumerator3.MoveNext())
                          goto label_38;
                        else
                          goto label_41;
label_37:
                        int num5;
                        switch (num5)
                        {
                          case 1:
                            break;
                          case 2:
                            goto label_32;
                          default:
                            goto label_40;
                        }
label_38:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        enumerator3.Current.Owners.Add(FindComponentService.zhf61FzAs08ZdStq71m(FindComponentService.wyDj5JBFOvUp3aNhic5o((object) cDisplayClass691.CS\u0024\u003C\u003E8__locals1.version)));
                        num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                        {
                          num5 = 0;
                          goto label_37;
                        }
                        else
                          goto label_37;
label_41:
                        num5 = 2;
                        goto label_37;
                      }
                      finally
                      {
                        enumerator3.Dispose();
                        int num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                          num6 = 0;
                        switch (num6)
                        {
                          default:
                        }
                      }
                    case 6:
                      flag2 = true;
                      num4 = 5;
                      continue;
                    case 7:
                      if (current2.Valid)
                      {
                        num4 = 10;
                        continue;
                      }
                      goto label_34;
                    case 8:
                      FindComponentService.lCITBgBFaM1sJH8Ic0xa((object) current2, (object) ((ModuleVersionHeader) FindComponentService.wyDj5JBFOvUp3aNhic5o((object) version1)).Version);
                      num4 = 2;
                      continue;
                    case 10:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.CandidateModules.ContainsKey(FindComponentService.TRRkqPBF3DeBYb8ZFdtB((object) current2)))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 12 : 3;
                        continue;
                      }
                      goto case 13;
                    case 11:
                      goto label_62;
                    case 12:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      enumerator3 = cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.CandidateModules[current2.ModuleItemUid].GetEnumerator();
                      num4 = 4;
                      continue;
                    case 13:
                      version1 = (ModuleVersion) FindComponentService.vHy53qzduNL4la1OiPP((object) this.moduleMetadataLoader, FindComponentService.eHcW1YBFpwFvr1R4vjtR((object) current2), FindComponentService.TRRkqPBF3DeBYb8ZFdtB((object) current2));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 8;
                      continue;
                    case 14:
label_32:
                      flag2 = true;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 8 : 9;
                      continue;
                    default:
                      goto label_33;
                  }
                }
label_33:
                current2 = enumerator2.Current;
                num4 = 7;
                goto label_24;
label_35:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 10 : 11;
                goto label_24;
              }
              finally
              {
                enumerator2.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            case 19:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.CandidateModules[FindComponentService.zhf61FzAs08ZdStq71m(FindComponentService.wyDj5JBFOvUp3aNhic5o((object) cDisplayClass691.CS\u0024\u003C\u003E8__locals1.version))].AddRange((IEnumerable<FindComponentService.CandidateDependModule>) list);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 10 : 2;
              continue;
            case 20:
label_62:
              if (!flag2)
                goto case 15;
              else
                goto label_63;
            case 21:
              flag1 = false;
              num3 = 29;
              continue;
            case 23:
              // ISSUE: reference to a compiler-generated method
              list = source.Select<ModuleVersionHeader, FindComponentService.CandidateDependModule>(new Func<ModuleVersionHeader, FindComponentService.CandidateDependModule>(cDisplayClass691.\u003CFillСompatibilityTable\u003Eb__0)).ToList<FindComponentService.CandidateDependModule>();
              num3 = 27;
              continue;
            case 24:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.AllModules.Add(cDisplayClass691.dependencyModuleUid);
              num3 = 16;
              continue;
            case 26:
              goto label_59;
            case 27:
              if (list.Count != 0)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 8 : 6;
                continue;
              }
              goto case 9;
            case 28:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass691.CS\u0024\u003C\u003E8__locals1.searchContext.CandidateModules[((ModuleVersionHeader) FindComponentService.wyDj5JBFOvUp3aNhic5o((object) cDisplayClass691.CS\u0024\u003C\u003E8__locals1.version)).VersionUid] = list;
              num3 = 25;
              continue;
            case 30:
              flag1 = false;
              num3 = 13;
              continue;
            default:
              goto label_17;
          }
        }
label_21:
        num2 = 28;
        goto label_9;
label_59:
        source = moduleVersionHeaders;
        num2 = 23;
        goto label_9;
label_63:
        num2 = 11;
        goto label_9;
label_66:
        num2 = 5;
        goto label_9;
label_67:
        // ISSUE: reference to a compiler-generated field
        cDisplayClass691.CS\u0024\u003C\u003E8__locals1 = cDisplayClass690;
        num2 = 4;
        goto label_9;
label_18:
        num3 = 6;
        goto label_10;
label_60:
        current1 = enumerator1.Current;
        num2 = 3;
        goto label_9;
      }
      finally
      {
        enumerator1.Dispose();
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num8 = 0;
        switch (num8)
        {
          default:
        }
      }
label_5:
      return flag1;
label_79:
      return true;
    }

    private bool FindModule(
      ClientComponentModel[] componentsWithModule,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 6;
      int index1;
      Dictionary<Guid, HashSet<FindComponentService.CandidateDependModule>>.Enumerator enumerator1;
      Dictionary<Guid, ClientComponentModel>.ValueCollection.Enumerator enumerator2;
      bool module;
      while (true)
      {
        ClientComponentModel[] clientComponentModelArray1;
        IEnumerator<Guid> enumerator3;
        HashSet<Guid>.Enumerator enumerator4;
        Dictionary<Guid, HashSet<FindComponentService.CandidateDependModule>> dictionary1;
        IEnumerator<FindComponentService.CandidateDependModule> enumerator5;
        ClientComponentModel clientComponentModel1;
        List<FindComponentService.CandidateDependModule> candidateDependModuleList1;
        Dictionary<Guid, List<FindComponentService.CandidateDependModule>> dictionary2;
        switch (num1)
        {
          case 1:
            goto label_280;
          case 2:
          case 7:
label_194:
            ++index1;
            num1 = 3;
            continue;
          case 3:
          case 9:
            if (index1 < clientComponentModelArray1.Length)
            {
              num1 = 14;
              continue;
            }
            goto case 10;
          case 4:
            List<FindComponentService.CandidateDependModule> source1 = candidateDependModuleList1;
            // ISSUE: reference to a compiler-generated field
            Func<FindComponentService.CandidateDependModule, bool> func = FindComponentService.\u003C\u003Ec.\u003C\u003E9__70_0;
            Func<FindComponentService.CandidateDependModule, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              FindComponentService.\u003C\u003Ec.\u003C\u003E9__70_0 = predicate = (Func<FindComponentService.CandidateDependModule, bool>) (a => a.Valid);
            }
            else
              goto label_343;
label_342:
            // ISSUE: reference to a compiler-generated method
            IOrderedEnumerable<FindComponentService.CandidateDependModule> orderedEnumerable = source1.Where<FindComponentService.CandidateDependModule>(predicate).OrderByDescending<FindComponentService.CandidateDependModule, Version>((Func<FindComponentService.CandidateDependModule, Version>) (a => (Version) FindComponentService.\u003C\u003Ec.TYYBGhfcMq6plEXGrfOE((object) a)));
            dictionary2 = new Dictionary<Guid, List<FindComponentService.CandidateDependModule>>();
            enumerator5 = orderedEnumerable.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 12 : 12;
            continue;
label_343:
            predicate = func;
            goto label_342;
          case 5:
            index1 = 0;
            num1 = 9;
            continue;
          case 6:
            clientComponentModelArray1 = componentsWithModule;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 4 : 5;
            continue;
          case 8:
            try
            {
label_205:
              if (enumerator4.MoveNext())
                goto label_250;
              else
                goto label_206;
label_198:
              Guid current;
              int num2;
              while (true)
              {
                int num3;
                ClientComponentModel[] clientComponentModelArray2;
                int index2;
                ClientComponentModel clientComponentModel2;
                FindComponentService.CandidateDependModule candidateDependModule1;
                ClientComponentModel[] array;
                FindComponentService.CandidateDependModule candidateDependModule2;
                List<FindComponentService.CandidateDependModule> candidateDependModuleList2;
                List<FindComponentService.CandidateDependModule> candidateDependModuleList3;
                FindComponentService.CandidateDependModule candidateDependModule3;
                List<FindComponentService.CandidateDependModule> candidateDependModuleList4;
                List<FindComponentService.CandidateDependModule>.Enumerator enumerator6;
                switch (num2)
                {
                  case 1:
                    try
                    {
label_236:
                      if (enumerator6.MoveNext())
                        goto label_230;
                      else
                        goto label_237;
label_223:
                      int num4;
                      int num5 = num4;
label_224:
                      FindComponentService.CandidateDependModule candidateDependModule4;
                      FindComponentService.CandidateDependModule candidate;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            candidateDependModule4 = candidateDependModuleList2.Find((Predicate<FindComponentService.CandidateDependModule>) (a => FindComponentService.\u003C\u003Ec__DisplayClass70_0.r26vjJQBXCyOZZp2LvOy(FindComponentService.\u003C\u003Ec__DisplayClass70_0.Wovn9AQBKlG2juHeUKq3((object) a), candidate.ModuleItemUid)));
                            num5 = 14;
                            continue;
                          case 2:
                            if (candidateDependModuleList3 == null)
                              goto case 7;
                            else
                              goto label_228;
                          case 3:
                            candidate = enumerator6.Current;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                            continue;
                          case 4:
                            if (candidateDependModuleList3 != null)
                            {
                              num5 = 13;
                              continue;
                            }
                            goto case 9;
                          case 5:
                          case 11:
                          case 12:
                            goto label_236;
                          case 6:
                          case 13:
                            candidateDependModuleList3.Add(candidateDependModule4);
                            num5 = 11;
                            continue;
                          case 7:
                            if (candidateDependModule4.Valid)
                            {
                              num5 = 4;
                              continue;
                            }
                            goto label_236;
                          case 8:
                            if (candidateDependModuleList3.Contains(candidateDependModule4))
                            {
                              num5 = 12;
                              continue;
                            }
                            goto case 7;
                          case 9:
                            candidateDependModuleList3 = new List<FindComponentService.CandidateDependModule>();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 4 : 6;
                            continue;
                          case 10:
                            goto label_219;
                          case 14:
                            if (candidateDependModule4 == null)
                            {
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 5;
                              continue;
                            }
                            goto case 2;
                          default:
                            goto label_230;
                        }
                      }
label_228:
                      num4 = 8;
                      goto label_223;
label_230:
                      num5 = 2;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
                      {
                        num5 = 3;
                        goto label_224;
                      }
                      else
                        goto label_224;
label_237:
                      num4 = 10;
                      goto label_223;
                    }
                    finally
                    {
                      enumerator6.Dispose();
                      int num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                        num6 = 0;
                      switch (num6)
                      {
                        default:
                      }
                    }
                  case 2:
                    Dictionary<Guid, ClientComponentModel> componentModules1 = searchContext.ChosenComponentModules;
                    Guid key1 = current;
                    ClientComponentModel clientComponentModel3 = new ClientComponentModel();
                    FindComponentService.n8FEILBFPLdNFpd5yqyN((object) clientComponentModel3, candidateDependModule3.HeaderUid);
                    FindComponentService.M82BL7zJJj9ytsx4xAS((object) clientComponentModel3, candidateDependModule3.ModuleItemUid);
                    clientComponentModel3.Owners = candidateDependModule3.Owners;
                    componentModules1[key1] = clientComponentModel3;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 9 : 1;
                    continue;
                  case 3:
                    candidateDependModuleList3 = (List<FindComponentService.CandidateDependModule>) null;
                    num3 = 29;
                    break;
                  case 5:
                    if (!searchContext.ChosenComponentModules.ContainsKey(current))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 6 : 3;
                      continue;
                    }
                    goto label_205;
                  case 6:
                    if (!searchContext.ChosenModules.Contains(current))
                    {
                      num2 = 25;
                      continue;
                    }
                    goto label_205;
                  case 7:
                    if (FindComponentService.dEdIiqBFtxAsy0SKVqNc((object) candidateDependModuleList3) != 0)
                    {
                      num2 = 17;
                      continue;
                    }
                    goto case 15;
                  case 8:
                  case 9:
                  case 12:
                  case 19:
                    goto label_205;
                  case 10:
                    if (array.Length == 0)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 24 : 0;
                      continue;
                    }
                    goto case 3;
                  case 11:
                    goto label_250;
                  case 13:
                  case 31:
                    if (index2 < clientComponentModelArray2.Length)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 27;
                  case 14:
                    index2 = 0;
                    num2 = 31;
                    continue;
                  case 15:
                    module = false;
                    num2 = 20;
                    continue;
                  case 16:
                    candidateDependModule2 = candidateDependModuleList2[0];
                    num2 = 30;
                    continue;
                  case 17:
                  case 28:
                    candidateDependModule3 = candidateDependModuleList3[0];
                    num2 = 2;
                    continue;
                  case 18:
                    if (!searchContext.CandidateModules.TryGetValue(FindComponentService.MeY255BFZT4ltNIPAYVj((object) clientComponentModel2), out candidateDependModuleList4))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 22;
                      continue;
                    }
                    goto case 21;
                  case 20:
                    goto label_263;
                  case 21:
                    enumerator6 = candidateDependModuleList4.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
                    continue;
                  case 22:
                  case 26:
label_219:
                    ++index2;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 13 : 5;
                    continue;
                  case 23:
                    array = ((IEnumerable<ClientComponentModel>) componentsWithModule).Except<ClientComponentModel>((IEnumerable<ClientComponentModel>) new ClientComponentModel[1]
                    {
                      clientComponentModel1
                    }).ToArray<ClientComponentModel>();
                    num2 = 10;
                    continue;
                  case 24:
                    candidateDependModule1 = candidateDependModuleList2[0];
                    num3 = 32;
                    break;
                  case 25:
                    if (!dictionary2.TryGetValue(current, out candidateDependModuleList2))
                    {
                      num3 = 12;
                      break;
                    }
                    goto case 23;
                  case 27:
                    if (candidateDependModuleList3 != null)
                    {
                      num2 = 7;
                      continue;
                    }
                    goto case 16;
                  case 29:
                    clientComponentModelArray2 = array;
                    num2 = 14;
                    continue;
                  case 30:
                    Dictionary<Guid, ClientComponentModel> componentModules2 = searchContext.ChosenComponentModules;
                    Guid key2 = current;
                    ClientComponentModel clientComponentModel4 = new ClientComponentModel();
                    FindComponentService.n8FEILBFPLdNFpd5yqyN((object) clientComponentModel4, candidateDependModule2.HeaderUid);
                    FindComponentService.M82BL7zJJj9ytsx4xAS((object) clientComponentModel4, FindComponentService.TRRkqPBF3DeBYb8ZFdtB((object) candidateDependModule2));
                    clientComponentModel4.Owners = candidateDependModule2.Owners;
                    componentModules2[key2] = clientComponentModel4;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 19 : 14;
                    continue;
                  case 32:
                    Dictionary<Guid, ClientComponentModel> componentModules3 = searchContext.ChosenComponentModules;
                    Guid key3 = current;
                    ClientComponentModel clientComponentModel5 = new ClientComponentModel();
                    FindComponentService.n8FEILBFPLdNFpd5yqyN((object) clientComponentModel5, FindComponentService.eHcW1YBFpwFvr1R4vjtR((object) candidateDependModule1));
                    FindComponentService.M82BL7zJJj9ytsx4xAS((object) clientComponentModel5, FindComponentService.TRRkqPBF3DeBYb8ZFdtB((object) candidateDependModule1));
                    clientComponentModel5.Owners = candidateDependModule1.Owners;
                    componentModules3[key3] = clientComponentModel5;
                    num2 = 8;
                    continue;
                  case 33:
                    goto label_194;
                  default:
                    clientComponentModel2 = clientComponentModelArray2[index2];
                    num2 = 18;
                    continue;
                }
                num2 = num3;
              }
label_206:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 18 : 33;
              goto label_198;
label_250:
              current = enumerator4.Current;
              num2 = 5;
              goto label_198;
            }
            finally
            {
              enumerator4.Dispose();
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                num7 = 0;
              switch (num7)
              {
                default:
              }
            }
          case 10:
            dictionary1 = new Dictionary<Guid, HashSet<FindComponentService.CandidateDependModule>>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 18 : 12;
            continue;
          case 11:
            try
            {
label_97:
              if (enumerator3.MoveNext())
                goto label_93;
              else
                goto label_98;
label_6:
              HashSet<FindComponentService.CandidateDependModule> candidateDependModuleSet1;
              int num8;
              while (true)
              {
                Dictionary<Guid, HashSet<FindComponentService.CandidateDependModule>> dictionary3;
                IEnumerable<ModuleVersionHeader> moduleVersionHeaders1;
                IEnumerable<ModuleVersionHeader> moduleVersionHeaders2;
                HashSet<FindComponentService.CandidateDependModule> source2;
                IEnumerator<ModuleVersionHeader> enumerator7;
                HashSet<Guid> guidSet;
                HashSet<FindComponentService.CandidateDependModule> candidateDependModuleSet2;
                Guid remainingModule;
                switch (num8)
                {
                  case 1:
                    goto label_145;
                  case 2:
                    try
                    {
label_159:
                      if (enumerator2.MoveNext())
                        goto label_161;
                      else
                        goto label_160;
label_158:
                      ClientComponentModel current1;
                      List<FindComponentService.CandidateDependModule> source3;
                      int num9;
                      while (true)
                      {
                        switch (num9)
                        {
                          case 1:
                            goto label_164;
                          case 2:
                            // ISSUE: reference to a compiler-generated method
                            enumerator5 = source3.Where<FindComponentService.CandidateDependModule>((Func<FindComponentService.CandidateDependModule, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass70_1.yrlfrwQB2grS4KVkf6MH(a.HeaderUid, remainingModule))).GetEnumerator();
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 1;
                            continue;
                          case 3:
                            if (searchContext.CandidateModules.TryGetValue(FindComponentService.MeY255BFZT4ltNIPAYVj((object) current1), out source3))
                            {
                              num9 = 2;
                              continue;
                            }
                            goto label_159;
                          case 4:
                            goto label_13;
                          case 5:
                            goto label_159;
                          default:
                            goto label_161;
                        }
                      }
label_164:
                      try
                      {
label_168:
                        if (enumerator5.MoveNext())
                          goto label_166;
                        else
                          goto label_169;
label_165:
                        FindComponentService.CandidateDependModule current2;
                        int num10;
                        while (true)
                        {
                          switch (num10)
                          {
                            case 1:
                              goto label_168;
                            case 2:
                              candidateDependModuleSet1.Add(current2);
                              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
                              continue;
                            case 3:
                              goto label_166;
                            default:
                              goto label_159;
                          }
                        }
label_166:
                        current2 = enumerator5.Current;
                        num10 = 2;
                        goto label_165;
label_169:
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
                        goto label_165;
                      }
                      finally
                      {
                        int num11;
                        if (enumerator5 == null)
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                        else
                          goto label_173;
label_172:
                        switch (num11)
                        {
                          case 1:
                          case 2:
                        }
label_173:
                        FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator5);
                        num11 = 2;
                        goto label_172;
                      }
label_160:
                      num9 = 4;
                      goto label_158;
label_161:
                      current1 = enumerator2.Current;
                      num9 = 3;
                      goto label_158;
                    }
                    finally
                    {
                      enumerator2.Dispose();
                      int num12 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
                        num12 = 0;
                      switch (num12)
                      {
                        default:
                      }
                    }
                  case 3:
label_99:
                    source2 = new HashSet<FindComponentService.CandidateDependModule>();
                    num8 = 18;
                    continue;
                  case 4:
                    goto label_339;
                  case 5:
                    try
                    {
label_111:
                      if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator7))
                        goto label_104;
                      else
                        goto label_112;
label_102:
                      Dictionary<Guid, ClientComponentModel>.ValueCollection values;
                      ModuleVersionHeader current3;
                      HashSet<FindComponentService.CandidateDependModule> candidateDependModuleSet3;
                      int num13;
                      while (true)
                      {
                        switch (num13)
                        {
                          case 1:
                            goto label_104;
                          case 2:
                            candidateDependModuleSet3 = candidateDependModuleSet2;
                            num13 = 4;
                            continue;
                          case 3:
                            if (FindComponentService.bxgLweBF4alAQMvkIPkO((object) values) > 0)
                            {
                              num13 = 10;
                              continue;
                            }
                            goto case 5;
                          case 4:
                            HashSet<FindComponentService.CandidateDependModule> candidateDependModuleSet4 = candidateDependModuleSet3;
                            FindComponentService.CandidateDependModule candidateDependModule5 = new FindComponentService.CandidateDependModule();
                            FindComponentService.YLGZ44BFxB4FuA8IiUUQ((object) candidateDependModule5, FindComponentService.g6LHQuBF76gEdOIm0C5X((object) current3));
                            FindComponentService.RMP0R2BF0y2Fdpy2KsiU((object) candidateDependModule5, FindComponentService.zhf61FzAs08ZdStq71m((object) current3));
                            FindComponentService.lCITBgBFaM1sJH8Ic0xa((object) candidateDependModule5, FindComponentService.LXTnMLBFmiUQfSubUX0W((object) current3));
                            FindComponentService.MjCaSABFDI60LPKqXDpH((object) candidateDependModule5, true);
                            candidateDependModuleSet4.Add(candidateDependModule5);
                            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                            continue;
                          case 5:
                            if (!dictionary3.TryGetValue(Guid.Empty, out candidateDependModuleSet3))
                            {
                              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 7 : 4;
                              continue;
                            }
                            goto case 4;
                          case 6:
                            values = searchContext.ChosenComponentModules.Values;
                            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 3 : 0;
                            continue;
                          case 7:
                            dictionary3[Guid.Empty] = candidateDependModuleSet2 = new HashSet<FindComponentService.CandidateDependModule>();
                            num13 = 2;
                            continue;
                          case 8:
                            goto label_114;
                          case 9:
                            goto label_91;
                          case 10:
                            enumerator2 = values.GetEnumerator();
                            num13 = 8;
                            continue;
                          default:
                            goto label_111;
                        }
                      }
label_114:
                      try
                      {
label_117:
                        if (enumerator2.MoveNext())
                          goto label_125;
                        else
                          goto label_118;
label_115:
                        ClientComponentModel current4;
                        int num14;
                        while (true)
                        {
                          ModuleVersion moduleVersion;
                          HashSet<FindComponentService.CandidateDependModule> candidateDependModuleSet5;
                          Guid key;
                          int num15;
                          switch (num14)
                          {
                            case 1:
                            case 6:
                              goto label_117;
                            case 2:
                              moduleVersion = (ModuleVersion) FindComponentService.vHy53qzduNL4la1OiPP((object) this.moduleMetadataLoader, FindComponentService.MJd4j0BFSxyqrmO88VXq((object) current4), FindComponentService.MeY255BFZT4ltNIPAYVj((object) current4));
                              num14 = 4;
                              continue;
                            case 3:
                              goto label_125;
                            case 4:
                              if (dictionary3.TryGetValue(key, out candidateDependModuleSet5))
                              {
                                num14 = 5;
                                continue;
                              }
                              goto case 14;
                            case 5:
                            case 9:
                              if (!FindComponentService.zxK5JxBF6vqpPYmhsZoS(FindComponentService.lTCXFgzmDwbANeh2YWG((object) searchContext)))
                              {
                                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                                continue;
                              }
                              goto case 11;
                            case 7:
                              goto label_111;
                            case 8:
                              candidateDependModuleSet5 = candidateDependModuleSet2;
                              num14 = 9;
                              continue;
                            case 10:
label_116:
                              guidSet.Add(FindComponentService.zhf61FzAs08ZdStq71m((object) current3));
                              num14 = 6;
                              continue;
                            case 11:
                              num15 = FindComponentService.biNyKKBFAH2ZLqXDRfMf((object) CheckModuleHelper.CheckSignatures((ModuleDependency) FindComponentService.uJ6ZVgBFHGWZftlNPcOQ(FindComponentService.iMlyy1ztkAWCr8rEdWj((object) moduleVersion)), (ModuleSignature) FindComponentService.Myq9P5BFkln6ljxvfiBh((object) current3), remainingModule)) ? 1 : 0;
                              break;
                            case 12:
                              key = FindComponentService.MeY255BFZT4ltNIPAYVj((object) current4);
                              num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 2;
                              continue;
                            case 13:
                              HashSet<FindComponentService.CandidateDependModule> candidateDependModuleSet6 = candidateDependModuleSet5;
                              FindComponentService.CandidateDependModule candidateDependModule6 = new FindComponentService.CandidateDependModule();
                              FindComponentService.YLGZ44BFxB4FuA8IiUUQ((object) candidateDependModule6, FindComponentService.g6LHQuBF76gEdOIm0C5X((object) current3));
                              candidateDependModule6.ModuleItemUid = FindComponentService.zhf61FzAs08ZdStq71m((object) current3);
                              candidateDependModule6.Version = current3.Version;
                              FindComponentService.MjCaSABFDI60LPKqXDpH((object) candidateDependModule6, true);
                              candidateDependModuleSet6.Add(candidateDependModule6);
                              num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
                              continue;
                            case 14:
                              dictionary3[key] = candidateDependModuleSet2 = new HashSet<FindComponentService.CandidateDependModule>();
                              num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 8;
                              continue;
                            default:
                              num15 = 1;
                              break;
                          }
                          if (num15 != 0)
                            num14 = 13;
                          else
                            goto label_116;
                        }
label_118:
                        num14 = 7;
                        goto label_115;
label_125:
                        current4 = enumerator2.Current;
                        num14 = 12;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                        {
                          num14 = 5;
                          goto label_115;
                        }
                        else
                          goto label_115;
                      }
                      finally
                      {
                        enumerator2.Dispose();
                        int num16 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
                          num16 = 0;
                        switch (num16)
                        {
                          default:
                        }
                      }
label_104:
                      current3 = enumerator7.Current;
                      num13 = 6;
                      goto label_102;
label_112:
                      num13 = 9;
                      goto label_102;
                    }
                    finally
                    {
                      if (enumerator7 != null)
                      {
                        int num17 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                          num17 = 1;
                        while (true)
                        {
                          switch (num17)
                          {
                            case 1:
                              enumerator7.Dispose();
                              num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_144;
                          }
                        }
                      }
label_144:;
                    }
                  case 6:
                  case 26:
                    goto label_97;
                  case 7:
                  case 9:
                    enumerator2 = searchContext.ChosenComponentModules.Values.GetEnumerator();
                    num8 = 2;
                    continue;
                  case 8:
                  case 15:
                    dictionary3 = new Dictionary<Guid, HashSet<FindComponentService.CandidateDependModule>>();
                    num8 = 10;
                    continue;
                  case 10:
                    guidSet = new HashSet<Guid>();
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 21 : 14;
                    continue;
                  case 11:
                    if (!searchContext.ChosenComponentModules.ContainsKey(remainingModule))
                    {
                      num8 = 28;
                      continue;
                    }
                    goto label_97;
                  case 12:
                    moduleVersionHeaders2 = moduleVersionHeaders1;
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 15 : 14;
                    continue;
                  case 13:
                    if (searchContext.ModuleVersions.TryGetValue(remainingModule, out moduleVersionHeaders2))
                    {
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 8 : 0;
                      continue;
                    }
                    goto case 27;
                  case 14:
                    dictionary1[remainingModule] = candidateDependModuleSet2 = new HashSet<FindComponentService.CandidateDependModule>();
                    num8 = 23;
                    continue;
                  case 16:
label_13:
                    if (FindComponentService.ctifHNBFwwoa6iudFPtk((object) candidateDependModuleSet1) != 0)
                    {
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 3 : 6;
                      continue;
                    }
                    goto case 13;
                  case 17:
                    try
                    {
label_85:
                      if (enumerator4.MoveNext())
                        goto label_83;
                      else
                        goto label_86;
label_67:
                      int num18;
                      Guid itemToRemove;
                      while (true)
                      {
                        switch (num18)
                        {
                          case 1:
                            goto label_83;
                          case 2:
                            goto label_99;
                          case 3:
                            goto label_69;
                          case 4:
                            enumerator1 = dictionary3.GetEnumerator();
                            num18 = 3;
                            continue;
                          case 5:
                            itemToRemove = enumerator4.Current;
                            num18 = 4;
                            continue;
                          default:
                            goto label_85;
                        }
                      }
label_69:
                      try
                      {
label_71:
                        if (enumerator1.MoveNext())
                          goto label_76;
                        else
                          goto label_72;
label_70:
                        FindComponentService.CandidateDependModule candidateDependModule;
                        KeyValuePair<Guid, HashSet<FindComponentService.CandidateDependModule>> current;
                        int num19;
                        while (true)
                        {
                          switch (num19)
                          {
                            case 1:
                              goto label_85;
                            case 2:
                              goto label_76;
                            case 3:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              candidateDependModule = current.Value.FirstOrDefault<FindComponentService.CandidateDependModule>((Func<FindComponentService.CandidateDependModule, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass70_2.JETshdQBp7jutswiDKBx(FindComponentService.\u003C\u003Ec__DisplayClass70_2.ijKF1hQB3AZVTxYB2dnp((object) a), itemToRemove)));
                              num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                              continue;
                            case 4:
                              goto label_71;
                            case 5:
                              current.Value.Remove(candidateDependModule);
                              num19 = 4;
                              continue;
                            default:
                              if (candidateDependModule != null)
                              {
                                num19 = 5;
                                continue;
                              }
                              goto label_71;
                          }
                        }
label_72:
                        num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
                        goto label_70;
label_76:
                        current = enumerator1.Current;
                        num19 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                        {
                          num19 = 3;
                          goto label_70;
                        }
                        else
                          goto label_70;
                      }
                      finally
                      {
                        enumerator1.Dispose();
                        int num20 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                          num20 = 0;
                        switch (num20)
                        {
                          default:
                        }
                      }
label_83:
                      num18 = 5;
                      goto label_67;
label_86:
                      num18 = 2;
                      goto label_67;
                    }
                    finally
                    {
                      enumerator4.Dispose();
                      int num21 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                        num21 = 0;
                      switch (num21)
                      {
                        default:
                      }
                    }
                  case 18:
                    enumerator1 = dictionary3.GetEnumerator();
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 25 : 13;
                    continue;
                  case 19:
label_91:
                    enumerator4 = guidSet.GetEnumerator();
                    num8 = 17;
                    continue;
                  case 20:
                    if (dictionary1.TryGetValue(remainingModule, out candidateDependModuleSet1))
                    {
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 7 : 5;
                      continue;
                    }
                    goto case 14;
                  case 21:
                    enumerator7 = moduleVersionHeaders2.GetEnumerator();
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 5;
                    continue;
                  case 22:
                    goto label_93;
                  case 23:
                    candidateDependModuleSet1 = candidateDependModuleSet2;
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 9 : 0;
                    continue;
                  case 24:
                    remainingModule = enumerator3.Current;
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 6 : 11;
                    continue;
                  case 25:
                    try
                    {
label_19:
                      if (enumerator1.MoveNext())
                        goto label_55;
                      else
                        goto label_20;
label_18:
                      HashSet<FindComponentService.CandidateDependModule> candidateDependModuleSet7;
                      HashSet<FindComponentService.CandidateDependModule>.Enumerator enumerator8;
                      KeyValuePair<Guid, HashSet<FindComponentService.CandidateDependModule>> current5;
                      HashSet<FindComponentService.CandidateDependModule>[] array;
                      int num22;
                      while (true)
                      {
                        switch (num22)
                        {
                          case 1:
                            goto label_35;
                          case 2:
                            goto label_22;
                          case 3:
                            if (array.Length == 0)
                            {
                              num22 = 10;
                              continue;
                            }
                            goto case 7;
                          case 4:
                            goto label_19;
                          case 5:
                            goto label_183;
                          case 6:
                          case 10:
                            enumerator8 = candidateDependModuleSet7.GetEnumerator();
                            num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 2;
                            continue;
                          case 7:
                            enumerator8 = candidateDependModuleSet7.GetEnumerator();
                            num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                            continue;
                          case 8:
                            goto label_55;
                          case 9:
                            candidateDependModuleSet7 = current5.Value;
                            num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                            continue;
                          default:
                            array = dictionary3.Values.Except<HashSet<FindComponentService.CandidateDependModule>>((IEnumerable<HashSet<FindComponentService.CandidateDependModule>>) new HashSet<FindComponentService.CandidateDependModule>[1]
                            {
                              candidateDependModuleSet7
                            }).ToArray<HashSet<FindComponentService.CandidateDependModule>>();
                            num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 3;
                            continue;
                        }
                      }
label_22:
                      try
                      {
label_25:
                        if (enumerator8.MoveNext())
                          goto label_27;
                        else
                          goto label_26;
label_23:
                        FindComponentService.CandidateDependModule current6;
                        int num23;
                        while (true)
                        {
                          switch (num23)
                          {
                            case 1:
                              goto label_25;
                            case 2:
                              source2.Add(current6);
                              num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
                              continue;
                            case 3:
                              goto label_19;
                            default:
                              goto label_27;
                          }
                        }
label_26:
                        num23 = 3;
                        goto label_23;
label_27:
                        current6 = enumerator8.Current;
                        num23 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                        {
                          num23 = 2;
                          goto label_23;
                        }
                        else
                          goto label_23;
                      }
                      finally
                      {
                        enumerator8.Dispose();
                        int num24 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                          num24 = 0;
                        switch (num24)
                        {
                          default:
                        }
                      }
label_35:
                      try
                      {
label_39:
                        if (enumerator8.MoveNext())
                          goto label_42;
                        else
                          goto label_40;
label_36:
                        int num25;
                        int num26 = num25;
label_37:
                        HashSet<FindComponentService.CandidateDependModule>[] candidateDependModuleSetArray;
                        FindComponentService.CandidateDependModule candidateDependModule;
                        FindComponentService.CandidateDependModule dependModule;
                        while (true)
                        {
                          switch (num26)
                          {
                            case 1:
                              source2.Add(candidateDependModule);
                              num26 = 6;
                              continue;
                            case 2:
                              dependModule = enumerator8.Current;
                              num26 = 8;
                              continue;
                            case 3:
                              goto label_19;
                            case 4:
                              if (candidateDependModule != null)
                              {
                                num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
                                continue;
                              }
                              goto case 6;
                            case 6:
                              ++index1;
                              num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                              continue;
                            case 7:
                              goto label_39;
                            case 8:
                              candidateDependModuleSetArray = array;
                              num26 = 10;
                              continue;
                            case 9:
                              goto label_42;
                            case 10:
                              index1 = 0;
                              num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 5 : 5;
                              continue;
                            case 11:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              candidateDependModule = candidateDependModuleSetArray[index1].FirstOrDefault<FindComponentService.CandidateDependModule>((Func<FindComponentService.CandidateDependModule, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass70_3.clR38nQB47KPal2sh6sn((object) a) == FindComponentService.\u003C\u003Ec__DisplayClass70_3.clR38nQB47KPal2sh6sn((object) dependModule)));
                              num26 = 4;
                              continue;
                            default:
                              if (index1 < candidateDependModuleSetArray.Length)
                                goto case 11;
                              else
                                goto label_44;
                          }
                        }
label_44:
                        num25 = 7;
                        goto label_36;
label_40:
                        num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 3 : 1;
                        goto label_37;
label_42:
                        num25 = 2;
                        goto label_36;
                      }
                      finally
                      {
                        enumerator8.Dispose();
                        int num27 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                          num27 = 0;
                        switch (num27)
                        {
                          default:
                        }
                      }
label_20:
                      num22 = 5;
                      goto label_18;
label_55:
                      current5 = enumerator1.Current;
                      num22 = 3;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
                      {
                        num22 = 9;
                        goto label_18;
                      }
                      else
                        goto label_18;
                    }
                    finally
                    {
                      enumerator1.Dispose();
                      int num28 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
                        num28 = 0;
                      switch (num28)
                      {
                        default:
                      }
                    }
                  case 27:
                    searchContext.ModuleVersions[remainingModule] = moduleVersionHeaders1 = (IEnumerable<ModuleVersionHeader>) this.moduleMetadataLoader.GetModuleVersionHeaders(remainingModule);
                    num8 = 12;
                    continue;
                  case 28:
                    if (!searchContext.ChosenModules.Contains(remainingModule))
                    {
                      num8 = 20;
                      continue;
                    }
                    goto label_97;
                }
label_183:
                // ISSUE: reference to a compiler-generated method
                enumerator5 = source2.OrderByDescending<FindComponentService.CandidateDependModule, Version>((Func<FindComponentService.CandidateDependModule, Version>) (a => (Version) FindComponentService.\u003C\u003Ec.TYYBGhfcMq6plEXGrfOE((object) a))).GetEnumerator();
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
              }
label_145:
              try
              {
label_148:
                if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator5))
                  goto label_147;
                else
                  goto label_149;
label_146:
                FindComponentService.CandidateDependModule current;
                int num29;
                while (true)
                {
                  switch (num29)
                  {
                    case 1:
                      goto label_148;
                    case 2:
                      goto label_97;
                    case 3:
                      candidateDependModuleSet1.Add(current);
                      num29 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_147;
                  }
                }
label_147:
                current = enumerator5.Current;
                num29 = 3;
                goto label_146;
label_149:
                num29 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 2;
                goto label_146;
              }
              finally
              {
                if (enumerator5 != null)
                {
                  int num30 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                    num30 = 0;
                  while (true)
                  {
                    switch (num30)
                    {
                      case 1:
                        goto label_156;
                      default:
                        enumerator5.Dispose();
                        num30 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_156:;
              }
label_93:
              num8 = 24;
              goto label_6;
label_98:
              num8 = 4;
              goto label_6;
            }
            finally
            {
              if (enumerator3 != null)
              {
                int num31 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                  num31 = 1;
                while (true)
                {
                  switch (num31)
                  {
                    case 1:
                      enumerator3.Dispose();
                      num31 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_189;
                  }
                }
              }
label_189:;
            }
          case 12:
            try
            {
label_270:
              if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator5))
                goto label_272;
              else
                goto label_271;
label_265:
              FindComponentService.CandidateDependModule current;
              List<FindComponentService.CandidateDependModule> candidateDependModuleList5;
              int num32;
              while (true)
              {
                switch (num32)
                {
                  case 1:
                    candidateDependModuleList5 = new List<FindComponentService.CandidateDependModule>();
                    num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 1;
                    continue;
                  case 2:
                    dictionary2[FindComponentService.eHcW1YBFpwFvr1R4vjtR((object) current)] = candidateDependModuleList5;
                    num32 = 6;
                    continue;
                  case 3:
                    goto label_270;
                  case 4:
                    if (!dictionary2.TryGetValue(FindComponentService.eHcW1YBFpwFvr1R4vjtR((object) current), out candidateDependModuleList5))
                    {
                      num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
                      continue;
                    }
                    goto case 6;
                  case 5:
                    goto label_272;
                  case 6:
                    candidateDependModuleList5.Add(current);
                    num32 = 3;
                    continue;
                  default:
                    goto label_195;
                }
              }
label_271:
              num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              goto label_265;
label_272:
              current = enumerator5.Current;
              num32 = 4;
              goto label_265;
            }
            finally
            {
              if (enumerator5 != null)
              {
                int num33 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                  num33 = 0;
                while (true)
                {
                  switch (num33)
                  {
                    case 1:
                      goto label_279;
                    default:
                      enumerator5.Dispose();
                      num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_279:;
            }
          case 13:
            goto label_262;
          case 14:
          case 15:
            clientComponentModel1 = clientComponentModelArray1[index1];
            num1 = 17;
            continue;
          case 16:
label_339:
            enumerator1 = dictionary1.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
            continue;
          case 17:
            if (!searchContext.CandidateModules.TryGetValue(clientComponentModel1.ModuleItemUid, out candidateDependModuleList1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 2;
              continue;
            }
            goto case 4;
          case 18:
            enumerator3 = searchContext.AllModules.Except<Guid>((IEnumerable<Guid>) searchContext.ChosenComponentModules.Keys).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 11 : 11;
            continue;
        }
label_195:
        enumerator4 = searchContext.AllModules.GetEnumerator();
        num1 = 8;
      }
label_262:
      return true;
label_263:
      return module;
label_280:
      try
      {
label_287:
        if (enumerator1.MoveNext())
          goto label_314;
        else
          goto label_288;
label_281:
        FindComponentService.CandidateDependModule[] array;
        FindComponentService.CandidateDependModule candidateDependModule7;
        List<FindComponentService.CandidateDependModule> candidateDependModuleList6;
        KeyValuePair<Guid, HashSet<FindComponentService.CandidateDependModule>> current7;
        FindComponentService.CandidateDependModule candidateDependModule8;
        FindComponentService.CandidateDependModule[] candidateDependModuleArray;
        int num34;
        FindComponentService.CandidateDependModule componentVersion;
        while (true)
        {
          switch (num34)
          {
            case 1:
            case 24:
              goto label_263;
            case 2:
            case 21:
              if (array.Length != 0)
              {
                num34 = 12;
                continue;
              }
              goto case 8;
            case 3:
              HashSet<FindComponentService.CandidateDependModule> source = current7.Value;
              // ISSUE: reference to a compiler-generated field
              Func<FindComponentService.CandidateDependModule, Version> func = FindComponentService.\u003C\u003Ec.\u003C\u003E9__70_7;
              Func<FindComponentService.CandidateDependModule, Version> keySelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                FindComponentService.\u003C\u003Ec.\u003C\u003E9__70_7 = keySelector = (Func<FindComponentService.CandidateDependModule, Version>) (a => (Version) FindComponentService.\u003C\u003Ec.TYYBGhfcMq6plEXGrfOE((object) a));
              }
              else
                goto label_319;
label_333:
              array = source.OrderByDescending<FindComponentService.CandidateDependModule, Version>(keySelector).ToArray<FindComponentService.CandidateDependModule>();
              num34 = 17;
              continue;
label_319:
              keySelector = func;
              goto label_333;
            case 4:
            case 19:
              if (index1 >= candidateDependModuleArray.Length)
              {
                num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 13 : 20;
                continue;
              }
              goto case 7;
            case 5:
              Dictionary<Guid, ClientComponentModel> componentModules = searchContext.ChosenComponentModules;
              Guid key = current7.Key;
              ClientComponentModel clientComponentModel = new ClientComponentModel();
              FindComponentService.n8FEILBFPLdNFpd5yqyN((object) clientComponentModel, FindComponentService.eHcW1YBFpwFvr1R4vjtR((object) candidateDependModule8));
              clientComponentModel.ModuleItemUid = FindComponentService.TRRkqPBF3DeBYb8ZFdtB((object) candidateDependModule8);
              clientComponentModel.Owners = candidateDependModule8.Owners;
              componentModules[key] = clientComponentModel;
              num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 10 : 10;
              continue;
            case 6:
              try
              {
label_292:
                if (enumerator2.MoveNext())
                  goto label_301;
                else
                  goto label_293;
label_290:
                FindComponentService.CandidateDependModule candidateDependModule9;
                ClientComponentModel current8;
                List<FindComponentService.CandidateDependModule> candidateDependModuleList7;
                int num35;
                while (true)
                {
                  switch (num35)
                  {
                    case 1:
                      goto label_282;
                    case 2:
                      if (searchContext.CandidateModules.TryGetValue(FindComponentService.MeY255BFZT4ltNIPAYVj((object) current8), out candidateDependModuleList7))
                      {
                        num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_292;
                    case 3:
                      if (candidateDependModuleList6 != null)
                      {
                        num35 = 10;
                        continue;
                      }
                      goto case 9;
                    case 4:
                    case 7:
                      candidateDependModuleList6.Add(candidateDependModule9);
                      num35 = 11;
                      continue;
                    case 5:
                      goto label_301;
                    case 6:
                      if (candidateDependModuleList6 != null)
                      {
                        num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 7;
                        continue;
                      }
                      goto case 13;
                    case 8:
                    case 11:
                      goto label_292;
                    case 9:
                      if (FindComponentService.aSCXe9BFynUJVFOkKp78((object) candidateDependModule9))
                      {
                        num35 = 6;
                        continue;
                      }
                      goto label_292;
                    case 10:
                      if (candidateDependModuleList6.Contains(candidateDependModule9))
                      {
                        num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 8 : 8;
                        continue;
                      }
                      goto case 9;
                    case 12:
                      if (candidateDependModule9 != null)
                      {
                        num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 3;
                        continue;
                      }
                      goto label_292;
                    case 13:
                      candidateDependModuleList6 = new List<FindComponentService.CandidateDependModule>();
                      num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 4;
                      continue;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      candidateDependModule9 = candidateDependModuleList7.Find((Predicate<FindComponentService.CandidateDependModule>) (a => FindComponentService.\u003C\u003Ec__DisplayClass70_4.qLJdZVQB0277AJtrlJRJ(FindComponentService.\u003C\u003Ec__DisplayClass70_4.ukJsmOQBxRy5HiXYgnjy((object) a), FindComponentService.\u003C\u003Ec__DisplayClass70_4.ukJsmOQBxRy5HiXYgnjy((object) componentVersion))));
                      num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 12 : 7;
                      continue;
                  }
                }
label_293:
                num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
                goto label_290;
label_301:
                current8 = enumerator2.Current;
                num35 = 2;
                goto label_290;
              }
              finally
              {
                enumerator2.Dispose();
                int num36 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                  num36 = 0;
                switch (num36)
                {
                  default:
                }
              }
            case 7:
              num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 7 : 9;
              continue;
            case 8:
              module = false;
              num34 = 24;
              continue;
            case 9:
              componentVersion = candidateDependModuleArray[index1];
              num34 = 27;
              continue;
            case 10:
            case 13:
              goto label_287;
            case 11:
              goto label_262;
            case 12:
            case 15:
              candidateDependModule7 = array[0];
              num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 18 : 1;
              continue;
            case 14:
              index1 = 0;
              num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 19 : 9;
              continue;
            case 16:
              if (candidateDependModuleList6.Count == 0)
              {
                num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto case 22;
            case 17:
              candidateDependModuleList6 = (List<FindComponentService.CandidateDependModule>) null;
              num34 = 26;
              continue;
            case 18:
              searchContext.ChosenComponentModules[current7.Key] = new ClientComponentModel()
              {
                ModuleUid = FindComponentService.eHcW1YBFpwFvr1R4vjtR((object) candidateDependModule7),
                ModuleItemUid = FindComponentService.TRRkqPBF3DeBYb8ZFdtB((object) candidateDependModule7),
                Owners = candidateDependModule7.Owners
              };
              num34 = 13;
              continue;
            case 20:
              if (candidateDependModuleList6 == null)
              {
                num34 = 21;
                continue;
              }
              goto case 16;
            case 22:
              candidateDependModule8 = candidateDependModuleList6[0];
              num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 5;
              continue;
            case 23:
              goto label_314;
            case 25:
label_282:
              ++index1;
              num34 = 4;
              continue;
            case 26:
              candidateDependModuleArray = array;
              num34 = 14;
              continue;
            case 27:
              enumerator2 = searchContext.ChosenComponentModules.Values.GetEnumerator();
              num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 4 : 6;
              continue;
            default:
              module = false;
              num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
          }
        }
label_288:
        num34 = 11;
        goto label_281;
label_314:
        current7 = enumerator1.Current;
        num34 = 3;
        goto label_281;
      }
      finally
      {
        enumerator1.Dispose();
        int num37 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
          num37 = 0;
        switch (num37)
        {
          default:
        }
      }
    }

    private void GetComponentFromModule(
      Guid moduleUid,
      Guid componentUid,
      FindComponentService.SearchContext searchContext)
    {
      int num = 9;
      ModuleVersion module;
      ComponentMetadata component;
      Guid componentUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_14;
          case 2:
            // ISSUE: reference to a compiler-generated method
            component = ((ModuleInfoMetadata) FindComponentService.iMlyy1ztkAWCr8rEdWj((object) module)).Components.FirstOrDefault<ComponentMetadata>((Func<ComponentMetadata, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass71_0.kej1nwQB9CHUXljoiAxt(a.Uid, componentUid1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 3:
            this.GetComponentFromConfiguration(componentUid1, searchContext);
            num = 7;
            continue;
          case 4:
            goto label_2;
          case 5:
            module = this.GetModule(moduleUid, searchContext);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 10 : 10;
            continue;
          case 6:
            this.GetModuleClientComponentModel(module, component, searchContext);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
            continue;
          case 7:
            goto label_6;
          case 8:
            componentUid1 = componentUid;
            num = 5;
            continue;
          case 9:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 8 : 8;
            continue;
          case 10:
            if (module != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 2;
              continue;
            }
            goto label_10;
          default:
            if (component != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 4 : 6;
              continue;
            }
            goto case 3;
        }
      }
label_14:
      return;
label_2:
      return;
label_6:
      return;
label_10:;
    }

    private ModuleVersion GetModule(
      Guid moduleUid,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 10;
      IEnumerable<ModuleVersionHeader> moduleVersionHeaders1;
      IEnumerator<ModuleVersionHeader> enumerator;
      ModuleVersion defaultModuleVersion;
      IEnumerable<ModuleVersionHeader> moduleVersionHeaders2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(1051802738 - -1831968059 ^ -1411236385), (object) moduleUid));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 2;
            continue;
          case 2:
            if (!searchContext.ModuleVersions.TryGetValue(moduleUid, out moduleVersionHeaders1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 3:
            goto label_17;
          case 4:
            goto label_9;
          case 5:
            goto label_3;
          case 6:
            moduleVersionHeaders1 = moduleVersionHeaders2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 7;
            continue;
          case 7:
            enumerator = moduleVersionHeaders1.GetEnumerator();
            num1 = 3;
            continue;
          case 8:
            goto label_13;
          case 9:
            if (defaultModuleVersion != null)
            {
              if (searchContext.IncompatibleModuleItems.Contains(((ModuleVersionHeader) FindComponentService.wyDj5JBFOvUp3aNhic5o((object) defaultModuleVersion)).VersionUid))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 0;
                continue;
              }
              goto label_9;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
              continue;
            }
          case 10:
            defaultModuleVersion = this.moduleMetadataLoader.GetDefaultModuleVersion(moduleUid);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 9 : 0;
            continue;
          default:
            searchContext.ModuleVersions[moduleUid] = moduleVersionHeaders2 = (IEnumerable<ModuleVersionHeader>) this.moduleMetadataLoader.GetModuleVersionHeaders(moduleUid);
            num1 = 6;
            continue;
        }
      }
label_3:
      return (ModuleVersion) null;
label_9:
      return defaultModuleVersion;
label_13:
      return (ModuleVersion) null;
label_17:
      ModuleVersion module;
      try
      {
label_23:
        if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator))
          goto label_19;
        else
          goto label_24;
label_18:
        ModuleVersionHeader current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_19;
            case 2:
              goto label_14;
            case 3:
              goto label_13;
            case 4:
              if (!searchContext.IncompatibleModuleItems.Contains(FindComponentService.zhf61FzAs08ZdStq71m((object) current)))
              {
                num2 = 5;
                continue;
              }
              goto label_23;
            case 5:
              module = (ModuleVersion) FindComponentService.vHy53qzduNL4la1OiPP((object) this.moduleMetadataLoader, FindComponentService.g6LHQuBF76gEdOIm0C5X((object) current), FindComponentService.zhf61FzAs08ZdStq71m((object) current));
              num2 = 2;
              continue;
            default:
              goto label_23;
          }
        }
label_19:
        current = enumerator.Current;
        num2 = 4;
        goto label_18;
label_24:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 3;
        goto label_18;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_30;
              default:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_30:;
      }
label_14:
      return module;
    }

    private void GetModuleClientComponentModel(
      ModuleVersion module,
      ComponentMetadata component,
      FindComponentService.SearchContext searchContext)
    {
      int num = 13;
      ComponentGraph.Vertex vertex;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            guid = FindComponentService.zhf61FzAs08ZdStq71m(FindComponentService.wyDj5JBFOvUp3aNhic5o((object) module));
            num = 5;
            continue;
          case 2:
            goto label_17;
          case 3:
            searchContext.ChosenModules.Add(FindComponentService.o91ZZ6BFe7tmdgKxfgXN((object) vertex));
            num = 9;
            continue;
          case 4:
            searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(-867826612 ^ -867768874), FindComponentService.BcBEmvzUHSE6Hf3AR79((object) component)));
            num = 2;
            continue;
          case 5:
            vertex = (ComponentGraph.Vertex) FindComponentService.f7OjbUBFJtFSCSk1JvW9(FindComponentService.cKHlxVzcgw9q1aIwTx5((object) searchContext), FindComponentService.cMLTumBFhHIoYiMbgbG3((object) component), guid, FindComponentService.uUi5StBFMCssTCDkHA2T((object) component), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 11 : 9;
            continue;
          case 6:
            goto label_16;
          case 7:
            searchContext.Errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146534727), FindComponentService.BcBEmvzUHSE6Hf3AR79((object) component)));
            num = 6;
            continue;
          case 8:
            goto label_8;
          case 9:
            if (this.FindComponent(guid, guid, guid, component.Uid, (IEnumerable<ComponentDependency>) ((ModuleInfoMetadata) FindComponentService.iMlyy1ztkAWCr8rEdWj((object) module)).Dependency.Components, searchContext))
            {
              num = 10;
              continue;
            }
            goto case 7;
          case 10:
            if (this.FindModuleImpl(guid, guid, guid, FindComponentService.cMLTumBFhHIoYiMbgbG3((object) component), module, searchContext))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 11:
            Dictionary<Guid, ClientComponentModel> components = searchContext.Components;
            Guid key = FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex);
            ClientComponentModel clientComponentModel = new ClientComponentModel();
            clientComponentModel.ModuleUid = FindComponentService.o91ZZ6BFe7tmdgKxfgXN((object) vertex);
            FindComponentService.M82BL7zJJj9ytsx4xAS((object) clientComponentModel, FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex));
            clientComponentModel.Owners = vertex.Owners;
            FindComponentService.aJiRH2BFWqD71eFO0MDW((object) clientComponentModel, vertex.Async);
            components.Add(key, clientComponentModel);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 3;
            continue;
          case 12:
            goto label_11;
          case 13:
            if (module == null)
            {
              num = 12;
              continue;
            }
            FindComponentService.uir9COBFbdBxBXhvM3Cg((object) searchContext.Options, InterfaceBuilderViewMode.Runtime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
            continue;
          case 14:
            searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(1142330761 ^ 1541959139 ^ 536746480), FindComponentService.BcBEmvzUHSE6Hf3AR79((object) component)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 8 : 5;
            continue;
          case 15:
            goto label_15;
          default:
            if (this.FindCustomTypes(searchContext))
            {
              num = 15;
              continue;
            }
            goto case 14;
        }
      }
label_17:
      return;
label_16:
      return;
label_8:
      return;
label_11:
      return;
label_15:;
    }

    private bool FindModuleComponent(
      Guid parent,
      Guid owner,
      Guid moduleUid,
      Guid parentComponentUid,
      ComponentDependency dependency,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 17;
      IEnumerator<ComponentGraph.Vertex> enumerator1;
      FindComponentService.SearchContext searchContext1;
      Guid dependencyHeaderUid;
      Guid owner1;
      while (true)
      {
        int num2 = num1;
        ModuleVersionHeader[] array1;
        bool flag;
        IEnumerable<ModuleVersionHeader> source1;
        ModuleVersionHeader[] array2;
        IEnumerable<ModuleVersionHeader> source2;
        IEnumerable<ModuleVersionHeader> moduleVersionHeaders;
        HashSet<Guid> itemUids;
        Guid parent1;
        ComponentDependency dependency1;
        Guid parentComponentUid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              searchContext1.ModuleVersions[moduleUid] = moduleVersionHeaders = (IEnumerable<ModuleVersionHeader>) this.moduleMetadataLoader.GetModuleVersionHeaders(moduleUid);
              num2 = 22;
              continue;
            case 2:
            case 6:
            case 10:
              array1 = source2.Where<ModuleVersionHeader>((Func<ModuleVersionHeader, bool>) (c =>
              {
                int num3 = 5;
                ComponentSignature componentSignature;
                while (true)
                {
                  int num4 = num3;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        if (!searchContext1.IncompatibleModuleItems.Contains(c.VersionUid))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 0;
                          continue;
                        }
                        goto label_17;
                      case 2:
                      case 8:
                        goto label_18;
                      case 3:
                        goto label_17;
                      case 4:
                        goto label_7;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        if (FindComponentService.\u003C\u003Ec__DisplayClass74_0.D8HShsQB5UsFMVbac3Bw(parent1, Guid.Empty))
                        {
                          num4 = 4;
                          continue;
                        }
                        // ISSUE: reference to a compiler-generated method
                        if (FindComponentService.\u003C\u003Ec__DisplayClass74_0.aAmlvvQBjhwmCA4mahwu((object) searchContext1.IncompatibleModuleItems) <= 0)
                        {
                          num4 = 8;
                          continue;
                        }
                        goto case 1;
                      case 6:
                        goto label_10;
                      case 7:
                        goto label_3;
                      case 9:
                        if (componentSignature != null)
                        {
                          // ISSUE: reference to a compiler-generated method
                          if (!((FindComponentOptions) FindComponentService.\u003C\u003Ec__DisplayClass74_0.d1QQ8cQBLkfXomDOtqbS((object) searchContext1)).CheckCompatibility)
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_3;
                        }
                        else
                          goto label_16;
                      default:
                        goto label_4;
                    }
                  }
label_16:
                  num3 = 6;
                  continue;
label_18:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  componentSignature = ((ModuleSignature) FindComponentService.\u003C\u003Ec__DisplayClass74_0.wwbvKGQBYJ5TFgHfw393((object) c)).Components.Find((Predicate<ComponentSignature>) (a => FindComponentService.\u003C\u003Ec__DisplayClass74_0.D8HShsQB5UsFMVbac3Bw(FindComponentService.\u003C\u003Ec__DisplayClass74_0.Kbthp6QBcaItKVUkAumO((object) a), dependencyHeaderUid)));
                  num3 = 9;
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return FindComponentService.\u003C\u003Ec__DisplayClass74_0.zPD96hQBsI6AA5k9ErtT(FindComponentService.\u003C\u003Ec__DisplayClass74_0.XRbHGpQBUr8TNZerUA9c((object) dependency1, (object) componentSignature));
label_4:
                return true;
label_7:
                return true;
label_10:
                return false;
label_17:
                return false;
              })).ToArray<ModuleVersionHeader>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 23 : 18;
              continue;
            case 3:
              if (!searchContext1.ModuleVersions.TryGetValue(moduleUid, out source1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
                continue;
              }
              goto case 20;
            case 4:
              if (array1.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 25;
                continue;
              }
              goto label_81;
            case 5:
            case 8:
              source2 = source1;
              num2 = 2;
              continue;
            case 7:
              goto label_15;
            case 9:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 6 : 4;
              continue;
            case 11:
              flag = false;
              num2 = 28;
              continue;
            case 12:
              owner1 = owner;
              num2 = 3;
              continue;
            case 13:
              source2 = (IEnumerable<ModuleVersionHeader>) array2;
              num2 = 9;
              continue;
            case 14:
              source2 = source1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 10 : 2;
              continue;
            case 15:
              dependency1 = dependency;
              num2 = 27;
              continue;
            case 16:
              parent1 = parent;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 21 : 19;
              continue;
            case 17:
              goto label_7;
            case 18:
              goto label_81;
            case 19:
              if (array2.Length == 0)
              {
                num2 = 5;
                continue;
              }
              goto case 13;
            case 20:
              dependencyHeaderUid = dependency1.HeaderUid;
              num2 = 11;
              continue;
            case 21:
              searchContext1 = searchContext;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 4 : 15;
              continue;
            case 22:
              source1 = moduleVersionHeaders;
              num2 = 20;
              continue;
            case 23:
              if (array1.Length == 0 & flag)
              {
                num2 = 26;
                continue;
              }
              goto case 4;
            case 24:
              goto label_78;
            case 25:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              enumerator1 = ((IEnumerable<ModuleVersionHeader>) array1).Select<ModuleVersionHeader, ComponentGraph.Vertex>((Func<ModuleVersionHeader, ComponentGraph.Vertex>) (candidate => searchContext1.ComponentGraph.AddVertex(dependencyHeaderUid, FindComponentService.\u003C\u003Ec__DisplayClass74_0.zRXIRLQBzIudOFnWfG7p((object) candidate), FindComponentService.\u003C\u003Ec__DisplayClass74_0.If0bD3QWBULTGKGU6ljV((object) candidate), parent1, (string) FindComponentService.\u003C\u003Ec__DisplayClass74_0.uZX0FuQWbkKOPVXPobjx(FindComponentService.\u003C\u003Ec__DisplayClass74_0.xSc38JQWWLELWkVEVYFK(1642859704 ^ 1642941532), (object) parentComponentUid1, (object) FindComponentService.\u003C\u003Ec__DisplayClass74_0.OThF8aQWo7bPu1oMVpCa((object) dependency1)), owner1, FindComponentService.\u003C\u003Ec__DisplayClass74_0.tk5eKpQWhafVkPldg1Wo((object) dependency1)))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 7;
              continue;
            case 26:
              Predicate<ComponentSignature> predicate;
              array1 = source1.Where<ModuleVersionHeader>((Func<ModuleVersionHeader, bool>) (c =>
              {
                int num5 = 6;
                ComponentSignature componentSignature;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_2;
                    case 2:
                      goto label_8;
                    case 3:
                      List<ComponentSignature> components = c.Signature.Components;
                      Predicate<ComponentSignature> predicate1 = predicate;
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      Predicate<ComponentSignature> match = predicate1 == null ? (predicate = (Predicate<ComponentSignature>) (a => FindComponentService.\u003C\u003Ec__DisplayClass74_0.D8HShsQB5UsFMVbac3Bw(FindComponentService.\u003C\u003Ec__DisplayClass74_0.Kbthp6QBcaItKVUkAumO((object) a), dependencyHeaderUid))) : predicate1;
                      componentSignature = components.Find(match);
                      num5 = 10;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!FindComponentService.\u003C\u003Ec__DisplayClass74_0.YFv5hqQWF9AZIxP9pj12(FindComponentService.\u003C\u003Ec__DisplayClass74_0.d1QQ8cQBLkfXomDOtqbS((object) searchContext1)))
                      {
                        num5 = 2;
                        continue;
                      }
                      goto label_7;
                    case 5:
                      if (searchContext1.IncompatibleModuleItems.Count > 0)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 7 : 6;
                        continue;
                      }
                      goto case 3;
                    case 6:
                      if (!(parent1 == Guid.Empty))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 5 : 2;
                        continue;
                      }
                      goto label_2;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      if (!searchContext1.IncompatibleModuleItems.Contains(FindComponentService.\u003C\u003Ec__DisplayClass74_0.zRXIRLQBzIudOFnWfG7p((object) c)))
                      {
                        num5 = 3;
                        continue;
                      }
                      goto label_16;
                    case 8:
                      goto label_7;
                    case 9:
                      goto label_16;
                    case 10:
                      if (componentSignature != null)
                      {
                        num5 = 4;
                        continue;
                      }
                      goto label_11;
                    default:
                      goto label_11;
                  }
                }
label_2:
                return true;
label_7:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return FindComponentService.\u003C\u003Ec__DisplayClass74_0.zPD96hQBsI6AA5k9ErtT(FindComponentService.\u003C\u003Ec__DisplayClass74_0.XRbHGpQBUr8TNZerUA9c((object) dependency1, (object) componentSignature));
label_8:
                return true;
label_11:
                return false;
label_16:
                return false;
              })).ToArray<ModuleVersionHeader>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 2;
              continue;
            case 27:
              parentComponentUid1 = parentComponentUid;
              num2 = 12;
              continue;
            case 28:
              if (searchContext1.CandidateDependencies.TryGetValue(dependencyHeaderUid, out itemUids))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            default:
              array2 = source1.Where<ModuleVersionHeader>((Func<ModuleVersionHeader, bool>) (c => itemUids.Contains(c.VersionUid))).ToArray<ModuleVersionHeader>();
              num2 = 19;
              continue;
          }
        }
label_7:
        num1 = 16;
      }
label_15:
      bool moduleComponent;
      try
      {
label_21:
        if (enumerator1.MoveNext())
          goto label_48;
        else
          goto label_22;
label_17:
        int num6;
        while (true)
        {
          int num7;
          HashSet<string>.Enumerator enumerator2;
          ModuleInfoMetadata moduleInfoMetadata;
          HashSet<Guid> guidSet;
          Guid guid;
          IEnumerator<Guid> enumerator3;
          ClientComponentModel clientComponentModel1;
          ComponentGraph.Vertex vertex;
          switch (num6)
          {
            case 1:
              goto label_79;
            case 2:
label_59:
              HashSet<Guid> owners = vertex.Owners;
              Func<Guid, bool> func;
              Func<Guid, bool> func1 = func;
              // ISSUE: reference to a compiler-generated method
              Func<Guid, bool> predicate = func1 == null ? (func = (Func<Guid, bool>) (ownerUid => FindComponentService.\u003C\u003Ec__DisplayClass74_1.kjtlmKQWCEoDUT0pFJQy(ownerUid, vertex.ItemUid))) : func1;
              enumerator3 = owners.Where<Guid>(predicate).GetEnumerator();
              num6 = 21;
              continue;
            case 3:
              moduleComponent = true;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
              continue;
            case 4:
              enumerator2 = vertex.ViewItemUidList.GetEnumerator();
              num6 = 20;
              continue;
            case 5:
            case 18:
label_19:
              searchContext1.ChosenModules.Add(FindComponentService.o91ZZ6BFe7tmdgKxfgXN((object) vertex));
              num6 = 15;
              continue;
            case 6:
              if (!searchContext1.Components.TryGetValue(guid, out clientComponentModel1))
              {
                num6 = 8;
                continue;
              }
              goto case 4;
            case 7:
              vertex = enumerator1.Current;
              num6 = 19;
              continue;
            case 8:
              Dictionary<Guid, ClientComponentModel> components = searchContext1.Components;
              Guid key = FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex);
              ClientComponentModel clientComponentModel2 = new ClientComponentModel();
              clientComponentModel2.ModuleUid = FindComponentService.o91ZZ6BFe7tmdgKxfgXN((object) vertex);
              FindComponentService.M82BL7zJJj9ytsx4xAS((object) clientComponentModel2, guid);
              clientComponentModel2.RenderUidList = vertex.ViewItemUidList;
              clientComponentModel2.Owners = vertex.Owners;
              components[key] = clientComponentModel2;
              num6 = 18;
              continue;
            case 9:
              if (!this.FindComponent(guid, guid, vertex.Async ? guid : owner1, dependencyHeaderUid, (IEnumerable<ComponentDependency>) ((ModuleDependency) FindComponentService.uJ6ZVgBFHGWZftlNPcOQ((object) moduleInfoMetadata)).Components, searchContext1))
              {
                num6 = 10;
                continue;
              }
              goto case 6;
            case 10:
            case 11:
              goto label_21;
            case 12:
              guidSet.Add(vertex.ItemUid);
              num7 = 3;
              break;
            case 13:
              searchContext1.CandidateDependencies[dependencyHeaderUid] = guidSet;
              num6 = 12;
              continue;
            case 14:
              guidSet = new HashSet<Guid>();
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 8 : 13;
              continue;
            case 15:
              if (!searchContext1.CandidateDependencies.TryGetValue(dependencyHeaderUid, out guidSet))
              {
                num6 = 14;
                continue;
              }
              goto case 12;
            case 16:
              goto label_78;
            case 17:
              goto label_48;
            case 19:
              guid = FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
              continue;
            case 20:
              try
              {
label_42:
                if (enumerator2.MoveNext())
                  goto label_40;
                else
                  goto label_43;
label_39:
                string current;
                int num8;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_40;
                    case 2:
                      goto label_42;
                    case 3:
                      clientComponentModel1.RenderUidList.Add(current);
                      num8 = 2;
                      continue;
                    default:
                      goto label_59;
                  }
                }
label_40:
                current = enumerator2.Current;
                num8 = 3;
                goto label_39;
label_43:
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                goto label_39;
              }
              finally
              {
                enumerator2.Dispose();
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                  num9 = 0;
                switch (num9)
                {
                  default:
                }
              }
            case 21:
              try
              {
label_28:
                if (enumerator3.MoveNext())
                  goto label_30;
                else
                  goto label_29;
label_27:
                Guid current;
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      goto label_28;
                    case 2:
                      goto label_30;
                    case 3:
                      clientComponentModel1.Owners.Add(current);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_19;
                  }
                }
label_29:
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                goto label_27;
label_30:
                current = enumerator3.Current;
                num10 = 3;
                goto label_27;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num11 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
                    num11 = 0;
                  while (true)
                  {
                    switch (num11)
                    {
                      case 1:
                        goto label_37;
                      default:
                        FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator3);
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_37:;
              }
            default:
              moduleInfoMetadata = (ModuleInfoMetadata) FindComponentService.iMlyy1ztkAWCr8rEdWj((object) this.moduleMetadataLoader.GetSpecificModuleVersion(FindComponentService.o91ZZ6BFe7tmdgKxfgXN((object) vertex), FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex)));
              num7 = 9;
              break;
          }
          num6 = num7;
        }
label_22:
        num6 = 16;
        goto label_17;
label_48:
        num6 = 7;
        goto label_17;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num12 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
            num12 = 1;
          while (true)
          {
            switch (num12)
            {
              case 1:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator1);
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                continue;
              default:
                goto label_65;
            }
          }
        }
label_65:;
      }
label_79:
      return moduleComponent;
label_78:
      return false;
label_81:
      return false;
    }

    private bool GetDataClassFromModule(
      EleWise.ELMA.Model.Dependencies.Dependency dependency,
      FindComponentService.SearchContext searchContext,
      IDictionary<Guid, ClientDataClassModel> result)
    {
      Guid moduleUid = dependency.ModuleUid;
      IEnumerable<ModuleVersionHeader> moduleVersionHeaders;
      if (!searchContext.ModuleVersions.TryGetValue(moduleUid, out moduleVersionHeaders))
        moduleVersionHeaders = searchContext.ModuleVersions[moduleUid] = (IEnumerable<ModuleVersionHeader>) this.moduleMetadataLoader.GetModuleVersionHeaders(moduleUid);
      foreach (ModuleVersionHeader moduleVersionHeader in moduleVersionHeaders)
      {
        if (searchContext.Components.ContainsKey(moduleVersionHeader.VersionUid))
          return true;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (moduleVersionHeader.Signature.DataClasses.FirstOrDefault<DataClassDependency>((Func<DataClassDependency, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass75_0.LYbKWKQWVYkxjA9NW7pd(FindComponentService.\u003C\u003Ec__DisplayClass75_0.fLn3grQWI1o07jM45KsT((object) a), dependency.HeaderUid))) != null)
        {
          result[dependency.HeaderUid] = new ClientDataClassModel()
          {
            ModuleItemUid = moduleVersionHeader.VersionUid
          };
          return true;
        }
      }
      return false;
    }

    private bool GetFunctionFromModule(
      FunctionDependency dependency,
      FindComponentService.SearchContext searchContext,
      IDictionary<Guid, ClientFunctionModel> result)
    {
      Guid moduleUid = dependency.ModuleUid;
      IEnumerable<ModuleVersionHeader> moduleVersionHeaders;
      if (!searchContext.ModuleVersions.TryGetValue(moduleUid, out moduleVersionHeaders))
        moduleVersionHeaders = searchContext.ModuleVersions[moduleUid] = (IEnumerable<ModuleVersionHeader>) this.moduleMetadataLoader.GetModuleVersionHeaders(moduleUid);
      foreach (ModuleVersionHeader moduleVersionHeader in moduleVersionHeaders)
      {
        if (searchContext.Components.ContainsKey(moduleVersionHeader.VersionUid))
          return true;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (moduleVersionHeader.Signature.Functions.FirstOrDefault<FunctionDependency>((Func<FunctionDependency, bool>) (a => FindComponentService.\u003C\u003Ec__DisplayClass76_0.ypiJQxQWXNHXiOriQKFW(a.HeaderUid, FindComponentService.\u003C\u003Ec__DisplayClass76_0.NrA0WjQWKVT7QL4XRkwb((object) dependency)))) != null)
        {
          result[dependency.HeaderUid] = new ClientFunctionModel()
          {
            HeaderUid = dependency.HeaderUid,
            ModuleItemUid = moduleVersionHeader.VersionUid,
            ModuleUid = dependency.ModuleUid
          };
          return true;
        }
      }
      return false;
    }

    /// <inheritdoc />
    public RecursiveComponentModel FindComponent(
      ObjectFormFindComponentModel model,
      FindComponentOptions options)
    {
      int num1 = 6;
      Guid guid1;
      string str1;
      RecursiveComponentModel component;
      string str2;
      Guid guid2;
      List<ClientComponentModel>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        ClientComponentModel clientComponentModel;
        while (true)
        {
          FindComponentService.SearchContext searchContext;
          switch (num2)
          {
            case 1:
              if (clientComponentModel == null)
              {
                num2 = 22;
                continue;
              }
              goto label_68;
            case 2:
              component = this.FindComponentInternal(model, searchContext);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_13;
            case 4:
              guid1 = FindComponentService.vfO5wYBFrkyDXxYc8S0I((object) model);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 18 : 7;
              continue;
            case 5:
              if (this.moduleApplicationCacheResult.TryGetValue(FindComponentService.pbqZmDBFdOsBTyucX6Fi((object) model), out component))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 11 : 12;
                continue;
              }
              break;
            case 6:
              if (FindComponentService.XYMrWbBF9tQNR5t8Wiok((object) options))
              {
                num2 = 5;
                continue;
              }
              break;
            case 7:
            case 14:
              goto label_12;
            case 8:
              component = (RecursiveComponentModel) component.Clone();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 19 : 2;
              continue;
            case 9:
              str1 = guid1.ToString();
              num2 = 8;
              continue;
            case 10:
              goto label_7;
            case 11:
            case 17:
            case 22:
              goto label_54;
            case 12:
              clientComponentModel = (ClientComponentModel) FindComponentService.F0eBFgBFltXsWqDlFFQT((object) component);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
              continue;
            case 13:
              str2 = guid2.ToString();
              num2 = 9;
              continue;
            case 15:
              if (FindComponentService.SHwxCpBFI8kUKZhtBG8g(guid1, Guid.Empty))
              {
                num2 = 13;
                continue;
              }
              goto label_54;
            case 16:
              goto label_68;
            case 18:
              if (FindComponentService.SHwxCpBFI8kUKZhtBG8g(guid2, guid1))
              {
                num2 = 20;
                continue;
              }
              goto label_54;
            case 19:
              ((ClientComponentModel) FindComponentService.F0eBFgBFltXsWqDlFFQT((object) component)).ItemUid = guid1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 21 : 17;
              continue;
            case 20:
              if (FindComponentService.SHwxCpBFI8kUKZhtBG8g(guid2, Guid.Empty))
                goto case 15;
              else
                goto label_57;
            case 21:
              goto label_58;
            default:
              if (!FindComponentService.XYMrWbBF9tQNR5t8Wiok((object) options))
              {
                num2 = 7;
                continue;
              }
              goto label_7;
          }
          searchContext = new FindComponentService.SearchContext(options);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
        }
label_7:
        this.moduleApplicationCacheResult[model.MetadataUid] = component;
        num1 = 14;
        continue;
label_57:
        num1 = 11;
        continue;
label_58:
        enumerator1 = component.ComponentCache.GetEnumerator();
        num1 = 3;
        continue;
label_68:
        guid2 = FindComponentService.E9tAxZBFV0HgOdgjNQ3I((object) clientComponentModel);
        num1 = 4;
      }
label_12:
      return component;
label_13:
      try
      {
label_48:
        if (enumerator1.MoveNext())
          goto label_46;
        else
          goto label_49;
label_14:
        List<KeyValuePair<string, string>> keyValuePairList;
        HashSet<string>.Enumerator enumerator2;
        ClientComponentModel current1;
        List<KeyValuePair<string, string>>.Enumerator enumerator3;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_48;
            case 2:
              goto label_34;
            case 3:
              goto label_54;
            case 4:
            case 7:
              keyValuePairList = new List<KeyValuePair<string, string>>();
              num3 = 10;
              continue;
            case 5:
              goto label_46;
            case 6:
label_32:
              enumerator3 = keyValuePairList.GetEnumerator();
              num3 = 2;
              continue;
            case 8:
              current1.Owners.Add(guid1);
              num3 = 4;
              continue;
            case 9:
              try
              {
label_18:
                if (enumerator2.MoveNext())
                  goto label_20;
                else
                  goto label_19;
label_16:
                string current2;
                string str3;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_32;
                    case 2:
                      goto label_20;
                    case 3:
                      goto label_18;
                    case 4:
                      if (current2.Contains(str2))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_18;
                    case 5:
                      keyValuePairList.Add(new KeyValuePair<string, string>(current2, str3));
                      num4 = 3;
                      continue;
                    default:
                      str3 = (string) FindComponentService.IMOPrgBFgciaGhbEpB3c((object) current2, (object) str2, (object) str1);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 5 : 2;
                      continue;
                  }
                }
label_19:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                goto label_16;
label_20:
                current2 = enumerator2.Current;
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                {
                  num4 = 4;
                  goto label_16;
                }
                else
                  goto label_16;
              }
              finally
              {
                enumerator2.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 10:
              enumerator2 = current1.RenderUidList.GetEnumerator();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 9;
              continue;
            default:
              if (!current1.Owners.Remove(guid2))
              {
                num3 = 7;
                continue;
              }
              goto case 8;
          }
        }
label_34:
        try
        {
label_37:
          if (enumerator3.MoveNext())
            goto label_40;
          else
            goto label_38;
label_35:
          KeyValuePair<string, string> current3;
          int num6;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_37;
              case 2:
                goto label_40;
              case 3:
                goto label_48;
              case 4:
                current1.RenderUidList.Remove(current3.Key);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                continue;
              default:
                current1.RenderUidList.Add(current3.Value);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
                continue;
            }
          }
label_38:
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 0;
          goto label_35;
label_40:
          current3 = enumerator3.Current;
          num6 = 4;
          goto label_35;
        }
        finally
        {
          enumerator3.Dispose();
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
            num7 = 0;
          switch (num7)
          {
            default:
          }
        }
label_46:
        current1 = enumerator1.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        {
          num3 = 0;
          goto label_14;
        }
        else
          goto label_14;
label_49:
        num3 = 3;
        goto label_14;
      }
      finally
      {
        enumerator1.Dispose();
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          num8 = 0;
        switch (num8)
        {
          default:
        }
      }
label_54:
      return component;
    }

    private RecursiveComponentModel FindComponentInternal(
      ObjectFormFindComponentModel model,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 22;
      RecursiveComponentModel recursiveModel;
      FindComponentService.SearchContext searchContext1;
      while (true)
      {
        ClientComponentModel clientComponentModel1;
        IEnumerator<ClientFunctionModel> enumerator1;
        ClientComponentModel[] array;
        KeyValuePair<Guid, ClientComponentModel> keyValuePair;
        Dictionary<Guid, ClientComponentModel>.Enumerator enumerator2;
        IEnumerator<ClientDataClassModel> enumerator3;
        FindComponentService componentService;
        switch (num1)
        {
          case 1:
label_47:
            FindComponentService.LsVbNKBF55JDN8n02vIg((object) searchContext1.AllModules);
            num1 = 17;
            continue;
          case 2:
            try
            {
label_37:
              if (enumerator2.MoveNext())
                goto label_35;
              else
                goto label_38;
label_32:
              KeyValuePair<Guid, ClientComponentModel> current;
              ClientComponentModel clientComponentModel2;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_37;
                  case 2:
                    goto label_35;
                  case 3:
                    searchContext1.Components.Add(FindComponentService.MeY255BFZT4ltNIPAYVj((object) clientComponentModel2), clientComponentModel2);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
                    continue;
                  case 4:
                    goto label_2;
                  default:
                    clientComponentModel2 = current.Value;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 1;
                    continue;
                }
              }
label_35:
              current = enumerator2.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
              {
                num2 = 0;
                goto label_32;
              }
              else
                goto label_32;
label_38:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 0;
              goto label_32;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 3:
            clientComponentModel1 = keyValuePair.Value;
            num1 = 4;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            enumerator1 = searchContext1.Functions.Values.Where<ClientFunctionModel>((Func<ClientFunctionModel, bool>) (function => !searchContext1.Components.ContainsKey(FindComponentService.\u003C\u003Ec__DisplayClass78_0.zZ5MbEQW2cbrNmLQxHYS((object) function)))).GetEnumerator();
            num1 = 15;
            continue;
          case 5:
            try
            {
label_53:
              if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator3))
                goto label_50;
              else
                goto label_54;
label_49:
              ClientDataClassModel current;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_53;
                  case 2:
                    goto label_50;
                  case 3:
                    clientComponentModel1.DataClasses.Add(current);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                    continue;
                  default:
                    goto label_47;
                }
              }
label_50:
              current = enumerator3.Current;
              num4 = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
              {
                num4 = 1;
                goto label_49;
              }
              else
                goto label_49;
label_54:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              goto label_49;
            }
            finally
            {
              int num5;
              if (enumerator3 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              else
                goto label_58;
label_57:
              switch (num5)
              {
                case 1:
                  break;
                default:
              }
label_58:
              FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator3);
              num5 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
              {
                num5 = 2;
                goto label_57;
              }
              else
                goto label_57;
            }
          case 6:
            goto label_22;
          case 7:
            recursiveModel = new RecursiveComponentModel();
            num1 = 12;
            continue;
          case 8:
            goto label_27;
          case 9:
label_2:
            FindComponentService.In1G9QBFu5mGyHOPsJhK((object) recursiveModel, (object) clientComponentModel1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 16 : 2;
            continue;
          case 10:
            Dictionary<Guid, ClientComponentModel>.ValueCollection values = searchContext1.Components.Values;
            // ISSUE: reference to a compiler-generated field
            Func<ClientComponentModel, bool> func = FindComponentService.\u003C\u003Ec.\u003C\u003E9__78_0;
            Func<ClientComponentModel, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              FindComponentService.\u003C\u003Ec.\u003C\u003E9__78_0 = predicate = (Func<ClientComponentModel, bool>) (component => FindComponentService.\u003C\u003Ec.pgSCdFfcxyg867jk9orx(component.ModuleItemUid, Guid.Empty));
            }
            else
              goto label_67;
label_65:
            array = values.Where<ClientComponentModel>(predicate).ToArray<ClientComponentModel>();
            num1 = 13;
            continue;
label_67:
            predicate = func;
            goto label_65;
          case 11:
            componentService = this;
            num1 = 7;
            continue;
          case 12:
            this.FindComponentFromConfiguration(model, searchContext1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 18 : 16;
            continue;
          case 13:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (((IEnumerable<ClientComponentModel>) array).All<ClientComponentModel>((Func<ClientComponentModel, bool>) (component => componentService.FillСompatibilityTable(componentService.moduleMetadataLoader.GetSpecificModuleVersion(FindComponentService.\u003C\u003Ec__DisplayClass78_0.ybA4mBQWPBRRE57ffvHw((object) component), FindComponentService.\u003C\u003Ec__DisplayClass78_0.OxwcBAQW1uaDLabtVtpC((object) component)), searchContext1))))
            {
              num1 = 24;
              continue;
            }
            goto case 20;
          case 14:
            this.FillEntityDependencies(recursiveModel);
            num1 = 19;
            continue;
          case 15:
            try
            {
label_6:
              if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator1))
                goto label_9;
              else
                goto label_7;
label_5:
              ClientFunctionModel current;
              int num6;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    clientComponentModel1.Functions.Add(current);
                    num6 = 3;
                    continue;
                  case 2:
                    goto label_9;
                  case 3:
                    goto label_6;
                  default:
                    goto label_62;
                }
              }
label_7:
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              goto label_5;
label_9:
              current = enumerator1.Current;
              num6 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
              {
                num6 = 1;
                goto label_5;
              }
              else
                goto label_5;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator1);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
              }
label_16:;
            }
          case 16:
            recursiveModel.ComponentCache = searchContext1.Components.Except<KeyValuePair<Guid, ClientComponentModel>>((IEnumerable<KeyValuePair<Guid, ClientComponentModel>>) new KeyValuePair<Guid, ClientComponentModel>[1]
            {
              keyValuePair
            }).Select<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel>((Func<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel>) (a => a.Value)).ToList<ClientComponentModel>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 14 : 5;
            continue;
          case 17:
            searchContext1.AllModules.AddRange<Guid>((IEnumerable<Guid>) searchContext1.ChosenModules);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 10 : 9;
            continue;
          case 18:
            keyValuePair = searchContext1.Components.First<KeyValuePair<Guid, ClientComponentModel>>();
            num1 = 3;
            continue;
          case 19:
            goto label_26;
          case 20:
            searchContext1.Clear();
            num1 = 6;
            continue;
          case 21:
            searchContext1 = searchContext;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 3 : 11;
            continue;
          case 22:
            num1 = 21;
            continue;
          case 23:
            FindComponentService.iooQkoBFjwiNesIufA6I((object) searchContext1);
            num1 = 8;
            continue;
          case 24:
            if (!this.FindModule(array, searchContext1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 23 : 8;
              continue;
            }
            enumerator2 = searchContext1.ChosenComponentModules.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
            continue;
        }
label_62:
        // ISSUE: reference to a compiler-generated method
        enumerator3 = searchContext1.DataClasses.Values.Where<ClientDataClassModel>((Func<ClientDataClassModel, bool>) (dataClass => !searchContext1.Components.ContainsKey(FindComponentService.\u003C\u003Ec__DisplayClass78_0.TCMm8SQWeXIWxlwlAiwe((object) dataClass)))).GetEnumerator();
        num1 = 5;
      }
label_22:
      return this.FindComponentInternal(model, searchContext1);
label_26:
      return recursiveModel;
label_27:
      return this.FindComponentInternal(model, searchContext1);
    }

    private void FindComponentFromConfiguration(
      ObjectFormFindComponentModel model,
      FindComponentService.SearchContext searchContext)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        Guid guid;
        ComponentGraph.Vertex vertex;
        IEnumerator<ClientFunctionModel> enumerator1;
        IEnumerable<ClientFunctionModel> functionModels;
        while (true)
        {
          string componentName;
          IEnumerable<ClientDataClassModel> dataClassModels;
          IEnumerator<ClientDataClassModel> enumerator2;
          switch (num2)
          {
            case 1:
              goto label_47;
            case 2:
              Dictionary<Guid, ClientComponentModel> components = searchContext.Components;
              Guid key = FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex);
              ClientComponentModel clientComponentModel = new ClientComponentModel();
              FindComponentService.gHf6qOBFF83pESH2yeSb((object) clientComponentModel, FindComponentService.EKWac9zzFvThoYiiFo5((object) vertex));
              FindComponentService.aJiRH2BFWqD71eFO0MDW((object) clientComponentModel, FindComponentService.q4h85NBFBxYqKkIqQqF1((object) vertex));
              clientComponentModel.RenderUidList = vertex.ViewItemUidList;
              components.Add(key, clientComponentModel);
              num2 = 18;
              continue;
            case 3:
              goto label_6;
            case 4:
              functionModels = this.GetFunctions(componentName, (IReadOnlyCollection<FunctionDependency>) model.FunctionDependencies, searchContext, true).functionModels;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 10;
              continue;
            case 5:
              componentName = (string) FindComponentService.xVcZMkBFsklcoOtoitoL(FindComponentService.iOJgvJBFYRfKgNOAL24x((object) model), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824365623), FindComponentService.B1upWEBFUphXlqLMPgfk(FindComponentService.ql646BBFLR5BP1kDsgj2((object) model)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 3 : 4;
              continue;
            case 6:
              try
              {
label_34:
                if (enumerator2.MoveNext())
                  goto label_33;
                else
                  goto label_35;
label_32:
                ClientDataClassModel current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_30;
                    case 2:
                      searchContext.DataClasses[FindComponentService.KQ588fBFfP6HcAVOGSkp((object) current)] = current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 3 : 1;
                      continue;
                    case 3:
                      goto label_34;
                    default:
                      goto label_33;
                  }
                }
label_33:
                current = enumerator2.Current;
                num3 = 2;
                goto label_32;
label_35:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                goto label_32;
              }
              finally
              {
                int num4;
                if (enumerator2 == null)
                  num4 = 2;
                else
                  goto label_40;
label_39:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_40:
                FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator2);
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
                {
                  num4 = 1;
                  goto label_39;
                }
                else
                  goto label_39;
              }
            case 7:
              goto label_5;
            case 8:
              searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(1051802738 - -1831968059 ^ -1411237833), FindComponentService.iOJgvJBFYRfKgNOAL24x((object) model)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 11 : 17;
              continue;
            case 9:
label_24:
              enumerator2 = dataClassModels.GetEnumerator();
              num2 = 6;
              continue;
            case 10:
              if (searchContext.Errors.Count > 0)
              {
                num2 = 19;
                continue;
              }
              dataClassModels = this.GetDataClasses(componentName, (IReadOnlyCollection<DataClassDependency>) model.DataClassDependencies, searchContext, true).dataClassModels;
              num2 = 12;
              continue;
            case 11:
              goto label_4;
            case 12:
              if (FindComponentService.vKChURzsrUf3vkTTcIY((object) searchContext.Errors) <= 0)
              {
                num2 = 15;
                continue;
              }
              goto case 14;
            case 13:
              try
              {
label_11:
                if (FindComponentService.Xtuo5mz2tWrRwGmUMM2((object) enumerator1))
                  goto label_9;
                else
                  goto label_12;
label_8:
                ClientFunctionModel current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      searchContext.Functions[FindComponentService.JjPtnYBFoMWBXtGgW9M3((object) current)] = current;
                      num5 = 3;
                      continue;
                    case 2:
                      goto label_24;
                    case 3:
                      goto label_11;
                    default:
                      goto label_9;
                  }
                }
label_9:
                current = enumerator1.Current;
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                {
                  num5 = 1;
                  goto label_8;
                }
                else
                  goto label_8;
label_12:
                num5 = 2;
                goto label_8;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_19;
                      default:
                        FindComponentService.OvaV7SzejkY4BOybd2x((object) enumerator1);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_19:;
              }
            case 14:
              searchContext.Errors.Add(EleWise.ELMA.SR.T((string) FindComponentService.PC0R82zrUHU2qMy6Gg0(-244066886 - -48452443 ^ -195573731), (object) componentName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 7 : 1;
              continue;
            case 15:
              guid = FindComponentService.pbqZmDBFdOsBTyucX6Fi((object) model);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 3;
              continue;
            case 16:
              if (this.FindComponent(model.ItemUid, FindComponentService.vfO5wYBFrkyDXxYc8S0I((object) model), FindComponentService.vfO5wYBFrkyDXxYc8S0I((object) model), guid, (IEnumerable<ComponentDependency>) model.ComponentDependencies, searchContext))
              {
                num2 = 11;
                continue;
              }
              goto case 8;
            case 17:
              goto label_45;
            case 18:
              goto label_46;
            case 19:
              searchContext.Errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886589671), (object) componentName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
              continue;
          }
label_30:
          ((FindComponentOptions) FindComponentService.lTCXFgzmDwbANeh2YWG((object) searchContext)).ViewMode = InterfaceBuilderViewMode.Runtime;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 13 : 16;
        }
label_6:
        vertex = (ComponentGraph.Vertex) FindComponentService.f7OjbUBFJtFSCSk1JvW9(FindComponentService.cKHlxVzcgw9q1aIwTx5((object) searchContext), guid, FindComponentService.vfO5wYBFrkyDXxYc8S0I((object) model), Guid.Empty, false);
        num1 = 2;
        continue;
label_46:
        enumerator1 = functionModels.GetEnumerator();
        num1 = 13;
      }
label_47:
      return;
label_5:
      return;
label_4:
      return;
label_45:;
    }

    internal static bool GJVOnczTaR8Vx1UiM5r() => FindComponentService.P0XQefzXow7msOjblcG == null;

    internal static FindComponentService ny0295zkI79qcRsEqK3() => FindComponentService.P0XQefzXow7msOjblcG;

    internal static int ehvH7RznYpL4PA3dcfB([In] object obj0) => ((HashSet<Guid>) obj0).Count;

    internal static void a1VJ1AzO2HAIBOnZwkj([In] object obj0, int timeout, [In] object obj2) => ((ISession) obj0).ExecuteWithTimeout(timeout, (System.Action) obj2);

    internal static bool Xtuo5mz2tWrRwGmUMM2([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void OvaV7SzejkY4BOybd2x([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object bJZRQIzPaXpi6pREbbm([In] object obj0) => (object) ((ComponentMetadataItemWrapper) obj0).Signature;

    internal static Guid bwoDqGz1JjsA7K0CQeq([In] object obj0) => ((CustomTypeImplementationModel) obj0).TypeUid;

    internal static void SEdqeFzN2Wids1PlI5K([In] object obj0, Guid value) => ((CustomTypeModel) obj0).TypeUid = value;

    internal static bool Tpq3Slz3nJ8ch1Jm4Y6([In] object obj0) => ((CustomTypeImplementationModel) obj0).IsCollection;

    internal static void kmWlLozpIDaOhPsyqEK([In] object obj0, bool value) => ((CustomTypeModel) obj0).IsCollection = value;

    internal static Guid A3K5WQza9pDvO3NWvq1([In] object obj0) => ((ComponentMetadataItemWrapper) obj0).Uid;

    internal static void vFLZn2zDunAfWQQI5BK([In] object obj0, Guid value) => ((CustomTypeModel) obj0).ItemUid = value;

    internal static object iMlyy1ztkAWCr8rEdWj([In] object obj0) => (object) ((ModuleVersion) obj0).Metadata;

    internal static object CvRW6lzwwq0EQ5KXDKY([In] object obj0) => (object) ((ComponentMetadata) obj0).CustomTypeImplementation;

    internal static void BJfHPkz4usOYVkh496y([In] object obj0, Guid value) => ((CustomTypeModel) obj0).SubTypeUid = value;

    internal static void UCkqCpz6l2NnPWwCrjt([In] object obj0, Guid value) => ((CustomTypeModel) obj0).HeaderUid = value;

    internal static void hHaIsgzHbTKOkWBZkvL([In] object obj0, Guid value) => ((CustomTypeModel) obj0).ModuleUid = value;

    internal static Guid zhf61FzAs08ZdStq71m([In] object obj0) => ((ModuleVersionHeader) obj0).VersionUid;

    internal static int n3qm1lz7Myf3kxLsn3P([In] object obj0) => ((List<ComponentMetadataItemWrapper>) obj0).Count;

    internal static object GxSR99zx3ss5c8h2MMw([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object MTyav2z0mMKCuXrTiIo([In] object obj0) => (object) ((ICleanUIObjectsModel) obj0).Modules;

    internal static object lTCXFgzmDwbANeh2YWG([In] object obj0) => (object) ((FindComponentService.SearchContext) obj0).Options;

    internal static int Er7FNezy60ZGrjl8Cre([In] object obj0) => ((List<ItemRuntimeModel>) obj0).Count;

    internal static Guid OLpPL4zMhFxCvpk9kMd([In] object obj0) => ((ItemRuntimeModel) obj0).ItemUid;

    internal static void M82BL7zJJj9ytsx4xAS([In] object obj0, Guid value) => ((ClientComponentModel) obj0).ModuleItemUid = value;

    internal static Guid NBVX77z9qIdCwXt3ICf([In] object obj0) => ((ItemRuntimeModel) obj0).HeaderUid;

    internal static object vHy53qzduNL4la1OiPP([In] object obj0, Guid moduleUid, Guid versionUid) => (object) ((IModuleMetadataLoader) obj0).GetSpecificModuleVersion(moduleUid, versionUid);

    internal static Guid x23RTCzl072F9mR0SP8([In] object obj0) => ((ModuleReference) obj0).ModuleUid;

    internal static object PC0R82zrUHU2qMy6Gg0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static InterfaceBuilderViewMode RQgC0czgFSWQ4XvqAxr([In] object obj0) => ((FindComponentOptions) obj0).ViewMode;

    internal static object QOMAZEz50QRLoH9oiWM([In] object obj0) => (object) ((ComponentMetadataItemHeader) obj0).Emulation;

    internal static object z3Gya3zjOeKvblRLCEF([In] object obj0) => (object) ((ComponentMetadataItemHeader) obj0).Published;

    internal static object DFASlozYEBdlcbhTFVo([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static Guid sjUd4ZzLHZM6ksBmvHP([In] object obj0) => ((ComponentMetadataItem) obj0).Uid;

    internal static object BcBEmvzUHSE6Hf3AR79([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static int vKChURzsrUf3vkTTcIY([In] object obj0) => ((List<string>) obj0).Count;

    internal static object cKHlxVzcgw9q1aIwTx5([In] object obj0) => (object) ((FindComponentService.SearchContext) obj0).ComponentGraph;

    internal static Guid EKWac9zzFvThoYiiFo5([In] object obj0) => ((ComponentGraph.Vertex) obj0).ItemUid;

    internal static void gHf6qOBFF83pESH2yeSb([In] object obj0, Guid value) => ((ClientComponentModel) obj0).ItemUid = value;

    internal static bool q4h85NBFBxYqKkIqQqF1([In] object obj0) => ((ComponentGraph.Vertex) obj0).Async;

    internal static void aJiRH2BFWqD71eFO0MDW([In] object obj0, bool value) => ((ClientComponentModel) obj0).Async = value;

    internal static Guid JjPtnYBFoMWBXtGgW9M3([In] object obj0) => ((ClientFunctionModel) obj0).HeaderUid;

    internal static void uir9COBFbdBxBXhvM3Cg([In] object obj0, InterfaceBuilderViewMode value) => ((FindComponentOptions) obj0).ViewMode = value;

    internal static Guid cMLTumBFhHIoYiMbgbG3([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid S8hxbYBFGlZbv2GJuYvK([In] object obj0) => ((EleWise.ELMA.Model.Dependencies.Dependency) obj0).HeaderUid;

    internal static bool SODVc5BFE1jGqDmIIqZJ([In] object obj0) => ((ClientComponentModel) obj0).Async;

    internal static Guid KQ588fBFfP6HcAVOGSkp([In] object obj0) => ((ClientDataClassModel) obj0).HeaderUid;

    internal static int sDdEm3BFQbJHm5tfqV9U([In] object obj0) => ((Dictionary<Guid, ClientComponentModel>) obj0).Count;

    internal static void GhjFjEBFCndCXlt42s75([In] object obj0) => ((List<string>) obj0).Reverse();

    internal static object OnTNHEBFvIM8M49ecnRy() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void qAo95vBF8H25WWCSTQYN([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static Guid MeY255BFZT4ltNIPAYVj([In] object obj0) => ((ClientComponentModel) obj0).ModuleItemUid;

    internal static void In1G9QBFu5mGyHOPsJhK([In] object obj0, [In] object obj1) => ((RecursiveComponentModel) obj0).Header = (ClientComponentModel) obj1;

    internal static bool SHwxCpBFI8kUKZhtBG8g([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid E9tAxZBFV0HgOdgjNQ3I([In] object obj0) => ((ClientComponentModel) obj0).ItemUid;

    internal static Guid MJd4j0BFSxyqrmO88VXq([In] object obj0) => ((ClientComponentModel) obj0).ModuleUid;

    internal static Guid DrepmcBFiXaxOYhG0UYT([In] object obj0) => ((ClientFunctionModel) obj0).ModuleItemUid;

    internal static Guid RoQqCaBFRmwxZQEEr95e([In] object obj0) => ((CustomTypeModel) obj0).ItemUid;

    internal static Guid anstrnBFq6qDS1uSunmG([In] object obj0) => ((ClientImplementationModel) obj0).ItemUid;

    internal static Guid u9VTAiBFKr2hcEsUT9CQ([In] object obj0) => ((ClientImplementationModel) obj0).ModuleItemUid;

    internal static Guid zZ5tqXBFXc8CW3jfJJC3([In] object obj0) => ((ClientImplementationModel) obj0).ModuleUid;

    internal static object nlTaJcBFT5Ie2t4OOk9o([In] object obj0) => ((ComponentMetadataItem) obj0).Signature;

    internal static object Myq9P5BFkln6ljxvfiBh([In] object obj0) => (object) ((ModuleVersionHeader) obj0).Signature;

    internal static Guid YxYSFPBFnmNjPCHUXxcv([In] object obj0) => ((ComponentMetadataItemWrapper) obj0).HeaderUid;

    internal static object wyDj5JBFOvUp3aNhic5o([In] object obj0) => (object) ((ModuleVersion) obj0).Header;

    internal static object ar2MpGBF2WR9Iqk4CT2u(
      [In] object obj0,
      Guid headerUid,
      Guid itemUid,
      Guid moduleUid,
      Guid parent,
      [In] object obj5,
      Guid owner,
      bool async)
    {
      return (object) ((ComponentGraph) obj0).AddVertex(headerUid, itemUid, moduleUid, parent, (string) obj5, owner, async);
    }

    internal static Guid o91ZZ6BFe7tmdgKxfgXN([In] object obj0) => ((ComponentGraph.Vertex) obj0).ModuleUid;

    internal static void n8FEILBFPLdNFpd5yqyN([In] object obj0, Guid value) => ((ClientComponentModel) obj0).ModuleUid = value;

    internal static Guid OMUDSfBF1aZmZMxuFVxw([In] object obj0) => ((LinkToModule) obj0).ModuleUid;

    internal static bool PjqLdUBFN5nTFGxfWBq3([In] object obj0, Guid moduleUid) => ((IModuleMetadataLoader) obj0).IsSystemModule(moduleUid);

    internal static Guid TRRkqPBF3DeBYb8ZFdtB([In] object obj0) => ((FindComponentService.CandidateDependModule) obj0).ModuleItemUid;

    internal static Guid eHcW1YBFpwFvr1R4vjtR([In] object obj0) => ((FindComponentService.CandidateDependModule) obj0).HeaderUid;

    internal static void lCITBgBFaM1sJH8Ic0xa([In] object obj0, [In] object obj1) => ((FindComponentService.CandidateDependModule) obj0).Version = (Version) obj1;

    internal static void MjCaSABFDI60LPKqXDpH([In] object obj0, bool value) => ((FindComponentService.CandidateDependModule) obj0).Valid = value;

    internal static int dEdIiqBFtxAsy0SKVqNc([In] object obj0) => ((List<FindComponentService.CandidateDependModule>) obj0).Count;

    internal static int ctifHNBFwwoa6iudFPtk([In] object obj0) => ((HashSet<FindComponentService.CandidateDependModule>) obj0).Count;

    internal static int bxgLweBF4alAQMvkIPkO([In] object obj0) => ((Dictionary<Guid, ClientComponentModel>.ValueCollection) obj0).Count;

    internal static bool zxK5JxBF6vqpPYmhsZoS([In] object obj0) => ((FindComponentOptions) obj0).CheckCompatibility;

    internal static object uJ6ZVgBFHGWZftlNPcOQ([In] object obj0) => (object) ((ModuleInfoMetadata) obj0).Dependency;

    internal static bool biNyKKBFAH2ZLqXDRfMf([In] object obj0) => ((CompatibilityResult) obj0).IsValid;

    internal static Guid g6LHQuBF76gEdOIm0C5X([In] object obj0) => ((ModuleVersionHeader) obj0).HeaderUid;

    internal static void YLGZ44BFxB4FuA8IiUUQ([In] object obj0, Guid value) => ((FindComponentService.CandidateDependModule) obj0).HeaderUid = value;

    internal static void RMP0R2BF0y2Fdpy2KsiU([In] object obj0, Guid value) => ((FindComponentService.CandidateDependModule) obj0).ModuleItemUid = value;

    internal static object LXTnMLBFmiUQfSubUX0W([In] object obj0) => (object) ((ModuleVersionHeader) obj0).Version;

    internal static bool aSCXe9BFynUJVFOkKp78([In] object obj0) => ((FindComponentService.CandidateDependModule) obj0).Valid;

    internal static Guid uUi5StBFMCssTCDkHA2T([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static object f7OjbUBFJtFSCSk1JvW9(
      [In] object obj0,
      Guid headerUid,
      Guid itemUid,
      Guid moduleUid,
      bool async)
    {
      return (object) ((ComponentGraph) obj0).AddHeadVertex(headerUid, itemUid, moduleUid, async);
    }

    internal static bool XYMrWbBF9tQNR5t8Wiok([In] object obj0) => ((FindComponentOptions) obj0).CacheResult;

    internal static Guid pbqZmDBFdOsBTyucX6Fi([In] object obj0) => ((ObjectFormFindComponentModel) obj0).MetadataUid;

    internal static object F0eBFgBFltXsWqDlFFQT([In] object obj0) => (object) ((RecursiveComponentModel) obj0).Header;

    internal static Guid vfO5wYBFrkyDXxYc8S0I([In] object obj0) => ((ObjectFormFindComponentModel) obj0).ItemUid;

    internal static object IMOPrgBFgciaGhbEpB3c([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void LsVbNKBF55JDN8n02vIg([In] object obj0) => ((HashSet<Guid>) obj0).Clear();

    internal static void iooQkoBFjwiNesIufA6I([In] object obj0) => ((FindComponentService.SearchContext) obj0).Clear();

    internal static object iOJgvJBFYRfKgNOAL24x([In] object obj0) => (object) ((ObjectFormFindComponentModel) obj0).MetadataDisplayName;

    internal static object ql646BBFLR5BP1kDsgj2([In] object obj0) => (object) ((ObjectFormFindComponentModel) obj0).Form;

    internal static object B1upWEBFUphXlqLMPgfk([In] object obj0) => (object) ((FormViewItem) obj0).DisplayName;

    internal static object xVcZMkBFsklcoOtoitoL([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    /// <summary>Зависимый модуль-кандидат</summary>
    internal class CandidateDependModule
    {
      private static FindComponentService.CandidateDependModule dCtnEafsLUWIW00YptIV;

      /// <summary>Ctor</summary>
      public CandidateDependModule()
      {
        FindComponentService.CandidateDependModule.P0aZxJfscVXeEaaIdxnI();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.Owners = new HashSet<Guid>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <summary>Обладатели</summary>
      public HashSet<Guid> Owners { get; set; }

      /// <summary>Подходит ли версия</summary>
      public bool Valid
      {
        get => this.\u003CValid\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CValid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Уникальный идентификатор версии</summary>
      public Guid ModuleItemUid
      {
        get => this.\u003CModuleItemUid\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CModuleItemUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Уникальный идентификатор заголовка</summary>
      public Guid HeaderUid
      {
        get => this.\u003CHeaderUid\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CHeaderUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Версия</summary>
      public Version Version
      {
        get => this.\u003CVersion\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CVersion\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public override int GetHashCode()
      {
        int num = 1;
        Guid headerUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              headerUid = this.HeaderUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return headerUid.GetHashCode() ^ this.ModuleItemUid.GetHashCode() ^ this.Valid.GetHashCode() ^ (FindComponentService.CandidateDependModule.DntiP5fszCkSoAav3MLD((object) this.Version, (object) null) ? this.Version.GetHashCode() : 0);
      }

      /// <inheritdoc />
      public override bool Equals(object obj)
      {
        int num = 3;
        FindComponentService.CandidateDependModule candidateDependModule;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_13;
            case 2:
              if (candidateDependModule != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 4 : 0;
                continue;
              }
              goto label_9;
            case 3:
              candidateDependModule = obj as FindComponentService.CandidateDependModule;
              num = 2;
              continue;
            case 4:
              if (FindComponentService.CandidateDependModule.CCD3WCfcFMGks0KjFaY4(this.HeaderUid, candidateDependModule.HeaderUid))
              {
                num = 7;
                continue;
              }
              goto label_13;
            case 5:
              goto label_9;
            case 6:
              if (this.Valid == FindComponentService.CandidateDependModule.ymRLfpfcWHk3q9DsT5kt((object) candidateDependModule))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 7:
              if (!FindComponentService.CandidateDependModule.CCD3WCfcFMGks0KjFaY4(this.ModuleItemUid, FindComponentService.CandidateDependModule.TVHfmbfcBrGlpqmgjfBu((object) candidateDependModule)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
                continue;
              }
              goto case 6;
            default:
              goto label_12;
          }
        }
label_9:
        return false;
label_12:
        return FindComponentService.CandidateDependModule.uXF2Glfcb96v7pt2jMry((object) this.Version, FindComponentService.CandidateDependModule.DjKdkwfco2RL9WIQZ4s8((object) candidateDependModule));
label_13:
        return false;
      }

      internal static void P0aZxJfscVXeEaaIdxnI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool yVwAvPfsUUFDEkrtgQ1Q() => FindComponentService.CandidateDependModule.dCtnEafsLUWIW00YptIV == null;

      internal static FindComponentService.CandidateDependModule lHWVx5fssBBnSuqcpdhV() => FindComponentService.CandidateDependModule.dCtnEafsLUWIW00YptIV;

      internal static bool DntiP5fszCkSoAav3MLD([In] object obj0, [In] object obj1) => (Version) obj0 != (Version) obj1;

      internal static bool CCD3WCfcFMGks0KjFaY4([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

      internal static Guid TVHfmbfcBrGlpqmgjfBu([In] object obj0) => ((FindComponentService.CandidateDependModule) obj0).ModuleItemUid;

      internal static bool ymRLfpfcWHk3q9DsT5kt([In] object obj0) => ((FindComponentService.CandidateDependModule) obj0).Valid;

      internal static object DjKdkwfco2RL9WIQZ4s8([In] object obj0) => (object) ((FindComponentService.CandidateDependModule) obj0).Version;

      internal static bool uXF2Glfcb96v7pt2jMry([In] object obj0, [In] object obj1) => (Version) obj0 == (Version) obj1;
    }

    /// <summary>Контекст поиска</summary>
    internal sealed class SearchContext
    {
      private readonly FindComponentOptions originalOptions;
      private FindComponentOptions options;
      internal static FindComponentService.SearchContext D883qefchvEpHKEWr1hH;

      /// <summary>Ctor</summary>
      /// <param name="options">Опции поиска</param>
      internal SearchContext(FindComponentOptions options)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num1 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
          num1 = 3;
        while (true)
        {
          int num2;
          switch (num1)
          {
            case 1:
              this.Functions = new Dictionary<Guid, ClientFunctionModel>();
              num1 = 22;
              continue;
            case 2:
              this.CacheIncludeDataClasses = new Dictionary<Guid, Dictionary<Guid, ClientDataClassModel>>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 5;
              continue;
            case 3:
              if (options != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 24 : 23;
                continue;
              }
              goto case 4;
            case 4:
              options = new FindComponentOptions();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 19 : 18;
              continue;
            case 5:
              this.Errors = new List<string>();
              num2 = 16;
              break;
            case 6:
              this.CacheLastPublishedDataClasses = new List<DataClassMetadataItem>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 21 : 14;
              continue;
            case 7:
              this.AllModules = new HashSet<Guid>();
              num2 = 17;
              break;
            case 8:
              this.CustomTypes = new List<CustomTypeModel>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 12 : 5;
              continue;
            case 9:
              this.LoadedModuleHeaders = new Dictionary<Guid, ModuleMetadataItemHeader>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            case 10:
              this.CandidateDependencies = new Dictionary<Guid, HashSet<Guid>>();
              num1 = 8;
              continue;
            case 11:
              this.Components = new Dictionary<Guid, ClientComponentModel>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 12 : 14;
              continue;
            case 12:
              this.CacheTypeLastPublishedComponents = new List<ComponentMetadataItemWrapper>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 4 : 18;
              continue;
            case 13:
              this.options = (FindComponentOptions) FindComponentService.SearchContext.XWTKZbfcfJnlClqdPC0u((object) options);
              num1 = 23;
              continue;
            case 14:
              this.DataClasses = new Dictionary<Guid, ClientDataClassModel>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
              continue;
            case 15:
              this.ChosenModules = new HashSet<Guid>();
              num1 = 7;
              continue;
            case 16:
              goto label_30;
            case 17:
              this.ChosenComponentModules = new Dictionary<Guid, ClientComponentModel>();
              num1 = 20;
              continue;
            case 18:
              this.CacheTypeModules = new List<ModuleVersion>();
              num1 = 28;
              continue;
            case 19:
            case 24:
              this.originalOptions = options;
              num1 = 13;
              continue;
            case 20:
              this.IncompatibleModuleItems = new HashSet<Guid>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 10;
              continue;
            case 21:
              this.CacheRuntimeModules = new List<ModuleVersion>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 4 : 25;
              continue;
            case 22:
              this.ModuleVersions = new Dictionary<Guid, IEnumerable<ModuleVersionHeader>>();
              num2 = 26;
              break;
            case 23:
              this.ComponentGraph = new ComponentGraph();
              num2 = 11;
              break;
            case 25:
              this.CacheImplementationModules = new List<ModuleVersion>();
              num1 = 2;
              continue;
            case 26:
              this.ComponentVersions = new Dictionary<Guid, IEnumerable<ComponentMetadataItemWrapper>>();
              num1 = 9;
              continue;
            case 27:
              this.CacheLastPublishedComponents = new List<ComponentMetadataItemWrapper>();
              num1 = 6;
              continue;
            case 28:
              this.ExtensionPoints = new List<ClientExtensionPointModel>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 27 : 24;
              continue;
            default:
              this.CandidateModules = new Dictionary<Guid, List<FindComponentService.CandidateDependModule>>();
              num1 = 15;
              continue;
          }
          num1 = num2;
        }
label_30:;
      }

      /// <summary>Настройки поиска</summary>
      internal FindComponentOptions Options
      {
        get
        {
          int num = 2;
          FindComponentOptions options1;
          FindComponentOptions options2;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.options = options1 = (FindComponentOptions) FindComponentService.SearchContext.XWTKZbfcfJnlClqdPC0u((object) this.originalOptions);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                continue;
              case 2:
                options2 = this.options;
                if (options2 == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                  continue;
                }
                goto label_2;
              default:
                goto label_6;
            }
          }
label_2:
          return options2;
label_6:
          return options1;
        }
      }

      /// <summary>Граф компонентов</summary>
      internal ComponentGraph ComponentGraph { get; }

      /// <summary>Список вычисленных моделей компонентов</summary>
      internal Dictionary<Guid, ClientComponentModel> Components { get; }

      /// <summary>Список вычисленных моделей структур обмена данными</summary>
      internal Dictionary<Guid, ClientDataClassModel> DataClasses { get; }

      /// <summary>Список вычисленных моделей функций</summary>
      internal Dictionary<Guid, ClientFunctionModel> Functions { get; }

      /// <summary>Кеш загруженных оберток над метаданными модулей</summary>
      internal Dictionary<Guid, IEnumerable<ModuleVersionHeader>> ModuleVersions { get; }

      /// <summary>Кеш загруженных оберток над метаданными компонентов</summary>
      internal Dictionary<Guid, IEnumerable<ComponentMetadataItemWrapper>> ComponentVersions { get; }

      /// <summary>Кеш загруженных заголовков</summary>
      internal Dictionary<Guid, ModuleMetadataItemHeader> LoadedModuleHeaders { get; }

      /// <summary>Список кандидатов</summary>
      internal Dictionary<Guid, List<FindComponentService.CandidateDependModule>> CandidateModules { get; }

      /// <summary>Выбранные модели компонентов модулей</summary>
      internal Dictionary<Guid, ClientComponentModel> ChosenComponentModules { get; }

      /// <summary>
      /// Кандидаты по зависимостям, которые подходили к определенной зависимости
      /// </summary>
      internal Dictionary<Guid, HashSet<Guid>> CandidateDependencies { get; }

      /// <summary>Несовместимые версии модулей</summary>
      internal HashSet<Guid> IncompatibleModuleItems { get; }

      /// <summary>Выбранные модули (ModuleUid)</summary>
      internal HashSet<Guid> ChosenModules { get; }

      /// <summary>Все модули (ModuleUid), найденные в выборке</summary>
      internal HashSet<Guid> AllModules { get; }

      /// <summary>Ошибки</summary>
      internal List<string> Errors { get; }

      /// <summary>Список найденых точек расширения</summary>
      internal List<ClientExtensionPointModel> ExtensionPoints { get; set; }

      /// <summary>Список кастомных компонентов</summary>
      internal List<CustomTypeModel> CustomTypes { get; set; }

      /// <summary>
      /// Кеш списка последних опубликованных компонентов конфигурации
      /// Используется при вычислении точек расширения
      /// </summary>
      internal List<ComponentMetadataItemWrapper> CacheLastPublishedComponents { get; set; }

      /// <summary>
      /// Кеш списка последних опубликованных компонентов конфигурации
      /// Используется при вычисления реализаций типов
      /// </summary>
      internal List<ComponentMetadataItemWrapper> CacheTypeLastPublishedComponents { get; set; }

      /// <summary>
      /// Кеш списка последних опубликованных датаклассов конфигурации
      /// Используется при вычислении точек расширения
      /// </summary>
      internal List<DataClassMetadataItem> CacheLastPublishedDataClasses { get; set; }

      /// <summary>
      /// Кеш списка уже загруженных модулей в рантайм + последних опубликованных модулей
      /// Используется при вычислении точек расширения
      /// </summary>
      internal List<ModuleVersion> CacheRuntimeModules { get; set; }

      /// <summary>
      /// Кеш списка модулей, в которых есть реализации точек расширения
      /// Используется при вычислении точек расширения
      /// </summary>
      internal List<ModuleVersion> CacheImplementationModules { get; set; }

      /// <summary>
      /// Кеш списка модулей, в которых есть реализации кастомных типов
      /// </summary>
      internal List<ModuleVersion> CacheTypeModules { get; set; }

      /// <summary>
      /// Кеш списка вложенных датаклассов для текущего
      /// Используется при вычислении точек расширения
      /// </summary>
      internal Dictionary<Guid, Dictionary<Guid, ClientDataClassModel>> CacheIncludeDataClasses { get; set; }

      /// <summary>Очистить контекст перед повторным поиском компонента</summary>
      internal void Clear()
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                FindComponentService.SearchContext.u6W2tlfcSCNDq2Xu57J3((object) this.CacheTypeModules);
                num2 = 9;
                continue;
              case 2:
                FindComponentService.SearchContext.VwmvhWfcQHlc0DCI9dos((object) this.Components);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              case 3:
                this.options = (FindComponentOptions) null;
                num2 = 2;
                continue;
              case 4:
                FindComponentService.SearchContext.VwmvhWfcQHlc0DCI9dos((object) this.ChosenComponentModules);
                num2 = 12;
                continue;
              case 5:
                FindComponentService.SearchContext.KJ9shBfcIn0OWdR0toBr((object) this.CandidateDependencies);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 18 : 7;
                continue;
              case 6:
                this.Errors.Clear();
                num2 = 11;
                continue;
              case 7:
                goto label_8;
              case 8:
                this.CacheIncludeDataClasses.Clear();
                num2 = 6;
                continue;
              case 9:
                FindComponentService.SearchContext.iFAiIBfciPn774WH2Zu5((object) this.CacheLastPublishedComponents);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 10 : 4;
                continue;
              case 10:
                this.CacheLastPublishedDataClasses.Clear();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 16 : 2;
                continue;
              case 11:
                goto label_3;
              case 12:
                FindComponentService.SearchContext.NJA5y4fcuHBgZGtslGZa((object) this.ChosenModules);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 5 : 1;
                continue;
              case 13:
                FindComponentService.SearchContext.TcMEfpfcZsTPbDt8W2Be((object) this.CandidateModules);
                num2 = 4;
                continue;
              case 14:
                this.CacheTypeLastPublishedComponents.Clear();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
                continue;
              case 15:
                FindComponentService.SearchContext.SrQc7OfcvVREl9mhPrNL((object) this.Functions);
                num2 = 17;
                continue;
              case 16:
                FindComponentService.SearchContext.u6W2tlfcSCNDq2Xu57J3((object) this.CacheRuntimeModules);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 6;
                continue;
              case 17:
                FindComponentService.SearchContext.lIhlHJfc8Y9PeGuT5uuK((object) this.ComponentGraph);
                num2 = 13;
                continue;
              case 18:
                FindComponentService.SearchContext.s6c4oTfcVPWU44CP3s78((object) this.CustomTypes);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 14 : 8;
                continue;
              default:
                FindComponentService.SearchContext.D2AuxvfcCOp9yWLJ9Ct7((object) this.DataClasses);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 15 : 5;
                continue;
            }
          }
label_8:
          this.CacheImplementationModules.Clear();
          num1 = 8;
        }
label_3:;
      }

      internal static object XWTKZbfcfJnlClqdPC0u([In] object obj0) => ((FindComponentOptions) obj0).Clone();

      internal static bool nSVduOfcGiSkENNnmBfT() => FindComponentService.SearchContext.D883qefchvEpHKEWr1hH == null;

      internal static FindComponentService.SearchContext esu4YpfcE2kedXEtDZ88() => FindComponentService.SearchContext.D883qefchvEpHKEWr1hH;

      internal static void VwmvhWfcQHlc0DCI9dos([In] object obj0) => ((Dictionary<Guid, ClientComponentModel>) obj0).Clear();

      internal static void D2AuxvfcCOp9yWLJ9Ct7([In] object obj0) => ((Dictionary<Guid, ClientDataClassModel>) obj0).Clear();

      internal static void SrQc7OfcvVREl9mhPrNL([In] object obj0) => ((Dictionary<Guid, ClientFunctionModel>) obj0).Clear();

      internal static void lIhlHJfc8Y9PeGuT5uuK([In] object obj0) => ((ComponentGraph) obj0).Clear();

      internal static void TcMEfpfcZsTPbDt8W2Be([In] object obj0) => ((Dictionary<Guid, List<FindComponentService.CandidateDependModule>>) obj0).Clear();

      internal static void NJA5y4fcuHBgZGtslGZa([In] object obj0) => ((HashSet<Guid>) obj0).Clear();

      internal static void KJ9shBfcIn0OWdR0toBr([In] object obj0) => ((Dictionary<Guid, HashSet<Guid>>) obj0).Clear();

      internal static void s6c4oTfcVPWU44CP3s78([In] object obj0) => ((List<CustomTypeModel>) obj0).Clear();

      internal static void u6W2tlfcSCNDq2Xu57J3([In] object obj0) => ((List<ModuleVersion>) obj0).Clear();

      internal static void iFAiIBfciPn774WH2Zu5([In] object obj0) => ((List<ComponentMetadataItemWrapper>) obj0).Clear();
    }
  }
}
