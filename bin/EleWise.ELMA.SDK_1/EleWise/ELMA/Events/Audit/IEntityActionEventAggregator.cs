// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEntityActionEventAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Точка расширения для агрегации событий объекта</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-104.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IEntityActionEventAggregator
  {
    /// <summary>
    /// Аггрегировать события в списке (убрать дублирующие, объединить общие события)
    /// </summary>
    /// <param name="eventList">Текущий список событий в рамках транзакции</param>
    /// <param name="previousResults">Список результатов выполнения предыдущих аггрегаторов</param>
    /// <returns>Результаты выполнения</returns>
    IEnumerable<ActionEventAggregatorResult> Aggregate(
      IList<EntityActionEventArgs> eventList,
      IEnumerable<ActionEventAggregatorResult> previousResults);
  }
}
