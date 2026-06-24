using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Proxies;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.AdoNet;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class CustomBatcher : IBatcher, IDisposable, ISavePointHelper
{
	private static readonly ILogger OrgItemLog;

	private DbCommand batchCommand;

	private readonly IBatcher batcher;

	private readonly IInterceptor interceptor;

	private static IRuntimeApplication runtimeApplication;

	private static IUnitOfWorkManager unitOfWorkManager;

	private long rowsAffected;

	private static CustomBatcher gF0AaUW1wCdtw4HLRhkP;

	public int BatchSize
	{
		get
		{
			return QHTnZHW1MnaS9dlLAJGG(batcher);
		}
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
				case 1:
					Cro4GgW1JqTQiYOBAh2t(batcher, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	private static string Pattern
	{
		get
		{
			int num = 4;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					return "";
				case 2:
					if (!zhjcKUWNbSfH3Ue9QoZx(text))
					{
						if (v3lDhIWNhfXPg6tjWOnX(text, EFZE9UW1YprMiZQoJKub(-1426094279 ^ -1426221405)))
						{
							return (string)WUoMJAWNGRud8UrvvGGM(EFZE9UW1YprMiZQoJKub(-1487388570 ^ -1487253074), text);
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 1;
						}
					}
					continue;
				default:
					return "";
				case 4:
					obj = SR.GetSetting((string)EFZE9UW1YprMiZQoJKub(0x7247028A ^ 0x724513D4));
					if (obj != null)
					{
						break;
					}
					num2 = 3;
					continue;
				case 3:
					obj = "";
					break;
				}
				text = (string)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public bool HasOpenResources => zn2gtwWN8LXLAvIu2SGE(batcher);

	[AsyncStateMachine(typeof(_003CAddToBatchAsync_003Ed__0))]
	public Task AddToBatchAsync(IExpectation expectation, CancellationToken cancellationToken)
	{
		int num = 1;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CAddToBatchAsync_003Ed__0 stateMachine = default(_003CAddToBatchAsync_003Ed__0);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 4;
				break;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 5;
				}
				break;
			default:
				stateMachine.expectation = expectation;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return stateMachine._003C_003Et__builder.Task;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 3;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 7;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CExecuteBatchAsync_003Ed__1))]
	public Task ExecuteBatchAsync(CancellationToken cancellationToken)
	{
		int num = 3;
		int num2 = num;
		_003CExecuteBatchAsync_003Ed__1 stateMachine = default(_003CExecuteBatchAsync_003Ed__1);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 5;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine._003C_003Et__builder = yuRPJTW1HNO7IJMFenE3();
				num2 = 6;
				break;
			case 2:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 4;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CExecuteReaderAsync_003Ed__2))]
	public Task<DbDataReader> ExecuteReaderAsync(DbCommand cmd, CancellationToken cancellationToken)
	{
		_003CExecuteReaderAsync_003Ed__2 stateMachine = default(_003CExecuteReaderAsync_003Ed__2);
		stateMachine._003C_003E4__this = this;
		stateMachine.cmd = cmd;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<DbDataReader>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DbDataReader> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CExecuteNonQueryAsync_003Ed__3))]
	public Task<int> ExecuteNonQueryAsync(DbCommand cmd, CancellationToken cancellationToken)
	{
		_003CExecuteNonQueryAsync_003Ed__3 stateMachine = default(_003CExecuteNonQueryAsync_003Ed__3);
		stateMachine._003C_003E4__this = this;
		stateMachine.cmd = cmd;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<int> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPrepareCommandAsync_003Ed__4))]
	public Task<DbCommand> PrepareCommandAsync(CommandType commandType, SqlString sql, SqlType[] parameterTypes, CancellationToken cancellationToken)
	{
		_003CPrepareCommandAsync_003Ed__4 stateMachine = default(_003CPrepareCommandAsync_003Ed__4);
		stateMachine._003C_003E4__this = this;
		stateMachine.commandType = commandType;
		stateMachine.sql = sql;
		stateMachine.parameterTypes = parameterTypes;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<DbCommand>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DbCommand> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPrepareBatchCommandAsync_003Ed__5))]
	public Task<DbCommand> PrepareBatchCommandAsync(CommandType commandType, SqlString sql, SqlType[] parameterTypes, CancellationToken cancellationToken)
	{
		_003CPrepareBatchCommandAsync_003Ed__5 stateMachine = default(_003CPrepareBatchCommandAsync_003Ed__5);
		stateMachine._003C_003E4__this = this;
		stateMachine.commandType = commandType;
		stateMachine.sql = sql;
		stateMachine.parameterTypes = parameterTypes;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<DbCommand>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DbCommand> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public bool SavePoint(string key, IDbCommand dBCommand)
	{
		return ne4CSkW1AGC36NPpOMFo(key, dBCommand);
	}

	public void ReleaseSavePoint(string key, IDbCommand dBCommand)
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
				wX9onmW17SOVlyJyKJM2(key, dBCommand);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void RollBackSavePoint(string key, IDbCommand dBCommand)
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
				ef5agyW1xqGEbMT7DIsF(key, dBCommand);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public CustomBatcher(IBatcher batcher, IInterceptor interceptor)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				this.interceptor = interceptor;
				num = 2;
				continue;
			}
			this.batcher = batcher;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
			{
				num = 1;
			}
		}
	}

	public void AbortBatch(Exception e)
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
				OgO6sSW10vZglgu08kpH(batcher, e);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void AddToBatch(IExpectation expectation)
	{
		//Discarded unreachable code: IL_004b, IL_00cd, IL_00e1, IL_00f0
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				int num;
				if (expectation.get_CanBeBatched())
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num = 1;
					}
					goto IL_004f;
				}
				goto IL_0093;
				IL_0093:
				k0FyL0W1yNSbpn3FjfkQ(batcher, expectation);
				num = 2;
				goto IL_004f;
				IL_004f:
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 1:
						rowsAffected += r3Rm7gW1mXyo37JPrcso(expectation);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				goto IL_0093;
			}
			catch (Exception ex)
			{
				ProcessException(ex);
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					throw;
				}
			}
		}
	}

	public void CancelLastQuery()
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
				DuXHPgW19pQxv22rGMnl(batcher);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CloseCommand(DbCommand cmd, DbDataReader reader)
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
				btKj1FW1d8NyW0RiBXDj(batcher, cmd, reader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CloseCommands()
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
				mY0Sn2W1lHZFUvQCb3Zt(batcher);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CloseReader(DbDataReader reader)
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
				xCnfUNW1rU53fBExuPfC(batcher, reader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ExecuteBatch()
	{
		//Discarded unreachable code: IL_0101, IL_0137, IL_0146, IL_0156, IL_0165, IL_0226, IL_024d, IL_030b, IL_031a, IL_039d, IL_03d5, IL_03e4
		int num = 2;
		int num2 = num;
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				sqlQueryInfo = DiagnosticsManager.StartCall(delegate
				{
					//Discarded unreachable code: IL_0083, IL_0092
					int num9 = 2;
					int num10 = num9;
					while (true)
					{
						switch (num10)
						{
						case 1:
						case 3:
							return null;
						case 2:
							if (batchCommand == null)
							{
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num10 = 1;
								}
								continue;
							}
							break;
						}
						if (!VPCk0fW1jRw6rUG7QDoY(uAX3wOW15YsylCp716uU(batchCommand)))
						{
							break;
						}
						num10 = 3;
					}
					return new SqlQueryInfo(batchCommand);
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					int num3;
					if (!mL01r7W1gSXb36nBslmN(OrgItemLog, LogLevel.Debug))
					{
						num3 = 5;
						goto IL_0075;
					}
					goto IL_00e7;
					IL_0075:
					int num4 = num3;
					goto IL_0079;
					IL_00e7:
					if (batchCommand == null)
					{
						num4 = 2;
						goto IL_0079;
					}
					goto IL_010f;
					IL_0170:
					num4 = 6;
					goto IL_0079;
					IL_010f:
					if (!VPCk0fW1jRw6rUG7QDoY(uAX3wOW15YsylCp716uU(batchCommand)))
					{
						num3 = 3;
						goto IL_0075;
					}
					goto IL_0170;
					IL_0079:
					while (true)
					{
						switch (num4)
						{
						case 3:
							if (!QCRO9WW1LpKDrc8dA52J(batchCommand.CommandText, EFZE9UW1YprMiZQoJKub(0x1ECE530A ^ 0x1ECC4218), StringComparison.InvariantCultureIgnoreCase))
							{
								num4 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto case 1;
						case 4:
							break;
						default:
							goto IL_010f;
						case 2:
						case 5:
						case 7:
						case 8:
							goto IL_0170;
						case 1:
							jLpyPnW1cTnn1bQkyhar(OrgItemLog, GZlvLFW1sguHo2bkygEF(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638537387), batchCommand.CommandText, string.Concat(from IDataParameter p in (IEnumerable)yR6AqkW1U71LhmrXZpGm(batchCommand)
								select (string)_003C_003Ec.DEna1hQmOQJwOjl82KR8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A64BE06), _003C_003Ec.TTZpVSQmkT49smaTYRtp(p), _003C_003Ec.WY7HjQQmnrAV1qDeVyGj(p))), Environment.StackTrace));
							num4 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num4 = 7;
							}
							continue;
						case 6:
							try
							{
								I1OAVbW1zNaGBGksfgFP(batcher);
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 2:
										return;
									default:
										rowsAffected = 0L;
										num5 = 2;
										continue;
									case 1:
										if (sqlQueryInfo == null)
										{
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
											{
												num5 = 2;
											}
											continue;
										}
										break;
									case 4:
										break;
									}
									sqlQueryInfo.RowsAffected = ((rowsAffected > 0) ? rowsAffected : 0);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
									{
										num5 = 0;
									}
								}
							}
							catch (Exception ex)
							{
								int num6 = 3;
								int num7 = num6;
								while (true)
								{
									switch (num7)
									{
									case 3:
										if (sqlQueryInfo == null)
										{
											num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
											{
												num7 = 0;
											}
											break;
										}
										goto case 1;
									case 1:
										lXmSvkWNFvPuHY8knMGQ(sqlQueryInfo, ex);
										num7 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
										{
											num7 = 2;
										}
										break;
									default:
										ProcessException(ex);
										num7 = 4;
										break;
									case 4:
										throw;
									}
								}
							}
						}
						break;
					}
					goto IL_00e7;
				}
				finally
				{
					if (sqlQueryInfo != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								((IDisposable)sqlQueryInfo).Dispose();
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num8 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	public int ExecuteNonQuery(DbCommand cmd)
	{
		//Discarded unreachable code: IL_0101, IL_0110, IL_0178, IL_023c, IL_0274, IL_0283
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				sqlQueryInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass21_._003CExecuteNonQuery_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			case 3:
				_003C_003Ec__DisplayClass21_.cmd = cmd;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				int num3 = HHWCSsWNBq4Z41XejoYc(batcher, _003C_003Ec__DisplayClass21_.cmd);
				int num4 = 5;
				while (true)
				{
					int num5;
					switch (num4)
					{
					case 2:
						return result;
					case 3:
					case 4:
						rowsAffected = 0L;
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num4 = 0;
						}
						continue;
					default:
						result = num3;
						num5 = 2;
						goto IL_00a2;
					case 5:
						if (sqlQueryInfo != null)
						{
							break;
						}
						num5 = 4;
						goto IL_00a2;
					case 1:
						break;
						IL_00a2:
						num4 = num5;
						continue;
					}
					sqlQueryInfo.RowsAffected = ((num3 > 0) ? num3 : 0);
					num4 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num4 = 3;
					}
				}
			}
			catch (Exception ex)
			{
				int num6 = 3;
				while (true)
				{
					switch (num6)
					{
					case 3:
						if (sqlQueryInfo != null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num6 = 1;
							}
							break;
						}
						goto case 2;
					case 1:
						lXmSvkWNFvPuHY8knMGQ(sqlQueryInfo, ex);
						num6 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num6 = 1;
						}
						break;
					case 2:
						RQJKdtWNWEk6GnKUFlFj(ex, (_003C_003Ec__DisplayClass21_.cmd != null) ? _003C_003Ec__DisplayClass21_.cmd.Connection : null);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num6 = 0;
						}
						break;
					default:
						throw;
					}
				}
			}
			finally
			{
				if (sqlQueryInfo != null)
				{
					int num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							y182loWNoTJHc01K5jT8(sqlQueryInfo);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num7 = 0;
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

	public DbDataReader ExecuteReader(DbCommand cmd)
	{
		//Discarded unreachable code: IL_0079, IL_009c, IL_0135, IL_0144, IL_0154, IL_0163, IL_01a4, IL_01b3
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		DbDataReader result = default(DbDataReader);
		while (true)
		{
			switch (num2)
			{
			case 7:
				try
				{
					result = new DataReaderProxy((DbDataReader)TlqeCFWNCKo5a5wbFqbK(batcher, _003C_003Ec__DisplayClass24_.cmd), _003C_003Ec__DisplayClass24_.cmd, sqlQueryInfo);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				catch (Exception ex)
				{
					int num4 = 4;
					while (true)
					{
						switch (num4)
						{
						case 4:
							if (sqlQueryInfo == null)
							{
								num4 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num4 = 5;
								}
								break;
							}
							goto case 1;
						case 1:
							lXmSvkWNFvPuHY8knMGQ(sqlQueryInfo, ex);
							num4 = 7;
							break;
						case 2:
							if (sqlQueryInfo == null)
							{
								num4 = 3;
								break;
							}
							goto case 5;
						case 5:
							sqlQueryInfo.Dispose();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num4 = 0;
							}
							break;
						case 6:
						case 7:
							RQJKdtWNWEk6GnKUFlFj(ex, (_003C_003Ec__DisplayClass24_.cmd != null) ? LZfVOvWNvIWY8YgTagCG(_003C_003Ec__DisplayClass24_.cmd) : null);
							num4 = 2;
							break;
						default:
							throw;
						}
					}
				}
			case 4:
				sqlQueryInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass24_._003CExecuteReader_003Eb__1);
				num2 = 7;
				break;
			case 2:
				_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			case 6:
				if (QCRO9WW1LpKDrc8dA52J(uAX3wOW15YsylCp716uU(_003C_003Ec__DisplayClass24_.cmd), EFZE9UW1YprMiZQoJKub(0x3A5D5EF ^ 0x3A5B827), StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 1:
				_003C_003Ec__DisplayClass24_.cmd = cmd;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				if (!zhjcKUWNbSfH3Ue9QoZx(t29KUIWNERunP3XbGctj()))
				{
					num2 = 6;
					break;
				}
				goto case 4;
			case 5:
				D4YxZ0WNQR4rarh3ZMbo(_003C_003Ec__DisplayClass24_.cmd, qw2C0yWNf6kXvx9avGIu(uAX3wOW15YsylCp716uU(_003C_003Ec__DisplayClass24_.cmd), t29KUIWNERunP3XbGctj(), (MatchEvaluator)((Match match) => ((Capture)_003C_003Ec.bfuZQYQmPlq4jet48jRI(_003C_003Ec.Hboyk0Qm2lgRpkTSl9bX(match), _003C_003Ec.zb7ZT3Qmel3VOSmChtyY(-1998538950 ^ -1998242584))).Value + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475564249)), RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture));
				num2 = 4;
				break;
			}
		}
	}

	public static int? SetCurrentContextTimeout(int? timeout)
	{
		return (Locator.Initialized ? Locator.GetService<IRuntimeApplication>() : null)?.SetCurrentContextTimeout(timeout);
	}

	public DbCommand PrepareBatchCommand(CommandType commandType, SqlString sql, SqlType[] parameterTypes)
	{
		//Discarded unreachable code: IL_009a, IL_0104, IL_0113, IL_0166, IL_01d7, IL_020f, IL_021e
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_;
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		DbCommand result = default(DbCommand);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
				_003C_003Ec__DisplayClass28_.sqlString = ((object)sql).ToString();
				sqlQueryInfo = DiagnosticsManager.StartCall(delegate
				{
					//Discarded unreachable code: IL_002d, IL_003c
					int num6 = 2;
					int num7 = num6;
					while (true)
					{
						switch (num7)
						{
						case 2:
							if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass28_.sqlString))
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num7 = 0;
								}
								break;
							}
							goto default;
						default:
							return null;
						case 1:
						{
							SqlQueryInfo obj = new SqlQueryInfo
							{
								Sql = _003C_003Ec__DisplayClass28_.sqlString
							};
							_003C_003Ec__DisplayClass28_0.MHvdB4QyMxp47neZYBiP(obj, true);
							return obj;
						}
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				batchCommand = (DbCommand)FGr1S5WNu6TyFmTApfr5(hM0c3HWNZPhGctwvfPeE(batcher, commandType, sql, parameterTypes));
				int num3 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num3 = 4;
				}
				while (true)
				{
					switch (num3)
					{
					case 4:
						if (sqlQueryInfo == null)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 2;
					default:
						result = batchCommand;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num3 = 1;
						}
						break;
					case 2:
						sqlQueryInfo.SetDbCommand(batchCommand);
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num3 = 2;
						}
						break;
					case 1:
						return result;
					}
				}
			}
			catch (Exception ex)
			{
				int num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					case 2:
						lXmSvkWNFvPuHY8knMGQ(sqlQueryInfo, ex);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num4 = 0;
						}
						continue;
					case 1:
						if (sqlQueryInfo != null)
						{
							num4 = 2;
							continue;
						}
						break;
					}
					break;
				}
				throw;
			}
			finally
			{
				if (sqlQueryInfo != null)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							y182loWNoTJHc01K5jT8(sqlQueryInfo);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num5 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public DbCommand PrepareCommand(CommandType commandType, SqlString sql, SqlType[] parameterTypes)
	{
		//Discarded unreachable code: IL_0099, IL_011a, IL_018b, IL_01bb, IL_01ca, IL_01d6, IL_01e5
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_;
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		DbCommand result = default(DbCommand);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
				_003C_003Ec__DisplayClass29_.sqlString = ((object)sql).ToString();
				sqlQueryInfo = DiagnosticsManager.StartCall(delegate
				{
					//Discarded unreachable code: IL_0072, IL_0081
					int num6 = 1;
					int num7 = num6;
					while (true)
					{
						switch (num7)
						{
						case 1:
							if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass29_.sqlString))
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num7 = 0;
								}
								break;
							}
							goto case 2;
						case 2:
							return null;
						default:
						{
							SqlQueryInfo sqlQueryInfo2 = new SqlQueryInfo();
							_003C_003Ec__DisplayClass29_0.TyhcVHQyrKhniAmWy2x7(sqlQueryInfo2, _003C_003Ec__DisplayClass29_.sqlString);
							_003C_003Ec__DisplayClass29_0.sF3WNPQygRXefyexcj0M(sqlQueryInfo2, true);
							return sqlQueryInfo2;
						}
						}
					}
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return result;
			case 1:
				try
				{
					DbCommand dbCommand = (DbCommand)FGr1S5WNu6TyFmTApfr5(iIK4XHWNI1aWnRF8j2rx(batcher, commandType, sql, parameterTypes));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return result;
						case 1:
							sqlQueryInfo.SetDbCommand(dbCommand);
							num3 = 3;
							continue;
						default:
							if (sqlQueryInfo != null)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						case 3:
							break;
						}
						result = dbCommand;
						num3 = 2;
					}
				}
				catch (Exception exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							sqlQueryInfo.Exception = exception;
							num4 = 2;
							continue;
						default:
							if (sqlQueryInfo != null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							break;
						case 2:
							break;
						}
						break;
					}
					throw;
				}
				finally
				{
					int num5;
					if (sqlQueryInfo == null)
					{
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num5 = 1;
						}
						goto IL_018f;
					}
					goto IL_01a5;
					IL_01a5:
					y182loWNoTJHc01K5jT8(sqlQueryInfo);
					num5 = 2;
					goto IL_018f;
					IL_018f:
					switch (num5)
					{
					case 1:
						goto end_IL_016a;
					case 2:
						goto end_IL_016a;
					}
					goto IL_01a5;
					end_IL_016a:;
				}
			}
		}
	}

	public DbCommand PrepareQueryCommand(CommandType commandType, SqlString sql, SqlType[] parameterTypes)
	{
		//Discarded unreachable code: IL_0059, IL_010f, IL_0190, IL_01af, IL_01db, IL_01ea
		int num = 1;
		int num2 = num;
		DbCommand result = default(DbCommand);
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_;
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				_003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
				_003C_003Ec__DisplayClass30_.sqlString = ((object)sql).ToString();
				sqlQueryInfo = DiagnosticsManager.StartCall(delegate
				{
					//Discarded unreachable code: IL_002d, IL_003c
					int num6 = 2;
					int num7 = num6;
					while (true)
					{
						switch (num7)
						{
						case 2:
							if (!_003C_003Ec__DisplayClass30_0.fHngVeQyUa4etR9ZEsEq(_003C_003Ec__DisplayClass30_.sqlString))
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
								{
									num7 = 0;
								}
								break;
							}
							goto default;
						default:
							return null;
						case 1:
						{
							SqlQueryInfo obj = new SqlQueryInfo
							{
								Sql = _003C_003Ec__DisplayClass30_.sqlString
							};
							_003C_003Ec__DisplayClass30_0.gLFdwOQysglBlY4Pk9VD(obj, true);
							return obj;
						}
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				DbCommand dbCommand = (DbCommand)FGr1S5WNu6TyFmTApfr5(PNw5ytWNVD1Afvaupbs3(batcher, commandType, sql, parameterTypes));
				int num3 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num3 = 2;
				}
				while (true)
				{
					switch (num3)
					{
					case 3:
						if (dbCommand != null)
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num3 = 1;
							}
							break;
						}
						goto default;
					case 1:
						sqlQueryInfo.SetDbCommand(dbCommand);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num3 = 0;
						}
						break;
					default:
						result = dbCommand;
						num3 = 4;
						break;
					case 2:
						if (sqlQueryInfo != null)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num3 = 1;
							}
							break;
						}
						goto default;
					case 4:
						return result;
					}
				}
			}
			catch (Exception ex)
			{
				int num4 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num4 = 2;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						lXmSvkWNFvPuHY8knMGQ(sqlQueryInfo, ex);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num4 = 0;
						}
						continue;
					case 2:
						if (sqlQueryInfo != null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num4 = 0;
							}
							continue;
						}
						break;
					case 1:
						break;
					}
					break;
				}
				throw;
			}
			finally
			{
				int num5;
				if (sqlQueryInfo == null)
				{
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num5 = 1;
					}
					goto IL_0194;
				}
				goto IL_01b9;
				IL_01b9:
				y182loWNoTJHc01K5jT8(sqlQueryInfo);
				num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num5 = 0;
				}
				goto IL_0194;
				IL_0194:
				switch (num5)
				{
				default:
					goto end_IL_016f;
				case 1:
					goto end_IL_016f;
				case 2:
					break;
				case 0:
					goto end_IL_016f;
				}
				goto IL_01b9;
				end_IL_016f:;
			}
		}
	}

	public void Dispose()
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
				y182loWNoTJHc01K5jT8(batcher);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static DbCommand SetCommandTimeout(object command)
	{
		//Discarded unreachable code: IL_0086, IL_00f8
		int num = 8;
		int? commandTimeout = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					goto end_IL_0012;
				default:
					return (DbCommand)command;
				case 6:
					if (runtimeApplication == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 5;
						}
					}
					else
					{
						commandTimeout = runtimeApplication.GetCommandTimeout();
						num2 = 3;
					}
					continue;
				case 5:
					return (DbCommand)command;
				case 3:
					if (!commandTimeout.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto end_IL_0012;
				case 7:
					if (!Locator.Initialized)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					obj = (runtimeApplication = Locator.GetService<IRuntimeApplication>());
					break;
				case 1:
					obj = null;
					break;
				case 8:
					obj = runtimeApplication;
					if (obj != null)
					{
						break;
					}
					num2 = 7;
					continue;
				}
				runtimeApplication = (IRuntimeApplication)obj;
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			((DbCommand)command).CommandTimeout = commandTimeout.Value;
			num = 2;
		}
	}

	private static void ProcessException(object ex)
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
				RQJKdtWNWEk6GnKUFlFj(ex, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void ProcessException(object ex, object dbConnection)
	{
		//Discarded unreachable code: IL_0065, IL_0074, IL_0141, IL_0199, IL_01a8, IL_01b9, IL_01c3
		int num = 11;
		int num2 = num;
		ITransformationProvider transformationProvider = default(ITransformationProvider);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 8:
				return;
			case 7:
				unitOfWorkManager.ThrowExceptionOnCommit((Exception)ex);
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 8;
				}
				continue;
			case 12:
				return;
			case 10:
				if (YTlIxWWNSJ2NqjV41rVr())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 13;
			case 16:
				if (transformationProvider == null)
				{
					num2 = 8;
					continue;
				}
				goto default;
			case 11:
				obj2 = runtimeApplication;
				if (obj2 == null)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto IL_0212;
			case 9:
				return;
			case 4:
				if (runtimeApplication != null)
				{
					transformationProvider = (ITransformationProvider)zB4GdXWNiJmJQlwIpRWM(runtimeApplication);
					num2 = 14;
					continue;
				}
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				obj = null;
				break;
			case 15:
				if (unitOfWorkManager != null)
				{
					num2 = 7;
					continue;
				}
				goto case 16;
			case 14:
				if (transformationProvider.IsUnrecoverableException((Exception)ex))
				{
					num2 = 6;
					continue;
				}
				goto case 16;
			default:
				lK8VUhWNRFs9VhqloFCY(transformationProvider, ex, dbConnection);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 5;
				}
				continue;
			case 13:
				obj2 = null;
				goto IL_0212;
			case 6:
				obj = unitOfWorkManager;
				if (obj == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 3:
				if (YTlIxWWNSJ2NqjV41rVr())
				{
					num2 = 5;
					continue;
				}
				goto case 2;
			case 1:
				obj2 = (runtimeApplication = Locator.GetService<IRuntimeApplication>());
				goto IL_0212;
			case 5:
				{
					obj = (unitOfWorkManager = Locator.GetService<IUnitOfWorkManager>());
					break;
				}
				IL_0212:
				runtimeApplication = (IRuntimeApplication)obj2;
				num2 = 4;
				continue;
			}
			unitOfWorkManager = (IUnitOfWorkManager)obj;
			num2 = 15;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
			{
				num2 = 1;
			}
		}
	}

	static CustomBatcher()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				yH2K3rWNqICN5B653NPH();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				OrgItemLog = (ILogger)NVaHjwWNKMtWrKqbjlsF(EFZE9UW1YprMiZQoJKub(-1867198571 ^ -1867063857));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool JdVDhiW14n1hXBCALUhW()
	{
		return gF0AaUW1wCdtw4HLRhkP == null;
	}

	internal static CustomBatcher zdYLX8W16U76YL7YOmaf()
	{
		return gF0AaUW1wCdtw4HLRhkP;
	}

	internal static AsyncTaskMethodBuilder yuRPJTW1HNO7IJMFenE3()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static bool ne4CSkW1AGC36NPpOMFo(object P_0, object P_1)
	{
		return SavePointHelper.SavePoint((string)P_0, (IDbCommand)P_1);
	}

	internal static void wX9onmW17SOVlyJyKJM2(object P_0, object P_1)
	{
		SavePointHelper.ReleaseSavePoint((string)P_0, (IDbCommand)P_1);
	}

	internal static void ef5agyW1xqGEbMT7DIsF(object P_0, object P_1)
	{
		SavePointHelper.RollBackSavePoint((string)P_0, (IDbCommand)P_1);
	}

	internal static void OgO6sSW10vZglgu08kpH(object P_0, object P_1)
	{
		((IBatcher)P_0).AbortBatch((Exception)P_1);
	}

	internal static int r3Rm7gW1mXyo37JPrcso(object P_0)
	{
		return ((IExpectation)P_0).get_ExpectedRowCount();
	}

	internal static void k0FyL0W1yNSbpn3FjfkQ(object P_0, object P_1)
	{
		((IBatcher)P_0).AddToBatch((IExpectation)P_1);
	}

	internal static int QHTnZHW1MnaS9dlLAJGG(object P_0)
	{
		return ((IBatcher)P_0).get_BatchSize();
	}

	internal static void Cro4GgW1JqTQiYOBAh2t(object P_0, int P_1)
	{
		((IBatcher)P_0).set_BatchSize(P_1);
	}

	internal static void DuXHPgW19pQxv22rGMnl(object P_0)
	{
		((IBatcher)P_0).CancelLastQuery();
	}

	internal static void btKj1FW1d8NyW0RiBXDj(object P_0, object P_1, object P_2)
	{
		((IBatcher)P_0).CloseCommand((DbCommand)P_1, (DbDataReader)P_2);
	}

	internal static void mY0Sn2W1lHZFUvQCb3Zt(object P_0)
	{
		((IBatcher)P_0).CloseCommands();
	}

	internal static void xCnfUNW1rU53fBExuPfC(object P_0, object P_1)
	{
		((IBatcher)P_0).CloseReader((DbDataReader)P_1);
	}

	internal static bool mL01r7W1gSXb36nBslmN(object P_0, LogLevel level)
	{
		return ((ILogger)P_0).IsEnabled(level);
	}

	internal static object uAX3wOW15YsylCp716uU(object P_0)
	{
		return ((DbCommand)P_0).CommandText;
	}

	internal static bool VPCk0fW1jRw6rUG7QDoY(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object EFZE9UW1YprMiZQoJKub(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool QCRO9WW1LpKDrc8dA52J(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	internal static object yR6AqkW1U71LhmrXZpGm(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object GZlvLFW1sguHo2bkygEF(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void jLpyPnW1cTnn1bQkyhar(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void I1OAVbW1zNaGBGksfgFP(object P_0)
	{
		((IBatcher)P_0).ExecuteBatch();
	}

	internal static void lXmSvkWNFvPuHY8knMGQ(object P_0, object P_1)
	{
		((AbstractCallInfo)P_0).Exception = (Exception)P_1;
	}

	internal static int HHWCSsWNBq4Z41XejoYc(object P_0, object P_1)
	{
		return ((IBatcher)P_0).ExecuteNonQuery((DbCommand)P_1);
	}

	internal static void RQJKdtWNWEk6GnKUFlFj(object P_0, object P_1)
	{
		ProcessException(P_0, P_1);
	}

	internal static void y182loWNoTJHc01K5jT8(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool zhjcKUWNbSfH3Ue9QoZx(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool v3lDhIWNhfXPg6tjWOnX(object P_0, object P_1)
	{
		return Regex.IsMatch((string)P_0, (string)P_1);
	}

	internal static object WUoMJAWNGRud8UrvvGGM(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object t29KUIWNERunP3XbGctj()
	{
		return Pattern;
	}

	internal static object qw2C0yWNf6kXvx9avGIu(object P_0, object P_1, object P_2, RegexOptions P_3)
	{
		return Regex.Replace((string)P_0, (string)P_1, (MatchEvaluator)P_2, P_3);
	}

	internal static void D4YxZ0WNQR4rarh3ZMbo(object P_0, object P_1)
	{
		((DbCommand)P_0).CommandText = (string)P_1;
	}

	internal static object TlqeCFWNCKo5a5wbFqbK(object P_0, object P_1)
	{
		return ((IBatcher)P_0).ExecuteReader((DbCommand)P_1);
	}

	internal static object LZfVOvWNvIWY8YgTagCG(object P_0)
	{
		return ((DbCommand)P_0).Connection;
	}

	internal static bool zn2gtwWN8LXLAvIu2SGE(object P_0)
	{
		return ((IBatcher)P_0).get_HasOpenResources();
	}

	internal static object hM0c3HWNZPhGctwvfPeE(object P_0, CommandType P_1, object P_2, object P_3)
	{
		return ((IBatcher)P_0).PrepareBatchCommand(P_1, (SqlString)P_2, (SqlType[])P_3);
	}

	internal static object FGr1S5WNu6TyFmTApfr5(object P_0)
	{
		return SetCommandTimeout(P_0);
	}

	internal static object iIK4XHWNI1aWnRF8j2rx(object P_0, CommandType P_1, object P_2, object P_3)
	{
		return ((IBatcher)P_0).PrepareCommand(P_1, (SqlString)P_2, (SqlType[])P_3);
	}

	internal static object PNw5ytWNVD1Afvaupbs3(object P_0, CommandType P_1, object P_2, object P_3)
	{
		return ((IBatcher)P_0).PrepareQueryCommand(P_1, (SqlString)P_2, (SqlType[])P_3);
	}

	internal static bool YTlIxWWNSJ2NqjV41rVr()
	{
		return Locator.Initialized;
	}

	internal static object zB4GdXWNiJmJQlwIpRWM(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static void lK8VUhWNRFs9VhqloFCY(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).ProcessException((Exception)P_1, (IDbConnection)P_2);
	}

	internal static void yH2K3rWNqICN5B653NPH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object NVaHjwWNKMtWrKqbjlsF(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
