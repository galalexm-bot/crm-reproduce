// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IMappingTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Интерфейс работы с мэппингом NHibernate для типа</summary>
  public interface IMappingTypeDescriptor
  {
    /// <summary>Создать мэппинг свойства</summary>
    /// <param name="mappingBuilder">Мэппинг</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    void CreatePropertyMapping(
      INHibernatePropertiesMapper mappingBuilder,
      ClassMetadata metadata,
      EntityPropertyMetadata propertyMetadata);
  }
}
