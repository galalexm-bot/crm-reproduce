using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Actors;

internal class ExternalMembershipImportManagerActor : Actor, IExternalMembershipImportManagerActor, IActorWithIntegerKey, IActor
{
	[Component(Type = ComponentType.Server)]
	private sealed class ModuleAutoDeployActorInitHandler : IActorInitHandler
	{
		internal static object xS2Yvjpo9IGZItQFVrnf;

		public Task Init(IActorModelRuntime actorModelRuntime)
		{
			return (Task)giNVQspoz0V9VGU0ouLs(actorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L));
		}

		public ModuleAutoDeployActorInitHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			HvBRS5pJkVrF3jpc64lT();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object giNVQspoz0V9VGU0ouLs(object P_0)
		{
			return ((IExternalMembershipImportManagerActor)P_0).Start();
		}

		internal static bool j5lTDNpofacV4ZWXZjMO()
		{
			return xS2Yvjpo9IGZItQFVrnf == null;
		}

		internal static ModuleAutoDeployActorInitHandler HtST1Upo1lXPQ7jQgacO()
		{
			return (ModuleAutoDeployActorInitHandler)xS2Yvjpo9IGZItQFVrnf;
		}

		internal static void HvBRS5pJkVrF3jpc64lT()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}
	}

	private readonly ExternalMembershipImportManager externalMembershipImportManager;

	private IDisposable timerDisposer;

	internal static ExternalMembershipImportManagerActor QXLt8IpkJBtqJjHSuNFK;

	public ExternalMembershipImportManagerActor(ExternalMembershipImportManager externalMembershipImportManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SHMBW3pkhe7hGRbp4B9I();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.externalMembershipImportManager = externalMembershipImportManager;
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 != 0)
			{
				num = 0;
			}
		}
	}

	public Task Start()
	{
		return (Task)Ae5m0fpkGLAQJYj1CJfF(new Task[2]
		{
			RegisterOrUpdateReminder((string)D1A4mXpkOmf17WFsJOO6(0x4CD4C8A0 ^ 0x4CD5EB7A), TcfOd7pkqKgi7n5Dte7J(1.0), TcfOd7pkqKgi7n5Dte7J(1.0)),
			(Task)huf0FFpkcqpsW3nFbtZG(this, D1A4mXpkOmf17WFsJOO6(-1076846736 ^ -1076773718))
		});
	}

	public override Task ReceiveReminder(string reminderName)
	{
		//Discarded unreachable code: IL_008c, IL_009b
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 2:
				return (Task)SXvvqFpkFyrp0FNIjKeB();
			default:
				timerDisposer = RegisterTimer(OnTimer, null, TimeSpan.Zero, TimeSpan.FromSeconds(SR.GetSetting((string)D1A4mXpkOmf17WFsJOO6(-179348817 ^ -179406523), 10)));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (timerDisposer != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public Task AddUsersToImport(ICollection<string> userNames, ICollection<long> groupIds, Guid authProviderUid)
	{
		externalMembershipImportManager.AddUsersToImportInternal(userNames, groupIds, authProviderUid);
		return Start();
	}

	public Task ImportComplete()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				DeactivateOnIdle();
				num2 = 3;
				break;
			default:
				timerDisposer = null;
				num2 = 4;
				break;
			case 3:
				return UnregisterReminder((string)D1A4mXpkOmf17WFsJOO6(0x46347DA6 ^ 0x46355E7C));
			case 2:
			{
				IDisposable disposable = timerDisposer;
				if (disposable == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
					{
						num2 = 1;
					}
					break;
				}
				s7xrFRpk0eMW63sEoVsN(disposable);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnTimer_003Ed__8))]
	private Task OnTimer(object _)
	{
		int num = 5;
		int num2 = num;
		_003COnTimer_003Ed__8 stateMachine = default(_003COnTimer_003Ed__8);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				stateMachine._003C_003Et__builder = QZlco5pkEun1MFPaAJgj();
				num2 = 2;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 3;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void SHMBW3pkhe7hGRbp4B9I()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool rNDIi8pkK3kKirGK30if()
	{
		return QXLt8IpkJBtqJjHSuNFK == null;
	}

	internal static ExternalMembershipImportManagerActor NPW66opktMjewMhCdvMh()
	{
		return QXLt8IpkJBtqJjHSuNFK;
	}

	internal static object D1A4mXpkOmf17WFsJOO6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static TimeSpan TcfOd7pkqKgi7n5Dte7J(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static object huf0FFpkcqpsW3nFbtZG(object P_0, object P_1)
	{
		return ((Actor)P_0).ReceiveReminder((string)P_1);
	}

	internal static object Ae5m0fpkGLAQJYj1CJfF(object P_0)
	{
		return Task.WhenAll((Task[])P_0);
	}

	internal static object SXvvqFpkFyrp0FNIjKeB()
	{
		return Task.CompletedTask;
	}

	internal static void s7xrFRpk0eMW63sEoVsN(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static AsyncTaskMethodBuilder QZlco5pkEun1MFPaAJgj()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static void zNTp9TpkDeZlJ7P0KLZj(object P_0)
	{
		((ExternalMembershipImportManager)P_0).ImportUsersInternal();
	}
}
