// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.DependencyAnalysisResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Результат анализа зависимостей</summary>
  public sealed class DependencyAnalysisResult
  {
    internal static DependencyAnalysisResult SDuP4PhiJA3HaJ49I6Mn;

    /// <summary>Ctor</summary>
    public DependencyAnalysisResult()
    {
      DependencyAnalysisResult.tRQY6xhilGZGxYu6C3YC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.DataClassDependencies = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 0;
            continue;
          case 2:
            this.FunctionDependencies = new List<FunctionDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 3;
            continue;
          case 3:
            this.ComponentDependencies = new List<ComponentDependency>();
            num = 5;
            continue;
          case 4:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
            continue;
          case 5:
            goto label_3;
          default:
            this.EnumDependencies = new List<EnumDependency>();
            num = 4;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Зависимости от перечислений</summary>
    public List<EnumDependency> EnumDependencies { get; set; }

    /// <summary>Зависимости от сущностей</summary>
    public List<EntityDependency> EntityDependencies { get; set; }

    /// <summary>Зависимости от DTO</summary>
    public List<DataClassDependency> DataClassDependencies { get; set; }

    /// <summary>Зависимости от функций</summary>
    public List<FunctionDependency> FunctionDependencies { get; set; }

    /// <summary>Зависимости от компонентов</summary>
    public List<ComponentDependency> ComponentDependencies { get; set; }

    internal static void tRQY6xhilGZGxYu6C3YC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool iSoKtVhi9l0Y5jY8pCcJ() => DependencyAnalysisResult.SDuP4PhiJA3HaJ49I6Mn == null;

    internal static DependencyAnalysisResult StJJ3OhidWPklrQQhnOc() => DependencyAnalysisResult.SDuP4PhiJA3HaJ49I6Mn;
  }
}
