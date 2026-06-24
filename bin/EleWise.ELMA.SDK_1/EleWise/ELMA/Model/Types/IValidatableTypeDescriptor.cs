// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IValidatableTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс описания типа, позволяющий провести валидацию типа
  /// </summary>
  public interface IValidatableTypeDescriptor
  {
    /// <summary>Валидация метаданных свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Список ошибок</returns>
    MetadataItemValidationError[] Validate(IPropertyMetadata propertyMetadata);
  }
}
