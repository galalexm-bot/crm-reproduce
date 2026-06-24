using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Deploy.Utils;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Actors;

internal sealed class ImportExecutorActor : Actor, IImportExecutorActor, IActorWithGuidKey, IActor
{
	internal static readonly string StateKey;

	internal static readonly string TimestampKey;

	private readonly IAuthenticationService authenticationService;

	private readonly IBLOBStore blobStore;

	private readonly IExportImportFileService fileService;

	private readonly IDeployManager deployManager;

	private readonly ITimestampService timestampService;

	private readonly IConfigurationImportInternalFactory configurationImportInternalFactory;

	private List<DeployLogMessage> log;

	private List<DeploySystemMessage> systemMessages;

	private bool isStarted;

	private CancellationTokenSource cts;

	private Task externalTask;

	private ContinuedImportState continuedImportState;

	private static ImportExecutorActor LocliPEzzG8o2rWpsNP5;

	public ImportExecutorActor(IAuthenticationService authenticationService, IBLOBStore blobStore, IExportImportFileService fileService, IDeployManager deployManager, ITimestampService timestampService, IConfigurationImportInternalFactory configurationImportInternalFactory)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				this.timestampService = timestampService;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 6;
				}
				break;
			case 4:
				this.authenticationService = authenticationService;
				num = 2;
				break;
			case 2:
				this.blobStore = blobStore;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 6:
				this.configurationImportInternalFactory = configurationImportInternalFactory;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num = 0;
				}
				break;
			case 5:
				this.deployManager = deployManager;
				num = 3;
				break;
			case 1:
				this.fileService = fileService;
				num = 5;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnDeactivateAsync_003Ed__15))]
	public override Task OnDeactivateAsync()
	{
		int num = 2;
		_003COnDeactivateAsync_003Ed__15 stateMachine = default(_003COnDeactivateAsync_003Ed__15);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					stateMachine._003C_003E1__state = -1;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					stateMachine._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 3;
					continue;
				case 3:
					return stateMachine._003C_003Et__builder.Task;
				case 1:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				}
				break;
			}
			_003C_003Et__builder = stateMachine._003C_003Et__builder;
			num = 5;
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

	public Task<IEnumerable<DeployLogMessage>> GetLastLog(int count)
	{
		if (log == null || count <= 0)
		{
			return Task.FromResult(Enumerable.Empty<DeployLogMessage>());
		}
		count = Math.Min(count, log.Count);
		int offset = log.Count - count;
		return Task.FromResult(DeployUtils.SafeSkip(log, offset, count));
	}

	public Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(int offset, int count)
	{
		if (systemMessages == null)
		{
			return Task.FromResult(Enumerable.Empty<DeploySystemMessage>());
		}
		return Task.FromResult(DeployUtils.SafeSkip(systemMessages, offset, count));
	}

	public Task Import(IImportSettings settings)
	{
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass19_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 3:
				_003C_003Ec__DisplayClass19_.settings = settings;
				num2 = 6;
				break;
			case 5:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				num2 = 4;
				break;
			case 6:
				if (isStarted)
				{
					num2 = 2;
					break;
				}
				PrepareToStart();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return (Task)meI7oAfFWdAvtbUBB2Qi();
			case 1:
				externalTask = RunExternalTask(_003C_003Ec__DisplayClass19_._003CImport_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (Task)meI7oAfFWdAvtbUBB2Qi();
			}
		}
	}

	public Task<bool> IsActive()
	{
		return Task.FromResult(isStarted || HasContinuedImport());
	}

	public Task ContinuedImport(IEnumerable<IConfigImportSettings> settings)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals0.settings = settings;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (isStarted)
		{
			return Task.CompletedTask;
		}
		PrepareToStart();
		externalTask = RunExternalTask(delegate
		{
			int num = 4;
			BPMAppFakeManifest[] manifests = default(BPMAppFakeManifest[]);
			while (true)
			{
				int num2 = num;
				IEnumerable<BPMAppFakeManifest> source;
				Func<BPMAppFakeManifest, bool> predicate;
				while (true)
				{
					switch (num2)
					{
					case 1:
						CS_0024_003C_003E8__locals0._003C_003E4__this.isStarted = false;
						num2 = 2;
						break;
					default:
						if (new ContinuedImporter(CS_0024_003C_003E8__locals0._003C_003E4__this.continuedImportState, CS_0024_003C_003E8__locals0._003C_003E4__this.CreateRunImportParameters(_003C_003Ec__DisplayClass21_0.vAQI488JWepso9qbwVwV(CS_0024_003C_003E8__locals0._003C_003E4__this.continuedImportState)), CS_0024_003C_003E8__locals0._003C_003E4__this.blobStore, CS_0024_003C_003E8__locals0._003C_003E4__this.fileService, CS_0024_003C_003E8__locals0._003C_003E4__this.deployManager, CS_0024_003C_003E8__locals0._003C_003E4__this.configurationImportInternalFactory).ExecuteImport())
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num2 = 5;
							}
							break;
						}
						goto case 1;
					case 5:
						CS_0024_003C_003E8__locals0._003C_003E4__this.FinishImport();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 1;
						}
						break;
					case 2:
						return Task.CompletedTask;
					case 4:
						source = CS_0024_003C_003E8__locals0.settings.Select((IConfigImportSettings s) => s.FakeManifest);
						predicate = (BPMAppFakeManifest m) => m != null;
						goto end_IL_0012;
					case 3:
					{
						ImportExecutorActor _003C_003E4__this = CS_0024_003C_003E8__locals0._003C_003E4__this;
						IUser currentUser = CS_0024_003C_003E8__locals0._003C_003E4__this.authenticationService.GetCurrentUser();
						_003C_003E4__this.continuedImportState = new ContinuedImportState(((currentUser != null) ? _003C_003Ec__DisplayClass21_0.V6O2b08JBDCxGFYmerk1(currentUser) : null) as long?, CS_0024_003C_003E8__locals0.settings, manifests);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						break;
					}
					}
					continue;
					end_IL_0012:
					break;
				}
				manifests = source.Where(predicate).ToArray();
				num = 3;
			}
		});
		return Task.CompletedTask;
	}

	public Task ContinueImport()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (isStarted)
				{
					num2 = 2;
					continue;
				}
				PrepareToStart();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return Task.CompletedTask;
			case 2:
				return (Task)meI7oAfFWdAvtbUBB2Qi();
			}
			externalTask = RunExternalTask(delegate
			{
				//Discarded unreachable code: IL_0041, IL_0099, IL_01c2, IL_0219, IL_0228
				switch (1)
				{
				case 1:
					try
					{
						byte[] array = (byte[])lbuRVwfFEWxVxvhb9ImP(blobStore, StateKey);
						int num3 = 8;
						Task result = default(Task);
						while (true)
						{
							switch (num3)
							{
							case 8:
								if (array == null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 5;
							case 2:
								FinishImport();
								num3 = 7;
								continue;
							case 1:
								FinishImport();
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num3 = 3;
								}
								continue;
							case 6:
								if (new ContinuedImporter(continuedImportState, CreateRunImportParameters(continuedImportState.UserId), blobStore, fileService, deployManager, configurationImportInternalFactory).ExecuteImport())
								{
									num3 = 2;
									continue;
								}
								break;
							case 5:
								continuedImportState = (ContinuedImportState)PULCApfFfLaTDBKCEZ2n(array);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								result = (Task)meI7oAfFWdAvtbUBB2Qi();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								log.AddRange(continuedImportState.LogMessages);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num3 = 6;
								}
								continue;
							case 7:
								break;
							default:
								return result;
							case 0:
								return result;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								HuF9iZfFvtVtimUobrt0(qHjdhZfFQHOZ3kNeteuB(), PmsumkfFCC7WSvYYja57(XVuoNgfFGwByBUS7qSUC(-210725949 ^ -210395947)), ex);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					break;
				}
				return (Task)meI7oAfFWdAvtbUBB2Qi();
			});
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num2 = 1;
			}
		}
	}

	public Task<IEnumerable<BPMAppFakeManifest>> GetFakeManifests()
	{
		return Task.FromResult((IEnumerable<BPMAppFakeManifest>)(continuedImportState?.Manifests));
	}

	private bool HasContinuedImport()
	{
		return blobStore.LoadOrNull(StateKey) != null;
	}

	private void FinishImport()
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
				isStarted = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				blobStore.Save(TimestampKey, (byte[])uSv8iSfFbUSEUh0I994N(GyPABkfFo4MQ5dvit8xC(timestampService)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void PrepareToStart()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				systemMessages = new List<DeploySystemMessage>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				log = new List<DeployLogMessage>();
				num2 = 4;
				break;
			case 3:
				isStarted = true;
				num2 = 2;
				break;
			default:
				cts = new CancellationTokenSource();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private IRunImportParameters CreateRunImportParameters(long? userId)
	{
		return new RunImportParameters(userId, log, systemMessages, cts.Token);
	}

	public Task<IContinuedImportState> GetImportState()
	{
		return Task.FromResult((IContinuedImportState)continuedImportState);
	}

	static ImportExecutorActor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				JAyQb3fFhJr49H1UTTTr();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				TimestampKey = (string)XVuoNgfFGwByBUS7qSUC(-787452571 ^ -787127391);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			case 1:
				StateKey = (string)XVuoNgfFGwByBUS7qSUC(0x1C9495B4 ^ 0x1C919BDE);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool dNBL2lfFFC2GikRKNEd2()
	{
		return LocliPEzzG8o2rWpsNP5 == null;
	}

	internal static ImportExecutorActor eiRCPvfFBwx7ivDuTyK1()
	{
		return LocliPEzzG8o2rWpsNP5;
	}

	internal static object meI7oAfFWdAvtbUBB2Qi()
	{
		return Task.CompletedTask;
	}

	internal static long GyPABkfFo4MQ5dvit8xC(object P_0)
	{
		return ((ITimestampService)P_0).GetTimestamp();
	}

	internal static object uSv8iSfFbUSEUh0I994N(long P_0)
	{
		return BitConverter.GetBytes(P_0);
	}

	internal static void JAyQb3fFhJr49H1UTTTr()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object XVuoNgfFGwByBUS7qSUC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lbuRVwfFEWxVxvhb9ImP(object P_0, object P_1)
	{
		return ((IBLOBStore)P_0).LoadOrNull((string)P_1);
	}

	internal static object PULCApfFfLaTDBKCEZ2n(object P_0)
	{
		return ClassSerializationHelper.DeserializeObject((byte[])P_0);
	}

	internal static object qHjdhZfFQHOZ3kNeteuB()
	{
		return Logger.Log;
	}

	internal static object PmsumkfFCC7WSvYYja57(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void HuF9iZfFvtVtimUobrt0(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
