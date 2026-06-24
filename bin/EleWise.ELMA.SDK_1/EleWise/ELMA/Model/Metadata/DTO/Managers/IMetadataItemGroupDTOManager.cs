// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.IMetadataItemGroupDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  /// <summary>
  /// Менеджер групп элементов метаданных для работы через Remoting
  /// </summary>
  public interface IMetadataItemGroupDTOManager : IConfigurationService
  {
    /// <summary>
    /// Загрузить корневую группу с загруженным списком подгрупп
    /// </summary>
    /// <returns>Корневая группа процессов</returns>
    MetadataItemGroupDTO LoadRootGroup();

    /// <summary>Получить список подчиненных групп</summary>
    /// <param name="parentGroupId">Id родительской группы (или 0 - если корень)</param>
    /// <returns>Список подчиненных групп</returns>
    IEnumerable<MetadataItemGroupDTO> GetChildGroups(long parentGroupId);

    /// <summary>Получить список подчиненных групп</summary>
    /// <param name="parentGroupId">Id родительской группы (или 0 - если корень)</param>
    /// <returns>Список подчиненных групп</returns>
    IEnumerable<MetadataItemGroupDTO> GetNestedChildGroups(long parentGroupId);

    /// <summary>Сохранить группу</summary>
    /// <param name="group">Группа</param>
    /// <returns>Измененная группа</returns>
    MetadataItemGroupDTO Save(MetadataItemGroupDTO group);

    /// <summary>Удалить группу</summary>
    /// <param name="groupId">Идентификатор группы</param>
    void Delete(long groupId);
  }
}
