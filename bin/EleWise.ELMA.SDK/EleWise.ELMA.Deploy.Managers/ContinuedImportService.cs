using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Managers;

[Service]
internal sealed class ContinuedImportService : IContinuedImportService
{
	private readonly ConcurrentDictionary<Guid, int> logMessages;

	private readonly IExportImportService exportImportService;

	private readonly IModuleFileDeployServiceExtended moduleFileDeployService;

	private readonly IConfigurationUnpackService configurationUnpackService;

	private static ContinuedImportService Qmkmn9EDzNsjaNQxr3MB;

	public ContinuedImportService(IExportImportService exportImportService, IModuleFileDeployServiceExtended moduleFileDeployService, IConfigurationUnpackService configurationUnpackService)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		logMessages = new ConcurrentDictionary<Guid, int>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.moduleFileDeployService = moduleFileDeployService;
				num = 3;
				break;
			case 1:
				this.exportImportService = exportImportService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 2;
				}
				break;
			case 0:
				return;
			case 3:
				this.configurationUnpackService = configurationUnpackService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Task<Guid> Import(IEnumerable<Guid> testUids, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		return exportImportService.ContinuedImport(testUids);
	}

	public Task<IEnumerable<Guid>> Test(BinaryFile configFile, CancellationToken cancellationToken)
	{
		return Test(configFile, null, cancellationToken);
	}

	[AsyncStateMachine(typeof(_003CTest_003Ed__7))]
	public Task<IEnumerable<Guid>> Test(BinaryFile configFile, string activationKey, CancellationToken cancellationToken)
	{
		_003CTest_003Ed__7 stateMachine = default(_003CTest_003Ed__7);
		stateMachine._003C_003E4__this = this;
		stateMachine.configFile = configFile;
		stateMachine.activationKey = activationKey;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<Guid>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable<Guid>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task<IEnumerable<BPMAppFakeManifest>> GetImportManifests(Guid uid, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		return exportImportService.GetImportManifests(uid);
	}

	public Task<List<TestImportMessages>> GetTestLog(Guid testUid, CancellationToken cancellationToken)
	{
		return GetLog(testUid, logMessages, exportImportService.GetTestLog);
	}

	public Task<IEnumerable<IImportSettings>> GetImportSettings(Guid testUid)
	{
		return exportImportService.GetImportSettings(testUid);
	}

	[AsyncStateMachine(typeof(_003CGetLog_003Ed__11<>))]
	private Task<List<T>> GetLog<T>(Guid sessionId, ConcurrentDictionary<Guid, int> messageCountDictionary, Func<Guid, int, int, Task<IEnumerable<T>>> getLogsFunc)
	{
		_003CGetLog_003Ed__11<T> stateMachine = default(_003CGetLog_003Ed__11<T>);
		stateMachine.sessionId = sessionId;
		stateMachine.messageCountDictionary = messageCountDictionary;
		stateMachine.getLogsFunc = getLogsFunc;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<List<T>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<List<T>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool jVpD7LEtFdcJTVoB02Rt()
	{
		return Qmkmn9EDzNsjaNQxr3MB == null;
	}

	internal static ContinuedImportService Q7FLehEtBeaa7X2ma9ML()
	{
		return Qmkmn9EDzNsjaNQxr3MB;
	}
}
