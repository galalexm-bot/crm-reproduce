// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.DependencyFinders.CatalogDependencyFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Components.Dependency;
using EleWise.ELMA.UI.Components.Dependency.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components.DependencyFinders
{
  /// <summary>Компонент поиска зависимостей по справочникам</summary>
  [Component]
  internal sealed class CatalogDependencyFinder : IDependencyFinder
  {
    private readonly ISessionProvider sessionProvider;
    private static CatalogDependencyFinder Du9ixlfES9UMW42y9cu7;

    private ISession Session => (ISession) CatalogDependencyFinder.GShQF3fEq48U84QZKTlU((object) this.sessionProvider, (object) string.Empty);

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public CatalogDependencyFinder(ISessionProvider sessionProvider)
    {
      CatalogDependencyFinder.l5o5IlfEKEaDsXH3OUTK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> GetDependencies(
      IEnumerable<IDependencyRequest> dependencyRequests)
    {
      IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> first = Enumerable.Empty<EleWise.ELMA.Model.Dependencies.Dependency>();
      if (!dependencyRequests.Any<IDependencyRequest>())
        return first;
      ICollection<CatalogDependencyFinder.DependencyWithScriptModule> dependenciesWithScriptModulesList = (ICollection<CatalogDependencyFinder.DependencyWithScriptModule>) null;
      this.Session.ExecuteWithTimeout(0, (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
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
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              dependenciesWithScriptModulesList = (ICollection<CatalogDependencyFinder.DependencyWithScriptModule>) ((ICriteria) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WSF2Ht8l0BxMkuDmVgpB(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.zJNGiD8lA4QB2hii85Ny((object) ((ICriteria) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.vA0DE88l6m8cRoIMB0qx(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.vA0DE88l6m8cRoIMB0qx(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.UDuF4G8l4tmAO8TFqQDF((object) this.Session.CreateCriteria<IMetadataItemHeader>(), CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(874012245 ^ 874127567), CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(589593376 ^ -1977315327 ^ -1459167175)), CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(322893104 - -1992822529 ^ -1979190623), CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(1917256330 ^ 1916956354)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16733391), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138603608))).Add((ICriterion) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WG5pA68lHm9GRJJPCc80(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-649342099 - -1150814748 ^ 501386721))), CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WG5pA68lHm9GRJJPCc80(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(1470440286 ^ 1470486152))), (object) new IProjection[3]
              {
                (IProjection) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.wPLaZZ8l7JtuDxq6TRPS((object) Projections.Property((string) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-882126494 ^ -881993150)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61113735)),
                (IProjection) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.wPLaZZ8l7JtuDxq6TRPS(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.ih111S8lxj4E8hA84MKA((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757337956)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 396927152)),
                Projections.Alias((IProjection) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.ih111S8lxj4E8hA84MKA(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(222162814 ^ 221807606)), (string) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(1581325282 << 3 ^ -233983096))
              })).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (CatalogDependencyFinder.DependencyWithScriptModule))).List<CatalogDependencyFinder.DependencyWithScriptModule>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      foreach (CatalogDependencyFinder.DependencyWithScriptModule withScriptModule in (IEnumerable<CatalogDependencyFinder.DependencyWithScriptModule>) dependenciesWithScriptModulesList)
      {
        MetadataDependencyContainer dependencies = withScriptModule.Dependencies;
        foreach (IDependencyRequest dependencyRequest in dependencyRequests)
        {
          Guid moduleUid = dependencyRequest.ModuleUid;
          // ISSUE: reference to a compiler-generated method
          IEnumerable<FunctionDependency> second1 = dependencies.FunctionDependencies.Where<FunctionDependency>((Func<FunctionDependency, bool>) (a => CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_1.SOmOkm8ldZKfLCiHfxq2((object) a) == moduleUid));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          IEnumerable<DataClassDependency> second2 = dependencies.DataClassDependencies.Where<DataClassDependency>((Func<DataClassDependency, bool>) (a => CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_1.eJTNka8llOZ09OUtjHhc(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_1.SOmOkm8ldZKfLCiHfxq2((object) a), moduleUid)));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> second3 = dependencies.FormDependencies.SelectMany<FormViewItemDependencyContainer, EleWise.ELMA.Model.Dependencies.Dependency>((Func<FormViewItemDependencyContainer, IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>>) (a => ((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) a.ComponentDependencies.Where<ComponentDependency>((Func<ComponentDependency, bool>) (c => c.ModuleUid == moduleUid))).Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) a.DataClassDependencies.Where<DataClassDependency>((Func<DataClassDependency, bool>) (d => CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_1.eJTNka8llOZ09OUtjHhc(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_1.SOmOkm8ldZKfLCiHfxq2((object) d), moduleUid))))));
          first = first.Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second1).Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second2).Concat<EleWise.ELMA.Model.Dependencies.Dependency>(second3);
        }
      }
      ICollection<ScriptModuleDependencyContainer> serverScriptModuleDependencyContainers = (ICollection<ScriptModuleDependencyContainer>) null;
      this.Session.ExecuteWithTimeout(0, (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              ICriteria criteria = this.Session.CreateCriteria<ScriptModule>();
              // ISSUE: reference to a compiler-generated method
              object obj = CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(~210725948 ^ -210759011);
              ICollection<CatalogDependencyFinder.DependencyWithScriptModule> source = dependenciesWithScriptModulesList;
              // ISSUE: reference to a compiler-generated field
              Func<CatalogDependencyFinder.DependencyWithScriptModule, long> func = CatalogDependencyFinder.\u003C\u003Ec.\u003C\u003E9__4_8;
              Func<CatalogDependencyFinder.DependencyWithScriptModule, long> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                CatalogDependencyFinder.\u003C\u003Ec.\u003C\u003E9__4_8 = selector = (Func<CatalogDependencyFinder.DependencyWithScriptModule, long>) (s => CatalogDependencyFinder.\u003C\u003Ec.o964AS8lYw7rfWfnNtbd((object) s));
              }
              else
                goto label_7;
label_6:
              long[] array = source.Select<CatalogDependencyFinder.DependencyWithScriptModule, long>(selector).ToArray<long>();
              // ISSUE: reference to a compiler-generated method
              object expression = CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.wrOcvx8lmlDGtKsetDwT(obj, (object) array);
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              serverScriptModuleDependencyContainers = (ICollection<ScriptModuleDependencyContainer>) ((ICriteria) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WSF2Ht8l0BxMkuDmVgpB((object) criteria.Add((ICriterion) expression).Add((ICriterion) Restrictions.IsNotNull((string) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-1445902765 ^ -1980277732 ^ 539445799))), (object) new IProjection[1]
              {
                (IProjection) Projections.Property((string) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-1350312861 << 3 ^ 2082452336))
              })).List<ScriptModuleDependencyContainer>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
