// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.IComponentMetadataItemDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using System;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  /// <summary>
  /// Интерфейс менеджера элементов метаданных компонентов для работы через Remoting
  /// </summary>
  public interface IComponentMetadataItemDTOManager : IConfigurationService
  {
    /// <summary>
    /// Загрузить элемент метаданных компонентов по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    ComponentMetadataItemDTO Load(long id);

    /// <summary>Загрузить элемент метаданных компонентов</summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Заголовок метаданных компонентов</returns>
    ComponentMetadataItemDTO LoadOrNull(long id);

    /// <summary>
    /// Загрузить элемент метаданных компонентов по Uid без учета прав
    /// </summary>
    /// <param name="uid">Уникальный идентификатор</param>
    /// <returns>Заголовок метаданных компонентов</returns>
    ComponentMetadataItemDTO LoadOrNull(Guid uid);
  }
}
