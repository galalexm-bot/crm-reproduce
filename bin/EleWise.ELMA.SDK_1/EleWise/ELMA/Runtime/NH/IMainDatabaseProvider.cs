// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IMainDatabaseProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using System;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Провайдер основной БД</summary>
  public interface IMainDatabaseProvider : IProvider, IConfigurableProvider, IDisposable
  {
    /// <summary>Строка содеинения БД</summary>
    string ConnectionString { get; }

    /// <summary>Название диалекта (тип??)</summary>
    string DataProviderName { get; }

    /// <summary>
    /// Включен/выключен
    /// Если выключен то свойства ConnectionString и Dialect имеют неопределенные значения
    /// </summary>
    bool Enabled { get; }

    /// <summary>
    /// Создать провайдер для обновления структуры базы данных, отвязанный от сессии NHibernate
    /// </summary>
    ITransformationProvider CreateTransformationProvider();

    /// <summary>
    /// Возращает строку запроса для сравнения свойства со значением через равенство (для строк - регистронезависимо)
    /// </summary>
    SqlString EqualToSqlString(
      ICriteria criteria,
      ICriteriaQuery criteriaQuery,
      string lhsPropertyPath,
      [NotNull] IEntityPropertyMetadata lhsPropertyMetadata,
      object rhsValue);

    /// <summary>
    /// Возращает строку запроса для сравнения 2-х свойств через равенство (для строк - регистронезависимо)
    /// </summary>
    SqlString EqualToSqlString(
      ICriteria criteria,
      ICriteriaQuery criteriaQuery,
      SqlString[] lhsColumnNames,
      IEntityPropertyMetadata lhsPropertyMetadata,
      SqlString[] rhsColumnNames,
      IEntityPropertyMetadata rhsPropertyMetadata);
  }
}
