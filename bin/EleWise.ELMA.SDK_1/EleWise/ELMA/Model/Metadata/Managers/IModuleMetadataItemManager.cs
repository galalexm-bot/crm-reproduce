// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.IModuleMetadataItemManager
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
  /// <summary>Интерфейс менеджера метаданных модулей</summary>
  internal interface IModuleMetadataItemManager : 
    IEntityManager<ModuleMetadataItem, long>,
    IEntityManager<ModuleMetadataItem>,
    IEntityManager
  {
    /// <summary>Создание модуля</summary>
    /// <param name="name">Имя</param>
    /// <param name="displayName">Отображаемое имя</param>
    /// <param name="description">Описание</param>
    /// <returns>Элемент метаданных модуля</returns>
    ModuleMetadataItem Create(string name, string displayName, string description);

    /// <summary>Опубликовать модуль</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="comment">Комментарий</param>
    /// <returns>Результат публикации</returns>
    UIMetadataPublishResult Publish(Guid headerUid, string comment);

    /// <summary>Получить метаданные и скрипты модулей</summary>
    /// <param name="itemUids">Идентификаторы модулей</param>
    /// <param name="debug">Режим отображения</param>
    /// <returns>Список метаданных и скриптов</returns>
    List<RuntimeModuleModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids, bool debug);
  }
}
