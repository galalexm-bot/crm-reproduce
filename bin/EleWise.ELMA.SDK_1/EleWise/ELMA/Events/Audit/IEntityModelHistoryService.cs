// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEntityModelHistoryService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Интерфейс сервиса для получения истории измнений сущностей
  /// </summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IEntityModelHistoryService
  {
    /// <summary>Получить кол-во сделанных изменений за период</summary>
    /// <param name="objectTypeUid">Тип объекта</param>
    /// <param name="from">Начало периода</param>
    /// <param name="eqlQuery"> </param>
    /// <returns>Количество изменений</returns>
    long Count(Guid objectTypeUid, DateTime? from, string eqlQuery = null);

    /// <summary>Получить все элементы истории изменений</summary>
    /// <param name="objectTypeUid">Тип объекта</param>
    /// <param name="from">Начало периода</param>
    /// <param name="eqlQuery"> </param>
    /// <returns>Коллекция элементов изменения</returns>
    IEnumerable<IEntityModelHistoryItem> Find(Guid objectTypeUid, DateTime? from, string eqlQuery = null);

    /// <summary>Получить все элементы истории изменений</summary>
    /// <param name="objectTypeUid">Тип объекта</param>
    /// <param name="from">Начало периода</param>
    /// <param name="filterKey">Ключ для фильтра, чтобы получить данные по существующим идентификаторам из базы</param>
    /// <param name="filter"> </param>
    /// <returns>Коллекция элементов изменения</returns>
    IEnumerable<IEntityModelHistoryItem> Find(
      Guid objectTypeUid,
      DateTime? from,
      string filterKey,
      IEntityFilter filter);
  }
}
