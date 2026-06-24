// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DataSource.IExternalDataSourceExecutor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Nodes;
using System;
using System.Collections.Generic;
using System.Data;

namespace EleWise.ELMA.DataSource
{
  /// <summary>Интерфейс исполнителя внешнего источника данных</summary>
  public interface IExternalDataSourceExecutor : IDisposable
  {
    /// <summary>Получить структуру источника данных</summary>
    /// <returns></returns>
    IEnumerable<SchemaNode> LoadSchema();

    /// <summary>Выполнить запрос</summary>
    /// <param name="query">Запрос</param>
    /// <param name="paramValues">Параметры запроса</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="commandTimeout">Таймаут выполнения запроса</param>
    /// <returns></returns>
    DataTable ExecuteQuery(
      string query,
      Dictionary<string, object> paramValues = null,
      FetchOptions fetchOptions = null,
      int? commandTimeout = null);

    /// <summary>Получить количество записей</summary>
    /// <param name="query">Запрос</param>
    /// <param name="paramValues">Параметры запроса</param>
    /// <returns></returns>
    long? Count(string query, Dictionary<string, object> paramValues = null);
  }
}
