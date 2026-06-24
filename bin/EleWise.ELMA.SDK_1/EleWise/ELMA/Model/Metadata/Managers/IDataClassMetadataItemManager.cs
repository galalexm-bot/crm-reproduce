// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.IDataClassMetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Интерфейс менеджера метаданных датаклассов</summary>
  internal interface IDataClassMetadataItemManager : 
    IEntityManager<DataClassMetadataItem, long>,
    IEntityManager<DataClassMetadataItem>,
    IEntityManager
  {
    /// <summary>Создание датакласса в модуле</summary>
    /// <param name="moduleUid">Модуль</param>
    /// <param name="groupUid">Группа</param>
    /// <param name="displayName">Отображаемое имя</param>
    /// <returns>Элемент метаданных датакласса</returns>
    DataClassMetadataItem Create(Guid moduleUid, Guid groupUid, string displayName);

    /// <summary>Копировать датакласс</summary>
    /// <param name="headerUid">Заголовок датакласса</param>
    /// <returns>Новый экземпляр</returns>
    DataClassMetadataItem Copy(Guid headerUid);

    /// <summary>Публикация датаклассов</summary>
    /// <param name="comment">Комментарий</param>
    /// <param name="headerIds">Уникальные идентификаторы датаклассов</param>
    /// <returns>Результат публикации</returns>
    UIMetadataPublishResult Publish(string comment, Guid[] headerIds);

    /// <summary>Публикация датаклассов</summary>
    /// <param name="comment">Комментарий</param>
    /// <param name="headerId">Уникальный идентификатор датаклассов</param>
    /// <returns>Результат публикации</returns>
    UIMetadataPublishResult Publish(string comment, Guid headerId);

    /// <summary>
    /// Получить последние версии опубликованных датаклассов из конфигурации
    /// </summary>
    /// <returns></returns>
    IEnumerable<DataClassMetadataItem> GetLastPublished();

    /// <summary>Получить метаданные структур обмена данными</summary>
    /// <param name="itemUids">Идентификаторы структур обмена данными</param>
    /// <returns>Список метаданных</returns>
    List<RuntimeDataClassModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids);
  }
}
