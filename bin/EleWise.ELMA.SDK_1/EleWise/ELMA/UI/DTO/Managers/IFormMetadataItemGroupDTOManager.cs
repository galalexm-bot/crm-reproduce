// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Managers.IFormMetadataItemGroupDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.UI.DTO.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.DTO.Managers
{
  public interface IFormMetadataItemGroupDTOManager : IConfigurationService
  {
    /// <summary>Загрузить корневую группу</summary>
    /// <param name="metadataType">Тип метаданных форм (страница или портлет)</param>
    /// <returns>Корневая группа форм указанного типа</returns>
    FormMetadataItemGroupDTO LoadRootGroup(Guid metadataType);

    /// <summary>Получить список подчиненных групп</summary>
    /// <param name="parentGroupId">Id родительской группы (или 0 - если корень)</param>
    /// <returns>Список подчиненных групп</returns>
    IEnumerable<FormMetadataItemGroupDTO> GetChildGroups(Guid metadataType, long? parentGroupId);

    /// <summary>Получить список подчиненных групп</summary>
    /// <param name="parentGroupId">Id родительской группы (или 0 - если корень)</param>
    /// <returns>Список подчиненных групп</returns>
    IEnumerable<FormMetadataItemGroupDTO> GetNestedChildGroups(
      Guid metadataType,
      long? parentGroupId);

    /// <summary>Сохранить группу</summary>
    /// <param name="group">Группа</param>
    /// <returns>Измененная группа</returns>
    FormMetadataItemGroupDTO Save(FormMetadataItemGroupDTO group);

    /// <summary>Удалить группу</summary>
    /// <param name="groupId">Идентификатор группы</param>
    void Delete(long groupId);
  }
}
