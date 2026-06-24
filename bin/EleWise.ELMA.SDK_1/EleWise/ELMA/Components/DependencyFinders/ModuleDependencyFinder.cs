// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.DependencyFinders.ModuleDependencyFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Components.Dependency;
using EleWise.ELMA.UI.Components.Dependency.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components.DependencyFinders
{
  /// <summary>Компонент поиска зависимостей по модулям</summary>
  [Component]
  internal sealed class ModuleDependencyFinder : IDependencyFinder
  {
    private readonly ISessionProvider sessionProvider;
    private static ModuleDependencyFinder TK5nBKfEXwV1uUR9pFww;

    private ISession Session => (ISession) ModuleDependencyFinder.Atq64PfEnZxsM9p9b1jt((object) this.sessionProvider, (object) string.Empty);

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    public ModuleDependencyFinder(ISessionProvider sessionProvider)
    {
      ModuleDependencyFinder.CDj9axfEOR7d4ZgPeewx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
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
      // ISSUE: reference to a compiler-generated method
      Guid[] moduleUids = dependencyRequests.Select<IDependencyRequest, Guid>((Func<IDependencyRequest, Guid>) (a => ModuleDependencyFinder.\u003C\u003Ec.o9p8Ly8rKjKOYy0MEux6((object) a))).ToArray<Guid>();
      ICollection<ModuleInfoMetadata> moduleInfoMetadatas = (ICollection<ModuleInfoMetadata>) null;
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
              moduleInfoMetadatas = (ICollection<ModuleInfoMetadata>) ((ICriteria) ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.jjbo5j8rCJJ3A4nXXHCy(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.ngghoR8rEnVGJFFNp9wW(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.ngghoR8rEnVGJFFNp9wW(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.ngghoR8rEnVGJFFNp9wW(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.ngghoR8rEnVGJFFNp9wW(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.IGKitK8rbOXr1sc0ALll((object) this.Session.CreateCriteria<ModuleMetadataItem>(), ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(222162814 ^ 222124492), ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(1819636893 << 3 ^ 1672327082)), ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.QOjPJv8rGqxQHk4aJ3EK(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.l9Za6f8rhDdEKIPUUDIG(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(647913418 ^ 647517316), (object) moduleUids))), ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.K1flCG8rfKEFMarEfbFk(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(-1939377524 ^ -1939768850))), ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.K1flCG8rfKEFMarEfbFk(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(1461625753 ^ 1461654473))), ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.K1flCG8rfKEFMarEfbFk(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.G8nIgF8rorVrtALlsTek(132912447 ^ 132948989))), (object) new IProjection[1]
              {
                (IProjection) ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_0.WD0GJk8rQZv5eIgNekDP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867782002))
              })).List<ModuleInfoMetadata>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      foreach (ModuleInfoMetadata moduleInfoMetadata in (IEnumerable<ModuleInfoMetadata>) moduleInfoMetadatas)
      {
        ModuleDependency dependency = moduleInfoMetadata.Dependency;
        foreach (Guid guid in moduleUids)
        {
          Guid moduleUid = guid;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          IEnumerable<FunctionDependency> second1 = dependency.Functions.Where<FunctionDependency>((Func<FunctionDependency, bool>) (a => ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_1.IPcBly8rVcUBOxqulVxR(ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_1.l8av2o8rIFGBfvwV28rB((object) a), moduleUid)));
          // ISSUE: reference to a compiler-generated method
          IEnumerable<DataClassDependency> second2 = dependency.DataClasses.Where<DataClassDependency>((Func<DataClassDependency, bool>) (a => ModuleDependencyFinder.\u003C\u003Ec__DisplayClass4_1.IPcBly8rVcUBOxqulVxR(a.ModuleUid, moduleUid)));
          IEnumerable<ComponentDependency> second3 = dependency.Components.Where<ComponentDependency>((Func<ComponentDependency, bool>) (a => a.ModuleUid == moduleUid));
          first = first.Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second1).Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second2).Concat<EleWise.ELMA.Model.Dependencies.Dependency>((IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency>) second3);
        }
      }
      return first;
    }

    internal static object Atq64PfEnZxsM9p9b1jt([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static bool np5O0RfETeM9rTnluk05() => ModuleDependencyFinder.TK5nBKfEXwV1uUR9pFww == null;

    internal static ModuleDependencyFinder B2fiosfEkoGAPm6x1PDw() => ModuleDependencyFinder.TK5nBKfEXwV1uUR9pFww;

    internal static void CDj9axfEOR7d4ZgPeewx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
