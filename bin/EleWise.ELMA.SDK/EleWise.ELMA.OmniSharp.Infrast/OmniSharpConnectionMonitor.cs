using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp.Infrastructure;

internal class OmniSharpConnectionMonitor : IConnectionMonitor, IDisposable
{
	private Timer pingTimer;

	private readonly int isAliveCheckPeriod;

	private readonly ILogger logger;

	private readonly SimpleWebClient client;

	private volatile bool isOffline;

	private bool lastStatus;

	internal static OmniSharpConnectionMonitor ewO0LdWrQeRTelyv6iph;

	public bool IsOffline => isOffline;

	public OmniSharpConnectionMonitor(SimpleWebClient client, ILogger logger, int isAliveCheckPeriod = 2)
	{
		//Discarded unreachable code: IL_0028, IL_002d
		lP66HFWr8GkZums7qhvG();
		isOffline = true;
		base._002Ector();
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 6:
				Cxg4gxWru5og9uSkZZBD(client, TgUXDEWrZI3MAffxWSTr(-867826612 ^ -867946186));
				num = 4;
				break;
			default:
				this.isAliveCheckPeriod = isAliveCheckPeriod;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num = 7;
				}
				break;
			case 3:
				return;
			case 4:
				Cxg4gxWru5og9uSkZZBD(logger, TgUXDEWrZI3MAffxWSTr(--1867379187 ^ 0x6F4FC479));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.logger = logger;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 0;
				}
				break;
			case 7:
				this.client = client;
				num = 5;
				break;
			case 1:
				Contract.CheckArgument(isAliveCheckPeriod > 0, (string)TgUXDEWrZI3MAffxWSTr(0x1A33FE36 ^ 0x1A31CBAC));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 2;
				}
				break;
			case 5:
				pingTimer = new Timer(Ping, null, mrClaxWrIkgHVXUiiVdH(isAliveCheckPeriod), Timeout.InfiniteTimeSpan);
				num = 3;
				break;
			}
		}
	}

	public void Dispose()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				Timer timer = pingTimer;
				if (timer == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				}
				GvtJmZWrV5vk8x9AR9Rb(timer);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
			case 3:
				pingTimer = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPing_003Ed__11))]
	private void Ping(object state)
	{
		int num = 4;
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		_003CPing_003Ed__11 stateMachine = default(_003CPing_003Ed__11);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return;
				default:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 2;
					continue;
				case 3:
					stateMachine._003C_003Et__builder = luqT68WrSQLgmNZCH3o4();
					num2 = 5;
					continue;
				case 4:
					break;
				case 5:
					stateMachine._003C_003E1__state = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			stateMachine._003C_003E4__this = this;
			num = 3;
		}
	}

	[AsyncStateMachine(typeof(_003CIsAlive_003Ed__12))]
	private Task<bool> IsAlive()
	{
		_003CIsAlive_003Ed__12 stateMachine = default(_003CIsAlive_003Ed__12);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static void lP66HFWr8GkZums7qhvG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object TgUXDEWrZI3MAffxWSTr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Cxg4gxWru5og9uSkZZBD(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static TimeSpan mrClaxWrIkgHVXUiiVdH(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static bool HU50CpWrCiyg8sDFEwqD()
	{
		return ewO0LdWrQeRTelyv6iph == null;
	}

	internal static OmniSharpConnectionMonitor yEirvLWrvRo6e58AHZQf()
	{
		return ewO0LdWrQeRTelyv6iph;
	}

	internal static void GvtJmZWrV5vk8x9AR9Rb(object P_0)
	{
		((Timer)P_0).Dispose();
	}

	internal static AsyncVoidMethodBuilder luqT68WrSQLgmNZCH3o4()
	{
		return AsyncVoidMethodBuilder.Create();
	}
}
