// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ConfigImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Базовая реализация точки расширения <see cref="T:EleWise.ELMA.Deploy.Import.ExtensionPoints.IConfigImportExtension" />
  /// </summary>
  public abstract class ConfigImportExtension : IConfigImportExtension, IConfigImportActionExtension
  {
    internal static ConfigImportExtension MtL7FlElgaCfn28btpSV;

    /// <summary>После проверки файла</summary>
    /// <param name="parameters"></param>
    public virtual void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
    {
    }

    /// <inheritdoc />
    public virtual void OnPreStartTest(PreStartTestImportParameters parameters)
    {
    }

    /// <summary>Перед стартом импорта</summary>
    /// <param name="parameters"></param>
    public virtual void OnPreStartImport(PreStartImportParameters parameters)
    {
    }

    /// <summary>Перед чтением пакетов</summary>
    /// <param name="parameters"></param>
    public virtual void OnPreReadPackets(PreReadPacketsParameters parameters)
    {
    }

    IReadMetadataResult IConfigImportActionExtension.OnReadMetadata(
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      return (IReadMetadataResult) null;
    }

    /// <summary>После чтения пакетов</summary>
    /// <param name="parameters"></param>
    public virtual void OnPostReadPackets(PostReadPacketsParameters parameters)
    {
    }

    /// <summary>
    /// Выполнить необходимые действия после завершения импорта
    /// </summary>
    /// <param name="parameters"></param>
    public virtual void OnPostCompleteImport(PostCompleteImportParameters parameters)
    {
    }

    /// <inheritdoc />
    public virtual void OnPrePublish(PrePublishParameters parameters)
    {
    }

    /// <inheritdoc />
    public virtual void OnPostPublish(PostPublishParameters parameters)
    {
    }

    /// <inheritdoc />
    public virtual void OnImportSuccessfull(ImportSuccessfullParameters parameters)
    {
    }

    protected ConfigImportExtension()
    {
      ConfigImportExtension.re2Is3ElY0OUUW5y0bDA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void re2Is3ElY0OUUW5y0bDA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tMYr0FEl57ug779JRqec() => ConfigImportExtension.MtL7FlElgaCfn28btpSV == null;

    internal static ConfigImportExtension yjg9sSEljwIv55PSJl6k() => ConfigImportExtension.MtL7FlElgaCfn28btpSV;
  }
}
