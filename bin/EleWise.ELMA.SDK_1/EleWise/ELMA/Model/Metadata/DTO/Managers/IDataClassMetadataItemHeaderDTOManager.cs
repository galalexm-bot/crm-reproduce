// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.IDataClassMetadataItemHeaderDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  /// <summary>
  /// Интерфейс менеджера заголовков метаданных датакласса для работы через Remoting
  /// </summary>
  public interface IDataClassMetadataItemHeaderDTOManager : IConfigurationService
  {
    /// <summary>
    /// Загрузить заголовок метаданных функций по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    DataClassMetadataItemHeaderDTO Load(long id);

    /// <summary>Загрузить заголовок метаданных функций</summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Заголовок метаданных функций</returns>
    DataClassMetadataItemHeaderDTO LoadOrNull(long id);

    /// <summary>
    /// Загрузить заголовок метаданных функций по Uid без учета прав
    /// </summary>
    /// <param name="uid">Уникальный идентификатор</param>
    /// <returns>Заголовок метаданных функций</returns>
    DataClassMetadataItemHeaderDTO LoadOrNull(Guid uid);

    /// <summary>Получить все заголовки метаданных функций</summary>
    IEnumerable<DataClassMetadataItemHeaderDTO> FindAll();
  }
}
