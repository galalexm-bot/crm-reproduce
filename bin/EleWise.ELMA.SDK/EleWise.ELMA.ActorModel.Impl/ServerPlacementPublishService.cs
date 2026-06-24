using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel.Impl;

internal class ServerPlacementPublishService : IServerPlacementPublishService
{
	private readonly IRuntimeApplication runtimeApplication;

	private readonly IActorModelRuntime actorModelRuntime;

	internal static ServerPlacementPublishService Q51xiBfallU7cvHX9m1e;

	public ServerPlacementPublishService(IRuntimeApplication runtimeApplication, IActorModelRuntime actorModelRuntime)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.actorModelRuntime = actorModelRuntime;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.runtimeApplication = runtimeApplication;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Task Publish<T>(Func<T, Task> action, bool ignoreError, Action<Guid, Exception> errorAction) where T : IServerPlacementActor
	{
		_003C_003Ec__DisplayClass3_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0<T>();
		CS_0024_003C_003E8__locals0.action = action;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.errorAction = errorAction;
		CS_0024_003C_003E8__locals0.ignoreError = ignoreError;
		return Task.WhenAll(runtimeApplication.GetActiveConnectionUids().Select(delegate(Guid uid)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass3_0<T>._003C_003CPublish_003Eb__0_003Ed stateMachine = default(_003C_003Ec__DisplayClass3_0<T>._003C_003CPublish_003Eb__0_003Ed);
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			while (true)
			{
				switch (num2)
				{
				case 1:
					stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return stateMachine._003C_003Et__builder.Task;
				default:
					stateMachine.uid = uid;
					num2 = 6;
					break;
				case 6:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 3;
					}
					break;
				case 5:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					break;
				case 4:
					stateMachine._003C_003E1__state = -1;
					num2 = 5;
					break;
				}
			}
		}));
	}

	[AsyncStateMachine(typeof(_003CPublish_003Ed__4<, >))]
	public Task<IReadOnlyDictionary<Guid, TRes>> Publish<T, TRes>(Func<T, Task<TRes>> action, bool ignoreError, Action<Guid, Exception> errorAction) where T : IServerPlacementActor
	{
		_003CPublish_003Ed__4<T, TRes> stateMachine = default(_003CPublish_003Ed__4<T, TRes>);
		stateMachine._003C_003E4__this = this;
		stateMachine.action = action;
		stateMachine.ignoreError = ignoreError;
		stateMachine.errorAction = errorAction;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IReadOnlyDictionary<Guid, TRes>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IReadOnlyDictionary<Guid, TRes>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool eruMEtfari4cLiMi1qx3()
	{
		return Q51xiBfallU7cvHX9m1e == null;
	}

	internal static ServerPlacementPublishService v49F1sfagZr8VIHS3LyH()
	{
		return Q51xiBfallU7cvHX9m1e;
	}
}
