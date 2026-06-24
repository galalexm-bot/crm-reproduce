// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.IComponentMetadataItemHeaderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Managers
{
  /// <summary>Интерфейс менеджера заголовков метаданных компонента</summary>
  internal interface IComponentMetadataItemHeaderManager : 
    IEntityManager<ComponentMetadataItemHeader, long>,
    IEntityManager<ComponentMetadataItemHeader>,
    IEntityManager
  {
    /// <summary>
    /// Получить следующий номер публикуемой версии компонента
    /// </summary>
    /// <param name="headerId">Идентификатор заголовка компонента</param>
    /// <returns>Номер версии</returns>
    long GetPublishingVersionNumber(long headerId);

    /// <summary>
    /// Получить список всех опубликованных заголовков компонентов
    /// </summary>
    /// <returns>Список всех опубликованных заголовков компонентов</returns>
    IEnumerable<ComponentMetadataItemHeader> GetAllPublished();

    /// <summary>Получить список всех черновых заголовков компонентов</summary>
    /// <returns>Список всех черновых заголовков компонентов</returns>
    IEnumerable<ComponentMetadataItemHeader> GetAllDrafts();

    /// <summary>Проверить идентификатор компонента</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка компонента</param>
    /// <param name="name">Идентификатор компонента</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns><c>True</c>, если идентификатор валиден</returns>
    bool ValidateName(Guid headerUid, string name, out string errorMessage);

    /// <summary>Проверить отображаемое имя компонента</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка компонента</param>
    /// <param name="displayName">Отображаемое имя компонента</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns><c>True</c>, если отображаемое имя валидно</returns>
    bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage);

    /// <summary>Редактировать заголовок метаданных</summary>
    /// <param name="uid">Идентификатор</param>
    /// <param name="groupUid">Идентификатор группы</param>
    /// <returns>Заголовок метаданных</returns>
    ComponentMetadataItemHeader Edit(Guid uid, Guid groupUid);

    /// <summary>Удалить компонент</summary>
    /// <param name="headerId">Идентификатор заголовка компонента</param>
    void Delete(long headerId);

    /// <summary>
    /// Построить упорядоченный для публикации список метаданных компонентов
    /// </summary>
    /// <param name="headers">Список заголовков метаданных компонентов</param>
    /// <returns>Отсортированное перечисление</returns>
    IEnumerable<ComponentMetadataItemHeader> SortByDependencies(
      IEnumerable<ComponentMetadataItemHeader> headers);

    /// <summary>Найти все объекты по Uid'ам из массива</summary>
    /// <param name="UidArray">Массив идентификаторов</param>
    /// <returns>Список найденных объектов</returns>
    ICollection<ComponentMetadataItemHeader> FindByIdArray(Guid[] UidArray);
  }
}
