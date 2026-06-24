// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataAssemblyPublishResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Результат публикации метаданных для сборок</summary>
  [Serializable]
  public class MetadataAssemblyPublishResult
  {
    private static MetadataAssemblyPublishResult bYphSPb3tJMS8pnXQcQr;

    /// <summary>Ctor</summary>
    /// <param name="configurationAssembly">Сборка конфигурации</param>
    /// <param name="dynamicAssembly">Сборка динамик</param>
    public MetadataAssemblyPublishResult(
      AssemblyModelsMetadata configurationAssembly,
      AssemblyModelsMetadata dynamicAssembly)
    {
      MetadataAssemblyPublishResult.BE1Cngb36pmQRJjYgr2M();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.DynamicAssembly = dynamicAssembly;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.ConfigurationAssembly = configurationAssembly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="configurationAssembly">Сборка конфигурации</param>
    /// <param name="scriptsAssembly">Сборка скриптов конфигурации</param>
    /// <param name="dynamicAssembly">Сборка динамик</param>
    public MetadataAssemblyPublishResult(
      AssemblyModelsMetadata configurationAssembly,
      AssemblyModelsMetadata scriptsAssembly,
      AssemblyModelsMetadata dynamicAssembly)
    {
      MetadataAssemblyPublishResult.BE1Cngb36pmQRJjYgr2M();
      // ISSUE: explicit constructor call
      this.\u002Ector(configurationAssembly, dynamicAssembly);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ScriptsAssembly = scriptsAssembly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="configurationAssembly">Сборка конфигурации</param>
    /// <param name="scriptsAssembly">Сборка скриптов конфигурации</param>
    /// <param name="dynamicAssembly">Сборка динамик</param>
    /// <param name="configurationDeltaAssemblyRaw">Raw дельта-сборки конфигурации</param>
    /// <param name="dynamicDeltaAssemblyRaw">Raw дельта-сборки динамик</param>
    internal MetadataAssemblyPublishResult(
      AssemblyModelsMetadata configurationAssembly,
      AssemblyModelsMetadata scriptsAssembly,
      AssemblyModelsMetadata dynamicAssembly,
      MemoryStream configurationDeltaAssemblyRaw,
      MemoryStream dynamicDeltaAssemblyRaw)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(configurationAssembly, scriptsAssembly, dynamicAssembly);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ConfigurationDeltaAssemblyRaw = configurationDeltaAssemblyRaw;
            num = 2;
            continue;
          case 2:
            this.DynamicDeltaAssemblyRaw = dynamicDeltaAssemblyRaw;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>
    /// Информация о сборке с моделями, созданными в дизайнере
    /// </summary>
    public AssemblyModelsMetadata ConfigurationAssembly { get; }

    /// <summary>Информация о сборке со скриптами конфигурации</summary>
    public AssemblyModelsMetadata ScriptsAssembly { get; }

    /// <summary>Информация о динамической сборке</summary>
    public AssemblyModelsMetadata DynamicAssembly { get; }

    /// <summary>Raw дельта-сборки конфигурации</summary>
    internal MemoryStream ConfigurationDeltaAssemblyRaw { get; }

    /// <summary>Raw дельта-сборки динамик</summary>
    internal MemoryStream DynamicDeltaAssemblyRaw { get; }

    internal static void BE1Cngb36pmQRJjYgr2M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool dCSZWNb3whEL6JCl2UFB() => MetadataAssemblyPublishResult.bYphSPb3tJMS8pnXQcQr == null;

    internal static MetadataAssemblyPublishResult kFnId9b34ssxdrxtmOcj() => MetadataAssemblyPublishResult.bYphSPb3tJMS8pnXQcQr;
  }
}
