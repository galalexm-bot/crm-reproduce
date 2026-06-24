// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.MetatdataDependenciesExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Реализация точки расширения работы с зависимостями для метаданных
  /// </summary>
  [Component]
  internal class MetatdataDependenciesExtension : IDependenciesExtension
  {
    /// <summary>Менеджер заголовка метаданных</summary>
    private MetadataItemHeaderManager metadataItemHeaderManager;
    internal static MetatdataDependenciesExtension ieY04rfGF7cljcvdPMP7;

    /// <summary>Ctor</summary>
    /// <param name="metadataItemHeaderManager">Менеджер заголовка метаданных</param>
    public MetatdataDependenciesExtension(
      MetadataItemHeaderManager metadataItemHeaderManager)
    {
      MetatdataDependenciesExtension.JRY8LmfGoWn9oLqCnOWY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.metadataItemHeaderManager = metadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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
    public IEnumerable<IDependencyContainer> GetDependencyContainers(Guid uid)
    {
      List<IDependencyContainer> dependencyContainers = new List<IDependencyContainer>();
      IMetadataItem published = this.metadataItemHeaderManager.LoadOrNull(uid)?.Published;
      if (published != null)
      {
        if (published.Dependencies is MetadataDependencyContainer dependencies1)
          dependencyContainers.Add((IDependencyContainer) dependencies1);
        if (published.ClientScriptModule?.Dependencies is ScriptModuleDependencyContainer dependencies2)
          dependencyContainers.Add((IDependencyContainer) dependencies2);
      }
      return (IEnumerable<IDependencyContainer>) dependencyContainers;
    }

    internal static void JRY8LmfGoWn9oLqCnOWY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kGlmRZfGBekjXPVyq3ZG() => MetatdataDependenciesExtension.ieY04rfGF7cljcvdPMP7 == null;

    internal static MetatdataDependenciesExtension wwSt0YfGWcQnmDra1gJn() => MetatdataDependenciesExtension.ieY04rfGF7cljcvdPMP7;
  }
}
