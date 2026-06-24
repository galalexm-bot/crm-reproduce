// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.IReadMetadataResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>Результат чтения метаданных</summary>
  public interface IReadMetadataResult
  {
    /// <summary>Метаданные</summary>
    IMetadata Metadata { get; }

    /// <summary>Проверить прочитанные метаданные</summary>
    bool TestMetadata();

    /// <summary>Сохранить прочитанные метаданные</summary>
    void SaveMetadata();
  }
}
