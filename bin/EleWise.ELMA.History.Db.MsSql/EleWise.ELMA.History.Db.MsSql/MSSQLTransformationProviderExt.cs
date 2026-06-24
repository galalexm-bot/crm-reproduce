using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.History.Db.MsSql;

[Component]
internal sealed class MSSQLTransformationProviderExtension : ITransformationProviderExtension
{
	private readonly bool canUse;

	private bool? useSequence;

	private static MsSqlQueryTableType historyObject;

	private static MsSqlQueryTableType historyObjectObserver;

	private static MsSqlQueryTableType historyUpdateQueueItem;

	private readonly MSSQLTransformationProvider mSSQLTransformationProvider;

	public bool CanUse => canUse;

	public QueryTableType HistoryObject => historyObject ?? (historyObject = new MsSqlQueryTableType("HistoryObjectTableType", SysObjectName));

	public QueryTableType HistoryObjectObserver => historyObjectObserver ?? (historyObjectObserver = new MsSqlQueryTableType("HistoryObjectObserverTableType", SysObjectName));

	public QueryTableType HistoryUpdateQueueItem => historyUpdateQueueItem ?? (historyUpdateQueueItem = new MsSqlQueryTableType("HistoryUpdateQueueItemTableType", SysObjectName));

	public MSSQLTransformationProviderExtension(ITransformationProvider transformationProvider)
	{
		mSSQLTransformationProvider = transformationProvider as MSSQLTransformationProvider;
		canUse = mSSQLTransformationProvider != null;
	}

	public string SysObjectName(string name)
	{
		return mSSQLTransformationProvider.Dialect.QuoteIfNeeded(name);
	}

	public void InsertIfNotExists(string table, IDictionary<string, object> insertValues, bool isNeedInsertId, IEnumerable<string> columnsToCheck, IDictionary<string, object> paramValues = null)
	{
		Contract.ArgumentNotNull(table, "table");
		Contract.ArgumentNotNull(insertValues, "insertValues");
		if (!insertValues.Any())
		{
			throw new ArgumentException(SR.T("Список параметров для вставки не может быть пустым"));
		}
		mSSQLTransformationProvider.BeginTransaction();
		string arg = mSSQLTransformationProvider.Dialect.QuoteIfNeeded(table);
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
		if (isNeedInsertId && mSSQLTransformationProvider.IsSequenceSupport && useSequence.HasValue)
		{
			mSSQLTransformationProvider.CheckSequenceExists(table, 0L);
			useSequence = true;
		}
		if (isNeedInsertId && !insertValues.Keys.Contains("Id"))
		{
			long num = mSSQLTransformationProvider.ReserveIds(1, table)[0];
			insertValues.Add(mSSQLTransformationProvider.Dialect.QuoteIfNeeded("Id"), num);
		}
		foreach (KeyValuePair<string, object> insertValue in insertValues)
		{
			string key = insertValue.Key;
			object value = insertValue.Value;
			if (value is SqlExpressionParameter sqlExpressionParameter)
			{
				fields[mSSQLTransformationProvider.Dialect.QuoteIfNeeded(key)] = sqlExpressionParameter.Expression;
				continue;
			}
			string text = "p" + key.Replace("\"", "").Replace("[", "").Replace("]", "");
			fields[mSSQLTransformationProvider.Dialect.QuoteIfNeeded(key)] = mSSQLTransformationProvider.ParameterSeparator + text;
			allParams.Add(text, value);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("INSERT INTO {0} ({1}) SELECT {2} WHERE NOT EXISTS (SELECT 1 FROM {0} WITH (UPDLOCK, SERIALIZABLE)", arg, string.Join(", ", fields.Keys), string.Join(", ", fields.Values));
		if (columnsToCheck != null && columnsToCheck.Any())
		{
			stringBuilder.AppendFormat(" WHERE {0}", string.Join(" AND ", columnsToCheck.Select(delegate(string c)
			{
				string text2 = mSSQLTransformationProvider.Dialect.QuoteIfNeeded(c);
				return $"{text2}={fields[text2]}";
			})));
		}
		stringBuilder.Append(");");
		mSSQLTransformationProvider.ExecuteWithTimeout(0, delegate
		{
			mSSQLTransformationProvider.ExecuteNonQuery(stringBuilder.ToString(), allParams);
		});
		mSSQLTransformationProvider.CommitTransaction();
	}
}
