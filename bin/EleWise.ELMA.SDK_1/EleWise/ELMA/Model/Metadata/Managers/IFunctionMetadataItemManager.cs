// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.IFunctionMetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Интерфейс менеджера метаданных функций</summary>
  internal interface IFunctionMetadataItemManager : 
    IEntityManager<FunctionMetadataItem, long>,
    IEntityManager<FunctionMetadataItem>,
    IEntityManager
  {
    /// <summary>Создание функции в модуле</summary>
    /// <param name="moduleUid">Модуль</param>
    /// <param name="group">Группа</param>
    /// <param name="displayName">Отображаемое имя</param>
    /// <returns>Элемент метаданных функции</returns>
    FunctionMetadataItem Create(Guid moduleUid, Guid group, string displayName);

    /// <summary>Копировать функцию</summary>
    /// <param name="headerUid">Заголовок функции</param>
    /// <returns>Новый экземпляр</returns>
    FunctionMetadataItem Copy(Guid headerUid);

    /// <summary>Получить список кандидатов</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка функции</param>
    /// <returns>Список кандидатов, упорядоченный по убыванию номера версии</returns>
    IEnumerable<FunctionMetadataItem> GetCandidates(Guid headerUid);

    /// <summary>Опубликовать функцию</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="comment">Комментарий</param>
    /// <returns>Результат публикации</returns>
    UIMetadataPublishResult Publish(Guid headerUid, string comment);

    /// <summary>Обновить код функции</summary>
    /// <param name="newMetadata">Новые метаданные</param>
    /// <param name="oldMetadata">Старые метаданные</param>
    /// <param name="newSource">Исходный код функции</param>
    string UpdateScriptCode(
      FunctionMetadata newMetadata,
      FunctionMetadata oldMetadata,
      string newSource);

    /// <summary>Сгенерировать код для функции</summary>
    /// <param name="request">Запрос на генерацию кода функции</param>
    /// <returns>Ответа при генерации кода для функции</returns>
    GenerateFunctionCodeResponse GenerateCode(GenerateFunctionCodeRequest request);
  }
}
