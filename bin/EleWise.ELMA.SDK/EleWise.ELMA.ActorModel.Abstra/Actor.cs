using System;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ActorModel.Abstractions;

public abstract class Actor : IActor
{
	private static readonly TimeSpan DefaultCollectionAge;

	private IActorModelProvider actorModelProvider;

	private static Actor OxNtFvfD0BCVLU5cEVqZ;

	public virtual TimeSpan LifeTime { get; }

	public void Initialize(IActorModelProvider actorModelProvider)
	{
		//Discarded unreachable code: IL_0073, IL_0082
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				throw new InvalidOperationException(SR.T((string)mvmN3JfDMGDcmknRuJxh(0x18A6761F ^ 0x18A321D5)));
			default:
				this.actorModelProvider = actorModelProvider;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				if (this.actorModelProvider == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public virtual Task OnActivateAsync()
	{
		return (Task)rnsqX4fDJmhtK0p2FPCh();
	}

	public virtual Task OnDeactivateAsync()
	{
		return (Task)rnsqX4fDJmhtK0p2FPCh();
	}

	public virtual Task ReceiveReminder(string reminderName)
	{
		return (Task)rnsqX4fDJmhtK0p2FPCh();
	}

	protected TKey GetPrimaryKey<TKey>()
	{
		return (TKey)actorModelProvider.GetPrimaryKey();
	}

	protected Task RegisterOrUpdateReminder(string reminderName, TimeSpan dueTime, TimeSpan period)
	{
		return (Task)XcjamwfD9wGiLKt4x8iq(actorModelProvider, reminderName, dueTime, period);
	}

	protected Task UnregisterReminder(string reminderName)
	{
		return actorModelProvider.UnregisterReminder(reminderName);
	}

	protected IDisposable RegisterTimer(Func<object, Task> asyncCallback, object state, TimeSpan dueTime, TimeSpan period)
	{
		return actorModelProvider.RegisterTimer(asyncCallback, state, dueTime, period);
	}

	protected Task RunExternalTask(Func<Task> action)
	{
		return actorModelProvider.RunExternalTask(action);
	}

	protected Task<TResult> RunExternalTask<TResult>(Func<Task<TResult>> action)
	{
		return actorModelProvider.RunExternalTask(action);
	}

	protected void DelayDeactivation(TimeSpan timeSpan)
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
				actorModelProvider.DelayDeactivation(timeSpan);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected void DeactivateOnIdle()
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
				xSZex3fDdBce6kGmsG5R(actorModelProvider);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected Actor()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		LifeTime = DefaultCollectionAge;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Actor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				DefaultCollectionAge = uppAOKfDl8vRcZ5F9DgK(10.0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object mvmN3JfDMGDcmknRuJxh(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool ivKPx8fDmrwlauQVDtiI()
	{
		return OxNtFvfD0BCVLU5cEVqZ == null;
	}

	internal static Actor SuQfXIfDyhsVQgGr9GS1()
	{
		return OxNtFvfD0BCVLU5cEVqZ;
	}

	internal static object rnsqX4fDJmhtK0p2FPCh()
	{
		return Task.CompletedTask;
	}

	internal static object XcjamwfD9wGiLKt4x8iq(object P_0, object P_1, TimeSpan dueTime, TimeSpan period)
	{
		return ((IActorModelProvider)P_0).RegisterOrUpdateReminder((string)P_1, dueTime, period);
	}

	internal static void xSZex3fDdBce6kGmsG5R(object P_0)
	{
		((IActorModelProvider)P_0).DeactivateOnIdle();
	}

	internal static TimeSpan uppAOKfDl8vRcZ5F9DgK(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}
}
