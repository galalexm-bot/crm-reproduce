// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Components.Dependency.ComponentDependencyFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Components.Dependency.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Components.Dependency
{
  /// <summary>Компонент поиска зависимостей по компонентам</summary>
  [Component]
  internal sealed class ComponentDependencyFinder : IDependencyFinder
  {
    private readonly ISessionProvider sessionProvider;
    internal static ComponentDependencyFinder Tvn3vlBuEtSKCyquoPG8;

    private ISession Session => (ISession) ComponentDependencyFinder.lghD42BuCKPQ8v9qb10s((object) this.sessionProvider, (object) string.Empty);

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public ComponentDependencyFinder(ISessionProvider sessionProvider)
    {
      ComponentDependencyFinder.EjNHrnBuvkYK1e4QqZru();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> GetDependencies(
      IEnumerable<IDependencyRequest> dependencyRequests)
    {
      IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> first = Enumerable.Empty<EleWise.ELMA.Model.Dependencies.Dependency>();
      if (!dependencyRequests.Any<IDependencyRequest>())
        return first;
      ICollection<ComponentDependencyFinder.ComponentMetadataWithScriptModule> componentMetadataWithScriptModules = (ICollection<ComponentDependencyFinder.ComponentMetadataWithScriptModule>) null;
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
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              componentMetadataWithScriptModules = (ICollection<ComponentDependencyFinder.ComponentMetadataWithScriptModule>) ((ICriteria) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.VPKJHTQE1EtSWuTRcbd8((object) ((ICriteria) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.IADB7NQETAbFphfp4Mt4(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.IADB7NQETAbFphfp4Mt4((object) this.Session.CreateCriteria<ComponentMetadataItem>(), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-281842504 ^ -281830872), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(2045296739 + 1688595713 ^ -561266388)), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(277947046 - -1479185048 ^ 1757102312), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-1638402543 ^ -1638753727)), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.OjxBERQEkaUS97eCmo6g(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(~-397266137 ^ 397228428), (object) true)), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.OjxBERQEkaUS97eCmo6g(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-1858887263 ^ -1858906129), (object) false)), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.c14yekQEOv3Ih4hjZlfN(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-1146510045 ^ -1146445079)))).SetProjection((IProjection) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.IC7n6WQEeBHq1BlZvyeI(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WcYS7tQE2Vaf1FLgUA20(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-2138958856 ^ -2138921670)), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(--1418440330 ^ 1418419548)), (IProjection) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.IC7n6WQEeBHq1BlZvyeI(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WcYS7tQE2Vaf1FLgUA20((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957501926)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312514223)), (IProjection) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.IC7n6WQEeBHq1BlZvyeI(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WcYS7tQE2Vaf1FLgUA20(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(1051802738 - -1831968059 ^ -1410878171)), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(647913418 ^ 647705426))), (object) new AliasToBeanResultTransformer(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.kUe61WQEPnRecsmqXDIH(__typeref (ComponentDependencyFinder.ComponentMetadataWithScriptModule))))).List<ComponentDependencyFinder.ComponentMetadataWithScriptModule>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      foreach (ComponentDependencyFinder.ComponentMetadataWithScriptModule withScriptModule in (IEnumerable<ComponentDependencyFinder.ComponentMetadataWithScriptModule>) componentMetadataWithScriptModules)
      {
        ComponentMetadata componentMetadata = withScriptModule.ComponentMetadata;
        foreach (IDependencyRequest dependencyRequest in dependencyRequests)
        {
          Guid moduleUid = dependencyRequest.ModuleUid;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          IEnumerable<FunctionDependency> second1 = componentMetadata.FunctionDependencies.Where<FunctionDependency>((Func<FunctionDependency, bool>) (a => ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_1.BYBQsjQE49yV1QKeMGRx(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_1.xVhtbXQEwCy2UGCJAEBt((object) a), moduleUid)));
          // ISSUE: reference to a compiler-generated method
          IEnumerable<DataClassDependency> second2 = componentMetadata.DataClassDependencies.Where<DataClassDependency>((Func<DataClassDependency, bool>) (a => ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_1.BYBQsjQE49yV1QKeMGRx(a.ModuleUid, moduleUid)));
          // ISSUE: reference to a compiler-generated method
          IEnumerable<ComponentDependency> second3 = componentMetadata.ComponentDependencies.Where<ComponentDependency>((Func<ComponentDependency, bool>) (a => ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_1.BYBQsjQE49yV1QKeMGRx(a.ModuleUid, moduleUid)));
          first = first.Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second1).Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second2).Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second3);
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
              object obj1 = ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-35995181 ^ -36028275);
              ICollection<ComponentDependencyFinder.ComponentMetadataWithScriptModule> source = componentMetadataWithScriptModules;
              // ISSUE: reference to a compiler-generated field
              Func<ComponentDependencyFinder.ComponentMetadataWithScriptModule, long> func = ComponentDependencyFinder.\u003C\u003Ec.\u003C\u003E9__4_6;
              Func<ComponentDependencyFinder.ComponentMetadataWithScriptModule, long> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ComponentDependencyFinder.\u003C\u003Ec.\u003C\u003E9__4_6 = selector = (Func<ComponentDependencyFinder.ComponentMetadataWithScriptModule, long>) (c => ComponentDependencyFinder.\u003C\u003Ec.SThpU9QExvX0F7aGVl4P((object) c));
              }
              else
                goto label_7;
