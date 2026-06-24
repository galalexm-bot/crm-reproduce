using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Actors;

internal sealed class ComponentMetadataPublishingActor : Actor, IComponentMetadataPublishingActor, IActorWithGuidKey, IActor
{
	private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;

	private readonly ISearchMetadataService searchMetadataService;

	private readonly ICheckComponentService checkComponentService;

	private readonly IDependencyService dependencyService;

	private readonly IComponentAssemblyBuilderService componentAssemblyBuilderService;

	private readonly IDataClassTypeReferenceManager dataClassTypeReferenceManager;

	private readonly ILockManager lockManager;

	private readonly IAuthenticationService authenticationService;

	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	private readonly ISessionProvider sessionProvider;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly ISearchFormServiceInternal searchFormService;

	private readonly ILogger logger;

	private bool publicationStarted;

	internal static ComponentMetadataPublishingActor Ue9jOFBVLs3sVl5LlFJ1;

	public override TimeSpan LifeTime { get; }

	public ComponentMetadataPublishingActor(ILoggerFactory loggerFactory, IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager, ISearchMetadataService searchMetadataService, ICheckComponentService checkComponentService, IDependencyService dependencyService, IComponentAssemblyBuilderService componentAssemblyBuilderService, IDataClassTypeReferenceManager dataClassTypeReferenceManager, ILockManager lockManager, IAuthenticationService authenticationService, IComponentMetadataItemManager componentMetadataItemManager, ISessionProvider sessionProvider, IUnitOfWorkManager unitOfWorkManager, IServerPlacementPublishService serverPlacementPublishService, ISearchFormServiceInternal searchFormService)
	{
		//Discarded unreachable code: IL_0033
		SingletonReader.JJCZtPuTvSt();
		LifeTime = TimeSpan.FromHours(1.0);
		base._002Ector();
		int num = 12;
		while (true)
		{
			switch (num)
			{
			case 13:
				logger = (ILogger)EZ8ZgIBVc995tXuZcBcy(loggerFactory, typeof(ComponentMetadataPublishingActor));
				num = 4;
				break;
			case 11:
				this.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
				num = 7;
				break;
			case 7:
			{
				this.lockManager = lockManager;
				int num2 = 2;
				num = num2;
				break;
			}
			case 5:
				this.componentAssemblyBuilderService = componentAssemblyBuilderService;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 11;
				}
				break;
			case 12:
				this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num = 0;
				}
				break;
			case 10:
				this.dependencyService = dependencyService;
				num = 5;
				break;
			case 14:
				this.searchFormService = searchFormService;
				num = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num = 12;
				}
				break;
			case 6:
				this.sessionProvider = sessionProvider;
				num = 9;
				break;
			case 4:
				return;
			case 9:
				this.unitOfWorkManager = unitOfWorkManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 3;
				}
				break;
			case 1:
				this.searchMetadataService = searchMetadataService;
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num = 8;
				}
				break;
			case 2:
				this.authenticationService = authenticationService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				break;
			case 8:
				this.checkComponentService = checkComponentService;
				num = 10;
				break;
			case 3:
				this.serverPlacementPublishService = serverPlacementPublishService;
				num = 14;
				break;
			default:
				this.componentMetadataItemManager = componentMetadataItemManager;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num = 6;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CReceiveReminder_003Ed__22))]
	public override Task ReceiveReminder(string reminderName)
	{
		int num = 1;
		int num2 = num;
		_003CReceiveReminder_003Ed__22 stateMachine = default(_003CReceiveReminder_003Ed__22);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				stateMachine.reminderName = reminderName;
				num2 = 5;
				break;
			case 6:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 4;
				break;
			case 4:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder = giN4TaBVzkNmLvQ0ORPp();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 3;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublish_003Ed__23))]
	public Task Publish(string comment, bool forEmulation)
	{
		int num = 7;
		int num2 = num;
		_003CPublish_003Ed__23 stateMachine = default(_003CPublish_003Ed__23);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine._003C_003Et__builder = giN4TaBVzkNmLvQ0ORPp();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num2 = 4;
				break;
			case 2:
				stateMachine.forEmulation = forEmulation;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				stateMachine.comment = comment;
				num2 = 2;
				break;
			case 3:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 5;
				break;
			case 5:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 3;
				break;
			case 7:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublishComplete_003Ed__24))]
	public Task PublishComplete()
	{
		int num = 1;
		int num2 = num;
		_003CPublishComplete_003Ed__24 stateMachine = default(_003CPublishComplete_003Ed__24);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 3;
				break;
			case 2:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublishInternal_003Ed__25))]
	private Task PublishInternal(Guid componentMetadataItemHeaderUid, string comment, bool forEmulation)
	{
		int num = 3;
		int num2 = num;
		_003CPublishInternal_003Ed__25 stateMachine = default(_003CPublishInternal_003Ed__25);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 8:
				stateMachine.forEmulation = forEmulation;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine.comment = comment;
				num2 = 8;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 7;
				break;
			case 2:
				stateMachine.componentMetadataItemHeaderUid = componentMetadataItemHeaderUid;
				num2 = 4;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				stateMachine._003C_003Et__builder = giN4TaBVzkNmLvQ0ORPp();
				num2 = 5;
				break;
			case 6:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 6;
				break;
			}
		}
	}

	private void CreatePublishingItem(ISession session, ComponentMetadataItemHeader header, string comment, bool forEmulation)
	{
		//Discarded unreachable code: IL_01a6, IL_0264, IL_054f, IL_0571, IL_0580, IL_05f7, IL_060a, IL_0619, IL_06c3, IL_06d2, IL_077f, IL_07bf, IL_07ce, IL_07da, IL_07e9
		int num = 2;
		int num2 = num;
		ComponentMetadataItem componentMetadataItem2 = default(ComponentMetadataItem);
		string text4 = default(string);
		string text3 = default(string);
		Version version = default(Version);
		string text = default(string);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		string text2 = default(string);
		IUser user = default(IUser);
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				PaPqHYBSByZKbqvFWaE9(header, UJcyeqBSFd6XSVGf8W3g(0x571EA399 ^ 0x571E0F0D));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				try
				{
					ComponentMetadataItem componentMetadataItem = (ComponentMetadataItem)rVoqKRBSoTwqWrJJjf9D(header);
					int num3 = 33;
					while (true)
					{
						int num4;
						ComponentMetadataItem componentMetadataItem3;
						switch (num3)
						{
						case 2:
							return;
						case 20:
							q4TR3mBSTv6HsfPt31Wl(componentMetadataItem2, Y7795cBSK21gjN8ip1F3(componentMetadataItem.ViewScriptModule, text4));
							num3 = 13;
							break;
						case 22:
							text3 = new Version(FvLfPLBSV5IeSvK6WYtd(version), Vd0FqeBSSES8LjDom2Za(version), osk0uJBSiKNT2bBVSQBC(version), Da4EtYBSR3ITDY5a3Q56(version) + 1).ToString();
							num3 = 21;
							break;
						case 49:
							hmIyeYBSZNGiTk2moeUt(componentMetadataItem2, text);
							num4 = 5;
							goto IL_0070;
						case 42:
							YP4HK7BSCbCAfgxFC1CJ(componentMetadataItem2, lMrdkGBSQXR95wVpG8bI());
							num3 = 47;
							break;
						case 34:
							if (!forEmulation)
							{
								num3 = 27;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
								{
									num3 = 39;
								}
								break;
							}
							goto case 8;
						case 21:
							text = text3;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num3 = 15;
							}
							break;
						case 45:
							text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FAEA1E);
							num3 = 34;
							break;
						case 37:
							Ywr9EOBSEM3UxcEkBmnM(componentMetadata);
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num3 = 10;
							}
							break;
						case 12:
							hqfvOlBSGjH87egGDPAy(componentMetadata);
							num3 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
							{
								num3 = 37;
							}
							break;
						case 28:
							cVikVrBSe1ijU5Dwg5XL(header, componentMetadataItem2);
							num3 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num3 = 6;
							}
							break;
						case 24:
							MuVfhVBSwdjgENYLaYBs(header, d3WLi4BSteHUbvsgfjbf(componentMetadata));
							num3 = 41;
							break;
						case 14:
							zuwW7oBSpNqYssBMnlq6(header, Jxt35JBS3Lr3koL10iIx(componentMetadata));
							num3 = 31;
							break;
						case 50:
							Xf3AhoBS85GsRBiQeWyR(componentMetadataItem2, comment);
							num3 = 45;
							break;
						case 9:
							RGROjwBS1MSyOOFFEb6W(header, componentMetadataItem2);
							num3 = 16;
							break;
						case 44:
						case 48:
							fTtMAmBSfBNPZPWToEky(componentMetadataItem2, componentMetadata);
							num3 = 42;
							break;
						case 1:
							text2 = ComponentMetadataHelper.ServerAssemblyName(componentMetadata);
							num3 = 18;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num3 = 27;
							}
							break;
						case 40:
							componentMetadataItem2.VersionNumber = JSZchkBSPdiY5Ni1NymO(componentMetadataItemHeaderManager, header.Id);
							num3 = 9;
							break;
						case 33:
							user = (IUser)xqIerWBSbRSlnt5Rvp4U(authenticationService);
							num3 = 30;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num3 = 27;
							}
							break;
						case 31:
							kv0Xj7BSDDA60dRSGEId(header, gaQuorBSaKwQuv13Evj5(componentMetadata));
							num3 = 24;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num3 = 21;
							}
							break;
						case 30:
							componentMetadata = (ComponentMetadata)ClassSerializationHelper.CloneObjectByXml(i0vhLxBShWukpBm8vG61(componentMetadataItem));
							num3 = 12;
							break;
						case 46:
							version = new Version((string)qya1FwBSI5HOTw9sCQaa(componentMetadataItem));
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num3 = 22;
							}
							break;
						default:
							componentMetadataItem2.Header = header;
							num3 = 50;
							break;
						case 18:
						case 29:
							YIss3WBSOesrml21H2VM(session, componentMetadataItem2);
							num3 = 25;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num3 = 7;
							}
							break;
						case 5:
							JjZN5JBSupMGDHYKyML0(componentMetadataItem2, text2);
							num3 = 26;
							break;
						case 10:
							if (!forEmulation)
							{
								num3 = 43;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
								{
									num3 = 30;
								}
								break;
							}
							goto case 7;
						case 15:
							hmIyeYBSZNGiTk2moeUt(componentMetadataItem, text3);
							num3 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num3 = 35;
							}
							break;
						case 16:
							zTFcpWBSN7trJBQTBo1I(header, false);
							num3 = 14;
							break;
						case 17:
						case 41:
							wFC31QBS4XClygkhDP6n(header);
							num3 = 2;
							break;
						case 19:
							text4 = ComponentMetadataHelper.ClientAssemblyName(componentMetadata, text);
							num3 = 33;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num3 = 51;
							}
							break;
						case 35:
						case 36:
							componentMetadataItem2.AssemblyVersion = text;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
							{
								num3 = 1;
							}
							break;
						case 6:
						case 26:
							typutFBSXH4FXkPf2pT3(componentMetadataItem2, Y7795cBSK21gjN8ip1F3(KF6RE5BSqIqMl6RJvUCj(componentMetadataItem), text2));
							num3 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num3 = 8;
							}
							break;
						case 4:
						case 43:
							componentMetadataItem2 = componentMetadataItemManager.Create();
							num3 = 44;
							break;
						case 11:
						case 39:
							if (string.IsNullOrEmpty((string)qya1FwBSI5HOTw9sCQaa(componentMetadataItem)))
							{
								num3 = 32;
								break;
							}
							goto case 46;
						case 27:
							componentMetadataItem2.AssemblyName = text2;
							num3 = 6;
							break;
						case 51:
							componentMetadataItem2.ClientScriptModule = ProcessScriptModule(componentMetadataItem.ClientScriptModule, text4);
							num3 = 20;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num3 = 6;
							}
							break;
						case 13:
							if (!forEmulation)
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num3 = 29;
								}
								break;
							}
							goto case 23;
						case 32:
							hmIyeYBSZNGiTk2moeUt(componentMetadataItem, text);
							num4 = 36;
							goto IL_0070;
						case 25:
							if (forEmulation)
							{
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num3 = 38;
								}
								break;
							}
							goto case 40;
						case 7:
							componentMetadataItem3 = header.Emulation;
							if (componentMetadataItem3 == null)
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num3 = 0;
								}
								break;
							}
							goto IL_06fe;
						case 8:
							text2 = ComponentMetadataHelperInternal.ServerEmulationAssemblyName(componentMetadata);
							num3 = 49;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num3 = 34;
							}
							break;
						case 23:
							nKCanpBSnHfyJeSopg4Y(componentMetadataItem2, Y7795cBSK21gjN8ip1F3(Voa41yBSkTB4jOqyfxkS(componentMetadataItem), text4));
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num3 = 18;
							}
							break;
						case 38:
							YyqqkwBS2KuYosyRLjCO(componentMetadataItem2, true);
							num4 = 28;
							goto IL_0070;
						case 3:
							componentMetadataItem3 = componentMetadataItemManager.Create();
							goto IL_06fe;
						case 47:
							{
								componentMetadataItem2.CreationAuthorId = (long?)((user != null) ? JMQLdcBSvh50ejK73X5x(user) : null);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num3 = 0;
								}
								break;
							}
							IL_0070:
							num3 = num4;
							break;
							IL_06fe:
							componentMetadataItem2 = componentMetadataItem3;
							num3 = 48;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num3 = 34;
							}
							break;
						}
					}
				}
				finally
				{
					int num5;
					if (disposable == null)
					{
						num5 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num5 = 1;
						}
						goto IL_0783;
					}
					goto IL_0799;
					IL_0799:
					OMElSLBS6UWTbC1dC4hg(disposable);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num5 = 1;
					}
					goto IL_0783;
					IL_0783:
					switch (num5)
					{
					case 2:
						goto end_IL_075e;
					case 1:
						goto end_IL_075e;
					}
					goto IL_0799;
					end_IL_075e:;
				}
			case 1:
				disposable = lockManager.Lock((string)wtLTlHBSW9cT9fJFqrdn(UJcyeqBSFd6XSVGf8W3g(0x53CB464B ^ 0x53CA5FFB), header.Id));
				num2 = 3;
				break;
			}
		}
		static ScriptModule ProcessScriptModule(ScriptModule scriptModule, string asmName)
		{
			int num6 = 1;
			int num7 = num6;
			while (true)
			{
				switch (num7)
				{
				default:
					return null;
				case 1:
					if (scriptModule != null)
					{
						ScriptModule scriptModule2 = CloneHelperBuilder.Create(scriptModule).Clone();
						yWHkRuBSAfEHOpJVAuHs(scriptModule2, bh4vScBSHvygwwTWVE5Z());
						scriptModule2.Id = 0L;
						scriptModule2.AssemblyName = asmName;
						return scriptModule2;
					}
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num7 = 0;
					}
					break;
				}
			}
		}
	}

	internal static object EZ8ZgIBVc995tXuZcBcy(object P_0, Type type)
	{
		return ((ILoggerFactory)P_0).CreateLogger(type);
	}

	internal static bool KXCrCYBVUu6ZQrjOfj8c()
	{
		return Ue9jOFBVLs3sVl5LlFJ1 == null;
	}

	internal static ComponentMetadataPublishingActor O7fycTBVs8RayBitNGHw()
	{
		return Ue9jOFBVLs3sVl5LlFJ1;
	}

	internal static AsyncTaskMethodBuilder giN4TaBVzkNmLvQ0ORPp()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static object UJcyeqBSFd6XSVGf8W3g(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void PaPqHYBSByZKbqvFWaE9(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object wtLTlHBSW9cT9fJFqrdn(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object rVoqKRBSoTwqWrJJjf9D(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).Draft;
	}

	internal static object xqIerWBSbRSlnt5Rvp4U(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object i0vhLxBShWukpBm8vG61(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static void hqfvOlBSGjH87egGDPAy(object P_0)
	{
		((ComponentMetadata)P_0).GenerateNewUids();
	}

	internal static void Ywr9EOBSEM3UxcEkBmnM(object P_0)
	{
		ComponentMetadataItemHeaderManager.UpdateCalculateScriptDynamicProperties((ComponentMetadata)P_0);
	}

	internal static void fTtMAmBSfBNPZPWToEky(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).Metadata = P_1;
	}

	internal static DateTime lMrdkGBSQXR95wVpG8bI()
	{
		return DateTime.Now;
	}

	internal static void YP4HK7BSCbCAfgxFC1CJ(object P_0, DateTime value)
	{
		((ComponentMetadataItem)P_0).CreationDate = value;
	}

	internal static object JMQLdcBSvh50ejK73X5x(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void Xf3AhoBS85GsRBiQeWyR(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).Comment = (string)P_1;
	}

	internal static void hmIyeYBSZNGiTk2moeUt(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).AssemblyVersion = (string)P_1;
	}

	internal static void JjZN5JBSupMGDHYKyML0(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).AssemblyName = (string)P_1;
	}

	internal static object qya1FwBSI5HOTw9sCQaa(object P_0)
	{
		return ((ComponentMetadataItem)P_0).AssemblyVersion;
	}

	internal static int FvLfPLBSV5IeSvK6WYtd(object P_0)
	{
		return ((Version)P_0).Major;
	}

	internal static int Vd0FqeBSSES8LjDom2Za(object P_0)
	{
		return ((Version)P_0).Minor;
	}

	internal static int osk0uJBSiKNT2bBVSQBC(object P_0)
	{
		return ((Version)P_0).Build;
	}

	internal static int Da4EtYBSR3ITDY5a3Q56(object P_0)
	{
		return ((Version)P_0).Revision;
	}

	internal static object KF6RE5BSqIqMl6RJvUCj(object P_0)
	{
		return ((ComponentMetadataItem)P_0).ScriptModule;
	}

	internal static object Y7795cBSK21gjN8ip1F3(object P_0, object P_1)
	{
		return ProcessScriptModule((ScriptModule)P_0, (string)P_1);
		static ScriptModule ProcessScriptModule(ScriptModule scriptModule, string asmName)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 1:
					if (scriptModule != null)
					{
						ScriptModule scriptModule2 = CloneHelperBuilder.Create(scriptModule).Clone();
						yWHkRuBSAfEHOpJVAuHs(scriptModule2, bh4vScBSHvygwwTWVE5Z());
						scriptModule2.Id = 0L;
						scriptModule2.AssemblyName = asmName;
						return scriptModule2;
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
	}

	internal static void typutFBSXH4FXkPf2pT3(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).ScriptModule = (ScriptModule)P_1;
	}

	internal static void q4TR3mBSTv6HsfPt31Wl(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).ViewScriptModule = (ScriptModule)P_1;
	}

	internal static object Voa41yBSkTB4jOqyfxkS(object P_0)
	{
		return ((ComponentMetadataItem)P_0).TestScriptModule;
	}

	internal static void nKCanpBSnHfyJeSopg4Y(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).TestScriptModule = (ScriptModule)P_1;
	}

	internal static object YIss3WBSOesrml21H2VM(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static void YyqqkwBS2KuYosyRLjCO(object P_0, bool value)
	{
		((ComponentMetadataItem)P_0).IsEmulation = value;
	}

	internal static void cVikVrBSe1ijU5Dwg5XL(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Emulation = (ComponentMetadataItem)P_1;
	}

	internal static long JSZchkBSPdiY5Ni1NymO(object P_0, long headerId)
	{
		return ((IComponentMetadataItemHeaderManager)P_0).GetPublishingVersionNumber(headerId);
	}

	internal static void RGROjwBS1MSyOOFFEb6W(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Published = (ComponentMetadataItem)P_1;
	}

	internal static void zTFcpWBSN7trJBQTBo1I(object P_0, bool value)
	{
		((ComponentMetadataItemHeader)P_0).IsDirtyItem = value;
	}

	internal static object Jxt35JBS3Lr3koL10iIx(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void zuwW7oBSpNqYssBMnlq6(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static object gaQuorBSaKwQuv13Evj5(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void kv0Xj7BSDDA60dRSGEId(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static object d3WLi4BSteHUbvsgfjbf(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static void MuVfhVBSwdjgENYLaYBs(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Description = (string)P_1;
	}

	internal static void wFC31QBS4XClygkhDP6n(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static void OMElSLBS6UWTbC1dC4hg(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid bh4vScBSHvygwwTWVE5Z()
	{
		return Guid.NewGuid();
	}

	internal static void yWHkRuBSAfEHOpJVAuHs(object P_0, Guid value)
	{
		((ScriptModule)P_0).Uid = value;
	}
}