label_7:
              selector = func;
              goto label_6;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }));
      ICollection<ScriptModuleDependencyContainer> clientScriptModuleDependencyContainers = (ICollection<ScriptModuleDependencyContainer>) null;
      this.Session.ExecuteWithTimeout(0, (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              ICriteria criteria = this.Session.CreateCriteria<ScriptModule>();
              // ISSUE: reference to a compiler-generated method
              object obj1 = CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(381945751 ^ 1158627804 ^ 1405863701);
              ICollection<CatalogDependencyFinder.DependencyWithScriptModule> source = dependenciesWithScriptModulesList;
              // ISSUE: reference to a compiler-generated field
              Func<CatalogDependencyFinder.DependencyWithScriptModule, long> func = CatalogDependencyFinder.\u003C\u003Ec.\u003C\u003E9__4_9;
              Func<CatalogDependencyFinder.DependencyWithScriptModule, long> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                CatalogDependencyFinder.\u003C\u003Ec.\u003C\u003E9__4_9 = selector = (Func<CatalogDependencyFinder.DependencyWithScriptModule, long>) (s => s.ClientScriptModuleId);
              }
              else
                goto label_7;
label_6:
              long[] array = source.Select<CatalogDependencyFinder.DependencyWithScriptModule, long>(selector).ToArray<long>();
              // ISSUE: reference to a compiler-generated method
              object obj2 = CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.wrOcvx8lmlDGtKsetDwT(obj1, (object) array);
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              clientScriptModuleDependencyContainers = (ICollection<ScriptModuleDependencyContainer>) ((ICriteria) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WSF2Ht8l0BxMkuDmVgpB(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.zJNGiD8lA4QB2hii85Ny(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.zJNGiD8lA4QB2hii85Ny((object) criteria, obj2), CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WG5pA68lHm9GRJJPCc80((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210648149))), (object) new IProjection[1]
              {
                (IProjection) CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.ih111S8lxj4E8hA84MKA(CatalogDependencyFinder.\u003C\u003Ec__DisplayClass4_0.pPjUuf8lw17wqkSJAHM2(-70007027 ^ -70084763))
              })).List<ScriptModuleDependencyContainer>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
label_7:
              selector = func;
              goto label_6;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }));
      IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> second4 = CatalogDependencyFinder.ScriptModuleDependencies((IEnumerable<ScriptModuleDependencyContainer>) serverScriptModuleDependencyContainers, dependencyRequests);
      IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> second5 = CatalogDependencyFinder.ScriptModuleDependencies((IEnumerable<ScriptModuleDependencyContainer>) clientScriptModuleDependencyContainers, dependencyRequests);
      return first.Concat<EleWise.ELMA.Model.Dependencies.Dependency>(second4).Concat<EleWise.ELMA.Model.Dependencies.Dependency>(second5);
    }

    private static IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> ScriptModuleDependencies(
      IEnumerable<ScriptModuleDependencyContainer> scriptModuleDependencyContainers,
      IEnumerable<IDependencyRequest> dependencyRequests)
    {
      IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> first = Enumerable.Empty<EleWise.ELMA.Model.Dependencies.Dependency>();
      foreach (ScriptModuleDependencyContainer dependencyContainer in scriptModuleDependencyContainers)
      {
        foreach (IDependencyRequest dependencyRequest in dependencyRequests)
        {
          Guid moduleUid = dependencyRequest.ModuleUid;
          // ISSUE: reference to a compiler-generated method
          IEnumerable<DataClassDependency> second = dependencyContainer.DataClassDependencies.Where<DataClassDependency>((Func<DataClassDependency, bool>) (a => CatalogDependencyFinder.\u003C\u003Ec__DisplayClass6_0.P0bLB98lz0VjqbhDCvPe((object) a) == moduleUid));
          first = first.Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second);
        }
      }
      return first;
    }

    internal static object GShQF3fEq48U84QZKTlU([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static bool oHyN0kfEiEgGuvIJawSj() => CatalogDependencyFinder.Du9ixlfES9UMW42y9cu7 == null;

    internal static CatalogDependencyFinder tbDSvafERSCo6Bt72HmS() => CatalogDependencyFinder.Du9ixlfES9UMW42y9cu7;

    internal static void l5o5IlfEKEaDsXH3OUTK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class DependencyWithScriptModule
    {
      internal static object vtTciw8lNQN1WCCOvvjq;

      public MetadataDependencyContainer Dependencies
      {
        get => this.\u003CDependencies\u003Ek__BackingField;
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
                this.\u003CDependencies\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

      public long ClientScriptModuleId
      {
        get => this.\u003CClientScriptModuleId\u003Ek__BackingField;
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
                this.\u003CClientScriptModuleId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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

      public long ScriptModuleId
      {
        get => this.\u003CScriptModuleId\u003Ek__BackingField;
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
                this.\u003CScriptModuleId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

      public DependencyWithScriptModule()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool inwa1R8l3auRTCZIcYiW() => CatalogDependencyFinder.DependencyWithScriptModule.vtTciw8lNQN1WCCOvvjq == null;

      internal static CatalogDependencyFinder.DependencyWithScriptModule WkSGsc8lprZOvgh1qfxc() => (CatalogDependencyFinder.DependencyWithScriptModule) CatalogDependencyFinder.DependencyWithScriptModule.vtTciw8lNQN1WCCOvvjq;
    }
  }
}
