using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.FeatureFlags;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FeatureFlags.Services;

[Service]
internal sealed class FeatureFlagService : IFeatureFlagService
{
	[Component]
	private sealed class ActorInitHandler : IActorInitHandler
	{
		private readonly object featureFlagService;

		private static object xdXwPsv9Np6t2IJqsR4I;

		public ActorInitHandler(FeatureFlagService featureFlagService)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Vaeb3Lv9avqrYxrhis17();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					this.featureFlagService = featureFlagService;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public Task Init(IActorModelRuntime actorModelRuntime)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					((FeatureFlagService)featureFlagService).wasActorInitHandler = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (Task)pUEYNdv9DDdy5teKpPtU();
				}
			}
		}

		internal static void Vaeb3Lv9avqrYxrhis17()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool S9rKrYv93SXuCuoYTNEq()
		{
			return xdXwPsv9Np6t2IJqsR4I == null;
		}

		internal static ActorInitHandler Uvar5Hv9pNQILesFOZEE()
		{
			return (ActorInitHandler)xdXwPsv9Np6t2IJqsR4I;
		}

		internal static object pUEYNdv9DDdy5teKpPtU()
		{
			return Task.CompletedTask;
		}
	}

	[Component]
	private sealed class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
	{
		private readonly object featureFlagService;

		private readonly object actorModelRuntime;

		private readonly object runtimeApplication;

		private static object cuK9uhv9tbe1RdWt4rJ2;

		public ServerStatusEventHandler(FeatureFlagService featureFlagService, IActorModelRuntime actorModelRuntime, IRuntimeApplication runtimeApplication)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			YG5bVNv965y6KheWZpp5();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				default:
					this.runtimeApplication = runtimeApplication;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					this.featureFlagService = featureFlagService;
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num = 0;
					}
					break;
				case 3:
					this.actorModelRuntime = actorModelRuntime;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public void ServerStarted(Guid serverUid, Version serverVersion)
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
					((IActorModelRuntime)actorModelRuntime).GetActor<IFeatureFlagActor>(serverUid).UpdateCache(jxPbaWv9HHve3EUQmtgM(runtimeApplication), ((FeatureFlagService)featureFlagService).featureFlags);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void ServerStarting(Guid serverUid)
		{
		}

		public void ServerStoped(Guid serverUid)
		{
		}

		internal static void YG5bVNv965y6KheWZpp5()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool v2W7t6v9wlY5Ix0bTqO4()
		{
			return cuK9uhv9tbe1RdWt4rJ2 == null;
		}

		internal static ServerStatusEventHandler sbbVe5v94PC0ROUbZqQL()
		{
			return (ServerStatusEventHandler)cuK9uhv9tbe1RdWt4rJ2;
		}

		internal static Guid jxPbaWv9HHve3EUQmtgM(object P_0)
		{
			return ((IRuntimeApplication)P_0).ConnectionUid;
		}
	}

	private readonly ILogger logger;

	private readonly IEnumerable<IFeatureFlagProvider> featureFlagProviders;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly IDictionary<string, bool?> featureFlags;

	private readonly object processLockObject;

	private readonly ISet<string> needNewKeys;

	private ISet<string> processKeys;

	private bool wasActorInitHandler;

	private static FeatureFlagService FrnwkFGBzqesL6HRfPIe;

	public FeatureFlagService(IEnumerable<IFeatureFlagProvider> featureFlagProviders, IServerPlacementPublishService serverPlacementPublishService, IActorModelRuntime actorModelRuntime, IRuntimeApplication runtimeApplication)
	{
		SingletonReader.JJCZtPuTvSt();
		logger = Logger.GetLogger(typeof(FeatureFlagService));
		featureFlags = new Dictionary<string, bool?>();
		processLockObject = new object();
		needNewKeys = new HashSet<string>();
		base._002Ector();
		this.featureFlagProviders = featureFlagProviders;
		this.serverPlacementPublishService = serverPlacementPublishService;
		this.actorModelRuntime = actorModelRuntime;
		this.runtimeApplication = runtimeApplication;
		featureFlagProviders.ForEach(delegate(IFeatureFlagProvider p)
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
					MPyJ1yGWiE9UPqOiWbpK(p, new EventHandler(FlagsChanged));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	internal bool? Enabled(string name)
	{
		if (!featureFlags.TryGetValue(name, out var value))
		{
			RefreshFlags(name);
			return featureFlags[name];
		}
		return value;
	}

	public bool Enabled(string name, bool defaultEnabled)
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 3;
		int num2 = num;
		bool? flag = default(bool?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (flag.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				flag = Enabled(name);
				num2 = 2;
				break;
			case 1:
				return defaultEnabled;
			default:
				return flag.GetValueOrDefault();
			}
		}
	}

	private void FlagsChanged(object sender, EventArgs e)
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
				RefreshFlags(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void RefreshFlags(string newFlag)
	{
		//Discarded unreachable code: IL_0045, IL_0160, IL_016f, IL_01c0, IL_020a, IL_0265, IL_029d, IL_02ac, IL_0407, IL_0442, IL_0451, IL_0508, IL_074b, IL_0783, IL_07b1, IL_07e0, IL_07ef, IL_083a, IL_0849, IL_08ca, IL_0902, IL_0911, IL_0a10, IL_0a94, IL_0acc, IL_0b67, IL_0c3b, IL_0c7b, IL_0c86, IL_0cb9, IL_0cc8, IL_0cd8, IL_0ce7, IL_0d40, IL_0d82, IL_0d91
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (newFlag == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num = 0;
					}
					goto IL_0049;
				}
				goto IL_0139;
				IL_0139:
				IDictionary<string, bool?> dictionary = featureFlags;
				num = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 10;
				}
				goto IL_0049;
				IL_0049:
				object obj = default(object);
				bool lockTaken = default(bool);
				int? num2 = default(int?);
				int? num17 = default(int?);
				int num4 = default(int);
				bool lockTaken2 = default(bool);
				_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_2 = default(_003C_003Ec__DisplayClass14_0);
				_003C_003Ec__DisplayClass14_1 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_1);
				IEnumerator<IFeatureFlagProvider> enumerator = default(IEnumerator<IFeatureFlagProvider>);
				List<(string, bool)> list = default(List<(string, bool)>);
				bool flag = default(bool);
				IFeatureFlagProvider current = default(IFeatureFlagProvider);
				while (true)
				{
					int? num3;
					switch (num)
					{
					case 3:
					case 10:
						obj = processLockObject;
						num = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num = 3;
						}
						continue;
					case 13:
						lockTaken = false;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num = 1;
						}
						continue;
					default:
						if (TAbogBGWodWY9QKrPXgw(featureFlags) == 0)
						{
							num = 9;
							continue;
						}
						goto case 14;
					case 14:
					{
						ISet<string> set = processKeys;
						if (set == null)
						{
							num = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num = 3;
							}
							continue;
						}
						num3 = set.Count;
						goto IL_0d03;
					}
					case 11:
						num2 = null;
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num = 4;
						}
						continue;
					case 16:
						break;
					case 9:
						return;
					case 6:
						if (num17 != num4)
						{
							num = 10;
							continue;
						}
						return;
					case 1:
						try
						{
							Monitor.Enter(dictionary, ref lockTaken);
							int num15 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
							{
								num15 = 2;
							}
							while (true)
							{
								switch (num15)
								{
								case 3:
									needNewKeys.Add(newFlag);
									num15 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
									{
										num15 = 0;
									}
									continue;
								case 1:
									return;
								case 2:
									if (featureFlags.ContainsKey(newFlag))
									{
										num15 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
										{
											num15 = 1;
										}
										continue;
									}
									goto case 3;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							if (lockTaken)
							{
								int num16 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
								{
									num16 = 1;
								}
								while (true)
								{
									switch (num16)
									{
									case 1:
										ej24GyGWWhtoweBvJ1Vn(dictionary);
										num16 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
										{
											num16 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 3;
					case 5:
						try
						{
							Monitor.Enter(obj, ref lockTaken);
							int num5 = 27;
							while (true)
							{
								int num11;
								switch (num5)
								{
								case 12:
									lockTaken2 = false;
									num5 = 9;
									break;
								case 16:
									if (!(wasActorInitHandler & _003C_003Ec__DisplayClass14_2.needActorReinit))
									{
										num5 = 10;
										break;
									}
									goto case 28;
								case 4:
									dictionary = featureFlags;
									num5 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
									{
										num5 = 12;
									}
									break;
								default:
									_003C_003Ec__DisplayClass14_2.newFeatureFlags = new Dictionary<string, bool?>();
									num5 = 15;
									break;
								case 24:
									if (MglI6NGWvQq5LxEmU9uJ(processKeys) > IR8T9RGW87rssCe2xAsY(_003C_003Ec__DisplayClass14_2.newFeatureFlags))
									{
										num5 = 3;
										break;
									}
									goto case 19;
								case 20:
									if (!_003C_003Ec__DisplayClass14_.needLog)
									{
										num5 = 14;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
										{
											num5 = 21;
										}
										break;
									}
									goto case 22;
								case 10:
									return;
								case 18:
									lg6cPHGWutqdM0phRFlc(logger, _003C_003Ec__DisplayClass14_2.message);
									num5 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
									{
										num5 = 26;
									}
									break;
								case 23:
									serverPlacementPublishService.Publish<IFeatureFlagActor>(_003C_003Ec__DisplayClass14_2._003CRefreshFlags_003Eb__0, ignoreError: true, null);
									num5 = 16;
									break;
								case 28:
									GBUogCGWVmpfPnkWHBRF(((ComponentManager)V3GTlRGWI2bJU8ykpGgc()).GetExtensionPoints<IActorInitHandler>().Select(delegate(IActorInitHandler h)
									{
										int num19 = 4;
										int num20 = num19;
										_003C_003CRefreshFlags_003Eb__14_1_003Ed stateMachine = default(_003C_003CRefreshFlags_003Eb__14_1_003Ed);
										AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
										while (true)
										{
											switch (num20)
											{
											case 4:
												stateMachine._003C_003E4__this = this;
												num20 = 3;
												break;
											default:
												_003C_003Et__builder = stateMachine._003C_003Et__builder;
												num20 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
												{
													num20 = 1;
												}
												break;
											case 1:
												_003C_003Et__builder.Start(ref stateMachine);
												num20 = 6;
												break;
											case 6:
												return stateMachine._003C_003Et__builder.Task;
											case 5:
												stateMachine._003C_003Et__builder = JxEmHfGWRQPYkye7o18Y();
												num20 = 2;
												break;
											case 2:
												stateMachine._003C_003E1__state = -1;
												num20 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
												{
													num20 = 0;
												}
												break;
											case 3:
												stateMachine.h = h;
												num20 = 5;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
												{
													num20 = 0;
												}
												break;
											}
										}
									}).ToArray());
									num5 = 7;
									break;
								case 22:
									fVImIIGWC3q1kfVbMqpw(KqOPj2GWfP2pZX7B0MVU(_003C_003Ec__DisplayClass14_.CS_0024_003C_003E8__locals1.message), sNu74NGWGwEi0m6amDUJ(-882126494 ^ -882350154));
									num5 = 5;
									break;
								case 3:
									_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_1();
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
									{
										num5 = 2;
									}
									break;
								case 14:
									try
									{
										while (true)
										{
											int num6;
											if (!enumerator.MoveNext())
											{
												num6 = 3;
												goto IL_051a;
											}
											goto IL_0596;
											IL_051a:
											while (true)
											{
												switch (num6)
												{
												case 6:
													if (IG9f9iGWEJtnQCTaEOFc(list) > 0)
													{
														num6 = 8;
														continue;
													}
													break;
												case 1:
													break;
												case 9:
													flag = true;
													num6 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
													{
														num6 = 5;
													}
													continue;
												case 7:
													goto IL_0596;
												case 8:
													if (_003C_003Ec__DisplayClass14_2.message != null)
													{
														int num7 = 4;
														num6 = num7;
														continue;
													}
													goto case 5;
												case 4:
													fVImIIGWC3q1kfVbMqpw(fVImIIGWC3q1kfVbMqpw(((StringBuilder)KqOPj2GWfP2pZX7B0MVU(_003C_003Ec__DisplayClass14_2.message)).Append((string)sNu74NGWGwEi0m6amDUJ(0x66F566B6 ^ 0x66F61438)), OqOoxnGWQm9lmOYLNBxb(current.GetType())), sNu74NGWGwEi0m6amDUJ(0x637E299B ^ 0x637F78D9));
													num6 = 2;
													continue;
												default:
													list = current.GetFlags(processKeys.Except(_003C_003Ec__DisplayClass14_2.newFeatureFlags.Keys)).Where(_003C_003Ec__DisplayClass14_2._003CRefreshFlags_003Eb__2).ToList();
													num6 = 6;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
													{
														num6 = 0;
													}
													continue;
												case 2:
													list.ForEach(_003C_003Ec__DisplayClass14_2._003CRefreshFlags_003Eb__3);
													num6 = 9;
													continue;
												case 5:
													list.ForEach(_003C_003Ec__DisplayClass14_2._003CRefreshFlags_003Eb__4);
													num6 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
													{
														num6 = 1;
													}
													continue;
												case 3:
													goto end_IL_0563;
												}
												break;
											}
											continue;
											IL_0596:
											current = enumerator.Current;
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
											{
												num6 = 0;
											}
											goto IL_051a;
											continue;
											end_IL_0563:
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											int num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
											{
												num8 = 0;
											}
											while (true)
											{
												switch (num8)
												{
												default:
													enumerator.Dispose();
													num8 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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
									goto case 24;
								case 1:
									try
									{
										Monitor.Enter(dictionary, ref lockTaken2);
										int num9 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
										{
											num9 = 5;
										}
										while (true)
										{
											switch (num9)
											{
											case 2:
												return;
											case 5:
												if (newFlag == null)
												{
													num9 = 3;
													continue;
												}
												goto case 1;
											default:
												processKeys = featureFlags.Keys.Union(needNewKeys).ToHashSet();
												num9 = 4;
												continue;
											case 1:
												if (!needNewKeys.Contains(newFlag))
												{
													num9 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
													{
														num9 = 2;
													}
													continue;
												}
												goto default;
											case 4:
												hpZcqmGWbtcONBn6pBVa(needNewKeys);
												num9 = 6;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
												{
													num9 = 0;
												}
												continue;
											case 6:
												break;
											}
											break;
										}
									}
									finally
									{
										if (lockTaken2)
										{
											int num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
											{
												num10 = 1;
											}
											while (true)
											{
												switch (num10)
												{
												case 1:
													ej24GyGWWhtoweBvJ1Vn(dictionary);
													num10 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
													{
														num10 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									goto default;
								case 17:
									lockTaken2 = false;
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num5 = 1;
									}
									break;
								case 2:
									_003C_003Ec__DisplayClass14_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass14_2;
									num5 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
									{
										num5 = 30;
									}
									break;
								case 29:
									dictionary = featureFlags;
									num5 = 17;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
									{
										num5 = 0;
									}
									break;
								case 8:
								case 21:
									processKeys.Except(_003C_003Ec__DisplayClass14_.CS_0024_003C_003E8__locals1.newFeatureFlags.Keys).ToArray().ForEach(_003C_003Ec__DisplayClass14_._003CRefreshFlags_003Eb__5);
									num5 = 19;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
									{
										num5 = 2;
									}
									break;
								case 19:
									if (!flag)
									{
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
										{
											num5 = 6;
										}
										break;
									}
									goto case 18;
								case 9:
									try
									{
										Monitor.Enter(dictionary, ref lockTaken2);
										int num12 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
										{
											num12 = 1;
										}
										while (true)
										{
											switch (num12)
											{
											default:
												processKeys = null;
												num12 = 2;
												continue;
											case 1:
												_003C_003Ec__DisplayClass14_2.newFeatureFlags.ForEach(_003C_003Ec__DisplayClass14_2._003CRefreshFlags_003Eb__6);
												num12 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
												{
													num12 = 0;
												}
												continue;
											case 2:
												break;
											}
											break;
										}
									}
									finally
									{
										if (lockTaken2)
										{
											int num13 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
											{
												num13 = 0;
											}
											while (true)
											{
												switch (num13)
												{
												case 1:
													Monitor.Exit(dictionary);
													num13 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
													{
														num13 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									goto case 23;
								case 27:
									_003C_003Ec__DisplayClass14_2 = new _003C_003Ec__DisplayClass14_0();
									num5 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
									{
										num5 = 11;
									}
									break;
								case 25:
									flag = false;
									num5 = 13;
									break;
								case 5:
									flag = true;
									num5 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
									{
										num5 = 8;
									}
									break;
								case 6:
								case 26:
									_003C_003Ec__DisplayClass14_2.needActorReinit = false;
									num11 = 4;
									goto IL_02ca;
								case 13:
									enumerator = featureFlagProviders.GetEnumerator();
									num5 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
									{
										num5 = 14;
									}
									break;
								case 11:
									_003C_003Ec__DisplayClass14_2._003C_003E4__this = this;
									num5 = 18;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
									{
										num5 = 29;
									}
									break;
								case 15:
									_003C_003Ec__DisplayClass14_2.message = (seceCNGWh0j4XN3yckTE(logger) ? new StringBuilder((string)sNu74NGWGwEi0m6amDUJ(-234299632 ^ -234133082)) : null);
									num11 = 25;
									goto IL_02ca;
								case 30:
									_003C_003Ec__DisplayClass14_.needLog = _003C_003Ec__DisplayClass14_.CS_0024_003C_003E8__locals1.message != null && gKpTN3GWZoyi01fj0WxG(logger);
									num5 = 20;
									break;
								case 7:
									return;
									IL_02ca:
									num5 = num11;
									break;
								}
							}
						}
						finally
						{
							int num14;
							if (!lockTaken)
							{
								num14 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num14 = 1;
								}
								goto IL_0c3f;
							}
							goto IL_0c55;
							IL_0c55:
							Monitor.Exit(obj);
							num14 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num14 = 0;
							}
							goto IL_0c3f;
							IL_0c3f:
							switch (num14)
							{
							default:
								goto end_IL_0c1a;
							case 2:
								break;
							case 1:
								goto end_IL_0c1a;
							case 0:
								goto end_IL_0c1a;
							}
							goto IL_0c55;
							end_IL_0c1a:;
						}
					case 8:
						num4 = TAbogBGWodWY9QKrPXgw(featureFlags);
						num = 6;
						continue;
					case 12:
						lockTaken = false;
						num = 5;
						continue;
					case 2:
						return;
					case 4:
						num3 = num2;
						goto IL_0d03;
					case 15:
						return;
						IL_0d03:
						num17 = num3;
						num = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num = 2;
						}
						continue;
					}
					break;
				}
				goto IL_0139;
			}
			catch (Exception ex)
			{
				int num18 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num18 = 1;
				}
				while (true)
				{
					switch (num18)
					{
					default:
						return;
					case 1:
						hcxKHIGWSbnrf1IAllNE(logger, ex);
						num18 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num18 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		case 0:
			break;
		}
	}

	internal static bool Sj8Fn1GWFiDdsJRgTFv7()
	{
		return FrnwkFGBzqesL6HRfPIe == null;
	}

	internal static FeatureFlagService q2i9FCGWBaD58Wodt3bX()
	{
		return FrnwkFGBzqesL6HRfPIe;
	}

	internal static void ej24GyGWWhtoweBvJ1Vn(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static int TAbogBGWodWY9QKrPXgw(object P_0)
	{
		return ((ICollection<KeyValuePair<string, bool?>>)P_0).Count;
	}

	internal static void hpZcqmGWbtcONBn6pBVa(object P_0)
	{
		((ICollection<string>)P_0).Clear();
	}

	internal static bool seceCNGWh0j4XN3yckTE(object P_0)
	{
		return ((ILogger)P_0).IsInfoEnabled();
	}

	internal static object sNu74NGWGwEi0m6amDUJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int IG9f9iGWEJtnQCTaEOFc(object P_0)
	{
		return ((List<(string, bool)>)P_0).Count;
	}

	internal static object KqOPj2GWfP2pZX7B0MVU(object P_0)
	{
		return ((StringBuilder)P_0).AppendLine();
	}

	internal static object OqOoxnGWQm9lmOYLNBxb(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object fVImIIGWC3q1kfVbMqpw(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static int MglI6NGWvQq5LxEmU9uJ(object P_0)
	{
		return ((ICollection<string>)P_0).Count;
	}

	internal static int IR8T9RGW87rssCe2xAsY(object P_0)
	{
		return ((Dictionary<string, bool?>)P_0).Count;
	}

	internal static bool gKpTN3GWZoyi01fj0WxG(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static void lg6cPHGWutqdM0phRFlc(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object V3GTlRGWI2bJU8ykpGgc()
	{
		return ComponentManager.Current;
	}

	internal static void GBUogCGWVmpfPnkWHBRF(object P_0)
	{
		Task.WaitAll((Task[])P_0);
	}

	internal static void hcxKHIGWSbnrf1IAllNE(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static void MPyJ1yGWiE9UPqOiWbpK(object P_0, object P_1)
	{
		((IFeatureFlagProvider)P_0).FlagsChanged += (EventHandler)P_1;
	}

	internal static AsyncTaskMethodBuilder JxEmHfGWRQPYkye7o18Y()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
