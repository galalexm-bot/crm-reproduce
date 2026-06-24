using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Dialect;
using NHibernate.Engine;
using NHibernate.Id;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers;

public abstract class TransformationProvider : TransformationProviderBase, ITransformationProviderAsync, ITransformationProvider, ITransformationProviderBase, IDisposable
{
	protected static readonly string ParamPrefix;

	public const int DefaultLongCommandTimeout = 0;

	public const int DefaultSequenceMaxLo = 100;

	public const int DefaultRetryOnDeadlockCount = 20;

	public const int DefaultRetryOnDeadlockInterval = 300;

	protected readonly ForeignKeyConstraintMapper constraintMapper;

	private Dictionary<string, List<Pair<string, string>>> temporaryColumnNames;

	private Dictionary<KeyValuePair<string, string>, string> deletingColumnNames;

	private Regex createIndexPattern;

	private ConcurrentDictionary<string, IIdentifierGenerator> generatorMap;

	internal static TransformationProvider wcFITEWXPCkPiH2YAHD9;

	public abstract Guid Uid { get; }

	public abstract AbstractDbMetadataProvider DbMetadataProvider { get; }

	protected Func<IDbConnection> ConnectionCreateFunc => connectionCreateFunc ?? FromCurrentSession();

	public static int DefaultExtendedCommandTimeout
	{
		get
		{
			int num = 3;
			int num2 = num;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 3:
					num3 = SR.GetSetting((string)HUgsdnWXtd4YQwhnFhJx(0x34185E55 ^ 0x3419A3D1), 300);
					num2 = 2;
					break;
				case 2:
					if (num3 <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 1:
					return num3;
				default:
					num3 = 300;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool CheckParameterBinding => false;

	public abstract int TableRecordMaxSize { get; }

	public abstract bool HasFullAutoBackupSupport { get; }

	protected virtual Regex CreateIndexPattern
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					createIndexPattern = new Regex((string)HUgsdnWXtd4YQwhnFhJx(0x3CE17B75 ^ 0x3CE37AED), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					if (createIndexPattern == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					break;
				}
				break;
			}
			return createIndexPattern;
		}
	}

	public virtual Task<IDataReader> ExecuteQueryAsync(string sql, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ExecuteQueryBaseAsync(sql, paramValues, isAsync: true, cancellationToken).AsTask();
	}

	public virtual Task<int> ExecuteNonQueryAsync(string sql, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		paramValues = paramValues ?? new Dictionary<string, object>();
		return ExecuteNonQueryBaseAsync(sql, paramValues.Keys.ToReadOnlyCollection(), paramValues.Values.ToReadOnlyCollection(), isAsync: true, cancellationToken).AsTask();
	}

	public virtual Task<object> ExecuteScalarAsync(string sql, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ExecuteScalarBaseAsync(sql, paramValues, isAsync: true, cancellationToken).AsTask();
	}

	public virtual Task<int> InsertAsync(string table, string[] columns, object[] values, CancellationToken cancellationToken = default(CancellationToken))
	{
		return InsertAsync(table, columns, values, isNeedInsertId: false, cancellationToken);
	}

	public virtual Task<int> InsertAsync(string table, string[] columns, object[] values, bool isNeedInsertId, CancellationToken cancellationToken = default(CancellationToken))
	{
		return InsertBaseAsync(table, columns, values, isNeedInsertId, isAsync: true, cancellationToken).AsTask();
	}

	public virtual Task<int> InsertAsync(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ExecuteNonQueryAsync(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFF0528) + table + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889483926) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541728885), columns.Select((string i) => ((Dialect)c8afbIWTVMx7l6O9RAYA(this)).QuoteIfNeeded(i))) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099664375) + selectColName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824262423) + selectFrom, paramValues, cancellationToken);
	}

	public virtual Task<int> UpdateAsync(string table, string[] columns, object[] values, string where, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return UpdateBaseAsync(table, columns, values, where, paramValues, isAsync: true, cancellationToken).AsTask();
	}

	[AsyncStateMachine(typeof(_003CExecuteWithTimeoutAsync_003Ed__7))]
	public Task ExecuteWithTimeoutAsync(int timeout, Func<Task> action)
	{
		_003CExecuteWithTimeoutAsync_003Ed__7 stateMachine = default(_003CExecuteWithTimeoutAsync_003Ed__7);
		stateMachine._003C_003E4__this = this;
		stateMachine.timeout = timeout;
		stateMachine.action = action;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public abstract Task BulkInsertAsync(string tableName, DataTable data, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task BulkInsertAsync(string tableName, DataTable data, bool shouldGenerateId, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task BulkUpdateAsync(string tableName, DataTable data, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task BulkUpdateAsync(string tableName, DataTable data, string keyColumn, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task BulkUpdateAsync(string tableName, DataTable data, List<ColumnLink> keyColumns, CancellationToken cancellationToken = default(CancellationToken));

	public virtual Task<int> BulkDeleteAsync(string table, string where, Dictionary<string, object> paramValues = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return BulkDeleteBaseAsync(table, where, paramValues, isAsync: true, cancellationToken).AsTask();
	}

	public abstract Task<int> BulkDeleteAsync(BulkDeleteArg arg, CancellationToken cancellationToken = default(CancellationToken));

	[AsyncStateMachine(typeof(_003CExecuteNonQueryBaseAsync_003Ed__15))]
	private System.Threading.Tasks.ValueTask<int> ExecuteNonQueryBaseAsync(string sql, IReadOnlyList<string> paramNames, IReadOnlyList<object> paramValues, bool isAsync, CancellationToken cancellationToken)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteNonQueryBaseAsync_003Ed__15 _003CExecuteNonQueryBaseAsync_003Ed__ = default(_003CExecuteNonQueryBaseAsync_003Ed__15);
		_003CExecuteNonQueryBaseAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteNonQueryBaseAsync_003Ed__.sql = sql;
		_003CExecuteNonQueryBaseAsync_003Ed__.paramNames = paramNames;
		_003CExecuteNonQueryBaseAsync_003Ed__.paramValues = paramValues;
		_003CExecuteNonQueryBaseAsync_003Ed__.isAsync = isAsync;
		_003CExecuteNonQueryBaseAsync_003Ed__.cancellationToken = cancellationToken;
		_003CExecuteNonQueryBaseAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CExecuteNonQueryBaseAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CExecuteNonQueryBaseAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CExecuteNonQueryBaseAsync_003Ed__15>(ref _003CExecuteNonQueryBaseAsync_003Ed__);
		return _003CExecuteNonQueryBaseAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	[AsyncStateMachine(typeof(_003CInsertBaseAsync_003Ed__16))]
	private System.Threading.Tasks.ValueTask<int> InsertBaseAsync(string table, IReadOnlyList<string> columns, IReadOnlyList<object> values, bool isNeedInsertId, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		_003CInsertBaseAsync_003Ed__16 _003CInsertBaseAsync_003Ed__ = default(_003CInsertBaseAsync_003Ed__16);
		_003CInsertBaseAsync_003Ed__._003C_003E4__this = this;
		_003CInsertBaseAsync_003Ed__.table = table;
		_003CInsertBaseAsync_003Ed__.columns = columns;
		_003CInsertBaseAsync_003Ed__.values = values;
		_003CInsertBaseAsync_003Ed__.isNeedInsertId = isNeedInsertId;
		_003CInsertBaseAsync_003Ed__.isAsync = isAsync;
		_003CInsertBaseAsync_003Ed__.cancellationToken = cancellationToken;
		_003CInsertBaseAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CInsertBaseAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CInsertBaseAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CInsertBaseAsync_003Ed__16>(ref _003CInsertBaseAsync_003Ed__);
		return _003CInsertBaseAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	[AsyncStateMachine(typeof(_003CUpdateBaseAsync_003Ed__17))]
	private System.Threading.Tasks.ValueTask<int> UpdateBaseAsync(string table, IReadOnlyList<string> columns, IReadOnlyList<object> values, string where, Dictionary<string, object> paramValues, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		_003CUpdateBaseAsync_003Ed__17 _003CUpdateBaseAsync_003Ed__ = default(_003CUpdateBaseAsync_003Ed__17);
		_003CUpdateBaseAsync_003Ed__._003C_003E4__this = this;
		_003CUpdateBaseAsync_003Ed__.table = table;
		_003CUpdateBaseAsync_003Ed__.columns = columns;
		_003CUpdateBaseAsync_003Ed__.values = values;
		_003CUpdateBaseAsync_003Ed__.where = where;
		_003CUpdateBaseAsync_003Ed__.paramValues = paramValues;
		_003CUpdateBaseAsync_003Ed__.isAsync = isAsync;
		_003CUpdateBaseAsync_003Ed__.cancellationToken = cancellationToken;
		_003CUpdateBaseAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CUpdateBaseAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CUpdateBaseAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CUpdateBaseAsync_003Ed__17>(ref _003CUpdateBaseAsync_003Ed__);
		return _003CUpdateBaseAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	[AsyncStateMachine(typeof(_003CBulkDeleteBaseAsync_003Ed__18))]
	private System.Threading.Tasks.ValueTask<int> BulkDeleteBaseAsync(string table, string where, Dictionary<string, object> paramValues, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		_003CBulkDeleteBaseAsync_003Ed__18 _003CBulkDeleteBaseAsync_003Ed__ = default(_003CBulkDeleteBaseAsync_003Ed__18);
		_003CBulkDeleteBaseAsync_003Ed__._003C_003E4__this = this;
		_003CBulkDeleteBaseAsync_003Ed__.table = table;
		_003CBulkDeleteBaseAsync_003Ed__.where = where;
		_003CBulkDeleteBaseAsync_003Ed__.paramValues = paramValues;
		_003CBulkDeleteBaseAsync_003Ed__.isAsync = isAsync;
		_003CBulkDeleteBaseAsync_003Ed__.cancellationToken = cancellationToken;
		_003CBulkDeleteBaseAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<int>.Create();
		_003CBulkDeleteBaseAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<int> _003C_003Et__builder = _003CBulkDeleteBaseAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CBulkDeleteBaseAsync_003Ed__18>(ref _003CBulkDeleteBaseAsync_003Ed__);
		return _003CBulkDeleteBaseAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	[Obsolete("Не использовать", true)]
	public TransformationProvider()
	{
		//Discarded unreachable code: IL_006a, IL_006f
		FinqLEWX3lSUqg2BApY8();
		constraintMapper = new ForeignKeyConstraintMapper();
		temporaryColumnNames = new Dictionary<string, List<Pair<string, string>>>();
		deletingColumnNames = new Dictionary<KeyValuePair<string, string>, string>();
		generatorMap = new ConcurrentDictionary<string, IIdentifierGenerator>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TransformationProvider(Func<IDbConnection> connectionCreateFunc)
	{
		SingletonReader.JJCZtPuTvSt();
		constraintMapper = new ForeignKeyConstraintMapper();
		temporaryColumnNames = new Dictionary<string, List<Pair<string, string>>>();
		deletingColumnNames = new Dictionary<KeyValuePair<string, string>, string>();
		generatorMap = new ConcurrentDictionary<string, IIdentifierGenerator>();
		base._002Ector(connectionCreateFunc);
	}

	public abstract ITransformationProvider CreateWithNewConnection();

	private bool SavePoint(string key, IDbCommand dBCommand)
	{
		//Discarded unreachable code: IL_0041, IL_0050
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (dBCommand == null)
				{
					num2 = 2;
					break;
				}
				goto default;
			default:
				if (YJmYaUWXpkCxM7UlB5Wm(dBCommand) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				}
				return SavePoint(key, (IDbTransaction)YJmYaUWXpkCxM7UlB5Wm(dBCommand));
			case 1:
			case 2:
				return false;
			}
		}
	}

	private void ReleaseSavePoint(string key, IDbCommand dBCommand)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (dBCommand != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 2:
				return;
			case 3:
				return;
			}
			if (YJmYaUWXpkCxM7UlB5Wm(dBCommand) == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 3;
				}
				continue;
			}
			OliiwoWXaQgkaARVX1Wd(this, key, YJmYaUWXpkCxM7UlB5Wm(dBCommand));
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
			{
				num2 = 2;
			}
		}
	}

	private void RollBackSavePoint(string key, IDbCommand dBCommand)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (dBCommand != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 0:
				return;
			case 1:
				if (YJmYaUWXpkCxM7UlB5Wm(dBCommand) == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					break;
				}
				dLqK9pWXDmMSlZJ2GXds(this, key, YJmYaUWXpkCxM7UlB5Wm(dBCommand));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	protected virtual Func<IDbConnection> FromCurrentSession()
	{
		_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass32_0();
		ISession session = base.Session;
		ISessionImplementor val = (ISessionImplementor)(object)((session is ISessionImplementor) ? session : null);
		if (val == null)
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.sifc = val.get_Factory().get_ConnectionProvider();
		return () => (IDbConnection)_003C_003Ec__DisplayClass32_0.SMDgkkQ6PHyWJNbiTyLm(CS_0024_003C_003E8__locals0.sifc);
	}

	public virtual void CheckPrerequisites()
	{
	}

	public virtual string GetDatabaseServerVersion()
	{
		return null;
	}

	public virtual Version GetEngineVersion()
	{
		return null;
	}

	public virtual string GetCurrentSchemaName()
	{
		return string.Empty;
	}

	protected void TransformIntoServerDateTime(DataTable data)
	{
		//Discarded unreachable code: IL_0069, IL_0078, IL_00a4, IL_00b3, IL_00c3, IL_00d2, IL_0117, IL_01af, IL_01be
		int num = 5;
		int num3 = default(int);
		DateTime? dateTime = default(DateTime?);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					num3 = 0;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					return;
				case 2:
				case 15:
					if (QeAKL1WXHUwqREmbDkwE(((DataColumn)UVI86HWX4EmckK8ScyJW(CJeeJhWXweptRXYaopFG(data), num3)).DataType, kcFGHvWX66UvSiChBiyq(typeof(DateTime).TypeHandle)))
					{
						goto end_IL_0012;
					}
					goto case 14;
				case 13:
					dateTime = hsbE9AWXxjXfEwYGMQdG(E7t1xUWX7tjRWJMbbWlJ(data.Rows, num4), num3) as DateTime?;
					num2 = 6;
					break;
				case 17:
					eleATJWXmN1S24iKZntv(((DataRowCollection)BIWfC6WX0hRBpYo8n0PL(data))[num4], num3, dateTime.Value.ToServerDateTime());
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 16;
					}
					break;
				default:
					num3++;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 9;
					}
					break;
				case 10:
				case 11:
					num4 = 0;
					num2 = 7;
					break;
				case 1:
				case 16:
					num4++;
					num2 = 8;
					break;
				case 4:
				case 9:
					if (num3 >= ((InternalDataCollectionBase)CJeeJhWXweptRXYaopFG(data)).Count)
					{
						return;
					}
					num2 = 2;
					break;
				case 14:
					if (!QeAKL1WXHUwqREmbDkwE(Mlg9vNWXAs0Ma7K68RZC(UVI86HWX4EmckK8ScyJW(data.Columns, num3)), kcFGHvWX66UvSiChBiyq(typeof(DateTime?).TypeHandle)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 10;
				case 7:
				case 8:
					if (num4 >= JMy7CMWXymvbGnvfVYGe(BIWfC6WX0hRBpYo8n0PL(data)))
					{
						num2 = 12;
						break;
					}
					goto case 13;
				case 6:
					if (!dateTime.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 17;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	public override int ExecuteNonQuery(string sql, Dictionary<string, object> paramValues = null)
	{
		Contract.ArgumentNotNull(sql, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107952658));
		Contract.ArgumentNotNullOrEmpty(sql, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103E1485));
		paramValues = paramValues ?? new Dictionary<string, object>();
		return ExecuteNonQuery(sql, paramValues.Keys.ToArray(), paramValues.Values.ToArray());
	}

	public virtual int Insert(string table, string[] columns, object[] values)
	{
		return Qe1UqsWXMuEGJHxTGPQa(this, table, columns, values, false);
	}

	public virtual int Insert(string table, string[] columns, object[] values, bool isNeedInsertId)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		ValueTaskAwaiter<int> awaiter = default(ValueTaskAwaiter<int>);
		System.Threading.Tasks.ValueTask<int> valueTask = default(System.Threading.Tasks.ValueTask<int>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				awaiter = valueTask.GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return awaiter.GetResult();
			case 2:
				valueTask = InsertBaseAsync(table, columns, values, isNeedInsertId, isAsync: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual int Insert(string table, string[] columns, string selectColName, string selectFrom, bool isNeedInsertId, Dictionary<string, object> paramValues = null)
	{
		return ExecuteNonQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426163005), table, string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583742218), columns.Select((string i) => (string)mNbVhyWXJlS2ZRZuSPDn(c8afbIWTVMx7l6O9RAYA(this), i))), selectColName, selectFrom), paramValues);
	}

	public virtual int Update(string table, string[] columns, object[] values, string where, Dictionary<string, object> paramValues = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return UpdateBaseAsync(table, columns, values, where, paramValues, isAsync: false).GetAwaiter().GetResult();
	}

	public abstract string GetSqlOrderBy(PropertyMetadata propertyMetadata, string columnName);

	public virtual string GetSqlHierarchicalChilds(string tableName, string parentColumnName, string nameColumnName, long? parentId, int indent, int deep)
	{
		throw new NotImplementedException();
	}

	public abstract string BitAndExpression(string idcolumn, long mask);

	public abstract string BitAndExpression(string idcolumn, string mask);

	public virtual string NoLockTableExpression(string tableName, string alias)
	{
		return (string)MIVZl1WX97yyHeoixXXl(HUgsdnWXtd4YQwhnFhJx(-234299632 ^ -234282688), mNbVhyWXJlS2ZRZuSPDn(Dialect, tableName), alias);
	}

	public virtual string GetProcedureNameFromText(string procedureText)
	{
		return (string)gQrq12WXdI1DBTA9QAnw(procedureText);
	}

	public virtual Index GetIndexInfoFromStatement(string sqlText)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		Match match = default(Match);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = ((IEnumerable<string>)fdSUInWXlyd5IiP4m0Hg(match.Groups[(string)HUgsdnWXtd4YQwhnFhJx(-1921202237 ^ -1921183903)].Value, new char[1] { '.' })).Last();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				match = CreateIndexPattern.Match(sqlText);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				Index obj = new Index
				{
					Name = (string)Dfm11pWX5Y3xSpKfLslA(Dialect, ((Capture)kmh2MvWXgGLA0274iWAh(S8rGWYWXrF4VAcFTKwda(match), HUgsdnWXtd4YQwhnFhJx(0x5DD55050 ^ 0x5DD4AE32))).Value)
				};
				TflSjaWXjlASCOfTFeHd(obj, Dfm11pWX5Y3xSpKfLslA(Dialect, text));
				return obj;
			}
			}
		}
	}

	public virtual void RetryOnDeadlock(Action action, int retryCount)
	{
		//Discarded unreachable code: IL_00ec, IL_01b4, IL_01e7, IL_020a, IL_0219, IL_0278, IL_0287
		int num = 9;
		Random random = default(Random);
		int deadlockRetryIntervalDeviation = default(int);
		int deadlockRetryInterval = default(int);
		int num6 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					DxbkD1WXYwkIbPOn3hGI(action, HUgsdnWXtd4YQwhnFhJx(0x5A4C7B29 ^ 0x5A4D62DD));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					random = new Random();
					num2 = 13;
					continue;
				case 3:
				case 12:
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					return;
				case 4:
					goto end_IL_0012;
				case 6:
					deadlockRetryIntervalDeviation = GetDeadlockRetryIntervalDeviation();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					retryCount = GetDeadlockRetryAttempt();
					num2 = 2;
					continue;
				case 13:
					deadlockRetryInterval = GetDeadlockRetryInterval();
					num2 = 6;
					continue;
				default:
					if (retryCount < 0)
					{
						num2 = 11;
						continue;
					}
					break;
				case 5:
					num6 = random.Next(-deadlockRetryIntervalDeviation, deadlockRetryIntervalDeviation);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 10;
					}
					continue;
				case 10:
					Thread.Sleep((deadlockRetryInterval + num6 * deadlockRetryInterval / 100 + 1) * num5);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					break;
				case 1:
					try
					{
						V0xc5GWXL3eROm9gowxL(action);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (ygDWIqWXUspv6MwfURB8(this, ex))
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
									{
										num4 = 2;
									}
									continue;
								}
								goto case 3;
							case 3:
								throw;
							case 2:
								if (num5 == retryCount + 1)
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
									{
										num4 = 1;
									}
									continue;
								}
								break;
							case 1:
								throw;
							}
							break;
						}
					}
					goto case 5;
				}
				num5 = 1;
				num2 = 12;
				continue;
				end_IL_0012:
				break;
			}
			num5++;
			num = 3;
		}
	}

	public abstract bool IsUnrecoverableException(Exception ex);

	public virtual void ProcessException(Exception ex, IDbConnection dbConnection)
	{
		//Discarded unreachable code: IL_0068, IL_00ca, IL_00d9, IL_00e8
		int num = 6;
		int num2 = num;
		IUnitOfWorkManager unitOfWorkManager = default(IUnitOfWorkManager);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				if (!Qjkgh0WXsTl21FPTg7cY(this, ex))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 2;
			case 4:
				obj = null;
				break;
			case 2:
				if (JHu6bWWXcTR0O9eAN2o1())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 3:
				if (unitOfWorkManager != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return;
			case 1:
				mfA4npWXz4xYBkcEKRuB(unitOfWorkManager, ex);
				num2 = 7;
				continue;
			case 5:
				return;
			case 7:
				return;
			default:
				obj = Locator.GetService<IUnitOfWorkManager>();
				break;
			}
			unitOfWorkManager = (IUnitOfWorkManager)obj;
			num2 = 3;
		}
	}

	public virtual bool SavePoint(string key, IDbTransaction dbTransaction)
	{
		return false;
	}

	public virtual void ReleaseSavePoint(string key, IDbTransaction dbTransaction)
	{
	}

	public virtual void RollBackSavePoint(string key, IDbTransaction dbTransaction)
	{
	}

	protected virtual bool CanRetryAfterException(Exception ex)
	{
		return false;
	}

	public static string UniversalProcedureNameFromText(string procedureText)
	{
		//Discarded unreachable code: IL_0179, IL_0212, IL_0225
		int num = 8;
		string text = default(string);
		Match match = default(Match);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					text = (string)iIQIHnWTWgpyKXtg5Ewd(match.Value);
					num2 = 15;
					continue;
				case 14:
					text = (string)gui2SsWThpT7B06k87Ym(text.Replace((string)HUgsdnWXtd4YQwhnFhJx(-1824388195 ^ -1824326273), "").Replace((string)HUgsdnWXtd4YQwhnFhJx(-105199646 ^ -105238262), ""), HUgsdnWXtd4YQwhnFhJx(-289714582 ^ -289713358), "");
					num2 = 12;
					continue;
				case 3:
					if (!yycXYfWToQIxQ7weEJlH(text2, HUgsdnWXtd4YQwhnFhJx(0x637E299B ^ 0x637E335F)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 17;
				default:
					return text2;
				case 9:
					text = text.Split(new string[1] { (string)HUgsdnWXtd4YQwhnFhJx(--1418440330 ^ 0x548BB44E) }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					if (string.IsNullOrEmpty(procedureText))
					{
						num2 = 7;
						continue;
					}
					match = (Match)fdCCJlWTBrZR2RsSvHeg(u1wMVyWTFhpnnJljCOx5(procedureText), HUgsdnWXtd4YQwhnFhJx(0x7EC153F ^ 0x7EDEB47));
					num2 = 16;
					continue;
				case 18:
					if (!lkeTLeWTGwaIL6RTDXUu(match))
					{
						return string.Empty;
					}
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
				case 11:
					if (!NtxsCmWTb5ujoVSPXxYO(text))
					{
						num2 = 14;
						continue;
					}
					goto case 12;
				case 16:
					if (match.Success)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 2;
						}
						continue;
					}
					match = Regex.Match((string)u1wMVyWTFhpnnJljCOx5(procedureText), (string)HUgsdnWXtd4YQwhnFhJx(0x1637C429 ^ 0x16363A87));
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 5;
					}
					continue;
				case 13:
					text2 = match.Value.Trim();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					return text;
				case 17:
					text2 = ((IEnumerable<string>)F7xFSPWTE3q2t6KOtGdb(text2, new string[1] { (string)HUgsdnWXtd4YQwhnFhJx(-1876063057 ^ -1876060565) }, StringSplitOptions.RemoveEmptyEntries)).LastOrDefault();
					num2 = 6;
					continue;
				case 1:
				case 6:
					if (NtxsCmWTb5ujoVSPXxYO(text2))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 15:
					if (!yycXYfWToQIxQ7weEJlH(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36B1CD)))
					{
						break;
					}
					goto case 9;
				case 4:
					text2 = (string)gui2SsWThpT7B06k87Ym(gui2SsWThpT7B06k87Ym(gui2SsWThpT7B06k87Ym(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475919845), ""), HUgsdnWXtd4YQwhnFhJx(0x571EA399 ^ 0x571E5571), ""), HUgsdnWXtd4YQwhnFhJx(-138018305 ^ -138011481), "");
					num2 = 10;
					continue;
				case 7:
					return string.Empty;
				}
				break;
			}
			num = 5;
		}
	}

	public abstract void BackupTables(string[] tableNames, string[] newTableNames);

	public abstract bool TableExists(string table);

	public virtual void AddTable(Table table)
	{
		//Discarded unreachable code: IL_00c5, IL_00fe, IL_010d, IL_0118, IL_01bd, IL_01d0, IL_01df
		int num = 1;
		int num2 = num;
		List<ForeignKey>.Enumerator enumerator = default(List<ForeignKey>.Enumerator);
		ForeignKey current = default(ForeignKey);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (table.ForeignKeys != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 1:
				Contract.ArgumentNotNull(table, (string)HUgsdnWXtd4YQwhnFhJx(-475857671 ^ -475856357));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				AddTable(table.Name, zZGY93WTfSD03hNLBG9s(table), vB2EWyWTQwj49jAPyyvy(table), table.Columns.ToArray());
				num2 = 4;
				break;
			case 5:
				return;
			case 3:
				enumerator = table.ForeignKeys.GetEnumerator();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num3 = 1;
							}
							goto IL_011c;
						}
						goto IL_017e;
						IL_017e:
						current = enumerator.Current;
						num3 = 3;
						goto IL_011c;
						IL_011c:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 3:
								AddForeignKey(current);
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								break;
							default:
								goto IL_017e;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	public abstract void RenameTable(string oldTableName, string newTableName);

	public abstract void RenameSequence(string oldTableName, string newTableName);

	public abstract int GetTableColumnsSize(string table);

	public virtual void RemoveTable(string tableName, bool removeSequence)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ExecuteNonQuery((string)eUWIxXWTvUXwcluM0RN1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571F5D69), th4WuLWTCoficlLkMVib(this, tableName)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public abstract void AddTableSequence(string tableName);

	public abstract void RemoveTableSequence(string tableName);

	public virtual void InitTableGenerators()
	{
	}

	public abstract bool ColumnExists(string table, string column);

	public virtual void AddColumn(string table, Column column)
	{
		int num = 5;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				throw new DataException((string)MIVZl1WX97yyHeoixXXl(Q25YMBWTI0IQHBaFpJSM(HUgsdnWXtd4YQwhnFhJx(-672123589 ^ -672020525)), column.Name, table));
			case 6:
				DxbkD1WXYwkIbPOn3hGI(column, HUgsdnWXtd4YQwhnFhJx(0x49E27B8A ^ 0x49E38480));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				fVlMmMWT8LuO0H3irfrY(table, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AC323A));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				if (!BcOadbWTu2aBFD9YVqO9(this, table, tiI7oaWTZKB0MmbbtxwA(column)))
				{
					text = (string)QIcOScWTSGccOlYsB2tk(c8afbIWTVMx7l6O9RAYA(this), column, false);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
				}
				break;
			case 5:
				DxbkD1WXYwkIbPOn3hGI(table, HUgsdnWXtd4YQwhnFhJx(0x63ABA4E8 ^ 0x63AA5A0A));
				num2 = 4;
				break;
			default:
				fEeL7JWTipjVFsiraghx(this, table, text, tiI7oaWTZKB0MmbbtxwA(column));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public abstract void RenameColumn(string table, string oldColumnName, string newColumnName);

	public virtual void RemoveColumn(string table, string column)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				text = (string)SW5TQbWTRQiALaZTJyow(this, table, column);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 1:
				DeleteDeletingColumnTemporaryName(table, text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (text == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public abstract void RemoveColumnConstraints(string table, string column);

	public virtual int GetColumnSize(Column column)
	{
		//Discarded unreachable code: IL_005a, IL_0166, IL_01a5
		int num = 5;
		int num2 = num;
		DbType dataType = default(DbType);
		int num4 = default(int);
		int? length = default(int?);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 2:
				num3 = 255;
				break;
			case 6:
				return 4;
			case 7:
				return 1024;
			case 9:
				switch (dataType)
				{
				case DbType.Binary:
					return 0;
				case DbType.Boolean:
					return 2;
				case DbType.Byte:
					return 2;
				case DbType.Currency:
					return 6;
				case DbType.Date:
				case DbType.DateTime:
				case DbType.DateTime2:
				case DbType.DateTimeOffset:
					return 8;
				case DbType.Decimal:
					return 8;
				case DbType.Double:
					return 8;
				case DbType.Guid:
					return 16;
				case DbType.Int16:
					return 2;
				case DbType.Int32:
					return 4;
				case DbType.Int64:
					return 8;
				case DbType.Object:
					return 0;
				case DbType.SByte:
					return 2;
				case DbType.Single:
					return 6;
				case DbType.String:
				case DbType.StringFixedLength:
					break;
				default:
					goto IL_0121;
				case DbType.AnsiString:
				case DbType.AnsiStringFixedLength:
					goto IL_013b;
				case DbType.Time:
					return 4;
				case DbType.UInt16:
					return 2;
				case DbType.UInt32:
					return 4;
				case DbType.UInt64:
					return 8;
				case DbType.VarNumeric:
					return 8;
				case DbType.Xml:
					return 4;
				case (DbType)24:
					goto IL_024b;
				}
				if (num4 > 512)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return num4 * 2;
			case 12:
				goto IL_013b;
			case 5:
				DxbkD1WXYwkIbPOn3hGI(column, HUgsdnWXtd4YQwhnFhJx(0x4785BC0D ^ 0x47844307));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 4;
				}
				continue;
			case 8:
				length = ((ColumnType)aOiKVJWTqa8YmGEkqbMP(column)).Length;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (length.HasValue)
				{
					length = ((ColumnType)aOiKVJWTqa8YmGEkqbMP(column)).Length;
					num2 = 10;
					continue;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				DxbkD1WXYwkIbPOn3hGI(column.ColumnType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837727391));
				num2 = 8;
				continue;
			default:
				return 4;
			case 11:
				goto IL_024b;
			case 3:
				dataType = ((ColumnType)aOiKVJWTqa8YmGEkqbMP(column)).DataType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 9;
				}
				continue;
			case 10:
				{
					num3 = length.Value;
					break;
				}
				IL_024b:
				return 0;
				IL_013b:
				if (num4 <= 1024)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 6;
				IL_0121:
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 11;
				}
				continue;
			}
			num4 = num3;
			num2 = 3;
		}
	}

	public virtual bool NeedStringColumnTransform(string tableName, string columnName)
	{
		return false;
	}

	public virtual void ConvertColumnString(string tableName, string columnName, int columnSize)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				M34GdGWTK2w7GnJdjXXq(this, tableName, columnName, columnSize, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void ConvertColumnString(string tableName, string columnName, int columnSize, bool substringStrings)
	{
		//Discarded unreachable code: IL_00da, IL_00e9
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!ColumnExists(tableName, columnName))
				{
					num2 = 7;
					break;
				}
				text = GenerateColumnTemporaryName(tableName, columnName);
				num2 = 3;
				break;
			case 8:
				return;
			case 1:
				return;
			case 7:
				return;
			case 5:
				qw135nWTkujsqlYvoCK8(this, tableName, new Column(columnName, new ColumnType(DbType.String, columnSize)));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				if (!QKTOkiWTXpqniq8J75xn(this, tableName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
				RemoveColumn(tableName, text);
				num2 = 8;
				break;
			case 3:
				wHjXj9WTTxTFIWxY5oBI(this, tableName, columnName, text);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				ExecuteNonQuery((string)lsc52dWTnSNR5IjpkEjk(HUgsdnWXtd4YQwhnFhJx(-1123633026 ^ -1123596482), mNbVhyWXJlS2ZRZuSPDn(Dialect, tableName), ((Dialect)c8afbIWTVMx7l6O9RAYA(this)).QuoteIfNeeded(columnName), substringStrings ? ((Dialect)c8afbIWTVMx7l6O9RAYA(this)).Substring((string)mNbVhyWXJlS2ZRZuSPDn(Dialect, text), 1, (int?)columnSize) : ((Dialect)c8afbIWTVMx7l6O9RAYA(this)).QuoteIfNeeded(text)));
				num2 = 4;
				break;
			}
		}
	}

	public virtual void ConvertColumnStringIfNeed(string tableName, string columnName, int columnSize)
	{
		//Discarded unreachable code: IL_0059, IL_0068
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!apQ6i5WTOht9x51VqZ1q(this, tableName, columnName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 3:
				return;
			}
			AgHKpJWT2cf4s4Vkp062(this, tableName, columnName, columnSize);
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
			{
				num2 = 2;
			}
		}
	}

	public virtual string GenerateDeletingColumnTemporaryName(string tableName, string columnName)
	{
		int num = 2;
		int num2 = num;
		KeyValuePair<string, string> key = default(KeyValuePair<string, string>);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				DxbkD1WXYwkIbPOn3hGI(columnName, HUgsdnWXtd4YQwhnFhJx(0x103FE975 ^ 0x103E1605));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				key = new KeyValuePair<string, string>((string)Jn4UQMWTek4uxF6h5VkE(tableName), (string)Jn4UQMWTek4uxF6h5VkE(columnName));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				deletingColumnNames[key] = text;
				num2 = 4;
				break;
			case 5:
				text = (string)RPFKGhWTPJVyHgXFQuik(this, tableName, columnName);
				num2 = 3;
				break;
			case 2:
				DxbkD1WXYwkIbPOn3hGI(tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870808427));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return text;
			}
		}
	}

	public virtual string GenerateColumnTemporaryName(string tableName, string columnName)
	{
		//Discarded unreachable code: IL_00bf, IL_02b9, IL_02c8
		int num = 16;
		_003C_003Ec__DisplayClass89_0 _003C_003Ec__DisplayClass89_ = default(_003C_003Ec__DisplayClass89_0);
		List<Pair<string, string>> value = default(List<Pair<string, string>>);
		string temporaryName = default(string);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					_003C_003Ec__DisplayClass89_.temporaryName = (string)HUgsdnWXtd4YQwhnFhJx(-138018305 ^ -137888137);
					num2 = 17;
					continue;
				case 13:
					temporaryColumnNames.Add((string)Jn4UQMWTek4uxF6h5VkE(tableName), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 14;
					}
					continue;
				case 14:
					temporaryName = _003C_003Ec__DisplayClass89_.temporaryName;
					num2 = 10;
					continue;
				case 9:
				case 11:
					_003C_003Ec__DisplayClass89_.temporaryName = (string)APrideWTNw058Md1SOJi(_003C_003Ec__DisplayClass89_.temporaryName, columnName, HUgsdnWXtd4YQwhnFhJx(-2099751081 ^ -2099750099));
					num2 = 18;
					continue;
				case 10:
					num3 = 0;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					value = new List<Pair<string, string>>();
					num2 = 13;
					continue;
				case 2:
					break;
				case 12:
					if (!value.Exists(_003C_003Ec__DisplayClass89_._003CGenerateColumnTemporaryName_003Eb__0))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 5;
				case 8:
					columnName = columnName.Substring(0, 20);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 11;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass89_.temporaryName = (string)G6qBvPWT33TL3lyoqYIU(temporaryName, num3);
					num2 = 6;
					continue;
				default:
					DxbkD1WXYwkIbPOn3hGI(columnName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411176739));
					num2 = 19;
					continue;
				case 17:
					if (M02wnCWT1cvi6iMqZWuF(columnName) <= 25)
					{
						num2 = 9;
						continue;
					}
					goto case 8;
				case 4:
					return _003C_003Ec__DisplayClass89_.temporaryName;
				case 5:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
				case 7:
					if (!BcOadbWTu2aBFD9YVqO9(this, tableName, _003C_003Ec__DisplayClass89_.temporaryName))
					{
						num2 = 12;
						continue;
					}
					goto case 5;
				case 16:
					_003C_003Ec__DisplayClass89_ = new _003C_003Ec__DisplayClass89_0();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 15;
					}
					continue;
				case 15:
					Contract.ArgumentNotNull(tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583727018));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					if (!temporaryColumnNames.TryGetValue((string)Jn4UQMWTek4uxF6h5VkE(tableName), out value))
					{
						num2 = 3;
						continue;
					}
					goto case 14;
				}
				break;
			}
			value.Add(new Pair<string, string>((string)Jn4UQMWTek4uxF6h5VkE(_003C_003Ec__DisplayClass89_.temporaryName), columnName.ToUpper()));
			num = 4;
		}
	}

	public virtual string GetDeletingColumnTemporaryName(string tableName, string columnName)
	{
		int num = 3;
		KeyValuePair<string, string> key = default(KeyValuePair<string, string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					if (!deletingColumnNames.TryGetValue(key, out var value))
					{
						num2 = 4;
						continue;
					}
					return value;
				}
				case 2:
					Contract.ArgumentNotNull(columnName, (string)HUgsdnWXtd4YQwhnFhJx(0x2A7797B7 ^ 0x2A7668C7));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				case 4:
					return columnName;
				case 1:
					key = new KeyValuePair<string, string>((string)Jn4UQMWTek4uxF6h5VkE(tableName), (string)Jn4UQMWTek4uxF6h5VkE(columnName));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			DxbkD1WXYwkIbPOn3hGI(tableName, HUgsdnWXtd4YQwhnFhJx(-643786247 ^ -643739301));
			num = 2;
		}
	}

	public abstract bool ConstraintExists(string table, string name);

	public abstract List<ForeignKey> GetForeignKeys(string tableName);

	public virtual void AddForeignKey(ForeignKey foreignKey)
	{
		//Discarded unreachable code: IL_0207, IL_0216
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass93_0 _003C_003Ec__DisplayClass93_ = default(_003C_003Ec__DisplayClass93_0);
		while (true)
		{
			switch (num2)
			{
			case 11:
				ExecuteWithTimeout(0, _003C_003Ec__DisplayClass93_._003CAddForeignKey_003Eb__0);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 10;
				}
				break;
			case 7:
				DxbkD1WXYwkIbPOn3hGI(_003C_003Ec__DisplayClass93_.foreignKey, HUgsdnWXtd4YQwhnFhJx(-1426094279 ^ -1426163539));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 8;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass93_.onUpdateConstraintResolved = (string)iipkVfWTanfGoKphhPBI(constraintMapper, _003C_003Ec__DisplayClass93_.foreignKey.UpdateAction);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 2:
				_003C_003Ec__DisplayClass93_.onDeleteConstraintResolved = (string)iipkVfWTanfGoKphhPBI(constraintMapper, _003C_003Ec__DisplayClass93_.foreignKey.DeleteAction);
				num2 = 6;
				break;
			case 4:
				_003C_003Ec__DisplayClass93_._003C_003E4__this = this;
				num2 = 9;
				break;
			case 9:
				_003C_003Ec__DisplayClass93_.foreignKey = foreignKey;
				num2 = 7;
				break;
			case 10:
				return;
			case 5:
				_003C_003Ec__DisplayClass93_ = new _003C_003Ec__DisplayClass93_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 4;
				}
				break;
			default:
				_003C_003Ec__DisplayClass93_.columnNames = _003C_003Ec__DisplayClass93_.foreignKey.Columns.Select(QuoteIfNeeded).ToArray();
				num2 = 3;
				break;
			case 3:
				_003C_003Ec__DisplayClass93_.refColumnNames = _003C_003Ec__DisplayClass93_.foreignKey.RefColumns.Select(QuoteIfNeeded).ToArray();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 11;
				}
				break;
			case 8:
				if (ConstraintExists((string)a7D8cxWTpTmTRWQiPyOT(_003C_003Ec__DisplayClass93_.foreignKey), _003C_003Ec__DisplayClass93_.foreignKey.Name))
				{
					return;
				}
				num2 = 2;
				break;
			}
		}
	}

	public virtual void RemoveForeignKey(string tableName, string fkName)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass94_0 _003C_003Ec__DisplayClass94_ = default(_003C_003Ec__DisplayClass94_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				ExecuteWithTimeout(0, _003C_003Ec__DisplayClass94_._003CRemoveForeignKey_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass94_.fkName = fkName;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass94_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 0:
				return;
			case 2:
				_003C_003Ec__DisplayClass94_ = new _003C_003Ec__DisplayClass94_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass94_.tableName = tableName;
				num2 = 5;
				break;
			}
		}
	}

	public virtual void RemoveForeignKeys(IList<string> skipNames, IList<string> useNames)
	{
		IEnumerable<KeyValuePair<string, string>> items = from fk in GetForeignKeys()
			select new KeyValuePair<string, string>(fk.TableName, fk.Name);
		ExecuteMethod(skipNames, useNames, items, delegate(KeyValuePair<string, string> p)
		{
			RemoveForeignKey(p.Key, p.Value);
		});
	}

	public virtual void AddPrimaryKey(PrimaryKey primaryKey)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				AddPrimaryKey(primaryKey.Name, (string)JfvglTWTDhek8QggO44p(primaryKey), (string[])FGAdBZWTtYkIGidQptRN(primaryKey.Columns));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void RemovePrimaryKey(string tableName, string pkName)
	{
		//Discarded unreachable code: IL_0059
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (AUe37iWTwCK8BTafFv9v(this, tableName, pkName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				return;
			default:
				ExecuteNonQuery((string)MIVZl1WX97yyHeoixXXl(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92EED79), QuoteIfNeeded(tableName), th4WuLWTCoficlLkMVib(this, pkName)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual void RemovePrimaryKeys(IList<string> skipNames = null, IList<string> useNames = null)
	{
		ExecuteMethod(skipNames, useNames, GetPrimaryKeys(), delegate(KeyValuePair<string, string> p)
		{
			RemovePrimaryKey(p.Key, p.Value);
		});
	}

	public virtual List<KeyValuePair<string, string>> GetPrimaryKeys()
	{
		return new List<KeyValuePair<string, string>>();
	}

	public virtual PrimaryKey GetPrimaryKeyByTable(string table)
	{
		return null;
	}

	protected virtual string GetIndexNameByForeignKey(string fkName)
	{
		//Discarded unreachable code: IL_00a6, IL_00b5
		int num = 2;
		int num2 = num;
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 2:
				if (Dy6BhLWT4Ibx0VoZBox6(fkName, HUgsdnWXtd4YQwhnFhJx(-234299632 ^ -234282778), StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				result = (string)eUWIxXWTvUXwcluM0RN1(HUgsdnWXtd4YQwhnFhJx(0x103FE975 ^ 0x103DE973), fkName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				result = (string)eUWIxXWTvUXwcluM0RN1(HUgsdnWXtd4YQwhnFhJx(-105199646 ^ -105170916), NlYql1WT6YapEQiOCZcE(fkName, 2));
				num2 = 3;
				break;
			}
		}
	}

	public abstract string[] GetTableColumnsNames(string tableName);

	public virtual void RemoveTrigger(string tableName, string triggerName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ExecuteNonQuery((string)eUWIxXWTvUXwcluM0RN1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740469308), QuoteIfNeeded(triggerName)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void RemoveTriggers(IList<string> skipNames, IList<string> useNames)
	{
		ExecuteMethod(skipNames, useNames, GetTriggers(), delegate(KeyValuePair<string, string> p)
		{
			RemoveTrigger(p.Key, p.Value);
		});
	}

	protected abstract List<KeyValuePair<string, string>> GetTriggers();

	public virtual void RemoveProcedure(string procedureName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ExecuteNonQuery((string)eUWIxXWTvUXwcluM0RN1(HUgsdnWXtd4YQwhnFhJx(0x7C1EE318 ^ 0x7C1CE336), th4WuLWTCoficlLkMVib(this, procedureName)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void RemoveProcedures(IList<string> skipNames, IList<string> useNames)
	{
		ExecuteMethod(skipNames, useNames, GetProcedures(), delegate(string p)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					yIoVZ6WT5JCAZw4B0qj7(this, p);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
	}

	protected abstract List<string> GetProcedures();

	public virtual string TableFunction(string name, string @params)
	{
		return (string)MIVZl1WX97yyHeoixXXl(HUgsdnWXtd4YQwhnFhJx(-561074844 ^ -561088726), name, @params);
	}

	public virtual void RemoveView(string viewName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ExecuteNonQuery((string)HUgsdnWXtd4YQwhnFhJx(0x10E41EDB ^ 0x10E61E8B) + (string)th4WuLWTCoficlLkMVib(this, viewName));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void RemoveViews(IList<string> skipNames, IList<string> useNames)
	{
		ExecuteMethod(skipNames, useNames, GetViews(), delegate(string p)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					v0MtnoWTjH1ul91eqxUZ(this, p);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	public abstract List<string> GetIndexes(string tableName);

	public abstract void AddUniqueIndex(Index index);

	public abstract void AddIndex(Index index);

	public virtual void AddNvlIndex(Index index)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				okCqYYWTHxKYAoP4Ftv6(this, index);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public abstract bool IndexExists(string tableName, string indexName);

	public virtual void RemoveIndex(string tableName, string indexName)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass117_0 _003C_003Ec__DisplayClass117_ = default(_003C_003Ec__DisplayClass117_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				_003C_003Ec__DisplayClass117_ = new _003C_003Ec__DisplayClass117_0();
				num2 = 2;
				break;
			case 4:
				ExecuteWithTimeout(0, _003C_003Ec__DisplayClass117_._003CRemoveIndex_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass117_._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass117_.indexName = indexName;
				num2 = 4;
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void RemoveIndexes(IList<string> skipNames, IList<string> useNames)
	{
		ExecuteMethod(skipNames, useNames, GetIndexes(), delegate(KeyValuePair<string, string> p)
		{
			RemoveIndex(p.Key, p.Value);
		});
	}

	public virtual string GenerateIndexName()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C24613));
		paEffGWTxpKWVy7C0KGW(stringBuilder, RpOH9hWT7HNgRPEDtRjg(LjGZCcWTAT4yFW5bpbvU().ToString((string)HUgsdnWXtd4YQwhnFhJx(-672123589 ^ -672084109)), 0, 24));
		return stringBuilder.ToString();
	}

	protected abstract List<KeyValuePair<string, string>> GetIndexes();

	public virtual void DisableIndexOnTable(string tableName)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass121_0 _003C_003Ec__DisplayClass121_ = default(_003C_003Ec__DisplayClass121_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass121_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass121_.tableName = tableName;
				num2 = 2;
				break;
			case 2:
				ExecuteWithTimeout(0, _003C_003Ec__DisplayClass121_._003CDisableIndexOnTable_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass121_ = new _003C_003Ec__DisplayClass121_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public virtual void RebuildIndexOnTable(string tableName)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass122_0 _003C_003Ec__DisplayClass122_ = default(_003C_003Ec__DisplayClass122_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass122_ = new _003C_003Ec__DisplayClass122_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				_003C_003Ec__DisplayClass122_.tableName = tableName;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				ExecuteWithTimeout(0, _003C_003Ec__DisplayClass122_._003CRebuildIndexOnTable_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				return;
			case 1:
				_003C_003Ec__DisplayClass122_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public abstract string GetDisableIndexOnTable(string tableName);

	public abstract string GetRebuildIndexOnTable(string tableName);

	public abstract string BackupDatabase(string connectionString, string outputPath);

	public abstract DateTime GetDateTimeNow();

	public abstract DateTime GetUtcDateTimeNow();

	protected void EnsureHasConnection()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				NErxTEWTmb9CKE36MhPL(I2RZT7WT0DaunAb21A5A(this));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (((IDbConnection)I2RZT7WT0DaunAb21A5A(this)).State == ConnectionState.Open)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual object GetLobString(IDataReader rs, string name)
	{
		return YqTfu3WTMBZx7he1c7gT(NHibernateUtil.StringClob, (DbDataReader)rs, name, Q0cHoIWTyo0TxkhqDJGe(base.Session));
	}

	protected virtual int ExecuteNonQuery(string sql, string[] paramnames, object[] paramvalues)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		System.Threading.Tasks.ValueTask<int> valueTask = default(System.Threading.Tasks.ValueTask<int>);
		ValueTaskAwaiter<int> awaiter = default(ValueTaskAwaiter<int>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				valueTask = ExecuteNonQueryBaseAsync(sql, paramnames, paramvalues, isAsync: false, tSBP0BWTJdFa0uRBw4ey());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				awaiter = valueTask.GetAwaiter();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return awaiter.GetResult();
			}
		}
	}

	protected override string QuoteIfNeeded(string name)
	{
		return (string)mNbVhyWXJlS2ZRZuSPDn(c8afbIWTVMx7l6O9RAYA(this), name);
	}

	protected List<string> GetPrimaryKeys(IEnumerable<Column> columns)
	{
		return (from column in columns
			where _003C_003Ec.EjMrohQ4cWbpulqZmZsC(column)
			select (string)_003C_003Ec.gBlLIZQ4zt4Zem7nLbZk(column)).ToList();
	}

	protected virtual void AddTable(string name, bool sequence, bool isTemporary, params Column[] columns)
	{
		//Discarded unreachable code: IL_00c0, IL_00cf, IL_01a6, IL_0217, IL_0226, IL_0235
		int num = 16;
		int num2 = num;
		Column column = default(Column);
		string text = default(string);
		List<string> list = default(List<string>);
		Column[] array = default(Column[]);
		string item = default(string);
		bool flag = default(bool);
		List<string> primaryKeys = default(List<string>);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 16:
				if (!TableExists(name))
				{
					num2 = 15;
					continue;
				}
				goto case 13;
			case 2:
				return;
			case 10:
				return;
			case 12:
			{
				Column column2 = column;
				h37VAiWTrqwitMpDOOBo(column2, MYscFcWTlmJrEfaXpdvM(column2) | ColumnProperty.NotNull);
				num2 = 14;
				continue;
			}
			case 8:
				text = list.ToCommaSeparatedString();
				num2 = 17;
				continue;
			case 6:
				if (APvbZZWTd1XyT16Xdxra(column))
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			case 21:
				array = columns;
				num2 = 11;
				continue;
			case 4:
				list.Add(item);
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 22;
				}
				continue;
			case 17:
				rMhHKUWTgnJkN1Fyki2f(this, name, text, sequence, isTemporary);
				num2 = 7;
				continue;
			case 20:
				flag = primaryKeys.Count > 1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				continue;
			case 13:
				throw new DataException((string)rjY3ySWT9JKkoqHPyZ5g(Q25YMBWTI0IQHBaFpJSM(HUgsdnWXtd4YQwhnFhJx(0x48A7E34A ^ 0x48A6176C)), name));
			case 15:
				primaryKeys = GetPrimaryKeys(columns);
				num2 = 20;
				continue;
			case 5:
			case 18:
				column = array[num3];
				num2 = 9;
				continue;
			case 3:
				AddPrimaryKey((string)rjY3ySWT9JKkoqHPyZ5g(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D3264), name), name, primaryKeys.ToArray());
				num2 = 2;
				continue;
			case 11:
				num3 = 0;
				num2 = 19;
				continue;
			case 1:
			case 19:
				if (num3 < array.Length)
				{
					num2 = 18;
					continue;
				}
				goto case 8;
			default:
				list = new List<string>(columns.Length);
				num2 = 21;
				continue;
			case 7:
				if (!flag)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto case 3;
			case 9:
				if (flag)
				{
					num2 = 6;
					continue;
				}
				break;
			case 22:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				continue;
			case 14:
				break;
			}
			item = (string)QIcOScWTSGccOlYsB2tk(c8afbIWTVMx7l6O9RAYA(this), column, flag);
			num2 = 4;
		}
	}

	protected virtual void AddTable(string name, bool sequence, params Column[] columns)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				AddTable(name, sequence, isTemporary: false, columns);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void AddTable(string table, string columns, bool sequence)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				rMhHKUWTgnJkN1Fyki2f(this, table, columns, sequence, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void AddTable(string table, string columns, bool sequence, bool isTemporary)
	{
		int num = 1;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				ExecuteNonQuery(sql);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				sql = (string)MIVZl1WX97yyHeoixXXl(HUgsdnWXtd4YQwhnFhJx(-477139494 ^ -477270692), th4WuLWTCoficlLkMVib(this, table), columns);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void AddPrimaryKey(string name, string table, params string[] columns)
	{
		int num = 5;
		_003C_003Ec__DisplayClass139_0 _003C_003Ec__DisplayClass139_ = default(_003C_003Ec__DisplayClass139_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (AUe37iWTwCK8BTafFv9v(this, table, name))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					_003C_003Ec__DisplayClass139_.sql = (string)lsc52dWTnSNR5IjpkEjk(HUgsdnWXtd4YQwhnFhJx(-2138160520 ^ -2138291506), th4WuLWTCoficlLkMVib(this, table), th4WuLWTCoficlLkMVib(this, name), columns.Select(QuoteIfNeeded).ToCommaSeparatedString());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 2;
					}
					continue;
				case 0:
					return;
				case 2:
					break;
				case 3:
					return;
				case 5:
					_003C_003Ec__DisplayClass139_ = new _003C_003Ec__DisplayClass139_0();
					num2 = 4;
					continue;
				case 4:
					_003C_003Ec__DisplayClass139_._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			ExecuteWithTimeout(0, _003C_003Ec__DisplayClass139_._003CAddPrimaryKey_003Eb__0);
			num = 3;
		}
	}

	protected void CheckConstraintNotExists(string table, string name)
	{
		//Discarded unreachable code: IL_007c, IL_008b
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!AUe37iWTwCK8BTafFv9v(this, table, name))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return;
			}
			break;
		}
		throw new DataException((string)rjY3ySWT9JKkoqHPyZ5g(Q25YMBWTI0IQHBaFpJSM(HUgsdnWXtd4YQwhnFhJx(0x4EDCBA32 ^ 0x4EDEBB16)), name));
	}

	protected abstract void AddColumn(string table, string sqlColumn, string columnName);

	protected Dictionary<string, List<string>> ConvertItemNames(IList<string> itemNames)
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		if (itemNames == null)
		{
			return dictionary;
		}
		foreach (string itemName in itemNames)
		{
			if (!string.IsNullOrEmpty(itemName))
			{
				string key = string.Empty;
				string text = itemName.ToUpper();
				int num = itemName.IndexOf('.');
				if (num >= 0)
				{
					key = itemName.Substring(0, num).ToUpper();
					text = itemName.Substring(num + 1).ToUpper();
				}
				if (!dictionary.TryGetValue(key, out var value))
				{
					value = new List<string>();
					dictionary.Add(key, value);
				}
				if (text != string.Empty && !value.Contains(text))
				{
					value.Add(text);
				}
			}
		}
		return dictionary;
	}

	protected bool ItemNameContains(Dictionary<string, List<string>> dict, string itemName)
	{
		itemName = itemName.ToUpper();
		if (dict != null)
		{
			foreach (List<string> value in dict.Values)
			{
				if (value.Contains(itemName))
				{
					return true;
				}
			}
		}
		return false;
	}

	protected bool ItemNameContains(Dictionary<string, List<string>> dict, string tableName, string itemName)
	{
		itemName = itemName.ToUpper();
		tableName = ((tableName != null) ? tableName.ToUpper() : string.Empty);
		if (dict.TryGetValue(tableName, out var value) && ItemNameContains(value, itemName))
		{
			return true;
		}
		if (tableName != string.Empty && dict.TryGetValue(string.Empty, out value) && ItemNameContains(value, itemName))
		{
			return true;
		}
		return false;
	}

	protected virtual string DeleteColumnTemporaryName(string tableName, string temporaryName)
	{
		//Discarded unreachable code: IL_0111, IL_0120
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass145_0 _003C_003Ec__DisplayClass145_ = default(_003C_003Ec__DisplayClass145_0);
		List<Pair<string, string>> value = default(List<Pair<string, string>>);
		Pair<string, string> pair = default(Pair<string, string>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				DxbkD1WXYwkIbPOn3hGI(tableName, HUgsdnWXtd4YQwhnFhJx(-787452571 ^ -787372601));
				num2 = 8;
				break;
			case 5:
				_003C_003Ec__DisplayClass145_.temporaryName = temporaryName;
				num2 = 4;
				break;
			case 2:
				if (!value.Remove(pair))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 7:
				if (temporaryColumnNames.TryGetValue((string)Jn4UQMWTek4uxF6h5VkE(tableName), out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				pair = value.Find(_003C_003Ec__DisplayClass145_._003CDeleteColumnTemporaryName_003Eb__0);
				num2 = 2;
				break;
			case 8:
				Contract.ArgumentNotNull(_003C_003Ec__DisplayClass145_.temporaryName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36126551));
				num2 = 7;
				break;
			case 1:
				return pair.Second;
			case 3:
				return null;
			case 6:
				_003C_003Ec__DisplayClass145_ = new _003C_003Ec__DisplayClass145_0();
				num2 = 5;
				break;
			}
		}
	}

	protected virtual void DeleteDeletingColumnTemporaryName(string tableName, string columnName)
	{
		int num = 1;
		KeyValuePair<string, string> key = default(KeyValuePair<string, string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 4:
					deletingColumnNames.Remove(key);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					key = new KeyValuePair<string, string>((string)Jn4UQMWTek4uxF6h5VkE(tableName), (string)Jn4UQMWTek4uxF6h5VkE(columnName));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					DxbkD1WXYwkIbPOn3hGI(tableName, HUgsdnWXtd4YQwhnFhJx(-1638402543 ^ -1638515021));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			DxbkD1WXYwkIbPOn3hGI(columnName, HUgsdnWXtd4YQwhnFhJx(0x4DC2B14D ^ 0x4DC34E3D));
			num = 3;
		}
	}

	protected string CreateParamName(params object[] args)
	{
		return string.Concat(ParamPrefix, string.Concat(args));
	}

	private bool ItemNameContains(List<string> list, string name)
	{
		foreach (string item in list)
		{
			if (item.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C4CB4)))
			{
				string value = item.Substring(0, item.Length - 1);
				if (name.StartsWith(value, StringComparison.CurrentCultureIgnoreCase))
				{
					return true;
				}
			}
			else if (name.Equals(item, StringComparison.CurrentCultureIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	protected void ExecuteMethod(IList<string> skipNames, IList<string> useNames, IEnumerable<KeyValuePair<string, string>> items, Action<KeyValuePair<string, string>> itemAction)
	{
		Dictionary<string, List<string>> dict = ConvertItemNames(skipNames);
		Dictionary<string, List<string>> dictionary = ((useNames != null) ? ConvertItemNames(useNames) : null);
		foreach (KeyValuePair<string, string> item in items)
		{
			if (!ItemNameContains(dict, item.Key, item.Value) && (dictionary == null || ItemNameContains(dictionary, item.Key, item.Value)))
			{
				itemAction(item);
			}
		}
	}

	protected void ExecuteMethod(IList<string> skipNames, IList<string> useNames, List<string> items, Action<string> itemAction)
	{
		Dictionary<string, List<string>> dict = ConvertItemNames(skipNames);
		Dictionary<string, List<string>> dictionary = ((useNames != null) ? ConvertItemNames(useNames) : null);
		foreach (string item in items)
		{
			if (!item.IsNullOrWhiteSpace() && ((!ItemNameContains(dict, item) && dictionary == null) || ItemNameContains(dictionary, item)))
			{
				itemAction(item);
			}
		}
	}

	private int GetDeadlockRetryInterval()
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 3;
		int num2 = num;
		int setting = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				setting = SR.GetSetting((string)HUgsdnWXtd4YQwhnFhJx(-1978478350 ^ -1978608954), 300);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (setting > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return 300;
			default:
				return setting;
			}
		}
	}

	private int GetDeadlockRetryIntervalDeviation()
	{
		//Discarded unreachable code: IL_0037, IL_0046
		int num = 2;
		int setting = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 20;
				case 3:
					return setting;
				case 2:
					setting = SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA742AC), 20);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (setting > 0)
					{
						break;
					}
					goto default;
				}
				break;
			}
			num = 3;
		}
	}

	private int GetDeadlockRetryAttempt()
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 1;
		int num2 = num;
		int setting = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				setting = SR.GetSetting((string)HUgsdnWXtd4YQwhnFhJx(0x4785BC0D ^ 0x4787BEF3), 20);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (setting > 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 2:
				return 20;
			case 3:
				return setting;
			}
		}
	}

	public abstract void BulkInsert(string tableName, DataTable data);

	public abstract void BulkInsert(string tableName, DataTable data, bool shouldGenerateId);

	public abstract void BulkUpdate(string tableName, DataTable data);

	public abstract void BulkUpdate(string tableName, DataTable data, string keyColumn);

	public abstract void BulkUpdate(string tableName, DataTable data, List<ColumnLink> keyColumns);

	public virtual long ReserveId(int count, string tableName)
	{
		return ReserveIds(count, tableName)[0];
	}

	public virtual long[] ReserveIds(int count, string tableName)
	{
		return new long[0];
	}

	protected internal virtual long[] ReserveIds(int count, string table, Func<Dictionary<string, string>, IIdentifierGenerator> createGenerator, Func<long[]> reserveIdRange)
	{
		_003C_003Ec__DisplayClass169_0 _003C_003Ec__DisplayClass169_ = new _003C_003Ec__DisplayClass169_0();
		_003C_003Ec__DisplayClass169_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass169_.table = table;
		_003C_003Ec__DisplayClass169_.createGenerator = createGenerator;
		if (count < 1)
		{
			return new long[1];
		}
		if (_003C_003Ec__DisplayClass169_.createGenerator != null && count <= 100 && base.SessionProvider != null)
		{
			_003C_003Ec__DisplayClass169_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass169_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass169_;
			CS_0024_003C_003E8__locals0.gen = generatorMap.GetOrAdd(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.table, (Func<string, IIdentifierGenerator>)delegate
			{
				//Discarded unreachable code: IL_0041
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				int num = 5;
				int num2 = num;
				IIdentifierGenerator val = default(IIdentifierGenerator);
				Int64Type @int = default(Int64Type);
				Dictionary<string, string> dictionary = default(Dictionary<string, string>);
				Dialect val2 = default(Dialect);
				while (true)
				{
					switch (num2)
					{
					case 6:
						((IConfigurable)val).Configure((IType)(object)@int, (IDictionary<string, string>)dictionary, val2);
						num2 = 2;
						break;
					case 1:
						if (!(val is IConfigurable))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 6;
					case 4:
						val2 = (Dialect)_003C_003Ec__DisplayClass169_0.zIDQ8wQHSkVXEPXFZEkW(_003C_003Ec__DisplayClass169_0.TRMXPYQHVhA1FTEvtsvn(_003C_003Ec__DisplayClass169_0.yhaRkYQHILxDJj7BR35C(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.Session)));
						num2 = 7;
						break;
					default:
						return val;
					case 3:
						val = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.createGenerator(dictionary);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 1;
						}
						break;
					case 7:
						dictionary = new Dictionary<string, string>
						{
							{
								(string)_003C_003Ec__DisplayClass169_0.sMynCFQHifvDQKratt8J(-1334993905 ^ -1334857653),
								100.ToString()
							},
							{
								(string)_003C_003Ec__DisplayClass169_0.sMynCFQHifvDQKratt8J(-289714582 ^ -289525602),
								(string)_003C_003Ec__DisplayClass169_0.eA1EgXQHR7pb5KTYjZAE(_003C_003Ec__DisplayClass169_0.sMynCFQHifvDQKratt8J(-1638402543 ^ -1638758119), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.table)
							}
						};
						num2 = 3;
						break;
					case 5:
						@int = NHibernateUtil.Int64;
						num2 = 4;
						break;
					}
				}
			});
			return (from _ in Enumerable.Range(0, count)
				select Convert.ToInt64(_003C_003Ec__DisplayClass169_1.qoRde0QHk6CaPJjjVfAG(CS_0024_003C_003E8__locals0.gen, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.Session.GetSessionImplementation(), null))).ToArray();
		}
		return reserveIdRange();
	}

	public virtual int BulkDelete(string table, string where, Dictionary<string, object> paramValues = null)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return BulkDeleteBaseAsync(table, where, paramValues, isAsync: false).GetAwaiter().GetResult();
	}

	public abstract int BulkDelete(BulkDeleteArg arg);

	static TransformationProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				ParamPrefix = (string)HUgsdnWXtd4YQwhnFhJx(-541731959 ^ -541779631);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void FinqLEWX3lSUqg2BApY8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DBxeZKWX1j5N7PFfroFt()
	{
		return wcFITEWXPCkPiH2YAHD9 == null;
	}

	internal static TransformationProvider m79CTIWXNlRuF5JEXc4L()
	{
		return wcFITEWXPCkPiH2YAHD9;
	}

	internal static object YJmYaUWXpkCxM7UlB5Wm(object P_0)
	{
		return ((IDbCommand)P_0).Transaction;
	}

	internal static void OliiwoWXaQgkaARVX1Wd(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).ReleaseSavePoint((string)P_1, (IDbTransaction)P_2);
	}

	internal static void dLqK9pWXDmMSlZJ2GXds(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).RollBackSavePoint((string)P_1, (IDbTransaction)P_2);
	}

	internal static object HUgsdnWXtd4YQwhnFhJx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object CJeeJhWXweptRXYaopFG(object P_0)
	{
		return ((DataTable)P_0).Columns;
	}

	internal static object UVI86HWX4EmckK8ScyJW(object P_0, int P_1)
	{
		return ((DataColumnCollection)P_0)[P_1];
	}

	internal static Type kcFGHvWX66UvSiChBiyq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool QeAKL1WXHUwqREmbDkwE(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type Mlg9vNWXAs0Ma7K68RZC(object P_0)
	{
		return ((DataColumn)P_0).DataType;
	}

	internal static object E7t1xUWX7tjRWJMbbWlJ(object P_0, int P_1)
	{
		return ((DataRowCollection)P_0)[P_1];
	}

	internal static object hsbE9AWXxjXfEwYGMQdG(object P_0, int P_1)
	{
		return ((DataRow)P_0)[P_1];
	}

	internal static object BIWfC6WX0hRBpYo8n0PL(object P_0)
	{
		return ((DataTable)P_0).Rows;
	}

	internal static void eleATJWXmN1S24iKZntv(object P_0, int P_1, object P_2)
	{
		((DataRow)P_0)[P_1] = P_2;
	}

	internal static int JMy7CMWXymvbGnvfVYGe(object P_0)
	{
		return ((InternalDataCollectionBase)P_0).Count;
	}

	internal static int Qe1UqsWXMuEGJHxTGPQa(object P_0, object P_1, object P_2, object P_3, bool isNeedInsertId)
	{
		return ((TransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3, isNeedInsertId);
	}

	internal static object mNbVhyWXJlS2ZRZuSPDn(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object MIVZl1WX97yyHeoixXXl(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object gQrq12WXdI1DBTA9QAnw(object P_0)
	{
		return UniversalProcedureNameFromText((string)P_0);
	}

	internal static object fdSUInWXlyd5IiP4m0Hg(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object S8rGWYWXrF4VAcFTKwda(object P_0)
	{
		return ((Match)P_0).Groups;
	}

	internal static object kmh2MvWXgGLA0274iWAh(object P_0, object P_1)
	{
		return ((GroupCollection)P_0)[(string)P_1];
	}

	internal static object Dfm11pWX5Y3xSpKfLslA(object P_0, object P_1)
	{
		return ((Dialect)P_0).UnquoteIfNeeded((string)P_1);
	}

	internal static void TflSjaWXjlASCOfTFeHd(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static void DxbkD1WXYwkIbPOn3hGI(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void V0xc5GWXL3eROm9gowxL(object P_0)
	{
		P_0();
	}

	internal static bool ygDWIqWXUspv6MwfURB8(object P_0, object P_1)
	{
		return ((TransformationProvider)P_0).CanRetryAfterException((Exception)P_1);
	}

	internal static bool Qjkgh0WXsTl21FPTg7cY(object P_0, object P_1)
	{
		return ((TransformationProvider)P_0).IsUnrecoverableException((Exception)P_1);
	}

	internal static bool JHu6bWWXcTR0O9eAN2o1()
	{
		return Locator.Initialized;
	}

	internal static void mfA4npWXz4xYBkcEKRuB(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).ThrowExceptionOnCommit((Exception)P_1);
	}

	internal static object u1wMVyWTFhpnnJljCOx5(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object fdCCJlWTBrZR2RsSvHeg(object P_0, object P_1)
	{
		return Regex.Match((string)P_0, (string)P_1);
	}

	internal static object iIQIHnWTWgpyKXtg5Ewd(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool yycXYfWToQIxQ7weEJlH(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static bool NtxsCmWTb5ujoVSPXxYO(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object gui2SsWThpT7B06k87Ym(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool lkeTLeWTGwaIL6RTDXUu(object P_0)
	{
		return ((Group)P_0).Success;
	}

	internal static object F7xFSPWTE3q2t6KOtGdb(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static bool zZGY93WTfSD03hNLBG9s(object P_0)
	{
		return ((Table)P_0).Sequence;
	}

	internal static bool vB2EWyWTQwj49jAPyyvy(object P_0)
	{
		return ((Table)P_0).IsTemporary;
	}

	internal static object th4WuLWTCoficlLkMVib(object P_0, object P_1)
	{
		return ((TransformationProviderBase)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object eUWIxXWTvUXwcluM0RN1(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void fVlMmMWT8LuO0H3irfrY(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object tiI7oaWTZKB0MmbbtxwA(object P_0)
	{
		return ((Column)P_0).Name;
	}

	internal static bool BcOadbWTu2aBFD9YVqO9(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).ColumnExists((string)P_1, (string)P_2);
	}

	internal static object Q25YMBWTI0IQHBaFpJSM(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object c8afbIWTVMx7l6O9RAYA(object P_0)
	{
		return ((TransformationProviderBase)P_0).Dialect;
	}

	internal static object QIcOScWTSGccOlYsB2tk(object P_0, object P_1, bool compoundPrimaryKey)
	{
		return ((Dialect)P_0).GetColumnSql((Column)P_1, compoundPrimaryKey);
	}

	internal static void fEeL7JWTipjVFsiraghx(object P_0, object P_1, object P_2, object P_3)
	{
		((TransformationProvider)P_0).AddColumn((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object SW5TQbWTRQiALaZTJyow(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).DeleteColumnTemporaryName((string)P_1, (string)P_2);
	}

	internal static object aOiKVJWTqa8YmGEkqbMP(object P_0)
	{
		return ((Column)P_0).ColumnType;
	}

	internal static void M34GdGWTK2w7GnJdjXXq(object P_0, object P_1, object P_2, int columnSize, bool substringStrings)
	{
		((TransformationProvider)P_0).ConvertColumnString((string)P_1, (string)P_2, columnSize, substringStrings);
	}

	internal static bool QKTOkiWTXpqniq8J75xn(object P_0, object P_1)
	{
		return ((TransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void wHjXj9WTTxTFIWxY5oBI(object P_0, object P_1, object P_2, object P_3)
	{
		((TransformationProvider)P_0).RenameColumn((string)P_1, (string)P_2, (string)P_3);
	}

	internal static void qw135nWTkujsqlYvoCK8(object P_0, object P_1, object P_2)
	{
		((TransformationProvider)P_0).AddColumn((string)P_1, (Column)P_2);
	}

	internal static object lsc52dWTnSNR5IjpkEjk(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool apQ6i5WTOht9x51VqZ1q(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).NeedStringColumnTransform((string)P_1, (string)P_2);
	}

	internal static void AgHKpJWT2cf4s4Vkp062(object P_0, object P_1, object P_2, int columnSize)
	{
		((TransformationProvider)P_0).ConvertColumnString((string)P_1, (string)P_2, columnSize);
	}

	internal static object Jn4UQMWTek4uxF6h5VkE(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object RPFKGhWTPJVyHgXFQuik(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).GenerateColumnTemporaryName((string)P_1, (string)P_2);
	}

	internal static int M02wnCWT1cvi6iMqZWuF(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object APrideWTNw058Md1SOJi(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object G6qBvPWT33TL3lyoqYIU(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object a7D8cxWTpTmTRWQiPyOT(object P_0)
	{
		return ((ForeignKey)P_0).TableName;
	}

	internal static object iipkVfWTanfGoKphhPBI(object P_0, EleWise.ELMA.Runtime.Db.Migrator.Framework.ForeignKeyConstraint constraint)
	{
		return ((ForeignKeyConstraintMapper)P_0).SqlForConstraint(constraint);
	}

	internal static object JfvglTWTDhek8QggO44p(object P_0)
	{
		return ((PrimaryKey)P_0).TableName;
	}

	internal static object FGAdBZWTtYkIGidQptRN(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	internal static bool AUe37iWTwCK8BTafFv9v(object P_0, object P_1, object P_2)
	{
		return ((TransformationProvider)P_0).ConstraintExists((string)P_1, (string)P_2);
	}

	internal static bool Dy6BhLWT4Ibx0VoZBox6(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	internal static object NlYql1WT6YapEQiOCZcE(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static void okCqYYWTHxKYAoP4Ftv6(object P_0, object P_1)
	{
		((TransformationProvider)P_0).AddIndex((Index)P_1);
	}

	internal static Guid LjGZCcWTAT4yFW5bpbvU()
	{
		return Guid.NewGuid();
	}

	internal static object RpOH9hWT7HNgRPEDtRjg(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object paEffGWTxpKWVy7C0KGW(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object I2RZT7WT0DaunAb21A5A(object P_0)
	{
		return ((TransformationProviderBase)P_0).Connection;
	}

	internal static void NErxTEWTmb9CKE36MhPL(object P_0)
	{
		((IDbConnection)P_0).Open();
	}

	internal static object Q0cHoIWTyo0TxkhqDJGe(object P_0)
	{
		return ((ISession)P_0).GetSessionImplementation();
	}

	internal static object YqTfu3WTMBZx7he1c7gT(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static CancellationToken tSBP0BWTJdFa0uRBw4ey()
	{
		return CancellationToken.None;
	}

	internal static object rjY3ySWT9JKkoqHPyZ5g(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool APvbZZWTd1XyT16Xdxra(object P_0)
	{
		return ((Column)P_0).IsPrimaryKey;
	}

	internal static ColumnProperty MYscFcWTlmJrEfaXpdvM(object P_0)
	{
		return ((Column)P_0).ColumnProperty;
	}

	internal static void h37VAiWTrqwitMpDOOBo(object P_0, ColumnProperty value)
	{
		((Column)P_0).ColumnProperty = value;
	}

	internal static void rMhHKUWTgnJkN1Fyki2f(object P_0, object P_1, object P_2, bool sequence, bool isTemporary)
	{
		((TransformationProvider)P_0).AddTable((string)P_1, (string)P_2, sequence, isTemporary);
	}

	internal static void yIoVZ6WT5JCAZw4B0qj7(object P_0, object P_1)
	{
		((TransformationProvider)P_0).RemoveProcedure((string)P_1);
	}

	internal static void v0MtnoWTjH1ul91eqxUZ(object P_0, object P_1)
	{
		((TransformationProvider)P_0).RemoveView((string)P_1);
	}
}
