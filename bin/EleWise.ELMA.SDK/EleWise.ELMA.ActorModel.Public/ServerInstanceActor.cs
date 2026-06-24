using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ActorModel.Publication;

internal sealed class ServerInstanceActor : Actor, IServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly ILazy<MetadataItemManager> metadataItemManager;

	private readonly IPublicationEventHandler publicationEventHandler;

	private TaskCompletionSource<bool> waitPublication;

	internal static ServerInstanceActor M2sbqHfapGo9KjDugNS2;

	public override TimeSpan LifeTime { get; }

	public ServerInstanceActor(IActorModelRuntime actorModelRuntime, IRuntimeApplication runtimeApplication, ILazy<MetadataItemManager> metadataItemManager, IPublicationEventHandler publicationEventHandler)
	{
		SingletonReader.JJCZtPuTvSt();
		LifeTime = TimeSpan.FromDays(365.0);
		base._002Ector();
		this.actorModelRuntime = actorModelRuntime;
		this.runtimeApplication = runtimeApplication;
		this.metadataItemManager = metadataItemManager;
		this.publicationEventHandler = publicationEventHandler;
	}

	public Task DeltaPublicationStart(MetadataAssemblyPublishResult result, Guid[] softPublished, Guid[] deltaPublished, AssemblyModelsMetadata restartNeeded)
	{
		//Discarded unreachable code: IL_00e8, IL_00f7
		int num = 7;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 10:
					waitPublication = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
					num2 = 9;
					continue;
				case 7:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass9_.deltaPublished = deltaPublished;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return (Task)yrXr3BfawEiosKWved88();
				case 2:
					_003C_003Ec__DisplayClass9_.softPublished = softPublished;
					num2 = 4;
					continue;
				case 3:
					_003C_003Ec__DisplayClass9_.restartNeeded = restartNeeded;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (W3g8u0fatD5jnUuoVW2k(runtimeApplication))
					{
						if (waitPublication == null)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num2 = 10;
							}
							continue;
						}
						goto case 11;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					YgJJHVfaHoFljpBFuuJr(waitPublication, new Exception((string)W8eipAfa6QJ8cOHNXMCy(j7CtNufa4m66JhbCRAGw(-1822890472 ^ -1822576240))));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 5;
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				case 9:
					return actorModelRuntime.GetActor<IPublicationActor>(Guid.Empty).Wait(JFlqrpfaAwt05vjEWbpK(runtimeApplication)).ContinueWith(_003C_003Ec__DisplayClass9_._003CDeltaPublicationStart_003Eb__0, TaskContinuationOptions.RunContinuationsAsynchronously | TaskContinuationOptions.NotOnFaulted);
				}
				break;
			}
			_003C_003Ec__DisplayClass9_.result = result;
			num = 2;
		}
	}

	public Task DeltaPublicationComplete()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Task.CompletedTask;
			case 1:
			{
				TaskCompletionSource<bool> taskCompletionSource = waitPublication;
				if (taskCompletionSource == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
				taskCompletionSource.TrySetResult(result: true);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	public Task PublicationComplete(Guid publicationToken)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				publicationEventHandler.Complete(publicationToken);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (Task)yrXr3BfawEiosKWved88();
			}
		}
	}

	public Task PublicationError(Guid publicationToken, Exception exception)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				BDHNGlfaxGxbBS9HZpdU(publicationEventHandler, publicationToken, exception);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return (Task)yrXr3BfawEiosKWved88();
			case 1:
			{
				TaskCompletionSource<bool> taskCompletionSource = waitPublication;
				if (taskCompletionSource == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
				RIngfZfa7aIvb8Po1keo(taskCompletionSource, exception);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 2;
				}
				break;
			}
			}
		}
	}

	public Task Deactivate()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				DeactivateOnIdle();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Task.CompletedTask;
			}
		}
	}

	internal static bool W3g8u0fatD5jnUuoVW2k(object P_0)
	{
		return ((IRuntimeApplication)P_0).IsStarted;
	}

	internal static object yrXr3BfawEiosKWved88()
	{
		return Task.CompletedTask;
	}

	internal static object j7CtNufa4m66JhbCRAGw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object W8eipAfa6QJ8cOHNXMCy(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool YgJJHVfaHoFljpBFuuJr(object P_0, object P_1)
	{
		return ((TaskCompletionSource<bool>)P_0).TrySetException((Exception)P_1);
	}

	internal static Guid JFlqrpfaAwt05vjEWbpK(object P_0)
	{
		return ((IRuntimeApplication)P_0).ConnectionUid;
	}

	internal static bool Ovhv1NfaabN0wuHT43rX()
	{
		return M2sbqHfapGo9KjDugNS2 == null;
	}

	internal static ServerInstanceActor YAVxG6faDTYs99OR430k()
	{
		return M2sbqHfapGo9KjDugNS2;
	}

	internal static bool RIngfZfa7aIvb8Po1keo(object P_0, object P_1)
	{
		return ((TaskCompletionSource<bool>)P_0).TrySetException((Exception)P_1);
	}

	internal static void BDHNGlfaxGxbBS9HZpdU(object P_0, Guid publicationToken, object P_2)
	{
		((IPublicationEventHandler)P_0).Error(publicationToken, (Exception)P_2);
	}
}
