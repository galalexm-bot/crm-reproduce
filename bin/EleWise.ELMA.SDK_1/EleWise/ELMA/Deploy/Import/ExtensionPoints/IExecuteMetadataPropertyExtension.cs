// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.IExecuteMetadataPropertyExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения обработки свойств метаданных при импорте
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IExecuteMetadataPropertyExtension
  {
    /// <summary>Обработка свойства</summary>
    /// <param name="importedProperty">Импортируемое свойство</param>
    /// <param name="baseProperty">Свойство имеющееся в системе</param>
    /// <param name="importedMetadata">Импортируемые метаданные</param>
    /// <param name="parameters">Параметры обработки импортируемых данных</param>
    void MetadataPropertyProcessing(
      IPropertyMetadata importedProperty,
      IPropertyMetadata baseProperty,
      ClassMetadata importedMetadata,
      ReadMetadataParameters parameters);
  }
}
