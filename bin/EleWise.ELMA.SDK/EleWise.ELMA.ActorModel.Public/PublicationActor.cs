using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Helpers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ActorModel.Publication;

internal sealed class PublicationActor : Actor, IPublicationActor, IActorWithGuidKey, IActor
{
	private class PublishFinishedEventHandler : IMetadataPublishFinishedEventHandler, IEventHandler
	{
		private readonly Action<MetadataPublishedEventArgs> action;

		internal static object BgHY04Zb1iuM4GfTUdCL;

		public PublishFinishedEventHandler(Action<MetadataPublishedEventArgs> action)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.action = action;
		}

		public void PublishExecuted(MetadataPublishedEventArgs eventArgs)
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
					action(eventArgs);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool GpafM7ZbNMOQCcwojeL7()
		{
			return BgHY04Zb1iuM4GfTUdCL == null;
		}

		internal static PublishFinishedEventHandler t76Yg2Zb30wxL4WqdJqc()
		{
			return (PublishFinishedEventHandler)BgHY04Zb1iuM4GfTUdCL;
		}
	}

	private class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
	{
		private readonly Func<Guid, Task> complete;

		internal static object qNHd6VZbpkqyT8Lpxxdt;

		public ServerStatusEventHandler(Func<Guid, Task> complete)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.complete = complete;
		}

		public void ServerStarted(Guid serverUid, Version serverVersion)
		{
		}

		public void ServerStarting(Guid serverUid)
		{
		}

		public void ServerStoped(Guid serverUid)
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
					complete(serverUid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static bool IKSaaNZbayBtja304Jv5()
		{
			return qNHd6VZbpkqyT8Lpxxdt == null;
		}

		internal static ServerStatusEventHandler K9aT72ZbDLWc3GeCL6w7()
		{
			return (ServerStatusEventHandler)qNHd6VZbpkqyT8Lpxxdt;
		}
	}

	private readonly IUnitOfWorkManagerAsync unitOfWorkManager;

	private readonly ILazy<ISecurityService> securityService;

	private readonly ILazy<ISessionProvider> sessionProvider;

	private readonly ILazy<ITransformationProvider> transformationProvider;

	private readonly ILazy<MetadataItemHeaderManager> metadataItemHeaderManager;

	private readonly ILazy<MetadataItemManager> metadataItemManager;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly IDynamicPublicationService dynamicPublicationService;

	private readonly ILazy<IMetadataRuntimeService> metadataRuntimeService;

	private readonly IAfterDeltaPublishEventHandler afterDeltaPublishEventHandler;

	private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly IEnumerable<IPublicationHandler> publicationHandlers;

	private readonly ISearchMetadataService searchMetadataService;

	private readonly ILazy<IModelAssemblyBuilderHandler> modelAssemblyBuilderHandler;

	private readonly IEntityMetadataDependencyService entityMetadataDependencyService;

	private readonly IWorkWithFormDependeciesService workWithFormDependenciesService;

	private readonly ILogger publishLogger;

	private readonly HashSet<Guid> completeTokens;

	private IDisposable publishFinishedEventHandler;

	private IDisposable serverStatusEventHandler;

	private AbstractMetadata[] publishedMetadata;

	private Version publishedVersion;

	private HashSet<Guid> waitUids;

	private HashSet<Guid> waitRuntimeUpdateUids;

	private TaskCompletionSource<bool> waitNodesPublicationComplete;

	private TaskCompletionSource<bool> waitNodesRuntimeUpdateComplete;

	private Guid? publicationToken;

	private IDictionary<string, long> assemblyModelsMetadataIds;

	private static PublicationActor sjpvosfpA66fOdgSrIkN;

	public override TimeSpan LifeTime { get; }

	[NotNull]
	private ISession Session => sessionProvider.Value.GetSession(string.Empty);

	public PublicationActor(IUnitOfWorkManagerAsync unitOfWorkManager, ILazy<ISecurityService> securityService, ILazy<ISessionProvider> sessionProvider, ILazy<ITransformationProvider> transformationProvider, ILazy<MetadataItemHeaderManager> metadataItemHeaderManager, ILazy<MetadataItemManager> metadataItemManager, IActorModelRuntime actorModelRuntime, IRuntimeApplication runtimeApplication, IDynamicPublicationService dynamicPublicationService, ILazy<IMetadataRuntimeService> metadataRuntimeService, IAfterDeltaPublishEventHandler afterDeltaPublishEventHandler, IEventHandlerSubscribeService eventHandlerSubscribeService, IServerPlacementPublishService serverPlacementPublishService, IEnumerable<IPublicationHandler> publicationHandlers, ISearchMetadataService searchMetadataService, ILazy<IModelAssemblyBuilderHandler> modelAssemblyBuilderHandler, IEntityMetadataDependencyService entityMetadataDependencyService, IWorkWithFormDependeciesService workWithFormDependenciesService)
	{
		SingletonReader.JJCZtPuTvSt();
		completeTokens = new HashSet<Guid>();
		LifeTime = TimeSpan.FromDays(365.0);
		base._002Ector();
		this.unitOfWorkManager = unitOfWorkManager;
		this.securityService = securityService;
		this.sessionProvider = sessionProvider;
		this.transformationProvider = transformationProvider;
		this.metadataItemHeaderManager = metadataItemHeaderManager;
		this.metadataItemManager = metadataItemManager;
		this.actorModelRuntime = actorModelRuntime;
		this.runtimeApplication = runtimeApplication;
		this.dynamicPublicationService = dynamicPublicationService;
		this.metadataRuntimeService = metadataRuntimeService;
		this.afterDeltaPublishEventHandler = afterDeltaPublishEventHandler;
		this.eventHandlerSubscribeService = eventHandlerSubscribeService;
		this.serverPlacementPublishService = serverPlacementPublishService;
		this.publicationHandlers = publicationHandlers;
		this.searchMetadataService = searchMetadataService;
		this.modelAssemblyBuilderHandler = modelAssemblyBuilderHandler;
		this.entityMetadataDependencyService = entityMetadataDependencyService;
		this.workWithFormDependenciesService = workWithFormDependenciesService;
		publishLogger = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334934577));
	}

	public override Task OnActivateAsync()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (nZOJpmfpylYSIoU5LJpP(dynamicPublicationService))
				{
					num2 = 2;
					continue;
				}
				break;
			case 2:
				publishFinishedEventHandler = eventHandlerSubscribeService.Subscribe(new PublishFinishedEventHandler(PublishFinished));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return (Task)CNhprlfpJR56VHcSvmc5();
			case 4:
				Ic8mZYfpm7pLAh7eYV5s(publishLogger, BaDoFSfp0Y3o0kH3tZnG(0x571EA399 ^ 0x571BF703));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 3;
				}
				continue;
			}
			serverStatusEventHandler = (IDisposable)vTLMjVfpMNNPmgYFlnNU(eventHandlerSubscribeService, new ServerStatusEventHandler(Complete));
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
			{
				num2 = 1;
			}
		}
	}

	public override Task OnDeactivateAsync()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				NbhRh4fp9pcZgJLHtPab(serverStatusEventHandler);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
			{
				IDisposable disposable = publishFinishedEventHandler;
				if (disposable == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					disposable.Dispose();
					num2 = 3;
				}
				break;
			}
			case 4:
				return (Task)CNhprlfpJR56VHcSvmc5();
			case 2:
				Ic8mZYfpm7pLAh7eYV5s(publishLogger, BaDoFSfp0Y3o0kH3tZnG(-1108654032 ^ -1108704432));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CReceiveReminder_003Ed__36))]
	public override Task ReceiveReminder(string reminderName)
	{
		int num = 5;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CReceiveReminder_003Ed__36 stateMachine = default(_003CReceiveReminder_003Ed__36);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				stateMachine.reminderName = reminderName;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder = psnbbpfpdMlTuWb2vEQN();
				num2 = 2;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 6:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num2 = 4;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__37))]
	public Task<Guid> Start(string comment, string tag, params long[] headerIds)
	{
		_003CStart_003Ed__37 stateMachine = default(_003CStart_003Ed__37);
		stateMachine._003C_003E4__this = this;
		stateMachine.comment = comment;
		stateMachine.tag = tag;
		stateMachine.headerIds = headerIds;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CStartInternal_003Ed__38))]
	private Task StartInternal(string comment, string tag, long[] headerIds)
	{
		int num = 2;
		_003CStartInternal_003Ed__38 stateMachine = default(_003CStartInternal_003Ed__38);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					stateMachine.tag = tag;
					num2 = 7;
					continue;
				case 6:
					stateMachine._003C_003Et__builder = psnbbpfpdMlTuWb2vEQN();
					num2 = 8;
					continue;
				case 2:
					stateMachine._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				case 8:
					stateMachine._003C_003E1__state = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 4;
					continue;
				case 4:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 3;
					continue;
				case 7:
					stateMachine.headerIds = headerIds;
					num2 = 6;
					continue;
				case 3:
					return stateMachine._003C_003Et__builder.Task;
				}
				break;
			}
			stateMachine.comment = comment;
			num = 5;
		}
	}

	public Task<bool> PublicationStarted()
	{
		if (publicationToken.HasValue)
		{
			return Task.FromResult(result: true);
		}
		DeactivateOnIdle();
		return Task.FromResult(result: false);
	}

	public Task Wait(Guid uid)
	{
		//Discarded unreachable code: IL_0073, IL_00a1, IL_0104, IL_013c, IL_01de, IL_0254, IL_0263, IL_0290
		int num = 5;
		int num2 = num;
		bool lockTaken = default(bool);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				lockTaken = false;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				lockTaken = false;
				num2 = 9;
				break;
			case 9:
				try
				{
					Monitor.Enter(hashSet, ref lockTaken);
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							waitUids.Add(uid);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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
				finally
				{
					if (lockTaken)
					{
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								ebFpZNfplMPVeUHOmAfQ(hashSet);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num7 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 3;
			case 4:
				hashSet = waitUids;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (Task)CNhprlfpJR56VHcSvmc5();
			case 5:
				if (waitUids != null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 2:
				hashSet = waitRuntimeUpdateUids;
				num2 = 8;
				break;
			case 3:
				if (waitRuntimeUpdateUids == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 6:
				try
				{
					Monitor.Enter(hashSet, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							waitRuntimeUpdateUids.Add(uid);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					int num5;
					if (!lockTaken)
					{
						int num4 = 2;
						num5 = num4;
						goto IL_0239;
					}
					goto IL_026e;
					IL_0239:
					switch (num5)
					{
					default:
						goto end_IL_0220;
					case 2:
						goto end_IL_0220;
					case 1:
						break;
					case 0:
						goto end_IL_0220;
					}
					goto IL_026e;
					IL_026e:
					Monitor.Exit(hashSet);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num5 = 0;
					}
					goto IL_0239;
					end_IL_0220:;
				}
				goto default;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CComplete_003Ed__41))]
	public Task Complete(Guid сonnectionUid)
	{
		int num = 3;
		int num2 = num;
		_003CComplete_003Ed__41 stateMachine = default(_003CComplete_003Ed__41);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				stateMachine.сonnectionUid = сonnectionUid;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				stateMachine._003C_003Et__builder = psnbbpfpdMlTuWb2vEQN();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public Task RuntimeUpdated(Guid connectionUid)
	{
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				waitRuntimeUpdateUids.Remove(connectionUid);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				waitRuntimeUpdateUids = null;
				num2 = 6;
				break;
			case 5:
				if (waitRuntimeUpdateUids != null)
				{
					num2 = 4;
					break;
				}
				goto default;
			default:
				return (Task)CNhprlfpJR56VHcSvmc5();
			case 3:
				if (I9mtQufprG1ZIiEFGDjx(waitRuntimeUpdateUids) == 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 6:
			{
				TaskCompletionSource<bool> taskCompletionSource = waitNodesRuntimeUpdateComplete;
				if (taskCompletionSource == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					taskCompletionSource.TrySetResult(result: true);
					num2 = 2;
				}
				break;
			}
			}
		}
	}

	[AsyncStateMachine(typeof(_003CError_003Ed__43))]
	public Task Error(Exception exception)
	{
		int num = 4;
		int num2 = num;
		_003CError_003Ed__43 stateMachine = default(_003CError_003Ed__43);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				stateMachine.exception = exception;
				num2 = 6;
				break;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 2;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			case 1:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 5;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				break;
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private MetadataAssemblyPublishResult Publish(PublishData publishData)
	{
		//Discarded unreachable code: IL_0186, IL_0195, IL_01a5, IL_01b4, IL_0226, IL_03ce, IL_04b3, IL_04c6, IL_04d5
		int num = 24;
		ICollection<IRootMetadata> collection = default(ICollection<IRootMetadata>);
		AssemblyModelsMetadata assemblyModelsMetadata = default(AssemblyModelsMetadata);
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = default(_003C_003Ec__DisplayClass46_0);
		MetadataAssemblyPublishResult result = default(MetadataAssemblyPublishResult);
		IList<ScriptModule> allScriptModules = default(IList<ScriptModule>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 4:
				case 5:
					if (collection == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 13;
				case 25:
				{
					IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> obj = Session.QueryOver<AssemblyModelsMetadata>();
					ParameterExpression parameterExpression = (ParameterExpression)Pv0bQOfpzl4niI4MiJNP(MRbA6EfpcFOKsJVdGjQm(typeof(AssemblyModelsMetadata).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76F1F04));
					assemblyModelsMetadata = ((IQueryOver<AssemblyModelsMetadata>)(object)obj.Where(Expression.Lambda<Func<AssemblyModelsMetadata, bool>>((Expression)Tqmexlfab8g14GIlrp8e(QcZEC1faBJW0El6bmCZf(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), vGqWd4faFfls9kCe1Im9(BaDoFSfp0Y3o0kH3tZnG(0x269E5FCA ^ 0x269E55AE), MRbA6EfpcFOKsJVdGjQm(typeof(string).TypeHandle))), QcZEC1faBJW0El6bmCZf(Expression.Convert((Expression)qmpQGGfaotI2jqJplgTn(parameterExpression, (MethodInfo)jJ5K2XfaWLEAyb916ZKG((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), MRbA6EfpcFOKsJVdGjQm(typeof(int).TypeHandle)), vGqWd4faFfls9kCe1Im9(2, MRbA6EfpcFOKsJVdGjQm(typeof(int).TypeHandle)))), new ParameterExpression[1] { parameterExpression }))).Take(1).SingleOrDefault();
					num2 = 15;
					break;
				}
				case 23:
					_003C_003Ec__DisplayClass46_.publishData = publishData;
					num2 = 6;
					break;
				case 21:
					if (dynamicPublicationService.Enable)
					{
						num2 = 25;
						break;
					}
					goto case 1;
				case 16:
				case 20:
					if (gVm3UAfaGxV9ObDjq591(_003C_003Ec__DisplayClass46_.publishData.RestartNeededMetadata) <= 0)
					{
						num2 = 4;
						break;
					}
					goto case 18;
				default:
					if (assemblyModelsMetadata == null)
					{
						goto end_IL_0012;
					}
					goto case 22;
				case 14:
					collection = _003C_003Ec__DisplayClass46_.publishData.RestartNeededMetadata.Values;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 1;
					}
					break;
				case 22:
					bHdOpJfavdcOkdeZTSxl(Session, assemblyModelsMetadata);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 6;
					}
					break;
				case 24:
					_003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
					num2 = 23;
					break;
				case 2:
					oXM82FfaCjwug51Njp6Z(Session, assemblyModelsMetadata);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				case 17:
				{
					HashSet<IRootMetadata> hashSet = ((IEnumerable)maOl3efahXEcsF5riZAa(assemblyModelsMetadata)).Cast<IRootMetadata>().ToHashSet(RootMetadataComparer.Instance);
					hashSet.UnionWith(_003C_003Ec__DisplayClass46_.publishData.RestartNeededMetadata.Values);
					hashSet.ExceptWith(_003C_003Ec__DisplayClass46_.publishData.SoftPublishedMetadata.Values);
					hashSet.ExceptWith(_003C_003Ec__DisplayClass46_.publishData.DeltaPublishedMetadata.Values);
					collection = hashSet;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					break;
				}
				case 19:
					result = ConfigurationModelAssemblyBuilder.Publish(_003C_003Ec__DisplayClass46_.publishData.MetadataItems.Where(_003C_003Ec__DisplayClass46_._003CPublish_003Eb__0), _003C_003Ec__DisplayClass46_._003CPublish_003Eb__1, _003C_003Ec__DisplayClass46_._003CPublish_003Eb__2, metadataRuntimeService.Value, modelAssemblyBuilderHandler.Value, publishedMetadata.OfType<AbstractMetadata>(), allScriptModules, ignoreScriptsErrors: false, !JBybaTfpsjpmgMWHCVOe(_003C_003Ec__DisplayClass46_.publishData), buildClientScripts: true, nZOJpmfpylYSIoU5LJpP(dynamicPublicationService));
					num2 = 21;
					break;
				case 15:
					collection = null;
					num2 = 11;
					break;
				case 1:
				case 8:
				case 12:
					return result;
				case 9:
					assemblyModelsMetadata.SetMetadata(collection.Cast<AbstractMetadata>().ToArray());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 2;
					}
					break;
				case 13:
					if (SpvmekfaQnJVlSiTbEj7(collection) > 0)
					{
						num2 = 9;
						break;
					}
					goto default;
				case 10:
					allScriptModules = ((ICriteria)BWUctNfpUUKqdQryZKgd(Session.CreateCriteria<ScriptModule>(), LisvgmfpLq15lOyOspvO(BaDoFSfp0Y3o0kH3tZnG(-978351861 ^ -978384811), FabUvKfpYg1HkGAAmjoU(jwoNeGfp5hxmvpXWdOrm(T1BBLIfpgXNoReaASXEi(InterfaceActivator.TypeOf<IMetadataItemHeader>()), BaDoFSfp0Y3o0kH3tZnG(-29254301 ^ -29105159), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420568172)), iN5TgdfpjiDJqHotjxFy(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881949270)))))).List<ScriptModule>();
					num2 = 19;
					break;
				case 6:
					_003C_003Ec__DisplayClass46_._003C_003E4__this = this;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 5;
					}
					break;
				case 18:
				{
					AssemblyModelsMetadata assemblyModelsMetadata2 = new AssemblyModelsMetadata();
					DcFPHEfaEXoe1oSG4xMI(assemblyModelsMetadata2, BaDoFSfp0Y3o0kH3tZnG(-345420348 ^ -345421920));
					uDKBdufafsG201uFbbgq(assemblyModelsMetadata2, AssemblyModelsMetadataStatus.Prepared);
					assemblyModelsMetadata = assemblyModelsMetadata2;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 14;
					}
					break;
				}
				case 11:
					if (assemblyModelsMetadata == null)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 14;
						}
						break;
					}
					goto case 17;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	private static List<ValidationError> ValidateMetadataItem(object item, IEnumerable<IMetadata> extendMetadata)
	{
		List<ValidationError> list = new List<ValidationError>();
		EntityMetadata entityMetadata = ((IMetadataItem)item).Metadata as EntityMetadata;
		if (entityMetadata?.ViewModelMetadata == null)
		{
			return list;
		}
		using (MetadataServiceContext.Extend(extendMetadata))
		{
			foreach (FormViewItem form in entityMetadata.Forms)
			{
				list.AddRange(CheckComponentHelper.CheckComponentViewItems(form, entityMetadata.ViewModelMetadata.Uid, entityMetadata));
			}
			return list;
		}
	}

	internal static void ValidateMetadataReferences(PublishData publishData)
	{
		//Discarded unreachable code: IL_00e6, IL_00f5, IL_01da, IL_02a9, IL_02bc, IL_02cb, IL_02dc, IL_039d, IL_03d5, IL_03fd, IL_040c, IL_044e, IL_045d, IL_05c4, IL_05d7, IL_062b, IL_0635, IL_079c, IL_07af, IL_07be, IL_082c, IL_09b5, IL_09c8, IL_0ad5, IL_0ae4, IL_0aef, IL_0b26, IL_0b35, IL_0ca9, IL_0cbc
		int num = 12;
		_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_2 = default(_003C_003Ec__DisplayClass48_0);
		List<EntityMetadata> list = default(List<EntityMetadata>);
		Dictionary<Guid, IRootMetadata>.Enumerator enumerator = default(Dictionary<Guid, IRootMetadata>.Enumerator);
		_003C_003Ec__DisplayClass48_2 _003C_003Ec__DisplayClass48_ = default(_003C_003Ec__DisplayClass48_2);
		KeyValuePair<Guid, IRootMetadata> current5 = default(KeyValuePair<Guid, IRootMetadata>);
		EntityMetadata entityMetadata4 = default(EntityMetadata);
		IEnumerator<EntityMetadata> enumerator2 = default(IEnumerator<EntityMetadata>);
		EntityMetadata current2 = default(EntityMetadata);
		List<ValidationError> list3 = default(List<ValidationError>);
		_003C_003Ec__DisplayClass48_1 _003C_003Ec__DisplayClass48_3 = default(_003C_003Ec__DisplayClass48_1);
		Dictionary<Guid, IRootMetadata> dictionary = default(Dictionary<Guid, IRootMetadata>);
		KeyValuePair<Guid, IRootMetadata> current = default(KeyValuePair<Guid, IRootMetadata>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntityMetadata entityMetadata5 = default(EntityMetadata);
		KeyValuePair<Guid, IRootMetadata> current6 = default(KeyValuePair<Guid, IRootMetadata>);
		ValidationError[] validationErrors = default(ValidationError[]);
		KeyValuePair<Guid, IRootMetadata> current4 = default(KeyValuePair<Guid, IRootMetadata>);
		EntityMetadata entityMetadata3 = default(EntityMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		KeyValuePair<Guid, IRootMetadata> current3 = default(KeyValuePair<Guid, IRootMetadata>);
		IEnumerable<EntityMetadata> source = default(IEnumerable<EntityMetadata>);
		while (true)
		{
			int num2 = num;
			List<EntityMetadata> list2;
			Action<EntityMetadata> action;
			while (true)
			{
				switch (num2)
				{
				case 18:
					if (_003C_003Ec__DisplayClass48_2.publishData.RestartNeededMetadata.Count > 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 30:
					if (list.Count <= 0)
					{
						num2 = 18;
						continue;
					}
					goto case 16;
				case 9:
					try
					{
						while (true)
						{
							int num15;
							if (!enumerator.MoveNext())
							{
								int num14 = 8;
								num15 = num14;
								goto IL_0104;
							}
							goto IL_01e4;
							IL_0104:
							while (true)
							{
								switch (num15)
								{
								case 5:
									break;
								case 7:
									_003C_003Ec__DisplayClass48_.tempMetadataList[current5.Key] = current5.Value;
									num15 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
									{
										num15 = 3;
									}
									continue;
								case 3:
									if ((entityMetadata4 = current5.Value as EntityMetadata) == null)
									{
										num15 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
										{
											num15 = 2;
										}
										continue;
									}
									goto case 6;
								case 6:
									if (JxMDCnfaZexqZ3ZpjMAJ(entityMetadata4) == EntityMetadataType.InterfaceExtension)
									{
										num15 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
										{
											num15 = 4;
										}
										continue;
									}
									goto case 1;
								default:
									goto IL_01e4;
								case 4:
									_003C_003Ec__DisplayClass48_.publishExtensionsMetadataList[atZvhUfauvh9Gx7MeNyc(entityMetadata4)] = current5.Value;
									num15 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num15 = 1;
									}
									continue;
								case 1:
								case 2:
									GetRecursiveTablePartMetadata(current5.Value).ForEach(_003C_003Ec__DisplayClass48_._003CValidateMetadataReferences_003Eb__6);
									num15 = 5;
									continue;
								case 8:
									goto end_IL_0132;
								}
								break;
							}
							continue;
							IL_01e4:
							current5 = enumerator.Current;
							num15 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
							{
								num15 = 7;
							}
							goto IL_0104;
							continue;
							end_IL_0132:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num16 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num16 = 0;
						}
						switch (num16)
						{
						case 0:
							break;
						}
					}
					goto case 17;
				case 14:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator2.MoveNext())
							{
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num6 = 0;
								}
								goto IL_02ea;
							}
							goto IL_0360;
							IL_0360:
							current2 = enumerator2.Current;
							int num7 = 2;
							num6 = num7;
							goto IL_02ea;
							IL_02ea:
							while (true)
							{
								switch (num6)
								{
								case 2:
									list3.AddRange(ValidateMetadataReferences(current2, _003C_003Ec__DisplayClass48_.tempMetadataList, _003C_003Ec__DisplayClass48_.publishExtensionsMetadataList));
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num6 = 0;
									}
									continue;
								case 3:
									goto IL_0360;
								case 1:
									goto end_IL_033a;
								}
								break;
							}
							continue;
							end_IL_033a:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num8 = 1;
							}
							while (true)
							{
								switch (num8)
								{
								case 1:
									NbhRh4fp9pcZgJLHtPab(enumerator2);
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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
					}
					goto case 8;
				case 1:
					_003C_003Ec__DisplayClass48_3.tempMetadataList = new Dictionary<Guid, IRootMetadata>(dictionary);
					num2 = 26;
					continue;
				case 25:
					try
					{
						while (true)
						{
							IL_04b9:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 6;
								goto IL_0417;
							}
							goto IL_0468;
							IL_04d3:
							_003C_003Ec__DisplayClass48_.tempMetadataList[current.Key] = current.Value;
							num3 = 8;
							goto IL_0417;
							IL_0468:
							current = enumerator.Current;
							int num4 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num4 = 1;
							}
							goto IL_041b;
							IL_0417:
							num4 = num3;
							goto IL_041b;
							IL_041b:
							while (true)
							{
								switch (num4)
								{
								case 2:
									break;
								case 8:
									if ((entityMetadata = current.Value as EntityMetadata) == null)
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 4;
								case 5:
									goto IL_04b9;
								case 7:
									goto IL_04d3;
								case 4:
									if (JxMDCnfaZexqZ3ZpjMAJ(entityMetadata) == EntityMetadataType.InterfaceExtension)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 1;
								default:
									_003C_003Ec__DisplayClass48_.publishExtensionsMetadataList[entityMetadata.BaseClassUid] = current.Value;
									num4 = 3;
									continue;
								case 1:
								case 3:
									GetRecursiveTablePartMetadata(current.Value).ForEach(_003C_003Ec__DisplayClass48_._003CValidateMetadataReferences_003Eb__8);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
									{
										num4 = 5;
									}
									continue;
								case 6:
									goto end_IL_04b9;
								}
								break;
							}
							goto IL_0468;
							continue;
							end_IL_04b9:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 24;
				case 15:
					_003C_003Ec__DisplayClass48_.publishExtensionsMetadataList = new Dictionary<Guid, IRootMetadata>();
					num2 = 3;
					continue;
				case 17:
					enumerator = _003C_003Ec__DisplayClass48_2.publishData.DeltaPublishedMetadata.GetEnumerator();
					num2 = 23;
					continue;
				case 12:
					_003C_003Ec__DisplayClass48_2 = new _003C_003Ec__DisplayClass48_0();
					num2 = 11;
					continue;
				case 23:
					try
					{
						while (true)
						{
							int num17;
							if (!enumerator.MoveNext())
							{
								num17 = 6;
								goto IL_0639;
							}
							goto IL_06db;
							IL_0639:
							while (true)
							{
								switch (num17)
								{
								case 4:
									_003C_003Ec__DisplayClass48_.publishExtensionsMetadataList[atZvhUfauvh9Gx7MeNyc(entityMetadata5)] = current6.Value;
									num17 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
									{
										num17 = 1;
									}
									continue;
								case 2:
									break;
								case 5:
									if ((entityMetadata5 = current6.Value as EntityMetadata) != null)
									{
										num17 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
										{
											num17 = 0;
										}
										continue;
									}
									goto case 1;
								case 7:
									goto IL_06db;
								default:
									if (JxMDCnfaZexqZ3ZpjMAJ(entityMetadata5) == EntityMetadataType.InterfaceExtension)
									{
										num17 = 4;
										continue;
									}
									goto case 1;
								case 3:
									_003C_003Ec__DisplayClass48_.tempMetadataList[current6.Key] = current6.Value;
									num17 = 5;
									continue;
								case 1:
									GetRecursiveTablePartMetadata(current6.Value).ForEach(_003C_003Ec__DisplayClass48_._003CValidateMetadataReferences_003Eb__7);
									num17 = 2;
									continue;
								case 6:
									goto end_IL_0697;
								}
								break;
							}
							continue;
							IL_06db:
							current6 = enumerator.Current;
							num17 = 3;
							goto IL_0639;
							continue;
							end_IL_0697:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num18 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num18 = 0;
						}
						switch (num18)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				case 3:
					enumerator = _003C_003Ec__DisplayClass48_2.publishData.SoftPublishedMetadata.GetEnumerator();
					num2 = 9;
					continue;
				case 20:
					validationErrors = (ValidationError[])sUTohXfaVZMup1qONDks(list3);
					num2 = 19;
					continue;
				case 13:
					enumerator = _003C_003Ec__DisplayClass48_2.publishData.DeltaPublishedMetadata.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							int num11;
							if (!enumerator.MoveNext())
							{
								num11 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num11 = 2;
								}
								goto IL_083a;
							}
							goto IL_091b;
							IL_091b:
							current4 = enumerator.Current;
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num11 = 1;
							}
							goto IL_083a;
							IL_083a:
							while (true)
							{
								int num12;
								switch (num11)
								{
								case 4:
									_003C_003Ec__DisplayClass48_3.publishExtensionsMetadataList[atZvhUfauvh9Gx7MeNyc(entityMetadata3)] = current4.Value;
									num11 = 6;
									continue;
								case 5:
									break;
								case 1:
									_003C_003Ec__DisplayClass48_3.tempMetadataList[current4.Key] = current4.Value;
									num11 = 3;
									continue;
								default:
									if (JxMDCnfaZexqZ3ZpjMAJ(entityMetadata3) == EntityMetadataType.InterfaceExtension)
									{
										num12 = 4;
										goto IL_0836;
									}
									goto case 6;
								case 3:
									if ((entityMetadata3 = current4.Value as EntityMetadata) != null)
									{
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
										{
											num11 = 0;
										}
										continue;
									}
									goto case 6;
								case 7:
									goto IL_091b;
								case 6:
									GetRecursiveTablePartMetadata(current4.Value).ForEach(_003C_003Ec__DisplayClass48_3._003CValidateMetadataReferences_003Eb__4);
									num12 = 5;
									goto IL_0836;
								case 2:
									goto end_IL_0888;
									IL_0836:
									num11 = num12;
									continue;
								}
								break;
							}
							continue;
							end_IL_0888:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 29:
					enumerator = _003C_003Ec__DisplayClass48_2.publishData.SoftPublishedMetadata.GetEnumerator();
					num2 = 2;
					continue;
				case 10:
					enumerator = _003C_003Ec__DisplayClass48_2.publishData.RestartNeededMetadata.GetEnumerator();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 25;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_2();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass48_2.publishData = publishData;
					num2 = 22;
					continue;
				case 19:
					throw new MetadataValidationException(ValidationErrorHelper.GetMessage(validationErrors), validationErrors);
				case 27:
					enumerator2 = _003C_003Ec__DisplayClass48_2.publishData.RestartNeededMetadata.Values.OfType<EntityMetadata>().GetEnumerator();
					num2 = 14;
					continue;
				case 26:
					_003C_003Ec__DisplayClass48_3.publishExtensionsMetadataList = new Dictionary<Guid, IRootMetadata>();
					num2 = 29;
					continue;
				case 2:
					try
					{
						while (true)
						{
							int num9;
							if (!enumerator.MoveNext())
							{
								num9 = 4;
								goto IL_0af3;
							}
							goto IL_0c03;
							IL_0af3:
							while (true)
							{
								switch (num9)
								{
								case 1:
									if ((entityMetadata2 = current3.Value as EntityMetadata) == null)
									{
										num9 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
										{
											num9 = 5;
										}
										continue;
									}
									goto case 6;
								case 7:
									_003C_003Ec__DisplayClass48_3.tempMetadataList[current3.Key] = current3.Value;
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
									{
										num9 = 1;
									}
									continue;
								case 6:
									if (JxMDCnfaZexqZ3ZpjMAJ(entityMetadata2) == EntityMetadataType.InterfaceExtension)
									{
										num9 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
										{
											num9 = 2;
										}
										continue;
									}
									goto case 3;
								case 2:
									_003C_003Ec__DisplayClass48_3.publishExtensionsMetadataList[atZvhUfauvh9Gx7MeNyc(entityMetadata2)] = current3.Value;
									num9 = 3;
									continue;
								case 8:
									goto IL_0c03;
								case 3:
								case 5:
									GetRecursiveTablePartMetadata(current3.Value).ForEach(_003C_003Ec__DisplayClass48_3._003CValidateMetadataReferences_003Eb__3);
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
									{
										num9 = 0;
									}
									continue;
								case 4:
									goto end_IL_0ba2;
								}
								break;
							}
							continue;
							IL_0c03:
							current3 = enumerator.Current;
							num9 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num9 = 7;
							}
							goto IL_0af3;
							continue;
							end_IL_0ba2:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 13;
				case 6:
					list = _003C_003Ec__DisplayClass48_2.publishData.DeltaPublishedMetadata.Values.OfType<EntityMetadata>().Where(_003C_003Ec__DisplayClass48_3._003CValidateMetadataReferences_003Eb__1).ToList();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 21;
					}
					continue;
				case 5:
					if (source.Any())
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 28;
						}
						continue;
					}
					return;
				case 8:
					if (Qci5cSfaIvImRXfnasdn(list3) <= 0)
					{
						source = _003C_003Ec__DisplayClass48_2.publishData.DeltaPublishedMetadata.Values.OfType<EntityMetadata>().Where(_003C_003Ec__DisplayClass48_._003CValidateMetadataReferences_003Eb__5);
						num2 = 5;
						continue;
					}
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 4;
					}
					continue;
				case 24:
					list3 = new List<ValidationError>();
					num2 = 27;
					continue;
				case 7:
					_003C_003Ec__DisplayClass48_.tempMetadataList = new Dictionary<Guid, IRootMetadata>(dictionary);
					num2 = 15;
					continue;
				case 16:
					_003C_003Ec__DisplayClass48_3 = new _003C_003Ec__DisplayClass48_1();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					dictionary = ((IMetadataService)S0v839fa8E74PcnDqO2c()).GetMetadataList().OfType<IRootMetadata>().ToDictionary((IRootMetadata m) => _003C_003Ec.vtjCHZZbzL3q8S9hb7I3(m));
					num2 = 16;
					continue;
				case 21:
					list2 = list;
					action = _003C_003Ec__DisplayClass48_2._003CValidateMetadataReferences_003Eb__2;
					break;
				case 28:
					throw new Exception(SR.T((string)BaDoFSfp0Y3o0kH3tZnG(-2099751081 ^ -2099444817), string.Join((string)BaDoFSfp0Y3o0kH3tZnG(0x1ECE530A ^ 0x1ECE1A28), source.Select((EntityMetadata md) => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87480509), _003C_003Ec.DDJ3kLZhWySKomM4jMnT(md), _003C_003Ec.lFdYGLZhoHvvp9vDrtQr(md))))));
				}
				break;
			}
			list2.ForEach(action);
			num = 30;
		}
	}

	private static IEnumerable<TablePartMetadata> GetRecursiveTablePartMetadata(object metadata)
	{
		if (metadata is EntityMetadata entityMetadata)
		{
			List<TablePartMetadata> list = new List<TablePartMetadata>();
			list.AddRange(entityMetadata.TableParts);
			list.AddRange(entityMetadata.TableParts.SelectMany((TablePartMetadata tablePart) => GetRecursiveTablePartMetadata(tablePart)));
			return list;
		}
		return Enumerable.Empty<TablePartMetadata>();
	}

	private static IEnumerable<ValidationError> ValidateMetadataReferences(object metadata, IDictionary<Guid, IRootMetadata> metadataList, IDictionary<Guid, IRootMetadata> publishExtensionsMetadataList)
	{
		List<ValidationError> list = new List<ValidationError>();
		foreach (PropertyMetadata property in ((ClassMetadata)metadata).Properties)
		{
			_003C_003Ec__DisplayClass50_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass50_0();
			if ((CS_0024_003C_003E8__locals0.settings = property.Settings as EntitySettings) != null)
			{
				if (!metadataList.TryGetValue(property.SubTypeUid, out var value))
				{
					list.Add(new ValidationError
					{
						OwnerUid = ((AbstractMetadata)metadata).Uid,
						ElementUid = property.SubTypeUid,
						ElementTypeUid = ValidationElementType.Property,
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A43141), property.Name)
					});
				}
				if ((CS_0024_003C_003E8__locals0.settings.RelationType == RelationType.ManyToManyInverse || CS_0024_003C_003E8__locals0.settings.RelationType == RelationType.OneToMany) && value is EntityMetadata entityMetadata && entityMetadata.Properties.All((PropertyMetadata p) => _003C_003Ec__DisplayClass50_0.NXClnCZEBPs6mNmusDmB(_003C_003Ec__DisplayClass50_0.TTIXwZZGzGLRtPEbhZcq(p), _003C_003Ec__DisplayClass50_0.lp0uyRZEFC8lKi1nLXM3(CS_0024_003C_003E8__locals0.settings))) && (!publishExtensionsMetadataList.TryGetValue(property.SubTypeUid, out var value2) || ((EntityMetadata)value2).Properties.All((PropertyMetadata p) => p.Uid != _003C_003Ec__DisplayClass50_0.lp0uyRZEFC8lKi1nLXM3(CS_0024_003C_003E8__locals0.settings))) && (!metadataList.TryGetValue(entityMetadata.ImplementationUid, out var value3) || ((EntityMetadata)value3).Properties.All((PropertyMetadata p) => _003C_003Ec__DisplayClass50_0.NXClnCZEBPs6mNmusDmB(_003C_003Ec__DisplayClass50_0.TTIXwZZGzGLRtPEbhZcq(p), CS_0024_003C_003E8__locals0.settings.KeyColumnUid))))
				{
					list.Add(new ValidationError
					{
						OwnerUid = ((AbstractMetadata)metadata).Uid,
						ElementUid = property.SubTypeUid,
						ElementTypeUid = ValidationElementType.Property,
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475551417))
					});
				}
			}
		}
		foreach (TablePartMetadata tablePart in ((EntityMetadata)metadata).TableParts)
		{
			list.AddRange(ValidateMetadataReferences(tablePart, metadataList, publishExtensionsMetadataList));
		}
		return list;
	}

	private void CreatePublishingItem(IMetadataItem item, string tag, string comment, PublishData publishData, IDictionary<Guid, IRootMetadata> metadataRuntime, List<IMetadata> metadataToExtend)
	{
		IRootMetadata rootMetadata = ClassSerializationHelper.CloneObjectByXml(item.Metadata) as IRootMetadata;
		using (new MetadataServiceContext(new ExtendedMetadataService(MetadataServiceContext.Service, metadataToExtend)))
		{
			foreach (IPublicationHandler publicationHandler in publicationHandlers)
			{
				publicationHandler.UpdateMetadata(rootMetadata);
			}
		}
		IDeltaRootMetadata deltaRootMetadata = rootMetadata as IDeltaRootMetadata;
		metadataRuntime.TryGetValue(item.Header.Uid, out var value);
		if (rootMetadata != null)
		{
			if (value == null)
			{
				if (!dynamicPublicationService.Enable || MetadataServiceContext.MetadataRuntimeService.ConfigurationScriptsRecompileRequired)
				{
					publishData.DeltaPublishedMetadata[rootMetadata.Uid] = rootMetadata;
				}
				else if (deltaRootMetadata != null)
				{
					if (MetadataSoftPublishHelper.GetPublicationTypeOnCreate(rootMetadata) != PublicationType.Restart)
					{
						publishData.DeltaPublishedMetadata[rootMetadata.Uid] = rootMetadata;
					}
					else
					{
						publishData.RestartNeededMetadata[rootMetadata.Uid] = rootMetadata;
					}
				}
				else
				{
					publishData.RestartNeededMetadata[rootMetadata.Uid] = rootMetadata;
				}
			}
			else
			{
				IDeltaRootMetadata deltaRootMetadata2 = value as IDeltaRootMetadata;
				if (deltaRootMetadata == null || deltaRootMetadata2 == null)
				{
					if (!value.IsRestartNeeded(rootMetadata))
					{
						publishData.SoftPublishedMetadata[rootMetadata.Uid] = rootMetadata;
					}
					else if (!dynamicPublicationService.Enable || MetadataServiceContext.MetadataRuntimeService.ConfigurationScriptsRecompileRequired)
					{
						publishData.DeltaPublishedMetadata[rootMetadata.Uid] = rootMetadata;
					}
					else
					{
						publishData.RestartNeededMetadata[rootMetadata.Uid] = rootMetadata;
					}
				}
				else
				{
					switch (MetadataSoftPublishHelper.GetPublicationTypeOnChange(deltaRootMetadata2, rootMetadata))
					{
					case PublicationType.Soft:
						publishData.SoftPublishedMetadata[rootMetadata.Uid] = rootMetadata;
						break;
					case PublicationType.Delta:
						publishData.DeltaPublishedMetadata[rootMetadata.Uid] = rootMetadata;
						break;
					case PublicationType.Restart:
						if (dynamicPublicationService.Enable && !MetadataServiceContext.MetadataRuntimeService.ConfigurationScriptsRecompileRequired)
						{
							publishData.RestartNeededMetadata[rootMetadata.Uid] = rootMetadata;
							break;
						}
						goto case PublicationType.Delta;
					}
				}
			}
		}
		IMetadataItem metadataItem = metadataItemManager.Value.Create();
		metadataItem.Uid = Guid.NewGuid();
		metadataItem.Metadata = rootMetadata;
		metadataItem.CreationDate = item.CreationDate;
		metadataItem.CreationAuthorId = item.CreationAuthorId;
		metadataItem.Header = item.Header;
		metadataItem.Comment = comment;
		metadataItem.Header.Tag = tag;
		using (MetadataServiceContext.Extend(metadataToExtend))
		{
			foreach (IPublicationHandler publicationHandler2 in publicationHandlers)
			{
				publicationHandler2.UpdateMetadataItem(item, metadataItem);
			}
			if (workWithFormDependenciesService.IsActive() && rootMetadata is EntityMetadata metadata)
			{
				entityMetadataDependencyService.CollectDependencies(metadata, item.Header.Current);
			}
		}
		Session.Save((object)metadataItem);
		item.Header.Published = metadataItem;
		item.Header.IsDirtyItem = false;
		item.Header.Save();
		publishData.MetadataItems.Add(metadataItem);
	}

	private void PublishFinished(MetadataPublishedEventArgs eventArgs)
	{
		//Discarded unreachable code: IL_024d, IL_025c, IL_0390, IL_040c, IL_044c, IL_045b, IL_0467
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_2 = default(_003C_003Ec__DisplayClass52_0);
		_003C_003Ec__DisplayClass52_1 _003C_003Ec__DisplayClass52_ = default(_003C_003Ec__DisplayClass52_1);
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		while (true)
		{
			switch (num2)
			{
			case 11:
				_003C_003Ec__DisplayClass52_2.eventArgs = eventArgs;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 3;
				}
				break;
			case 10:
				if (AfHtJSfaSh4pvQjCC9ej(_003C_003Ec__DisplayClass52_2.eventArgs.PublishResult) != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 9:
				return;
			case 8:
				_003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_1();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				try
				{
					Ic8mZYfpm7pLAh7eYV5s(publishLogger, BaDoFSfp0Y3o0kH3tZnG(-210725949 ^ -210385475));
					int num3 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num3 = 11;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							return;
						case 11:
							b2x7NsfaRZReskSvmQ9I(securityService.Value, new Action(_003C_003Ec__DisplayClass52_2._003CPublishFinished_003Eb__2));
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num3 = 9;
							}
							break;
						case 9:
							publishLogger.Debug(BaDoFSfp0Y3o0kH3tZnG(-1751176224 ^ -1751483046));
							num3 = 2;
							break;
						default:
							if (SpvmekfaQnJVlSiTbEj7(_003C_003Ec__DisplayClass52_2.eventArgs.DeltaPublishedMetadata) > 0)
							{
								num3 = 10;
								break;
							}
							goto case 4;
						case 7:
							Iv0dHafaO1ppTaT7aflo(svdZDIfaXm0vt2uIf7ca(runtimeApplication.ApplicationStartCache, uMDa0nfaKvKQ2Fph7GXo(BaDoFSfp0Y3o0kH3tZnG(-477139494 ^ -477141058), false)), ysDFoDfanGY1rNvCJDyu(K0FHKffakPkTcDf86alK(jIVWHkfaTr9OQRYYISrd(pKIe6wfaqLO74Kawet8G(_003C_003Ec__DisplayClass52_2.eventArgs)))));
							num3 = 8;
							break;
						case 10:
							Ic8mZYfpm7pLAh7eYV5s(publishLogger, BaDoFSfp0Y3o0kH3tZnG(0x4EDCBA32 ^ 0x4ED9ECCA));
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num3 = 0;
							}
							break;
						case 6:
							Ic8mZYfpm7pLAh7eYV5s(publishLogger, BaDoFSfp0Y3o0kH3tZnG(-1886646897 ^ -1886823745));
							num3 = 3;
							break;
						case 12:
							kS2Yt2fa2KrqD8JAylHI(runtimeApplication.ApplicationStartCache);
							num3 = 4;
							break;
						case 2:
							metadataRuntimeService.Value.GetAssemblyModelsMetadataList().Where(_003C_003Ec__DisplayClass52_2._003CPublishFinished_003Eb__3).ForEach(_003C_003Ec__DisplayClass52_2._003CPublishFinished_003Eb__4);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num3 = 1;
							}
							break;
						case 8:
							Iv0dHafaO1ppTaT7aflo(svdZDIfaXm0vt2uIf7ca(runtimeApplication.ApplicationStartCache, uMDa0nfaKvKQ2Fph7GXo(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583742758), false)), ysDFoDfanGY1rNvCJDyu(K0FHKffakPkTcDf86alK(((MetadataAssemblyPublishResult)pKIe6wfaqLO74Kawet8G(_003C_003Ec__DisplayClass52_2.eventArgs)).DynamicAssembly)));
							num3 = 12;
							break;
						case 4:
						case 5:
						{
							KkbQcSfaeh2C3eDN9uIE(unitOfWork);
							int num4 = 6;
							num3 = num4;
							break;
						}
						case 1:
							if (((MetadataAssemblyPublishResult)pKIe6wfaqLO74Kawet8G(_003C_003Ec__DisplayClass52_2.eventArgs)).DynamicAssembly == null)
							{
								num3 = 5;
								break;
							}
							goto default;
						}
					}
				}
				catch (Exception ex)
				{
					int num5 = 2;
					while (true)
					{
						switch (num5)
						{
						case 2:
							publishLogger.Error(BCeKD3faPDSFy7tBmR23(ex), ex);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num5 = 1;
							}
							break;
						case 1:
							IPV0Zqfa1KFBwPZVfIdG(unitOfWork);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num5 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				finally
				{
					int num6;
					if (unitOfWork == null)
					{
						num6 = 2;
						goto IL_0410;
					}
					goto IL_0426;
					IL_0410:
					switch (num6)
					{
					default:
						goto end_IL_03fb;
					case 1:
						break;
					case 2:
						goto end_IL_03fb;
					case 0:
						goto end_IL_03fb;
					}
					goto IL_0426;
					IL_0426:
					NbhRh4fp9pcZgJLHtPab(unitOfWork);
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num6 = 0;
					}
					goto IL_0410;
					end_IL_03fb:;
				}
			case 3:
				yvZ0ExfaiRSUYuXeF0pR(new DbDeltaModelUpdater(_003C_003Ec__DisplayClass52_2.eventArgs.DeltaPublishedMetadata.OfType<EntityMetadata>().Select(_003C_003Ec__DisplayClass52_._003CPublishFinished_003Eb__1)), Session);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				Ic8mZYfpm7pLAh7eYV5s(publishLogger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979559297));
				num2 = 7;
				break;
			case 5:
				unitOfWork = unitOfWorkManager.Create("", transactional: true, IsolationLevel.ReadCommitted);
				num2 = 4;
				break;
			case 1:
				_003C_003Ec__DisplayClass52_2 = new _003C_003Ec__DisplayClass52_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass52_2._003C_003E4__this = this;
				num2 = 11;
				break;
			case 2:
				if (SpvmekfaQnJVlSiTbEj7(_003C_003Ec__DisplayClass52_2.eventArgs.DeltaPublishedMetadata) > 0)
				{
					num2 = 8;
					break;
				}
				goto case 5;
			case 7:
				_003C_003Ec__DisplayClass52_.metadataRuntime = publishedMetadata.OfType<EntityMetadata>().ToDictionary((EntityMetadata m) => _003C_003Ec.BGfD41ZhbvVaciNNAWFh(m));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object BaDoFSfp0Y3o0kH3tZnG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Ic8mZYfpm7pLAh7eYV5s(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static bool nZOJpmfpylYSIoU5LJpP(object P_0)
	{
		return ((IDynamicPublicationService)P_0).Enable;
	}

	internal static object vTLMjVfpMNNPmgYFlnNU(object P_0, object P_1)
	{
		return ((IEventHandlerSubscribeService)P_0).Subscribe((IEventHandler)P_1);
	}

	internal static object CNhprlfpJR56VHcSvmc5()
	{
		return Task.CompletedTask;
	}

	internal static bool GQim44fp7wury7w85TU6()
	{
		return sjpvosfpA66fOdgSrIkN == null;
	}

	internal static PublicationActor J6OiRofpxWZZe6GZakpv()
	{
		return sjpvosfpA66fOdgSrIkN;
	}

	internal static void NbhRh4fp9pcZgJLHtPab(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static AsyncTaskMethodBuilder psnbbpfpdMlTuWb2vEQN()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static void ebFpZNfplMPVeUHOmAfQ(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static int I9mtQufprG1ZIiEFGDjx(object P_0)
	{
		return ((HashSet<Guid>)P_0).Count;
	}

	internal static object T1BBLIfpgXNoReaASXEi(Type P_0)
	{
		return DetachedCriteria.For(P_0);
	}

	internal static object jwoNeGfp5hxmvpXWdOrm(object P_0, object P_1, object P_2)
	{
		return ((DetachedCriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object iN5TgdfpjiDJqHotjxFy(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object FabUvKfpYg1HkGAAmjoU(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).SetProjection((IProjection)P_1);
	}

	internal static object LisvgmfpLq15lOyOspvO(object P_0, object P_1)
	{
		return Subqueries.PropertyIn((string)P_0, (DetachedCriteria)P_1);
	}

	internal static object BWUctNfpUUKqdQryZKgd(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool JBybaTfpsjpmgMWHCVOe(object P_0)
	{
		return ((PublishData)P_0).OnlySoftPublished();
	}

	internal static Type MRbA6EfpcFOKsJVdGjQm(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Pv0bQOfpzl4niI4MiJNP(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object vGqWd4faFfls9kCe1Im9(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object QcZEC1faBJW0El6bmCZf(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object jJ5K2XfaWLEAyb916ZKG(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object qmpQGGfaotI2jqJplgTn(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object Tqmexlfab8g14GIlrp8e(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static object maOl3efahXEcsF5riZAa(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).RestoreMetadata();
	}

	internal static int gVm3UAfaGxV9ObDjq591(object P_0)
	{
		return ((Dictionary<Guid, IRootMetadata>)P_0).Count;
	}

	internal static void DcFPHEfaEXoe1oSG4xMI(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).Name = (string)P_1;
	}

	internal static void uDKBdufafsG201uFbbgq(object P_0, AssemblyModelsMetadataStatus value)
	{
		((AssemblyModelsMetadata)P_0).Status = value;
	}

	internal static int SpvmekfaQnJVlSiTbEj7(object P_0)
	{
		return ((ICollection<IRootMetadata>)P_0).Count;
	}

	internal static object oXM82FfaCjwug51Njp6Z(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static void bHdOpJfavdcOkdeZTSxl(object P_0, object P_1)
	{
		((ISession)P_0).Delete(P_1);
	}

	internal static object S0v839fa8E74PcnDqO2c()
	{
		return MetadataServiceContext.MetadataRuntimeService;
	}

	internal static EntityMetadataType JxMDCnfaZexqZ3ZpjMAJ(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid atZvhUfauvh9Gx7MeNyc(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static int Qci5cSfaIvImRXfnasdn(object P_0)
	{
		return ((List<ValidationError>)P_0).Count;
	}

	internal static object sUTohXfaVZMup1qONDks(object P_0)
	{
		return ((List<ValidationError>)P_0).ToArray();
	}

	internal static object AfHtJSfaSh4pvQjCC9ej(object P_0)
	{
		return ((MetadataAssemblyPublishResult)P_0).DynamicAssembly;
	}

	internal static void yvZ0ExfaiRSUYuXeF0pR(object P_0, object P_1)
	{
		((DbDeltaModelUpdater)P_0).Update((ISession)P_1);
	}

	internal static void b2x7NsfaRZReskSvmQ9I(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunBySystemUser((Action)P_1);
	}

	internal static object pKIe6wfaqLO74Kawet8G(object P_0)
	{
		return ((MetadataPublishedEventArgs)P_0).PublishResult;
	}

	internal static object uMDa0nfaKvKQ2Fph7GXo(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static object svdZDIfaXm0vt2uIf7ca(object P_0, object P_1)
	{
		return ((ApplicationStartCache)P_0).GetAssemblyInfo((Assembly)P_1);
	}

	internal static object jIVWHkfaTr9OQRYYISrd(object P_0)
	{
		return ((MetadataAssemblyPublishResult)P_0).ConfigurationAssembly;
	}

	internal static object K0FHKffakPkTcDf86alK(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).AssemblyRawStream;
	}

	internal static object ysDFoDfanGY1rNvCJDyu(object P_0)
	{
		return AssemblyInfoCache.EvaluateHashCode((Stream)P_0);
	}

	internal static void Iv0dHafaO1ppTaT7aflo(object P_0, object P_1)
	{
		((AssemblyInfoCache)P_0).HashCode = (string)P_1;
	}

	internal static void kS2Yt2fa2KrqD8JAylHI(object P_0)
	{
		((ApplicationStartCache)P_0).Save();
	}

	internal static void KkbQcSfaeh2C3eDN9uIE(object P_0)
	{
		((IUnitOfWork)P_0).Commit();
	}

	internal static object BCeKD3faPDSFy7tBmR23(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void IPV0Zqfa1KFBwPZVfIdG(object P_0)
	{
		((IUnitOfWork)P_0).Rollback();
	}

	internal static object xVOjKRfaNGdOn3yD63Y7(object P_0, Guid publicationToken)
	{
		return ((IServerInstanceActor)P_0).PublicationComplete(publicationToken);
	}

	internal static object rpG2hHfa33LIjFe2h3y2(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}
}
