// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IEntityInstanceFilterProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  public interface IEntityInstanceFilterProvider
  {
    /// <summary>
    /// Получить данные для фильтации (или null, если провайдер не применим к параметрам)
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="entityType">Тип сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="viewAttributes">Параметры отображения свойства</param>
    /// <returns>Данные для фильтрации</returns>
    string GetFilterProviderData(
      IEntity entity,
      Type entityType,
      PropertyMetadata propertyMetadata,
      ViewAttributes viewAttributes);
  }
}
