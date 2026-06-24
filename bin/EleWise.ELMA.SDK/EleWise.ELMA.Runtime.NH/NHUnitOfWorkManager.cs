using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Engine;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

internal class NHUnitOfWorkManager : IUnitOfWorkManagerAsync, IUnitOfWorkManager, IUnitOfWorkManagerRollback
{
	private class UnitOfWork : EleWise.ELMA.Runtime.NH.UnitOfWork
	{
		private readonly object sessionProvider;

		private readonly object transformProvider;

		private readonly IEnumerable<IUnitOfWorkEventListener> listeners;

		private readonly bool nested;

		private readonly object dbName;

		private readonly Guid uid;

		private static object uHKsZsQ7gewG0ZdCGbs4;

		public override Task<bool> IsDirtyAsync => Session.IsDirtyAsync(CancellationToken.None);

		public override bool IsDirty => GFPl0yQxBaovBA51wt9S(Session);

		public override ISession Session => ((ISessionProvider)sessionProvider).GetSession((string)dbName);

		public override Guid Uid => uid;

		[AsyncStateMachine(typeof(_003CCommitAsync_003Ed__2))]
		public override Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			int num = 6;
			int num2 = num;
			_003CCommitAsync_003Ed__2 stateMachine = default(_003CCommitAsync_003Ed__2);
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			while (true)
			{
				switch (num2)
				{
				default:
					stateMachine._003C_003Et__builder = zr4d5FQ7YoiywvCnUZtw();
					num2 = 4;
					break;
				case 5:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return stateMachine._003C_003Et__builder.Task;
				case 1:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 3;
					break;
				case 4:
					stateMachine._003C_003E1__state = -1;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					stateMachine._003C_003E4__this = this;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		[AsyncStateMachine(typeof(_003CRollbackAsync_003Ed__3))]
		public override Task RollbackAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			int num = 4;
			int num2 = num;
			_003CRollbackAsync_003Ed__3 stateMachine = default(_003CRollbackAsync_003Ed__3);
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			while (true)
			{
				switch (num2)
				{
				case 1:
					stateMachine._003C_003E1__state = -1;
					num2 = 6;
					break;
				case 3:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					stateMachine._003C_003E4__this = this;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 3;
					}
					break;
				case 6:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					return stateMachine._003C_003Et__builder.Task;
				case 2:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 5;
					break;
				default:
					stateMachine._003C_003Et__builder = zr4d5FQ7YoiywvCnUZtw();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		[AsyncStateMachine(typeof(_003CExecuteRollbackActionsAsync_003Ed__4))]
		private Task ExecuteRollbackActionsAsync(CancellationToken cancellationToken)
		{
			int num = 5;
			int num2 = num;
			_003CExecuteRollbackActionsAsync_003Ed__4 stateMachine = default(_003CExecuteRollbackActionsAsync_003Ed__4);
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			while (true)
			{
				switch (num2)
				{
				case 5:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 4;
					break;
				case 4:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return stateMachine._003C_003Et__builder.Task;
				case 2:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					stateMachine._003C_003E1__state = -1;
					num2 = 3;
					break;
				case 3:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 2;
					break;
				}
			}
		}

		[AsyncStateMachine(typeof(_003CSafeExecuteActionAsync_003Ed__5))]
		private Task SafeExecuteActionAsync(Func<CancellationToken, Task> action, string errorMessage, ILogger logger, CancellationToken cancellationToken)
		{
			_003CSafeExecuteActionAsync_003Ed__5 stateMachine = default(_003CSafeExecuteActionAsync_003Ed__5);
			stateMachine.action = action;
			stateMachine.errorMessage = errorMessage;
			stateMachine.logger = logger;
			stateMachine.cancellationToken = cancellationToken;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			stateMachine._003C_003E1__state = -1;
			AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
			_003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		[AsyncStateMachine(typeof(_003CSafeExecuteListenersAsync_003Ed__6))]
		private Task SafeExecuteListenersAsync(Func<IUnitOfWorkEventListener, CancellationToken, Task> action, string errorMessage, ILogger logger, CancellationToken cancellationToken)
		{
			_003CSafeExecuteListenersAsync_003Ed__6 stateMachine = default(_003CSafeExecuteListenersAsync_003Ed__6);
			stateMachine._003C_003E4__this = this;
			stateMachine.action = action;
			stateMachine.errorMessage = errorMessage;
			stateMachine.logger = logger;
			stateMachine.cancellationToken = cancellationToken;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			stateMachine._003C_003E1__state = -1;
			AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
			_003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		public UnitOfWork(string dbName, bool transactional, ISessionProvider sessionProvider, ITransformationProvider transformProvider, IEnumerable<IUnitOfWorkEventListener> listeners, IsolationLevel isolationLevel = IsolationLevel.Unspecified)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			Contract.ArgumentNotNull(sessionProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099492539));
			Contract.ArgumentNotNull(transformProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E98CDE));
			Contract.ArgumentNotNull(listeners, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289485082));
			if (!transactional)
			{
				throw new NotImplementedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104904896));
			}
			this.dbName = dbName;
			this.sessionProvider = sessionProvider;
			this.transformProvider = transformProvider;
			this.listeners = listeners;
			uid = Guid.NewGuid();
			nested = HasTransaction(dbName, sessionProvider);
			if (nested)
			{
				return;
			}
			ISession session = sessionProvider.GetSession(dbName);
			if (isolationLevel != IsolationLevel.Unspecified && transformProvider.Dialect.IsIsolationLevelSupported(isolationLevel))
			{
				session.BeginTransaction(isolationLevel);
			}
			else
			{
				session.BeginTransaction();
			}
			foreach (IUnitOfWorkEventListener listener in this.listeners)
			{
				listener.OnStartUnitofWork(this);
			}
			RollbackHolder.SetRollBackFlag(dbName, flag: false);
			PreCommitActions.LockClear();
			PreCommitAsyncActions.LockClear();
			PostCommitActions.Clear();
			PostCommitAsyncActions.Clear();
			RollbackActions.Clear();
			RollbackAsyncActions.Clear();
		}

