// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.IComponentMetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Managers
{
  /// <summary>Интерфейс менеджера метаданных компонента</summary>
  internal interface IComponentMetadataItemManager : 
    IEntityManager<ComponentMetadataItem, long>,
    IEntityManager<ComponentMetadataItem>,
    IEntityManager
  {
    /// <summary>Создать портлет</summary>
    /// <param name="typeUid">Тип</param>
    /// <param name="moduleUid">Модуль</param>
    /// <param name="groupUid">Группа</param>
    /// <param name="displayName">Отображаемое имя</param>
    /// <returns>Портлет</returns>
    ComponentMetadataItem Create(Guid typeUid, Guid moduleUid, Guid groupUid, string displayName);

    /// <summary>Копировать компонент</summary>
    /// <param name="headerUid">Заголовок компонента</param>
    /// <returns>Новый экземпляр</returns>
    ComponentMetadataItem Copy(Guid headerUid);

    /// <summary>Отметить версию как не рабочую</summary>
    /// <param name="obj">Элемент метаданных компонента</param>
    void MarkAsNotWorking(ComponentMetadataItem obj);

    /// <summary>Переписать скрипты при переименовании компонента</summary>
    /// <param name="current">Текущие метаданные компонента</param>
    /// <param name="oldName">Старое наименование метаданных</param>
    void Rename(ComponentMetadataItem current, string oldName);

    /// <summary>Получить метаданные и скрипты компонентов</summary>
    /// <param name="itemUids">Идентификаторы компонентов</param>
    /// <param name="debug">Режим отображения</param>
    /// <returns>Список метаданных и скриптов</returns>
    List<RuntimeComponentModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids, bool debug);

    /// <summary>Публиковать компонент</summary>
    /// <param name="headerId">Идентификатор заголовка компонента</param>
    /// <param name="comment">Комментарий</param>
    /// <param name="forEmulation"><c>true</c> если публикация происходит для эмуляции</param>
    /// <returns>Результат публикации</returns>
    UIMetadataPublishResult Publish(Guid headerId, string comment, bool forEmulation);

    /// <summary>Получить версии-кандидаты по идентификатору заголовка</summary>
    /// <param name="headerUid">Идентификатор заголовка</param>
    /// <returns>Версии-кандидаты</returns>
    IEnumerable<ComponentMetadataItemWrapper> GetCandidates(Guid headerUid);

    /// <summary>
    /// Получить все последние опубликованные версии компонентов конфигурации
    /// </summary>
    /// <returns>Список последних версий компонентов</returns>
    IEnumerable<ComponentMetadataItemWrapper> GetLastPublished();
  }
}
