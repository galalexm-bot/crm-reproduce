using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.Modules;

internal sealed class Importer
{
	private readonly IExportImportService exportImportService;

	private readonly ILogger logger;

	private readonly IModuleManager moduleManager;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private static Importer YGlYoUEMb4hVsGbpar1s;

	public Importer(IExportImportService exportImportService, IModuleManager moduleManager, IModuleMetadataLoader moduleMetadataLoader, ILogger logger)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kaWW9REMECDCltir10la();
		base._002Ector();
		int num = 4;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				this.moduleManager = moduleManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 2;
				break;
			case 4:
				this.exportImportService = exportImportService;
				num = 3;
				break;
			case 1:
				return;
			case 2:
				this.logger = logger;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CImport_003Ed__6))]
	public Task Import(IReadOnlyCollection<IConfigImportSettings> configImportSettings)
	{
		_003CImport_003Ed__6 stateMachine = default(_003CImport_003Ed__6);
		stateMachine._003C_003E4__this = this;
		stateMachine.configImportSettings = configImportSettings;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CTestImport_003Ed__7))]
	public Task<IReadOnlyCollection<ModuleImportSettings>> TestImport(Guid testUid, IEnumerable<IConfigImportSettings> configImportSettings, bool clearAfterTest)
	{
		_003CTestImport_003Ed__7 stateMachine = default(_003CTestImport_003Ed__7);
		stateMachine._003C_003E4__this = this;
		stateMachine.testUid = testUid;
		stateMachine.configImportSettings = configImportSettings;
		stateMachine.clearAfterTest = clearAfterTest;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IReadOnlyCollection<ModuleImportSettings>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IReadOnlyCollection<ModuleImportSettings>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CImportConfiguration_003Ed__8))]
	private Task<bool> ImportConfiguration(IReadOnlyCollection<IConfigImportSettings> configImportSettings)
	{
		_003CImportConfiguration_003Ed__8 stateMachine = default(_003CImportConfiguration_003Ed__8);
		stateMachine._003C_003E4__this = this;
		stateMachine.configImportSettings = configImportSettings;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void ProcessBPMAppInfo(IReadOnlyDictionary<string, ElmaStoreComponentManifest> oldManifests, IEnumerable<ElmaStoreComponentManifest> newManifests)
	{
		foreach (ElmaStoreComponentManifest newManifest in newManifests)
		{
			if (oldManifests.ContainsKey(newManifest.Id))
			{
				ElmaStoreComponentManifest elmaStoreComponentManifest = oldManifests[newManifest.Id];
				if (!(newManifest.SemanticVersion > elmaStoreComponentManifest.SemanticVersion))
				{
					ManifestStoreComponentInfo info = new ManifestStoreComponentInfo(null, elmaStoreComponentManifest, null, null);
					moduleManager.SaveStoreComponentInfo(info, StoreComponentStatus.Active);
				}
			}
		}
	}

	private bool ProcessImportLog(IEnumerable<DeployLogMessage> messages)
	{
		bool result = true;
		foreach (DeployLogMessage message in messages)
		{
			switch (message.MessageType)
			{
			case DeployLogMessageType.Error:
				Error(message.MessageText);
				result = false;
				continue;
			case DeployLogMessageType.Warn:
				Warn(message.MessageText);
				continue;
			case DeployLogMessageType.SystemImportStatus:
				if (message.ImportStatus == BPMAppItemImportStatus.Error)
				{
					Error(message.MessageText);
					result = false;
					continue;
				}
				break;
			}
			Trace(message.MessageText);
		}
		return result;
	}

	private void ProcessTestLog(IEnumerable<TestImportMessages> messages)
	{
		foreach (TestImportMessages message in messages)
		{
			switch (message.Type)
			{
			case TestImportMessagesType.Warning:
				Warn(message.Text);
				break;
			case TestImportMessagesType.Error:
				Error(message.Text);
				break;
			default:
				Info(message.Text);
				break;
			}
		}
	}

	private void Error(string message)
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
				logger.Log(LogLevel.Error, null, message ?? string.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Info(string message)
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
				logger.Log(LogLevel.Information, null, message ?? string.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Trace(string message)
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
				logger.Log(LogLevel.Trace, null, message ?? string.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Warn(string message)
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
				logger.Log(LogLevel.Warning, null, message ?? string.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void kaWW9REMECDCltir10la()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool aQR5AwEMh0bghiwXCZtq()
	{
		return YGlYoUEMb4hVsGbpar1s == null;
	}

	internal static Importer iVNIf9EMGs1AYBiMJD7P()
	{
		return YGlYoUEMb4hVsGbpar1s;
	}
}
