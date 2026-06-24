// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEntityActionHistoryCollector
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Сборщик дополнительных данных для отображения истории по объекту.
  /// Срабатывает только при отображении
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-104.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [Obsolete("Данный класс устарел и больше не используется. Используйте IEntityActionHistoryCollectorRelated")]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IEntityActionHistoryCollector
  {
    /// <summary>Получить данные для отображения истории</summary>
    /// <param name="id">Идентификатор объекта</param>
    /// <param name="actionObject">Идентификатор типа сущности</param>
    /// <returns>Список аргументов для добавления в общий список отображения</returns>
    [Obsolete("Метод устарел и больше не используется. Используйте IEntityActionHistoryCollectorRelated.CollectHistory")]
    IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject);
  }
}
