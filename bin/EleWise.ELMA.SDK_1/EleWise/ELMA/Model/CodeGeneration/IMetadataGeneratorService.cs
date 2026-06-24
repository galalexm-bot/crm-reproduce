// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.IMetadataGeneratorService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Поставщик генераторов кода для метаданных</summary>
  public interface IMetadataGeneratorService
  {
    /// <summary>Получить генератор</summary>
    /// <param name="metadata">Метаданные</param>
    ICodeGenerator GetCodeGenerator(IMetadata metadata);
  }
}
