using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Actors;

internal sealed class DataClassMetadataPublishingActor : DataClassMetadataPublishingActorBase, IDataClassMetadataPublishingActor, IActorWithGuidKey, IActor
{
	private static DataClassMetadataPublishingActor cP3biQbj10Kl0TsyYBus;

	public DataClassMetadataPublishingActor(ILoggerFactory loggerFactory, IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager, ICheckDataClassService checkDataClassService, ISearchMetadataService searchMetadataService, IDataClassAssemblyBuilderService dataClassAssemblyBuilderService, IDataClassMetadataItemManager dataClassMetadataItemManager, IDataClassTypeReferenceManager dataClassTypeReferenceManager, ISessionProvider sessionProvider, IUnitOfWorkManager unitOfWorkManager, IServerPlacementPublishService serverPlacementPublishService, ISearchFormServiceInternal searchFormService)
	{
		//Discarded unreachable code: IL_004c, IL_0051
		ukj5QpbjpuTXfTIjyCrW();
		base._002Ector((ILogger)iXkjI8bjDM4D3Ec0fQoe(loggerFactory, mp8OKPbja55sJJhepFEx(typeof(DataClassMetadataPublishingActor).TypeHandle)), dataClassMetadataItemHeaderManager, checkDataClassService, searchMetadataService, dataClassAssemblyBuilderService, dataClassMetadataItemManager, dataClassTypeReferenceManager, sessionProvider, unitOfWorkManager, serverPlacementPublishService, searchFormService);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[AsyncStateMachine(typeof(_003CPublish_003Ed__1))]
	public Task Publish(string comment)
	{
		int num = 6;
		int num2 = num;
		_003CPublish_003Ed__1 stateMachine = default(_003CPublish_003Ed__1);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 6:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 3;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 4;
				break;
			case 5:
				stateMachine.comment = comment;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				stateMachine._003C_003Et__builder = xXiRO3bjtG2gECSyi9S4();
				num2 = 2;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public Task PublishComplete()
	{
		return Complete();
	}

	internal static void ukj5QpbjpuTXfTIjyCrW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type mp8OKPbja55sJJhepFEx(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object iXkjI8bjDM4D3Ec0fQoe(object P_0, Type type)
	{
		return ((ILoggerFactory)P_0).CreateLogger(type);
	}

	internal static bool qH37AsbjNAwv8DUP1k93()
	{
		return cP3biQbj10Kl0TsyYBus == null;
	}

	internal static DataClassMetadataPublishingActor OmSvwZbj3RcUtdPcdDfA()
	{
		return cP3biQbj10Kl0TsyYBus;
	}

	internal static AsyncTaskMethodBuilder xXiRO3bjtG2gECSyi9S4()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
internal abstract class DataClassMetadataPublishingActorBase : Actor
{
	private readonly ICheckDataClassService checkDataClassService;

	private readonly ISearchMetadataService searchMetadataService;

	private readonly IDataClassAssemblyBuilderService dataClassAssemblyBuilderService;

	private readonly IDataClassMetadataItemManager dataClassMetadataItemManager;

	private readonly IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager;

	private readonly IDataClassTypeReferenceManager dataClassTypeReferenceManager;

	private readonly ISessionProvider sessionProvider;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly ISearchFormServiceInternal searchFormService;

	private readonly ILogger logger;

	protected const string ReminderName = "DataClassMetadataPublishingActorBase";

	protected Guid? PublicationToken;

	private static DataClassMetadataPublishingActorBase OhlOYMbjwws8JCgvr5Zt;

	public override TimeSpan LifeTime { get; }

	protected DataClassMetadataPublishingActorBase(ILogger logger, IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager, ICheckDataClassService checkDataClassService, ISearchMetadataService searchMetadataService, IDataClassAssemblyBuilderService dataClassAssemblyBuilderService, IDataClassMetadataItemManager dataClassMetadataItemManager, IDataClassTypeReferenceManager dataClassTypeReferenceManager, ISessionProvider sessionProvider, IUnitOfWorkManager unitOfWorkManager, IServerPlacementPublishService serverPlacementPublishService, ISearchFormServiceInternal searchFormService)
	{
		//Discarded unreachable code: IL_0033
		lZBNBObjHIMMkkfXMVVc();
		LifeTime = npIkRkbjAPoGWXpQXJo4(1.0);
		base._002Ector();
		int num = 9;
		while (true)
		{
			switch (num)
			{
			case 5:
			{
				this.sessionProvider = sessionProvider;
				int num2 = 6;
				num = num2;
				break;
			}
			case 3:
				return;
			case 6:
				this.unitOfWorkManager = unitOfWorkManager;
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 3;
				}
				break;
			case 7:
				this.serverPlacementPublishService = serverPlacementPublishService;
				num = 2;
				break;
			case 9:
				this.logger = logger;
				num = 8;
				break;
			case 2:
				this.searchFormService = searchFormService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num = 0;
				}
				break;
			case 11:
				this.searchMetadataService = searchMetadataService;
				num = 10;
				break;
			default:
				this.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
				num = 3;
				break;
			case 1:
				this.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
				num = 5;
				break;
			case 8:
				this.checkDataClassService = checkDataClassService;
				num = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num = 11;
				}
				break;
			case 4:
				this.dataClassMetadataItemManager = dataClassMetadataItemManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num = 0;
				}
				break;
			case 10:
				this.dataClassAssemblyBuilderService = dataClassAssemblyBuilderService;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CReceiveReminder_003Ed__17))]
	public override Task ReceiveReminder(string reminderName)
	{
		int num = 1;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CReceiveReminder_003Ed__17 stateMachine = default(_003CReceiveReminder_003Ed__17);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					break;
				case 4:
					stateMachine._003C_003Et__builder = yBF6Ufbj75wWu8BwclmC();
					num2 = 6;
					continue;
				case 1:
					stateMachine._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return stateMachine._003C_003Et__builder.Task;
				case 6:
					stateMachine._003C_003E1__state = -1;
					num2 = 3;
					continue;
				default:
					stateMachine.reminderName = reminderName;
					num2 = 4;
					continue;
				}
				break;
			}
			_003C_003Et__builder.Start(ref stateMachine);
			num = 5;
		}
	}

	[AsyncStateMachine(typeof(_003CPublishInternal_003Ed__18))]
	protected Task PublishInternal(string comment, Guid[] dataClassMetadataItemHeadersUid)
	{
		int num = 1;
		int num2 = num;
		_003CPublishInternal_003Ed__18 stateMachine = default(_003CPublishInternal_003Ed__18);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine.comment = comment;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 3;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			case 7:
				stateMachine._003C_003Et__builder = yBF6Ufbj75wWu8BwclmC();
				num2 = 6;
				break;
			case 3:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine.dataClassMetadataItemHeadersUid = dataClassMetadataItemHeadersUid;
				num2 = 7;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static UIMetadataPublishResult PublishInternal(string comment, Guid[] dataClassMetadataItemHeadersUid, IUnitOfWorkManager unitOfWorkManager, IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager, IDataClassMetadataItemManager dataClassMetadataItemManager, IDataClassTypeReferenceManager dataClassTypeReferenceManager, IDataClassAssemblyBuilderService dataClassAssemblyBuilderService, ICheckDataClassService checkDataClassService, ISearchMetadataService searchMetadataService, ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_0208, IL_02ee, IL_0316, IL_0335, IL_0344, IL_0371, IL_03cc, IL_03db, IL_03e6, IL_049d, IL_04b0, IL_04cf, IL_060b, IL_0658, IL_0767, IL_0844, IL_089e, IL_08d6, IL_08e5
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		UIMetadataPublishResult result = default(UIMetadataPublishResult);
		UIMetadataPublishResult uIMetadataPublishResult = default(UIMetadataPublishResult);
		DataClassMetadataItemHeader dataClassMetadataItemHeader = default(DataClassMetadataItemHeader);
		_003C_003Ec__DisplayClass19_1 _003C_003Ec__DisplayClass19_2 = default(_003C_003Ec__DisplayClass19_1);
		Guid guid = default(Guid);
		ValidationResult validationResult = default(ValidationResult);
		Guid[] array3 = default(Guid[]);
		int num8 = default(int);
		DataClassMetadataItem dataClassMetadataItem2 = default(DataClassMetadataItem);
		DataClassBuildAssemblyModel dataClassBuildAssemblyModel = default(DataClassBuildAssemblyModel);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		DataClassMetadataItem[] array = default(DataClassMetadataItem[]);
		Dictionary<Guid, DataClassMetadataItem>.KeyCollection.Enumerator enumerator = default(Dictionary<Guid, DataClassMetadataItem>.KeyCollection.Enumerator);
		Guid current = default(Guid);
		int num6 = default(int);
		DataClassMetadataItem[] array2 = default(DataClassMetadataItem[]);
		Dictionary<Guid, DataClassMetadataItem> dictionary = default(Dictionary<Guid, DataClassMetadataItem>);
		DataClassMetadataItem dataClassMetadataItem = default(DataClassMetadataItem);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass19_.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass19_.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
				num2 = 2;
				continue;
			case 6:
				_003C_003Ec__DisplayClass19_.comment = comment;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 3;
				}
				continue;
			case 7:
				unitOfWork = unitOfWorkManager.Create("", transactional: true, IsolationLevel.ReadCommitted);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return result;
			case 5:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass19_.dataClassMetadataItemManager = dataClassMetadataItemManager;
				num2 = 3;
				continue;
			}
			try
			{
				HashSet<Guid> hashSet = new HashSet<Guid>();
				int num3 = 31;
				while (true)
				{
					int num7;
					switch (num3)
					{
					case 18:
						return result;
					case 28:
						return result;
					case 20:
						result = uIMetadataPublishResult;
						num7 = 28;
						goto IL_00f7;
					case 39:
						dataClassMetadataItemHeader = _003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals1.dataClassMetadataItemHeaderManager.LoadOrNull(guid);
						num3 = 9;
						break;
					case 2:
						uIMetadataPublishResult.Errors.AddRange((IEnumerable<ValidationError>)veOQUIbj9bA2AL5e1UK3(validationResult));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num3 = 14;
						}
						break;
					case 12:
						guid = array3[num8];
						num3 = 26;
						break;
					case 35:
						array3 = dataClassMetadataItemHeadersUid;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num3 = 1;
						}
						break;
					case 9:
						if (dataClassMetadataItemHeader != null)
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num3 = 8;
							}
							break;
						}
						goto case 10;
					case 4:
						xNfGFFbj5QFQUB8frtLs(unitOfWork);
						num3 = 20;
						break;
					case 10:
						throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x83274DA), guid));
					case 8:
						dataClassMetadataItem2 = (DataClassMetadataItem)tHd7t2bjxiyV6kp2sSb3(dataClassMetadataItemHeader);
						num3 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num3 = 36;
						}
						break;
					case 33:
						try
						{
							SQw3GZbjd5dxLVPvrtOj(dataClassAssemblyBuilderService, dataClassBuildAssemblyModel);
							int num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
							{
								num9 = 0;
							}
							switch (num9)
							{
							case 0:
								break;
							}
						}
						finally
						{
							int num10;
							if (metadataServiceContext == null)
							{
								num10 = 2;
								goto IL_031a;
							}
							goto IL_034f;
							IL_031a:
							switch (num10)
							{
							default:
								goto end_IL_0305;
							case 2:
								goto end_IL_0305;
							case 1:
								break;
							case 0:
								goto end_IL_0305;
							}
							goto IL_034f;
							IL_034f:
							LFw4lWbjl4EKejsab8Et(metadataServiceContext);
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num10 = 0;
							}
							goto IL_031a;
							end_IL_0305:;
						}
						goto case 3;
					case 14:
						result = uIMetadataPublishResult;
						num3 = 18;
						break;
					case 32:
						uIMetadataPublishResult.ItemUid = XdqQH7bjgSQXB7B787l6(array[0]);
						num3 = 24;
						break;
					case 21:
						_003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass19_;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num3 = 6;
						}
						break;
					case 13:
						try
						{
							while (true)
							{
								IL_044b:
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num4 = 1;
									}
									goto IL_03ea;
								}
								goto IL_0428;
								IL_0428:
								current = enumerator.Current;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num4 = 1;
								}
								goto IL_03ea;
								IL_03ea:
								while (true)
								{
									switch (num4)
									{
									case 1:
										hashSet.Add(current);
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
										{
											num4 = 2;
										}
										continue;
									case 2:
										goto IL_044b;
									case 3:
										goto end_IL_044b;
									}
									break;
								}
								goto IL_0428;
								continue;
								end_IL_044b:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
						goto case 17;
					case 27:
						num6++;
						num3 = 11;
						break;
					case 7:
					case 11:
						if (num6 >= array2.Length)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 16;
					case 5:
						if (!yRgIWAbjJAj2RxFWNfG3(validationResult))
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
							{
								num3 = 1;
							}
							break;
						}
						goto case 27;
					case 6:
						if (hashSet.Contains(guid))
						{
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num3 = 19;
							}
							break;
						}
						goto case 39;
					case 23:
					case 34:
						if (num8 >= array3.Length)
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
							{
								num3 = 2;
							}
							break;
						}
						goto case 12;
					case 22:
						dictionary = new Dictionary<Guid, DataClassMetadataItem>();
						num3 = 30;
						break;
					case 19:
					case 24:
						num8++;
						num3 = 34;
						break;
					case 38:
						enumerator = dictionary.Keys.GetEnumerator();
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num3 = 13;
						}
						break;
					case 36:
						if (dataClassMetadataItem2 == null)
						{
							num3 = 29;
							break;
						}
						_003C_003Ec__DisplayClass19_2.session = (ISession)v3m4Plbjmv80ANHr1Cyx(sessionProvider, "");
						num3 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num3 = 22;
						}
						break;
					case 3:
						mqw4IXbjrvyytn2N0yoP(_003C_003Ec__DisplayClass19_2.session);
						num7 = 32;
						goto IL_00f7;
					case 31:
						uIMetadataPublishResult = new UIMetadataPublishResult();
						num3 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num3 = 35;
						}
						break;
					case 26:
						_003C_003Ec__DisplayClass19_2 = new _003C_003Ec__DisplayClass19_1();
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num3 = 21;
						}
						break;
					case 1:
						num8 = 0;
						num3 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num3 = 4;
						}
						break;
					case 16:
						dataClassMetadataItem = array2[num6];
						num3 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num3 = 15;
						}
						break;
					case 30:
						GetNotPublishedItems(_003C_003Ec__DisplayClass19_2.CS_0024_003C_003E8__locals1.dataClassMetadataItemHeaderManager, dataClassMetadataItem2, dictionary, guid);
						num3 = 38;
						break;
					case 29:
						throw new Exception(SR.T((string)zSJX6Zbj007hv8Q9SGFa(-218496594 ^ -218562536), guid));
					case 37:
						num6 = 0;
						num7 = 7;
						goto IL_00f7;
					case 17:
						array = dictionary.Values.Select(_003C_003Ec__DisplayClass19_2._003CPublishInternal_003Eb__0).ToArray();
						num3 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num3 = 1;
						}
						break;
					case 25:
						array2 = array;
						num3 = 37;
						break;
					case 15:
						validationResult = (ValidationResult)SE4jbEbjMXfNZKfdYvxW(checkDataClassService, (DataClassMetadata)W6LLkLbjypk39JY6VCiG(dataClassMetadataItem));
						num7 = 5;
						goto IL_00f7;
					default:
						{
							List<DataClassMetadata> metadataList = searchMetadataService.GetPublishedDataClasses().ToList();
							List<DataClassAssemblyInfo> source = searchMetadataService.GetPublishedDataClassAssemblies().ToList();
							dataClassBuildAssemblyModel = new DataClassBuildAssemblyModel(array, source.Select((DataClassAssemblyInfo a) => (byte[])_003C_003Ec.rlTYOdCmD9uym6SZDJk6(a)), source.Select((DataClassAssemblyInfo a) => a.ClientAssemblyRaw));
							metadataServiceContext = MetadataServiceContext.Extend(metadataList);
							num3 = 33;
							break;
						}
						IL_00f7:
						num3 = num7;
						break;
					}
				}
			}
			catch (Exception)
			{
				int num11 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num11 = 0;
				}
				while (true)
				{
					switch (num11)
					{
					case 1:
						oDnHnqbjj1lNtxqgdpVM(unitOfWork);
						num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num11 = 0;
						}
						break;
					default:
						throw;
					}
				}
			}
			finally
			{
				if (unitOfWork != null)
				{
					int num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num12 = 1;
					}
					while (true)
					{
						switch (num12)
						{
						case 1:
							LFw4lWbjl4EKejsab8Et(unitOfWork);
							num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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
			}
		}
	}

	[AsyncStateMachine(typeof(_003CComplete_003Ed__20))]
	protected Task Complete()
	{
		int num = 2;
		_003CComplete_003Ed__20 stateMachine = default(_003CComplete_003Ed__20);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 2:
					stateMachine._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return stateMachine._003C_003Et__builder.Task;
				case 5:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					stateMachine._003C_003Et__builder = yBF6Ufbj75wWu8BwclmC();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					stateMachine._003C_003E1__state = -1;
					num2 = 4;
					continue;
				}
				break;
			}
			_003C_003Et__builder = stateMachine._003C_003Et__builder;
			num = 5;
		}
	}

	private static void GetNotPublishedItems(object dataClassMetadataItemHeaderManager, object item, Dictionary<Guid, DataClassMetadataItem> cache, params Guid[] publishingItems)
	{
		if (cache.ContainsKey(((DataClassMetadataItem)item).Header.Uid))
		{
			return;
		}
		cache[((DataClassMetadataItem)item).Header.Uid] = (DataClassMetadataItem)item;
		foreach (PropertyMetadata property in ((DataClassMetadata)((DataClassMetadataItem)item).Metadata).Properties)
		{
			_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
			if (!(property.TypeUid != DataClassDescriptor.UID))
			{
				CS_0024_003C_003E8__locals0.header = ((IEntityManager<DataClassMetadataItemHeader>)dataClassMetadataItemHeaderManager).LoadOrNull(property.SubTypeUid);
				if (CS_0024_003C_003E8__locals0.header != null && (CS_0024_003C_003E8__locals0.header.Published == null || Array.Exists(publishingItems, (Guid uid) => uid == _003C_003Ec__DisplayClass21_0.bxcCjVCmMIvFK2e5aFK6(CS_0024_003C_003E8__locals0.header))))
				{
					GetNotPublishedItems(dataClassMetadataItemHeaderManager, CS_0024_003C_003E8__locals0.header.Draft, cache, publishingItems);
				}
			}
		}
	}

	private static void CreatePublishingItem(object dataClassMetadataItemHeaderManager, object dataClassMetadataItemManager, object dataClassTypeReferenceManager, object session, object item, object comment)
	{
		//Discarded unreachable code: IL_0095, IL_00a4, IL_02cc, IL_0395
		int num = 10;
		string text = default(string);
		DataClassMetadataItem dataClassMetadataItem = default(DataClassMetadataItem);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		Version version = default(Version);
		DataClassTypeReference dataClassTypeReference2 = default(DataClassTypeReference);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					T0JUkfbYqS0PIFGmiVua(DOq3SEbYB9pduxUtBMLq(item));
					num2 = 5;
					continue;
				case 1:
					IwuDsdbYEKM1qrotiXrZ(item, text);
					num2 = 23;
					continue;
				case 15:
					dataClassMetadataItem.AssemblyName = (string)P3owOjbYCWZrgJjoKlfv(dataClassMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				case 21:
				case 22:
					version = new Version((string)vbjGbGbYhx1A9jEtb75P(item));
					num2 = 27;
					continue;
				case 7:
					pvuuXPbYWSw2o9dvvJqR(dataClassMetadataItem, DOq3SEbYB9pduxUtBMLq(item));
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 26;
					}
					continue;
				default:
					RoI7CxbYvkBNAWiokqeq(session, dataClassMetadataItem);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 1;
					}
					continue;
				case 25:
					EncuBUbYik99PluFb36b(dataClassMetadataItem, HSKI99bYSYemKkTXJUnM(v6LniGbYuMKP4NpV4jaV(DOq3SEbYB9pduxUtBMLq(item))));
					num = 3;
					break;
				case 26:
					h6txqZbYoJWDIC7iqYXK(dataClassMetadataItem, comment);
					num2 = 11;
					continue;
				case 17:
				case 23:
					IwuDsdbYEKM1qrotiXrZ(dataClassMetadataItem, vbjGbGbYhx1A9jEtb75P(item));
					num = 15;
					break;
				case 9:
					dataClassMetadataItem = ((IEntityManager<DataClassMetadataItem>)dataClassMetadataItemManager).Create();
					num2 = 8;
					continue;
				case 13:
					IwuDsdbYEKM1qrotiXrZ(item, zSJX6Zbj007hv8Q9SGFa(-234299632 ^ -234342976));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 2;
					}
					continue;
				case 27:
					text = new Version(version.Major, sTqNH1bYfo68yWtBf7jS(version), DF5bkYbYQYVnk1pnU4SZ(version), version.Revision + 1).ToString();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					((DataClassMetadataItemHeader)DOq3SEbYB9pduxUtBMLq(item)).DisplayName = dataClassMetadata.DisplayName;
					num2 = 28;
					continue;
				case 14:
					dataClassMetadataItem.CreationAuthorId = ((DataClassMetadataItem)item).CreationAuthorId;
					num = 7;
					break;
				case 4:
					yoDeVLbYZ2xTeHX0Uc1Y(DOq3SEbYB9pduxUtBMLq(item), cdvX9AbY8uAl0gJifHx0(dataClassMetadata));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 1;
					}
					continue;
				case 28:
					if (v6LniGbYuMKP4NpV4jaV(DOq3SEbYB9pduxUtBMLq(item)) == null)
					{
						num2 = 16;
						continue;
					}
					goto case 12;
				case 20:
					JT8E8wbjccNP39KFNj8V(dataClassMetadataItem, dataClassMetadata);
					num = 19;
					break;
				case 2:
					if (!tIA5DKbYGwLBUyKe0o81(vbjGbGbYhx1A9jEtb75P(item)))
					{
						num2 = 21;
						continue;
					}
					goto case 13;
				case 12:
					PyQpdObYVqRtBYoWhqIf(dataClassMetadataItem, T8S830bYIfMkFVuERcFA(((DataClassMetadataItemHeader)DOq3SEbYB9pduxUtBMLq(item)).Published));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 25;
					}
					continue;
				case 3:
				case 16:
					GWi4vfbYRYu5MIGn8GZX(DOq3SEbYB9pduxUtBMLq(item), dataClassMetadataItem);
					num = 18;
					break;
				case 10:
					dataClassMetadata = (DataClassMetadata)W6LLkLbjypk39JY6VCiG(item);
					num2 = 9;
					continue;
				case 24:
					OodtUSbjsNytOHOkLwvv(dataClassMetadata, cuZLoAbjU3BCFNZ7kjPh(dataClassTypeReferenceManager, dataClassTypeReference2).ToString());
					num2 = 20;
					continue;
				case 11:
					dataClassMetadataItem.VersionNumber = RFZmGwbYbgbmoZJUKmF9(dataClassMetadataItemHeaderManager, ((Entity<long>)DOq3SEbYB9pduxUtBMLq(item)).Id);
					num2 = 2;
					continue;
				case 19:
					GxpYWlbYFCb817bxylAT(dataClassMetadataItem, iaOftJbjzmC96j7ZKr3Y());
					num2 = 14;
					continue;
				case 8:
				{
					DataClassTypeReference dataClassTypeReference = new DataClassTypeReference();
					gjr2vDbjLcBWmlDDtmp5(dataClassTypeReference, nSQb4ZbjYe0sUVDKYagO(dataClassMetadata));
					dataClassTypeReference.ItemUid = XdqQH7bjgSQXB7B787l6(dataClassMetadataItem);
					dataClassTypeReference2 = dataClassTypeReference;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 24;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	internal static void lZBNBObjHIMMkkfXMVVc()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static TimeSpan npIkRkbjAPoGWXpQXJo4(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static bool WEiO8Ibj4cunJ7JftFkn()
	{
		return OhlOYMbjwws8JCgvr5Zt == null;
	}

	internal static DataClassMetadataPublishingActorBase eNOGM2bj6dmQMhei8up4()
	{
		return OhlOYMbjwws8JCgvr5Zt;
	}

	internal static AsyncTaskMethodBuilder yBF6Ufbj75wWu8BwclmC()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static object tHd7t2bjxiyV6kp2sSb3(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Draft;
	}

	internal static object zSJX6Zbj007hv8Q9SGFa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object v3m4Plbjmv80ANHr1Cyx(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object W6LLkLbjypk39JY6VCiG(object P_0)
	{
		return ((DataClassMetadataItem)P_0).Metadata;
	}

	internal static object SE4jbEbjMXfNZKfdYvxW(object P_0, object P_1)
	{
		return ((ICheckDataClassService)P_0).Validate((DataClassMetadata)P_1);
	}

	internal static bool yRgIWAbjJAj2RxFWNfG3(object P_0)
	{
		return ((ValidationResult)P_0).IsValid;
	}

	internal static object veOQUIbj9bA2AL5e1UK3(object P_0)
	{
		return ((ValidationResult)P_0).Errors;
	}

	internal static void SQw3GZbjd5dxLVPvrtOj(object P_0, object P_1)
	{
		((IDataClassAssemblyBuilderService)P_0).Build((DataClassBuildAssemblyModel)P_1);
	}

	internal static void LFw4lWbjl4EKejsab8Et(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void mqw4IXbjrvyytn2N0yoP(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static Guid XdqQH7bjgSQXB7B787l6(object P_0)
	{
		return ((DataClassMetadataItem)P_0).Uid;
	}

	internal static void xNfGFFbj5QFQUB8frtLs(object P_0)
	{
		((IUnitOfWork)P_0).Commit();
	}

	internal static void oDnHnqbjj1lNtxqgdpVM(object P_0)
	{
		((IUnitOfWork)P_0).Rollback();
	}

	internal static Guid nSQb4ZbjYe0sUVDKYagO(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void gjr2vDbjLcBWmlDDtmp5(object P_0, Guid value)
	{
		((DataClassTypeReference)P_0).MetadataUid = value;
	}

	internal static long cuZLoAbjU3BCFNZ7kjPh(object P_0, object P_1)
	{
		return ((IDataClassTypeReferenceManager)P_0).Save((DataClassTypeReference)P_1);
	}

	internal static void OodtUSbjsNytOHOkLwvv(object P_0, object P_1)
	{
		((DataClassMetadata)P_0).TypeRef = (string)P_1;
	}

	internal static void JT8E8wbjccNP39KFNj8V(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).Metadata = P_1;
	}

	internal static DateTime iaOftJbjzmC96j7ZKr3Y()
	{
		return DateTime.Now;
	}

	internal static void GxpYWlbYFCb817bxylAT(object P_0, DateTime value)
	{
		((DataClassMetadataItem)P_0).CreationDate = value;
	}

	internal static object DOq3SEbYB9pduxUtBMLq(object P_0)
	{
		return ((DataClassMetadataItem)P_0).Header;
	}

	internal static void pvuuXPbYWSw2o9dvvJqR(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).Header = (DataClassMetadataItemHeader)P_1;
	}

	internal static void h6txqZbYoJWDIC7iqYXK(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).Comment = (string)P_1;
	}

	internal static long RFZmGwbYbgbmoZJUKmF9(object P_0, long headerId)
	{
		return ((IDataClassMetadataItemHeaderManager)P_0).GetNewPublishingVersionNumber(headerId);
	}

	internal static object vbjGbGbYhx1A9jEtb75P(object P_0)
	{
		return ((DataClassMetadataItem)P_0).AssemblyVersion;
	}

	internal static bool tIA5DKbYGwLBUyKe0o81(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void IwuDsdbYEKM1qrotiXrZ(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).AssemblyVersion = (string)P_1;
	}

	internal static int sTqNH1bYfo68yWtBf7jS(object P_0)
	{
		return ((Version)P_0).Minor;
	}

	internal static int DF5bkYbYQYVnk1pnU4SZ(object P_0)
	{
		return ((Version)P_0).Build;
	}

	internal static object P3owOjbYCWZrgJjoKlfv(object P_0)
	{
		return DataClassMetadataItemManager.ServerAssemblyName((DataClassMetadata)P_0);
	}

	internal static object RoI7CxbYvkBNAWiokqeq(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static object cdvX9AbY8uAl0gJifHx0(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void yoDeVLbYZ2xTeHX0Uc1Y(object P_0, object P_1)
	{
		((DataClassMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static object v6LniGbYuMKP4NpV4jaV(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Published;
	}

	internal static object T8S830bYIfMkFVuERcFA(object P_0)
	{
		return ((DataClassMetadataItem)P_0).AssemblyRaw;
	}

	internal static void PyQpdObYVqRtBYoWhqIf(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).AssemblyRaw = (byte[])P_1;
	}

	internal static object HSKI99bYSYemKkTXJUnM(object P_0)
	{
		return ((DataClassMetadataItem)P_0).ClientAssemblyRaw;
	}

	internal static void EncuBUbYik99PluFb36b(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).ClientAssemblyRaw = (byte[])P_1;
	}

	internal static void GWi4vfbYRYu5MIGn8GZX(object P_0, object P_1)
	{
		((DataClassMetadataItemHeader)P_0).Published = (DataClassMetadataItem)P_1;
	}

	internal static void T0JUkfbYqS0PIFGmiVua(object P_0)
	{
		((Entity<long>)P_0).Save();
	}
}
