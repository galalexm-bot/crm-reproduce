using System;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Actors;

internal class UpdateUserSecuritySetCacheQueueManagerActor : Actor, IUpdateUserSecuritySetCacheQueueManagerActor, IActorWithIntegerKey, IActor
{
	[Component(Type = ComponentType.Server)]
	private sealed class ModuleAutoDeployActorInitHandler : IActorInitHandler
	{
		internal static object QSELAYpJXefA3RRt5Cmn;

		public Task Init(IActorModelRuntime actorModelRuntime)
		{
			return (Task)rch4p7pJ7PTEl3vyf5kI(actorModelRuntime.GetActor<IUpdateUserSecuritySetCacheQueueManagerActor>(0L));
		}

		public ModuleAutoDeployActorInitHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ERypT8pJ6OU4m07BnYI0();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object rch4p7pJ7PTEl3vyf5kI(object P_0)
		{
			return ((IUpdateUserSecuritySetCacheQueueManagerActor)P_0).Start();
		}

		internal static bool AS351gpJnOGgm7NR01VX()
		{
			return QSELAYpJXefA3RRt5Cmn == null;
		}

		internal static ModuleAutoDeployActorInitHandler pR7igtpJieoWG0HQumJy()
		{
			return (ModuleAutoDeployActorInitHandler)QSELAYpJXefA3RRt5Cmn;
		}

		internal static void ERypT8pJ6OU4m07BnYI0()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}
	}

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly UpdateUserSecuritySetCacheQueueManager updateUserSecuritySetCacheQueueManager;

	private IDisposable timerDisposable;

	private string reminderName;

	private int executing;

	internal static UpdateUserSecuritySetCacheQueueManagerActor CTjNHjpkQPDJjJS5egOl;

	public UpdateUserSecuritySetCacheQueueManagerActor(IActorModelRuntime actorModelRuntime, UpdateUserSecuritySetCacheQueueManager updateUserSecuritySetCacheQueueManager)
	{
		//Discarded unreachable code: IL_0049, IL_004e
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		reminderName = Guid.NewGuid().ToString();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
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
				this.actorModelRuntime = actorModelRuntime;
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.updateUserSecuritySetCacheQueueManager = updateUserSecuritySetCacheQueueManager;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Task Start()
	{
		//Discarded unreachable code: IL_003f, IL_004e
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (Task)sD2SFkpkg6PQsaGK4xTh();
			case 1:
				return RegisterExecute(TimeSpan.Zero);
			case 2:
				if (timerDisposable == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public Task RegisterExecute(TimeSpan waitTimeSpan)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (reminderName != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto default;
				default:
					reminderName = XSrftYpk8Vhq1fF8ayWS().ToString();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return (Task)hdl60lpkyAjQsJgAQQwh(this, reminderName, waitTimeSpan, Ixo7vCpk3yBlQtFx5Rn6(1.0));
				case 2:
				case 4:
					timerDisposable = RegisterTimer(reminderName, waitTimeSpan);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
				case 5:
				{
					IDisposable disposable = timerDisposable;
					if (disposable == null)
					{
						num2 = 2;
						continue;
					}
					EngBNHpkrG8Xq38bSEKi(disposable);
					num = 4;
					break;
				}
				}
				break;
			}
		}
	}

	public override Task ReceiveReminder(string reminderName)
	{
		//Discarded unreachable code: IL_0055, IL_008f
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				timerDisposable = RegisterTimer(reminderName, TimeSpan.Zero);
				num2 = 4;
				break;
			case 5:
				if (!hCw04IpkbLYWVnC08HVD(reminderName, this.reminderName))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 1:
				if (timerDisposable == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 3:
				return (Task)IutJWopkSVGAUQgQ2thK(this, reminderName);
			case 2:
			case 4:
				return (Task)sD2SFkpkg6PQsaGK4xTh();
			}
		}
	}

	public Task TimerComplete(string reminderName)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					IDisposable disposable = timerDisposable;
					if (disposable == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						EngBNHpkrG8Xq38bSEKi(disposable);
						num2 = 2;
					}
					continue;
				}
				case 4:
					if (this.reminderName != null)
					{
						break;
					}
					goto case 1;
				default:
					return (Task)IutJWopkSVGAUQgQ2thK(this, reminderName);
				}
				break;
			}
			num = 3;
		}
	}

	private IDisposable RegisterTimer(string reminderName, TimeSpan dueTime)
	{
		return RegisterTimer(OnTimer, reminderName, dueTime, kAxN0npk9r5H633UtkQO(5.0));
	}

	private Task OnTimer(object state)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (Task)sD2SFkpkg6PQsaGK4xTh();
			default:
				RunExternalTask(_003C_003Ec__DisplayClass11_._003COnTimer_003Eb__0);
				num2 = 2;
				break;
			case 5:
				_003C_003Ec__DisplayClass11_.reminderName = (string)state;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				reminderName = null;
				num2 = 5;
				break;
			case 6:
				_003C_003Ec__DisplayClass11_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 6;
				break;
			case 4:
				if (Interlocked.Exchange(ref executing, 1) == 0)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	internal static bool iob9cYpkdVoTJAdkFRLT()
	{
		return CTjNHjpkQPDJjJS5egOl == null;
	}

	internal static UpdateUserSecuritySetCacheQueueManagerActor Y9K1u2pkT8Zm95kuiQs6()
	{
		return CTjNHjpkQPDJjJS5egOl;
	}

	internal static object sD2SFkpkg6PQsaGK4xTh()
	{
		return Task.CompletedTask;
	}

	internal static Guid XSrftYpk8Vhq1fF8ayWS()
	{
		return Guid.NewGuid();
	}

	internal static void EngBNHpkrG8Xq38bSEKi(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static TimeSpan Ixo7vCpk3yBlQtFx5Rn6(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static object hdl60lpkyAjQsJgAQQwh(object P_0, object P_1, TimeSpan P_2, TimeSpan P_3)
	{
		return ((Actor)P_0).RegisterOrUpdateReminder((string)P_1, P_2, P_3);
	}

	internal static bool hCw04IpkbLYWVnC08HVD(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object IutJWopkSVGAUQgQ2thK(object P_0, object P_1)
	{
		return ((Actor)P_0).UnregisterReminder((string)P_1);
	}

	internal static TimeSpan kAxN0npk9r5H633UtkQO(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}
}
