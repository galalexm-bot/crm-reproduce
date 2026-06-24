// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IPropertyTypeInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс описания типа данных, предоставляющий методы для получения информации о свойстве класса
  /// </summary>
  public interface IPropertyTypeInfo
  {
    /// <summary>Получить отображаемое имя типа у свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Отображаемое имя типа у свойства</returns>
    string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata);

    /// <summary>Получить отображаемое имя типа</summary>
    /// <param name="subTypeUid">Уникальные идентификатор подтипа</param>
    /// <returns></returns>
    string GetTypeDisplayName(Guid subTypeUid);
  }
}
