using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Locking;

internal class DbDistributedLockService : LockService<DbDistributedLockServiceSettings>
{
	private static DbDistributedLockService A7klRkhraSB6M8OUqPui;

	public SessionFactoryHolder SessionFactoryHolder
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionFactoryHolder_003Ek__BackingField;
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
				case 1:
					_003CSessionFactoryHolder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
				case 1:
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
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

	private TimeSpan ValidUntilDateOverTime => JRj4pyhrmOpttAZEghdI(SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDF21EC), 2L));

	protected override Lock AcquireLockInternalImpl(string name, TimeSpan maxValidFor, TimeSpan timeout, TimeSpan repeatInterval)
	{
		int num = 3;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return _003C_003Ec__DisplayClass9_.dLock;
				case 4:
					_003C_003Ec__DisplayClass9_.maxValidFor = maxValidFor;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					RepeatUntilTimeout(timeout, repeatInterval, _003C_003Ec__DisplayClass9_._003CAcquireLockInternalImpl_003Eb__0);
					num2 = 6;
					continue;
				case 1:
					_003C_003Ec__DisplayClass9_.name = name;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					_003C_003Ec__DisplayClass9_.token = V1pUpEhrwoYOlZCOwbAw();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass9_.dLock = null;
			num = 7;
		}
	}

	[AsyncStateMachine(typeof(_003CAcquireLockInternalAsyncImpl_003Ed__10))]
	protected override Task<Lock> AcquireLockInternalAsyncImpl(string name, CancellationToken token, TimeSpan maxValidFor, TimeSpan timeout, TimeSpan repeatInterval)
	{
		_003CAcquireLockInternalAsyncImpl_003Ed__10 stateMachine = default(_003CAcquireLockInternalAsyncImpl_003Ed__10);
		stateMachine._003C_003E4__this = this;
		stateMachine.name = name;
		stateMachine.token = token;
		stateMachine.maxValidFor = maxValidFor;
		stateMachine.timeout = timeout;
		stateMachine.repeatInterval = repeatInterval;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Lock>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Lock> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	protected override string GetInternalLockName(string name)
	{
		return (string)GviZlLhr4AXrj6X62o6D(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978578622), name);
	}

	private bool TryObtainDbLock(string name, TimeSpan maxValidFor, Guid token)
	{
		//Discarded unreachable code: IL_00ee, IL_0121, IL_019a
		int num = 2;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass12_.hasLockRecord = false;
					num = 5;
					break;
				case 8:
					_003C_003Ec__DisplayClass12_.environmentIdentifier = (string)eerVA3hr6DqOrmKBk0Fi(base.ApplicationEnvironment);
					num = 4;
					break;
				case 3:
					_003C_003Ec__DisplayClass12_._003C_003E4__this = this;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					return _003C_003Ec__DisplayClass12_.hasLockRecord;
				case 6:
					_003C_003Ec__DisplayClass12_.token = token;
					num = 8;
					break;
				case 5:
					try
					{
						new StatelessSessionHelper(SessionFactoryHolder).ExecuteOnSeparateTransaction(_003C_003Ec__DisplayClass12_._003CTryObtainDbLock_003Eb__0);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 2:
								base.Logger.Debug(exception, (string)GviZlLhr4AXrj6X62o6D(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921032675), _003C_003Ec__DisplayClass12_.name));
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num4 = 1;
								}
								continue;
							default:
								_003C_003Ec__DisplayClass12_.hasLockRecord = false;
								num4 = 2;
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 7;
				default:
					_003C_003Ec__DisplayClass12_.maxValidFor = maxValidFor;
					num2 = 3;
					continue;
				case 1:
					_003C_003Ec__DisplayClass12_.name = name;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void ExtendDbLock(string name, TimeSpan maxValidFor, Guid token)
	{
		//Discarded unreachable code: IL_0074, IL_012e, IL_0166
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		_003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals0;
		CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass13_.maxValidFor = maxValidFor;
				num2 = 8;
				break;
			case 1:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_1();
					int num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass13_;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							CS_0024_003C_003E8__locals0.environmentIdentifier = (string)eerVA3hr6DqOrmKBk0Fi(base.ApplicationEnvironment);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return;
						}
						new StatelessSessionHelper(SessionFactoryHolder).ExecuteOnSeparateTransaction(delegate(IStatelessSession session)
						{
							//Discarded unreachable code: IL_00fb, IL_017d, IL_01dc, IL_0232
							int num5 = 9;
							int num6 = num5;
							DbLock dbLock = default(DbLock);
							DateTime utcNow = default(DateTime);
							DateTime? validUntilDate = default(DateTime?);
							DateTime? dateTime = default(DateTime?);
							while (true)
							{
								DateTime? dateTime2;
								switch (num6)
								{
								case 14:
									if (dbLock != null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
										{
											num6 = 1;
										}
										continue;
									}
									return;
								case 8:
									utcNow = DateTime.UtcNow;
									num6 = 3;
									continue;
								case 11:
									CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.ExtendDbLockByQuery(session, dbLock, validUntilDate);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num6 = 2;
									}
									continue;
								case 1:
									if (!(_003C_003Ec__DisplayClass13_1.Qv86qZvxFVuMwKk7YvPm(dbLock) == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.token))
									{
										num6 = 6;
										continue;
									}
									goto case 10;
								case 5:
									dateTime2 = _003C_003Ec__DisplayClass13_1.an7G4Ov7zlQAkWlcbxT5(utcNow, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.maxValidFor);
									break;
								case 3:
									if (_003C_003Ec__DisplayClass13_1.K7m9Pmv7cGhHBfsMG0b6(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.maxValidFor, LockService.InfiniteTimeSpan))
									{
										num6 = 7;
										continue;
									}
									goto case 5;
								case 4:
									return;
								case 6:
									return;
								case 12:
									return;
								case 7:
									dateTime = null;
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num6 = 0;
									}
									continue;
								case 10:
									if (!_003C_003Ec__DisplayClass13_1.HLIGPavxWmN7qb0B8IEM(_003C_003Ec__DisplayClass13_1.V5Pc1RvxBBh9p7f5lkeF(dbLock), CS_0024_003C_003E8__locals0.environmentIdentifier))
									{
										num6 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
										{
											num6 = 4;
										}
										continue;
									}
									goto case 13;
								case 13:
									dbLock.ValidUntilDate = validUntilDate;
									num6 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num6 = 9;
									}
									continue;
								case 9:
									dbLock = session.Get<DbLock>((object)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.name);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
									{
										num6 = 8;
									}
									continue;
								case 2:
									_003C_003Ec__DisplayClass13_1.n9HrXDvxhLXx3SWWs11s(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.Logger, _003C_003Ec__DisplayClass13_1.cBAWZ5vxbBRVIDpuJyGV(_003C_003Ec__DisplayClass13_1.fnmQXevxoFySYDaUokVn(0x4785BC0D ^ 0x47806811), dbLock.Id, _003C_003Ec__DisplayClass13_1.Qv86qZvxFVuMwKk7YvPm(dbLock)));
									num6 = 12;
									continue;
								default:
									dateTime2 = dateTime;
									break;
								}
								validUntilDate = dateTime2;
								num6 = 14;
							}
						});
						num3 = 2;
					}
				}
				finally
				{
					if (callContextSessionOwner != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								WVJor8hr7O1uEdjqePUI(callContextSessionOwner);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				_003C_003Ec__DisplayClass13_.name = name;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass13_._003C_003E4__this = this;
				num2 = 6;
				break;
			case 7:
				return;
			case 3:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				num2 = 2;
				break;
			case 5:
				callContextSessionOwner = (CallContextSessionOwner)rRyWJyhrAUViEFUJhtKs();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				base.Logger.Debug(GviZlLhr4AXrj6X62o6D(heC2OkhrH8m29hPNfOJs(-1921202237 ^ -1921032815), _003C_003Ec__DisplayClass13_.name));
				num2 = 5;
				break;
			case 8:
				_003C_003Ec__DisplayClass13_.token = token;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void DeleteDbLock(string name, Guid token)
	{
		//Discarded unreachable code: IL_00e4, IL_0117, IL_017a
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass14_.token = token;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				_003C_003Ec__DisplayClass14_.name = name;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				return;
			case 4:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
				num2 = 2;
				continue;
			}
			try
			{
				new StatelessSessionHelper(SessionFactoryHolder).ExecuteOnSeparateTransaction(_003C_003Ec__DisplayClass14_._003CDeleteDbLock_003Eb__0);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
			catch (Exception exception)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						base.Logger.Error(exception, (string)GviZlLhr4AXrj6X62o6D(heC2OkhrH8m29hPNfOJs(-1710575414 ^ -1710675386), _003C_003Ec__DisplayClass14_.name));
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			}
		}
	}

	private void ExecuteOnSeparateTransaction(Action<IStatelessSession> action)
	{
		IStatelessSession val = null;
		try
		{
			val = SessionFactoryHolder.SessionFactory.OpenStatelessSession();
			val.BeginTransaction(IsolationLevel.ReadCommitted);
			action(val);
		}
		catch (Exception exception)
		{
			if (val != null && val.get_Transaction() != null && val.get_Transaction().get_IsActive())
			{
				base.Logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837833083));
				val.get_Transaction().Rollback();
			}
			base.Logger.Debug(exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218522912));
		}
		finally
		{
			if (val != null)
			{
				try
				{
					if (val.get_Transaction() != null && val.get_Transaction().get_IsActive())
					{
						val.get_Transaction().Commit();
					}
				}
				finally
				{
					val.Close();
					((IDisposable)val).Dispose();
				}
			}
		}
	}

	private bool RepeatUntilTimeout(TimeSpan timeout, TimeSpan repeatInterval, Func<bool> action)
	{
		TimeSpan zero = TimeSpan.Zero;
		bool result;
		while (!(result = action()) && zero < timeout)
		{
			Thread.Sleep(repeatInterval);
			zero += repeatInterval;
		}
		return result;
	}

	[AsyncStateMachine(typeof(_003CRepeatUntilTimeoutAsync_003Ed__17))]
	private Task<bool> RepeatUntilTimeoutAsync(TimeSpan timeout, TimeSpan repeatInterval, CancellationToken token, Func<bool> action)
	{
		_003CRepeatUntilTimeoutAsync_003Ed__17 stateMachine = default(_003CRepeatUntilTimeoutAsync_003Ed__17);
		stateMachine.timeout = timeout;
		stateMachine.repeatInterval = repeatInterval;
		stateMachine.token = token;
		stateMachine.action = action;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void InsertDbLockByQuery(IStatelessSession session, DbLock dblock)
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
				CsiNUjhrx3qRY0QunsZy(session, dblock);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ExtendDbLockByQuery(IStatelessSession session, DbLock dbLock, DateTime? validUntilDate)
	{
		dbLock.ValidUntilDate = validUntilDate;
		session.Update((object)dbLock);
	}

	private void DeleteDbLockByQuery(IStatelessSession session, DbLock dblock)
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
				jBKeUmhr0rt347gUCeaD(session, dblock);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DbDistributedLockService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nrCtAkhry3qUpT6a99eY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool cTnZePhrDChU6HDP5ZA2()
	{
		return A7klRkhraSB6M8OUqPui == null;
	}

	internal static DbDistributedLockService vqeWWohrtTkjJv3nNiVE()
	{
		return A7klRkhraSB6M8OUqPui;
	}

	internal static Guid V1pUpEhrwoYOlZCOwbAw()
	{
		return Guid.NewGuid();
	}

	internal static object GviZlLhr4AXrj6X62o6D(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object eerVA3hr6DqOrmKBk0Fi(object P_0)
	{
		return ((IApplicationEnvironmentService)P_0).GetEnvironmentId();
	}

	internal static object heC2OkhrH8m29hPNfOJs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rRyWJyhrAUViEFUJhtKs()
	{
		return CallContextSessionOwner.Create();
	}

	internal static void WVJor8hr7O1uEdjqePUI(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object CsiNUjhrx3qRY0QunsZy(object P_0, object P_1)
	{
		return ((IStatelessSession)P_0).Insert(P_1);
	}

	internal static void jBKeUmhr0rt347gUCeaD(object P_0, object P_1)
	{
		((IStatelessSession)P_0).Delete(P_1);
	}

	internal static TimeSpan JRj4pyhrmOpttAZEghdI(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static void nrCtAkhry3qUpT6a99eY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
