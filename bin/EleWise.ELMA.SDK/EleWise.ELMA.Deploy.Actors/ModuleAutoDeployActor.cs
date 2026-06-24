using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Actors;

internal sealed class ModuleAutoDeployActor : Actor, IModuleAutoDeployActor, IActorWithGuidKey, IActor
{
	private readonly IModuleFileDeployService moduleFileDeployService;

	private readonly ISecurityServiceAsync securityService;

	private ModuleDeployDirectoryWatcher watcher;

	private static ModuleAutoDeployActor vqsIstEzhHMyXnSZk1Dh;

	public override TimeSpan LifeTime { get; }

	public ModuleAutoDeployActor(IModuleFileDeployService moduleFileDeployService, ISecurityServiceAsync securityService)
	{
		//Discarded unreachable code: IL_0043, IL_0048
		nCxTGZEzfJk2uPaVoFo3();
		LifeTime = wlv7RjEzQqlGl4m2cshM(365.0);
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.securityService = securityService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				this.moduleFileDeployService = moduleFileDeployService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public Task StartWatching()
	{
		return (Task)rEBUNNEzCNiuTRM7qRma();
	}

	public override Task OnActivateAsync()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				watcher = new ModuleDeployDirectoryWatcher(moduleFileDeployService, securityService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (Task)rEBUNNEzCNiuTRM7qRma();
			default:
				w9UURgEzvKtyQSVN0Sq2(watcher);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void nCxTGZEzfJk2uPaVoFo3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static TimeSpan wlv7RjEzQqlGl4m2cshM(double P_0)
	{
		return TimeSpan.FromDays(P_0);
	}

	internal static bool MCis3mEzGQ6oNjCaIwuu()
	{
		return vqsIstEzhHMyXnSZk1Dh == null;
	}

	internal static ModuleAutoDeployActor LlYKulEzEkUVNRusX2ch()
	{
		return vqsIstEzhHMyXnSZk1Dh;
	}

	internal static object rEBUNNEzCNiuTRM7qRma()
	{
		return Task.CompletedTask;
	}

	internal static void w9UURgEzvKtyQSVN0Sq2(object P_0)
	{
		((ModuleDeployDirectoryWatcher)P_0).Init();
	}
}
