using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Proxies;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers;

public abstract class TransformationProviderBase : ITransformationProviderBase, IDisposable
{
	protected static IRuntimeApplication runtimeApplication;

	protected IDbConnection connection;

	protected IDbTransaction transaction;

	protected Func<IDbConnection> connectionCreateFunc;

	private static readonly AsyncLocal<int?> contextTimeout;

	private bool disposed;

	private static TransformationProviderBase cHPScIWTYiW9tIIJCVed;

	public virtual IDbConnection Connection
	{
		get
		{
			//Discarded unreachable code: IL_0088, IL_0097, IL_0118, IL_0127, IL_0158, IL_0167
			int num = 6;
			IDbConnection dbConnection = default(IDbConnection);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 11:
						if (!P2P9XmWTsnBcWgmWvxXn(dbConnection).HasFlag(ConnectionState.Broken))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 1;
					case 2:
						if (dbConnection == null)
						{
							num2 = 7;
							continue;
						}
						goto case 11;
					case 10:
						aLCNv3WkEvsEintP5S03(this, dbConnection);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 8;
						}
						continue;
					case 8:
						dbConnection.Open();
						num = 3;
						break;
					default:
						if (dbConnection.State.HasFlag(ConnectionState.Open))
						{
							num2 = 9;
							continue;
						}
						goto case 10;
					case 3:
					case 7:
					case 9:
						return dbConnection;
					case 1:
						gyHoV6WkG7FAcuOp6eeZ(dbConnection);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 0;
						}
						continue;
					case 6:
						obj = connection;
						if (obj != null)
						{
							goto IL_019f;
						}
						num2 = 5;
						continue;
					case 5:
						{
							obj = new DbConnectionProxy((DbConnection)wdtSC0Wkhna9PCCLPCiL(Session), useSavePoint: false);
							goto IL_019f;
						}
						IL_019f:
						dbConnection = (IDbConnection)obj;
						num = 2;
						break;
					}
					break;
				}
			}
		}
	}

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		protected get
		{
			return _003CSessionProvider_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string ParameterSeparator => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6DF2C);

	public static int DefaultCommandTimeout
	{
		get
		{
			//Discarded unreachable code: IL_0088, IL_0124, IL_016d, IL_017c
			int num = 10;
			int? num3 = default(int?);
			int num5 = default(int);
			int? num4 = default(int?);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 6:
						if (!num3.HasValue)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num2 = 13;
							}
							continue;
						}
						goto case 11;
					case 4:
						return num3.Value;
					case 7:
						obj = null;
						break;
					case 5:
						num5 = 0;
						num2 = 2;
						continue;
					case 9:
						obj = runtimeApplication;
						if (obj == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 3:
						if (runtimeApplication != null)
						{
							num2 = 8;
							continue;
						}
						goto case 6;
					default:
						num3 = 600;
						num2 = 4;
						continue;
					case 2:
						if (num4 <= num5)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 4;
					case 10:
						goto end_IL_0012;
					case 1:
						if (Locator.Initialized)
						{
							num2 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 7;
					case 8:
						num3 = runtimeApplication.GetCommandTimeout();
						num2 = 6;
						continue;
					case 11:
						num4 = num3;
						num2 = 5;
						continue;
					case 12:
						obj = (runtimeApplication = Locator.GetService<IRuntimeApplication>());
						break;
					}
					runtimeApplication = (IRuntimeApplication)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 3;
					}
					continue;
					end_IL_0012:
					break;
				}
				num3 = null;
				num = 9;
			}
		}
	}

	public bool LogsEnabled
	{
		get
		{
			//Discarded unreachable code: IL_0092, IL_00a1
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return true;
				case 3:
					return true;
				case 1:
					if (PU5hsuWkfwKQxAXQQxYJ())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				if (!ContextVars.TryGetValue<bool>((string)MIPAnEWkWRtMxO3d4sSF(-1867198571 ^ -1867068489), out var value))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return value;
			}
		}
		set
		{
			//Discarded unreachable code: IL_008c, IL_009b
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!PU5hsuWkfwKQxAXQQxYJ())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
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
				ContextVars.Set((string)MIPAnEWkWRtMxO3d4sSF(-576149596 ^ -576019578), value);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public abstract Dialect Dialect { get; }

	protected ISession Session
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
					return (ISession)adrtxUWkqIth09awhnVy(SessionProvider, "");
				case 1:
					qaRiPbWkRbv0uPUG9H7i(SessionProvider, MIPAnEWkWRtMxO3d4sSF(--1333735954 ^ 0x4F7EC2DE));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[AsyncStateMachine(typeof(_003CExecuteQueryBaseAsync_003Ed__0))]
	internal System.Threading.Tasks.ValueTask<IDataReader> ExecuteQueryBaseAsync(string sql, Dictionary<string, object> paramValues, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteQueryBaseAsync_003Ed__0 _003CExecuteQueryBaseAsync_003Ed__ = default(_003CExecuteQueryBaseAsync_003Ed__0);
		_003CExecuteQueryBaseAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteQueryBaseAsync_003Ed__.sql = sql;
		_003CExecuteQueryBaseAsync_003Ed__.paramValues = paramValues;
		_003CExecuteQueryBaseAsync_003Ed__.isAsync = isAsync;
		_003CExecuteQueryBaseAsync_003Ed__.cancellationToken = cancellationToken;
		_003CExecuteQueryBaseAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<IDataReader>.Create();
		_003CExecuteQueryBaseAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<IDataReader> _003C_003Et__builder = _003CExecuteQueryBaseAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CExecuteQueryBaseAsync_003Ed__0>(ref _003CExecuteQueryBaseAsync_003Ed__);
		return _003CExecuteQueryBaseAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	[AsyncStateMachine(typeof(_003CExecuteScalarBaseAsync_003Ed__1))]
	internal System.Threading.Tasks.ValueTask<object> ExecuteScalarBaseAsync(string sql, Dictionary<string, object> paramValues, bool isAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteScalarBaseAsync_003Ed__1 _003CExecuteScalarBaseAsync_003Ed__ = default(_003CExecuteScalarBaseAsync_003Ed__1);
		_003CExecuteScalarBaseAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteScalarBaseAsync_003Ed__.sql = sql;
		_003CExecuteScalarBaseAsync_003Ed__.paramValues = paramValues;
		_003CExecuteScalarBaseAsync_003Ed__.isAsync = isAsync;
		_003CExecuteScalarBaseAsync_003Ed__.cancellationToken = cancellationToken;
		_003CExecuteScalarBaseAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<object>.Create();
		_003CExecuteScalarBaseAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<object> _003C_003Et__builder = _003CExecuteScalarBaseAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CExecuteScalarBaseAsync_003Ed__1>(ref _003CExecuteScalarBaseAsync_003Ed__);
		return _003CExecuteScalarBaseAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	[Obsolete("Не использовать", true)]
	public TransformationProviderBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TransformationProviderBase(Func<IDbConnection> connectionCreateFunc)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(connectionCreateFunc, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106387300));
		this.connectionCreateFunc = connectionCreateFunc;
		IDbConnection dbConnection = connectionCreateFunc();
		IDbConnection dbConnection2;
		if (dbConnection is DbConnectionProxy)
		{
			dbConnection2 = dbConnection;
		}
		else
		{
			IDbConnection dbConnection3 = new DbConnectionProxy((DbConnection)dbConnection);
			dbConnection2 = dbConnection3;
		}
		connection = dbConnection2;
		if (connection.State != ConnectionState.Open)
		{
			BeforeOpenConnection(dbConnection);
			connection.Open();
		}
	}

	public void Dispose()
	{
		//Discarded unreachable code: IL_0065
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (P2P9XmWTsnBcWgmWvxXn(connection) == ConnectionState.Open)
				{
					num2 = 3;
					break;
				}
				return;
			case 3:
				disposed = true;
				num2 = 5;
				break;
			case 0:
				return;
			case 5:
				connection.Close();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (connection == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				return;
			}
		}
	}

	public void BeginTransaction()
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
				BeginTransaction(IsolationLevel.Unspecified);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void BeginTransaction(IsolationLevel level)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_007f
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				return;
			case 4:
				if (transaction == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 5:
				if (connection == null)
				{
					return;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			default:
				transaction = (IDbTransaction)((level == IsolationLevel.Unspecified) ? yR4ue1WTzIqEJjlEpgoA(connection) : iGIOPRWTc6WrtdreVfQF(connection, level));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void RollbackTransaction()
	{
		//Discarded unreachable code: IL_003e, IL_00a3, IL_00c6, IL_0141, IL_0150
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				return;
			case 6:
				if (connection != null)
				{
					num2 = 5;
					continue;
				}
				return;
			case 2:
				try
				{
					bQYYGSWkFZoOm4tx7dIr(transaction);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception exception)
				{
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						case 2:
							if (LogsEnabled)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						default:
							((ILogger)naC2DvWkBEDh8suK3AEU()).Error(MIPAnEWkWRtMxO3d4sSF(-281842504 ^ -281972932), exception);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			case 4:
				return;
			case 5:
				if (transaction != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 3;
					}
				}
				continue;
			}
			transaction = null;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
			{
				num2 = 0;
			}
		}
	}

	public void CommitTransaction()
	{
		//Discarded unreachable code: IL_005a, IL_008d, IL_010d, IL_011c
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						NpmyoWWkbsD7Nd7ZxMN1(transaction);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (LogsEnabled)
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
									{
										num4 = 2;
									}
									continue;
								}
								break;
							case 2:
								((ILogger)naC2DvWkBEDh8suK3AEU()).Error(MIPAnEWkWRtMxO3d4sSF(-583745292 ^ -583613672), exception);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 1;
				case 3:
					return;
				case 2:
					return;
				case 5:
					throw new InvalidOperationException((string)oCOtPFWko6gMsYhxQLNw(MIPAnEWkWRtMxO3d4sSF(--1418440330 ^ 0x5489AD34)));
				case 1:
					transaction = null;
					num2 = 2;
					continue;
				case 4:
					if (connection != null)
					{
						if (transaction == null)
						{
							num2 = 5;
							continue;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 0;
						}
						continue;
					}
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public abstract string GuidQuerySintaxis(Guid guid);

	public DataTable GetSchemaTable(string tableName)
	{
		//Discarded unreachable code: IL_00b3, IL_00ea, IL_0120, IL_0158, IL_01b1, IL_01e1, IL_01f0, IL_0208, IL_0297
		int num = 3;
		int num2 = num;
		string text = default(string);
		DataTable result = default(DataTable);
		while (true)
		{
			switch (num2)
			{
			case 3:
				YPSG1PWkQELJAKYRBPQe(tableName, MIPAnEWkWRtMxO3d4sSF(0x68BBB53E ^ 0x68BA7D9C));
				num2 = 2;
				break;
			case 2:
				text = (string)IuEbNXWkv48lWfRbX0Z9(MIPAnEWkWRtMxO3d4sSF(0x5F3078B6 ^ 0x5F327CDC), MRVus9WkCWvqPVHvccW4(this, tableName));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					IDbCommand dbCommand = (IDbCommand)LoLoFmWk80ZjhXRl6Uqx(this, text);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							IDataReader dataReader = (IDataReader)AV3P0rWkZIhaltebkXWj(dbCommand, CommandBehavior.KeyInfo);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							default:
								try
								{
									result = (DataTable)jBmHWCWku6i2CCw0gHw1(dataReader);
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num5 = 0;
									}
									return num5 switch
									{
										0 => result, 
										_ => result, 
									};
								}
								finally
								{
									if (dataReader != null)
									{
										int num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
										{
											num6 = 1;
										}
										while (true)
										{
											switch (num6)
											{
											case 1:
												WmZMXtWkIGCdtYKEX32M(dataReader);
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
												{
													num6 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
							}
						}
						finally
						{
							int num7;
							if (dbCommand == null)
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
								{
									num7 = 0;
								}
								goto IL_01b5;
							}
							goto IL_01cb;
							IL_01cb:
							dbCommand.Dispose();
							num7 = 2;
							goto IL_01b5;
							IL_01b5:
							switch (num7)
							{
							default:
								goto end_IL_0190;
							case 1:
								break;
							case 0:
								goto end_IL_0190;
							case 2:
								goto end_IL_0190;
							}
							goto IL_01cb;
							end_IL_0190:;
						}
					}
				}
				catch (Exception exception)
				{
					int num8 = 2;
					while (true)
					{
						switch (num8)
						{
						case 2:
							if (LogsEnabled)
							{
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num8 = 1;
								}
								continue;
							}
							break;
						case 1:
							((ILogger)naC2DvWkBEDh8suK3AEU()).Warn(df5UmEWkVKRvkpWQAtqP(MIPAnEWkWRtMxO3d4sSF(-1858887263 ^ -1859017249), text, MIPAnEWkWRtMxO3d4sSF(-812025778 ^ -812049552)), exception);
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num8 = 0;
							}
							continue;
						}
						break;
					}
					throw;
				}
			case 4:
				return result;
			default:
				text = SetupFetchOptions(text, new FetchOptions(0, 1));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public abstract List<string> GetTables();

	public virtual IDataReader ExecuteQuery(string sql, Dictionary<string, object> paramValues = null)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return ExecuteQueryBaseAsync(sql, paramValues, isAsync: false, CancellationToken.None).GetAwaiter().GetResult();
	}

	public void ExecuteWithTimeout(int timeout, Action action)
	{
		//Discarded unreachable code: IL_00a5, IL_00b4, IL_00e7, IL_00fa, IL_0109
		int num = 1;
		int num2 = num;
		int? currentContextTimeout = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				currentContextTimeout = SetCurrentContextTimeout(timeout);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				int num3;
				if (action == null)
				{
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num3 = 1;
					}
					goto IL_0076;
				}
				goto IL_008c;
				IL_008c:
				WqUlsAWkSNiHJh6ObqZL(action);
				int num4 = 2;
				num3 = num4;
				goto IL_0076;
				IL_0076:
				switch (num3)
				{
				case 1:
					return;
				case 2:
					return;
				}
				goto IL_008c;
			}
			finally
			{
				SetCurrentContextTimeout(currentContextTimeout);
				int num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				case 0:
					break;
				}
			}
		}
	}

	public virtual object ExecuteScalar(string sql, Dictionary<string, object> paramValues = null)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return ExecuteScalarBaseAsync(sql, paramValues, isAsync: false, CancellationToken.None).GetAwaiter().GetResult();
	}

	public int? SetCurrentContextTimeout(int? timeout)
	{
		int? value = contextTimeout.Value;
		contextTimeout.Value = timeout;
		return value;
	}

	public virtual string SetupFetchOptions(string query, FetchOptions fetchOptions)
	{
		return (string)Bsgr8EWkiRAF8KTAaTy1(this, query, fetchOptions, true);
	}

	public abstract string SetupFetchOptions(string query, FetchOptions fetchOptions, bool quoteIfNeededSortExpression);

	public abstract string Count(string query);

	public virtual bool IsSortableDataColumn(DataColumn column)
	{
		return true;
	}

	public abstract IList<ForeignKey> GetForeignKeys();

	public abstract IDictionary<string, PrimaryKey> GetAllPrimaryKeys();

	public abstract List<string> GetViews();

	protected virtual void BeforeOpenConnection(IDbConnection dbConnection)
	{
	}

	protected virtual IDbCommand BuildCommand(string sql)
	{
		//Discarded unreachable code: IL_00dc, IL_00eb, IL_016d, IL_017c
		int num = 5;
		int num2 = num;
		IDbCommand dbCommand = default(IDbCommand);
		while (true)
		{
			switch (num2)
			{
			default:
				SetCommanTimeout(dbCommand);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				dbCommand.Transaction = transaction;
				num2 = 8;
				break;
			case 11:
				AhRWAtWkTZFAK5DaviDd(dbCommand, CommandType.Text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (DCDYmIWkkMvwVrrjo7Gj(Session) != null)
				{
					num2 = 9;
					break;
				}
				goto case 1;
			case 10:
				if (Session == null)
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 9:
				nP73RlWkn8pXXNaqTocH(DCDYmIWkkMvwVrrjo7Gj(Session), (DbCommand)dbCommand);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (connection == null)
				{
					num2 = 10;
					break;
				}
				goto case 7;
			case 1:
			case 3:
			case 8:
				return dbCommand;
			case 5:
				dbCommand = (IDbCommand)SOO2xCWkKeMySd6OvdFB(Connection);
				num2 = 4;
				break;
			case 4:
				MJVlT4WkX57aHO5ZTXvd(dbCommand, sql);
				num2 = 11;
				break;
			}
		}
	}

	protected void TransformIntoRuntimeDateTime(DataTable data)
	{
		//Discarded unreachable code: IL_00bd, IL_00cc, IL_00dc, IL_01d5, IL_0260
		int num = 7;
		int num2 = num;
		int num3 = default(int);
		int num4 = default(int);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 5:
				num3++;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 15;
				}
				break;
			case 12:
				num4 = 0;
				num2 = 2;
				break;
			case 10:
				RaflpWWkpULR8K01TwxR(jTrri8WkNZyXwRaLN4DS(data.Rows, num4), num3, pFkxenWk32S2IuXWXev5(dateTime.Value));
				num2 = 14;
				break;
			case 7:
				num3 = 0;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				return;
			case 6:
			case 15:
				if (num3 >= h4OtFDWkakirc506su4S(data.Columns))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (dateTime.HasValue)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 14;
			case 9:
				dateTime = data.Rows[num4][num3] as DateTime?;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (!P5CK9jWk11mXwUGGsXKQ(aUiyAMWkeXJbQfbm8wTR(JfU09EWk23PoHtZPpqNJ(Rj8FVAWkO8FtT6hH4yJr(data), num3)), YuHVNFWkPBS0BSYvffX6(typeof(DateTime).TypeHandle)))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 12;
			case 14:
				num4++;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 13;
				}
				break;
			case 2:
			case 13:
				if (num4 >= h4OtFDWkakirc506su4S(data.Rows))
				{
					num2 = 5;
					break;
				}
				goto case 9;
			case 8:
				if (!P5CK9jWk11mXwUGGsXKQ(aUiyAMWkeXJbQfbm8wTR(JfU09EWk23PoHtZPpqNJ(data.Columns, num3)), YuHVNFWkPBS0BSYvffX6(typeof(DateTime?).TypeHandle)))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 12;
			}
		}
	}

	protected virtual void AddParameter(IDbCommand cmd, string name, object val)
	{
		int num = 2;
		int num2 = num;
		IDbDataParameter dbDataParameter = default(IDbDataParameter);
		while (true)
		{
			switch (num2)
			{
			case 2:
				dbDataParameter = cmd.CreateParameter();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				dbDataParameter.ParameterName = name;
				num2 = 4;
				break;
			default:
				bjJtGtWkw7lwdYSRJ6UB(vOreSgWktg4dFUE3PC3B(cmd), dbDataParameter);
				num2 = 3;
				break;
			case 3:
				return;
			case 4:
				dTRsd7WkDrlg2bVOqQvp(this, dbDataParameter, val);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void SetParameterValue(IDbDataParameter param, object val)
	{
		//Discarded unreachable code: IL_00a6, IL_00b9, IL_00c8, IL_00ef, IL_01d3, IL_01de, IL_01e8, IL_01f7, IL_0232, IL_0241, IL_02ce, IL_02dd
		int num = 23;
		int num2 = num;
		ParameterValue parameterValue = default(ParameterValue);
		bool? flag = default(bool?);
		MemoryStream memoryStream = default(MemoryStream);
		object obj = default(object);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			int num3;
			object obj2;
			switch (num2)
			{
			case 11:
				if (parameterValue != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 14;
			case 2:
				if (flag.Value)
				{
					num2 = 24;
					break;
				}
				goto case 1;
			case 1:
				num3 = 0;
				goto IL_0322;
			case 6:
				yTSW84WkHO0WaqJ9RlU7(memoryStream, 0L, SeekOrigin.Begin);
				num2 = 15;
				break;
			case 22:
				if (parameterValue != null)
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 8;
			case 13:
				if (Fv8RMrWk7luZE01NIvBN(parameterValue) > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 7:
				return;
			default:
				o1n0feWkxm2Or6iDOtSg(param, Fv8RMrWk7luZE01NIvBN(parameterValue));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 7;
				}
				break;
			case 18:
				if (!flag.HasValue)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 14:
			case 21:
				obj = BxitTtWk67XSbeXN0eHw(dateTime.Value);
				num2 = 10;
				break;
			case 19:
				if (parameterValue == null)
				{
					return;
				}
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 12;
				}
				break;
			case 8:
				obj2 = val;
				goto IL_02ef;
			case 10:
			case 17:
				if ((memoryStream = obj as MemoryStream) != null)
				{
					num2 = 6;
					break;
				}
				goto case 15;
			case 23:
				parameterValue = val as ParameterValue;
				num2 = 22;
				break;
			case 12:
				param.DbType = parameterValue.Type;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 13;
				}
				break;
			case 20:
				if (dateTime.HasValue)
				{
					num2 = 11;
					break;
				}
				goto case 10;
			case 15:
				flag = obj as bool?;
				num2 = 18;
				break;
			case 3:
				dateTime = obj as DateTime?;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 20;
				}
				break;
			case 16:
				obj2 = parameterValue.Value;
				goto IL_02ef;
			case 4:
				if (!NOJUr0Wk4yRAgtTIJcKm(parameterValue))
				{
					num2 = 17;
					break;
				}
				goto case 14;
			case 24:
				num3 = 1;
				goto IL_0322;
			case 5:
			case 9:
				{
					faqmhCWkAQN7J5ou10Hy(param, obj ?? DBNull.Value);
					num2 = 19;
					break;
				}
				IL_0322:
				obj = num3;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 9;
				}
				break;
				IL_02ef:
				obj = obj2;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	protected virtual List<string> GetReservedWords()
	{
		List<string> list = new List<string>();
		IDbConnection dbConnection;
		if (!(Connection is DbConnectionProxy dbConnectionProxy))
		{
			dbConnection = Connection;
		}
		else
		{
			IDbConnection realConnection = dbConnectionProxy.RealConnection;
			dbConnection = realConnection;
		}
		foreach (DataRow row in ((DbConnection)dbConnection).GetSchema(DbMetaDataCollectionNames.ReservedWords).Rows)
		{
			list.Add(row[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108783874)].ToString());
		}
		return list;
	}

	protected abstract string QuoteIfNeeded(string name);

	private IDbCommand SetCommanTimeout(IDbCommand command)
	{
		//Discarded unreachable code: IL_00ef, IL_00fe, IL_010e
		int num = 6;
		int? num3 = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!disposed)
					{
						num = 5;
						break;
					}
					goto case 2;
				case 7:
					num3 = fIj2ULWkm3lXlJWek0Fe();
					num = 3;
					break;
				default:
					if (num3.HasValue)
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				case 1:
					return command;
				case 5:
					num3 = contextTimeout.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					q44cvLWk0Mm16n5R0uro(command, 30);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
				case 4:
					q44cvLWk0Mm16n5R0uro(command, num3.Value);
					num2 = 8;
					continue;
				case 8:
					return command;
				}
				break;
			}
		}
	}

	public abstract int ExecuteNonQuery(string sql, Dictionary<string, object> paramValues = null);

	static TransformationProviderBase()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				contextTimeout = new AsyncLocal<int?>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				tgvGqqWkyo6TPjqmpyLW();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool CCfsUDWTLbrDlCcL6m26()
	{
		return cHPScIWTYiW9tIIJCVed == null;
	}

	internal static TransformationProviderBase YRsw3TWTU85DIQkjtbXt()
	{
		return cHPScIWTYiW9tIIJCVed;
	}

	internal static ConnectionState P2P9XmWTsnBcWgmWvxXn(object P_0)
	{
		return ((IDbConnection)P_0).State;
	}

	internal static object iGIOPRWTc6WrtdreVfQF(object P_0, IsolationLevel P_1)
	{
		return ((IDbConnection)P_0).BeginTransaction(P_1);
	}

	internal static object yR4ue1WTzIqEJjlEpgoA(object P_0)
	{
		return ((IDbConnection)P_0).BeginTransaction();
	}

	internal static void bQYYGSWkFZoOm4tx7dIr(object P_0)
	{
		((IDbTransaction)P_0).Rollback();
	}

	internal static object naC2DvWkBEDh8suK3AEU()
	{
		return Logger.Log;
	}

	internal static object MIPAnEWkWRtMxO3d4sSF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oCOtPFWko6gMsYhxQLNw(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void NpmyoWWkbsD7Nd7ZxMN1(object P_0)
	{
		((IDbTransaction)P_0).Commit();
	}

	internal static object wdtSC0Wkhna9PCCLPCiL(object P_0)
	{
		return ((ISession)P_0).get_Connection();
	}

	internal static void gyHoV6WkG7FAcuOp6eeZ(object P_0)
	{
		((IDbConnection)P_0).Close();
	}

	internal static void aLCNv3WkEvsEintP5S03(object P_0, object P_1)
	{
		((TransformationProviderBase)P_0).BeforeOpenConnection((IDbConnection)P_1);
	}

	internal static bool PU5hsuWkfwKQxAXQQxYJ()
	{
		return ContextVars.HasImpl;
	}

	internal static void YPSG1PWkQELJAKYRBPQe(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object MRVus9WkCWvqPVHvccW4(object P_0, object P_1)
	{
		return ((TransformationProviderBase)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object IuEbNXWkv48lWfRbX0Z9(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object LoLoFmWk80ZjhXRl6Uqx(object P_0, object P_1)
	{
		return ((TransformationProviderBase)P_0).BuildCommand((string)P_1);
	}

	internal static object AV3P0rWkZIhaltebkXWj(object P_0, CommandBehavior P_1)
	{
		return ((IDbCommand)P_0).ExecuteReader(P_1);
	}

	internal static object jBmHWCWku6i2CCw0gHw1(object P_0)
	{
		return ((IDataReader)P_0).GetSchemaTable();
	}

	internal static void WmZMXtWkIGCdtYKEX32M(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object df5UmEWkVKRvkpWQAtqP(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void WqUlsAWkSNiHJh6ObqZL(object P_0)
	{
		P_0();
	}

	internal static object Bsgr8EWkiRAF8KTAaTy1(object P_0, object P_1, object P_2, bool quoteIfNeededSortExpression)
	{
		return ((TransformationProviderBase)P_0).SetupFetchOptions((string)P_1, (FetchOptions)P_2, quoteIfNeededSortExpression);
	}

	internal static void qaRiPbWkRbv0uPUG9H7i(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object adrtxUWkqIth09awhnVy(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object SOO2xCWkKeMySd6OvdFB(object P_0)
	{
		return ((IDbConnection)P_0).CreateCommand();
	}

	internal static void MJVlT4WkX57aHO5ZTXvd(object P_0, object P_1)
	{
		((IDbCommand)P_0).CommandText = (string)P_1;
	}

	internal static void AhRWAtWkTZFAK5DaviDd(object P_0, CommandType P_1)
	{
		((IDbCommand)P_0).CommandType = P_1;
	}

	internal static object DCDYmIWkkMvwVrrjo7Gj(object P_0)
	{
		return ((ISession)P_0).get_Transaction();
	}

	internal static void nP73RlWkn8pXXNaqTocH(object P_0, object P_1)
	{
		((ITransaction)P_0).Enlist((DbCommand)P_1);
	}

	internal static object Rj8FVAWkO8FtT6hH4yJr(object P_0)
	{
		return ((DataTable)P_0).Columns;
	}

	internal static object JfU09EWk23PoHtZPpqNJ(object P_0, int P_1)
	{
		return ((DataColumnCollection)P_0)[P_1];
	}

	internal static Type aUiyAMWkeXJbQfbm8wTR(object P_0)
	{
		return ((DataColumn)P_0).DataType;
	}

	internal static Type YuHVNFWkPBS0BSYvffX6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool P5CK9jWk11mXwUGGsXKQ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object jTrri8WkNZyXwRaLN4DS(object P_0, int P_1)
	{
		return ((DataRowCollection)P_0)[P_1];
	}

	internal static DateTime pFkxenWk32S2IuXWXev5(DateTime serverDateTime)
	{
		return serverDateTime.ToRuntimeDateTimeFromServer();
	}

	internal static void RaflpWWkpULR8K01TwxR(object P_0, int P_1, object P_2)
	{
		((DataRow)P_0)[P_1] = P_2;
	}

	internal static int h4OtFDWkakirc506su4S(object P_0)
	{
		return ((InternalDataCollectionBase)P_0).Count;
	}

	internal static void dTRsd7WkDrlg2bVOqQvp(object P_0, object P_1, object P_2)
	{
		((TransformationProviderBase)P_0).SetParameterValue((IDbDataParameter)P_1, P_2);
	}

	internal static object vOreSgWktg4dFUE3PC3B(object P_0)
	{
		return ((IDbCommand)P_0).Parameters;
	}

	internal static int bjJtGtWkw7lwdYSRJ6UB(object P_0, object P_1)
	{
		return ((IList)P_0).Add(P_1);
	}

	internal static bool NOJUr0Wk4yRAgtTIJcKm(object P_0)
	{
		return ((ParameterValue)P_0).ConvertToDbTime;
	}

	internal static DateTime BxitTtWk67XSbeXN0eHw(DateTime runtimeDateTime)
	{
		return runtimeDateTime.ToServerDateTime();
	}

	internal static long yTSW84WkHO0WaqJ9RlU7(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void faqmhCWkAQN7J5ou10Hy(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static int Fv8RMrWk7luZE01NIvBN(object P_0)
	{
		return ((ParameterValue)P_0).Size;
	}

	internal static void o1n0feWkxm2Or6iDOtSg(object P_0, int P_1)
	{
		((IDbDataParameter)P_0).Size = P_1;
	}

	internal static void q44cvLWk0Mm16n5R0uro(object P_0, int P_1)
	{
		((IDbCommand)P_0).CommandTimeout = P_1;
	}

	internal static int fIj2ULWkm3lXlJWek0Fe()
	{
		return DefaultCommandTimeout;
	}

	internal static void tgvGqqWkyo6TPjqmpyLW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
