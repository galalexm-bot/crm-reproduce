using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading;

internal sealed class ElmaTasksPool : IDisposable
{
	private readonly Queue<Func<Task>> queue;

	private readonly string systemThreadTimeoutAppSettingsKey;

	private readonly string appSettingsKey;

	private readonly int minTasksCount;

	private int tasksCount;

	private bool dispose;

	internal static ElmaTasksPool RF6034BS9VCfR1q9HIYA;

	public ElmaTasksPool(string appSettingsKey, int minTasksCount)
	{
		//Discarded unreachable code: IL_003a
		VpY2s3BSr4INplL0Uaha();
		queue = new Queue<Func<Task>>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				tasksCount = 0;
				num = 4;
				break;
			case 5:
				this.minTasksCount = minTasksCount;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				Task.Run((Func<Task>)SystemDo);
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num = 6;
				}
				break;
			default:
				this.appSettingsKey = appSettingsKey;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 2;
				}
				break;
			case 3:
				systemThreadTimeoutAppSettingsKey = appSettingsKey + (string)EPsbIMBSgeia7QMMMjEt(-420743386 ^ -420811518);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num = 0;
				}
				break;
			case 1:
			{
				hY6EDaBS52qqkUFfUYOg(appSettingsKey, EPsbIMBSgeia7QMMMjEt(-1459557599 ^ -1459490523));
				int num2 = 3;
				num = num2;
				break;
			}
			case 6:
				return;
			}
		}
	}

	public void Push(Func<Task> taskFactory)
	{
		if (dispose)
		{
			throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218424344) + appSettingsKey + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3CF516));
		}
		lock (queue)
		{
			queue.Enqueue(taskFactory);
		}
		Task.Run((Func<Task>)Do);
	}

	public void Dispose()
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
				dispose = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal int GetTasksCount()
	{
		return tasksCount;
	}

	[AsyncStateMachine(typeof(_003CDo_003Ed__10))]
	private Task Do()
	{
		int num = 1;
		int num2 = num;
		_003CDo_003Ed__10 stateMachine = default(_003CDo_003Ed__10);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return stateMachine._003C_003Et__builder.Task;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				break;
			default:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CSystemDo_003Ed__11))]
	private Task SystemDo()
	{
		int num = 2;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CSystemDo_003Ed__11 stateMachine = default(_003CSystemDo_003Ed__11);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	internal static void VpY2s3BSr4INplL0Uaha()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object EPsbIMBSgeia7QMMMjEt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void hY6EDaBS52qqkUFfUYOg(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool HcbTJDBSdyipb4AqLtVp()
	{
		return RF6034BS9VCfR1q9HIYA == null;
	}

	internal static ElmaTasksPool vABP7FBSlqhxPoOsGfUn()
	{
		return RF6034BS9VCfR1q9HIYA;
	}
}
