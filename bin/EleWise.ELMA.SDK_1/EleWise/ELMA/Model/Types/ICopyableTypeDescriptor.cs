// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ICopyableTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс описателя типов, который поддерживает копирование значений данного типа
  /// </summary>
  public interface ICopyableTypeDescriptor
  {
    /// <summary>Скопировать значения свойства</summary>
    /// <param name="obj">Объект из которого нужно копировать</param>
    /// <param name="target">Объект, в который идет копирование</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    void Copy(
      object obj,
      object target,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata);
  }
}
