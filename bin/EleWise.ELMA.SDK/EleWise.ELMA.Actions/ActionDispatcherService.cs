using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions;

[Service(EnableInterceptors = false)]
public sealed class ActionDispatcherService
{
	private class Invokers
	{
		private readonly object invokers;

		private static object jxX3RPZEHQk6IitHrsvr;

		public IActionInvoker this[bool async]
		{
			get
			{
				return (IActionInvoker)((object[])invokers)[(!async) ? 1 : 0];
			}
			set
			{
				int num = 4;
				int num2 = num;
				IActionInvoker actionInvoker = default(IActionInvoker);
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					case 3:
						if (actionInvoker != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					default:
						if (actionInvoker != value)
						{
							num2 = 2;
							continue;
						}
						break;
					case 4:
						actionInvoker = (IActionInvoker)((object[])invokers)[(!async) ? 1 : 0];
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 3;
						}
						continue;
					case 2:
						throw new ArgumentException();
					}
					((object[])invokers)[(!async) ? 1 : 0] = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
				}
			}
		}

		public Invokers()
		{
			//Discarded unreachable code: IL_003b, IL_0040
			SingletonReader.JJCZtPuTvSt();
			invokers = new IActionInvoker[2];
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool sHE1LZZEAotSp3BojNVS()
		{
			return jxX3RPZEHQk6IitHrsvr == null;
		}

		internal static Invokers s8JSa7ZE7JKBkJeZxmUL()
		{
			return (Invokers)jxX3RPZEHQk6IitHrsvr;
		}
	}

	[Component(Order = -100)]
	private class MetadataPublishFinishedEventHandler : IMetadataPublishFinishedEventHandler, IEventHandler
	{
		private readonly object actionDispatcherService;

		internal static object wdyNcYZExdY0KSuu9Vbx;

		public MetadataPublishFinishedEventHandler(ActionDispatcherService actionDispatcherService)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				this.actionDispatcherService = actionDispatcherService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num = 0;
				}
			}
		}

		public void PublishExecuted(MetadataPublishedEventArgs e)
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
					e.DeltaPublishedMetadata.OfType<EntityMetadata>().SelectMany((EntityMetadata m) => new Guid[2] { m.Uid, m.ImplementationUid }).ForEach(delegate(Guid u)
					{
						int num3 = 3;
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
							case 2:
								((ActionDispatcherService)actionDispatcherService).actionTypeObjectMap.Remove(u);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
								{
									num4 = 0;
								}
								break;
							case 3:
							{
								ISet<Guid> toInitialize = ((ActionDispatcherService)actionDispatcherService).toInitialize;
								if (toInitialize == null)
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
									{
										num4 = 2;
									}
								}
								else
								{
									toInitialize.Add(u);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
									{
										num4 = 1;
									}
								}
								break;
							}
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool pdyHfgZE0jYooeEgpZow()
		{
			return wdyNcYZExdY0KSuu9Vbx == null;
		}

		internal static MetadataPublishFinishedEventHandler CTL2XrZEmsVEmGSBTEMu()
		{
			return (MetadataPublishFinishedEventHandler)wdyNcYZExdY0KSuu9Vbx;
		}
	}

	private readonly IEnumerable<IActionInvokerProvider> actionProviders;

	private readonly IDictionary<Guid, IDictionary<Guid, Invokers>> actionTypeObjectMap;

	private ISet<Guid> toInitialize;

	internal static ActionDispatcherService pRjBRaftfOWJlp0PqDCY;

	public ActionDispatcherService(IEnumerable<IActionInvokerProvider> actionProviders)
	{
		SingletonReader.JJCZtPuTvSt();
		actionTypeObjectMap = PublishCacheContext.CreateCache<Guid, IDictionary<Guid, Invokers>>();
		base._002Ector();
		Contract.ArgumentNotNull(actionProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548EF696));
		this.actionProviders = actionProviders;
	}

	private void Initialize()
	{
		//Discarded unreachable code: IL_009a, IL_00a9, IL_0150, IL_01f9, IL_020c, IL_028b, IL_02f4, IL_0303, IL_039e, IL_03de, IL_03ed, IL_03f9
		int num = 2;
		int num2 = num;
		ActionDispatcherService actionDispatcherService = default(ActionDispatcherService);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 4:
				return;
			case 1:
				actionDispatcherService = this;
				num2 = 3;
				continue;
			case 3:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
			{
				ISet<Guid> set = toInitialize;
				if (set == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (VEyJVxftv1BdqcPWA24n(set) == 0)
				{
					num2 = 4;
					continue;
				}
				goto case 1;
			}
			}
			try
			{
				Monitor.Enter(actionDispatcherService, ref lockTaken);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
					case 4:
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num3 = 0;
						}
						break;
					case 1:
						return;
					default:
					{
						ISet<Guid> set2 = toInitialize;
						if (set2 == null)
						{
							int num6 = 2;
							num3 = num6;
							break;
						}
						if (set2.Count == 0)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 1;
							}
							break;
						}
						goto case 2;
					}
					case 3:
						try
						{
							IEnumerable<IActionInvoker> enumerable = actionProviders.SelectMany((IActionInvokerProvider p) => p.GetInvokers());
							int num4 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									cRe7p9ft8xesBPIEwTjg(toInitialize);
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
									{
										num4 = 0;
									}
									break;
								case 6:
									toInitialize = PublishCacheContext.CreateCache<Guid>();
									num4 = 5;
									break;
								case 1:
									InitializeInvokers(enumerable);
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num4 = 0;
									}
									break;
								case 8:
									if (toInitialize != null)
									{
										num4 = 7;
										break;
									}
									goto case 1;
								case 5:
									return;
								case 7:
									enumerable = enumerable.Where((IActionInvoker i) => toInitialize.Contains(i.ActionObject.Uid));
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
									{
										num4 = 1;
									}
									break;
								case 4:
									if (toInitialize != null)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
										{
											num4 = 0;
										}
										break;
									}
									goto case 6;
								case 3:
									return;
								}
							}
						}
						catch (Exception ex)
						{
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									return;
								case 2:
									jjCgHEftIIBEmg7IsY8L(actionTypeObjectMap);
									num5 = 5;
									break;
								case 4:
									cRe7p9ft8xesBPIEwTjg(toInitialize);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
									{
										num5 = 0;
									}
									break;
								case 1:
									KfYVnlftu8YtLPDLkZqm(UhMM1uftZhXuQe5lRoif(), ex);
									num5 = 2;
									break;
								case 5:
									if (toInitialize != null)
									{
										num5 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
										{
											num5 = 2;
										}
										break;
									}
									goto case 6;
								case 6:
									throw;
								case 3:
									InitializeInvokers(actionProviders.SelectMany((IActionInvokerProvider p) => p.GetInvokers()));
									num5 = 4;
									break;
								case 0:
									return;
								}
							}
						}
					}
				}
			}
			finally
			{
				int num7;
				if (!lockTaken)
				{
					num7 = 2;
					goto IL_03a2;
				}
				goto IL_03b8;
				IL_03a2:
				switch (num7)
				{
				case 2:
					goto end_IL_038d;
				case 1:
					goto end_IL_038d;
				}
				goto IL_03b8;
				IL_03b8:
				xtYtBnftVuIaBYLKcvWB(actionDispatcherService);
				num7 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num7 = 0;
				}
				goto IL_03a2;
				end_IL_038d:;
			}
		}
	}

	private void InitializeInvokers(IEnumerable<IActionInvoker> invokers)
	{
		foreach (IActionInvoker invoker in invokers)
		{
			IDictionary<Guid, Invokers> orAdd = actionTypeObjectMap.GetOrAdd(invoker.ActionObject.Uid, (Guid _) => new Dictionary<Guid, Invokers>());
			if (!orAdd.TryGetValue(invoker.ActionType.Uid, out var value))
			{
				orAdd.Add(invoker.ActionType.Uid, value = new Invokers());
			}
			try
			{
				value[invoker.MethodMetadata.ResultArgument.ArgumentType.IsAsync()] = invoker;
			}
			catch (ArgumentException)
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643448377), invoker.ActionType.DisplayName, invoker.ActionObject.DisplayName));
			}
		}
	}

	private IActionInvoker GetInvoker(Guid actionUid, Guid objectUid, bool isAsync)
	{
		//Discarded unreachable code: IL_009a, IL_00a9, IL_00b8
		int num = 4;
		int num2 = num;
		Invokers value2 = default(Invokers);
		IDictionary<Guid, Invokers> value = default(IDictionary<Guid, Invokers>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				Initialize();
				num2 = 3;
				break;
			case 5:
				return (IActionInvoker)fFZ35HftSEWmmAivrpbG(value2, isAsync);
			default:
				return null;
			case 1:
				if (!value.TryGetValue(actionUid, out value2))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 3:
				if (!actionTypeObjectMap.TryGetValue(objectUid, out value))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	private ActionInvokeEventArgs GetEventArgs(IAuditAction actionType, IAuditObject actionObject, params object[] methodArgs)
	{
		ActionInvokeEventArgs actionInvokeEventArgs = new ActionInvokeEventArgs();
		VYjIOiftiHq0pBmLsrp2(actionInvokeEventArgs, actionType);
		actionInvokeEventArgs.Object = actionObject;
		actionInvokeEventArgs.Params = methodArgs.ToList();
		return actionInvokeEventArgs;
	}

	internal static string GetKey([NotNull] MethodInfo methodInfo, params object[] methodArgs)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (TwFHLIftRfXmabp2LuNH(methodInfo, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)MYtXYJftXnRu8pVjQoXW(UHVfyeftquEvXN29hEc9(-2099751081 ^ -2099441789), methodInfo.DeclaringType.FullName, methodInfo.Name, ((IEnumerable<ParameterInfo>)iPDlZNftKWyaKJ8IHirM(methodInfo)).Select((ParameterInfo p) => _003C_003Ec.bMbtnIZEdLgMe5eE7gMQ(p).FullName).ToSeparatedString((string)UHVfyeftquEvXN29hEc9(-675505729 ^ -675506755)));
			default:
				throw new ArgumentNullException((string)UHVfyeftquEvXN29hEc9(0x7C1EE318 ^ 0x7C1BBBA4));
			}
		}
	}

	public ActionCheckResult CheckAction(IAuditObject actionObject, IAuditAction actionType, params object[] methodArgs)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				IActionInvoker invoker = GetInvoker(sgm1aCftkampsG6LbnmT(actionType), actionObject.Uid, isAsync: false);
				if (invoker == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 2;
					}
					break;
				}
				return waFw9jftOW5bRMpLdNrF(invoker, GetEventArgs(actionType, actionObject, methodArgs));
			}
			default:
				A8mnekftTxL2dLh2gqEv(actionType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72425B86));
				num2 = 3;
				break;
			case 1:
				A8mnekftTxL2dLh2gqEv(actionObject, UHVfyeftquEvXN29hEc9(0x8317432 ^ 0x8342CC2));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return KN2CxfftnJtVLqZj1hBN(UHVfyeftquEvXN29hEc9(-1822890472 ^ -1822572740));
			}
		}
	}

	[AsyncStateMachine(typeof(_003CCheckActionAsync_003Ed__10))]
	public Task<ActionCheckResult> CheckActionAsync(IAuditObject actionObject, IAuditAction actionType, CancellationToken cancellationToken, params object[] methodArgs)
	{
		_003CCheckActionAsync_003Ed__10 stateMachine = default(_003CCheckActionAsync_003Ed__10);
		stateMachine._003C_003E4__this = this;
		stateMachine.actionObject = actionObject;
		stateMachine.actionType = actionType;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine.methodArgs = methodArgs;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ActionCheckResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ActionCheckResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public object InvokeAction([NotNull] IAuditObject actionObject, [NotNull] IAuditAction actionType, params object[] methodArgs)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_0117
		int num = 4;
		int num2 = num;
		ActionCheckResult actionCheckResult = default(ActionCheckResult);
		IActionInvoker invoker = default(IActionInvoker);
		string argsString = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (J3Lchjft25tp1Knc9cyZ(actionCheckResult = CheckAction(actionObject, actionType, methodArgs)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 3:
				Contract.ArgumentNotNull(actionType, (string)UHVfyeftquEvXN29hEc9(-1088304168 ^ -1088122156));
				num2 = 5;
				break;
			case 8:
				throw new InvalidOperationException(SR.T((string)UHVfyeftquEvXN29hEc9(0x10E41EDB ^ 0x10E14791), actionType.DisplayName, actionObject.DisplayName, methodArgs.ToSeparatedString((string)UHVfyeftquEvXN29hEc9(-138018305 ^ -138067035))));
			default:
				return rntRQWftNUAJn8KCstGG(invoker, GetEventArgs(actionType, actionObject, methodArgs));
			case 4:
				A8mnekftTxL2dLh2gqEv(actionObject, UHVfyeftquEvXN29hEc9(-138018305 ^ -138192625));
				num2 = 3;
				break;
			case 2:
				if (invoker != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 7:
				argsString = string.Join((string)UHVfyeftquEvXN29hEc9(-1411196499 ^ -1411216015), methodArgs.Select(delegate(object a)
				{
					//Discarded unreachable code: IL_004d, IL_005c
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							if (a != null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 2;
						case 2:
							return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837666659);
						default:
							return a.ToString();
						}
					}
				}));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				throw new ElmaInvalidOperationException((string)zqM7dDfteoFKkCFPnbSo(actionType), (string)lANNsXftP4fYOrkaBCWl(actionObject), argsString, actionCheckResult.ErrorMessage.IsNullOrWhiteSpace() ? null : new Exception(actionCheckResult.ErrorMessage));
			case 1:
				invoker = GetInvoker(actionType.Uid, Dw48v8ft1RIoQdndMFkx(actionObject), isAsync: false);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CInvokeActionAsync_003Ed__12))]
	public Task<object> InvokeActionAsync(IAuditObject actionObject, IAuditAction actionType, CancellationToken cancellationToken, params object[] methodArgs)
	{
		_003CInvokeActionAsync_003Ed__12 stateMachine = default(_003CInvokeActionAsync_003Ed__12);
		stateMachine._003C_003E4__this = this;
		stateMachine.actionObject = actionObject;
		stateMachine.actionType = actionType;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine.methodArgs = methodArgs;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static int VEyJVxftv1BdqcPWA24n(object P_0)
	{
		return ((ICollection<Guid>)P_0).Count;
	}

	internal static void cRe7p9ft8xesBPIEwTjg(object P_0)
	{
		((ICollection<Guid>)P_0).Clear();
	}

	internal static object UhMM1uftZhXuQe5lRoif()
	{
		return Logger.Log;
	}

	internal static void KfYVnlftu8YtLPDLkZqm(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static void jjCgHEftIIBEmg7IsY8L(object P_0)
	{
		((ICollection<KeyValuePair<Guid, IDictionary<Guid, Invokers>>>)P_0).Clear();
	}

	internal static void xtYtBnftVuIaBYLKcvWB(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool kWFYFJftQOIdp1l8ycNt()
	{
		return pRjBRaftfOWJlp0PqDCY == null;
	}

	internal static ActionDispatcherService WF8vE7ftCnnTaVWLgdp5()
	{
		return pRjBRaftfOWJlp0PqDCY;
	}

	internal static object fFZ35HftSEWmmAivrpbG(object P_0, bool async)
	{
		return ((Invokers)P_0)[async];
	}

	internal static void VYjIOiftiHq0pBmLsrp2(object P_0, object P_1)
	{
		((AuditEventArgs)P_0).Action = (IAuditAction)P_1;
	}

	internal static bool TwFHLIftRfXmabp2LuNH(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object UHVfyeftquEvXN29hEc9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object iPDlZNftKWyaKJ8IHirM(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object MYtXYJftXnRu8pVjQoXW(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void A8mnekftTxL2dLh2gqEv(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Guid sgm1aCftkampsG6LbnmT(object P_0)
	{
		return ((IAuditAction)P_0).Uid;
	}

	internal static ActionCheckResult KN2CxfftnJtVLqZj1hBN(object P_0)
	{
		return ActionCheckResult.False((string)P_0);
	}

	internal static ActionCheckResult waFw9jftOW5bRMpLdNrF(object P_0, object P_1)
	{
		return ((IActionInvoker)P_0).CheckAction((ActionInvokeEventArgs)P_1);
	}

	internal static bool J3Lchjft25tp1Knc9cyZ(ActionCheckResult actionCheckResult)
	{
		return actionCheckResult;
	}

	internal static object zqM7dDfteoFKkCFPnbSo(object P_0)
	{
		return ((IAuditAction)P_0).DisplayName;
	}

	internal static object lANNsXftP4fYOrkaBCWl(object P_0)
	{
		return ((IAuditObject)P_0).DisplayName;
	}

	internal static Guid Dw48v8ft1RIoQdndMFkx(object P_0)
	{
		return ((IAuditObject)P_0).Uid;
	}

	internal static object rntRQWftNUAJn8KCstGG(object P_0, object P_1)
	{
		return ((IActionInvoker)P_0).InvokeAction((ActionInvokeEventArgs)P_1);
	}
}
