using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Actors;

internal sealed class FunctionMetadataPublishingActor : Actor, IFunctionMetadataPublishingActor, IActorWithGuidKey, IActor
{
	private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;

	private readonly ISearchMetadataService searchMetadataService;

	private readonly IDependencyService dependencyService;

	private readonly IFunctionAssemblyBuilderService functionAssemblyBuilderService;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly ILockManager lockManager;

	private readonly IAuthenticationService authenticationService;

	private readonly IFunctionMetadataItemManager functionMetadataItemManager;

	private readonly ISessionProvider sessionProvider;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly ISearchFormServiceInternal searchFormService;

	private readonly ILogger logger;

	private bool publicationStarted;

	private static FunctionMetadataPublishingActor bDQEaybYOa5wILbYkESP;

	public override TimeSpan LifeTime { get; }

	public FunctionMetadataPublishingActor(ILoggerFactory loggerFactory, IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager, ISearchMetadataService searchMetadataService, IDependencyService dependencyService, IFunctionAssemblyBuilderService functionAssemblyBuilderService, IUnitOfWorkManager unitOfWorkManager, ILockManager lockManager, IAuthenticationService authenticationService, IFunctionMetadataItemManager functionMetadataItemManager, ISessionProvider sessionProvider, IServerPlacementPublishService serverPlacementPublishService, ISearchFormServiceInternal searchFormService)
	{
		//Discarded unreachable code: IL_0033
		VUg6XAbYPVfMlwcgcKQH();
		LifeTime = LTpgaebY1H0YybQA7PWa(1.0);
		base._002Ector();
		int num = 7;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
				this.dependencyService = dependencyService;
				num = 2;
				break;
			case 10:
				return;
			case 7:
				this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num = 5;
				}
				break;
			case 5:
				this.searchMetadataService = searchMetadataService;
				num2 = 4;
				goto IL_0038;
			default:
				this.authenticationService = authenticationService;
				num = 9;
				break;
			case 2:
				this.functionAssemblyBuilderService = functionAssemblyBuilderService;
				num2 = 8;
				goto IL_0038;
			case 9:
				this.functionMetadataItemManager = functionMetadataItemManager;
				num = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 9;
				}
				break;
			case 8:
				this.unitOfWorkManager = unitOfWorkManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num = 1;
				}
				break;
			case 12:
				this.sessionProvider = sessionProvider;
				num = 6;
				break;
			case 3:
				this.searchFormService = searchFormService;
				num = 11;
				break;
			case 6:
				this.serverPlacementPublishService = serverPlacementPublishService;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num = 3;
				}
				break;
			case 1:
				this.lockManager = lockManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 0;
				}
				break;
			case 11:
				{
					logger = (ILogger)MKqm8PbY3t9L9dj6p2Dm(loggerFactory, g5ymyhbYNKQosjA6WlXa(typeof(FunctionMetadataPublishingActor).TypeHandle));
					num = 10;
					break;
				}
				IL_0038:
				num = num2;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CReceiveReminder_003Ed__20))]
	public override Task ReceiveReminder(string reminderName)
	{
		int num = 5;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CReceiveReminder_003Ed__20 stateMachine = default(_003CReceiveReminder_003Ed__20);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					stateMachine.reminderName = reminderName;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					stateMachine._003C_003E1__state = -1;
					num2 = 2;
					continue;
				case 5:
					break;
				default:
					return stateMachine._003C_003Et__builder.Task;
				case 1:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					num2 = 6;
					continue;
				case 2:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 3;
					continue;
				}
				break;
			}
			stateMachine._003C_003E4__this = this;
			num = 4;
		}
	}

	[AsyncStateMachine(typeof(_003CPublish_003Ed__21))]
	public Task Publish(string comment)
	{
		int num = 3;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CPublish_003Ed__21 stateMachine = default(_003CPublish_003Ed__21);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					stateMachine._003C_003Et__builder = cX2Ek0bYpajA2ZsHkJ4W();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					stateMachine._003C_003E4__this = this;
					num2 = 2;
					continue;
				case 1:
					return stateMachine._003C_003Et__builder.Task;
				case 2:
					stateMachine.comment = comment;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			stateMachine._003C_003E1__state = -1;
			num = 4;
		}
	}

	[AsyncStateMachine(typeof(_003CPublishComplete_003Ed__22))]
	public Task PublishComplete()
	{
		int num = 4;
		int num2 = num;
		_003CPublishComplete_003Ed__22 stateMachine = default(_003CPublishComplete_003Ed__22);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				break;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 2;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublishInternal_003Ed__23))]
	private Task PublishInternal(Guid functionMetadataItemHeaderUid, string comment)
	{
		int num = 2;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CPublishInternal_003Ed__23 stateMachine = default(_003CPublishInternal_003Ed__23);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				case 1:
					stateMachine.functionMetadataItemHeaderUid = functionMetadataItemHeaderUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return stateMachine._003C_003Et__builder.Task;
				case 3:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					num2 = 4;
					continue;
				case 4:
					stateMachine._003C_003E1__state = -1;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					stateMachine.comment = comment;
					num2 = 3;
					continue;
				case 2:
					stateMachine._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Et__builder.Start(ref stateMachine);
			num = 6;
		}
	}

	private void CreatePublishingItem(ISession session, FunctionMetadataItemHeader header, string comment)
	{
		//Discarded unreachable code: IL_01c3, IL_01d2, IL_01f2, IL_0201, IL_0408, IL_0448, IL_0457, IL_0463, IL_0472
		int num = 2;
		int num2 = num;
		FunctionMetadataItem functionMetadataItem = default(FunctionMetadataItem);
		FunctionMetadataItem functionMetadataItem2 = default(FunctionMetadataItem);
		FunctionMetadata functionMetadata = default(FunctionMetadata);
		string text = default(string);
		Version version = default(Version);
		string text2 = default(string);
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				Contract.ArgumentNotNull(header, (string)KyUngFbYaEiAmLft9pqu(-97972138 ^ -97927998));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					IUser user = (IUser)qIIxuxbYwi4kB79NusDL(authenticationService);
					int num3 = 25;
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 25:
							functionMetadataItem = functionMetadataItemManager.Create();
							num3 = 24;
							break;
						default:
							I4hytWbY6dOnT7LFmRdV(functionMetadataItem, comment);
							num3 = 12;
							break;
						case 1:
							functionMetadataItem2 = (FunctionMetadataItem)MsogWvbYApTTYSpQRy4r(header);
							num3 = 10;
							break;
						case 16:
							CndWc9bYMldAhD5ONJje(functionMetadataItem, functionMetadata);
							num3 = 22;
							break;
						case 19:
							text = (string)rAKwobbYgAD8sMijZ8v3(functionMetadata);
							num3 = 9;
							break;
						case 23:
							Omm139bYYLEih0DlpsiH(header, functionMetadataItem);
							num3 = 5;
							break;
						case 9:
							UTsUkBbY5K6vNBxQey9J(functionMetadataItem, text);
							num3 = 26;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
							{
								num3 = 25;
							}
							break;
						case 14:
							functionMetadataItem.Header = header;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
							{
								num3 = 0;
							}
							break;
						case 2:
						case 18:
							jeNB8hbY9Eou761ptZBo(functionMetadataItem, IS9brobYdPORfBG7ZcOq(functionMetadataItem2));
							num3 = 19;
							break;
						case 6:
							wm1Pw0bYUcJqjjUOqQk6(header);
							num3 = 17;
							break;
						case 10:
							functionMetadata = (FunctionMetadata)functionMetadataItem2.Metadata;
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num3 = 3;
							}
							break;
						case 15:
						case 21:
							version = new Version((string)IS9brobYdPORfBG7ZcOq(functionMetadataItem2));
							num3 = 4;
							break;
						case 26:
							v0qcUZbYjQv0V6knRuKx(functionMetadataItem, ProcessScriptModule(functionMetadataItem2.ScriptModule, text));
							num4 = 20;
							goto IL_0074;
						case 4:
							text2 = new Version(version.Major, c3wZDYbYlo0S81h0bZBj(version), T5s5M4bYrNkKyDd5wANG(version), version.Revision + 1).ToString();
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num3 = 3;
							}
							break;
						case 3:
							jeNB8hbY9Eou761ptZBo(functionMetadataItem2, text2);
							num4 = 2;
							goto IL_0074;
						case 11:
							sLZDWubYx1uEKRRMYnD6(header, ztjhEObY7fNKjNT0KVeI(functionMetadata));
							num4 = 8;
							goto IL_0074;
						case 12:
							functionMetadataItem.VersionNumber = CiPIOpbYHL9AmPLBWcto(functionMetadataItemHeaderManager, header.Id);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num3 = 1;
							}
							break;
						case 5:
							HgpJi4bYLC6XlwCbZvjg(header, false);
							num4 = 6;
							goto IL_0074;
						case 13:
							header.Description = (string)yphgPsbYyAIRYEdEstYT(functionMetadata);
							num3 = 16;
							break;
						case 7:
							jeNB8hbY9Eou761ptZBo(functionMetadataItem2, KyUngFbYaEiAmLft9pqu(-1633514411 ^ -1633524091));
							num3 = 18;
							break;
						case 8:
							wo1QLNbYmiqGKpLown8w(header, oQuR0rbY0GG59mu4YbDL(functionMetadata));
							num3 = 13;
							break;
						case 20:
							session.Save((object)functionMetadataItem);
							num4 = 23;
							goto IL_0074;
						case 22:
							if (!w7d2OnbYJtC4hw53UK5R(functionMetadataItem2.AssemblyVersion))
							{
								num3 = 15;
								break;
							}
							goto case 7;
						case 24:
							functionMetadataItem.CreationAuthorId = (long?)((user != null) ? YNajM4bY44ieP4ZZhnsS(user) : null);
							num3 = 14;
							break;
						case 17:
							return;
							IL_0074:
							num3 = num4;
							break;
						}
					}
				}
				finally
				{
					int num5;
					if (disposable == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num5 = 0;
						}
						goto IL_040c;
					}
					goto IL_0422;
					IL_0422:
					disposable.Dispose();
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num5 = 0;
					}
					goto IL_040c;
					IL_040c:
					switch (num5)
					{
					default:
						goto end_IL_03e7;
					case 2:
						break;
					case 0:
						goto end_IL_03e7;
					case 1:
						goto end_IL_03e7;
					}
					goto IL_0422;
					end_IL_03e7:;
				}
			case 0:
				return;
			case 1:
				disposable = (IDisposable)K07OEFbYt47oNhQhEtL8(lockManager, d9aM7vbYDy3kHaumAVfY(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70234952), header.Id));
				num2 = 3;
				break;
			}
		}
		static ScriptModule ProcessScriptModule(ScriptModule scriptModule, string asmName)
		{
			//Discarded unreachable code: IL_0056, IL_0065
			int num6 = 1;
			int num7 = num6;
			while (true)
			{
				switch (num7)
				{
				case 2:
					return null;
				default:
				{
					ScriptModule scriptModule2 = CloneHelperBuilder.Create(scriptModule).Clone();
					deMQErbYcxFMsZaqs0MP(scriptModule2, HkYtD7bYsWnCHuZINQ44());
					scriptModule2.Id = 0L;
					met2M5bYzwHJapILaqUI(scriptModule2, asmName);
					return scriptModule2;
				}
				case 1:
					if (scriptModule != null)
					{
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num7 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	internal static void VUg6XAbYPVfMlwcgcKQH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static TimeSpan LTpgaebY1H0YybQA7PWa(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static Type g5ymyhbYNKQosjA6WlXa(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object MKqm8PbY3t9L9dj6p2Dm(object P_0, Type type)
	{
		return ((ILoggerFactory)P_0).CreateLogger(type);
	}

	internal static bool he0KOPbY2I3b9WkKqWhG()
	{
		return bDQEaybYOa5wILbYkESP == null;
	}

	internal static FunctionMetadataPublishingActor q77dKNbYeR16mRorKTVK()
	{
		return bDQEaybYOa5wILbYkESP;
	}

	internal static AsyncTaskMethodBuilder cX2Ek0bYpajA2ZsHkJ4W()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static object KyUngFbYaEiAmLft9pqu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object d9aM7vbYDy3kHaumAVfY(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object K07OEFbYt47oNhQhEtL8(object P_0, object P_1)
	{
		return ((ILockManager)P_0).Lock((string)P_1);
	}

	internal static object qIIxuxbYwi4kB79NusDL(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object YNajM4bY44ieP4ZZhnsS(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void I4hytWbY6dOnT7LFmRdV(object P_0, object P_1)
	{
		((FunctionMetadataItem)P_0).Comment = (string)P_1;
	}

	internal static long CiPIOpbYHL9AmPLBWcto(object P_0, long headerId)
	{
		return ((IFunctionMetadataItemHeaderManager)P_0).GetPublishingVersionNumber(headerId);
	}

	internal static object MsogWvbYApTTYSpQRy4r(object P_0)
	{
		return ((FunctionMetadataItemHeader)P_0).Draft;
	}

	internal static object ztjhEObY7fNKjNT0KVeI(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void sLZDWubYx1uEKRRMYnD6(object P_0, object P_1)
	{
		((FunctionMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static object oQuR0rbY0GG59mu4YbDL(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void wo1QLNbYmiqGKpLown8w(object P_0, object P_1)
	{
		((FunctionMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static object yphgPsbYyAIRYEdEstYT(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static void CndWc9bYMldAhD5ONJje(object P_0, object P_1)
	{
		((FunctionMetadataItem)P_0).Metadata = P_1;
	}

	internal static bool w7d2OnbYJtC4hw53UK5R(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void jeNB8hbY9Eou761ptZBo(object P_0, object P_1)
	{
		((FunctionMetadataItem)P_0).AssemblyVersion = (string)P_1;
	}

	internal static object IS9brobYdPORfBG7ZcOq(object P_0)
	{
		return ((FunctionMetadataItem)P_0).AssemblyVersion;
	}

	internal static int c3wZDYbYlo0S81h0bZBj(object P_0)
	{
		return ((Version)P_0).Minor;
	}

	internal static int T5s5M4bYrNkKyDd5wANG(object P_0)
	{
		return ((Version)P_0).Build;
	}

	internal static object rAKwobbYgAD8sMijZ8v3(object P_0)
	{
		return FunctionMetadataHelper.ServerAssemblyName((FunctionMetadata)P_0);
	}

	internal static void UTsUkBbY5K6vNBxQey9J(object P_0, object P_1)
	{
		((FunctionMetadataItem)P_0).AssemblyName = (string)P_1;
	}

	internal static void v0qcUZbYjQv0V6knRuKx(object P_0, object P_1)
	{
		((FunctionMetadataItem)P_0).ScriptModule = (ScriptModule)P_1;
	}

	internal static void Omm139bYYLEih0DlpsiH(object P_0, object P_1)
	{
		((FunctionMetadataItemHeader)P_0).Published = (FunctionMetadataItem)P_1;
	}

	internal static void HgpJi4bYLC6XlwCbZvjg(object P_0, bool value)
	{
		((FunctionMetadataItemHeader)P_0).IsDirtyItem = value;
	}

	internal static void wm1Pw0bYUcJqjjUOqQk6(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static Guid HkYtD7bYsWnCHuZINQ44()
	{
		return Guid.NewGuid();
	}

	internal static void deMQErbYcxFMsZaqs0MP(object P_0, Guid value)
	{
		((ScriptModule)P_0).Uid = value;
	}

	internal static void met2M5bYzwHJapILaqUI(object P_0, object P_1)
	{
		((ScriptModule)P_0).AssemblyName = (string)P_1;
	}
}
