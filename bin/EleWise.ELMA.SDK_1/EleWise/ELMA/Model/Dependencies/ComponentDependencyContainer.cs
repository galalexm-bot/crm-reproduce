// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.ComponentDependencyContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Контейнер зависимости для компонентов</summary>
  public sealed class ComponentDependencyContainer : IDependencyContainer
  {
    private static ComponentDependencyContainer teRXTmhi0FblPcMgdf19;

    /// <summary>Ctor</summary>
    public ComponentDependencyContainer()
    {
      ComponentDependencyContainer.hVrFmDhiMSWKOKfJVN6R();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.DataClassDependencies = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 3;
            continue;
          case 2:
            this.ComponentDependencies = new List<ComponentDependency>();
            num = 5;
            continue;
          case 3:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 4;
            continue;
          case 4:
            this.EnumDependencies = new List<EnumDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 5:
            this.FunctionDependencies = new List<FunctionDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <summary>Зависимости в компонентах</summary>
    public List<ComponentDependency> ComponentDependencies { get; }

    /// <summary>Общие зависимости от функций</summary>
    public List<FunctionDependency> FunctionDependencies { get; }

    /// <summary>Общие зависимости от датаклассов</summary>
    public List<DataClassDependency> DataClassDependencies { get; }

    /// <summary>Общие зависимости от сущностей</summary>
    public List<EntityDependency> EntityDependencies { get; }

    /// <summary>Общие зависимости от перечислений</summary>
    public List<EnumDependency> EnumDependencies { get; }

    internal static void hVrFmDhiMSWKOKfJVN6R() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool aUVI5DhimygyZK109iiI() => ComponentDependencyContainer.teRXTmhi0FblPcMgdf19 == null;

    internal static ComponentDependencyContainer z7F186hiyUGIjblOJUaW() => ComponentDependencyContainer.teRXTmhi0FblPcMgdf19;
  }
}
