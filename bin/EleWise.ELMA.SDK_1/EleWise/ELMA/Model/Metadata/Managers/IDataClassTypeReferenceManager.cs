// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.IDataClassTypeReferenceManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using System;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Интерфейса менеджера ссылки типа DTO</summary>
  internal interface IDataClassTypeReferenceManager
  {
    /// <summary>Сохранить</summary>
    /// <param name="dataClassTypeReference">Ссылка типа DTO на метаданные</param>
    /// <returns>Идентификатор записи</returns>
    long Save(DataClassTypeReference dataClassTypeReference);

    /// <summary>Загрузить ссылку метаданных на модуль</summary>
    /// <param name="id">Уникальный идентификатор записи в строковом варианте</param>
    /// <returns>Ссылка типа DTO на метаданные или <c>null</c></returns>
    DataClassTypeReference LoadOrNull(string id);

    /// <summary>
    /// Найти ссылку типа DTO на метаданные по уникальному идентификатору item и уникальному идентификатору метаданных
    /// </summary>
    /// <param name="itemUid">Уникальный идентификатор записи</param>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>Ссылка типа на DTO</returns>
    DataClassTypeReference FindByItemUid(Guid itemUid, Guid metadataUid);

    /// <summary>
    /// Найти ссылку типа DTO на метаданные по уникальному идентификатору метаданных
    /// </summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>Ссылка типа на DTO</returns>
    DataClassTypeReference FindByMetadataUid(Guid metadataUid);

    /// <summary>
    /// Получить список ссылок на типы по списку уникальный идентификаторов метаданных
    /// </summary>
    /// <param name="itemUid">Список уникальных идентификаторов записи</param>
    /// <returns>Список ссылок на типы</returns>
    DataClassTypeReference[] FindReferencesByItemUid(Guid[] itemUid);
  }
}
