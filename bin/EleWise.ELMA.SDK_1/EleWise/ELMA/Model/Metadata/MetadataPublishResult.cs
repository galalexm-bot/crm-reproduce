// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataPublishResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Результат публикации метаданных</summary>
  [Serializable]
  public class MetadataPublishResult : MetadataAssemblyPublishResult
  {
    internal static MetadataPublishResult bHgpSeb6hC2kq49dZm1V;

    /// <summary>Ctor</summary>
    public MetadataPublishResult()
    {
      MetadataPublishResult.qtoSPgb6fChYbFrXyCTY();
      // ISSUE: explicit constructor call
      this.\u002Ector((AssemblyModelsMetadata) null, (AssemblyModelsMetadata) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="configurationAssembly">Сборка конфигурации</param>
    /// <param name="dynamicAssembly">Сборка динамик</param>
    public MetadataPublishResult(
      AssemblyModelsMetadata configurationAssembly,
      AssemblyModelsMetadata dynamicAssembly)
    {
      MetadataPublishResult.qtoSPgb6fChYbFrXyCTY();
      // ISSUE: explicit constructor call
      base.\u002Ector(configurationAssembly, dynamicAssembly);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="configurationAssembly">Сборка конфигурации</param>
    /// <param name="scriptsAssembly">Сборка скриптов конфигурации</param>
    /// <param name="dynamicAssembly">Сборка динамик</param>
    public MetadataPublishResult(
      AssemblyModelsMetadata configurationAssembly,
      AssemblyModelsMetadata scriptsAssembly,
      AssemblyModelsMetadata dynamicAssembly)
    {
      MetadataPublishResult.qtoSPgb6fChYbFrXyCTY();
      // ISSUE: explicit constructor call
      base.\u002Ector(configurationAssembly, scriptsAssembly, dynamicAssembly);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Ctor
    /// <param name="metadataAssemblePublishResult">Результат публикации метаданных</param>
    /// <param name="needRestart">Требует перезапуска</param>
    /// </summary>
    public MetadataPublishResult(
      [NotNull] MetadataAssemblyPublishResult metadataAssemblePublishResult,
      bool needRestart)
    {
      MetadataPublishResult.qtoSPgb6fChYbFrXyCTY();
      // ISSUE: explicit constructor call
      this.\u002Ector(metadataAssemblePublishResult.ConfigurationAssembly, metadataAssemblePublishResult.ScriptsAssembly, metadataAssemblePublishResult.DynamicAssembly);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.NeedRestart = needRestart;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Требует перезапуска</summary>
    public bool NeedRestart
    {
      get => this.\u003CNeedRestart\u003Ek__BackingField;
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
              this.\u003CNeedRestart\u003Ek__BackingField = value;
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

    internal static void qtoSPgb6fChYbFrXyCTY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OMfZ3Gb6GrsMjGp4Ohno() => MetadataPublishResult.bHgpSeb6hC2kq49dZm1V == null;

    internal static MetadataPublishResult GhKsxfb6EjmYBnSyCEjN() => MetadataPublishResult.bHgpSeb6hC2kq49dZm1V;
  }
}
