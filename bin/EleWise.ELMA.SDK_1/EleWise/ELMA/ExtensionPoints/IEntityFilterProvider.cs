// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IEntityFilterProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Провайдер для фильтрации при выборе сущностей</summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IEntityFilterProvider
  {
    /// <summary>Уникальный идентификатор провайдера</summary>
    Guid ProviderUid { get; }

    /// <summary>Применить данные к фильтру</summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="data">Данные для фильтрации</param>
    void ApplyFilter(IEntityFilter filter, string data);

    /// <summary>
    /// Получить данные для фильтации (или null, если провайдер не применим к параметрам)
    /// </summary>
    /// <param name="entityType">Тип сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="viewAttributes">Параметры отображения свойства</param>
    /// <returns>Данные для фильтрации</returns>
    string GetFilterProviderData(
      Type entityType,
      PropertyMetadata propertyMetadata,
      ViewAttributes viewAttributes);

    /// <summary>Получить фильтр для типа сущности</summary>
    /// <param name="uid">Идентификатор типа сущности</param>
    /// <param name="filter">Текущий фильтр</param>
    /// <returns>Преобразованный фильтр или <c>null</c>, если изменений не требуется</returns>
    IEntityFilter GetFilter(Guid uid, IEntityFilter filter);
  }
}
