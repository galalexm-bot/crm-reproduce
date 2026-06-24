// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Providers.AbstractDbMetadataProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers
{
  /// <summary>Абстрактный класс провайдера информации о БД</summary>
  public abstract class AbstractDbMetadataProvider
  {
    public const string INDEX_NAME_PARAMETER = "IndexName";
    public const string TABLE_NAME_PARAMETER = "TableName";
    public const string COLUMN_NAME_PARAMETER = "ColumnName";
    public const string FOREIGN_KEY_NAME_PARAMETER = "ForeignKeyName";
    public const string PARENT_TABLE_NAME_PARAMETER = "ParentTableName";
    public const string PARENT_COLUMN_NAME_PARAMETER = "ParentColumnName";
    public const string REF_TABLE_NAME_PARAMETER = "ReferenceTableName";
    public const string REF_COLUMN_NAME_PARAMETER = "ReferenceColumnName";
    /// <summary>Провайдер трансформации БД</summary>
    protected ITransformationProvider transformationProvider;
    internal static AbstractDbMetadataProvider ppP88JWkc1BURDS1jCTm;

    /// <summary>ctor</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    public AbstractDbMetadataProvider(ITransformationProvider transform)
    {
      AbstractDbMetadataProvider.FgpV6HWnBrLJXgPxV1ne();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.transformationProvider = transform;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Получить первичные ключи с БД</summary>
    /// <returns>Коллекция первичных ключей, существующих в БД</returns>
    public virtual IEnumerable<PrimaryKey> GetPrimaryKeys()
    {
      Dictionary<string, PrimaryKey> dictionary = new Dictionary<string, PrimaryKey>();
      using (IDataReader dataReader = this.transformationProvider.ExecuteQuery(this.PrimaryKeysScript, (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
        {
          string key = this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886517109)]);
          PrimaryKey primaryKey;
          if (!dictionary.TryGetValue(key, out primaryKey))
          {
            primaryKey = new PrimaryKey()
            {
              Name = key,
              TableName = this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195744753)])
            };
            dictionary[key] = primaryKey;
          }
          primaryKey.Columns.Add(this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312999927)]));
        }
      }
      return (IEnumerable<PrimaryKey>) dictionary.Values;
    }

    /// <summary>Получить индексы с БД</summary>
    /// <returns>Коллекция индексов, существующих в БД</returns>
    public virtual IEnumerable<EleWise.ELMA.Runtime.Db.Migrator.Framework.Index> GetIndexes()
    {
      Dictionary<string, EleWise.ELMA.Runtime.Db.Migrator.Framework.Index> dictionary = new Dictionary<string, EleWise.ELMA.Runtime.Db.Migrator.Framework.Index>();
      using (IDataReader dataReader = this.transformationProvider.ExecuteQuery(this.IndexesScript, (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
        {
          string key = this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281974340)]);
          EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index;
          if (!dictionary.TryGetValue(key, out index))
          {
            index = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index()
            {
              Name = key,
              TableName = this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105331976)])
            };
            dictionary[key] = index;
          }
          index.Columns.Add(this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824518483)]));
        }
      }
      return (IEnumerable<EleWise.ELMA.Runtime.Db.Migrator.Framework.Index>) dictionary.Values;
    }

    /// <summary>Получить внешние ключи с БД</summary>
    /// <returns>Коллекция внешних ключей, существующих в БД</returns>
    public virtual IEnumerable<ForeignKey> GetForeignKeys()
    {
      Dictionary<string, ForeignKey> dictionary = new Dictionary<string, ForeignKey>();
      using (IDataReader dataReader = this.transformationProvider.ExecuteQuery(this.ForeignKeysScript, (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
        {
          string key = this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787018492)]);
          ForeignKey foreignKey;
          if (!dictionary.TryGetValue(key, out foreignKey))
          {
            foreignKey = new ForeignKey()
            {
              Name = key,
              TableName = this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099621313)]),
              RefTableName = this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917126400)])
            };
            dictionary[key] = foreignKey;
          }
          foreignKey.Columns.Add(this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811893252)]));
          foreignKey.RefColumns.Add(this.ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538649152)]));
        }
      }
      return (IEnumerable<ForeignKey>) dictionary.Values;
    }

    /// <summary>
    /// Получить из предоставленного имени идентификатор с учётом диалекта БД
    /// </summary>
    /// <param name="name">Имя (таблицы или колонки)</param>
    /// <returns>Идентификатор (таблицы или колонки)</returns>
    public virtual string GetAsDbIdentifier(string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (AbstractDbMetadataProvider.uaMuTqWnWwGYcOr9jaTq((object) name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            }
            if (AbstractDbMetadataProvider.TWgEIVWnbo7GIyrXWH91(AbstractDbMetadataProvider.gEwmgwWnocX8ckWUZCV6((object) this.transformationProvider), (object) name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 2;
              continue;
            }
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            goto label_6;
        }
      }
label_2:
      return this.ConvertToRegularDbIdentifier(name);
label_3:
      return name;
label_6:
      return (string) null;
    }

    /// <summary>
    /// Преобразовать объект результата запроса в строку с учётом особенностей БД
    /// </summary>
    /// <param name="dbString">Объект результата запроса</param>
    /// <returns>Преобразованная из объекта строка</returns>
    protected virtual string ConvertToString(object dbString) => (string) AbstractDbMetadataProvider.FXMbkbWnhs3uKqxxvhho(dbString);

    /// <summary>SQL-скрипт для выборки внешних ключей</summary>
    protected abstract string ForeignKeysScript { get; }

    /// <summary>SQL-скрипт для выборки первичных ключей</summary>
    protected abstract string PrimaryKeysScript { get; }

    /// <summary>SQL-скрипт для выборки индексов</summary>
    protected abstract string IndexesScript { get; }

    /// <summary>Обернуть идентификатор при необходимости</summary>
    /// <param name="identifier">Идентификатор</param>
    /// <returns>Обернутую строку, если идентификатор является ключевым словом, иначе входная строка</returns>
    protected virtual string Quote(string identifier) => this.transformationProvider.Dialect.QuoteIfNeeded(identifier);

    /// <summary>
    /// Привести идентификатор к обычному виду, который применяется в СУБД, когда он не совпадает с ключевым словом.
    /// <para>Например: в Oracle обычные идентификаторы указываются в Upper Case, в PostgreSQL - в Lower Case, MSSQL - As Is (как есть).</para>
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    protected abstract string ConvertToRegularDbIdentifier(string name);

    internal static void FgpV6HWnBrLJXgPxV1ne() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jobuhJWkzLqx9Z31RwKh() => AbstractDbMetadataProvider.ppP88JWkc1BURDS1jCTm == null;

    internal static AbstractDbMetadataProvider IetnT3WnFmJBWtXsuCtR() => AbstractDbMetadataProvider.ppP88JWkc1BURDS1jCTm;

    internal static bool uaMuTqWnWwGYcOr9jaTq([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object gEwmgwWnocX8ckWUZCV6([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static bool TWgEIVWnbo7GIyrXWH91([In] object obj0, [In] object obj1) => ((Dialect) obj0).IsReservedWord((string) obj1);

    internal static object FXMbkbWnhs3uKqxxvhho([In] object obj0) => (object) Convert.ToString(obj0);
  }
}
