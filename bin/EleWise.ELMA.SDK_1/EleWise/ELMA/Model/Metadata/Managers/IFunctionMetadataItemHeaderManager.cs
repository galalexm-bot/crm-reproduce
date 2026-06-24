// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.IFunctionMetadataItemHeaderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Интерфейс менеджера заголовка метаданных функций</summary>
  internal interface IFunctionMetadataItemHeaderManager : 
    IEntityManager<FunctionMetadataItemHeader, long>,
    IEntityManager<FunctionMetadataItemHeader>,
    IEntityManager
  {
    /// <summary>Получить следующий номер публикуемой версии функции</summary>
    /// <param name="headerId">Идентификатор заголовка функции</param>
    /// <returns>Номер версии</returns>
    long GetPublishingVersionNumber(long headerId);

    /// <summary>Проверить идентификатор функции</summary>
    /// <param name="headerId">Id заголовка</param>
    /// <param name="name">Идентификатор функции</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns><c>true</c> если идентификатор валиден</returns>
    bool ValidateName(long headerId, string name, out string errorMessage);

    /// <summary>Проверить идентификатор функции</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="name">Идентификатор функции</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns><c>true</c> если идентификатор валиден</returns>
    bool ValidateName(Guid headerUid, string name, out string errorMessage);

    /// <summary>Проверить отображаемое имя функции</summary>
    /// <param name="headerId">Id заголовка</param>
    /// <param name="displayName">Отображаемое имя функции</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns><c>true</c> если отображаемое имя валидно</returns>
    bool ValidateDisplayName(long headerId, string displayName, out string errorMessage);

    /// <summary>Проверить отображаемое имя функции</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="displayName">Отображаемое имя функции</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns><c>true</c> если отображаемое имя валидно</returns>
    bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage);

    /// <summary>
    /// Получить список всех опубликованных заголовков функций
    /// </summary>
    /// <returns>Список всех опубликованных заголовков функций</returns>
    IEnumerable<FunctionMetadataItemHeader> GetAllPublished();

    /// <summary>Получить список всех черновых заголовков функций</summary>
    /// <returns>Список всех черновых заголовков функций</returns>
    IEnumerable<FunctionMetadataItemHeader> GetAllDrafts();

    /// <summary>Редактировать заголовок метаданных</summary>
    /// <param name="uid">Идентификатор заголовка метаданных</param>
    /// <param name="group">Группа</param>
    /// <returns>Заголовок метаданных</returns>
    FunctionMetadataItemHeader Edit(Guid uid, Guid group);
  }
}
