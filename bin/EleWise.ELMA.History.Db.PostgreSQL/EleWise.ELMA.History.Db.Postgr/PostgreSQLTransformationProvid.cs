using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions.PostgreSQL;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.History.Db.PostgreSQL;

[Component]
internal sealed class PostgreSQLTransformationProviderExtension : ITransformationProviderExtension
{
	private readonly bool canUse;

	private static PostgreSQLQueryTableType historyObject;

	private static PostgreSQLQueryTableType historyObjectObserver;

	private static PostgreSQLQueryTableType historyUpdateQueueItem;

	private readonly ITransformationProvider transformationProvider;

	public bool CanUse => canUse;

	public QueryTableType HistoryObject => historyObject ?? (historyObject = new PostgreSQLQueryTableType("HistoryObjectTableType", SysObjectName));

	public QueryTableType HistoryObjectObserver => historyObjectObserver ?? (historyObjectObserver = new PostgreSQLQueryTableType("HistoryObjectObserverTableType", SysObjectName));

	public QueryTableType HistoryUpdateQueueItem => historyUpdateQueueItem ?? (historyUpdateQueueItem = new PostgreSQLQueryTableType("HistoryUpdateQueueItemTableType", SysObjectName));

	public PostgreSQLTransformationProviderExtension(ITransformationProvider transformationProvider)
	{
		canUse = PostgreSQLTransformationProvider.ProviderUID.Equals(transformationProvider.Uid);
		this.transformationProvider = transformationProvider;
	}

	public string SysObjectName(string name)
	{
		if (!transformationProvider.Dialect.IsReservedWord(name))
		{
			name = name.ToLower();
		}
		return name;
	}

	public void InsertIfNotExists(string table, IDictionary<string, object> insertValues, bool isNeedInsertId, IEnumerable<string> columnsToCheck, IDictionary<string, object> paramValues = null)
	{
		Contract.ArgumentNotNull(table, "table");
		Contract.ArgumentNotNull(insertValues, "insertValues");
		if (!insertValues.Any())
		{
			throw new ArgumentException(SR.T("Список параметров для вставки не может быть пустым"));
		}
		transformationProvider.BeginTransaction();
		string arg = transformationProvider.Dialect.QuoteIfNeeded(table);
		Dictionary<string, string> fields = new Dictionary<string, string>();
		Dictionary<string, object> allParams = new Dictionary<string, object>();
		paramValues = paramValues ?? new Dictionary<string, object>();
		foreach (KeyValuePair<string, object> paramValue in paramValues)
		{
			if (!allParams.Keys.Any((string n) => n.Equals(paramValue.Key, StringComparison.CurrentCultureIgnoreCase)))
			{
				allParams.Add(paramValue.Key, paramValue.Value);
			}
		}
		if (isNeedInsertId)
		{
			SqlExpressionParameter value = new SqlExpressionParameter($"nextval('G_{table}')");
			insertValues.Add(transformationProvider.Dialect.QuoteIfNeeded("Id"), value);
		}
		foreach (KeyValuePair<string, object> insertValue in insertValues)
		{
			string key = insertValue.Key;
			object value2 = insertValue.Value;
			if (value2 is SqlExpressionParameter sqlExpressionParameter)
			{
				fields[transformationProvider.Dialect.QuoteIfNeeded(key)] = sqlExpressionParameter.Expression;
				continue;
			}
			string text = "p" + key.Replace("\"", "").Replace("[", "").Replace("]", "");
			fields[transformationProvider.Dialect.QuoteIfNeeded(key)] = transformationProvider.ParameterSeparator + text;
			allParams.Add(text, value2);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("INSERT INTO {0} ({1}) SELECT {2} WHERE NOT EXISTS (SELECT 1 FROM {0}", arg, string.Join(", ", fields.Keys), string.Join(", ", fields.Values));
		if (columnsToCheck != null && columnsToCheck.Any())
		{
			stringBuilder.AppendFormat(" WHERE {0}", string.Join(" AND ", columnsToCheck.Select(delegate(string c)
			{
				string text2 = transformationProvider.Dialect.QuoteIfNeeded(c);
				return $"{text2}={fields[text2]}";
			})));
		}
		stringBuilder.Append(" FOR UPDATE SKIP LOCKED);");
		transformationProvider.ExecuteWithTimeout(0, delegate
		{
			transformationProvider.ExecuteNonQuery(stringBuilder.ToString(), allParams);
		});
		transformationProvider.CommitTransaction();
	}
}