label_6:
              long[] array = source.Select<ComponentDependencyFinder.ComponentMetadataWithScriptModule, long>(selector).ToArray<long>();
              // ISSUE: reference to a compiler-generated method
              object obj2 = ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.A9mVXBQENvsrnffMHXKw(obj1, (object) array);
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              serverScriptModuleDependencyContainers = (ICollection<ScriptModuleDependencyContainer>) ((ICriteria) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.O0O6qmQE3GbdKZ5dYjwk(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W((object) criteria, obj2), (object) Restrictions.IsNotNull((string) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(1574260816 ^ 1574174776))), (object) new IProjection[1]
              {
                (IProjection) Projections.Property((string) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(1654249598 >> 2 ^ 413607543))
              })).List<ScriptModuleDependencyContainer>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              clientScriptModuleDependencyContainers = (ICollection<ScriptModuleDependencyContainer>) ((ICriteria) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DjcrhlQEn0YMvcgPNH2W((object) this.Session.CreateCriteria<ScriptModule>(), ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.A9mVXBQENvsrnffMHXKw(ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-53329496 >> 4 ^ -3300028), (object) componentMetadataWithScriptModules.Select<ComponentDependencyFinder.ComponentMetadataWithScriptModule, long>((Func<ComponentDependencyFinder.ComponentMetadataWithScriptModule, long>) (c => ComponentDependencyFinder.\u003C\u003Ec.gfUXC6QE0xX9FeM8NQof((object) c))).ToArray<long>()))).Add((ICriterion) Restrictions.IsNotNull((string) ComponentDependencyFinder.\u003C\u003Ec__DisplayClass4_0.DtfNkgQEXdUlkfSq16fC(-477139494 ^ -477217358))).SetProjection((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107925386))).List<ScriptModuleDependencyContainer>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> second4 = ComponentDependencyFinder.ScriptModuleDependencies((IEnumerable<ScriptModuleDependencyContainer>) serverScriptModuleDependencyContainers, dependencyRequests);
      IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> second5 = ComponentDependencyFinder.ScriptModuleDependencies((IEnumerable<ScriptModuleDependencyContainer>) clientScriptModuleDependencyContainers, dependencyRequests);
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
          IEnumerable<DataClassDependency> second = dependencyContainer.DataClassDependencies.Where<DataClassDependency>((Func<DataClassDependency, bool>) (a => ComponentDependencyFinder.\u003C\u003Ec__DisplayClass6_0.fOxvRcQEJWcYSP77hjdS(a.ModuleUid, moduleUid)));
          first = first.Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second);
        }
      }
      return first;
    }

    internal static object lghD42BuCKPQ8v9qb10s([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static bool jFZkqPBufjHtnPDNu0aw() => ComponentDependencyFinder.Tvn3vlBuEtSKCyquoPG8 == null;

    internal static ComponentDependencyFinder ps8Y6HBuQt13bxqvAC7P() => ComponentDependencyFinder.Tvn3vlBuEtSKCyquoPG8;

    internal static void EjNHrnBuvkYK1e4QqZru() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class ComponentMetadataWithScriptModule
    {
      internal static object iiwXItQEumD5AMDiQOXT;

      public ComponentMetadata ComponentMetadata
      {
        get => this.\u003CComponentMetadata\u003Ek__BackingField;
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
                this.\u003CComponentMetadata\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

      public ComponentMetadataWithScriptModule()
      {
        ComponentDependencyFinder.ComponentMetadataWithScriptModule.oJUrJHQESjAAdRDBqZTE();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool P8sQ2FQEIXe7tgHPg5pC() => ComponentDependencyFinder.ComponentMetadataWithScriptModule.iiwXItQEumD5AMDiQOXT == null;

      internal static ComponentDependencyFinder.ComponentMetadataWithScriptModule T34L27QEVvAJvLr9p8BU() => (ComponentDependencyFinder.ComponentMetadataWithScriptModule) ComponentDependencyFinder.ComponentMetadataWithScriptModule.iiwXItQEumD5AMDiQOXT;

      internal static void oJUrJHQESjAAdRDBqZTE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
