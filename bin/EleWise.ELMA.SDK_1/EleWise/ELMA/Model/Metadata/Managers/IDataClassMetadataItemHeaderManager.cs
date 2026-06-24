// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.IDataClassMetadataItemHeaderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Интерфейс менеджера заголовков метаданных датаклассов</summary>
  public interface IDataClassMetadataItemHeaderManager : 
    IEntityManager<DataClassMetadataItemHeader, long>,
    IEntityManager<DataClassMetadataItemHeader>,
    IEntityManager
  {
    /// <summary>
    /// Получить список всех опубликованных заголовков DataClass
    /// </summary>
    /// <returns>Список всех опубликованных заголовков DataClass</returns>
    IEnumerable<DataClassMetadataItemHeader> GetAllPublished();

    /// <summary>Получить список всех черновых заголовков DataClass</summary>
    /// <returns>Список всех черновых заголовков DataClass</returns>
    IEnumerable<DataClassMetadataItemHeader> GetAllDrafts();

    /// <summary>Проверить идентификатор компонента</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="name">Идентификатор компонента</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns><c>True</c>, если идентификатор валиден</returns>
    bool ValidateName(Guid headerUid, string name, out string errorMessage);

    /// <summary>Проверить отображаемое имя компонента</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="displayName">Отображаемое имя компонента</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns><c>True</c>, если отображаемое имя валидно</returns>
    bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage);

    /// <summary>
    /// Получить следующий номер публикуемой версии датакласса
    /// </summary>
    /// <param name="headerId">Идентификатор заголовка датакласса</param>
    /// <returns>Номер версии</returns>
    long GetNewPublishingVersionNumber(long headerId);

    /// <summary>Редактировать заголовок метаданных</summary>
    /// <param name="uid">Идентификатор заголовока метаданных</param>
    /// <param name="group">Группа</param>
    /// <returns>Заголовок метаданных</returns>
    DataClassMetadataItemHeader Edit(Guid uid, Guid group);
  }
}
