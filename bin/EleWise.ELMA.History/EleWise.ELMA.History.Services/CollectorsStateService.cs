using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.History.Components;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using NHibernate;
using NHibernate.Transform;

namespace EleWise.ELMA.History.Services;

[Service]
internal sealed class CollectorsStateService : ICollectorsStateService
{
	private readonly ITransformationProvider transformationProvider;

	private readonly ISessionProvider sessionProvider;

	private readonly IEnumerable<IEntityHistoryCollectorCacheble> collectors;

	private readonly ISecurityService securityService;

	private const string IndexName = "U_COLLECTORSQUERIES_COLLECTOR";

	private const string QueryParamName = "GueryParam";

	private const string GuidParamName = "GuidParam";

	public CollectorsStateService(ITransformationProvider transformationProvider, IEnumerable<IEntityHistoryCollectorCacheble> collectors, ISessionProvider sessionProvider, ISecurityService securityService)
	{
		this.transformationProvider = transformationProvider;
		this.collectors = collectors;
		this.sessionProvider = sessionProvider;
		this.securityService = securityService;
	}

	public bool CheckCollectors()
	{
		CreateTable();
		IEnumerable<CollectorStateInfo> oldStates = GetStates();
		List<CollectorStateInfo> newStates = new List<CollectorStateInfo>();
		BaseHistoryCollectorCachable.StateCollecting = true;
		securityService.RunWithElevatedPrivilegies(delegate
		{
			newStates.AddRange(collectors.Select((IEntityHistoryCollectorCacheble c) => new CollectorStateInfo(c.CachableCollectorGuid, HibernateHqlAndCriteriaToSqlTranslator.ToSql(c.GetCriteria(1L, c.BaseActionObject)))).ToList());
		});
		BaseHistoryCollectorCachable.StateCollecting = false;
		SaveStates(newStates.Where((CollectorStateInfo q) => !oldStates.Any((CollectorStateInfo oq) => oq.CollectorGuid == q.CollectorGuid)));
		IEnumerable<CollectorStateInfo> enumerable = newStates.Where((CollectorStateInfo q) => oldStates.Any((CollectorStateInfo o) => o.CollectorGuid == q.CollectorGuid && o.Query != q.Query));
		UpdateStates(enumerable);
		if (newStates.Count <= oldStates.Count())
		{
			return enumerable.Any();
		}
		return true;
	}

	private void CreateTable()
	{
		if (!transformationProvider.TableExists("HistoryCollectorsStates"))
		{
			transformationProvider.BeginTransaction();
			try
			{
				Table table = new Table
				{
					Sequence = false,
					Name = "HistoryCollectorsStates",
					Columns = new List<Column>
					{
						new Column("CollectorGuid", new ColumnType(DbType.Guid)),
						new Column("Query", new ColumnType(DbType.String, int.MaxValue))
					}
				};
				transformationProvider.AddTable(table);
				transformationProvider.AddIndex(new Index
				{
					Name = "U_COLLECTORSQUERIES_COLLECTOR",
					TableName = "HistoryCollectorsStates",
					Columns = new List<string> { "CollectorGuid" }
				});
				transformationProvider.CommitTransaction();
			}
			catch (Exception exception)
			{
				transformationProvider.RollbackTransaction();
				Logger.Log.Error(exception, "InitializeCollectorsQueriesTable error");
				throw;
			}
		}
	}

	private IEnumerable<CollectorStateInfo> GetStates()
	{
		return ((IQuery)(object)sessionProvider.GetSession(string.Empty).CreateSQLQuery("SELECT * FROM HistoryCollectorsStates")).CleanUpCache(cleanUpCache: false).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CollectorStateInfo))).List<CollectorStateInfo>();
	}

	private void SaveStates(IEnumerable<CollectorStateInfo> states)
	{
		if (!states.Any())
		{
			return;
		}
		sessionProvider.GetSession(string.Empty);
		string text = string.Format("INSERT INTO {0} ({1}, {2}) VALUES ", transformationProvider.Dialect.QuoteIfNeeded("HistoryCollectorsStates"), transformationProvider.Dialect.QuoteIfNeeded("CollectorGuid"), transformationProvider.Dialect.QuoteIfNeeded("Query"));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		int num = 0;
		foreach (CollectorStateInfo state in states)
		{
			if (num > 0)
			{
				text += ",";
			}
			text = text + '(' + transformationProvider.ParameterSeparator + "GuidParam" + num + ',' + transformationProvider.ParameterSeparator + "GueryParam" + num + ')';
			dictionary.Add("GuidParam" + num, state.CollectorGuid);
			dictionary.Add("GueryParam" + num, state.Query);
			num++;
		}
		transformationProvider.ExecuteNonQuery(text, dictionary);
	}

	private void UpdateStates(IEnumerable<CollectorStateInfo> states)
	{
		foreach (CollectorStateInfo state in states)
		{
			string sql = string.Format("UPDATE {0} SET {1} = {2}{3} WHERE {4} = {2}{5}", transformationProvider.Dialect.QuoteIfNeeded("HistoryCollectorsStates"), transformationProvider.Dialect.QuoteIfNeeded("CollectorGuid"), transformationProvider.ParameterSeparator, "GuidParam", transformationProvider.Dialect.QuoteIfNeeded("Query"), "GueryParam");
			Dictionary<string, object> paramValues = new Dictionary<string, object>
			{
				{ "GueryParam", state.Query },
				{ "GuidParam", state.CollectorGuid }
			};
			transformationProvider.ExecuteNonQuery(sql, paramValues);
		}
	}
}
