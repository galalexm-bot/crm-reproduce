// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.IPublicationActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>Интерфейс эктора публикации</summary>
  [FeatureFlagManaged("Publication.Actor.Enabled", true)]
  internal interface IPublicationActor : IActorWithGuidKey, IActor
  {
    /// <summary>
    /// Запустить публикацию указанного списка элементов метаданных
    /// </summary>
    /// <remarks>
    /// Метод возвращает токен запущенной публикации, который вернется в сообщении о заврешении публикации
    /// </remarks>
    /// <param name="comment">Комментарий к публикации</param>
    /// <param name="tag">Метка</param>
    /// <param name="headerIds">Идентификаторы заголовков метаданных</param>
    /// <returns>Токен публикации</returns>
    Task<Guid> Start(string comment, string tag, params long[] headerIds);

    /// <summary>Проверка состояния публикации при запуске сервера</summary>
    /// <remarks>При вызове сравнивается опубликованная версия в базе с версией в рантайме, и выкидывается исключение при несоответствии</remarks>
    /// <returns>true, если публикация в процессе, иначе false</returns>
    Task<bool> PublicationStarted();

    /// <summary>
    /// Ожидание заверешния работы отдельных узлов при публикации
    /// </summary>
    /// <param name="сonnectionUid">Уникальный идентификатор сервера</param>
    Task Wait(Guid сonnectionUid);

    /// <summary>Завершить ожидание</summary>
    /// <param name="сonnectionUid">Уникальный идентификатор сервера</param>
    Task Complete(Guid сonnectionUid);

    /// <summary>
    /// Завершить ожидание обновления метаданных на сервере после окончания публикации
    /// </summary>
    /// <param name="connectionUid">Уникальный идентификатор сервера</param>
    Task RuntimeUpdated(Guid connectionUid);

    /// <summary>Прервать ожидание с ошибкой</summary>
    /// <param name="exception">Исключение</param>
    Task Error(Exception exception);
  }
}