		public static bool HasTransaction(object dbName, [NotNull] ISessionProvider sessionProvider)
		{
			//Discarded unreachable code: IL_0063, IL_0072
			int num = 2;
			int num2 = num;
			ISession val = default(ISession);
			while (true)
			{
				switch (num2)
				{
				case 2:
					val = (ISession)S3hVyeQ7LJ0xbbpYTDdH(sessionProvider, dbName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return e3ypf1Q7s6vf4fCC4GRG(NArOBLQ7U2VhHHfu4cwm(val));
				default:
					return false;
				case 1:
					if (NArOBLQ7U2VhHHfu4cwm(val) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		public override void Dispose()
		{
			//Discarded unreachable code: IL_007b, IL_0085, IL_0102, IL_0142, IL_0151, IL_015d, IL_016c
			int num = 1;
			int num2 = num;
			IEnumerator<IUnitOfWorkEventListener> enumerator = default(IEnumerator<IUnitOfWorkEventListener>);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					ContextVars.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C513717));
					num2 = 3;
					break;
				case 3:
					return;
				case 1:
					if (nested)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						break;
					}
					enumerator = listeners.GetEnumerator();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!plk1QyQ7zFdelifhJRbA(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
								{
									num3 = 1;
								}
								goto IL_0089;
							}
							goto IL_009f;
							IL_009f:
							bmtlv1Q7cw3moBTH01eg(enumerator.Current, this);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
							{
								num3 = 0;
							}
							goto IL_0089;
							IL_0089:
							switch (num3)
							{
							case 2:
								break;
							default:
								continue;
							case 1:
								goto end_IL_00c6;
							}
							goto IL_009f;
							continue;
							end_IL_00c6:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 2;
							goto IL_0106;
						}
						goto IL_011c;
						IL_0106:
						switch (num4)
						{
						case 2:
							goto end_IL_00f1;
						case 1:
							goto end_IL_00f1;
						}
						goto IL_011c;
						IL_011c:
						LM72atQxFiRWk4wlOeSC(enumerator);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num4 = 1;
						}
						goto IL_0106;
						end_IL_00f1:;
					}
					goto case 4;
				case 0:
					return;
				}
			}
		}

		public override void Commit()
		{
			//Discarded unreachable code: IL_0148, IL_0157, IL_0162, IL_01a2, IL_01d5, IL_022a, IL_0239, IL_02b9, IL_02cc, IL_0302, IL_0311, IL_0321, IL_03e4, IL_03f3, IL_0480, IL_048f, IL_050a, IL_0518, IL_05ea, IL_062a, IL_0635, IL_0644, IL_072d, IL_073c, IL_0747, IL_0862, IL_089a, IL_09f6, IL_0a16, IL_0a25, IL_0bc3, IL_0c24, IL_0c56, IL_0c97, IL_0ca6, IL_0cb1, IL_0cb5, IL_0cbe, IL_0ce4, IL_0d33, IL_0d42, IL_0d6e, IL_0da1, IL_0def, IL_0dff, IL_0e30, IL_0e40, IL_0e4f, IL_0e5a, IL_0ed4, IL_0f07, IL_0f55, IL_0f64, IL_0f95, IL_0fcd, IL_0fef, IL_1071, IL_1080, IL_108f, IL_1102, IL_1217, IL_1226
			int num = 30;
			ISession val = default(ISession);
			Exception value2 = default(Exception);
			List<Action>.Enumerator enumerator4 = default(List<Action>.Enumerator);
			List<Action> list = default(List<Action>);
			DateTime dateTime2 = default(DateTime);
			Action current2 = default(Action);
			ILogger log = default(ILogger);
			_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0;
			Action result = default(Action);
			bool flag = default(bool);
			IEnumerator<KeyValuePair<CollectionKey, IPersistentCollection>> enumerator2 = default(IEnumerator<KeyValuePair<CollectionKey, IPersistentCollection>>);
			IPersistenceContext val3 = default(IPersistenceContext);
			IEnumerator<object> enumerator = default(IEnumerator<object>);
			IEntity entity = default(IEntity);
			EntityEntry val2 = default(EntityEntry);
			DateTime dateTime = default(DateTime);
			KeyValuePair<CollectionKey, IPersistentCollection> current = default(KeyValuePair<CollectionKey, IPersistentCollection>);
			IPersistentCollection value = default(IPersistentCollection);
			IEnumerator<IUnitOfWorkEventListener> enumerator3 = default(IEnumerator<IUnitOfWorkEventListener>);
			IUnitOfWorkEventListener current3 = default(IUnitOfWorkEventListener);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 29:
						if (!nested)
						{
							num2 = 18;
							continue;
						}
						return;
					case 34:
						if (e3ypf1Q7s6vf4fCC4GRG(val.get_Transaction()))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num2 = 7;
							}
							continue;
						}
						return;
					case 14:
						ContextVars.TryGetValue<Exception>((string)lVYGWnQxWFWdWWsa2drl(0x5F3078B6 ^ 0x5F32775E), out value2);
						num2 = 35;
						continue;
					case 21:
						enumerator4 = list.GetEnumerator();
						num2 = 19;
						continue;
					case 28:
						dateTime2 = tytbEIQxGYtdIsuNbEpj();
						num2 = 6;
						continue;
					case 19:
						try
						{
							while (true)
							{
								int num16;
								if (!enumerator4.MoveNext())
								{
									num16 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
									{
										num16 = 1;
									}
									goto IL_0166;
								}
								goto IL_026a;
								IL_026a:
								current2 = enumerator4.Current;
								num16 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
								{
									num16 = 0;
								}
								goto IL_0166;
								IL_0166:
								switch (num16)
								{
								case 3:
									continue;
								case 2:
									goto IL_026a;
								case 1:
									goto end_IL_0244;
								}
								try
								{
									current2();
									int num17 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num17 = 0;
									}
									switch (num17)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex2)
								{
									int num18 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num18 = 0;
									}
									while (true)
									{
										switch (num18)
										{
										default:
											RiwEiGQxqBgmtsuNeI3k(log, in5MJ2QxTL2IBff9TMll(lVYGWnQxWFWdWWsa2drl(-951514650 ^ -951284552), current2), ex2);
											num18 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
											{
												num18 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								continue;
								end_IL_0244:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator4).Dispose();
							int num19 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num19 = 0;
							}
							switch (num19)
							{
							case 0:
								break;
							}
						}
						goto case 20;
					case 35:
						if (RPRqaLQxb9VjsvES0nsa(KeYCnBQxoxqJfEhhmHjh(), dbName))
						{
							num = 26;
							break;
						}
						goto case 11;
					case 10:
						return;
					case 6:
						try
						{
							CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
							int num3 = 15;
							while (true)
							{
								int num7;
								switch (num3)
								{
								default:
									if (!PreCommitActions.LockTryDequeue(out result))
									{
										num3 = 36;
										continue;
									}
									goto case 4;
								case 8:
									SafeExecuteListeners(delegate(IUnitOfWorkEventListener l)
									{
										int num28 = 1;
										int num29 = num28;
										while (true)
										{
											switch (num29)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												l.OnPreFlushUnitofWork(CS_0024_003C_003E8__locals0._003C_003E4__this, CS_0024_003C_003E8__locals0.changedEntities);
												num29 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
												{
													num29 = 0;
												}
												break;
											}
										}
									}, (string)lVYGWnQxWFWdWWsa2drl(-1459557599 ^ -1459262501), log);
									num3 = 24;
									continue;
								case 7:
									CS_0024_003C_003E8__locals0.revertEntities = GetRevertEntities((string)dbName);
									num3 = 34;
									continue;
								case 16:
									if (flag)
									{
										num3 = 11;
										continue;
									}
									goto case 19;
								case 12:
									SafeExecuteAction(result, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575855380), result), log);
									num3 = 30;
									continue;
								case 35:
									enumerator2 = val3.get_CollectionsByKey().GetEnumerator();
									num3 = 9;
									continue;
								case 14:
									if (!flag)
									{
										num3 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
										{
											num3 = 21;
										}
										continue;
									}
									goto case 32;
								case 17:
									try
									{
										while (true)
										{
											int num5;
											if (!enumerator.MoveNext())
											{
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
												{
													num5 = 1;
												}
												goto IL_051c;
											}
											goto IL_059a;
											IL_059a:
											entity = (IEntity)enumerator.Current;
											num5 = 2;
											goto IL_051c;
											IL_051c:
											while (true)
											{
												switch (num5)
												{
												case 2:
													val2 = (EntityEntry)kBcs7rQxQGuFrMXqRu9Y(val3, entity);
													num5 = 3;
													continue;
												case 3:
													if (val2 != null)
													{
														num5 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
														{
															num5 = 0;
														}
														continue;
													}
													break;
												case 4:
													break;
												case 5:
													goto IL_059a;
												default:
													uFYyQwQxCeYgGuhAlXtP(val2, (Status)5);
													num5 = 4;
													continue;
												case 1:
													goto end_IL_0574;
												}
												break;
											}
											continue;
											end_IL_0574:
											break;
										}
									}
									finally
									{
										int num6;
										if (enumerator == null)
										{
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
											{
												num6 = 1;
											}
											goto IL_05ee;
										}
										goto IL_0604;
										IL_0604:
										LM72atQxFiRWk4wlOeSC(enumerator);
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
										{
											num6 = 0;
										}
										goto IL_05ee;
										IL_05ee:
										switch (num6)
										{
										default:
											goto end_IL_05c9;
										case 2:
											break;
										case 1:
											goto end_IL_05c9;
										case 0:
											goto end_IL_05c9;
										}
										goto IL_0604;
										end_IL_05c9:;
									}
									goto case 33;
								case 1:
									if (flag)
									{
										num3 = 28;
										continue;
									}
									goto default;
								case 11:
									bEusJaQxSEJSFiMsvlMZ(log, fPQEkTQxIyFdrIwCntiT(lVYGWnQxWFWdWWsa2drl(0x53CACA3 ^ 0x5392EE3), (int)VPpcM4QxVEF014kvURka(tytbEIQxGYtdIsuNbEpj(), dateTime).TotalMilliseconds, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606949238)));
									num3 = 19;
									continue;
								case 22:
									dateTime = DateTime.Now;
									num3 = 13;
									continue;
								case 18:
									SafeExecuteListeners(delegate(IUnitOfWorkEventListener l)
									{
										int num26 = 1;
										int num27 = num26;
										while (true)
										{
											switch (num27)
											{
											default:
												return;
											case 1:
												UhKvYGQxpJVTtappYxQW(l, this);
												num27 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
												{
													num27 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									}, (string)lVYGWnQxWFWdWWsa2drl(0x49E27B8A ^ 0x49E7FA2A), log);
									num3 = 26;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num3 = 9;
									}
									continue;
								case 32:
									bEusJaQxSEJSFiMsvlMZ(log, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675734997));
									num3 = 10;
									continue;
								case 9:
									try
									{
										while (true)
										{
											int num8;
											if (!plk1QyQ7zFdelifhJRbA(enumerator2))
											{
												num8 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
												{
													num8 = 2;
												}
												goto IL_074b;
											}
											goto IL_0829;
											IL_0829:
											current = enumerator2.Current;
											num8 = 4;
											goto IL_074b;
											IL_074b:
											while (true)
											{
												switch (num8)
												{
												case 6:
													if (CS_0024_003C_003E8__locals0.revertEntities.Contains(vYnbupQx84SNAyOpMLw9(value)))
													{
														num8 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
														{
															num8 = 0;
														}
														continue;
													}
													break;
												case 3:
													if (vYnbupQx84SNAyOpMLw9(value) != null)
													{
														num8 = 6;
														continue;
													}
													break;
												case 4:
													if ((value = current.Value) != null)
													{
														num8 = 3;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
														{
															num8 = 1;
														}
														continue;
													}
													break;
												case 1:
													pdG6FgQxZlDyjfyYri39(value);
													num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
													{
														num8 = 0;
													}
													continue;
												case 5:
													goto IL_0829;
												case 2:
													goto end_IL_07a3;
												}
												break;
											}
											continue;
											end_IL_07a3:
											break;
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											int num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
											{
												num9 = 0;
											}
											while (true)
											{
												switch (num9)
												{
												default:
													LM72atQxFiRWk4wlOeSC(enumerator2);
													num9 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
													{
														num9 = 0;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto case 8;
								case 26:
									dateTime = tytbEIQxGYtdIsuNbEpj();
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
									{
										num3 = 3;
									}
									continue;
								case 23:
									log.Debug(fPQEkTQxIyFdrIwCntiT(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2A9623B), (int)(tytbEIQxGYtdIsuNbEpj() - dateTime).TotalMilliseconds, lVYGWnQxWFWdWWsa2drl(0x6A81B9B4 ^ 0x6A843822)));
									num3 = 18;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num3 = 1;
									}
									continue;
								case 5:
									CS_0024_003C_003E8__locals0.changedEntities = val3.get_EntitiesByKey().Values.ToList();
									num3 = 20;
									continue;
								case 19:
								case 25:
									SafeExecuteListeners(delegate(IUnitOfWorkEventListener l)
									{
										int num24 = 1;
										int num25 = num24;
										while (true)
										{
											switch (num25)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												l.OnPostFlushUnitofWork(this);
												num25 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
												{
													num25 = 0;
												}
												break;
											}
										}
									}, (string)lVYGWnQxWFWdWWsa2drl(0x4EA5403C ^ 0x4EA0C2AC), log);
									num3 = 27;
									continue;
								case 28:
									bEusJaQxSEJSFiMsvlMZ(log, lVYGWnQxWFWdWWsa2drl(0x7E6E5A0B ^ 0x7E6BD8D5));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
									{
										num3 = 0;
									}
									continue;
								case 6:
								case 36:
									PreCommitActions.LockClear();
									num3 = 14;
									continue;
								case 27:
									if (d7tLxfQxiyPfvdVgXtLw(PreCommitActions) > 0)
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									break;
								case 24:
									dateTime = tytbEIQxGYtdIsuNbEpj();
									num3 = 29;
									continue;
								case 21:
									break;
								case 13:
									TbMfKXQxuSvxpZpnpA7s(val);
									num3 = 16;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num3 = 7;
									}
									continue;
								case 29:
									TbMfKXQxuSvxpZpnpA7s(val);
									num3 = 2;
									continue;
								case 4:
									if (result == null)
									{
										num3 = 31;
										continue;
									}
									goto case 12;
								case 34:
									val3 = (IPersistenceContext)TRt7n7QxfYqVTuH3e7Bt(tkiEt2QxExZnkKZyfTPs(val));
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num3 = 5;
									}
									continue;
								case 33:
									if (t1aUZ8Qxv1JG93iRAuKT(CS_0024_003C_003E8__locals0.revertEntities) > 0)
									{
										num7 = 35;
										goto IL_033d;
									}
									goto case 8;
								case 15:
									CS_0024_003C_003E8__locals0._003C_003E4__this = this;
									num7 = 7;
									goto IL_033d;
								case 2:
									if (flag)
									{
										num7 = 23;
										goto IL_033d;
									}
									goto case 18;
								case 20:
									enumerator = CS_0024_003C_003E8__locals0.changedEntities.Where((object e) => CS_0024_003C_003E8__locals0.revertEntities.Contains(e)).GetEnumerator();
									num3 = 17;
									continue;
								case 3:
								{
									bool num4 = val.IsDirty();
									if (flag)
									{
										log.Debug(fPQEkTQxIyFdrIwCntiT(lVYGWnQxWFWdWWsa2drl(0x1DE3DD89 ^ 0x1DE65C67), (int)VPpcM4QxVEF014kvURka(tytbEIQxGYtdIsuNbEpj(), dateTime).TotalMilliseconds, lVYGWnQxWFWdWWsa2drl(0x49E27B8A ^ 0x49E7FA1C)));
									}
									if (!num4)
									{
										num3 = 25;
										continue;
									}
									goto case 22;
								}
								case 10:
									break;
									IL_033d:
									num3 = num7;
									continue;
								}
								break;
							}
						}
						catch
						{
							int num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num10 = 0;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
									{
										num10 = 3;
									}
									continue;
								case 1:
									try
									{
										try
										{
											nSwMWiQxRTtZEmZNqPNU(val.get_Transaction());
											int num13 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
											{
												num13 = 0;
											}
											switch (num13)
											{
											case 0:
												break;
											}
										}
										catch
										{
											int num14 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
											{
												num14 = 0;
											}
											while (true)
											{
												switch (num14)
												{
												default:
													((IDisposable)NArOBLQ7U2VhHHfu4cwm(val)).Dispose();
													num14 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
													{
														num14 = 0;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									catch (Exception ex)
									{
										int num15 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
										{
											num15 = 1;
										}
										while (true)
										{
											switch (num15)
											{
											case 1:
												RiwEiGQxqBgmtsuNeI3k(log, lVYGWnQxWFWdWWsa2drl(-289714582 ^ -289845778), ex);
												num15 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
												{
													num15 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									goto default;
								case 3:
									try
									{
										ExecuteRollbackActions();
										int num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
										{
											num11 = 0;
										}
										switch (num11)
										{
										case 0:
											break;
										}
									}
									catch (Exception exception)
									{
										int num12 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
										{
											num12 = 0;
										}
										while (true)
										{
											switch (num12)
											{
											default:
												log.Error(lVYGWnQxWFWdWWsa2drl(0x4EA5403C ^ 0x4EA0C3C4), exception);
												num12 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
												{
													num12 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									break;
								case 2:
									break;
								}
								break;
							}
							throw;
						}
						goto case 17;
					case 12:
						return;
					case 38:
						log = Logger.Log;
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 30;
						}
						continue;
					case 1:
						return;
					case 2:
						try
						{
							while (true)
							{
								int num20;
								if (!enumerator3.MoveNext())
								{
									num20 = 3;
									goto IL_0e5e;
								}
								goto IL_0e78;
								IL_0e5e:
								switch (num20)
								{
								case 2:
									break;
								default:
									continue;
								case 1:
									try
									{
										g582XlQxX86Bfggk2GAj(current3, this);
										int num21 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
										{
											num21 = 0;
										}
										switch (num21)
										{
										case 0:
											break;
										}
									}
									catch (Exception ex3)
									{
										int num22 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
										{
											num22 = 1;
										}
										while (true)
										{
											switch (num22)
											{
											case 1:
												RiwEiGQxqBgmtsuNeI3k(log, lVYGWnQxWFWdWWsa2drl(0x2A7797B7 ^ 0x2A721315), ex3);
												num22 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
												{
													num22 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									continue;
								case 3:
									goto end_IL_0e9b;
								}
								goto IL_0e78;
								IL_0e78:
								current3 = enumerator3.Current;
								num20 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
								{
									num20 = 1;
								}
								goto IL_0e5e;
								continue;
								end_IL_0e9b:
								break;
							}
						}
						finally
						{
							if (enumerator3 != null)
							{
								int num23 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
								{
									num23 = 0;
								}
								while (true)
								{
									switch (num23)
									{
									case 1:
										LM72atQxFiRWk4wlOeSC(enumerator3);
										num23 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
										{
											num23 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 37;
					case 39:
						flag = log.IsDebugEnabled();
						num2 = 28;
						continue;
					case 4:
						return;
					case 17:
						dateTime = tytbEIQxGYtdIsuNbEpj();
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 33;
						}
						continue;
					case 37:
						list = PostCommitActions.ToList();
						num = 31;
						break;
					case 31:
						if (list.Count > 0)
						{
							num2 = 5;
							continue;
						}
						goto case 13;
					case 30:
						val = (ISession)S3hVyeQ7LJ0xbbpYTDdH(sessionProvider, dbName);
						num2 = 29;
						continue;
					case 27:
						bEusJaQxSEJSFiMsvlMZ(log, lVYGWnQxWFWdWWsa2drl(0x571EA399 ^ 0x571B2635));
						num2 = 22;
						continue;
					case 13:
					case 22:
						if (!flag)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 9;
					case 23:
						return;
					case 3:
					case 26:
						weZP9pQxhIXoTxiIdgjA(this);
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 12;
						}
						continue;
					case 9:
						bEusJaQxSEJSFiMsvlMZ(log, fPQEkTQxIyFdrIwCntiT(lVYGWnQxWFWdWWsa2drl(0x35C0467B ^ 0x35C5C069), (int)VPpcM4QxVEF014kvURka(DateTime.Now, dateTime2).TotalMilliseconds, lVYGWnQxWFWdWWsa2drl(0x10E41EDB ^ 0x10E19F4D)));
						num = 23;
						break;
					case 36:
						return;
					case 7:
						PmXx0OQxKFw6yi2wMnhq(NArOBLQ7U2VhHHfu4cwm(val));
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 8;
						}
						continue;
					case 33:
						if (NArOBLQ7U2VhHHfu4cwm(val) == null)
						{
							num2 = 10;
							continue;
						}
						goto case 34;
					case 20:
						if (!flag)
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
							{
								num2 = 13;
							}
							continue;
						}
						goto case 27;
					case 8:
						if (!flag)
						{
							num2 = 15;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num2 = 14;
							}
							continue;
						}
						goto case 24;
					case 11:
						if (value2 == null)
						{
							num2 = 38;
							continue;
						}
						goto case 3;
					case 25:
						if (!((ITransaction)NArOBLQ7U2VhHHfu4cwm(val)).get_IsActive())
						{
							num2 = 4;
							continue;
						}
						goto case 14;
					default:
						enumerator3 = listeners.GetEnumerator();
						num2 = 2;
						continue;
					case 5:
						PostCommitActions.Clear();
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 7;
						}
						continue;
					case 16:
						if (flag)
						{
							num2 = 32;
							continue;
						}
						goto case 21;
					case 32:
						bEusJaQxSEJSFiMsvlMZ(log, lVYGWnQxWFWdWWsa2drl(0x307E9FD1 ^ 0x307B1B23));
						num2 = 21;
						continue;
					case 24:
						bEusJaQxSEJSFiMsvlMZ(log, fPQEkTQxIyFdrIwCntiT(lVYGWnQxWFWdWWsa2drl(0x63ABA4E8 ^ 0x63AE20D2), (int)VPpcM4QxVEF014kvURka(tytbEIQxGYtdIsuNbEpj(), dateTime).TotalMilliseconds, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E98D2E)));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 0;
						}
						continue;
					case 18:
						if (NArOBLQ7U2VhHHfu4cwm(val) == null)
						{
							return;
						}
						num2 = 25;
						continue;
					}
					break;
				}
			}
		}

		public override void Rollback()
		{
			//Discarded unreachable code: IL_0065, IL_0074, IL_00d2, IL_0105, IL_0157, IL_0166, IL_0176, IL_0185, IL_01bb, IL_021f, IL_0251, IL_0292, IL_02a1, IL_0326, IL_0377, IL_0386, IL_04a7, IL_04b6, IL_04c7, IL_04d1, IL_0538, IL_056b, IL_05bd, IL_05cc, IL_0620, IL_0658
			int num = 12;
			Exception value = default(Exception);
			ISession val = default(ISession);
			IEnumerator<IUnitOfWorkEventListener> enumerator = default(IEnumerator<IUnitOfWorkEventListener>);
			IUnitOfWorkEventListener current = default(IUnitOfWorkEventListener);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						return;
					case 8:
						ContextVars.TryGetValue<Exception>((string)lVYGWnQxWFWdWWsa2drl(-87337865 ^ -87467105), out value);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 2;
						}
						continue;
					case 14:
						try
						{
							ExecuteRollbackActions();
							int num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num7 = 0;
							}
							switch (num7)
							{
							case 0:
								break;
							}
						}
						catch (Exception exception)
						{
							int num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
							{
								num8 = 1;
							}
							while (true)
							{
								switch (num8)
								{
								case 1:
									((ILogger)IgZLptQxkqm8NcH9aSc4()).Error(lVYGWnQxWFWdWWsa2drl(0x12441CA4 ^ 0x12419F5C), exception);
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
									{
										num8 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 2;
					case 5:
						return;
					case 4:
						try
						{
							((ILogger)IgZLptQxkqm8NcH9aSc4()).Debug(lVYGWnQxWFWdWWsa2drl(0x49E27B8A ^ 0x49E7FDD8));
							int num9 = 4;
							while (true)
							{
								switch (num9)
								{
								case 3:
									y1XPPvQxnsKc7QExKJfa(RollbackHolder, dbName, false);
									num9 = 2;
									continue;
								case 4:
									try
									{
										nSwMWiQxRTtZEmZNqPNU(NArOBLQ7U2VhHHfu4cwm(val));
										int num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
										{
											num10 = 0;
										}
										switch (num10)
										{
										case 0:
											break;
										}
									}
									catch
									{
										int num11 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
										{
											num11 = 0;
										}
										while (true)
										{
											switch (num11)
											{
											case 1:
												LM72atQxFiRWk4wlOeSC(NArOBLQ7U2VhHHfu4cwm(val));
												num11 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
												{
													num11 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									goto default;
								default:
									bEusJaQxSEJSFiMsvlMZ(IgZLptQxkqm8NcH9aSc4(), lVYGWnQxWFWdWWsa2drl(--1360331293 ^ 0x511084D1));
									num9 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num9 = 2;
									}
									continue;
								case 2:
									PreCommitActions.LockClear();
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num9 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						catch (Exception exception2)
						{
							int num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
							{
								num12 = 1;
							}
							while (true)
							{
								switch (num12)
								{
								case 1:
									Logger.Log.Warn(lVYGWnQxWFWdWWsa2drl(0x42643203 ^ 0x42663187), exception2);
									num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num12 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 16;
					case 11:
						if (!nested)
						{
							num2 = 10;
							continue;
						}
						goto case 9;
					case 15:
						if (e3ypf1Q7s6vf4fCC4GRG(val.get_Transaction()))
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 9;
					case 9:
					case 13:
						if (nested)
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 8;
					case 10:
						if (val.get_Transaction() == null)
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 15;
					case 2:
						enumerator = listeners.GetEnumerator();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						break;
					case 16:
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 14;
						}
						continue;
					case 7:
						throw value;
					case 12:
						val = (ISession)S3hVyeQ7LJ0xbbpYTDdH(sessionProvider, dbName);
						num2 = 11;
						continue;
					default:
						try
						{
							while (true)
							{
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num3 = 1;
									}
									goto IL_04d5;
								}
								goto IL_05d7;
								IL_05d7:
								current = enumerator.Current;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num3 = 0;
								}
								goto IL_04d5;
								IL_04d5:
								switch (num3)
								{
								case 1:
									continue;
								case 2:
									goto IL_05d7;
								case 3:
									goto end_IL_04ef;
								}
								try
								{
									lUpySHQxOTV8sSOuHkVy(current, this);
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											RiwEiGQxqBgmtsuNeI3k(IgZLptQxkqm8NcH9aSc4(), lVYGWnQxWFWdWWsa2drl(-1767720453 ^ -1767424321), ex);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								continue;
								end_IL_04ef:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num6 = 1;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										LM72atQxFiRWk4wlOeSC(enumerator);
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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
						goto case 9;
					case 6:
						if (value == null)
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num2 = 3;
							}
							continue;
						}
						break;
					}
					break;
				}
				A0hNHvQx26oB5XOtQ5EC(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345292244));
				num = 7;
			}
		}

		private void ExecuteRollbackActions()
		{
			//Discarded unreachable code: IL_0094, IL_00a3, IL_00ae, IL_0101, IL_0134, IL_018f, IL_019e, IL_01fb, IL_020e, IL_021d, IL_02db, IL_02ea
			int num = 12;
			int num2 = num;
			List<Action> list = default(List<Action>);
			List<Action>.Enumerator enumerator = default(List<Action>.Enumerator);
			Action current = default(Action);
			ILogger logger = default(ILogger);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 5:
					return;
				case 12:
					list = RollbackActions.ToList();
					num2 = 11;
					break;
				case 11:
					if (dmmtPMQxe2x9G5JRH2EM(list) <= 0)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 1;
					}
					break;
				case 8:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
								{
									num3 = 1;
								}
								goto IL_00b2;
							}
							goto IL_00cc;
							IL_00cc:
							current = enumerator.Current;
							num3 = 3;
							goto IL_00b2;
							IL_00b2:
							switch (num3)
							{
							case 2:
								break;
							case 3:
								try
								{
									current();
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											RiwEiGQxqBgmtsuNeI3k(logger, in5MJ2QxTL2IBff9TMll(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5CADBF), current), ex);
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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
								continue;
							default:
								continue;
							case 1:
								goto end_IL_01a9;
							}
							goto IL_00cc;
							continue;
							end_IL_01a9:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 9;
				case 2:
					RollbackActions.Clear();
					num2 = 7;
					break;
				case 4:
					bEusJaQxSEJSFiMsvlMZ(logger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824027643));
					num2 = 10;
					break;
				case 7:
					if (flag)
					{
						num2 = 4;
						break;
					}
					goto case 10;
				default:
					bEusJaQxSEJSFiMsvlMZ(logger, lVYGWnQxWFWdWWsa2drl(-398663332 ^ -398890726));
					num2 = 5;
					break;
				case 6:
					flag = logger.IsDebugEnabled();
					num2 = 2;
					break;
				case 1:
					logger = (ILogger)IgZLptQxkqm8NcH9aSc4();
					num2 = 6;
					break;
				case 10:
					enumerator = list.GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 7;
					}
					break;
				case 9:
					if (!flag)
					{
						num2 = 3;
						break;
					}
					goto default;
				}
			}
		}

		private void SafeExecuteAction(Action action, string errorMessage, ILogger logger)
		{
			//Discarded unreachable code: IL_0046, IL_0078, IL_00a8, IL_0197, IL_01a6
			switch (1)
			{
			case 0:
				break;
			case 1:
				try
				{
					jOVdFPQxPtcF17HYOxfN(action);
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num = 0;
					}
					switch (num)
					{
					case 0:
						break;
					}
					break;
				}
				catch (TransactionRollbackException)
				{
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					default:
						throw;
					}
				}
				catch (Exception ex2)
				{
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num3 = 2;
					}
					Exception value = default(Exception);
					while (true)
					{
						switch (num3)
						{
						default:
							ContextVars.TryGetValue<Exception>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A4DDD8), out value);
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
							{
								num3 = 4;
							}
							break;
						case 2:
							RiwEiGQxqBgmtsuNeI3k(logger, errorMessage, ex2);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num3 = 0;
							}
							break;
						case 4:
							if (value == null)
							{
								return;
							}
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num3 = 2;
							}
							break;
						case 3:
							A0hNHvQx26oB5XOtQ5EC(lVYGWnQxWFWdWWsa2drl(-138018305 ^ -138146281));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							throw new InvalidOperationException((string)jLcAXoQx1CaIUbqaZ4CG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138596514)), value);
						}
					}
				}
			}
		}

		private void SafeExecuteListeners(Action<IUnitOfWorkEventListener> action, string errorMessage, ILogger logger)
		{
			_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
			_003C_003Ec__DisplayClass26_.action = action;
			foreach (IUnitOfWorkEventListener listener in listeners)
			{
				_003C_003Ec__DisplayClass26_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass26_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass26_;
				CS_0024_003C_003E8__locals0.currentListener = listener;
				SafeExecuteAction(delegate
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
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.action(CS_0024_003C_003E8__locals0.currentListener);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}, errorMessage, logger);
			}
		}

		internal static AsyncTaskMethodBuilder zr4d5FQ7YoiywvCnUZtw()
		{
			return AsyncTaskMethodBuilder.Create();
		}

		internal static bool KBOH3XQ75JJQL8LCjlZS()
		{
			return uHKsZsQ7gewG0ZdCGbs4 == null;
		}

		internal static UnitOfWork PoaeK8Q7jvt1QFr1AqBf()
		{
			return (UnitOfWork)uHKsZsQ7gewG0ZdCGbs4;
		}

		internal static object S3hVyeQ7LJ0xbbpYTDdH(object P_0, object P_1)
		{
			return ((ISessionProvider)P_0).GetSession((string)P_1);
		}

		internal static object NArOBLQ7U2VhHHfu4cwm(object P_0)
		{
			return ((ISession)P_0).get_Transaction();
		}

		internal static bool e3ypf1Q7s6vf4fCC4GRG(object P_0)
		{
			return ((ITransaction)P_0).get_IsActive();
		}

		internal static void bmtlv1Q7cw3moBTH01eg(object P_0, object P_1)
		{
			((IUnitOfWorkEventListener)P_0).OnDisposeUnitofWork((IUnitOfWork)P_1);
		}

		internal static bool plk1QyQ7zFdelifhJRbA(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void LM72atQxFiRWk4wlOeSC(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static bool GFPl0yQxBaovBA51wt9S(object P_0)
		{
			return ((ISession)P_0).IsDirty();
		}

		internal static object lVYGWnQxWFWdWWsa2drl(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object KeYCnBQxoxqJfEhhmHjh()
		{
			return RollbackHolder;
		}

		internal static bool RPRqaLQxb9VjsvES0nsa(object P_0, object P_1)
		{
			return ((UnitOfWorkContextRollbackHolder)P_0).GetRollBackFlag((string)P_1);
		}

		internal static void weZP9pQxhIXoTxiIdgjA(object P_0)
		{
			((EleWise.ELMA.Runtime.NH.UnitOfWork)P_0).Rollback();
		}

		internal static DateTime tytbEIQxGYtdIsuNbEpj()
		{
			return DateTime.Now;
		}

		internal static object tkiEt2QxExZnkKZyfTPs(object P_0)
		{
			return ((ISession)P_0).GetSessionImplementation();
		}

		internal static object TRt7n7QxfYqVTuH3e7Bt(object P_0)
		{
			return ((ISessionImplementor)P_0).get_PersistenceContext();
		}

		internal static object kBcs7rQxQGuFrMXqRu9Y(object P_0, object P_1)
		{
			return ((IPersistenceContext)P_0).GetEntry(P_1);
		}

		internal static void uFYyQwQxCeYgGuhAlXtP(object P_0, Status P_1)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			((EntityEntry)P_0).set_Status(P_1);
		}

		internal static int t1aUZ8Qxv1JG93iRAuKT(object P_0)
		{
			return ((List<object>)P_0).Count;
		}

		internal static object vYnbupQx84SNAyOpMLw9(object P_0)
		{
			return ((IPersistentCollection)P_0).get_Owner();
		}

		internal static void pdG6FgQxZlDyjfyYri39(object P_0)
		{
			((IPersistentCollection)P_0).ClearDirty();
		}

		internal static void TbMfKXQxuSvxpZpnpA7s(object P_0)
		{
			((ISession)P_0).Flush();
		}

		internal static object fPQEkTQxIyFdrIwCntiT(object P_0, object P_1, object P_2)
		{
			return string.Concat(P_0, P_1, P_2);
		}

		internal static TimeSpan VPpcM4QxVEF014kvURka(DateTime P_0, DateTime P_1)
		{
			return P_0 - P_1;
		}

		internal static void bEusJaQxSEJSFiMsvlMZ(object P_0, object P_1)
		{
			((ILogger)P_0).Debug(P_1);
		}

		internal static int d7tLxfQxiyPfvdVgXtLw(object P_0)
		{
			return ((Queue<Action>)P_0).Count;
		}

		internal static void nSwMWiQxRTtZEmZNqPNU(object P_0)
		{
			((ITransaction)P_0).Rollback();
		}

		internal static void RiwEiGQxqBgmtsuNeI3k(object P_0, object P_1, object P_2)
		{
			((ILogger)P_0).Error(P_1, (Exception)P_2);
		}

		internal static void PmXx0OQxKFw6yi2wMnhq(object P_0)
		{
			((ITransaction)P_0).Commit();
		}

		internal static void g582XlQxX86Bfggk2GAj(object P_0, object P_1)
		{
			((IUnitOfWorkEventListener)P_0).OnPostCommitUnitofWork((IUnitOfWork)P_1);
		}

		internal static object in5MJ2QxTL2IBff9TMll(object P_0, object P_1)
		{
			return string.Format((string)P_0, P_1);
		}

		internal static object IgZLptQxkqm8NcH9aSc4()
		{
			return Logger.Log;
		}

		internal static void y1XPPvQxnsKc7QExKJfa(object P_0, object P_1, bool flag)
		{
			((UnitOfWorkContextRollbackHolder)P_0).SetRollBackFlag((string)P_1, flag);
		}

		internal static void lUpySHQxOTV8sSOuHkVy(object P_0, object P_1)
		{
			((IUnitOfWorkEventListener)P_0).OnPostRollbackUnitofWork((IUnitOfWork)P_1);
		}

		internal static void A0hNHvQx26oB5XOtQ5EC(object P_0)
		{
			ContextVars.Remove((string)P_0);
		}

		internal static int dmmtPMQxe2x9G5JRH2EM(object P_0)
		{
			return ((List<Action>)P_0).Count;
		}

		internal static void jOVdFPQxPtcF17HYOxfN(object P_0)
		{
			P_0();
		}

		internal static object jLcAXoQx1CaIUbqaZ4CG(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static object FySL82QxNDLehktR2TOt()
		{
			return Task.CompletedTask;
		}

		internal static void WZEfrBQx33oM8b2ljov4(object P_0, object P_1)
		{
			((IUnitOfWorkEventListener)P_0).OnPostFlushUnitofWork((IUnitOfWork)P_1);
		}

		internal static void UhKvYGQxpJVTtappYxQW(object P_0, object P_1)
		{
			((IUnitOfWorkEventListener)P_0).OnPreCommitUnitofWork((IUnitOfWork)P_1);
		}
	}

	private class UnitOfWorkContextRollbackHolder
	{
		internal static object jhW8ZGQxau4mWS8Lnve8;

		public List<Action> Actions { get; set; }

		public List<Func<CancellationToken, Task>> AsyncActions { get; set; }

		public static UnitOfWorkContextRollbackHolder GetFromContext()
		{
			return ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A367716), () => new UnitOfWorkContextRollbackHolder());
		}

		private UnitOfWorkContextRollbackHolder()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			jqjTTXQxwUHQ0PLfvWJm();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					AsyncActions = new List<Func<CancellationToken, Task>>();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				case 1:
					Actions = new List<Action>();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num = 2;
					}
					break;
				}
			}
		}

		public void SetRollBackFlag(string dbName, bool flag)
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
					ContextVars.Set(GetKey(dbName), flag);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private static string GetKey(object dbName)
		{
			return (string)WAPCZ6Qx6Vs287tC7hnS(g87IfAQx4NMUfqGpWM4D(-1411196499 ^ -1410903967), dbName);
		}

		public bool GetRollBackFlag(string dbName)
		{
			return ContextVars.GetOrAdd(GetKey(dbName), () => false);
		}

		internal static bool taGNUUQxDldvs1Ttog0D()
		{
			return jhW8ZGQxau4mWS8Lnve8 == null;
		}

		internal static UnitOfWorkContextRollbackHolder KGnedvQxtmKYbgUHNRRP()
		{
			return (UnitOfWorkContextRollbackHolder)jhW8ZGQxau4mWS8Lnve8;
		}

		internal static void jqjTTXQxwUHQ0PLfvWJm()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object g87IfAQx4NMUfqGpWM4D(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object WAPCZ6Qx6Vs287tC7hnS(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}
	}

	private class PreCommitActionsHolder
	{
		internal static object V4YlosQxHYg1loHKKsgW;

		public Queue<Action> Actions { get; private set; }

		public Queue<Func<CancellationToken, Task>> AsyncActions { get; private set; }

		public static PreCommitActionsHolder GetFromContext()
		{
			return ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7AB890), () => new PreCommitActionsHolder());
		}

		private PreCommitActionsHolder()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			CnthjqQxxil6vUYMPnZc();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					Actions = new Queue<Action>();
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num = 0;
					}
					break;
				case 2:
					AsyncActions = new Queue<Func<CancellationToken, Task>>();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				}
			}
		}

		internal static bool MdygMNQxAJuj2kJj9Nt0()
		{
			return V4YlosQxHYg1loHKKsgW == null;
		}

		internal static PreCommitActionsHolder CT0Up9Qx7gDTHCd8x8le()
		{
			return (PreCommitActionsHolder)V4YlosQxHYg1loHKKsgW;
		}

		internal static void CnthjqQxxil6vUYMPnZc()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private class PostCommitActionsHolder
	{
		internal static object Prly3ZQx0a3UHDsjWFY0;

		public List<Action> Actions { get; set; }

		public List<Func<CancellationToken, Task>> AsyncActions { get; private set; }

		public static PostCommitActionsHolder GetFromContext()
		{
			return ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92A99C9), () => new PostCommitActionsHolder());
		}

		private PostCommitActionsHolder()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ykdngdQxM20OuI7cs004();
			base._002Ector();
			int num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					AsyncActions = new List<Func<CancellationToken, Task>>();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				case 2:
					Actions = new List<Action>();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		internal static bool YXiLVaQxmmPXrbYZ39P7()
		{
			return Prly3ZQx0a3UHDsjWFY0 == null;
		}

		internal static PostCommitActionsHolder GCodcvQxyjOeqnojsmH7()
		{
			return (PostCommitActionsHolder)Prly3ZQx0a3UHDsjWFY0;
		}

		internal static void ykdngdQxM20OuI7cs004()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private readonly ISessionProvider sessionProvider;

	private readonly ITransformationProvider transformProvider;

	private readonly NestedScopeComponents<IUnitOfWorkEventListener> listeners;

	internal static NHUnitOfWorkManager mrVxG3W1GMgp29mlTopo;

	private static Queue<Func<CancellationToken, Task>> PreCommitAsyncActions => PreCommitActionsHolder.GetFromContext().AsyncActions;

	private static List<Func<CancellationToken, Task>> PostCommitAsyncActions => PostCommitActionsHolder.GetFromContext().AsyncActions;

	private static List<Func<CancellationToken, Task>> RollbackAsyncActions => UnitOfWorkContextRollbackHolder.GetFromContext().AsyncActions;

	private static UnitOfWorkContextRollbackHolder RollbackHolder => (UnitOfWorkContextRollbackHolder)hwMyufW1qlrGP9ptvB6H();

	private static Queue<Action> PreCommitActions => PreCommitActionsHolder.GetFromContext().Actions;

	private static List<Action> PostCommitActions => PostCommitActionsHolder.GetFromContext().Actions;

	private static List<Action> RollbackActions => UnitOfWorkContextRollbackHolder.GetFromContext().Actions;

	public IUnitOfWorkAsync CreateAsync(string dbName, bool transactional, IsolationLevel isolationLevel = IsolationLevel.Unspecified)
	{
		return new UnitOfWork(dbName, transactional, sessionProvider, transformProvider, listeners.Value, isolationLevel);
	}

	public void RegisterAsyncPreCommitAction(Func<CancellationToken, Task> action)
	{
		if (action != null)
		{
			PreCommitAsyncActions.LockEnqueue(action);
		}
	}

	public void RegisterAsyncPostCommitAction(Func<CancellationToken, Task> action)
	{
		if (action != null)
		{
			PostCommitAsyncActions.Add(action);
		}
	}

	public void RegisterAsyncRollbackAction(Func<CancellationToken, Task> action)
	{
		if (action != null)
		{
			RollbackAsyncActions.Add(action);
		}
	}

	[AsyncStateMachine(typeof(_003CThrowExceptionOnCommitAsync_003Ed__5))]
	public Task ThrowExceptionOnCommitAsync(Exception exception, CancellationToken cancellationToken = default(CancellationToken))
	{
		int num = 6;
		int num2 = num;
		_003CThrowExceptionOnCommitAsync_003Ed__5 stateMachine = default(_003CThrowExceptionOnCommitAsync_003Ed__5);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 7;
				}
				break;
			default:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 3;
				break;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 2;
				break;
			case 5:
				stateMachine.exception = exception;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				num2 = 5;
				break;
			case 7:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				break;
			}
		}
	}

	public NHUnitOfWorkManager(ISessionProvider sessionProvider, ITransformationProvider transformProvider)
	{
		//Discarded unreachable code: IL_003b, IL_0040
		SingletonReader.JJCZtPuTvSt();
		listeners = new NestedScopeComponents<IUnitOfWorkEventListener>(ServiceScope.Shell);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.sessionProvider = sessionProvider;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.transformProvider = transformProvider;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public IUnitOfWork Create(string dbName, bool transactional, IsolationLevel isolationLevel = IsolationLevel.Unspecified)
	{
		return new UnitOfWork(dbName, transactional, sessionProvider, transformProvider, listeners.Value, isolationLevel);
	}

	public bool HasActiveTransaction(string dbName)
	{
		return UnitOfWork.HasTransaction(dbName, sessionProvider);
	}

	public void RollbackCurrent(string dbName)
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
				yk6pqcW1CUrIYnxEqwLP(f2LBdxW1QdwGhK5yD4eF(), dbName, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void RegisterPreCommitAction(Action action)
	{
		//Discarded unreachable code: IL_0042, IL_0051
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 3:
				if (action == null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 1:
				break;
			}
			PreCommitActions.LockEnqueue(action);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
			{
				num2 = 0;
			}
		}
	}

	public void RegisterPostCommitAction(Action action)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				PostCommitActions.Add(action);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (action != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			}
		}
	}

	public void RegisterRollbackAction(Action action)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				RollbackActions.Add(action);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				if (action == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RevertEntityChangesOnCommit(string dbName, object entity)
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
			{
				object name = jN2KtHW1vaSy6PhGqXyM(dbName);
				List<object> orAdd = ContextVars.GetOrAdd((string)name, () => new List<object>());
				orAdd.Add(entity);
				ContextVars.Set((string)name, orAdd);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public void ThrowExceptionOnCommit(Exception exception)
	{
		//Discarded unreachable code: IL_00b7, IL_00ea, IL_013c, IL_014b, IL_015c, IL_0188, IL_01bb, IL_020c, IL_021b, IL_023b
		int num = 8;
		ISession val = default(ISession);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 7:
					if (val == null)
					{
						num2 = 2;
						continue;
					}
					obj = csRTLfW1ZV8Nl0aHleH8(val);
					goto IL_0282;
				case 3:
					if (V7Q3y2W1u6sAR4vbe06k(csRTLfW1ZV8Nl0aHleH8(val)))
					{
						num = 6;
						break;
					}
					goto default;
				case 8:
					val = (ISession)PiutqdW181hTStx8cWhp(sessionProvider, "");
					num2 = 7;
					continue;
				case 6:
					try
					{
						gwMBfoW1IdaKSA7M35rn(csRTLfW1ZV8Nl0aHleH8(val));
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex2)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								WXhB9cW1iNyWT9AsST8H(gZHi36W1VlOQyH23eXpY(), HULNmsW1S3yjvtweGIBa(-488881205 ^ -488751025), ex2);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 1;
				case 2:
					obj = null;
					goto IL_0282;
				case 9:
					try
					{
						((DbConnection)QJgZ6WW1Ryoxet53ASv3(val)).Close();
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								WXhB9cW1iNyWT9AsST8H(gZHi36W1VlOQyH23eXpY(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978605756), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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
					goto default;
				case 1:
					num = 9;
					break;
				case 4:
					return;
				default:
					{
						ContextVars.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583610596), exception);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 1;
						}
						continue;
					}
					IL_0282:
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	private static string GetRevertEntityChangesKey(object dbName)
	{
		return (string)Wj6LCLW1KNVCjS17j3v2(HULNmsW1S3yjvtweGIBa(0x66F566B6 ^ 0x66F776C6), dbName);
	}

	public static List<object> GetRevertEntities(string dbName)
	{
		_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass38_0();
		string revertEntityChangesKey = GetRevertEntityChangesKey(dbName);
		CS_0024_003C_003E8__locals0.revertEntities = ContextVars.GetOrAdd(revertEntityChangesKey, () => new List<object>());
		if (CS_0024_003C_003E8__locals0.revertEntities.Count == 0)
		{
			return CS_0024_003C_003E8__locals0.revertEntities;
		}
		Action action = delegate
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.revertEntities = CS_0024_003C_003E8__locals0.revertEntities.Union(from e in CS_0024_003C_003E8__locals0.revertEntities.SelectMany((object e) => (!(e is ICompositeEntity)) ? new object[0] : ((ICompositeEntity)e).GetCompositeEntities().Cast<object>())
						where e != null
						select _003C_003Ec.Bh0D1gQ0WuJLmRIQ2FBp(e)).ToList();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		};
		Action obj = delegate
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
					CS_0024_003C_003E8__locals0.revertEntities = CS_0024_003C_003E8__locals0.revertEntities.Union(from e in CS_0024_003C_003E8__locals0.revertEntities.OfType<IEntity>().SelectMany((IEntity e) => e.GetContainedEntities())
						where e != null
						select e.CastAsRealType()).ToList();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		};
		action();
		obj();
		action();
		return CS_0024_003C_003E8__locals0.revertEntities;
	}

	internal static bool PuURP4W1Ea7GuZllFI74()
	{
		return mrVxG3W1GMgp29mlTopo == null;
	}

	internal static NHUnitOfWorkManager UFCibBW1fHYuvwcboruH()
	{
		return mrVxG3W1GMgp29mlTopo;
	}

	internal static object f2LBdxW1QdwGhK5yD4eF()
	{
		return RollbackHolder;
	}

	internal static void yk6pqcW1CUrIYnxEqwLP(object P_0, object P_1, bool flag)
	{
		((UnitOfWorkContextRollbackHolder)P_0).SetRollBackFlag((string)P_1, flag);
	}

	internal static object jN2KtHW1vaSy6PhGqXyM(object P_0)
	{
		return GetRevertEntityChangesKey(P_0);
	}

	internal static object PiutqdW181hTStx8cWhp(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object csRTLfW1ZV8Nl0aHleH8(object P_0)
	{
		return ((ISession)P_0).get_Transaction();
	}

	internal static bool V7Q3y2W1u6sAR4vbe06k(object P_0)
	{
		return ((ITransaction)P_0).get_IsActive();
	}

	internal static void gwMBfoW1IdaKSA7M35rn(object P_0)
	{
		((ITransaction)P_0).Rollback();
	}

	internal static object gZHi36W1VlOQyH23eXpY()
	{
		return Logger.Log;
	}

	internal static object HULNmsW1S3yjvtweGIBa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void WXhB9cW1iNyWT9AsST8H(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Debug(P_1, (Exception)P_2);
	}

	internal static object QJgZ6WW1Ryoxet53ASv3(object P_0)
	{
		return ((ISession)P_0).get_Connection();
	}

	internal static object hwMyufW1qlrGP9ptvB6H()
	{
		return UnitOfWorkContextRollbackHolder.GetFromContext();
	}

	internal static object Wj6LCLW1KNVCjS17j3v2(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
