using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models.Certificates;
using EleWise.ELMA.Deploy.Utils;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Actors;

internal sealed class ExportActor : Actor, IExportActor, IActorWithGuidKey, IActor
{
	private readonly IAuthenticationService authenticationService;

	private List<DeployLogMessage> log;

	private bool isStarted;

	private CancellationTokenSource cts;

	private Task externalTask;

	private static ExportActor z8trq1EzeLm76r4spNGQ;

	public ExportActor(IAuthenticationService authenticationService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VRQCuVEzN0y2eg7jRBDq();
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
			case 1:
				this.authenticationService = authenticationService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnDeactivateAsync_003Ed__6))]
	public override Task OnDeactivateAsync()
	{
		int num = 1;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003COnDeactivateAsync_003Ed__6 stateMachine = default(_003COnDeactivateAsync_003Ed__6);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			default:
				stateMachine._003C_003Et__builder = mOgZECEz3n6reY6VqAGI();
				num2 = 3;
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Task<IEnumerable<DeployLogMessage>> GetLog(int offset, int count)
	{
		if (log == null)
		{
			return Task.FromResult(Enumerable.Empty<DeployLogMessage>());
		}
		return Task.FromResult(DeployUtils.SafeSkip(log, offset, count));
	}

	public Task Export(ConfigExportSettings settings)
	{
		return Export(settings, null, null);
	}

	public Task Export(ConfigExportSettings settings, byte[] certificate, string password)
	{
		//Discarded unreachable code: IL_00bd, IL_00cc
		int num = 8;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass9_.settings = settings;
					num2 = 3;
					continue;
				case 7:
					_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					log = new List<DeployLogMessage>();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 7;
					continue;
				case 10:
					return (Task)Fp6st4EzpG35g49wBONT();
				case 3:
					if (!isStarted)
					{
						num = 9;
						break;
					}
					goto case 1;
				case 6:
					externalTask = RunExternalTask(_003C_003Ec__DisplayClass9_._003CExport_003Eb__0);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					cts = new CancellationTokenSource();
					num = 4;
					break;
				case 1:
					return (Task)Fp6st4EzpG35g49wBONT();
				case 9:
					isStarted = true;
					num2 = 2;
					continue;
				case 4:
					_003C_003Ec__DisplayClass9_.certificateContainer = ((certificate == null) ? null : new CSPCertificateContainer(certificate, password));
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	internal static void VRQCuVEzN0y2eg7jRBDq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool E2GqLHEzP6sCRC0bcN2j()
	{
		return z8trq1EzeLm76r4spNGQ == null;
	}

	internal static ExportActor Fd7YixEz1TbFBvUee2mm()
	{
		return z8trq1EzeLm76r4spNGQ;
	}

	internal static AsyncTaskMethodBuilder mOgZECEz3n6reY6VqAGI()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static object Fp6st4EzpG35g49wBONT()
	{
		return Task.CompletedTask;
	}
}
