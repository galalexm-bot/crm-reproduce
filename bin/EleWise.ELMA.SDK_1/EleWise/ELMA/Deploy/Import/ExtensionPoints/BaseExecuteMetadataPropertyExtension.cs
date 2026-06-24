// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.BaseExecuteMetadataPropertyExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Базовый класс точки расширения обработки свойств метаданных при импорте
  /// </summary>
  [Component]
  public abstract class BaseExecuteMetadataPropertyExtension : IExecuteMetadataPropertyExtension
  {
    internal static BaseExecuteMetadataPropertyExtension mYnarFE9v30JRhAVXdxr;

    /// <inheritdoc />
    public virtual void MetadataPropertyProcessing(
      IPropertyMetadata importedProperty,
      IPropertyMetadata baseProperty,
      ClassMetadata importedMetadata,
      ReadMetadataParameters parameters)
    {
    }

    protected BaseExecuteMetadataPropertyExtension()
    {
      BaseExecuteMetadataPropertyExtension.EhR09BE9u5vdhTBp6eMd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void EhR09BE9u5vdhTBp6eMd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool yUTxdAE9891BO2lAKukg() => BaseExecuteMetadataPropertyExtension.mYnarFE9v30JRhAVXdxr == null;

    internal static BaseExecuteMetadataPropertyExtension tFFiL9E9Z6TvZYx8Zyws() => BaseExecuteMetadataPropertyExtension.mYnarFE9v30JRhAVXdxr;
  }
}
